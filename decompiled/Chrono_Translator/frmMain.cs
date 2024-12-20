using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Chrono_Translator.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Chrono_Translator;

[DesignerGenerated]
public class frmMain : Form
{
	private delegate void incDelegate();

	private struct MSGFILE
	{
		public byte type;

		public string name;

		public ulong startpt;

		public ulong endpt;

		public ulong pointer;
	}

	private IContainer components;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("tlpMain")]
	private TableLayoutPanel _tlpMain;

	[AccessedThroughProperty("flpMain")]
	private FlowLayoutPanel _flpMain;

	[AccessedThroughProperty("txtFile")]
	private TextBox _txtFile;

	[AccessedThroughProperty("btnFile")]
	private Button _btnFile;

	[AccessedThroughProperty("btnLoad")]
	private Button _btnLoad;

	[AccessedThroughProperty("tlpRight")]
	private TableLayoutPanel _tlpRight;

	[AccessedThroughProperty("EditBox1")]
	private EditBox _EditBox1;

	[AccessedThroughProperty("lblCurrent")]
	private Label _lblCurrent;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("msgTree")]
	private TreeView _msgTree;

	[AccessedThroughProperty("chkAutoLoad")]
	private CheckBox _chkAutoLoad;

	[AccessedThroughProperty("btnOption")]
	private Button _btnOption;

	[AccessedThroughProperty("btnReinsertAll")]
	private Button _btnReinsertAll;

	[AccessedThroughProperty("btnExtractAll")]
	private Button _btnExtractAll;

	[AccessedThroughProperty("btnDumpAll")]
	private Button _btnDumpAll;

	[AccessedThroughProperty("work")]
	private BackgroundWorker _work;

	private string[] msgNamebig;

	private string[] msgNamesmall;

	private string[] msgASD1;

	private string[] msgASD2;

	private MSGFILE[] msg;

	private FileStream file;

	internal int version;

	internal DirectoryInfo filepath;

	internal virtual StatusStrip StatusStrip1
	{
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual TableLayoutPanel tlpMain
	{
		get
		{
			return _tlpMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tlpMain = value;
		}
	}

	internal virtual FlowLayoutPanel flpMain
	{
		get
		{
			return _flpMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_flpMain = value;
		}
	}

	internal virtual TextBox txtFile
	{
		get
		{
			return _txtFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtFile = value;
		}
	}

	internal virtual Button btnFile
	{
		get
		{
			return _btnFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnFile_Click;
			if (_btnFile != null)
			{
				_btnFile.Click -= value2;
			}
			_btnFile = value;
			if (_btnFile != null)
			{
				_btnFile.Click += value2;
			}
		}
	}

	internal virtual Button btnLoad
	{
		get
		{
			return _btnLoad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnLoad_Click;
			if (_btnLoad != null)
			{
				_btnLoad.Click -= value2;
			}
			_btnLoad = value;
			if (_btnLoad != null)
			{
				_btnLoad.Click += value2;
			}
		}
	}

	internal virtual TableLayoutPanel tlpRight
	{
		get
		{
			return _tlpRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tlpRight = value;
		}
	}

	internal virtual EditBox EditBox1
	{
		get
		{
			return _EditBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_EditBox1 = value;
		}
	}

	internal virtual Label lblCurrent
	{
		get
		{
			return _lblCurrent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblCurrent = value;
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_OpenFileDialog1 = value;
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

	internal virtual TreeView msgTree
	{
		get
		{
			return _msgTree;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = msgTree_DoubleClick;
			TreeViewEventHandler value3 = msgTree_AfterSelect;
			if (_msgTree != null)
			{
				_msgTree.DoubleClick -= value2;
				_msgTree.AfterSelect -= value3;
			}
			_msgTree = value;
			if (_msgTree != null)
			{
				_msgTree.DoubleClick += value2;
				_msgTree.AfterSelect += value3;
			}
		}
	}

	internal virtual CheckBox chkAutoLoad
	{
		get
		{
			return _chkAutoLoad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkAutoLoad = value;
		}
	}

	internal virtual Button btnOption
	{
		get
		{
			return _btnOption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnOption_Click;
			if (_btnOption != null)
			{
				_btnOption.Click -= value2;
			}
			_btnOption = value;
			if (_btnOption != null)
			{
				_btnOption.Click += value2;
			}
		}
	}

	internal virtual Button btnReinsertAll
	{
		get
		{
			return _btnReinsertAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnReinsertAll_Click;
			if (_btnReinsertAll != null)
			{
				_btnReinsertAll.Click -= value2;
			}
			_btnReinsertAll = value;
			if (_btnReinsertAll != null)
			{
				_btnReinsertAll.Click += value2;
			}
		}
	}

	internal virtual Button btnExtractAll
	{
		get
		{
			return _btnExtractAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnExtractAll_Click;
			if (_btnExtractAll != null)
			{
				_btnExtractAll.Click -= value2;
			}
			_btnExtractAll = value;
			if (_btnExtractAll != null)
			{
				_btnExtractAll.Click += value2;
			}
		}
	}

	internal virtual Button btnDumpAll
	{
		get
		{
			return _btnDumpAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnDumpAll_Click;
			if (_btnDumpAll != null)
			{
				_btnDumpAll.Click -= value2;
			}
			_btnDumpAll = value;
			if (_btnDumpAll != null)
			{
				_btnDumpAll.Click += value2;
			}
		}
	}

	internal virtual BackgroundWorker work
	{
		get
		{
			return _work;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = work_DoWork;
			if (_work != null)
			{
				_work.DoWork -= value2;
			}
			_work = value;
			if (_work != null)
			{
				_work.DoWork += value2;
			}
		}
	}

	public frmMain()
	{
		base.Resize += frmMain_Resize;
		base.Load += frmMain_Load;
		msgNamebig = new string[1] { "big" };
		msgNamesmall = new string[1] { "small" };
		msgASD1 = new string[1] { "msgdata" };
		msgASD2 = new string[1] { "msgdata12" };
		msg = new MSGFILE[1];
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
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
		this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
		this.txtFile = new System.Windows.Forms.TextBox();
		this.btnFile = new System.Windows.Forms.Button();
		this.btnLoad = new System.Windows.Forms.Button();
		this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
		this.lblCurrent = new System.Windows.Forms.Label();
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.msgTree = new System.Windows.Forms.TreeView();
		this.chkAutoLoad = new System.Windows.Forms.CheckBox();
		this.btnOption = new System.Windows.Forms.Button();
		this.btnReinsertAll = new System.Windows.Forms.Button();
		this.btnExtractAll = new System.Windows.Forms.Button();
		this.btnDumpAll = new System.Windows.Forms.Button();
		this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		this.EditBox1 = new Chrono_Translator.EditBox();
		this.work = new System.ComponentModel.BackgroundWorker();
		this.StatusStrip1.SuspendLayout();
		this.tlpMain.SuspendLayout();
		this.flpMain.SuspendLayout();
		this.tlpRight.SuspendLayout();
		this.TableLayoutPanel1.SuspendLayout();
		this.SuspendLayout();
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		System.Windows.Forms.StatusStrip statusStrip = this.StatusStrip1;
		System.Drawing.Point location = new System.Drawing.Point(0, 629);
		statusStrip.Location = location;
		this.StatusStrip1.Name = "StatusStrip1";
		System.Windows.Forms.StatusStrip statusStrip2 = this.StatusStrip1;
		System.Drawing.Size size = new System.Drawing.Size(644, 22);
		statusStrip2.Size = size;
		this.StatusStrip1.TabIndex = 2;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
		System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel = this.ToolStripStatusLabel1;
		size = new System.Drawing.Size(629, 17);
		toolStripStatusLabel.Size = size;
		this.ToolStripStatusLabel1.Spring = true;
		this.ToolStripStatusLabel1.Text = "Thank to HoRRoR (http://consolgames.ru/)";
		this.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.tlpMain.ColumnCount = 2;
		this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.14384f));
		this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.85616f));
		this.tlpMain.Controls.Add(this.flpMain, 0, 0);
		this.tlpMain.Controls.Add(this.tlpRight, 1, 1);
		this.tlpMain.Controls.Add(this.TableLayoutPanel1, 0, 1);
		this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel = this.tlpMain;
		location = new System.Drawing.Point(0, 0);
		tableLayoutPanel.Location = location;
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel2 = this.tlpMain;
		System.Windows.Forms.Padding margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
		tableLayoutPanel2.Margin = margin;
		this.tlpMain.Name = "tlpMain";
		this.tlpMain.RowCount = 2;
		this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32f));
		this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel3 = this.tlpMain;
		size = new System.Drawing.Size(644, 629);
		tableLayoutPanel3.Size = size;
		this.tlpMain.TabIndex = 3;
		this.tlpMain.SetColumnSpan(this.flpMain, 2);
		this.flpMain.Controls.Add(this.txtFile);
		this.flpMain.Controls.Add(this.btnFile);
		this.flpMain.Controls.Add(this.btnLoad);
		this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.FlowLayoutPanel flowLayoutPanel = this.flpMain;
		location = new System.Drawing.Point(3, 3);
		flowLayoutPanel.Location = location;
		this.flpMain.Name = "flpMain";
		System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2 = this.flpMain;
		margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
		flowLayoutPanel2.Padding = margin;
		System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3 = this.flpMain;
		size = new System.Drawing.Size(638, 26);
		flowLayoutPanel3.Size = size;
		this.flpMain.TabIndex = 0;
		this.txtFile.BackColor = System.Drawing.SystemColors.Window;
		System.Windows.Forms.TextBox textBox = this.txtFile;
		location = new System.Drawing.Point(5, 3);
		textBox.Location = location;
		this.txtFile.Name = "txtFile";
		this.txtFile.ReadOnly = true;
		System.Windows.Forms.TextBox textBox2 = this.txtFile;
		size = new System.Drawing.Size(455, 20);
		textBox2.Size = size;
		this.txtFile.TabIndex = 0;
		this.txtFile.WordWrap = false;
		System.Windows.Forms.Button button = this.btnFile;
		location = new System.Drawing.Point(466, 3);
		button.Location = location;
		this.btnFile.Name = "btnFile";
		System.Windows.Forms.Button button2 = this.btnFile;
		size = new System.Drawing.Size(24, 23);
		button2.Size = size;
		this.btnFile.TabIndex = 1;
		this.btnFile.Text = "...";
		this.btnFile.UseVisualStyleBackColor = true;
		System.Windows.Forms.Button button3 = this.btnLoad;
		location = new System.Drawing.Point(496, 3);
		button3.Location = location;
		this.btnLoad.Name = "btnLoad";
		System.Windows.Forms.Button button4 = this.btnLoad;
		size = new System.Drawing.Size(75, 23);
		button4.Size = size;
		this.btnLoad.TabIndex = 2;
		this.btnLoad.Text = "Load";
		this.btnLoad.UseVisualStyleBackColor = true;
		this.tlpRight.ColumnCount = 1;
		this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.tlpRight.Controls.Add(this.EditBox1, 0, 1);
		this.tlpRight.Controls.Add(this.lblCurrent, 0, 0);
		this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel4 = this.tlpRight;
		location = new System.Drawing.Point(158, 35);
		tableLayoutPanel4.Location = location;
		this.tlpRight.Name = "tlpRight";
		this.tlpRight.RowCount = 2;
		this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23f));
		this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel5 = this.tlpRight;
		size = new System.Drawing.Size(483, 591);
		tableLayoutPanel5.Size = size;
		this.tlpRight.TabIndex = 2;
		this.lblCurrent.AutoSize = true;
		this.lblCurrent.Dock = System.Windows.Forms.DockStyle.Left;
		System.Windows.Forms.Label label = this.lblCurrent;
		location = new System.Drawing.Point(3, 0);
		label.Location = location;
		this.lblCurrent.Name = "lblCurrent";
		System.Windows.Forms.Label label2 = this.lblCurrent;
		size = new System.Drawing.Size(111, 23);
		label2.Size = size;
		this.lblCurrent.TabIndex = 5;
		this.lblCurrent.Text = "Current MSG: Nothing";
		this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TableLayoutPanel1.ColumnCount = 1;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel1.Controls.Add(this.msgTree, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.chkAutoLoad, 0, 1);
		this.TableLayoutPanel1.Controls.Add(this.btnOption, 0, 6);
		this.TableLayoutPanel1.Controls.Add(this.btnReinsertAll, 0, 3);
		this.TableLayoutPanel1.Controls.Add(this.btnExtractAll, 0, 2);
		this.TableLayoutPanel1.Controls.Add(this.btnDumpAll, 0, 4);
		this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel6 = this.TableLayoutPanel1;
		location = new System.Drawing.Point(3, 35);
		tableLayoutPanel6.Location = location;
		this.TableLayoutPanel1.Name = "TableLayoutPanel1";
		this.TableLayoutPanel1.RowCount = 7;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
		System.Windows.Forms.TableLayoutPanel tableLayoutPanel7 = this.TableLayoutPanel1;
		size = new System.Drawing.Size(149, 591);
		tableLayoutPanel7.Size = size;
		this.TableLayoutPanel1.TabIndex = 3;
		this.msgTree.Dock = System.Windows.Forms.DockStyle.Fill;
		this.msgTree.HideSelection = false;
		System.Windows.Forms.TreeView treeView = this.msgTree;
		location = new System.Drawing.Point(8, 6);
		treeView.Location = location;
		System.Windows.Forms.TreeView treeView2 = this.msgTree;
		margin = new System.Windows.Forms.Padding(8, 6, 0, 8);
		treeView2.Margin = margin;
		this.msgTree.Name = "msgTree";
		System.Windows.Forms.TreeView treeView3 = this.msgTree;
		size = new System.Drawing.Size(141, 428);
		treeView3.Size = size;
		this.msgTree.TabIndex = 3;
		this.chkAutoLoad.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox = this.chkAutoLoad;
		location = new System.Drawing.Point(3, 445);
		checkBox.Location = location;
		this.chkAutoLoad.Name = "chkAutoLoad";
		System.Windows.Forms.CheckBox checkBox2 = this.chkAutoLoad;
		size = new System.Drawing.Size(136, 17);
		checkBox2.Size = size;
		this.chkAutoLoad.TabIndex = 0;
		this.chkAutoLoad.Text = "Auto Load Saved MSG";
		this.chkAutoLoad.UseVisualStyleBackColor = true;
		this.btnOption.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.Button button5 = this.btnOption;
		location = new System.Drawing.Point(3, 565);
		button5.Location = location;
		this.btnOption.Name = "btnOption";
		System.Windows.Forms.Button button6 = this.btnOption;
		size = new System.Drawing.Size(143, 23);
		button6.Size = size;
		this.btnOption.TabIndex = 4;
		this.btnOption.Text = "Option";
		this.btnOption.UseVisualStyleBackColor = true;
		this.btnReinsertAll.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.Button button7 = this.btnReinsertAll;
		location = new System.Drawing.Point(3, 497);
		button7.Location = location;
		this.btnReinsertAll.Name = "btnReinsertAll";
		System.Windows.Forms.Button button8 = this.btnReinsertAll;
		size = new System.Drawing.Size(143, 23);
		button8.Size = size;
		this.btnReinsertAll.TabIndex = 1;
		this.btnReinsertAll.Text = "ReInsert ALL Saved MSG";
		this.btnReinsertAll.UseVisualStyleBackColor = true;
		this.btnExtractAll.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.Button button9 = this.btnExtractAll;
		location = new System.Drawing.Point(3, 468);
		button9.Location = location;
		this.btnExtractAll.Name = "btnExtractAll";
		System.Windows.Forms.Button button10 = this.btnExtractAll;
		size = new System.Drawing.Size(143, 23);
		button10.Size = size;
		this.btnExtractAll.TabIndex = 5;
		this.btnExtractAll.Text = "Extract ALL MSG";
		this.btnExtractAll.UseVisualStyleBackColor = true;
		this.btnDumpAll.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.Button button11 = this.btnDumpAll;
		location = new System.Drawing.Point(3, 526);
		button11.Location = location;
		this.btnDumpAll.Name = "btnDumpAll";
		System.Windows.Forms.Button button12 = this.btnDumpAll;
		size = new System.Drawing.Size(143, 23);
		button12.Size = size;
		this.btnDumpAll.TabIndex = 6;
		this.btnDumpAll.Text = "Text Dump for All";
		this.btnDumpAll.UseVisualStyleBackColor = true;
		this.OpenFileDialog1.DefaultExt = "nds";
		this.OpenFileDialog1.FileName = "OpenFileDialog1";
		this.OpenFileDialog1.Filter = "Nintendo DS Rom (*.nds)|*.nds";
		this.EditBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		Chrono_Translator.EditBox editBox = this.EditBox1;
		location = new System.Drawing.Point(3, 26);
		editBox.Location = location;
		Chrono_Translator.EditBox editBox2 = this.EditBox1;
		size = new System.Drawing.Size(200, 200);
		editBox2.MinimumSize = size;
		this.EditBox1.Name = "EditBox1";
		Chrono_Translator.EditBox editBox3 = this.EditBox1;
		margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
		editBox3.Padding = margin;
		Chrono_Translator.EditBox editBox4 = this.EditBox1;
		size = new System.Drawing.Size(477, 562);
		editBox4.Size = size;
		this.EditBox1.TabIndex = 4;
		this.work.WorkerSupportsCancellation = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(644, 651);
		this.ClientSize = size;
		this.Controls.Add(this.tlpMain);
		this.Controls.Add(this.StatusStrip1);
		size = new System.Drawing.Size(660, 687);
		this.MinimumSize = size;
		this.Name = "frmMain";
		this.Text = "Chrono Translator by Whivel";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.tlpMain.ResumeLayout(false);
		this.flpMain.ResumeLayout(false);
		this.flpMain.PerformLayout();
		this.tlpRight.ResumeLayout(false);
		this.tlpRight.PerformLayout();
		this.TableLayoutPanel1.ResumeLayout(false);
		this.TableLayoutPanel1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void btnLoad_Click(object sender, EventArgs e)
	{
		try
		{
			file.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		EditBox1.clear1();
		EditBox1.clear2();
		msg = new MSGFILE[1];
		msgTree.Nodes.Clear();
		DSExplorer dSExplorer = new DSExplorer();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(txtFile.Text);
			filepath = directoryInfo;
			file = File.Open(txtFile.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			filepath = null;
			Interaction.MsgBox("Impossible to load rom file", MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
			return;
		}
		checked
		{
			try
			{
				int num = 0;
				do
				{
					if (file.ReadByte() != Strings.Asc(Strings.Mid("CHRONO_T", num + 1, 1)))
					{
						Interaction.MsgBox("Invalid Game", MsgBoxStyle.Critical, "Error");
						return;
					}
					num++;
				}
				while (num <= 7);
				file.Seek(15L, SeekOrigin.Begin);
				switch (file.ReadByte())
				{
				case 69:
					version = 0;
					break;
				case 80:
					version = 1;
					break;
				case 74:
					version = 2;
					break;
				default:
					version = 0;
					break;
				}
				if (version == -1)
				{
					Interaction.MsgBox("Unknow Country Version", MsgBoxStyle.Exclamation, "Error");
				}
				TreeNode[] array = dSExplorer.LoadROM(txtFile.Text, msgNamebig);
				if (array.Length != 1)
				{
					filepath = null;
					Interaction.MsgBox("Impossible to load rom file", MsgBoxStyle.Exclamation, "ERROR");
					return;
				}
				int num2 = file.ReadByte();
				int num3 = 0;
				int num4 = array[0].Nodes.Count - 1;
				MSGFILE mSGFILE = default(MSGFILE);
				for (int i = 0; i <= num4; i++)
				{
					int num5 = Conversions.ToInteger(array[0].Nodes[i].Tag);
					array[0].Nodes[i].Tag = num3;
					num3++;
					file.Seek(num5, SeekOrigin.Begin);
					mSGFILE.name = array[0].Nodes[i].Text;
					mSGFILE.pointer = (ulong)num5;
					mSGFILE.startpt = (ulong)file.ReadByte() + ((ulong)file.ReadByte() << 8) + ((ulong)file.ReadByte() << 16) + ((ulong)file.ReadByte() << 24);
					num5 += 4;
					mSGFILE.endpt = (ulong)file.ReadByte() + ((ulong)file.ReadByte() << 8) + ((ulong)file.ReadByte() << 16) + ((ulong)file.ReadByte() << 24);
					num5 += 4;
					mSGFILE.type = 0;
					msg = (MSGFILE[])Utils.CopyArray(msg, new MSGFILE[msg.Length + 1]);
					msg[msg.Length - 2] = mSGFILE;
				}
				msgTree.Nodes.Add(array[0]);
				array = dSExplorer.LoadROM(txtFile.Text, msgNamesmall);
				int num6 = array[0].Nodes.Count - 1;
				for (int j = 0; j <= num6; j++)
				{
					int num5 = Conversions.ToInteger(array[0].Nodes[j].Tag);
					array[0].Nodes[j].Tag = num3;
					num3++;
					file.Seek(num5, SeekOrigin.Begin);
					mSGFILE.name = array[0].Nodes[j].Text;
					mSGFILE.pointer = (ulong)num5;
					mSGFILE.startpt = (ulong)file.ReadByte() + ((ulong)file.ReadByte() << 8) + ((ulong)file.ReadByte() << 16) + ((ulong)file.ReadByte() << 24);
					num5 += 4;
					mSGFILE.endpt = (ulong)file.ReadByte() + ((ulong)file.ReadByte() << 8) + ((ulong)file.ReadByte() << 16) + ((ulong)file.ReadByte() << 24);
					num5 += 4;
					mSGFILE.type = 1;
					msg = (MSGFILE[])Utils.CopyArray(msg, new MSGFILE[msg.Length + 1]);
					msg[msg.Length - 2] = mSGFILE;
				}
				msgTree.Nodes.Add(array[0]);
				msg = (MSGFILE[])Utils.CopyArray(msg, new MSGFILE[msg.Length - 2 + 1]);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Interaction.MsgBox("Impossible to load msg file in rom", MsgBoxStyle.Exclamation, "ERROR");
				ProjectData.ClearProjectError();
				return;
			}
			try
			{
				switch (version)
				{
				case 0:
				case 1:
					EditBox1.loadBig(Application.StartupPath + "\\tables\\big_asci.tbl");
					EditBox1.loadSmall(Application.StartupPath + "\\tables\\small_asci.tbl");
					break;
				case 2:
					EditBox1.loadBig(Application.StartupPath + "\\tables\\jap_big_asci.tbl");
					EditBox1.loadSmall(Application.StartupPath + "\\tables\\jap_small_asci.tbl");
					break;
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				Interaction.MsgBox(ex8.Message, MsgBoxStyle.Exclamation, "ERROR");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void frmMain_Resize(object sender, EventArgs e)
	{
		txtFile.Width = checked(flpMain.Width - 121);
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		OpenFileDialog1.InitialDirectory = Application.ExecutablePath;
	}

	private void msgTree_DoubleClick(object sender, EventArgs e)
	{
		if (msgTree.SelectedNode == null || !msgTree.SelectedNode.Text.EndsWith(".msg"))
		{
			return;
		}
		MSGFILE mSGFILE = msg[Conversions.ToInteger(msgTree.SelectedNode.Tag)];
		checked
		{
			try
			{
				string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(filepath.Parent.FullName + "\\MSGFILE\\", filepath.Name), Interaction.IIf(mSGFILE.type == 0, "\\BIG", "\\SMALL")), "\\"));
				byte[] array;
				if (File.Exists(text + mSGFILE.name))
				{
					if (chkAutoLoad.Checked)
					{
						array = File.ReadAllBytes(text + mSGFILE.name);
					}
					else if (Interaction.MsgBox("Load saved msg file?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Loading") == MsgBoxResult.Yes)
					{
						array = File.ReadAllBytes(text + mSGFILE.name);
					}
					else
					{
						array = new byte[Convert.ToInt32(decimal.Subtract(new decimal(mSGFILE.endpt - mSGFILE.startpt), 1m)) + 1];
						file.Seek((long)mSGFILE.startpt, SeekOrigin.Begin);
						file.Read(array, 0, (int)(mSGFILE.endpt - mSGFILE.startpt));
					}
				}
				else
				{
					array = new byte[Convert.ToInt32(decimal.Subtract(new decimal(mSGFILE.endpt - mSGFILE.startpt), 1m)) + 1];
					file.Seek((long)mSGFILE.startpt, SeekOrigin.Begin);
					file.Read(array, 0, (int)(mSGFILE.endpt - mSGFILE.startpt));
				}
				byte del = Conversions.ToByte(Interaction.IIf(mSGFILE.type == 0, 2, 0));
				DoMSG.MSGINFO mSGINFO = DoMSG.Extract(array, del);
				lblCurrent.Text = "Current MSG: " + mSGFILE.name;
				EditBox1.Convert2String(mSGINFO, mSGFILE.type, Conversions.ToString(version), mSGFILE.name, filepath);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				lblCurrent.Text = "Current MSG: Nothing";
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void btnFile_Click(object sender, EventArgs e)
	{
		try
		{
			file.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		EditBox1.clear1();
		EditBox1.clear2();
		msgTree.Nodes.Clear();
		version = -1;
		file = null;
		lblCurrent.Text = "Current MSG: Nothing";
		DialogResult dialogResult = OpenFileDialog1.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			txtFile.Text = OpenFileDialog1.FileName;
		}
		else
		{
			txtFile.Text = "Nothing selected";
		}
	}

	private void btnOption_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmOption.ShowDialog();
	}

	private void insertALL()
	{
		if (filepath == null)
		{
			throw new Exception("Select a file first");
		}
		string text = filepath.Parent.FullName + "\\MSGFILE\\" + filepath.Name + "\\";
		DirectoryInfo directoryInfo = new DirectoryInfo(text + "SMALL\\");
		DirectoryInfo directoryInfo2 = new DirectoryInfo(text + "BIG\\");
		if (!directoryInfo.Exists & !directoryInfo2.Exists)
		{
			throw new Exception("No msg file to be reinserted");
		}
		MSGFILE[] array = msg;
		int num = 0;
		if (num < array.Length)
		{
			MSGFILE mSGFILE = array[num];
			if (mSGFILE.type == 0)
			{
				if (directoryInfo2.GetFiles(mSGFILE.name, SearchOption.TopDirectoryOnly).Length <= 0)
				{
					goto IL_00d2;
				}
			}
			else if (directoryInfo.GetFiles(mSGFILE.name, SearchOption.TopDirectoryOnly).Length <= 0)
			{
				goto IL_00d2;
			}
		}
		checked
		{
			uint num2 = (uint)MySettingsProperty.Settings.FreeSpaceAddress;
			bool checkUsedSpace = MySettingsProperty.Settings.CheckUsedSpace;
			bool flag = MySettingsProperty.Settings.Overwrite;
			FileStream newfile;
			try
			{
				File.Copy(filepath.FullName, filepath.FullName + ".new.nds", overwrite: true);
				newfile = File.Open(filepath.FullName + ".new.nds", FileMode.Open, FileAccess.Write);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				File.Delete(filepath.FullName + ".new.nds");
				throw new Exception("Impossible to save new rom file");
			}
			MSGFILE[] array2 = msg;
			for (int i = 0; i < array2.Length; i++)
			{
				MSGFILE mSGFILE2 = array2[i];
				FileInfo fileInfo = new FileInfo(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text, Interaction.IIf(mSGFILE2.type == 0, "BIG\\", "SMALL\\")), mSGFILE2.name)));
				if (!fileInfo.Exists)
				{
					continue;
				}
				if (flag)
				{
					flag = false;
					if (decimal.Compare(new decimal(mSGFILE2.endpt - mSGFILE2.startpt), new decimal(fileInfo.Length)) >= 0)
					{
						flag = true;
					}
				}
				ListViewItem[] array3 = null;
				if (((unchecked(checkUsedSpace && !flag) ? 1u : 0u) | 1u) != 0)
				{
					MSGFILE[] array4 = msg;
					for (int j = 0; j < array4.Length; j++)
					{
						MSGFILE mSGFILE3 = array4[j];
						if (((mSGFILE3.startpt >= num2) & (decimal.Compare(new decimal(mSGFILE3.startpt), new decimal(num2 + fileInfo.Length - 1)) <= 0)) | ((mSGFILE3.endpt >= num2) & (decimal.Compare(new decimal(mSGFILE3.endpt), new decimal(num2 + fileInfo.Length - 1)) <= 0)))
						{
							array3 = ((array3 != null) ? ((ListViewItem[])Utils.CopyArray(array3, new ListViewItem[array3.Length + 1])) : new ListViewItem[1]);
							string text2 = Conversion.Hex(mSGFILE3.startpt);
							while (text2.Length < 8)
							{
								text2 = "0" + text2;
							}
							array3[array3.Length - 1] = new ListViewItem(text2);
							array3[array3.Length - 1].SubItems.Add(Conversion.Hex(mSGFILE3.endpt - mSGFILE3.startpt));
							array3[array3.Length - 1].SubItems.Add(mSGFILE3.name);
						}
					}
					if (array3 != null)
					{
						MyProject.Forms.frmSpace.setWarning(array3);
						DialogResult dialogResult = MyProject.Forms.frmSpace.ShowDialog();
						if (dialogResult == DialogResult.Cancel)
						{
							File.Delete(filepath.FullName + ".new.nds");
							throw new Exception("Insertion canceled");
						}
					}
				}
				try
				{
					if (flag)
					{
						insert(ref newfile, fileInfo, (uint)mSGFILE2.pointer, (int)mSGFILE2.startpt);
					}
					else
					{
						num2 = (uint)insert(ref newfile, fileInfo, (uint)mSGFILE2.pointer, (int)num2);
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					File.Delete(filepath.FullName + ".new.nds");
					throw ex4;
				}
			}
			try
			{
				newfile.Close();
				return;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
				return;
			}
		}
		IL_00d2:
		throw new Exception("No msg file to be reinserted");
	}

	public void insert(string nomemsg, int tipo)
	{
		string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(filepath.Parent.FullName + "\\MSGFILE\\", filepath.Name), Interaction.IIf(tipo == 0, "\\BIG", "\\SMALL")), "\\"));
		FileInfo fileInfo = new FileInfo(text + nomemsg);
		if (!fileInfo.Exists)
		{
			Interaction.MsgBox("ERRORE");
			return;
		}
		checked
		{
			uint num = (uint)MySettingsProperty.Settings.FreeSpaceAddress;
			bool checkUsedSpace = MySettingsProperty.Settings.CheckUsedSpace;
			bool flag = MySettingsProperty.Settings.Overwrite;
			MSGFILE[] array = msg;
			MSGFILE mSGFILE2 = default(MSGFILE);
			for (int i = 0; i < array.Length; i++)
			{
				MSGFILE mSGFILE = array[i];
				if (Operators.CompareString(mSGFILE.name, nomemsg, TextCompare: false) == 0)
				{
					mSGFILE2 = mSGFILE;
					break;
				}
			}
			if (flag)
			{
				flag = false;
				if (decimal.Compare(new decimal(mSGFILE2.endpt - mSGFILE2.startpt), new decimal(fileInfo.Length)) >= 0)
				{
					flag = true;
				}
			}
			if (unchecked(checkUsedSpace && !flag))
			{
				MSGFILE[] array2 = msg;
				for (int j = 0; j < array2.Length; j++)
				{
					MSGFILE mSGFILE3 = array2[j];
					if (((mSGFILE3.startpt >= num) & (decimal.Compare(new decimal(mSGFILE3.startpt), new decimal(num + fileInfo.Length - 1)) <= 0)) | ((mSGFILE3.endpt >= num) & (decimal.Compare(new decimal(mSGFILE3.endpt), new decimal(num + fileInfo.Length - 1)) <= 0)))
					{
						MsgBoxResult msgBoxResult = Interaction.MsgBox("Indicated FreeSpace is used by: " + mSGFILE3.name + "\r\ndo you want to continue insert? (NOT RECCOMENDED)\r\n\r\nIt's better to change it", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2, "ATTENTION");
						if (msgBoxResult == MsgBoxResult.No)
						{
							File.Delete(filepath.FullName + ".new.nds");
							Interaction.MsgBox("Insertion canceled", MsgBoxStyle.Information, "CANCEL");
							return;
						}
					}
				}
			}
			try
			{
				File.Copy(filepath.FullName, filepath.FullName + ".new.nds", overwrite: true);
				FileStream newfile = File.Open(filepath.FullName + ".new.nds", FileMode.Open, FileAccess.Write);
				insert(ref newfile, fileInfo, (uint)mSGFILE2.pointer, Conversions.ToInteger(Interaction.IIf(flag, mSGFILE2.startpt, num)));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				File.Delete(filepath.FullName + ".new.nds");
				throw ex2;
			}
		}
	}

	private long insert(ref FileStream newfile, FileInfo msgFile, uint pointer, int address)
	{
		byte[] array;
		try
		{
			array = File.ReadAllBytes(msgFile.FullName);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			newfile.Close();
			throw new Exception("Impossible to load msgfile\r\n" + msgFile.FullName);
		}
		checked
		{
			try
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					newfile.Seek(address + i, SeekOrigin.Begin);
					newfile.WriteByte(array[i]);
				}
				newfile.Seek(pointer, SeekOrigin.Begin);
				newfile.WriteByte((byte)unchecked(address % 256));
				newfile.WriteByte((byte)unchecked((address >> 8) % 256));
				newfile.WriteByte((byte)unchecked((address >> 16) % 256));
				newfile.WriteByte((byte)unchecked((address >> 24) % 256));
				newfile.WriteByte((byte)unchecked(checked(address + array.Length) % 256));
				newfile.WriteByte((byte)unchecked((checked(address + array.Length) >> 8) % 256));
				newfile.WriteByte((byte)unchecked((checked(address + array.Length) >> 16) % 256));
				newfile.WriteByte((byte)unchecked((checked(address + array.Length) >> 24) % 256));
				newfile.Seek(address + array.Length, SeekOrigin.Begin);
				newfile.WriteByte(byte.MaxValue);
				return address + array.Length + 1;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				newfile.Close();
				throw ex4;
			}
		}
	}

	private void btnReinsertAll_Click(object sender, EventArgs e)
	{
		try
		{
			insertALL();
			Interaction.MsgBox("ALL saved msg inserted", MsgBoxStyle.Information, "INSERT");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
		}
	}

	private void btnExtractAll_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (filepath == null)
				{
					throw new Exception("Select a file first");
				}
				string text = filepath.Parent.FullName + "\\MSGFILE\\" + filepath.Name + "\\";
				DirectoryInfo directoryInfo = new DirectoryInfo(text + "SMALL\\");
				DirectoryInfo directoryInfo2 = new DirectoryInfo(text + "BIG\\");
				if (!directoryInfo.Exists)
				{
					Directory.CreateDirectory(text + "SMALL\\");
				}
				if (!directoryInfo2.Exists)
				{
					Directory.CreateDirectory(text + "BIG\\");
				}
				MSGFILE[] array = msg;
				for (int i = 0; i < array.Length; i++)
				{
					MSGFILE mSGFILE = array[i];
					if (msgTree.SelectedNode.Text.EndsWith(".msg"))
					{
						byte[] array2 = new byte[Convert.ToInt32(decimal.Subtract(new decimal(mSGFILE.endpt - mSGFILE.startpt), 1m)) + 1];
						file.Seek((long)mSGFILE.startpt, SeekOrigin.Begin);
						file.Read(array2, 0, (int)(mSGFILE.endpt - mSGFILE.startpt));
						File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text, Interaction.IIf(mSGFILE.type == 0, "BIG\\", "SMALL\\")), mSGFILE.name)), array2);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void msgTree_AfterSelect(object sender, TreeViewEventArgs e)
	{
	}

	private void btnDumpAll_Click(object sender, EventArgs e)
	{
		try
		{
			if (filepath == null)
			{
				Interaction.MsgBox("Select a file first", MsgBoxStyle.Exclamation, "ERROR");
				return;
			}
			work.RunWorkerAsync();
			switch (MyProject.Forms.Dumping.ShowDialog())
			{
			case DialogResult.Cancel:
				work.CancelAsync();
				Interaction.MsgBox("Dump stopped", MsgBoxStyle.Information, "Dumping");
				break;
			case DialogResult.OK:
				Interaction.MsgBox("Dump finished", MsgBoxStyle.Information, "Dumping");
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void work_DoWork(object sender, DoWorkEventArgs e)
	{
		bool flag = false;
		while (Operators.CompareString(Form.ActiveForm.Name, "Dumping", TextCompare: false) != 0)
		{
			Application.DoEvents();
		}
		Dumping dumping = (Dumping)Form.ActiveForm;
		checked
		{
			try
			{
				if (filepath == null)
				{
					throw new Exception("Select a file first");
				}
				dumping.setDumpMax(msgTree.Nodes[0].Nodes.Count + msgTree.Nodes[1].Nodes.Count);
				MSGFILE[] array = msg;
				for (int i = 0; i < array.Length; i++)
				{
					MSGFILE mSGFILE = array[i];
					if (work.CancellationPending)
					{
						return;
					}
					if (!mSGFILE.name.EndsWith(".msg"))
					{
						continue;
					}
					dumping.incrementa();
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(filepath.Parent.FullName + "\\MSGFILE\\", filepath.Name), Interaction.IIf(mSGFILE.type == 0, "\\BIG", "\\SMALL")), "\\"));
					byte[] array2;
					if (File.Exists(text + mSGFILE.name))
					{
						if (chkAutoLoad.Checked)
						{
							array2 = File.ReadAllBytes(text + mSGFILE.name);
						}
						else if (Interaction.MsgBox("Dump saved msg file?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Loading") == MsgBoxResult.Yes)
						{
							array2 = File.ReadAllBytes(text + mSGFILE.name);
						}
						else
						{
							array2 = new byte[Convert.ToInt32(decimal.Subtract(new decimal(mSGFILE.endpt - mSGFILE.startpt), 1m)) + 1];
							file.Seek((long)mSGFILE.startpt, SeekOrigin.Begin);
							file.Read(array2, 0, (int)(mSGFILE.endpt - mSGFILE.startpt));
						}
					}
					else
					{
						array2 = new byte[Convert.ToInt32(decimal.Subtract(new decimal(mSGFILE.endpt - mSGFILE.startpt), 1m)) + 1];
						file.Seek((long)mSGFILE.startpt, SeekOrigin.Begin);
						file.Read(array2, 0, (int)(mSGFILE.endpt - mSGFILE.startpt));
					}
					byte del = Conversions.ToByte(Interaction.IIf(mSGFILE.type == 0, 2, 0));
					DoMSG.MSGINFO mSGINFO = DoMSG.Extract(array2, del);
					dumping.setLabel(mSGFILE.name);
					EditBox1.Convert2String(mSGINFO, mSGFILE.type, Conversions.ToString(version), mSGFILE.name, filepath, extr: true);
				}
				dumping.finished(0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				dumping.finished(1);
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
				ProjectData.ClearProjectError();
			}
		}
	}
}
