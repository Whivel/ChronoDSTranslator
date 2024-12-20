using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Chrono_Translator.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Chrono_Translator;

[DesignerGenerated]
public class frmSpace : Form
{
	private IContainer components;

	[AccessedThroughProperty("lswWarning")]
	private ListView _lswWarning;

	[AccessedThroughProperty("cmhAddress")]
	private ColumnHeader _cmhAddress;

	[AccessedThroughProperty("cmhLength")]
	private ColumnHeader _cmhLength;

	[AccessedThroughProperty("cmhMessage")]
	private ColumnHeader _cmhMessage;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[AccessedThroughProperty("btnContinue")]
	private Button _btnContinue;

	internal virtual ListView lswWarning
	{
		get
		{
			return _lswWarning;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ColumnWidthChangingEventHandler value2 = lswWarning_ColumnWidthChanging;
			if (_lswWarning != null)
			{
				_lswWarning.ColumnWidthChanging -= value2;
			}
			_lswWarning = value;
			if (_lswWarning != null)
			{
				_lswWarning.ColumnWidthChanging += value2;
			}
		}
	}

	internal virtual ColumnHeader cmhAddress
	{
		get
		{
			return _cmhAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmhAddress = value;
		}
	}

	internal virtual ColumnHeader cmhLength
	{
		get
		{
			return _cmhLength;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmhLength = value;
		}
	}

	internal virtual ColumnHeader cmhMessage
	{
		get
		{
			return _cmhMessage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmhMessage = value;
		}
	}

	internal virtual Button btnCancel
	{
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnCancel_Click;
			if (_btnCancel != null)
			{
				_btnCancel.Click -= value2;
			}
			_btnCancel = value;
			if (_btnCancel != null)
			{
				_btnCancel.Click += value2;
			}
		}
	}

	internal virtual Button btnContinue
	{
		get
		{
			return _btnContinue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnContinue_Click;
			if (_btnContinue != null)
			{
				_btnContinue.Click -= value2;
			}
			_btnContinue = value;
			if (_btnContinue != null)
			{
				_btnContinue.Click += value2;
			}
		}
	}

	public frmSpace()
	{
		base.Shown += frmSpace_Shown;
		base.Load += frmSpace_Load;
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
		this.lswWarning = new System.Windows.Forms.ListView();
		this.cmhAddress = new System.Windows.Forms.ColumnHeader();
		this.cmhLength = new System.Windows.Forms.ColumnHeader();
		this.cmhMessage = new System.Windows.Forms.ColumnHeader();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnContinue = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.lswWarning.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.cmhAddress, this.cmhLength, this.cmhMessage });
		this.lswWarning.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		System.Windows.Forms.ListView listView = this.lswWarning;
		System.Drawing.Point location = new System.Drawing.Point(12, 12);
		listView.Location = location;
		this.lswWarning.Name = "lswWarning";
		System.Windows.Forms.ListView listView2 = this.lswWarning;
		System.Drawing.Size size = new System.Drawing.Size(302, 103);
		listView2.Size = size;
		this.lswWarning.TabIndex = 0;
		this.lswWarning.UseCompatibleStateImageBehavior = false;
		this.lswWarning.View = System.Windows.Forms.View.Details;
		this.cmhAddress.Text = "Address";
		this.cmhAddress.Width = 79;
		this.cmhLength.Text = "Length";
		this.cmhLength.Width = 78;
		this.cmhMessage.Text = "Message";
		this.cmhMessage.Width = 113;
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		System.Windows.Forms.Button button = this.btnCancel;
		location = new System.Drawing.Point(12, 130);
		button.Location = location;
		this.btnCancel.Name = "btnCancel";
		System.Windows.Forms.Button button2 = this.btnCancel;
		size = new System.Drawing.Size(94, 21);
		button2.Size = size;
		this.btnCancel.TabIndex = 1;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
		System.Windows.Forms.Button button3 = this.btnContinue;
		location = new System.Drawing.Point(220, 130);
		button3.Location = location;
		this.btnContinue.Name = "btnContinue";
		System.Windows.Forms.Button button4 = this.btnContinue;
		size = new System.Drawing.Size(94, 21);
		button4.Size = size;
		this.btnContinue.TabIndex = 2;
		this.btnContinue.Text = "Continue";
		this.btnContinue.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(326, 157);
		this.ClientSize = size;
		this.Controls.Add(this.btnContinue);
		this.Controls.Add(this.btnCancel);
		this.Controls.Add(this.lswWarning);
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "frmSpace";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Warning - Free Space Address:";
		this.ResumeLayout(false);
	}

	public void setWarning(ListViewItem[] strings)
	{
		try
		{
			lswWarning.Items.Clear();
			foreach (ListViewItem value in strings)
			{
				lswWarning.Items.Add(value);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void lswWarning_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{
		e.Cancel = true;
		e.NewWidth = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "columns", new object[1] { e.ColumnIndex }, null, null, null), null, "Width", new object[0], null, null, null));
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnContinue_Click(object sender, EventArgs e)
	{
		MsgBoxResult msgBoxResult = Interaction.MsgBox("Are you sure to continue insert? (NOT RECCOMENDED)\r\n\r\nIt's better to change the Free Space Address from Options", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2, "ERRORE");
		if (msgBoxResult == MsgBoxResult.No)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		else
		{
			Close();
		}
	}

	private void frmSpace_Shown(object sender, EventArgs e)
	{
	}

	private void frmSpace_Load(object sender, EventArgs e)
	{
		Text = "Warning - Free Space Address: " + Conversion.Hex(MySettingsProperty.Settings.FreeSpaceAddress);
	}
}
