<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm1
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
        Me.btnPress = New System.Windows.Forms.Button()
        Me.btnFullTestSuite = New System.Windows.Forms.Button()
        Me.btnStabilityTests = New System.Windows.Forms.Button()
        Me.btnInRushCurrent = New System.Windows.Forms.Button()
        Me.btnRepetitivePeakCurrent = New System.Windows.Forms.Button()
        Me.btnOverload = New System.Windows.Forms.Button()
        Me.btnRepetitivePeakVoltage = New System.Windows.Forms.Button()
        Me.btnMinOnConAngle = New System.Windows.Forms.Button()
        Me.btnOffStateOperation = New System.Windows.Forms.Button()
        Me.btnOnStateDmrSupplyCurrent = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblSerialNum = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbxMinHPF_ResRelays = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxMinLPF_CapRelays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxMinLPF_ResRelays = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxMinHPF_Res = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxMinLPF_Cap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxMinLPF_Res = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxMinWattage = New System.Windows.Forms.TextBox()
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
        Me.lblWattage = New System.Windows.Forms.Label()
        Me.tbxWattage = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPress
        '
        Me.btnPress.Location = New System.Drawing.Point(641, 29)
        Me.btnPress.Name = "btnPress"
        Me.btnPress.Size = New System.Drawing.Size(113, 21)
        Me.btnPress.TabIndex = 2
        Me.btnPress.Text = "Press"
        Me.btnPress.UseVisualStyleBackColor = True
        '
        'btnFullTestSuite
        '
        Me.btnFullTestSuite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullTestSuite.Location = New System.Drawing.Point(42, 29)
        Me.btnFullTestSuite.Name = "btnFullTestSuite"
        Me.btnFullTestSuite.Size = New System.Drawing.Size(130, 29)
        Me.btnFullTestSuite.TabIndex = 1
        Me.btnFullTestSuite.Text = "Full Test Suite"
        Me.btnFullTestSuite.UseVisualStyleBackColor = True
        '
        'btnStabilityTests
        '
        Me.btnStabilityTests.Location = New System.Drawing.Point(42, 82)
        Me.btnStabilityTests.Name = "btnStabilityTests"
        Me.btnStabilityTests.Size = New System.Drawing.Size(130, 21)
        Me.btnStabilityTests.TabIndex = 0
        Me.btnStabilityTests.Text = "Stability Tests"
        Me.btnStabilityTests.UseVisualStyleBackColor = True
        '
        'btnInRushCurrent
        '
        Me.btnInRushCurrent.Location = New System.Drawing.Point(42, 118)
        Me.btnInRushCurrent.Name = "btnInRushCurrent"
        Me.btnInRushCurrent.Size = New System.Drawing.Size(130, 21)
        Me.btnInRushCurrent.TabIndex = 0
        Me.btnInRushCurrent.Text = "InRush Current"
        Me.btnInRushCurrent.UseVisualStyleBackColor = True
        '
        'btnRepetitivePeakCurrent
        '
        Me.btnRepetitivePeakCurrent.Location = New System.Drawing.Point(42, 155)
        Me.btnRepetitivePeakCurrent.Name = "btnRepetitivePeakCurrent"
        Me.btnRepetitivePeakCurrent.Size = New System.Drawing.Size(130, 21)
        Me.btnRepetitivePeakCurrent.TabIndex = 0
        Me.btnRepetitivePeakCurrent.Text = "Repetitive Peak Current"
        Me.btnRepetitivePeakCurrent.UseVisualStyleBackColor = True
        '
        'btnOverload
        '
        Me.btnOverload.Location = New System.Drawing.Point(42, 193)
        Me.btnOverload.Name = "btnOverload"
        Me.btnOverload.Size = New System.Drawing.Size(130, 21)
        Me.btnOverload.TabIndex = 0
        Me.btnOverload.Text = "Overload"
        Me.btnOverload.UseVisualStyleBackColor = True
        '
        'btnRepetitivePeakVoltage
        '
        Me.btnRepetitivePeakVoltage.Location = New System.Drawing.Point(42, 232)
        Me.btnRepetitivePeakVoltage.Name = "btnRepetitivePeakVoltage"
        Me.btnRepetitivePeakVoltage.Size = New System.Drawing.Size(130, 21)
        Me.btnRepetitivePeakVoltage.TabIndex = 0
        Me.btnRepetitivePeakVoltage.Text = "Repetitive Peak Voltage"
        Me.btnRepetitivePeakVoltage.UseVisualStyleBackColor = True
        '
        'btnMinOnConAngle
        '
        Me.btnMinOnConAngle.Location = New System.Drawing.Point(42, 275)
        Me.btnMinOnConAngle.Name = "btnMinOnConAngle"
        Me.btnMinOnConAngle.Size = New System.Drawing.Size(130, 37)
        Me.btnMinOnConAngle.TabIndex = 0
        Me.btnMinOnConAngle.Text = "Min && Max On-State Conduction Angle"
        Me.btnMinOnConAngle.UseVisualStyleBackColor = True
        '
        'btnOffStateOperation
        '
        Me.btnOffStateOperation.Location = New System.Drawing.Point(42, 333)
        Me.btnOffStateOperation.Name = "btnOffStateOperation"
        Me.btnOffStateOperation.Size = New System.Drawing.Size(130, 21)
        Me.btnOffStateOperation.TabIndex = 0
        Me.btnOffStateOperation.Text = "Off-State Operation"
        Me.btnOffStateOperation.UseVisualStyleBackColor = True
        '
        'btnOnStateDmrSupplyCurrent
        '
        Me.btnOnStateDmrSupplyCurrent.Location = New System.Drawing.Point(42, 372)
        Me.btnOnStateDmrSupplyCurrent.Name = "btnOnStateDmrSupplyCurrent"
        Me.btnOnStateDmrSupplyCurrent.Size = New System.Drawing.Size(130, 37)
        Me.btnOnStateDmrSupplyCurrent.TabIndex = 3
        Me.btnOnStateDmrSupplyCurrent.Text = "ON-State Dimmer Supply Current"
        Me.btnOnStateDmrSupplyCurrent.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(17, 35)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(45, 20)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "date "
        '
        'lblSerialNum
        '
        Me.lblSerialNum.AutoSize = True
        Me.lblSerialNum.BackColor = System.Drawing.SystemColors.Control
        Me.lblSerialNum.CausesValidation = False
        Me.lblSerialNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSerialNum.Location = New System.Drawing.Point(19, 39)
        Me.lblSerialNum.Name = "lblSerialNum"
        Me.lblSerialNum.Size = New System.Drawing.Size(153, 20)
        Me.lblSerialNum.TabIndex = 1
        Me.lblSerialNum.Text = "    Test Serial #          "
        Me.lblSerialNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(367, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date && Time"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(17, 55)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 20)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "time"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.lblSerialNum)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(367, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 84)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Test ID #"
        '
        'btnReadFile
        '
        Me.btnReadFile.Location = New System.Drawing.Point(42, 436)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(130, 36)
        Me.btnReadFile.TabIndex = 10
        Me.btnReadFile.Text = "ReadFile"
        Me.btnReadFile.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbxMinHPF_ResRelays)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tbxMinLPF_CapRelays)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbxMinLPF_ResRelays)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.tbxMinHPF_Res)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.tbxMinLPF_Cap)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tbxMinLPF_Res)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.tbxMinWattage)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.tbxConfigFile)
        Me.GroupBox3.Controls.Add(Me.tbxHPF_ResRelays)
        Me.GroupBox3.Controls.Add(Me.lblHPF_ResRelays)
        Me.GroupBox3.Controls.Add(Me.tbxLPF_CapRelays)
        Me.GroupBox3.Controls.Add(Me.lblLPF_CapRelays)
        Me.GroupBox3.Controls.Add(Me.tbxLPF_ResRelays)
        Me.GroupBox3.Controls.Add(Me.lblLPF_ResRelays)
        Me.GroupBox3.Controls.Add(Me.tbxHPF_Res)
        Me.GroupBox3.Controls.Add(Me.lblHPF_Res)
        Me.GroupBox3.Controls.Add(Me.tbxLPF_Cap)
        Me.GroupBox3.Controls.Add(Me.lblLPF_Cap)
        Me.GroupBox3.Controls.Add(Me.tbxLPF_Res)
        Me.GroupBox3.Controls.Add(Me.lblLPF_Res)
        Me.GroupBox3.Controls.Add(Me.lblWattage)
        Me.GroupBox3.Controls.Add(Me.tbxWattage)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(243, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(674, 391)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Test Parameters"
        '
        'tbxMinHPF_ResRelays
        '
        Me.tbxMinHPF_ResRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMinHPF_ResRelays.Location = New System.Drawing.Point(326, 353)
        Me.tbxMinHPF_ResRelays.Name = "tbxMinHPF_ResRelays"
        Me.tbxMinHPF_ResRelays.Size = New System.Drawing.Size(305, 22)
        Me.tbxMinHPF_ResRelays.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "HPF Res Relays"
        '
        'tbxMinLPF_CapRelays
        '
        Me.tbxMinLPF_CapRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMinLPF_CapRelays.Location = New System.Drawing.Point(326, 321)
        Me.tbxMinLPF_CapRelays.Name = "tbxMinLPF_CapRelays"
        Me.tbxMinLPF_CapRelays.Size = New System.Drawing.Size(305, 22)
        Me.tbxMinLPF_CapRelays.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "LPF Cap Relays"
        '
        'tbxMinLPF_ResRelays
        '
        Me.tbxMinLPF_ResRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMinLPF_ResRelays.Location = New System.Drawing.Point(325, 285)
        Me.tbxMinLPF_ResRelays.Name = "tbxMinLPF_ResRelays"
        Me.tbxMinLPF_ResRelays.Size = New System.Drawing.Size(306, 22)
        Me.tbxMinLPF_ResRelays.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "LPF Res Relays"
        '
        'tbxMinHPF_Res
        '
        Me.tbxMinHPF_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMinHPF_Res.Location = New System.Drawing.Point(129, 350)
        Me.tbxMinHPF_Res.Name = "tbxMinHPF_Res"
        Me.tbxMinHPF_Res.Size = New System.Drawing.Size(67, 22)
        Me.tbxMinHPF_Res.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "HPF Resistance"
        '
        'tbxMinLPF_Cap
        '
        Me.tbxMinLPF_Cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMinLPF_Cap.Location = New System.Drawing.Point(129, 315)
        Me.tbxMinLPF_Cap.Name = "tbxMinLPF_Cap"
        Me.tbxMinLPF_Cap.Size = New System.Drawing.Size(67, 22)
        Me.tbxMinLPF_Cap.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "LPF Capacitance"
        '
        'tbxMinLPF_Res
        '
        Me.tbxMinLPF_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMinLPF_Res.Location = New System.Drawing.Point(129, 285)
        Me.tbxMinLPF_Res.Name = "tbxMinLPF_Res"
        Me.tbxMinLPF_Res.Size = New System.Drawing.Size(67, 22)
        Me.tbxMinLPF_Res.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "LPF Resistance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 20)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Dimmer Min Wattage"
        '
        'tbxMinWattage
        '
        Me.tbxMinWattage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMinWattage.Location = New System.Drawing.Point(195, 253)
        Me.tbxMinWattage.Name = "tbxMinWattage"
        Me.tbxMinWattage.Size = New System.Drawing.Size(115, 26)
        Me.tbxMinWattage.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 20)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Config File Location"
        '
        'tbxConfigFile
        '
        Me.tbxConfigFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxConfigFile.Location = New System.Drawing.Point(195, 28)
        Me.tbxConfigFile.Multiline = True
        Me.tbxConfigFile.Name = "tbxConfigFile"
        Me.tbxConfigFile.Size = New System.Drawing.Size(240, 43)
        Me.tbxConfigFile.TabIndex = 85
        '
        'tbxHPF_ResRelays
        '
        Me.tbxHPF_ResRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxHPF_ResRelays.Location = New System.Drawing.Point(322, 204)
        Me.tbxHPF_ResRelays.Name = "tbxHPF_ResRelays"
        Me.tbxHPF_ResRelays.Size = New System.Drawing.Size(305, 22)
        Me.tbxHPF_ResRelays.TabIndex = 84
        '
        'lblHPF_ResRelays
        '
        Me.lblHPF_ResRelays.AutoSize = True
        Me.lblHPF_ResRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPF_ResRelays.Location = New System.Drawing.Point(208, 195)
        Me.lblHPF_ResRelays.Name = "lblHPF_ResRelays"
        Me.lblHPF_ResRelays.Size = New System.Drawing.Size(109, 16)
        Me.lblHPF_ResRelays.TabIndex = 83
        Me.lblHPF_ResRelays.Text = "HPF Res Relays"
        '
        'tbxLPF_CapRelays
        '
        Me.tbxLPF_CapRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLPF_CapRelays.Location = New System.Drawing.Point(325, 163)
        Me.tbxLPF_CapRelays.Name = "tbxLPF_CapRelays"
        Me.tbxLPF_CapRelays.Size = New System.Drawing.Size(305, 22)
        Me.tbxLPF_CapRelays.TabIndex = 82
        '
        'lblLPF_CapRelays
        '
        Me.lblLPF_CapRelays.AutoSize = True
        Me.lblLPF_CapRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPF_CapRelays.Location = New System.Drawing.Point(208, 163)
        Me.lblLPF_CapRelays.Name = "lblLPF_CapRelays"
        Me.lblLPF_CapRelays.Size = New System.Drawing.Size(106, 16)
        Me.lblLPF_CapRelays.TabIndex = 81
        Me.lblLPF_CapRelays.Text = "LPF Cap Relays"
        '
        'tbxLPF_ResRelays
        '
        Me.tbxLPF_ResRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLPF_ResRelays.Location = New System.Drawing.Point(324, 127)
        Me.tbxLPF_ResRelays.Name = "tbxLPF_ResRelays"
        Me.tbxLPF_ResRelays.Size = New System.Drawing.Size(306, 22)
        Me.tbxLPF_ResRelays.TabIndex = 80
        '
        'lblLPF_ResRelays
        '
        Me.lblLPF_ResRelays.AutoSize = True
        Me.lblLPF_ResRelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPF_ResRelays.Location = New System.Drawing.Point(207, 127)
        Me.lblLPF_ResRelays.Name = "lblLPF_ResRelays"
        Me.lblLPF_ResRelays.Size = New System.Drawing.Size(106, 16)
        Me.lblLPF_ResRelays.TabIndex = 79
        Me.lblLPF_ResRelays.Text = "LPF Res Relays"
        '
        'tbxHPF_Res
        '
        Me.tbxHPF_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxHPF_Res.Location = New System.Drawing.Point(128, 192)
        Me.tbxHPF_Res.Name = "tbxHPF_Res"
        Me.tbxHPF_Res.Size = New System.Drawing.Size(67, 22)
        Me.tbxHPF_Res.TabIndex = 78
        '
        'lblHPF_Res
        '
        Me.lblHPF_Res.AutoSize = True
        Me.lblHPF_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPF_Res.Location = New System.Drawing.Point(11, 192)
        Me.lblHPF_Res.Name = "lblHPF_Res"
        Me.lblHPF_Res.Size = New System.Drawing.Size(106, 16)
        Me.lblHPF_Res.TabIndex = 77
        Me.lblHPF_Res.Text = "HPF Resistance"
        '
        'tbxLPF_Cap
        '
        Me.tbxLPF_Cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLPF_Cap.Location = New System.Drawing.Point(128, 157)
        Me.tbxLPF_Cap.Name = "tbxLPF_Cap"
        Me.tbxLPF_Cap.Size = New System.Drawing.Size(67, 22)
        Me.tbxLPF_Cap.TabIndex = 76
        '
        'lblLPF_Cap
        '
        Me.lblLPF_Cap.AutoSize = True
        Me.lblLPF_Cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPF_Cap.Location = New System.Drawing.Point(11, 160)
        Me.lblLPF_Cap.Name = "lblLPF_Cap"
        Me.lblLPF_Cap.Size = New System.Drawing.Size(111, 16)
        Me.lblLPF_Cap.TabIndex = 75
        Me.lblLPF_Cap.Text = "LPF Capacitance"
        '
        'tbxLPF_Res
        '
        Me.tbxLPF_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLPF_Res.Location = New System.Drawing.Point(128, 127)
        Me.tbxLPF_Res.Name = "tbxLPF_Res"
        Me.tbxLPF_Res.Size = New System.Drawing.Size(67, 22)
        Me.tbxLPF_Res.TabIndex = 74
        '
        'lblLPF_Res
        '
        Me.lblLPF_Res.AutoSize = True
        Me.lblLPF_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPF_Res.Location = New System.Drawing.Point(11, 127)
        Me.lblLPF_Res.Name = "lblLPF_Res"
        Me.lblLPF_Res.Size = New System.Drawing.Size(103, 16)
        Me.lblLPF_Res.TabIndex = 73
        Me.lblLPF_Res.Text = "LPF Resistance"
        '
        'lblWattage
        '
        Me.lblWattage.AutoSize = True
        Me.lblWattage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWattage.Location = New System.Drawing.Point(13, 89)
        Me.lblWattage.Name = "lblWattage"
        Me.lblWattage.Size = New System.Drawing.Size(177, 20)
        Me.lblWattage.TabIndex = 59
        Me.lblWattage.Text = "Dimmer Rated Wattage"
        '
        'tbxWattage
        '
        Me.tbxWattage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWattage.Location = New System.Drawing.Point(196, 86)
        Me.tbxWattage.Name = "tbxWattage"
        Me.tbxWattage.Size = New System.Drawing.Size(79, 26)
        Me.tbxWattage.TabIndex = 58
        '
        'MainForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 635)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOnStateDmrSupplyCurrent)
        Me.Controls.Add(Me.btnFullTestSuite)
        Me.Controls.Add(Me.btnStabilityTests)
        Me.Controls.Add(Me.btnOffStateOperation)
        Me.Controls.Add(Me.btnRepetitivePeakVoltage)
        Me.Controls.Add(Me.btnRepetitivePeakCurrent)
        Me.Controls.Add(Me.btnInRushCurrent)
        Me.Controls.Add(Me.btnOverload)
        Me.Controls.Add(Me.btnMinOnConAngle)
        Me.Controls.Add(Me.btnPress)
        Me.Name = "MainForm1"
        Me.Text = "MainForm1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents btnFullTestSuite As Button
    Friend WithEvents btnStabilityTests As Button
    Friend WithEvents btnInRushCurrent As Button
    Friend WithEvents btnRepetitivePeakCurrent As Button
    Friend WithEvents btnOverload As Button
    Friend WithEvents btnRepetitivePeakVoltage As Button
    Friend WithEvents btnMinOnConAngle As Button
    Friend WithEvents btnOffStateOperation As Button
    Friend WithEvents btnOnStateDmrSupplyCurrent As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblSerialNum As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTime As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReadFile As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblWattage As Label
    Friend WithEvents tbxWattage As TextBox
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
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxConfigFile As TextBox
    Friend WithEvents tbxMinHPF_ResRelays As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxMinLPF_CapRelays As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxMinLPF_ResRelays As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxMinHPF_Res As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxMinLPF_Cap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxMinLPF_Res As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxMinWattage As TextBox
End Class
