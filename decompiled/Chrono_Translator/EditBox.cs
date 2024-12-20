using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Chrono_Translator.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Chrono_Translator;

[DesignerGenerated]
public class EditBox : UserControl
{
	private class dump
	{
		private int ind;

		private string testo;

		public int index => ind;

		public string text => testo;

		private dump()
		{
		}

		public dump(int index, string text)
		{
			ind = index;
			testo = text;
		}
	}

	public struct TABLE
	{
		public byte[] value;

		public string text;
	}

	private class ERRORE
	{
		private int pos;

		private string testo;

		private int len;

		public int position => pos;

		public string text => testo;

		public int length => len;

		private ERRORE()
		{
		}

		public ERRORE(int position, int length, string text)
		{
			pos = position;
			testo = text;
			len = length;
		}
	}

	private IContainer components;

	[AccessedThroughProperty("tblMain")]
	private TableLayoutPanel _tblMain;

	[AccessedThroughProperty("lswMessage")]
	private ListView _lswMessage;

	[AccessedThroughProperty("cmnLanguage")]
	private ColumnHeader _cmnLanguage;

	[AccessedThroughProperty("cmnText")]
	private ColumnHeader _cmnText;

	[AccessedThroughProperty("tlpUp")]
	private TableLayoutPanel _tlpUp;

	[AccessedThroughProperty("txtEdit")]
	private TextBox _txtEdit;

	[AccessedThroughProperty("cmnLength")]
	private ColumnHeader _cmnLength;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("flpCenter")]
	private FlowLayoutPanel _flpCenter;

	[AccessedThroughProperty("flpDown")]
	private FlowLayoutPanel _flpDown;

	[AccessedThroughProperty("btnExtract")]
	private Button _btnExtract;

	[AccessedThroughProperty("btnReinsert")]
	private Button _btnReinsert;

	[AccessedThroughProperty("btnSaveText")]
	private Button _btnSaveText;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("btnGetDump")]
	private Button _btnGetDump;

	[AccessedThroughProperty("btnSelect")]
	private Button _btnSelect;

	[AccessedThroughProperty("btnDump")]
	private Button _btnDump;

	private TABLE[] tbl;

	private TABLE[] s_tbl;

	private int selected;

	private int tipo;

	private uint unknow;

	private string nomemsg;

	private int versione;

	private bool modified;

	internal virtual TableLayoutPanel tblMain
	{
		get
		{
			return _tblMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tblMain = value;
		}
	}

	internal virtual ListView lswMessage
	{
		get
		{
			return _lswMessage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ColumnWidthChangingEventHandler value2 = lswMessage_ColumnWidthChanging;
			DrawListViewSubItemEventHandler value3 = lswMessage_DrawSubItem;
			DrawListViewColumnHeaderEventHandler value4 = lswMessage_DrawColumnHeader;
			EventHandler value5 = lswMessage_DoubleClick;
			if (_lswMessage != null)
			{
				_lswMessage.ColumnWidthChanging -= value2;
				_lswMessage.DrawSubItem -= value3;
				_lswMessage.DrawColumnHeader -= value4;
				_lswMessage.DoubleClick -= value5;
			}
			_lswMessage = value;
			if (_lswMessage != null)
			{
				_lswMessage.ColumnWidthChanging += value2;
				_lswMessage.DrawSubItem += value3;
				_lswMessage.DrawColumnHeader += value4;
				_lswMessage.DoubleClick += value5;
			}
		}
	}

	internal virtual ColumnHeader cmnLanguage
	{
		get
		{
			return _cmnLanguage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmnLanguage = value;
		}
	}

	internal virtual ColumnHeader cmnText
	{
		get
		{
			return _cmnText;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmnText = value;
		}
	}

	internal virtual TableLayoutPanel tlpUp
	{
		get
		{
			return _tlpUp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tlpUp = value;
		}
	}

	internal virtual TextBox txtEdit
	{
		get
		{
			return _txtEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = txtEdit_TextChanged;
			KeyPressEventHandler value3 = txtEdit_KeyPress;
			if (_txtEdit != null)
			{
				_txtEdit.TextChanged -= value2;
				_txtEdit.KeyPress -= value3;
			}
			_txtEdit = value;
			if (_txtEdit != null)
			{
				_txtEdit.TextChanged += value2;
				_txtEdit.KeyPress += value3;
			}
		}
	}

	internal virtual ColumnHeader cmnLength
	{
		get
		{
			return _cmnLength;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmnLength = value;
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual FlowLayoutPanel flpCenter
	{
		get
		{
			return _flpCenter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			PaintEventHandler value2 = flpCenter_Paint;
			if (_flpCenter != null)
			{
				_flpCenter.Paint -= value2;
			}
			_flpCenter = value;
			if (_flpCenter != null)
			{
				_flpCenter.Paint += value2;
			}
		}
	}

	internal virtual FlowLayoutPanel flpDown
	{
		get
		{
			return _flpDown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_flpDown = value;
		}
	}

	internal virtual Button btnExtract
	{
		get
		{
			return _btnExtract;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnExtract_Click;
			if (_btnExtract != null)
			{
				_btnExtract.Click -= value2;
			}
			_btnExtract = value;
			if (_btnExtract != null)
			{
				_btnExtract.Click += value2;
			}
		}
	}

	internal virtual Button btnReinsert
	{
		get
		{
			return _btnReinsert;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnReinsert_Click;
			if (_btnReinsert != null)
			{
				_btnReinsert.Click -= value2;
			}
			_btnReinsert = value;
			if (_btnReinsert != null)
			{
				_btnReinsert.Click += value2;
			}
		}
	}

	internal virtual Button btnSaveText
	{
		get
		{
			return _btnSaveText;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnSaveText_Click;
			if (_btnSaveText != null)
			{
				_btnSaveText.Click -= value2;
			}
			_btnSaveText = value;
			if (_btnSaveText != null)
			{
				_btnSaveText.Click += value2;
			}
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get
		{
			return _TableLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TableLayoutPanel1 = value;
		}
	}

	internal virtual Button btnGetDump
	{
		get
		{
			return _btnGetDump;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnGetDump_Click;
			if (_btnGetDump != null)
			{
				_btnGetDump.Click -= value2;
			}
			_btnGetDump = value;
			if (_btnGetDump != null)
			{
				_btnGetDump.Click += value2;
			}
		}
	}

	internal virtual Button btnSelect
	{
		get
		{
			return _btnSelect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnSelect = value;
		}
	}

	internal virtual Button btnDump
	{
		get
		{
			return _btnDump;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnDump_Click;
			if (_btnDump != null)
			{
				_btnDump.Click -= value2;
			}
			_btnDump = value;
			if (_btnDump != null)
			{
				_btnDump.Click += value2;
			}
		}
	}

	public EditBox()
	{
		base.Load += EditBox_Load;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.tblMain = new System.Windows.Forms.TableLayoutPanel();
		this.lswMessage = new System.Windows.Forms.ListView();
		this.cmnLanguage = new System.Windows.Forms.ColumnHeader();
		this.cmnLength = new System.Windows.Forms.ColumnHeader();
		this.cmnText = new System.Windows.Forms.ColumnHeader();
		this.tlpUp = new System.Windows.Forms.TableLayoutPanel();
		this.txtEdit = new System.Windows.Forms.TextBox();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.flpCenter = new System.Windows.Forms.FlowLayoutPanel();
		this.flpDown = new System.Windows.Forms.FlowLayoutPanel();
		this.btnSaveText = new System.Windows.Forms.Button();
		this.btnExtract = new System.Windows.Forms.Button();
		this.btnReinsert = new System.Windows.Forms.Button();
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.btnGetDump = new System.Windows.Forms.Button();
		this.btnSelect = new System.Windows.Forms.Button();
		this.btnDump = new System.Windows.Forms.Button();
		this.tblMain.SuspendLayout();
		this.tlpUp.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.flpDown.SuspendLayout();
		this.TableLayoutPanel1.SuspendLayout();
		this.SuspendLayout();
		this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
		this.tblMain.ColumnCount = 1;
		this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.tblMain.Controls.Add(this.lswMessage, 0, 0);
		this.tblMain.Controls.Add(this.tlpUp, 0, 1);
		this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel = this.tblMain;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		tableLayoutPanel.Location = location;
		this.tblMain.Name = "tblMain";
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel2 = this.tblMain;
		System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(2);
		tableLayoutPanel2.Padding = padding;
		this.tblMain.RowCount = 2;
		this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.2807f));
		this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.7193f));
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel3 = this.tblMain;
		System.Drawing.Size size = new System.Drawing.Size(690, 461);
		tableLayoutPanel3.Size = size;
		this.tblMain.TabIndex = 0;
		this.lswMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.cmnLanguage, this.cmnLength, this.cmnText });
		this.lswMessage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lswMessage.FullRowSelect = true;
		this.lswMessage.GridLines = true;
		this.lswMessage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.lswMessage.HideSelection = false;
		this.lswMessage.LabelWrap = false;
		System.Windows.Forms.ListView listView = this.lswMessage;
		location = new System.Drawing.Point(6, 6);
		listView.Location = location;
		this.lswMessage.MultiSelect = false;
		this.lswMessage.Name = "lswMessage";
		this.lswMessage.OwnerDraw = true;
		System.Windows.Forms.ListView listView2 = this.lswMessage;
		size = new System.Drawing.Size(678, 163);
		listView2.Size = size;
		this.lswMessage.TabIndex = 0;
		this.lswMessage.UseCompatibleStateImageBehavior = false;
		this.lswMessage.View = System.Windows.Forms.View.Details;
		this.cmnLanguage.Text = "Lang";
		this.cmnLanguage.Width = 48;
		this.cmnLength.Text = "Length";
		this.cmnLength.Width = 48;
		this.cmnText.Text = "Text";
		this.cmnText.Width = 553;
		this.tlpUp.ColumnCount = 1;
		this.tlpUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.tlpUp.Controls.Add(this.txtEdit, 0, 1);
		this.tlpUp.Controls.Add(this.Panel1, 0, 2);
		this.tlpUp.Controls.Add(this.flpDown, 0, 3);
		this.tlpUp.Controls.Add(this.TableLayoutPanel1, 0, 0);
		this.tlpUp.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel4 = this.tlpUp;
		location = new System.Drawing.Point(6, 176);
		tableLayoutPanel4.Location = location;
		this.tlpUp.Name = "tlpUp";
		this.tlpUp.RowCount = 4;
		this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29f));
		this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106f));
		this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36f));
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel5 = this.tlpUp;
		size = new System.Drawing.Size(678, 279);
		tableLayoutPanel5.Size = size;
		this.tlpUp.TabIndex = 1;
		this.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtEdit.HideSelection = false;
		System.Windows.Forms.TextBox textBox = this.txtEdit;
		location = new System.Drawing.Point(3, 32);
		textBox.Location = location;
		this.txtEdit.Multiline = true;
		this.txtEdit.Name = "txtEdit";
		this.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		System.Windows.Forms.TextBox textBox2 = this.txtEdit;
		size = new System.Drawing.Size(672, 100);
		textBox2.Size = size;
		this.txtEdit.TabIndex = 0;
		this.txtEdit.WordWrap = false;
		this.Panel1.AutoScroll = true;
		this.Panel1.Controls.Add(this.flpCenter);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.Panel panel = this.Panel1;
		location = new System.Drawing.Point(3, 138);
		panel.Location = location;
		this.Panel1.Name = "Panel1";
		System.Windows.Forms.Panel panel2 = this.Panel1;
		size = new System.Drawing.Size(672, 102);
		panel2.Size = size;
		this.Panel1.TabIndex = 4;
		this.flpCenter.AutoScroll = true;
		this.flpCenter.AutoSize = true;
		this.flpCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.flpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.FlowLayoutPanel flowLayoutPanel = this.flpCenter;
		location = new System.Drawing.Point(0, 0);
		flowLayoutPanel.Location = location;
		this.flpCenter.Name = "flpCenter";
		System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2 = this.flpCenter;
		padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
		flowLayoutPanel2.Padding = padding;
		System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3 = this.flpCenter;
		size = new System.Drawing.Size(672, 102);
		flowLayoutPanel3.Size = size;
		this.flpCenter.TabIndex = 0;
		this.flpDown.Controls.Add(this.btnSaveText);
		this.flpDown.Controls.Add(this.btnExtract);
		this.flpDown.Controls.Add(this.btnReinsert);
		this.flpDown.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4 = this.flpDown;
		location = new System.Drawing.Point(3, 246);
		flowLayoutPanel4.Location = location;
		this.flpDown.Name = "flpDown";
		System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5 = this.flpDown;
		size = new System.Drawing.Size(672, 30);
		flowLayoutPanel5.Size = size;
		this.flpDown.TabIndex = 5;
		System.Windows.Forms.Button button = this.btnSaveText;
		location = new System.Drawing.Point(3, 3);
		button.Location = location;
		this.btnSaveText.Name = "btnSaveText";
		System.Windows.Forms.Button button2 = this.btnSaveText;
		size = new System.Drawing.Size(176, 23);
		button2.Size = size;
		this.btnSaveText.TabIndex = 3;
		this.btnSaveText.Text = "Save Text (Not Permanently)";
		this.btnSaveText.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button3 = this.btnExtract;
		location = new System.Drawing.Point(185, 3);
		button3.Location = location;
		this.btnExtract.Name = "btnExtract";
		System.Windows.Forms.Button button4 = this.btnExtract;
		size = new System.Drawing.Size(138, 23);
		button4.Size = size;
		this.btnExtract.TabIndex = 0;
		this.btnExtract.Text = "Extract/Save MSG";
		this.btnExtract.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button5 = this.btnReinsert;
		location = new System.Drawing.Point(329, 3);
		button5.Location = location;
		this.btnReinsert.Name = "btnReinsert";
		System.Windows.Forms.Button button6 = this.btnReinsert;
		size = new System.Drawing.Size(124, 23);
		button6.Size = size;
		this.btnReinsert.TabIndex = 2;
		this.btnReinsert.Text = "ReInsert Current MSG";
		this.btnReinsert.UseVisualStyleBackColor = true;
		this.TableLayoutPanel1.ColumnCount = 3;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106f));
		this.TableLayoutPanel1.Controls.Add(this.btnGetDump, 2, 0);
		this.TableLayoutPanel1.Controls.Add(this.btnSelect, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.btnDump, 1, 0);
		this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel6 = this.TableLayoutPanel1;
		location = new System.Drawing.Point(0, 0);
		tableLayoutPanel6.Location = location;
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel7 = this.TableLayoutPanel1;
		padding = new System.Windows.Forms.Padding(0);
		tableLayoutPanel7.Margin = padding;
		this.TableLayoutPanel1.Name = "TableLayoutPanel1";
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel8 = this.TableLayoutPanel1;
		size = new System.Drawing.Size(678, 29);
		tableLayoutPanel8.Size = size;
		this.TableLayoutPanel1.TabIndex = 6;
		System.Windows.Forms.Button button7 = this.btnGetDump;
		location = new System.Drawing.Point(575, 3);
		button7.Location = location;
		this.btnGetDump.Name = "btnGetDump";
		System.Windows.Forms.Button button8 = this.btnGetDump;
		size = new System.Drawing.Size(98, 23);
		button8.Size = size;
		this.btnGetDump.TabIndex = 7;
		this.btnGetDump.Text = "Load Text Dump";
		this.btnGetDump.UseVisualStyleBackColor = true;
		this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.Button button9 = this.btnSelect;
		location = new System.Drawing.Point(3, 3);
		button9.Location = location;
		this.btnSelect.Name = "btnSelect";
		System.Windows.Forms.Button button10 = this.btnSelect;
		size = new System.Drawing.Size(460, 23);
		button10.Size = size;
		this.btnSelect.TabIndex = 4;
		this.btnSelect.Text = "Select Current Text Entry";
		this.btnSelect.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button11 = this.btnDump;
		location = new System.Drawing.Point(469, 3);
		button11.Location = location;
		this.btnDump.Name = "btnDump";
		System.Windows.Forms.Button button12 = this.btnDump;
		size = new System.Drawing.Size(98, 23);
		button12.Size = size;
		this.btnDump.TabIndex = 6;
		this.btnDump.Text = "Text Dump";
		this.btnDump.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.tblMain);
		size = new System.Drawing.Size(200, 200);
		this.MinimumSize = size;
		this.Name = "EditBox";
		size = new System.Drawing.Size(690, 461);
		this.Size = size;
		this.tblMain.ResumeLayout(false);
		this.tlpUp.ResumeLayout(false);
		this.tlpUp.PerformLayout();
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.flpDown.ResumeLayout(false);
		this.TableLayoutPanel1.ResumeLayout(false);
		this.ResumeLayout(false);
	}

	public void loadSmall(string file)
	{
		loadTables(file, ref s_tbl);
	}

	public void loadBig(string file)
	{
		loadTables(file, ref tbl);
	}

	private void loadTables(string file, ref TABLE[] tbl, bool append = false)
	{
		loadTables(new string[1] { file }, ref tbl, append);
	}

	private void loadTables(string[] file, ref TABLE[] tbl, bool append = false)
	{
		if (!append)
		{
			tbl = null;
		}
		if (file == null)
		{
			throw new Exception("no file definited");
		}
		int num = 0;
		checked
		{
			string[] array;
			try
			{
				array = File.ReadAllLines(file[num]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				throw new Exception("Impossible to load table\r\n" + Strings.Mid(file[num], file[num].LastIndexOf("\\") + 2));
			}
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (Operators.CompareString(text, "", TextCompare: false) == 0)
				{
					continue;
				}
				if (text.StartsWith(".include "))
				{
					FileInfo fileInfo = new FileInfo(file[num]);
					loadTables(fileInfo.DirectoryName + "\\" + Strings.Mid(text, 10), ref tbl, append: true);
					continue;
				}
				string[] array3 = text.Split('=');
				if (array3.Length > 0)
				{
					TABLE tABLE = default(TABLE);
					tABLE.value = new byte[unchecked(array3[0].Length / 2) - 1 + 1];
					int num2 = tABLE.value.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						tABLE.value[j] = (byte)Math.Round(Conversion.Val("&H" + Strings.Mid(array3[0], j * 2 + 1, 2)));
					}
					if (array3.Length == 3)
					{
						tABLE.text = "=";
					}
					else
					{
						tABLE.text = array3[1];
					}
					if (tbl == null)
					{
						tbl = new TABLE[1];
					}
					else
					{
						tbl = (TABLE[])Utils.CopyArray(tbl, new TABLE[tbl.Length + 1]);
					}
					tbl[tbl.Length - 1] = tABLE;
				}
			}
		}
	}

	public void Convert2String(DoMSG.MSGINFO msg, int type, string version, string nome, DirectoryInfo dir, bool extr = false)
	{
		lswMessage.Items.Clear();
		nomemsg = "";
		int num = 0;
		ListView listView = new ListView();
		DoMSG.MSGINFO.STRINGA[] value = msg.value;
		checked
		{
			for (int i = 0; i < value.Length; i++)
			{
				DoMSG.MSGINFO.STRINGA sTRINGA = value[i];
				string text = "";
				int num2 = 0;
				if (sTRINGA.value == null)
				{
					text = "";
				}
				else
				{
					while (num2 < sTRINGA.value.Length)
					{
						byte[] value2 = sTRINGA.value;
						TABLE[] tab = (TABLE[])Interaction.IIf(type == 0, tbl, s_tbl);
						TABLE tABLE = findTable(value2, ref tab, num2);
						if (tABLE.value == null)
						{
							string text2 = Conversion.Hex(sTRINGA.value[num2]);
							while (text2.Length < 2)
							{
								text2 = "0" + text2;
							}
							text = text + "{" + text2 + "}";
							num2++;
						}
						else
						{
							num2 += tABLE.value.Length;
							text += tABLE.text;
						}
					}
				}
				string text3 = "";
				unchecked
				{
					if (Operators.CompareString(version, Conversions.ToString(0), TextCompare: false) == 0)
					{
						switch (num % 4)
						{
						case 0:
							text3 = "L1";
							break;
						case 1:
							text3 = "EN";
							break;
						case 2:
							text3 = "L2";
							break;
						case 3:
							text3 = "FR";
							break;
						}
					}
					else if (Operators.CompareString(version, Conversions.ToString(1), TextCompare: false) == 0)
					{
						switch (num % 4)
						{
						case 0:
							text3 = "L1";
							break;
						case 1:
							text3 = "EN";
							break;
						case 2:
							text3 = "L2";
							break;
						case 3:
							text3 = "FR";
							break;
						}
					}
					else if (Operators.CompareString(version, Conversions.ToString(2), TextCompare: false) == 0)
					{
						switch (num % 2)
						{
						case 0:
							text3 = "JP";
							break;
						case 1:
							text3 = "EN";
							break;
						}
					}
				}
				num++;
				ListViewItem listViewItem = new ListViewItem(text3);
				try
				{
					Application.DoEvents();
					listViewItem.SubItems.Add(Conversions.ToString(sTRINGA.value.Length));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					listViewItem.SubItems.Add(Conversions.ToString(0));
					ProjectData.ClearProjectError();
				}
				text.Replace("&", "&&");
				listViewItem.SubItems.Add(text);
				if (!extr)
				{
					lswMessage.Items.Add(listViewItem);
				}
				else
				{
					listView.Items.Add(listViewItem);
				}
			}
			selected = -1;
			tipo = type;
			unknow = msg.unknow;
			nomemsg = nome;
			versione = Conversions.ToInteger(version);
			if (extr)
			{
				try
				{
					dumpMsg(ref listView, dir);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					clear1();
					throw ex4;
				}
				clear1();
			}
		}
	}

	private TABLE findTable(byte[] bytes, ref TABLE[] tab, int start, int index = 0)
	{
		TABLE[] tab2 = null;
		if (bytes == null)
		{
			return default(TABLE);
		}
		if (tab == null)
		{
			return default(TABLE);
		}
		checked
		{
			if (start + index > bytes.Length)
			{
				return default(TABLE);
			}
			if (tab.Length == 1)
			{
				if (start + tab[0].value.Length <= bytes.Length)
				{
					int num = tab[0].value.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (tab[0].value[i] != bytes[start + i])
						{
							return default(TABLE);
						}
					}
					return tab[0];
				}
				return default(TABLE);
			}
			TABLE[] array = tab;
			for (int j = 0; j < array.Length; j++)
			{
				TABLE tABLE = array[j];
				if (((index < tABLE.value.Length) & (start + index < bytes.Length)) && bytes[start + index] == tABLE.value[index])
				{
					tab2 = ((tab2 != null) ? ((TABLE[])Utils.CopyArray(tab2, new TABLE[tab2.Length + 1])) : new TABLE[1]);
					tab2[tab2.Length - 1] = tABLE;
				}
			}
			return findTable(bytes, ref tab2, start, index + 1);
		}
	}

	public byte[] Convert2Byte(string text, TABLE[] tbl)
	{
		if (Operators.CompareString(text, "", TextCompare: false) == 0)
		{
			return null;
		}
		byte[] array = null;
		bool flag = false;
		bool flag2 = false;
		string text2 = "";
		int num = 0;
		int length = text.Length;
		checked
		{
			for (int i = 1; i <= length; i++)
			{
				if (flag)
				{
					bool flag3 = false;
					text2 += Strings.Mid(text, i, 1);
					if (Operators.CompareString(Strings.Mid(text, i, 1), "}", TextCompare: false) != 0)
					{
						continue;
					}
					flag = false;
					for (int j = 0; j < tbl.Length; j++)
					{
						TABLE tABLE = tbl[j];
						if (Operators.CompareString(tABLE.text, text2, TextCompare: false) == 0)
						{
							array = ((array != null) ? ((byte[])Utils.CopyArray(array, new byte[array.Length + tABLE.value.Length - 1 + 1])) : new byte[tABLE.value.Length - 1 + 1]);
							byte[] value = tABLE.value;
							foreach (byte b in value)
							{
								array[num] = b;
								num++;
							}
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						try
						{
							byte b2 = Conversions.ToByte("&H" + Strings.Mid(text2, 2, 2));
							array = ((array != null) ? ((byte[])Utils.CopyArray(array, new byte[array.Length + 1])) : new byte[1]);
							array[num] = b2;
							num++;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					continue;
				}
				if (flag2)
				{
					for (int l = 0; l < tbl.Length; l++)
					{
						TABLE tABLE2 = tbl[l];
						if (Operators.CompareString(tABLE2.text, "\\" + Strings.Mid(text, i, 1), TextCompare: false) == 0)
						{
							array = ((array != null) ? ((byte[])Utils.CopyArray(array, new byte[array.Length + tABLE2.value.Length - 1 + 1])) : new byte[tABLE2.value.Length - 1 + 1]);
							byte[] value2 = tABLE2.value;
							foreach (byte b3 in value2)
							{
								array[num] = b3;
								num++;
							}
							break;
						}
					}
					flag2 = false;
					continue;
				}
				if (Operators.CompareString(Strings.Mid(text, i, 1), "\\", TextCompare: false) == 0)
				{
					flag2 = true;
					continue;
				}
				if (Operators.CompareString(Strings.Mid(text, i, 1), "{", TextCompare: false) == 0)
				{
					flag = true;
					text2 = "{";
					continue;
				}
				for (int n = 0; n < tbl.Length; n++)
				{
					TABLE tABLE3 = tbl[n];
					if (Operators.CompareString(tABLE3.text, Strings.Mid(text, i, 1), TextCompare: false) == 0)
					{
						array = ((array != null) ? ((byte[])Utils.CopyArray(array, new byte[array.Length + tABLE3.value.Length - 1 + 1])) : new byte[tABLE3.value.Length - 1 + 1]);
						byte[] value3 = tABLE3.value;
						foreach (byte b4 in value3)
						{
							array[num] = b4;
							num++;
						}
						break;
					}
				}
			}
			return array;
		}
	}

	private void lswMessage_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{
		if ((e.ColumnIndex == 0) | (e.ColumnIndex == 1) | ((e.ColumnIndex == 2) & (e.NewWidth < 200)))
		{
			e.Cancel = true;
			e.NewWidth = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "columns", new object[1] { e.ColumnIndex }, null, null, null), null, "Width", new object[0], null, null, null));
		}
	}

	private void EditBox_Load(object sender, EventArgs e)
	{
		nomemsg = "";
		lswMessage.Columns[2].Width = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "width", new object[0], null, null, null), 135));
		selected = -1;
		string[] array = null;
		try
		{
			array = File.ReadAllLines(Application.StartupPath + "\\tables\\list.txt");
			string[] array2 = array;
			foreach (string left in array2)
			{
				if (Operators.CompareString(left, "", TextCompare: false) != 0)
				{
					Button button = new Button();
					button.Font = new Font(button.Font.FontFamily, 10f, FontStyle.Regular, GraphicsUnit.Pixel);
					button.Text = left;
					button.AutoSize = true;
					Size size = new Size(10, 10);
					button.Size = size;
					button.Click += ButtEvent;
					flpCenter.Controls.Add(button);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ButtEvent(object sender, EventArgs e)
	{
		txtEdit.SelectedText = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
		txtEdit.Focus();
	}

	private void lswMessage_DoubleClick(object sender, EventArgs e)
	{
		ListView listView = (ListView)sender;
		if (listView.SelectedItems.Count == 1)
		{
			txtEdit.Text = listView.SelectedItems[0].SubItems[2].Text.Replace("&&", "&").Replace("\\n", "\r\n");
			selected = listView.SelectedIndices[0];
		}
	}

	private void lswMessage_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
	{
		e.DrawDefault = true;
	}

	private void lswMessage_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		e.DrawDefault = false;
		e.DrawBackground();
		HorizontalAlignment textAlign = e.Header.TextAlign;
		TextFormatFlags textFormatFlags = (TextFormatFlags)Conversions.ToInteger(Interaction.IIf(textAlign == HorizontalAlignment.Left, TextFormatFlags.Default, RuntimeHelpers.GetObjectValue(Interaction.IIf(textAlign == HorizontalAlignment.Center, TextFormatFlags.HorizontalCenter, TextFormatFlags.Right))));
		textFormatFlags = textFormatFlags;
		bool flag = false;
		checked
		{
			if (!e.Item.ListView.FullRowSelect)
			{
				if (((e.ItemState & ListViewItemStates.Focused) == ListViewItemStates.Focused) & e.Item.Selected & (e.Item.ListView.FullRowSelect | (e.Item.SubItems[0] == e.SubItem)))
				{
					flag = true;
					Rectangle rect = new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Header.Width, e.Bounds.Height);
					rect.Width = Left + 3;
					if (e.Item.ListView.FullRowSelect | (e.Item.SubItems[0] == e.SubItem))
					{
						e.Graphics.FillRectangle(SystemBrushes.Highlight, rect);
					}
				}
			}
			else if (Conversions.ToBoolean(Operators.AndObject(Operators.OrObject((e.ItemState & ListViewItemStates.Focused) == ListViewItemStates.Focused, Operators.CompareObjectEqual(NewLateBinding.LateGet(sender, null, "hideselection", new object[0], null, null, null), false, TextCompare: false)), e.Item.Selected)))
			{
				e.SubItem.BackColor = SystemColors.Highlight;
				e.SubItem.ForeColor = SystemColors.HighlightText;
			}
			else
			{
				ListViewItem.ListViewSubItem subItem = e.SubItem;
				object obj = Interaction.IIf(e.Item.ListView.Enabled, e.Item.ListView.BackColor, SystemColors.Control);
				Color color = default(Color);
				subItem.BackColor = ((obj != null) ? ((Color)obj) : color);
				e.SubItem.ForeColor = e.Item.ListView.ForeColor;
			}
			e.DrawText(textFormatFlags);
		}
	}

	private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	private void txtEdit_TextChanged(object sender, EventArgs e)
	{
		string text = "";
		int num = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null), null, "length", new object[0], null, null, null));
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			switch (Strings.Asc(Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)), i, 1)))
			{
			case 13:
				text += "\r\n";
				break;
			default:
				text += Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)), i, 1);
				break;
			case 10:
				break;
			}
		}
		int num2 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectionstart", new object[0], null, null, null));
		NewLateBinding.LateSet(sender, null, "Text", new object[1] { text }, null, null);
		NewLateBinding.LateSet(sender, null, "SelectionStart", new object[1] { num2 }, null, null);
	}

	private void btnSelect_Click(object sender, EventArgs e)
	{
		try
		{
			lswMessage.Items[selected].Selected = true;
			lswMessage.Items[0].Focused = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			foreach (ListViewItem selectedItem in lswMessage.SelectedItems)
			{
				selectedItem.Selected = false;
			}
			ProjectData.ClearProjectError();
		}
	}

	private void btnSaveText_Click(object sender, EventArgs e)
	{
		modified = false;
		if (selected >= 0)
		{
			string text = txtEdit.Text.Replace("\r", "\\n").Replace("\n", "");
			ERRORE eRRORE = checkText(text, (TABLE[])Interaction.IIf(tipo == 0, tbl, s_tbl));
			if (eRRORE != null)
			{
				Interaction.MsgBox(eRRORE.text);
				try
				{
					txtEdit.Focus();
					txtEdit.SelectionStart = eRRORE.position;
					txtEdit.SelectionLength = eRRORE.length;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox(ex2.Message);
					ProjectData.ClearProjectError();
					return;
				}
			}
			modified = true;
			lswMessage.Items[selected].SubItems[2].Text = text;
			lswMessage.Items[selected].SubItems[1].Text = Conversions.ToString(count(text, (TABLE[])Interaction.IIf(tipo == 0, tbl, s_tbl)));
		}
		else
		{
			Interaction.MsgBox("Nothing selected", MsgBoxStyle.Exclamation, "Error");
		}
	}

	private int count(string text, TABLE[] tbl)
	{
		bool flag = false;
		bool flag2 = false;
		string text2 = "";
		int num = 0;
		int length = text.Length;
		checked
		{
			for (int i = 1; i <= length; i++)
			{
				if (flag)
				{
					text2 += Strings.Mid(text, i, 1);
					if (Operators.CompareString(Strings.Mid(text, i, 1), "}", TextCompare: false) != 0)
					{
						continue;
					}
					flag = false;
					for (int j = 0; j < tbl.Length; j++)
					{
						TABLE tABLE = tbl[j];
						if (Operators.CompareString(tABLE.text, text2, TextCompare: false) == 0)
						{
							num += tABLE.value.Length;
							break;
						}
					}
					continue;
				}
				if (flag2)
				{
					for (int k = 0; k < tbl.Length; k++)
					{
						TABLE tABLE2 = tbl[k];
						if (Operators.CompareString(tABLE2.text, "\\" + Strings.Mid(text, i, 1), TextCompare: false) == 0)
						{
							num += tABLE2.value.Length;
							break;
						}
					}
					flag2 = false;
					continue;
				}
				if (Operators.CompareString(Strings.Mid(text, i, 1), "\\", TextCompare: false) == 0)
				{
					flag2 = true;
					continue;
				}
				if (Operators.CompareString(Strings.Mid(text, i, 1), "{", TextCompare: false) == 0)
				{
					flag = true;
					text2 = "{";
					continue;
				}
				for (int l = 0; l < tbl.Length; l++)
				{
					TABLE tABLE3 = tbl[l];
					if (Operators.CompareString(tABLE3.text, Strings.Mid(text, i, 1), TextCompare: false) == 0)
					{
						num += tABLE3.value.Length;
						break;
					}
				}
			}
			return num;
		}
	}

	private ERRORE checkText(string text, TABLE[] tbl)
	{
		if (tbl == null)
		{
			return new ERRORE(-1, 0, "Table needed");
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int length = text.Length;
		checked
		{
			for (int i = 1; i <= length; i++)
			{
				if (unchecked(Operators.CompareString(Strings.Mid(text, i, 1), "}", TextCompare: false) != 0 || flag))
				{
					flag3 = true;
				}
				if (flag2)
				{
					if (Operators.CompareString(Strings.Mid(text, i, 1), "\\", TextCompare: false) == 0)
					{
						return new ERRORE(i - 1, 1, "\\ not allowed here");
					}
					if (!flag)
					{
						if (Operators.CompareString(Strings.Mid(text, i, 1), "{", TextCompare: false) == 0)
						{
							return new ERRORE(i - 1, 1, "expected }");
						}
						if (Operators.CompareString(Strings.Mid(text, i, 1), "}", TextCompare: false) == 0)
						{
							if (!flag3)
							{
								return new ERRORE(i - 2, 2, "nothing between the brackets");
							}
							flag2 = false;
						}
					}
				}
				else if (!flag && Operators.CompareString(Strings.Mid(text, i, 1), "}", TextCompare: false) == 0)
				{
					return new ERRORE(i - 1, 1, "missing opening bracket");
				}
				if (!flag & (Operators.CompareString(Strings.Mid(text, i, 1), "{", TextCompare: false) == 0))
				{
					flag2 = true;
					flag3 = false;
				}
				flag = (unchecked(Operators.CompareString(Strings.Mid(text, i, 1), "\\", TextCompare: false) == 0 && !flag) ? true : false);
			}
			if (flag)
			{
				return new ERRORE(text.Length, 0, "expected character");
			}
			if (flag2)
			{
				return new ERRORE(text.Length, 0, "expected }");
			}
			ERRORE eRRORE = null;
			Regex regex = new Regex("[{]{1}[^\\{\\}]*[}]{1}", RegexOptions.None);
			MatchCollection matchCollection = regex.Matches(text);
			foreach (Match item in matchCollection)
			{
				if (!item.Value.Contains("\\"))
				{
					eRRORE = check(item, tbl);
				}
				if (eRRORE != null)
				{
					return eRRORE;
				}
			}
			flag2 = false;
			flag = false;
			int length2 = text.Length;
			for (int j = 1; j <= length2; j++)
			{
				if (flag2)
				{
					if (Operators.CompareString(Strings.Mid(text, j, 1), "}", TextCompare: false) == 0)
					{
						flag2 = false;
					}
					continue;
				}
				if (flag)
				{
					bool flag4 = false;
					for (int k = 0; k < tbl.Length; k++)
					{
						TABLE tABLE = tbl[k];
						if (Operators.CompareString(tABLE.text, "\\" + Strings.Mid(text, j, 1), TextCompare: false) == 0)
						{
							flag4 = true;
							break;
						}
					}
					if (!flag4)
					{
						Interaction.MsgBox("1");
						return new ERRORE(j - 2, 2, "\\" + Strings.Mid(text, j, 1) + " not exist in table");
					}
					flag = false;
					continue;
				}
				if (Operators.CompareString(Strings.Mid(text, j, 1), "\\", TextCompare: false) == 0)
				{
					flag = true;
					continue;
				}
				if (Operators.CompareString(Strings.Mid(text, j, 1), "{", TextCompare: false) == 0)
				{
					flag2 = true;
					continue;
				}
				bool flag5 = false;
				for (int l = 0; l < tbl.Length; l++)
				{
					TABLE tABLE2 = tbl[l];
					if (Operators.CompareString(tABLE2.text, Strings.Mid(text, j, 1), TextCompare: false) == 0)
					{
						flag5 = true;
						break;
					}
				}
				if (!flag5)
				{
					return new ERRORE(j - 1, 1, Strings.Mid(text, j, 1) + " not exist in table");
				}
			}
			return null;
		}
	}

	private ERRORE check(Match ma, TABLE[] tbl)
	{
		bool flag = false;
		checked
		{
			for (int i = 0; i < tbl.Length; i++)
			{
				TABLE tABLE = tbl[i];
				if (Operators.CompareString(ma.Value, tABLE.text, TextCompare: false) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				bool flag2 = true;
				int num = ma.Value.Length - 1;
				for (int j = 2; j <= num; j++)
				{
					int num2 = Strings.Asc(Strings.Mid(ma.Value, j, 1));
					if (unchecked(num2 < 48 || (num2 > 57 && num2 < 65) || (num2 > 70 && num2 < 97) || num2 > 102))
					{
						flag2 = false;
						break;
					}
				}
				if (!flag2)
				{
					return new ERRORE(ma.Index, ma.Value.Length, ma.Value + " isn't in table");
				}
				if (ma.Value.Length - 2 != 2)
				{
					return new ERRORE(ma.Index + 1, ma.Value.Length - 2, "Hexadecimal value length must be 2");
				}
			}
			return null;
		}
	}

	private void btnExtract_Click(object sender, EventArgs e)
	{
		try
		{
			extract();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
		}
	}

	private void extract()
	{
		DoMSG.MSGINFO.STRINGA[] array = null;
		if (Operators.CompareString(nomemsg, "", TextCompare: false) == 0)
		{
			throw new Exception("Select a msg file first");
		}
		checked
		{
			int num = lswMessage.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				array = ((array != null) ? ((DoMSG.MSGINFO.STRINGA[])Utils.CopyArray(array, new DoMSG.MSGINFO.STRINGA[array.Length + 1])) : new DoMSG.MSGINFO.STRINGA[1]);
				array[array.Length - 1].value = Convert2Byte(lswMessage.Items[i].SubItems[2].Text, (TABLE[])Interaction.IIf(tipo == 0, tbl, s_tbl));
				array[array.Length - 1].delimiter = Conversions.ToByte(Interaction.IIf(tipo == 0, 2, 0));
			}
			DoMSG.MSGINFO msg = default(DoMSG.MSGINFO);
			msg.value = array;
			msg.unknow = unknow;
			byte[] array2 = DoMSG.MakeMsg(msg);
			if (array2 == null)
			{
				throw new Exception("Impossible to save msgfile");
			}
			try
			{
				string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(MyProject.Forms.frmMain.filepath.Parent.FullName + "\\MSGFILE\\", MyProject.Forms.frmMain.filepath.Name), Interaction.IIf(tipo == 0, "\\BIG", "\\SMALL")), "\\"));
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + nomemsg, array2);
				modified = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				throw new Exception("Impossible to save msgfile.\r\nThe file is used by another software");
			}
		}
	}

	private void btnReinsert_Click(object sender, EventArgs e)
	{
		if (modified)
		{
			switch (Interaction.MsgBox("Do you want to save latest changes?", MsgBoxStyle.YesNoCancel, "Insert MSG"))
			{
			case MsgBoxResult.Cancel:
				return;
			case MsgBoxResult.Yes:
				try
				{
					extract();
					modified = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
					ProjectData.ClearProjectError();
					return;
				}
				break;
			}
		}
		try
		{
			MyProject.Forms.frmMain.insert(nomemsg, tipo);
			Interaction.MsgBox("Saved msg inserted", MsgBoxStyle.Information, "INSERT");
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Interaction.MsgBox(ex4.Message, MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
		}
	}

	public void clear1()
	{
		lswMessage.Items.Clear();
		selected = -1;
		tipo = -1;
		txtEdit.Text = "";
		nomemsg = "";
		modified = false;
		versione = -1;
	}

	public void clear2()
	{
		tbl = null;
		s_tbl = null;
	}

	private void btnDump_Click(object sender, EventArgs e)
	{
		try
		{
			ListView listView = lswMessage;
			dumpMsg(ref listView, MyProject.Forms.frmMain.filepath);
			lswMessage = listView;
			Interaction.MsgBox("Text Dump Saved", MsgBoxStyle.Information, "DUMP");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
		}
	}

	private void flpCenter_Paint(object sender, PaintEventArgs e)
	{
	}

	private void btnGetDump_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(nomemsg, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Select a msg file first", MsgBoxStyle.Exclamation, "ERROR");
			return;
		}
		if ((versione < 0) | (versione > 2))
		{
			Interaction.MsgBox("Impossible to recognize Game Version", MsgBoxStyle.Exclamation, "ERROR");
			return;
		}
		if (tipo == -1)
		{
			Interaction.MsgBox("Impossible to recognize MSG File Version", MsgBoxStyle.Exclamation, "ERROR");
			return;
		}
		StreamReader streamReader = null;
		string text;
		try
		{
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(MyProject.Forms.frmMain.filepath.Parent.FullName + "\\TEXTDUMP\\", MyProject.Forms.frmMain.filepath.Name), Interaction.IIf(tipo == 0, "\\BIG", "\\SMALL")), "\\"));
			if (!Directory.Exists(text))
			{
				Interaction.MsgBox("Impossible to find text dump", MsgBoxStyle.Exclamation, "ERROR");
				return;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
			return;
		}
		try
		{
			streamReader = new StreamReader(File.OpenRead(text + nomemsg + ".txt"), Encoding.UTF8);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Interaction.MsgBox("Impossible to find text dump", MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
			return;
		}
		checked
		{
			try
			{
				string text2 = streamReader.ReadLine();
				if (Operators.CompareString(text2.Replace("@", "").Replace("]", "").Replace("[", ""), nomemsg, TextCompare: false) != 0)
				{
					throw new Exception("Msg File doesn't match the selected dump");
				}
				int num = 1;
				switch (versione)
				{
				case 0:
					num = 4;
					break;
				case 1:
					num = 4;
					break;
				case 2:
					num = 2;
					break;
				}
				int num2 = -1;
				string text3 = "";
				string text4 = "";
				string text5 = "";
				dump[] array = null;
				while (!streamReader.EndOfStream)
				{
					text3 = streamReader.ReadLine();
					if (num2 == -1)
					{
						if (text3.StartsWith("[@ITEM "))
						{
							num2 = Conversions.ToInteger(text3.Split(' ')[1]);
							text5 = text3.Split(' ')[2];
						}
						else if (Operators.CompareString(text3, "", TextCompare: false) != 0)
						{
							throw new Exception("This file doesn't seem to be a correct dump");
						}
						continue;
					}
					text4 += text3;
					if (text3.Contains("\\0"))
					{
						if (!text3.EndsWith("\\0"))
						{
							throw new Exception("the text should contain \\ 0 only at the end");
						}
						num2 *= num;
						switch (versione)
						{
						case 0:
							num2 = text5 switch
							{
								"(L1)" => num2 + 0, 
								"(EN)" => num2 + 1, 
								"(L2)" => num2 + 2, 
								"(FR)" => num2 + 3, 
								_ => throw new Exception("Unknow Language Dump"), 
							};
							break;
						case 1:
							num2 = text5 switch
							{
								"(L1)" => num2 + 0, 
								"(EN)" => num2 + 1, 
								"(L2)" => num2 + 2, 
								"(FR)" => num2 + 3, 
								_ => throw new Exception("Unknow Language Dump"), 
							};
							break;
						case 2:
						{
							string left = text5;
							if (Operators.CompareString(left, "(JP)", TextCompare: false) == 0)
							{
								num2 += 0;
								break;
							}
							if (Operators.CompareString(left, "(EN)", TextCompare: false) == 0)
							{
								num2++;
								break;
							}
							throw new Exception("Unknow Language Dump");
						}
						default:
							throw new Exception("Unknow Version");
						}
						if (num2 > lswMessage.Items.Count - 1)
						{
							throw new Exception("Too many item in dump");
						}
						text4 = text4.Replace("\r", "\\n");
						text4 = text4.Replace("\n", "");
						text4 = text4.Replace("\\0", "");
						if (num2 == 1)
						{
							num2 = num2;
						}
						ERRORE eRRORE = checkText(text4, (TABLE[])Interaction.IIf(tipo == 0, tbl, s_tbl));
						if (eRRORE != null)
						{
							throw new Exception("ITEM " + Conversions.ToString(unchecked(num2 / 4)) + " - LANG " + text5 + "\r\n\r\n" + eRRORE.text);
						}
						array = ((array != null) ? ((dump[])Utils.CopyArray(array, new dump[array.Length + 1])) : new dump[1]);
						array[array.Length - 1] = new dump(num2, text4);
						text4 = "";
						num2 = -1;
					}
					else
					{
						text4 += "\r\n";
					}
				}
				modified = true;
				dump[] array2 = array;
				foreach (dump dump in array2)
				{
					lswMessage.Items[dump.index].SubItems[2].Text = dump.text;
					lswMessage.Items[dump.index].SubItems[1].Text = Conversions.ToString(count(dump.text, (TABLE[])Interaction.IIf(tipo == 0, tbl, s_tbl)));
				}
				Interaction.MsgBox("Text Dump Loaded", MsgBoxStyle.Information, "DUMP");
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Interaction.MsgBox(ex6.Message);
				ProjectData.ClearProjectError();
			}
			try
			{
				streamReader.Close();
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void dumpMsg(ref ListView x, DirectoryInfo dir)
	{
		if (Operators.CompareString(nomemsg, "", TextCompare: false) == 0)
		{
			throw new Exception("Select a msg file first");
		}
		if ((versione < 0) | (versione > 2))
		{
			throw new Exception("Impossible to recognize Game Version");
		}
		if (tipo == -1)
		{
			throw new Exception("Impossible to recognize MSG File Version");
		}
		StreamWriter streamWriter = null;
		string text;
		try
		{
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(dir.Parent.FullName + "\\TEXTDUMP\\", dir.Name), Interaction.IIf(tipo == 0, "\\BIG", "\\SMALL")), "\\"));
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.Delete(text + nomemsg + ".txt");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw ex2;
		}
		try
		{
			streamWriter = new StreamWriter(File.OpenWrite(text + nomemsg + ".txt"), Encoding.UTF8);
			streamWriter.WriteLine("[@" + nomemsg + "]\r\n");
			string lang = MySettingsProperty.Settings.Lang;
			int num = 1;
			if (Operators.CompareString(lang, "ALL", TextCompare: false) == 0)
			{
				switch (versione)
				{
				case 0:
					num = 4;
					break;
				case 1:
					num = 4;
					break;
				case 2:
					num = 1;
					break;
				}
			}
			int num2 = 0;
			int num3 = 0;
			foreach (ListViewItem item in x.Items)
			{
				if ((Operators.CompareString(item.SubItems[0].Text, lang, TextCompare: false) == 0) | (Operators.CompareString(lang, "ALL", TextCompare: false) == 0))
				{
					streamWriter.WriteLine("[@ITEM " + Conversions.ToString(num3) + " (" + item.SubItems[0].Text + ") ]");
					num2 = checked(num2 + 1);
					if (num2 % num == 0)
					{
						num3 = checked(num3 + 1);
					}
					streamWriter.WriteLine(item.SubItems[2].Text.Replace("\\n", "\r\n") + "\\0\r\n");
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			throw ex4;
		}
		try
		{
			streamWriter.Close();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
	}
}
