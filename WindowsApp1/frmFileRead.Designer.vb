<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFileRead
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxConfigFile = New System.Windows.Forms.TextBox()
        Me.tbxHPF_ResRelays = New System.Windows.Forms.TextBox()
        Me.lblHPF_ResRelays = New System.Windows.Forms.Label()
        Me.tbxLPF_CapRelays = New System.Windows.Forms.TextBox()
        Me.lblLPF_CapRelays = New System.Windows.Forms.Label()
        Me.tbxLPF_ResRelays = New System.Windows.Forms.TextBox()
        Me.lblLPF_ResRelays = New System.Windows.Forms.Label()
        Me.tbxHPF_Res = New System.Windows.Forms.TextBox()
        Me.lblHPF_Res = New System.Windows.Forms.Label()
        Me.tbxLPF_Cap = New System.Windows.Forms.TextBox()
        Me.lblLPF_Cap = New System.Windows.Forms.Label()
        Me.tbxLPF_Res = New System.Windows.Forms.TextBox()
        Me.lblLPF_Res = New System.Windows.Forms.Label()
        Me.tbxIndexToTables = New System.Windows.Forms.TextBox()
        Me.lblIndexToTables = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblWattage = New System.Windows.Forms.Label()
        Me.tbxWattage = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tbxMinLPF_ResRelays = New System.Windows.Forms.TextBox()
        Me.lblMinLPF_ResRelays = New System.Windows.Forms.Label()
        Me.lblMinLPF_CapRelays = New System.Windows.Forms.Label()
        Me.tbxMinLPF_CapRelays = New System.Windows.Forms.TextBox()
        Me.tbxMinHPF_ResRelays = New System.Windows.Forms.TextBox()
        Me.lblMinHPF_ResRelays = New System.Windows.Forms.Label()
        Me.tbxMinWattage = New System.Windows.Forms.TextBox()
        Me.lblMinWattage = New System.Windows.Forms.Label()
        Me.tbxIndexToMinTables = New System.Windows.Forms.TextBox()
        Me.IndexToMinTables = New System.Windows.Forms.Label()
        Me.tbxMinHPF_Res = New System.Windows.Forms.TextBox()
        Me.lblMinHPF_Res = New System.Windows.Forms.Label()
        Me.tbxMinLPF_Cap = New System.Windows.Forms.TextBox()
        Me.lblMinLPF_Cap = New System.Windows.Forms.Label()
        Me.tbxMinLPF_Res = New System.Windows.Forms.TextBox()
        Me.lblMinLPF_Res = New System.Windows.Forms.Label()
        Me.lblOVLDWattage = New System.Windows.Forms.Label()
        Me.tbxOVLDWattage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxOVLDLPF_Res = New System.Windows.Forms.TextBox()
        Me.tbxOVLDLPF_Cap = New System.Windows.Forms.TextBox()
        Me.tbxIndexToOVLDTables = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxOVLDLPF_ResRelays = New System.Windows.Forms.TextBox()
        Me.tbxOVLDLPF_CapRelays = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.lblRatedStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTest_Result_Filename = New System.Windows.Forms.Label()
        Me.tbxTestResultFilename = New System.Windows.Forms.TextBox()
        Me.lblDefaultDir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(92, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Config File Location"
        '
        'tbxConfigFile
        '
        Me.tbxConfigFile.Location = New System.Drawing.Point(195, 43)
        Me.tbxConfigFile.Name = "tbxConfigFile"
        Me.tbxConfigFile.Size = New System.Drawing.Size(194, 20)
        Me.tbxConfigFile.TabIndex = 73
        '
        'tbxHPF_ResRelays
        '
        Me.tbxHPF_ResRelays.Location = New System.Drawing.Point(178, 421)
        Me.tbxHPF_ResRelays.Name = "tbxHPF_ResRelays"
        Me.tbxHPF_ResRelays.Size = New System.Drawing.Size(102, 20)
        Me.tbxHPF_ResRelays.TabIndex = 72
        '
        'lblHPF_ResRelays
        '
        Me.lblHPF_ResRelays.AutoSize = True
        Me.lblHPF_ResRelays.Location = New System.Drawing.Point(90, 421)
        Me.lblHPF_ResRelays.Name = "lblHPF_ResRelays"
        Me.lblHPF_ResRelays.Size = New System.Drawing.Size(85, 13)
        Me.lblHPF_ResRelays.TabIndex = 71
        Me.lblHPF_ResRelays.Text = "HPF Res Relays"
        '
        'tbxLPF_CapRelays
        '
        Me.tbxLPF_CapRelays.Location = New System.Drawing.Point(179, 389)
        Me.tbxLPF_CapRelays.Name = "tbxLPF_CapRelays"
        Me.tbxLPF_CapRelays.Size = New System.Drawing.Size(101, 20)
        Me.tbxLPF_CapRelays.TabIndex = 70
        '
        'lblLPF_CapRelays
        '
        Me.lblLPF_CapRelays.AutoSize = True
        Me.lblLPF_CapRelays.Location = New System.Drawing.Point(90, 389)
        Me.lblLPF_CapRelays.Name = "lblLPF_CapRelays"
        Me.lblLPF_CapRelays.Size = New System.Drawing.Size(83, 13)
        Me.lblLPF_CapRelays.TabIndex = 69
        Me.lblLPF_CapRelays.Text = "LPF Cap Relays"
        '
        'tbxLPF_ResRelays
        '
        Me.tbxLPF_ResRelays.Location = New System.Drawing.Point(179, 353)
        Me.tbxLPF_ResRelays.Name = "tbxLPF_ResRelays"
        Me.tbxLPF_ResRelays.Size = New System.Drawing.Size(101, 20)
        Me.tbxLPF_ResRelays.TabIndex = 68
        '
        'lblLPF_ResRelays
        '
        Me.lblLPF_ResRelays.AutoSize = True
        Me.lblLPF_ResRelays.Location = New System.Drawing.Point(89, 353)
        Me.lblLPF_ResRelays.Name = "lblLPF_ResRelays"
        Me.lblLPF_ResRelays.Size = New System.Drawing.Size(83, 13)
        Me.lblLPF_ResRelays.TabIndex = 67
        Me.lblLPF_ResRelays.Text = "LPF Res Relays"
        '
        'tbxHPF_Res
        '
        Me.tbxHPF_Res.Location = New System.Drawing.Point(195, 287)
        Me.tbxHPF_Res.Name = "tbxHPF_Res"
        Me.tbxHPF_Res.Size = New System.Drawing.Size(53, 20)
        Me.tbxHPF_Res.TabIndex = 66
        '
        'lblHPF_Res
        '
        Me.lblHPF_Res.AutoSize = True
        Me.lblHPF_Res.Location = New System.Drawing.Point(89, 287)
        Me.lblHPF_Res.Name = "lblHPF_Res"
        Me.lblHPF_Res.Size = New System.Drawing.Size(84, 13)
        Me.lblHPF_Res.TabIndex = 65
        Me.lblHPF_Res.Text = "HPF Resistance"
        '
        'tbxLPF_Cap
        '
        Me.tbxLPF_Cap.Location = New System.Drawing.Point(195, 255)
        Me.tbxLPF_Cap.Name = "tbxLPF_Cap"
        Me.tbxLPF_Cap.Size = New System.Drawing.Size(53, 20)
        Me.tbxLPF_Cap.TabIndex = 64
        '
        'lblLPF_Cap
        '
        Me.lblLPF_Cap.AutoSize = True
        Me.lblLPF_Cap.Location = New System.Drawing.Point(89, 255)
        Me.lblLPF_Cap.Name = "lblLPF_Cap"
        Me.lblLPF_Cap.Size = New System.Drawing.Size(89, 13)
        Me.lblLPF_Cap.TabIndex = 63
        Me.lblLPF_Cap.Text = "LPF Capacitance"
        '
        'tbxLPF_Res
        '
        Me.tbxLPF_Res.Location = New System.Drawing.Point(195, 222)
        Me.tbxLPF_Res.Name = "tbxLPF_Res"
        Me.tbxLPF_Res.Size = New System.Drawing.Size(53, 20)
        Me.tbxLPF_Res.TabIndex = 62
        '
        'lblLPF_Res
        '
        Me.lblLPF_Res.AutoSize = True
        Me.lblLPF_Res.Location = New System.Drawing.Point(89, 222)
        Me.lblLPF_Res.Name = "lblLPF_Res"
        Me.lblLPF_Res.Size = New System.Drawing.Size(82, 13)
        Me.lblLPF_Res.TabIndex = 61
        Me.lblLPF_Res.Text = "LPF Resistance"
        '
        'tbxIndexToTables
        '
        Me.tbxIndexToTables.Location = New System.Drawing.Point(195, 184)
        Me.tbxIndexToTables.Name = "tbxIndexToTables"
        Me.tbxIndexToTables.Size = New System.Drawing.Size(53, 20)
        Me.tbxIndexToTables.TabIndex = 60
        '
        'lblIndexToTables
        '
        Me.lblIndexToTables.AutoSize = True
        Me.lblIndexToTables.Location = New System.Drawing.Point(89, 187)
        Me.lblIndexToTables.Name = "lblIndexToTables"
        Me.lblIndexToTables.Size = New System.Drawing.Size(78, 13)
        Me.lblIndexToTables.TabIndex = 59
        Me.lblIndexToTables.Text = "IndexToTables"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(54, 30)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Read"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblWattage
        '
        Me.lblWattage.AutoSize = True
        Me.lblWattage.Location = New System.Drawing.Point(83, 95)
        Me.lblWattage.Name = "lblWattage"
        Me.lblWattage.Size = New System.Drawing.Size(118, 13)
        Me.lblWattage.TabIndex = 57
        Me.lblWattage.Text = "Dimmer Rated Wattage"
        '
        'tbxWattage
        '
        Me.tbxWattage.Location = New System.Drawing.Point(178, 139)
        Me.tbxWattage.Name = "tbxWattage"
        Me.tbxWattage.Size = New System.Drawing.Size(37, 20)
        Me.tbxWattage.TabIndex = 1
        '
        'Timer1
        '
        '
        'tbxMinLPF_ResRelays
        '
        Me.tbxMinLPF_ResRelays.Location = New System.Drawing.Point(431, 354)
        Me.tbxMinLPF_ResRelays.Name = "tbxMinLPF_ResRelays"
        Me.tbxMinLPF_ResRelays.Size = New System.Drawing.Size(102, 20)
        Me.tbxMinLPF_ResRelays.TabIndex = 75
        '
        'lblMinLPF_ResRelays
        '
        Me.lblMinLPF_ResRelays.AutoSize = True
        Me.lblMinLPF_ResRelays.Location = New System.Drawing.Point(322, 357)
        Me.lblMinLPF_ResRelays.Name = "lblMinLPF_ResRelays"
        Me.lblMinLPF_ResRelays.Size = New System.Drawing.Size(103, 13)
        Me.lblMinLPF_ResRelays.TabIndex = 76
        Me.lblMinLPF_ResRelays.Text = "Min LPF Res Relays"
        '
        'lblMinLPF_CapRelays
        '
        Me.lblMinLPF_CapRelays.AutoSize = True
        Me.lblMinLPF_CapRelays.Location = New System.Drawing.Point(322, 389)
        Me.lblMinLPF_CapRelays.Name = "lblMinLPF_CapRelays"
        Me.lblMinLPF_CapRelays.Size = New System.Drawing.Size(103, 13)
        Me.lblMinLPF_CapRelays.TabIndex = 78
        Me.lblMinLPF_CapRelays.Text = "Min LPF Cap Relays"
        '
        'tbxMinLPF_CapRelays
        '
        Me.tbxMinLPF_CapRelays.Location = New System.Drawing.Point(431, 386)
        Me.tbxMinLPF_CapRelays.Name = "tbxMinLPF_CapRelays"
        Me.tbxMinLPF_CapRelays.Size = New System.Drawing.Size(102, 20)
        Me.tbxMinLPF_CapRelays.TabIndex = 77
        '
        'tbxMinHPF_ResRelays
        '
        Me.tbxMinHPF_ResRelays.Location = New System.Drawing.Point(431, 418)
        Me.tbxMinHPF_ResRelays.Name = "tbxMinHPF_ResRelays"
        Me.tbxMinHPF_ResRelays.Size = New System.Drawing.Size(102, 20)
        Me.tbxMinHPF_ResRelays.TabIndex = 80
        '
        'lblMinHPF_ResRelays
        '
        Me.lblMinHPF_ResRelays.AutoSize = True
        Me.lblMinHPF_ResRelays.Location = New System.Drawing.Point(340, 418)
        Me.lblMinHPF_ResRelays.Name = "lblMinHPF_ResRelays"
        Me.lblMinHPF_ResRelays.Size = New System.Drawing.Size(85, 13)
        Me.lblMinHPF_ResRelays.TabIndex = 79
        Me.lblMinHPF_ResRelays.Text = "HPF Res Relays"
        '
        'tbxMinWattage
        '
        Me.tbxMinWattage.Location = New System.Drawing.Point(406, 144)
        Me.tbxMinWattage.Name = "tbxMinWattage"
        Me.tbxMinWattage.Size = New System.Drawing.Size(37, 20)
        Me.tbxMinWattage.TabIndex = 2
        '
        'lblMinWattage
        '
        Me.lblMinWattage.AutoSize = True
        Me.lblMinWattage.Location = New System.Drawing.Point(317, 95)
        Me.lblMinWattage.Name = "lblMinWattage"
        Me.lblMinWattage.Size = New System.Drawing.Size(130, 13)
        Me.lblMinWattage.TabIndex = 82
        Me.lblMinWattage.Text = "Dimmer Minimum Wattage"
        '
        'tbxIndexToMinTables
        '
        Me.tbxIndexToMinTables.Location = New System.Drawing.Point(431, 184)
        Me.tbxIndexToMinTables.Name = "tbxIndexToMinTables"
        Me.tbxIndexToMinTables.Size = New System.Drawing.Size(53, 20)
        Me.tbxIndexToMinTables.TabIndex = 83
        '
        'IndexToMinTables
        '
        Me.IndexToMinTables.AutoSize = True
        Me.IndexToMinTables.Location = New System.Drawing.Point(323, 187)
        Me.IndexToMinTables.Name = "IndexToMinTables"
        Me.IndexToMinTables.Size = New System.Drawing.Size(101, 13)
        Me.IndexToMinTables.TabIndex = 84
        Me.IndexToMinTables.Text = "IndexTo Min Tables"
        '
        'tbxMinHPF_Res
        '
        Me.tbxMinHPF_Res.Location = New System.Drawing.Point(431, 284)
        Me.tbxMinHPF_Res.Name = "tbxMinHPF_Res"
        Me.tbxMinHPF_Res.Size = New System.Drawing.Size(53, 20)
        Me.tbxMinHPF_Res.TabIndex = 90
        '
        'lblMinHPF_Res
        '
        Me.lblMinHPF_Res.AutoSize = True
        Me.lblMinHPF_Res.Location = New System.Drawing.Point(322, 284)
        Me.lblMinHPF_Res.Name = "lblMinHPF_Res"
        Me.lblMinHPF_Res.Size = New System.Drawing.Size(104, 13)
        Me.lblMinHPF_Res.TabIndex = 89
        Me.lblMinHPF_Res.Text = "Min HPF Resistance"
        '
        'tbxMinLPF_Cap
        '
        Me.tbxMinLPF_Cap.Location = New System.Drawing.Point(431, 252)
        Me.tbxMinLPF_Cap.Name = "tbxMinLPF_Cap"
        Me.tbxMinLPF_Cap.Size = New System.Drawing.Size(53, 20)
        Me.tbxMinLPF_Cap.TabIndex = 88
        '
        'lblMinLPF_Cap
        '
        Me.lblMinLPF_Cap.AutoSize = True
        Me.lblMinLPF_Cap.Location = New System.Drawing.Point(316, 252)
        Me.lblMinLPF_Cap.Name = "lblMinLPF_Cap"
        Me.lblMinLPF_Cap.Size = New System.Drawing.Size(109, 13)
        Me.lblMinLPF_Cap.TabIndex = 87
        Me.lblMinLPF_Cap.Text = "Min LPF Capacitance"
        '
        'tbxMinLPF_Res
        '
        Me.tbxMinLPF_Res.Location = New System.Drawing.Point(431, 219)
        Me.tbxMinLPF_Res.Name = "tbxMinLPF_Res"
        Me.tbxMinLPF_Res.Size = New System.Drawing.Size(53, 20)
        Me.tbxMinLPF_Res.TabIndex = 86
        '
        'lblMinLPF_Res
        '
        Me.lblMinLPF_Res.AutoSize = True
        Me.lblMinLPF_Res.Location = New System.Drawing.Point(322, 222)
        Me.lblMinLPF_Res.Name = "lblMinLPF_Res"
        Me.lblMinLPF_Res.Size = New System.Drawing.Size(102, 13)
        Me.lblMinLPF_Res.TabIndex = 85
        Me.lblMinLPF_Res.Text = "Min LPF Resistance"
        '
        'lblOVLDWattage
        '
        Me.lblOVLDWattage.AutoSize = True
        Me.lblOVLDWattage.Location = New System.Drawing.Point(588, 95)
        Me.lblOVLDWattage.Name = "lblOVLDWattage"
        Me.lblOVLDWattage.Size = New System.Drawing.Size(132, 13)
        Me.lblOVLDWattage.TabIndex = 91
        Me.lblOVLDWattage.Text = "Dimmer Overload Wattage"
        '
        'tbxOVLDWattage
        '
        Me.tbxOVLDWattage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOVLDWattage.Location = New System.Drawing.Point(591, 111)
        Me.tbxOVLDWattage.Name = "tbxOVLDWattage"
        Me.tbxOVLDWattage.Size = New System.Drawing.Size(115, 24)
        Me.tbxOVLDWattage.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(593, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "OVLD LPF Resistance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(593, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "OVLD LPF Capacitance"
        '
        'tbxOVLDLPF_Res
        '
        Me.tbxOVLDLPF_Res.Location = New System.Drawing.Point(723, 219)
        Me.tbxOVLDLPF_Res.Name = "tbxOVLDLPF_Res"
        Me.tbxOVLDLPF_Res.Size = New System.Drawing.Size(53, 20)
        Me.tbxOVLDLPF_Res.TabIndex = 95
        '
        'tbxOVLDLPF_Cap
        '
        Me.tbxOVLDLPF_Cap.Location = New System.Drawing.Point(723, 252)
        Me.tbxOVLDLPF_Cap.Name = "tbxOVLDLPF_Cap"
        Me.tbxOVLDLPF_Cap.Size = New System.Drawing.Size(53, 20)
        Me.tbxOVLDLPF_Cap.TabIndex = 96
        '
        'tbxIndexToOVLDTables
        '
        Me.tbxIndexToOVLDTables.Location = New System.Drawing.Point(723, 184)
        Me.tbxIndexToOVLDTables.Name = "tbxIndexToOVLDTables"
        Me.tbxIndexToOVLDTables.Size = New System.Drawing.Size(53, 20)
        Me.tbxIndexToOVLDTables.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(587, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "IndexTo Overload Tables"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(593, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "OVLD LPF Res Relays"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(593, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "OVLD LPF Cap Relays"
        '
        'tbxOVLDLPF_ResRelays
        '
        Me.tbxOVLDLPF_ResRelays.Location = New System.Drawing.Point(723, 353)
        Me.tbxOVLDLPF_ResRelays.Name = "tbxOVLDLPF_ResRelays"
        Me.tbxOVLDLPF_ResRelays.Size = New System.Drawing.Size(102, 20)
        Me.tbxOVLDLPF_ResRelays.TabIndex = 101
        '
        'tbxOVLDLPF_CapRelays
        '
        Me.tbxOVLDLPF_CapRelays.Location = New System.Drawing.Point(723, 386)
        Me.tbxOVLDLPF_CapRelays.Name = "tbxOVLDLPF_CapRelays"
        Me.tbxOVLDLPF_CapRelays.Size = New System.Drawing.Size(102, 20)
        Me.tbxOVLDLPF_CapRelays.TabIndex = 102
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(86, 111)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(115, 22)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 18
        Me.ListBox2.Location = New System.Drawing.Point(319, 113)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(115, 22)
        Me.ListBox2.TabIndex = 1
        '
        'lblRatedStatus
        '
        Me.lblRatedStatus.AutoSize = True
        Me.lblRatedStatus.Location = New System.Drawing.Point(83, 133)
        Me.lblRatedStatus.Name = "lblRatedStatus"
        Me.lblRatedStatus.Size = New System.Drawing.Size(89, 26)
        Me.lblRatedStatus.TabIndex = 107
        Me.lblRatedStatus.Text = "Clink to Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bkgrnd goes blue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 26)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Clink to Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bkgrd goes blue"
        '
        'lblTest_Result_Filename
        '
        Me.lblTest_Result_Filename.AutoSize = True
        Me.lblTest_Result_Filename.Location = New System.Drawing.Point(536, 46)
        Me.lblTest_Result_Filename.Name = "lblTest_Result_Filename"
        Me.lblTest_Result_Filename.Size = New System.Drawing.Size(106, 13)
        Me.lblTest_Result_Filename.TabIndex = 108
        Me.lblTest_Result_Filename.Text = "Test Result Filename"
        '
        'tbxTestResultFilename
        '
        Me.tbxTestResultFilename.Location = New System.Drawing.Point(648, 43)
        Me.tbxTestResultFilename.Name = "tbxTestResultFilename"
        Me.tbxTestResultFilename.Size = New System.Drawing.Size(194, 20)
        Me.tbxTestResultFilename.TabIndex = 109
        '
        'lblDefaultDir
        '
        Me.lblDefaultDir.AutoSize = True
        Me.lblDefaultDir.Location = New System.Drawing.Point(649, 18)
        Me.lblDefaultDir.Name = "lblDefaultDir"
        Me.lblDefaultDir.Size = New System.Drawing.Size(60, 13)
        Me.lblDefaultDir.TabIndex = 110
        Me.lblDefaultDir.Text = "Default Dir:"
        '
        'frmFileRead
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 559)
        Me.Controls.Add(Me.lblDefaultDir)
        Me.Controls.Add(Me.tbxTestResultFilename)
        Me.Controls.Add(Me.lblTest_Result_Filename)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblRatedStatus)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.tbxOVLDLPF_CapRelays)
        Me.Controls.Add(Me.tbxOVLDLPF_ResRelays)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxIndexToOVLDTables)
        Me.Controls.Add(Me.tbxOVLDLPF_Cap)
        Me.Controls.Add(Me.tbxOVLDLPF_Res)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxOVLDWattage)
        Me.Controls.Add(Me.lblOVLDWattage)
        Me.Controls.Add(Me.tbxMinHPF_Res)
        Me.Controls.Add(Me.lblMinHPF_Res)
        Me.Controls.Add(Me.tbxMinLPF_Cap)
        Me.Controls.Add(Me.lblMinLPF_Cap)
        Me.Controls.Add(Me.tbxMinLPF_Res)
        Me.Controls.Add(Me.lblMinLPF_Res)
        Me.Controls.Add(Me.IndexToMinTables)
        Me.Controls.Add(Me.tbxIndexToMinTables)
        Me.Controls.Add(Me.lblMinWattage)
        Me.Controls.Add(Me.tbxMinWattage)
        Me.Controls.Add(Me.tbxMinHPF_ResRelays)
        Me.Controls.Add(Me.lblMinHPF_ResRelays)
        Me.Controls.Add(Me.lblMinLPF_CapRelays)
        Me.Controls.Add(Me.tbxMinLPF_CapRelays)
        Me.Controls.Add(Me.lblMinLPF_ResRelays)
        Me.Controls.Add(Me.tbxMinLPF_ResRelays)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbxConfigFile)
        Me.Controls.Add(Me.tbxHPF_ResRelays)
        Me.Controls.Add(Me.lblHPF_ResRelays)
        Me.Controls.Add(Me.tbxLPF_CapRelays)
        Me.Controls.Add(Me.lblLPF_CapRelays)
        Me.Controls.Add(Me.tbxLPF_ResRelays)
        Me.Controls.Add(Me.lblLPF_ResRelays)
        Me.Controls.Add(Me.tbxHPF_Res)
        Me.Controls.Add(Me.lblHPF_Res)
        Me.Controls.Add(Me.tbxLPF_Cap)
        Me.Controls.Add(Me.lblLPF_Cap)
        Me.Controls.Add(Me.tbxLPF_Res)
        Me.Controls.Add(Me.lblLPF_Res)
        Me.Controls.Add(Me.tbxIndexToTables)
        Me.Controls.Add(Me.lblIndexToTables)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWattage)
        Me.Controls.Add(Me.tbxWattage)
        Me.Name = "frmFileRead"
        Me.Text = "FileRead"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents tbxConfigFile As TextBox
    Friend WithEvents tbxHPF_ResRelays As TextBox
    Friend WithEvents lblHPF_ResRelays As Label
    Friend WithEvents tbxLPF_CapRelays As TextBox
    Friend WithEvents lblLPF_CapRelays As Label
    Friend WithEvents tbxLPF_ResRelays As TextBox
    Friend WithEvents lblLPF_ResRelays As Label
    Friend WithEvents tbxHPF_Res As TextBox
    Friend WithEvents lblHPF_Res As Label
    Friend WithEvents tbxLPF_Cap As TextBox
    Friend WithEvents lblLPF_Cap As Label
    Friend WithEvents tbxLPF_Res As TextBox
    Friend WithEvents lblLPF_Res As Label
    Friend WithEvents tbxIndexToTables As TextBox
    Friend WithEvents lblIndexToTables As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lblWattage As Label
    Friend WithEvents tbxWattage As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tbxMinLPF_ResRelays As TextBox
    Friend WithEvents lblMinLPF_ResRelays As Label
    Friend WithEvents lblMinLPF_CapRelays As Label
    Friend WithEvents tbxMinLPF_CapRelays As TextBox
    Friend WithEvents tbxMinHPF_ResRelays As TextBox
    Friend WithEvents lblMinHPF_ResRelays As Label
    Friend WithEvents tbxMinWattage As TextBox
    Friend WithEvents lblMinWattage As Label
    Friend WithEvents tbxIndexToMinTables As TextBox
    Friend WithEvents IndexToMinTables As Label
    Friend WithEvents tbxMinHPF_Res As TextBox
    Friend WithEvents lblMinHPF_Res As Label
    Friend WithEvents tbxMinLPF_Cap As TextBox
    Friend WithEvents lblMinLPF_Cap As Label
    Friend WithEvents tbxMinLPF_Res As TextBox
    Friend WithEvents lblMinLPF_Res As Label
    Friend WithEvents lblOVLDWattage As Label
    Friend WithEvents tbxOVLDWattage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxOVLDLPF_Res As TextBox
    Friend WithEvents tbxOVLDLPF_Cap As TextBox
    Friend WithEvents tbxIndexToOVLDTables As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxOVLDLPF_ResRelays As TextBox
    Friend WithEvents tbxOVLDLPF_CapRelays As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents lblRatedStatus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTest_Result_Filename As Label
    Friend WithEvents tbxTestResultFilename As TextBox
    Friend WithEvents lblDefaultDir As Label
End Class
