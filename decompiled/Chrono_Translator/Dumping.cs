using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Chrono_Translator;

[DesignerGenerated]
public class Dumping : Form
{
	private delegate void incDelegate();

	private delegate void setMaxDelegate(int val);

	private delegate void setLabelDelegate(string lbl);

	private delegate void endDelegate(int val);

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblCurrent")]
	private Label _lblCurrent;

	[AccessedThroughProperty("prgDump")]
	private ProgressBar _prgDump;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

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

	internal virtual ProgressBar prgDump
	{
		get
		{
			return _prgDump;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_prgDump = value;
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
			_btnCancel = value;
		}
	}

	public Dumping()
	{
		base.Shown += Dumping_Shown;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.lblCurrent = new System.Windows.Forms.Label();
		this.prgDump = new System.Windows.Forms.ProgressBar();
		this.btnCancel = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		System.Drawing.Point location = new System.Drawing.Point(7, 9);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		System.Drawing.Size size = new System.Drawing.Size(60, 13);
		label2.Size = size;
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Current file:";
		this.lblCurrent.AutoSize = true;
		System.Windows.Forms.Label label3 = this.lblCurrent;
		location = new System.Drawing.Point(73, 9);
		label3.Location = location;
		this.lblCurrent.Name = "lblCurrent";
		System.Windows.Forms.Label label4 = this.lblCurrent;
		size = new System.Drawing.Size(33, 13);
		label4.Size = size;
		this.lblCurrent.TabIndex = 1;
		this.lblCurrent.Text = "None";
		System.Windows.Forms.ProgressBar progressBar = this.prgDump;
		location = new System.Drawing.Point(10, 34);
		progressBar.Location = location;
		this.prgDump.Name = "prgDump";
		System.Windows.Forms.ProgressBar progressBar2 = this.prgDump;
		size = new System.Drawing.Size(373, 22);
		progressBar2.Size = size;
		this.prgDump.TabIndex = 2;
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		System.Windows.Forms.Button button = this.btnCancel;
		location = new System.Drawing.Point(157, 62);
		button.Location = location;
		this.btnCancel.Name = "btnCancel";
		System.Windows.Forms.Button button2 = this.btnCancel;
		size = new System.Drawing.Size(79, 24);
		button2.Size = size;
		this.btnCancel.TabIndex = 3;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(395, 95);
		this.ClientSize = size;
		this.Controls.Add(this.btnCancel);
		this.Controls.Add(this.prgDump);
		this.Controls.Add(this.lblCurrent);
		this.Controls.Add(this.Label1);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "Dumping";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Dumping";
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	public void setDumpMax(int val)
	{
		if (!InvokeRequired)
		{
			prgDump.Maximum = val;
			return;
		}
		setMaxDelegate method = setDumpMax;
		Invoke(method, val);
	}

	public void incrementa()
	{
		if (!InvokeRequired)
		{
			prgDump.Value = checked(prgDump.Value + 1);
			return;
		}
		incDelegate method = incrementa;
		Invoke(method);
	}

	public void setLabel(string lbl)
	{
		if (!InvokeRequired)
		{
			lblCurrent.Text = lbl;
			return;
		}
		setLabelDelegate method = setLabel;
		Invoke(method, lbl);
	}

	public void finished(int val)
	{
		if (!InvokeRequired)
		{
			DialogResult = (DialogResult)Conversions.ToInteger(Interaction.IIf(val == 0, DialogResult.OK, DialogResult.Abort));
			Close();
		}
		else
		{
			endDelegate method = finished;
			Invoke(method, val);
		}
	}

	private void Dumping_Shown(object sender, EventArgs e)
	{
		prgDump.Value = 0;
	}
}
