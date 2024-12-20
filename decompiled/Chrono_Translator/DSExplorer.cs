using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Chrono_Translator;

internal class DSExplorer
{
	public delegate void DirReadyD(int DirID, int ParentID, string DirName, bool IsRoot);

	public delegate void FileReadyD(int FileID, string ParentID, string FileName, uint position);

	public delegate void ROMIsReadyD(long TimeTakenMS);

	public uint FATOffset;

	public uint FATSize;

	public ushort FileCount;

	public Dictionary<string, ushort> FileIDs;

	public uint FileLastEnd;

	public Dictionary<ushort, string> FileNames;

	public Dictionary<ushort, uint> FileOffsets;

	public Dictionary<ushort, uint> FileSizes;

	public uint NTOffset;

	public uint NTSize;

	private FileStream rfs;

	public string ROMFilename;

	private Stopwatch TimeThis;

	public event DirReadyD DirReady;

	public event FileReadyD FileReady;

	public event ROMIsReadyD ROMIsReady;

	private void Async_LoadDir(string DirName, ushort DirID, ushort Parent)
	{
		long position = rfs.Position;
		checked
		{
			rfs.Seek(NTOffset + 8 * (DirID & 0xFFF), SeekOrigin.Begin);
			uint num = ReadUInt(rfs);
			ushort num2 = ReadUShort(rfs);
			ReadUShort(rfs);
			if (Parent == 0)
			{
				DirReady?.Invoke(61440, 0, "root", IsRoot: true);
			}
			else
			{
				DirReady?.Invoke(DirID, Parent, DirName, IsRoot: false);
			}
			rfs.Seek(NTOffset + num, SeekOrigin.Begin);
			ushort num3 = num2;
			while (true)
			{
				byte b = (byte)rfs.ReadByte();
				byte b2 = (byte)(b & 0x7F);
				if (b2 == 0)
				{
					break;
				}
				string text = ReadString(rfs, b2);
				if (b > 127)
				{
					ushort num4 = ReadUShort(rfs);
					Async_LoadDir(text, num4, num4);
				}
				else
				{
					Async_LoadFile(text, num3, DirName);
				}
				num3++;
			}
			rfs.Seek(position, SeekOrigin.Begin);
		}
	}

	private void Async_LoadFile(string FileName, ushort FileID, string Parent)
	{
		long position = rfs.Position;
		checked
		{
			rfs.Seek(FATOffset + FileID * 8, SeekOrigin.Begin);
			uint num = ReadUInt(rfs);
			uint num2 = ReadUInt(rfs);
			FileReady?.Invoke(FileID, Parent, FileName, (uint)(FATOffset + FileID * 8));
			FileIDs[FileName] = FileID;
			FileNames[FileID] = FileName;
			FileOffsets[FileID] = num;
			FileSizes[FileID] = num2 - num;
			if (num2 > FileLastEnd)
			{
				FileLastEnd = num2;
			}
			FileCount++;
			rfs.Seek(position, SeekOrigin.Begin);
		}
	}

	public void Async_LoadROM(string FileName)
	{
		TimeThis = new Stopwatch();
		TimeThis.Start();
		rfs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		rfs.Seek(64L, SeekOrigin.Begin);
		NTOffset = ReadUInt(rfs);
		NTSize = ReadUInt(rfs);
		FATOffset = ReadUInt(rfs);
		FATSize = ReadUInt(rfs);
		ROMFilename = FileName;
		if (FileIDs == null)
		{
			FileIDs = new Dictionary<string, ushort>();
			FileNames = new Dictionary<ushort, string>();
			FileOffsets = new Dictionary<ushort, uint>();
			FileSizes = new Dictionary<ushort, uint>();
		}
		FileIDs.Clear();
		FileNames.Clear();
		FileOffsets.Clear();
		FileSizes.Clear();
		Async_LoadDir("Root", 61440, 0);
		rfs.Dispose();
		TimeThis.Stop();
		ROMIsReady?.Invoke(TimeThis.ElapsedMilliseconds);
	}

	private TreeNode LoadDir(string DirName, ushort DirID, ushort Parent)
	{
		long position = rfs.Position;
		checked
		{
			rfs.Seek(NTOffset + 8 * (DirID & 0xFFF), SeekOrigin.Begin);
			uint num = ReadUInt(rfs);
			ushort num2 = ReadUShort(rfs);
			ReadUShort(rfs);
			TreeNode treeNode = null;
			if (Parent == 0)
			{
				treeNode = new TreeNode("root");
				treeNode.Name = "root";
				treeNode.Tag = 61440;
			}
			else
			{
				treeNode = new TreeNode(DirName);
				treeNode.Name = DirName;
				treeNode.Tag = NTOffset + 8 * (DirID & 0xFFF);
			}
			rfs.Seek(NTOffset + num, SeekOrigin.Begin);
			ushort num3 = num2;
			while (true)
			{
				byte b = (byte)rfs.ReadByte();
				byte b2 = (byte)(b & 0x7F);
				if (b2 == 0)
				{
					break;
				}
				string text = ReadString(rfs, b2);
				if (b > 127)
				{
					ushort num4 = ReadUShort(rfs);
					treeNode.Nodes.Add(LoadDir(text, num4, num4));
				}
				else
				{
					treeNode.Nodes.Add(LoadFile(text, num3, DirName));
				}
				num3++;
			}
			rfs.Seek(position, SeekOrigin.Begin);
			return treeNode;
		}
	}

	private TreeNode LoadFile(string FileName, ushort FileID, string Parent)
	{
		long position = rfs.Position;
		checked
		{
			rfs.Seek(FATOffset + FileID * 8, SeekOrigin.Begin);
			uint num = ReadUInt(rfs);
			uint num2 = ReadUInt(rfs);
			TreeNode treeNode = new TreeNode(FileName);
			treeNode.Name = FileName;
			treeNode.Tag = FATOffset + FileID * 8;
			FileIDs[FileName] = FileID;
			FileNames[FileID] = FileName;
			FileOffsets[FileID] = num;
			FileSizes[FileID] = num2 - num;
			if (num2 > FileLastEnd)
			{
				FileLastEnd = num2;
			}
			FileCount++;
			rfs.Seek(position, SeekOrigin.Begin);
			return treeNode;
		}
	}

	public TreeNode LoadROM(string FileName)
	{
		rfs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		rfs.Seek(64L, SeekOrigin.Begin);
		NTOffset = ReadUInt(rfs);
		NTSize = ReadUInt(rfs);
		FATOffset = ReadUInt(rfs);
		FATSize = ReadUInt(rfs);
		ROMFilename = FileName;
		if (FileIDs == null)
		{
			FileIDs = new Dictionary<string, ushort>();
			FileNames = new Dictionary<ushort, string>();
			FileOffsets = new Dictionary<ushort, uint>();
			FileSizes = new Dictionary<ushort, uint>();
		}
		FileIDs.Clear();
		FileNames.Clear();
		FileOffsets.Clear();
		FileSizes.Clear();
		return LoadDir("Root", 61440, 0);
	}

	public TreeNode[] LoadROM(string FileName, string[] dir)
	{
		TreeNode treeNode = LoadROM(FileName);
		TreeNode treeNode2 = new TreeNode("container");
		checked
		{
			if (treeNode != null)
			{
				treeNode2.Nodes.Add(treeNode);
				TreeNode[] array = null;
				foreach (string key in dir)
				{
					TreeNode[] array2 = treeNode2.Nodes.Find(key, searchAllChildren: true);
					if (array2.Length > 0)
					{
						TreeNode[] array3 = array2;
						foreach (TreeNode treeNode3 in array3)
						{
							array = ((array != null) ? ((TreeNode[])Utils.CopyArray(array, new TreeNode[array.Length + 1])) : new TreeNode[1]);
							array[array.Length - 1] = treeNode3;
						}
					}
				}
				return array;
			}
			return null;
		}
	}

	private string ReadString(FileStream fs, int StringLength)
	{
		if (StringLength == 0)
		{
			return "";
		}
		checked
		{
			byte[] array = new byte[StringLength - 1 + 1];
			fs.Read(array, 0, StringLength);
			StringBuilder stringBuilder = new StringBuilder(StringLength);
			int num = StringLength - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(Strings.Chr(array[i]));
			}
			return stringBuilder.ToString();
		}
	}

	private uint ReadUInt(FileStream fs)
	{
		byte[] array = new byte[4];
		fs.Read(array, 0, 4);
		uint num = array[0];
		checked
		{
			num += (uint)(array[1] * 256);
			num += (uint)(array[2] * 65536);
			return num + (uint)(array[3] * 16777216);
		}
	}

	private ushort ReadUShort(FileStream fs)
	{
		byte[] array = new byte[2];
		fs.Read(array, 0, 2);
		return checked((ushort)(array[0] + array[1] * 256));
	}

	private void WriteUInt(FileStream fs, uint WriteThis)
	{
		byte[] array = new byte[4];
		uint num = WriteThis;
		checked
		{
			array[0] = (byte)(unchecked((long)num) & 0xFFL);
			num >>= 8;
			array[1] = (byte)(unchecked((long)num) & 0xFFL);
			num >>= 8;
			array[2] = (byte)(unchecked((long)num) & 0xFFL);
			num >>= 8;
			array[3] = (byte)num;
			fs.Write(array, 0, 4);
		}
	}
}
