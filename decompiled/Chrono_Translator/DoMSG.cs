using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Chrono_Translator;

public class DoMSG
{
	public struct MSGINFO
	{
		public struct STRINGA
		{
			public byte[] value;

			public byte delimiter;
		}

		public uint unknow;

		public STRINGA[] value;
	}

	public static MSGINFO Extract(byte[] bytes, byte del)
	{
		MSGINFO result = default(MSGINFO);
		if (bytes == null)
		{
			return result;
		}
		if (bytes.Length < 16)
		{
			return result;
		}
		checked
		{
			int num = (int)(unchecked((uint)bytes[12]) + unchecked((uint)(bytes[13] << 8)) + unchecked((uint)(bytes[14] << 16)) + unchecked((uint)(bytes[15] << 24)));
			if (num != bytes.Length)
			{
				return result;
			}
			int num2 = 0;
			do
			{
				if (bytes[num2] != 0)
				{
					return result;
				}
				num2++;
			}
			while (num2 <= 3);
			if ((bytes[4] != 84) & (bytes[5] != 69) & (bytes[6] != 88) & (bytes[7] != 84))
			{
				return result;
			}
			int num3 = 0;
			MSGINFO result2 = default(MSGINFO);
			result2.unknow = unchecked((uint)bytes[8]) + unchecked((uint)(bytes[9] << 8)) + unchecked((uint)(bytes[10] << 16)) + unchecked((uint)(bytes[11] << 24));
			uint num4 = 16u;
			int num5 = (int)(unchecked((uint)bytes[12]) + unchecked((uint)(bytes[13] << 8)) + unchecked((uint)(bytes[14] << 16)) + unchecked((uint)(bytes[15] << 24)));
			if (num5 == bytes.Length)
			{
				num5 = num5;
			}
			int num6 = (int)(unchecked((uint)bytes[16]) + unchecked((uint)(bytes[17] << 8)) + unchecked((uint)(bytes[18] << 16)) + unchecked((uint)(bytes[19] << 24)));
			MSGINFO.STRINGA[] array = null;
			num2 = 0;
			while (num4 < num6)
			{
				array = ((array != null) ? ((MSGINFO.STRINGA[])Utils.CopyArray(array, new MSGINFO.STRINGA[array.Length + 1])) : new MSGINFO.STRINGA[1]);
				array[num2].delimiter = del;
				uint num7 = unchecked((uint)bytes[checked((int)num4)]) + unchecked((uint)(bytes[checked((int)(unchecked((long)num4) + 1L))] << 8)) + unchecked((uint)(bytes[checked((int)(unchecked((long)num4) + 2L))] << 16)) + unchecked((uint)(bytes[checked((int)(unchecked((long)num4) + 3L))] << 24));
				num4 = (uint)(unchecked((long)num4) + 4L);
				while (bytes[(int)num7] != array[num2].delimiter)
				{
					if (array[num2].value == null)
					{
						array[num2].value = new byte[1];
					}
					else
					{
						array[num2].value = (byte[])Utils.CopyArray(array[num2].value, new byte[array[num2].value.Length + 1]);
					}
					array[num2].value[array[num2].value.Length - 1] = bytes[(int)num7];
					num7 = (uint)(unchecked((long)num7) + 1L);
				}
				num2++;
			}
			result2.value = array;
			return result2;
		}
	}

	public static byte[] MakeMsg(MSGINFO msg)
	{
		checked
		{
			byte[] result;
			try
			{
				int num = 16 + msg.value.Length * 4;
				object obj = num;
				MSGINFO.STRINGA[] value = msg.value;
				for (int i = 0; i < value.Length; i++)
				{
					MSGINFO.STRINGA sTRINGA = value[i];
					num = ((sTRINGA.value != null) ? (num + sTRINGA.value.Length + 1) : (num + 1));
				}
				byte[] array = new byte[num - 1 + 1];
				array[0] = 0;
				array[1] = 0;
				array[2] = 0;
				array[3] = 0;
				array[4] = 84;
				array[5] = 69;
				array[6] = 88;
				array[7] = 84;
				array[8] = (byte)unchecked((long)msg.unknow % 256L);
				array[9] = (byte)unchecked((long)(msg.unknow >> 8) % 256L);
				array[10] = (byte)unchecked((long)(msg.unknow >> 16) % 256L);
				array[11] = (byte)unchecked((long)(msg.unknow >> 24) % 256L);
				array[12] = (byte)unchecked(num % 256);
				array[13] = (byte)unchecked((num >> 8) % 256);
				array[14] = (byte)unchecked((num >> 16) % 256);
				array[15] = (byte)unchecked((num >> 24) % 256);
				int num2 = 16;
				MSGINFO.STRINGA[] value2 = msg.value;
				for (int j = 0; j < value2.Length; j++)
				{
					MSGINFO.STRINGA sTRINGA2 = value2[j];
					array[num2] = Conversions.ToByte(Operators.ModObject(obj, 256));
					array[num2 + 1] = Conversions.ToByte(Operators.ModObject(Operators.RightShiftObject(obj, 8), 256));
					array[num2 + 2] = Conversions.ToByte(Operators.ModObject(Operators.RightShiftObject(obj, 16), 256));
					array[num2 + 3] = Conversions.ToByte(Operators.ModObject(Operators.RightShiftObject(obj, 24), 256));
					if (sTRINGA2.value != null)
					{
						int num3 = sTRINGA2.value.Length - 1;
						for (int k = 0; k <= num3; k++)
						{
							array[Conversions.ToInteger(obj)] = sTRINGA2.value[k];
							obj = Operators.AddObject(obj, 1);
						}
					}
					array[Conversions.ToInteger(obj)] = sTRINGA2.delimiter;
					obj = Operators.AddObject(obj, 1);
					num2 += 4;
				}
				result = array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
