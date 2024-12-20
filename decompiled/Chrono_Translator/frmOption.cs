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
public class frmOption : Form
{
	private IContainer components;

	[AccessedThroughProperty("gbxOption")]
	private GroupBox _gbxOption;

	[AccessedThroughProperty("chkOverwrite")]
	private CheckBox _chkOverwrite;

	[AccessedThroughProperty("txtFreeSpace")]
	private TextBox _txtFreeSpace;

	[AccessedThroughProperty("chkCheckUsedSpace")]
	private CheckBox _chkCheckUsedSpace;

	[AccessedThroughProperty("lblFreeSpace")]
	private Label _lblFreeSpace;

	[AccessedThroughProperty("lblOriginal")]
	private Label _lblOriginal;

	[AccessedThroughProperty("btnClose")]
	private Button _btnClose;

	[AccessedThroughProperty("btnSetAsDefault")]
	private Button _btnSetAsDefault;

	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[AccessedThroughProperty("cmbLanguage")]
	private ComboBox _cmbLanguage;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	internal virtual GroupBox gbxOption
	{
		get
		{
			return _gbxOption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = gbxOption_Enter;
			if (_gbxOption != null)
			{
				_gbxOption.Enter -= value2;
			}
			_gbxOption = value;
			if (_gbxOption != null)
			{
				_gbxOption.Enter += value2;
			}
		}
	}

	internal virtual CheckBox chkOverwrite
	{
		get
		{
			return _chkOverwrite;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkOverwrite = value;
		}
	}

	internal virtual TextBox txtFreeSpace
	{
		get
		{
			return _txtFreeSpace;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = txtFreeSpace_TextChanged;
			CancelEventHandler value3 = txtFreeSpace_Validating;
			if (_txtFreeSpace != null)
			{
				_txtFreeSpace.TextChanged -= value2;
				_txtFreeSpace.Validating -= value3;
			}
			_txtFreeSpace = value;
			if (_txtFreeSpace != null)
			{
				_txtFreeSpace.TextChanged += value2;
				_txtFreeSpace.Validating += value3;
			}
		}
	}

	internal virtual CheckBox chkCheckUsedSpace
	{
		get
		{
			return _chkCheckUsedSpace;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkCheckUsedSpace = value;
		}
	}

	internal virtual Label lblFreeSpace
	{
		get
		{
			return _lblFreeSpace;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblFreeSpace = value;
		}
	}

	internal virtual Label lblOriginal
	{
		get
		{
			return _lblOriginal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblOriginal = value;
		}
	}

	internal virtual Button btnClose
	{
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnClose_Click;
			if (_btnClose != null)
			{
				_btnClose.Click -= value2;
			}
			_btnClose = value;
			if (_btnClose != null)
			{
				_btnClose.Click += value2;
			}
		}
	}

	internal virtual Button btnSetAsDefault
	{
		get
		{
			return _btnSetAsDefault;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnSetAsDefault_Click;
			if (_btnSetAsDefault != null)
			{
				_btnSetAsDefault.Click -= value2;
			}
			_btnSetAsDefault = value;
			if (_btnSetAsDefault != null)
			{
				_btnSetAsDefault.Click += value2;
			}
		}
	}

	internal virtual Button btnSave
	{
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = btnSave_Click;
			if (_btnSave != null)
			{
				_btnSave.Click -= value2;
			}
			_btnSave = value;
			if (_btnSave != null)
			{
				_btnSave.Click += value2;
			}
		}
	}

	internal virtual ComboBox cmbLanguage
	{
		get
		{
			return _cmbLanguage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_cmbLanguage = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	public frmOption()
	{
		base.Load += frmOption_Load;
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
		this.gbxOption = new System.Windows.Forms.GroupBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.cmbLanguage = new System.Windows.Forms.ComboBox();
		this.btnClose = new System.Windows.Forms.Button();
		this.btnSetAsDefault = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.lblOriginal = new System.Windows.Forms.Label();
		this.chkOverwrite = new System.Windows.Forms.CheckBox();
		this.txtFreeSpace = new System.Windows.Forms.TextBox();
		this.chkCheckUsedSpace = new System.Windows.Forms.CheckBox();
		this.lblFreeSpace = new System.Windows.Forms.Label();
		this.gbxOption.SuspendLayout();
		this.SuspendLayout();
		this.gbxOption.Controls.Add(this.Label1);
		this.gbxOption.Controls.Add(this.cmbLanguage);
		this.gbxOption.Controls.Add(this.btnClose);
		this.gbxOption.Controls.Add(this.btnSetAsDefault);
		this.gbxOption.Controls.Add(this.btnSave);
		this.gbxOption.Controls.Add(this.lblOriginal);
		this.gbxOption.Controls.Add(this.chkOverwrite);
		this.gbxOption.Controls.Add(this.txtFreeSpace);
		this.gbxOption.Controls.Add(this.chkCheckUsedSpace);
		this.gbxOption.Controls.Add(this.lblFreeSpace);
		this.gbxOption.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.GroupBox groupBox = this.gbxOption;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		groupBox.Location = location;
		this.gbxOption.Name = "gbxOption";
		System.Windows.Forms.GroupBox groupBox2 = this.gbxOption;
		System.Drawing.Size size = new System.Drawing.Size(347, 165);
		groupBox2.Size = size;
		this.gbxOption.TabIndex = 0;
		this.gbxOption.TabStop = false;
		this.gbxOption.Text = "Options";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(12, 99);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(159, 13);
		label2.Size = size;
		this.Label1.TabIndex = 10;
		this.Label1.Text = "Language to Dump (Text Dump)";
		this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cmbLanguage.FormattingEnabled = true;
		this.cmbLanguage.Items.AddRange(new object[6] { "English (EN)", "French (FR)", "Unknow Language 1 (L1)", "Unknow Language 2 (L2)", "Japanese (JP)", "All Language" });
		System.Windows.Forms.ComboBox comboBox = this.cmbLanguage;
		location = new System.Drawing.Point(177, 96);
		comboBox.Location = location;
		this.cmbLanguage.Name = "cmbLanguage";
		System.Windows.Forms.ComboBox comboBox2 = this.cmbLanguage;
		size = new System.Drawing.Size(158, 21);
		comboBox2.Size = size;
		this.cmbLanguage.TabIndex = 9;
		this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		System.Windows.Forms.Button button = this.btnClose;
		location = new System.Drawing.Point(268, 132);
		button.Location = location;
		this.btnClose.Name = "btnClose";
		System.Windows.Forms.Button button2 = this.btnClose;
		size = new System.Drawing.Size(73, 21);
		button2.Size = size;
		this.btnClose.TabIndex = 8;
		this.btnClose.Text = "Close";
		this.btnClose.UseVisualStyleBackColor = true;
		this.btnSetAsDefault.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		System.Windows.Forms.Button button3 = this.btnSetAsDefault;
		location = new System.Drawing.Point(12, 132);
		button3.Location = location;
		this.btnSetAsDefault.Name = "btnSetAsDefault";
		System.Windows.Forms.Button button4 = this.btnSetAsDefault;
		size = new System.Drawing.Size(86, 21);
		button4.Size = size;
		this.btnSetAsDefault.TabIndex = 7;
		this.btnSetAsDefault.Text = "Set as Default";
		this.btnSetAsDefault.UseVisualStyleBackColor = true;
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		System.Windows.Forms.Button button5 = this.btnSave;
		location = new System.Drawing.Point(189, 132);
		button5.Location = location;
		this.btnSave.Name = "btnSave";
		System.Windows.Forms.Button button6 = this.btnSave;
		size = new System.Drawing.Size(73, 21);
		button6.Size = size;
		this.btnSave.TabIndex = 6;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.lblOriginal.AutoSize = true;
		System.Windows.Forms.Label label3 = this.lblOriginal;
		location = new System.Drawing.Point(241, 27);
		label3.Location = location;
		this.lblOriginal.Name = "lblOriginal";
		System.Windows.Forms.Label label4 = this.lblOriginal;
		size = new System.Drawing.Size(100, 13);
		label4.Size = size;
		this.lblOriginal.TabIndex = 5;
		this.lblOriginal.Text = "(original: 00000000)";
		this.chkOverwrite.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox = this.chkOverwrite;
		location = new System.Drawing.Point(15, 73);
		checkBox.Location = location;
		this.chkOverwrite.Name = "chkOverwrite";
		System.Windows.Forms.CheckBox checkBox2 = this.chkOverwrite;
		size = new System.Drawing.Size(297, 17);
		checkBox2.Size = size;
		this.chkOverwrite.TabIndex = 4;
		this.chkOverwrite.Text = "Overwrite old msg if new msg length is less than older one";
		this.chkOverwrite.UseVisualStyleBackColor = true;
		System.Windows.Forms.TextBox textBox = this.txtFreeSpace;
		location = new System.Drawing.Point(145, 24);
		textBox.Location = location;
		this.txtFreeSpace.Name = "txtFreeSpace";
		System.Windows.Forms.TextBox textBox2 = this.txtFreeSpace;
		size = new System.Drawing.Size(90, 20);
		textBox2.Size = size;
		this.txtFreeSpace.TabIndex = 3;
		this.txtFreeSpace.Text = "00000000";
		this.chkCheckUsedSpace.AutoSize = true;
		this.chkCheckUsedSpace.Checked = true;
		this.chkCheckUsedSpace.CheckState = System.Windows.Forms.CheckState.Checked;
		System.Windows.Forms.CheckBox checkBox3 = this.chkCheckUsedSpace;
		location = new System.Drawing.Point(15, 50);
		checkBox3.Location = location;
		this.chkCheckUsedSpace.Name = "chkCheckUsedSpace";
		System.Windows.Forms.CheckBox checkBox4 = this.chkCheckUsedSpace;
		size = new System.Drawing.Size(265, 17);
		checkBox4.Size = size;
		this.chkCheckUsedSpace.TabIndex = 2;
		this.chkCheckUsedSpace.Text = "Check if free space is already used (reccomended)";
		this.chkCheckUsedSpace.UseVisualStyleBackColor = true;
		this.lblFreeSpace.AutoSize = true;
		System.Windows.Forms.Label label5 = this.lblFreeSpace;
		location = new System.Drawing.Point(12, 25);
		label5.Location = location;
		this.lblFreeSpace.Name = "lblFreeSpace";
		System.Windows.Forms.Label label6 = this.lblFreeSpace;
		size = new System.Drawing.Size(128, 13);
		label6.Size = size;
		this.lblFreeSpace.TabIndex = 1;
		this.lblFreeSpace.Text = "FreeSpace Address (Hex)";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(347, 165);
		this.ClientSize = size;
		this.Controls.Add(this.gbxOption);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "frmOption";
		this.ShowInTaskbar = false;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Options Dialog";
		this.gbxOption.ResumeLayout(false);
		this.gbxOption.PerformLayout();
		this.ResumeLayout(false);
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			setSetting();
			Interaction.MsgBox("Settings Saved Temporarily", MsgBoxStyle.Information, "Settings");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
		}
	}

	private void btnSetAsDefault_Click(object sender, EventArgs e)
	{
		try
		{
			setSetting();
			MySettingsProperty.Settings.Save();
			Interaction.MsgBox("Settings Saved Permanently", MsgBoxStyle.Information, "Settings");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "ERROR");
			ProjectData.ClearProjectError();
		}
	}

	private void setSetting()
	{
		ulong num;
		try
		{
			num = Conversions.ToULong("&H" + txtFreeSpace.Text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw new Exception("Hexadecimal value expected");
		}
		if (num > uint.MaxValue)
		{
			throw new Exception("Value is too great");
		}
		MySettingsProperty.Settings.FreeSpaceAddress = num;
		MySettingsProperty.Settings.CheckUsedSpace = chkCheckUsedSpace.Checked;
		MySettingsProperty.Settings.Overwrite = chkOverwrite.Checked;
		switch (cmbLanguage.SelectedIndex)
		{
		case 0:
			MySettingsProperty.Settings.Lang = "EN";
			break;
		case 1:
			MySettingsProperty.Settings.Lang = "FR";
			break;
		case 2:
			MySettingsProperty.Settings.Lang = "L1";
			break;
		case 3:
			MySettingsProperty.Settings.Lang = "L2";
			break;
		case 4:
			MySettingsProperty.Settings.Lang = "JP";
			break;
		case 5:
			MySettingsProperty.Settings.Lang = "ALL";
			break;
		default:
			MySettingsProperty.Settings.Lang = "ALL";
			break;
		}
	}

	private bool getSetting()
	{
		txtFreeSpace.Text = Conversion.Hex(MySettingsProperty.Settings.FreeSpaceAddress);
		chkCheckUsedSpace.Checked = MySettingsProperty.Settings.CheckUsedSpace;
		chkOverwrite.Checked = MySettingsProperty.Settings.Overwrite;
		switch (MySettingsProperty.Settings.Lang)
		{
		case "EN":
			cmbLanguage.SelectedIndex = 0;
			break;
		case "FR":
			cmbLanguage.SelectedIndex = 1;
			break;
		case "L1":
			cmbLanguage.SelectedIndex = 2;
			break;
		case "L2":
			cmbLanguage.SelectedIndex = 3;
			break;
		case "JP":
			cmbLanguage.SelectedIndex = 4;
			break;
		case "ALL":
			cmbLanguage.SelectedIndex = 5;
			break;
		default:
			MySettingsProperty.Settings.Lang = "ALL";
			cmbLanguage.SelectedIndex = 5;
			break;
		}
		return false;
	}

	private void frmOption_Load(object sender, EventArgs e)
	{
		Text = "Options Dialog";
		if (getSetting())
		{
			Text += " *";
		}
		lblOriginal.Text = "(original: " + Conversion.Hex(MySettingsProperty.Settings.Properties["FreeSpaceAddress"].DefaultValue.ToString()) + ")";
	}

	private void txtFreeSpace_TextChanged(object sender, EventArgs e)
	{
	}

	private void txtFreeSpace_Validating(object sender, CancelEventArgs e)
	{
		try
		{
			ulong num = Conversions.ToULong("&H" + txtFreeSpace.Text);
			if (num > uint.MaxValue)
			{
				Interaction.MsgBox("Value is too great", MsgBoxStyle.Exclamation, "ERROR");
				e.Cancel = true;
			}
			if (num < 87965696)
			{
				MsgBoxResult msgBoxResult = Interaction.MsgBox("Input value is small enough that threatens to ruin the game.\r\nContinue?", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo, "ERROR");
				if (msgBoxResult == MsgBoxResult.No)
				{
					e.Cancel = true;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Hexadecimal value expected", MsgBoxStyle.Exclamation, "ERROR");
			e.Cancel = true;
			ProjectData.ClearProjectError();
		}
	}

	private void gbxOption_Enter(object sender, EventArgs e)
	{
	}
}
