<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPELATES
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		VB6_AddADODataBinding()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			VB6_RemoveADODataBinding()
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Private ADOBind_datPrimaryRS As VB6.MBindingCollection
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdRefresh As System.Windows.Forms.Button
	Public WithEvents cmdDelete As System.Windows.Forms.Button
	Public WithEvents cmdUpdate As System.Windows.Forms.Button
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents picButtons As System.Windows.Forms.Panel
	Public WithEvents _txtFields_12 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_11 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_10 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_9 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_8 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_7 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_6 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtFields_0 As System.Windows.Forms.TextBox
	Public WithEvents datPrimaryRS As VB6.ADODC
	Public WithEvents Lab1 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_12 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_11 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_10 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_9 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_8 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_7 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_6 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_5 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_4 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_3 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_2 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_1 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_0 As System.Windows.Forms.Label
	Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtFields As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPELATES))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.picButtons = New System.Windows.Forms.Panel
		Me.cmdClose = New System.Windows.Forms.Button
		Me.cmdRefresh = New System.Windows.Forms.Button
		Me.cmdDelete = New System.Windows.Forms.Button
		Me.cmdUpdate = New System.Windows.Forms.Button
		Me.cmdAdd = New System.Windows.Forms.Button
		Me._txtFields_12 = New System.Windows.Forms.TextBox
		Me._txtFields_11 = New System.Windows.Forms.TextBox
		Me._txtFields_10 = New System.Windows.Forms.TextBox
		Me._txtFields_9 = New System.Windows.Forms.TextBox
		Me._txtFields_8 = New System.Windows.Forms.TextBox
		Me._txtFields_7 = New System.Windows.Forms.TextBox
		Me._txtFields_6 = New System.Windows.Forms.TextBox
		Me._txtFields_5 = New System.Windows.Forms.TextBox
		Me._txtFields_4 = New System.Windows.Forms.TextBox
		Me._txtFields_3 = New System.Windows.Forms.TextBox
		Me._txtFields_2 = New System.Windows.Forms.TextBox
		Me._txtFields_1 = New System.Windows.Forms.TextBox
		Me._txtFields_0 = New System.Windows.Forms.TextBox
		Me.datPrimaryRS = New VB6.ADODC
		Me.Lab1 = New System.Windows.Forms.Label
		Me._lblLabels_12 = New System.Windows.Forms.Label
		Me._lblLabels_11 = New System.Windows.Forms.Label
		Me._lblLabels_10 = New System.Windows.Forms.Label
		Me._lblLabels_9 = New System.Windows.Forms.Label
		Me._lblLabels_8 = New System.Windows.Forms.Label
		Me._lblLabels_7 = New System.Windows.Forms.Label
		Me._lblLabels_6 = New System.Windows.Forms.Label
		Me._lblLabels_5 = New System.Windows.Forms.Label
		Me._lblLabels_4 = New System.Windows.Forms.Label
		Me._lblLabels_3 = New System.Windows.Forms.Label
		Me._lblLabels_2 = New System.Windows.Forms.Label
		Me._lblLabels_1 = New System.Windows.Forms.Label
		Me._lblLabels_0 = New System.Windows.Forms.Label
		Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtFields = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.picButtons.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFields, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "PELATES"
		Me.ClientSize = New System.Drawing.Size(385, 324)
		Me.Location = New System.Drawing.Point(73, 25)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmPELATES"
		Me.picButtons.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.picButtons.ForeColor = System.Drawing.SystemColors.WindowText
		Me.picButtons.Size = New System.Drawing.Size(385, 20)
		Me.picButtons.Location = New System.Drawing.Point(0, 282)
		Me.picButtons.TabIndex = 26
		Me.picButtons.BackColor = System.Drawing.SystemColors.Control
		Me.picButtons.CausesValidation = True
		Me.picButtons.Enabled = True
		Me.picButtons.Cursor = System.Windows.Forms.Cursors.Default
		Me.picButtons.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picButtons.TabStop = True
		Me.picButtons.Visible = True
		Me.picButtons.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picButtons.Name = "picButtons"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.Size = New System.Drawing.Size(73, 20)
		Me.cmdClose.Location = New System.Drawing.Point(312, 0)
		Me.cmdClose.TabIndex = 31
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRefresh.Text = "&Refresh"
		Me.cmdRefresh.Size = New System.Drawing.Size(73, 20)
		Me.cmdRefresh.Location = New System.Drawing.Point(235, 0)
		Me.cmdRefresh.TabIndex = 30
		Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRefresh.CausesValidation = True
		Me.cmdRefresh.Enabled = True
		Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRefresh.TabStop = True
		Me.cmdRefresh.Name = "cmdRefresh"
		Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDelete.Text = "&Delete"
		Me.cmdDelete.Size = New System.Drawing.Size(73, 20)
		Me.cmdDelete.Location = New System.Drawing.Point(158, 0)
		Me.cmdDelete.TabIndex = 29
		Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDelete.CausesValidation = True
		Me.cmdDelete.Enabled = True
		Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDelete.TabStop = True
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdUpdate.Text = "&Update"
		Me.cmdUpdate.Size = New System.Drawing.Size(73, 20)
		Me.cmdUpdate.Location = New System.Drawing.Point(81, 0)
		Me.cmdUpdate.TabIndex = 28
		Me.cmdUpdate.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUpdate.CausesValidation = True
		Me.cmdUpdate.Enabled = True
		Me.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUpdate.TabStop = True
		Me.cmdUpdate.Name = "cmdUpdate"
		Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAdd.Text = "&Add"
		Me.cmdAdd.Size = New System.Drawing.Size(73, 20)
		Me.cmdAdd.Location = New System.Drawing.Point(4, 0)
		Me.cmdAdd.TabIndex = 27
		Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdd.CausesValidation = True
		Me.cmdAdd.Enabled = True
		Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdd.TabStop = True
		Me.cmdAdd.Name = "cmdAdd"
		Me._txtFields_12.AutoSize = False
		Me._txtFields_12.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_12.Location = New System.Drawing.Point(136, 260)
		Me._txtFields_12.TabIndex = 25
		Me._txtFields_12.AcceptsReturn = True
		Me._txtFields_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_12.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_12.CausesValidation = True
		Me._txtFields_12.Enabled = True
		Me._txtFields_12.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_12.HideSelection = True
		Me._txtFields_12.ReadOnly = False
		Me._txtFields_12.Maxlength = 0
		Me._txtFields_12.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_12.MultiLine = False
		Me._txtFields_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_12.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_12.TabStop = True
		Me._txtFields_12.Visible = True
		Me._txtFields_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_12.Name = "_txtFields_12"
		Me._txtFields_11.AutoSize = False
		Me._txtFields_11.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_11.Location = New System.Drawing.Point(136, 239)
		Me._txtFields_11.TabIndex = 23
		Me._txtFields_11.AcceptsReturn = True
		Me._txtFields_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_11.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_11.CausesValidation = True
		Me._txtFields_11.Enabled = True
		Me._txtFields_11.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_11.HideSelection = True
		Me._txtFields_11.ReadOnly = False
		Me._txtFields_11.Maxlength = 0
		Me._txtFields_11.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_11.MultiLine = False
		Me._txtFields_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_11.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_11.TabStop = True
		Me._txtFields_11.Visible = True
		Me._txtFields_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_11.Name = "_txtFields_11"
		Me._txtFields_10.AutoSize = False
		Me._txtFields_10.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_10.Location = New System.Drawing.Point(136, 218)
		Me._txtFields_10.TabIndex = 21
		Me._txtFields_10.AcceptsReturn = True
		Me._txtFields_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_10.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_10.CausesValidation = True
		Me._txtFields_10.Enabled = True
		Me._txtFields_10.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_10.HideSelection = True
		Me._txtFields_10.ReadOnly = False
		Me._txtFields_10.Maxlength = 0
		Me._txtFields_10.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_10.MultiLine = False
		Me._txtFields_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_10.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_10.TabStop = True
		Me._txtFields_10.Visible = True
		Me._txtFields_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_10.Name = "_txtFields_10"
		Me._txtFields_9.AutoSize = False
		Me._txtFields_9.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_9.Location = New System.Drawing.Point(136, 196)
		Me._txtFields_9.TabIndex = 19
		Me._txtFields_9.AcceptsReturn = True
		Me._txtFields_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_9.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_9.CausesValidation = True
		Me._txtFields_9.Enabled = True
		Me._txtFields_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_9.HideSelection = True
		Me._txtFields_9.ReadOnly = False
		Me._txtFields_9.Maxlength = 0
		Me._txtFields_9.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_9.MultiLine = False
		Me._txtFields_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_9.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_9.TabStop = True
		Me._txtFields_9.Visible = True
		Me._txtFields_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_9.Name = "_txtFields_9"
		Me._txtFields_8.AutoSize = False
		Me._txtFields_8.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_8.Location = New System.Drawing.Point(136, 175)
		Me._txtFields_8.TabIndex = 17
		Me._txtFields_8.AcceptsReturn = True
		Me._txtFields_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_8.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_8.CausesValidation = True
		Me._txtFields_8.Enabled = True
		Me._txtFields_8.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_8.HideSelection = True
		Me._txtFields_8.ReadOnly = False
		Me._txtFields_8.Maxlength = 0
		Me._txtFields_8.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_8.MultiLine = False
		Me._txtFields_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_8.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_8.TabStop = True
		Me._txtFields_8.Visible = True
		Me._txtFields_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_8.Name = "_txtFields_8"
		Me._txtFields_7.AutoSize = False
		Me._txtFields_7.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_7.Location = New System.Drawing.Point(136, 154)
		Me._txtFields_7.TabIndex = 15
		Me._txtFields_7.AcceptsReturn = True
		Me._txtFields_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_7.CausesValidation = True
		Me._txtFields_7.Enabled = True
		Me._txtFields_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_7.HideSelection = True
		Me._txtFields_7.ReadOnly = False
		Me._txtFields_7.Maxlength = 0
		Me._txtFields_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_7.MultiLine = False
		Me._txtFields_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_7.TabStop = True
		Me._txtFields_7.Visible = True
		Me._txtFields_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_7.Name = "_txtFields_7"
		Me._txtFields_6.AutoSize = False
		Me._txtFields_6.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_6.Location = New System.Drawing.Point(136, 132)
		Me._txtFields_6.TabIndex = 13
		Me._txtFields_6.AcceptsReturn = True
		Me._txtFields_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_6.CausesValidation = True
		Me._txtFields_6.Enabled = True
		Me._txtFields_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_6.HideSelection = True
		Me._txtFields_6.ReadOnly = False
		Me._txtFields_6.Maxlength = 0
		Me._txtFields_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_6.MultiLine = False
		Me._txtFields_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_6.TabStop = True
		Me._txtFields_6.Visible = True
		Me._txtFields_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_6.Name = "_txtFields_6"
		Me._txtFields_5.AutoSize = False
		Me._txtFields_5.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_5.Location = New System.Drawing.Point(136, 111)
		Me._txtFields_5.TabIndex = 11
		Me._txtFields_5.AcceptsReturn = True
		Me._txtFields_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_5.CausesValidation = True
		Me._txtFields_5.Enabled = True
		Me._txtFields_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_5.HideSelection = True
		Me._txtFields_5.ReadOnly = False
		Me._txtFields_5.Maxlength = 0
		Me._txtFields_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_5.MultiLine = False
		Me._txtFields_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_5.TabStop = True
		Me._txtFields_5.Visible = True
		Me._txtFields_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_5.Name = "_txtFields_5"
		Me._txtFields_4.AutoSize = False
		Me._txtFields_4.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_4.Location = New System.Drawing.Point(136, 90)
		Me._txtFields_4.TabIndex = 9
		Me._txtFields_4.AcceptsReturn = True
		Me._txtFields_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_4.CausesValidation = True
		Me._txtFields_4.Enabled = True
		Me._txtFields_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_4.HideSelection = True
		Me._txtFields_4.ReadOnly = False
		Me._txtFields_4.Maxlength = 0
		Me._txtFields_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_4.MultiLine = False
		Me._txtFields_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_4.TabStop = True
		Me._txtFields_4.Visible = True
		Me._txtFields_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_4.Name = "_txtFields_4"
		Me._txtFields_3.AutoSize = False
		Me._txtFields_3.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_3.Location = New System.Drawing.Point(136, 68)
		Me._txtFields_3.TabIndex = 7
		Me._txtFields_3.AcceptsReturn = True
		Me._txtFields_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_3.CausesValidation = True
		Me._txtFields_3.Enabled = True
		Me._txtFields_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_3.HideSelection = True
		Me._txtFields_3.ReadOnly = False
		Me._txtFields_3.Maxlength = 0
		Me._txtFields_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_3.MultiLine = False
		Me._txtFields_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_3.TabStop = True
		Me._txtFields_3.Visible = True
		Me._txtFields_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_3.Name = "_txtFields_3"
		Me._txtFields_2.AutoSize = False
		Me._txtFields_2.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_2.Location = New System.Drawing.Point(136, 47)
		Me._txtFields_2.TabIndex = 5
		Me._txtFields_2.AcceptsReturn = True
		Me._txtFields_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_2.CausesValidation = True
		Me._txtFields_2.Enabled = True
		Me._txtFields_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_2.HideSelection = True
		Me._txtFields_2.ReadOnly = False
		Me._txtFields_2.Maxlength = 0
		Me._txtFields_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_2.MultiLine = False
		Me._txtFields_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_2.TabStop = True
		Me._txtFields_2.Visible = True
		Me._txtFields_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_2.Name = "_txtFields_2"
		Me._txtFields_1.AutoSize = False
		Me._txtFields_1.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_1.Location = New System.Drawing.Point(136, 26)
		Me._txtFields_1.TabIndex = 3
		Me._txtFields_1.AcceptsReturn = True
		Me._txtFields_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_1.CausesValidation = True
		Me._txtFields_1.Enabled = True
		Me._txtFields_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_1.HideSelection = True
		Me._txtFields_1.ReadOnly = False
		Me._txtFields_1.Maxlength = 0
		Me._txtFields_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_1.MultiLine = False
		Me._txtFields_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_1.TabStop = True
		Me._txtFields_1.Visible = True
		Me._txtFields_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_1.Name = "_txtFields_1"
		Me._txtFields_0.AutoSize = False
		Me._txtFields_0.Size = New System.Drawing.Size(225, 19)
		Me._txtFields_0.Location = New System.Drawing.Point(136, 4)
		Me._txtFields_0.TabIndex = 1
		Me._txtFields_0.AcceptsReturn = True
		Me._txtFields_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFields_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtFields_0.CausesValidation = True
		Me._txtFields_0.Enabled = True
		Me._txtFields_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFields_0.HideSelection = True
		Me._txtFields_0.ReadOnly = False
		Me._txtFields_0.Maxlength = 0
		Me._txtFields_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFields_0.MultiLine = False
		Me._txtFields_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFields_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFields_0.TabStop = True
		Me._txtFields_0.Visible = True
		Me._txtFields_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFields_0.Name = "_txtFields_0"
		Me.datPrimaryRS.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.datPrimaryRS.Size = New System.Drawing.Size(385, 22)
		Me.datPrimaryRS.Location = New System.Drawing.Point(0, 302)
		Me.datPrimaryRS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		Me.datPrimaryRS.ConnectionTimeout = 15
		Me.datPrimaryRS.CommandTimeout = 30
		Me.datPrimaryRS.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		Me.datPrimaryRS.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.datPrimaryRS.CommandType = ADODB.CommandTypeEnum.adCmdUnknown
		Me.datPrimaryRS.CacheSize = 50
		Me.datPrimaryRS.MaxRecords = 0
		Me.datPrimaryRS.BOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.BOFActionEnum.adDoMoveFirst
		Me.datPrimaryRS.EOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.EOFActionEnum.adDoMoveLast
		Me.datPrimaryRS.BackColor = System.Drawing.SystemColors.Window
		Me.datPrimaryRS.ForeColor = System.Drawing.SystemColors.WindowText
		Me.datPrimaryRS.Orientation = Microsoft.VisualBasic.Compatibility.VB6.ADODC.OrientationEnum.adHorizontal
		Me.datPrimaryRS.Enabled = True
		Me.datPrimaryRS.UserName = ""
		Me.datPrimaryRS.RecordSource = "select ONOMA,DIR,RIZA,C1,C2,C3,D1,D2,D3,HME,N1,N2,N3 from PELATES"
		Me.datPrimaryRS.Text = " "
		Me.datPrimaryRS.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=.\pelatesbackup.mdb;"
		Me.datPrimaryRS.Name = "datPrimaryRS"
		Me.Lab1.Size = New System.Drawing.Size(9, 25)
		Me.Lab1.Location = New System.Drawing.Point(376, 176)
		Me.Lab1.TabIndex = 32
		Me.Lab1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Lab1.BackColor = System.Drawing.SystemColors.Control
		Me.Lab1.Enabled = True
		Me.Lab1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Lab1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Lab1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Lab1.UseMnemonic = True
		Me.Lab1.Visible = True
		Me.Lab1.AutoSize = False
		Me.Lab1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Lab1.Name = "Lab1"
		Me._lblLabels_12.Text = "N3:"
		Me._lblLabels_12.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_12.Location = New System.Drawing.Point(8, 260)
		Me._lblLabels_12.TabIndex = 24
		Me._lblLabels_12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_12.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_12.Enabled = True
		Me._lblLabels_12.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_12.UseMnemonic = True
		Me._lblLabels_12.Visible = True
		Me._lblLabels_12.AutoSize = False
		Me._lblLabels_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_12.Name = "_lblLabels_12"
		Me._lblLabels_11.Text = "N2:"
		Me._lblLabels_11.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_11.Location = New System.Drawing.Point(8, 239)
		Me._lblLabels_11.TabIndex = 22
		Me._lblLabels_11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_11.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_11.Enabled = True
		Me._lblLabels_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_11.UseMnemonic = True
		Me._lblLabels_11.Visible = True
		Me._lblLabels_11.AutoSize = False
		Me._lblLabels_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_11.Name = "_lblLabels_11"
		Me._lblLabels_10.Text = "екависто лецехос(MB)"
		Me._lblLabels_10.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_10.Location = New System.Drawing.Point(8, 218)
		Me._lblLabels_10.TabIndex = 20
		Me._lblLabels_10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_10.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_10.Enabled = True
		Me._lblLabels_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_10.UseMnemonic = True
		Me._lblLabels_10.Visible = True
		Me._lblLabels_10.AutoSize = False
		Me._lblLabels_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_10.Name = "_lblLabels_10"
		Me._lblLabels_9.Text = "HME:"
		Me._lblLabels_9.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_9.Location = New System.Drawing.Point(8, 196)
		Me._lblLabels_9.TabIndex = 18
		Me._lblLabels_9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_9.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_9.Enabled = True
		Me._lblLabels_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_9.UseMnemonic = True
		Me._lblLabels_9.Visible = True
		Me._lblLabels_9.AutoSize = False
		Me._lblLabels_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_9.Name = "_lblLabels_9"
		Me._lblLabels_8.Text = "D3:"
		Me._lblLabels_8.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_8.Location = New System.Drawing.Point(8, 175)
		Me._lblLabels_8.TabIndex = 16
		Me._lblLabels_8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_8.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_8.Enabled = True
		Me._lblLabels_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_8.UseMnemonic = True
		Me._lblLabels_8.Visible = True
		Me._lblLabels_8.AutoSize = False
		Me._lblLabels_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_8.Name = "_lblLabels_8"
		Me._lblLabels_7.Text = "D2:"
		Me._lblLabels_7.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_7.Location = New System.Drawing.Point(8, 154)
		Me._lblLabels_7.TabIndex = 14
		Me._lblLabels_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_7.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_7.Enabled = True
		Me._lblLabels_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_7.UseMnemonic = True
		Me._lblLabels_7.Visible = True
		Me._lblLabels_7.AutoSize = False
		Me._lblLabels_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_7.Name = "_lblLabels_7"
		Me._lblLabels_6.Text = "D1:"
		Me._lblLabels_6.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_6.Location = New System.Drawing.Point(8, 132)
		Me._lblLabels_6.TabIndex = 12
		Me._lblLabels_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_6.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_6.Enabled = True
		Me._lblLabels_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_6.UseMnemonic = True
		Me._lblLabels_6.Visible = True
		Me._lblLabels_6.AutoSize = False
		Me._lblLabels_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_6.Name = "_lblLabels_6"
		Me._lblLabels_5.Text = "C3:"
		Me._lblLabels_5.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_5.Location = New System.Drawing.Point(8, 111)
		Me._lblLabels_5.TabIndex = 10
		Me._lblLabels_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_5.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_5.Enabled = True
		Me._lblLabels_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_5.UseMnemonic = True
		Me._lblLabels_5.Visible = True
		Me._lblLabels_5.AutoSize = False
		Me._lblLabels_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_5.Name = "_lblLabels_5"
		Me._lblLabels_4.Text = "C2:"
		Me._lblLabels_4.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_4.Location = New System.Drawing.Point(8, 90)
		Me._lblLabels_4.TabIndex = 8
		Me._lblLabels_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_4.Enabled = True
		Me._lblLabels_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_4.UseMnemonic = True
		Me._lblLabels_4.Visible = True
		Me._lblLabels_4.AutoSize = False
		Me._lblLabels_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_4.Name = "_lblLabels_4"
		Me._lblLabels_3.Text = "C1:"
		Me._lblLabels_3.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_3.Location = New System.Drawing.Point(8, 68)
		Me._lblLabels_3.TabIndex = 6
		Me._lblLabels_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_3.Enabled = True
		Me._lblLabels_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_3.UseMnemonic = True
		Me._lblLabels_3.Visible = True
		Me._lblLabels_3.AutoSize = False
		Me._lblLabels_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_3.Name = "_lblLabels_3"
		Me._lblLabels_2.Text = "RIZA:"
		Me._lblLabels_2.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_2.Location = New System.Drawing.Point(8, 47)
		Me._lblLabels_2.TabIndex = 4
		Me._lblLabels_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_2.Enabled = True
		Me._lblLabels_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_2.UseMnemonic = True
		Me._lblLabels_2.Visible = True
		Me._lblLabels_2.AutoSize = False
		Me._lblLabels_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_2.Name = "_lblLabels_2"
		Me._lblLabels_1.Text = "DIR:"
		Me._lblLabels_1.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_1.Location = New System.Drawing.Point(8, 26)
		Me._lblLabels_1.TabIndex = 2
		Me._lblLabels_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_1.Enabled = True
		Me._lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_1.UseMnemonic = True
		Me._lblLabels_1.Visible = True
		Me._lblLabels_1.AutoSize = False
		Me._lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_1.Name = "_lblLabels_1"
		Me._lblLabels_0.Text = "ONOMA:"
		Me._lblLabels_0.Size = New System.Drawing.Size(121, 17)
		Me._lblLabels_0.Location = New System.Drawing.Point(8, 4)
		Me._lblLabels_0.TabIndex = 0
		Me._lblLabels_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_0.Enabled = True
		Me._lblLabels_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_0.UseMnemonic = True
		Me._lblLabels_0.Visible = True
		Me._lblLabels_0.AutoSize = False
		Me._lblLabels_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_0.Name = "_lblLabels_0"
		Me.Controls.Add(picButtons)
		Me.Controls.Add(_txtFields_12)
		Me.Controls.Add(_txtFields_11)
		Me.Controls.Add(_txtFields_10)
		Me.Controls.Add(_txtFields_9)
		Me.Controls.Add(_txtFields_8)
		Me.Controls.Add(_txtFields_7)
		Me.Controls.Add(_txtFields_6)
		Me.Controls.Add(_txtFields_5)
		Me.Controls.Add(_txtFields_4)
		Me.Controls.Add(_txtFields_3)
		Me.Controls.Add(_txtFields_2)
		Me.Controls.Add(_txtFields_1)
		Me.Controls.Add(_txtFields_0)
		Me.Controls.Add(datPrimaryRS)
		Me.Controls.Add(Lab1)
		Me.Controls.Add(_lblLabels_12)
		Me.Controls.Add(_lblLabels_11)
		Me.Controls.Add(_lblLabels_10)
		Me.Controls.Add(_lblLabels_9)
		Me.Controls.Add(_lblLabels_8)
		Me.Controls.Add(_lblLabels_7)
		Me.Controls.Add(_lblLabels_6)
		Me.Controls.Add(_lblLabels_5)
		Me.Controls.Add(_lblLabels_4)
		Me.Controls.Add(_lblLabels_3)
		Me.Controls.Add(_lblLabels_2)
		Me.Controls.Add(_lblLabels_1)
		Me.Controls.Add(_lblLabels_0)
		Me.picButtons.Controls.Add(cmdClose)
		Me.picButtons.Controls.Add(cmdRefresh)
		Me.picButtons.Controls.Add(cmdDelete)
		Me.picButtons.Controls.Add(cmdUpdate)
		Me.picButtons.Controls.Add(cmdAdd)
		Me.lblLabels.SetIndex(_lblLabels_12, CType(12, Short))
		Me.lblLabels.SetIndex(_lblLabels_11, CType(11, Short))
		Me.lblLabels.SetIndex(_lblLabels_10, CType(10, Short))
		Me.lblLabels.SetIndex(_lblLabels_9, CType(9, Short))
		Me.lblLabels.SetIndex(_lblLabels_8, CType(8, Short))
		Me.lblLabels.SetIndex(_lblLabels_7, CType(7, Short))
		Me.lblLabels.SetIndex(_lblLabels_6, CType(6, Short))
		Me.lblLabels.SetIndex(_lblLabels_5, CType(5, Short))
		Me.lblLabels.SetIndex(_lblLabels_4, CType(4, Short))
		Me.lblLabels.SetIndex(_lblLabels_3, CType(3, Short))
		Me.lblLabels.SetIndex(_lblLabels_2, CType(2, Short))
		Me.lblLabels.SetIndex(_lblLabels_1, CType(1, Short))
		Me.lblLabels.SetIndex(_lblLabels_0, CType(0, Short))
		Me.txtFields.SetIndex(_txtFields_12, CType(12, Short))
		Me.txtFields.SetIndex(_txtFields_11, CType(11, Short))
		Me.txtFields.SetIndex(_txtFields_10, CType(10, Short))
		Me.txtFields.SetIndex(_txtFields_9, CType(9, Short))
		Me.txtFields.SetIndex(_txtFields_8, CType(8, Short))
		Me.txtFields.SetIndex(_txtFields_7, CType(7, Short))
		Me.txtFields.SetIndex(_txtFields_6, CType(6, Short))
		Me.txtFields.SetIndex(_txtFields_5, CType(5, Short))
		Me.txtFields.SetIndex(_txtFields_4, CType(4, Short))
		Me.txtFields.SetIndex(_txtFields_3, CType(3, Short))
		Me.txtFields.SetIndex(_txtFields_2, CType(2, Short))
		Me.txtFields.SetIndex(_txtFields_1, CType(1, Short))
		Me.txtFields.SetIndex(_txtFields_0, CType(0, Short))
		CType(Me.txtFields, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).EndInit()
		Me.picButtons.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
#Region "Upgrade Support"
	Public Sub VB6_AddADODataBinding()
		ADOBind_datPrimaryRS = New VB6.MBindingCollection()
		ADOBind_datPrimaryRS.DataSource = CType(datPrimaryRS, MSDATASRC.DataSource)
		ADOBind_datPrimaryRS.Add(_txtFields_12, "Text", "N3", Nothing, "_txtFields_12")
		ADOBind_datPrimaryRS.Add(_txtFields_11, "Text", "N2", Nothing, "_txtFields_11")
		ADOBind_datPrimaryRS.Add(_txtFields_10, "Text", "N1", Nothing, "_txtFields_10")
		ADOBind_datPrimaryRS.Add(_txtFields_9, "Text", "HME", Nothing, "_txtFields_9")
		ADOBind_datPrimaryRS.Add(_txtFields_8, "Text", "D3", Nothing, "_txtFields_8")
		ADOBind_datPrimaryRS.Add(_txtFields_7, "Text", "D2", Nothing, "_txtFields_7")
		ADOBind_datPrimaryRS.Add(_txtFields_6, "Text", "D1", Nothing, "_txtFields_6")
		ADOBind_datPrimaryRS.Add(_txtFields_5, "Text", "C3", Nothing, "_txtFields_5")
		ADOBind_datPrimaryRS.Add(_txtFields_4, "Text", "C2", Nothing, "_txtFields_4")
		ADOBind_datPrimaryRS.Add(_txtFields_3, "Text", "C1", Nothing, "_txtFields_3")
		ADOBind_datPrimaryRS.Add(_txtFields_2, "Text", "RIZA", Nothing, "_txtFields_2")
		ADOBind_datPrimaryRS.Add(_txtFields_1, "Text", "DIR", Nothing, "_txtFields_1")
		ADOBind_datPrimaryRS.Add(_txtFields_0, "Text", "ONOMA", Nothing, "_txtFields_0")
		ADOBind_datPrimaryRS.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_datPrimaryRS.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_datPrimaryRS.Clear()
		ADOBind_datPrimaryRS.Dispose()
		ADOBind_datPrimaryRS = Nothing
	End Sub
#End Region 
End Class