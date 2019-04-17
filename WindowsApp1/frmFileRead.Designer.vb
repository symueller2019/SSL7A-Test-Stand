<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileRead
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Config File Location"
        '
        'tbxConfigFile
        '
        Me.tbxConfigFile.Location = New System.Drawing.Point(169, 43)
        Me.tbxConfigFile.Name = "tbxConfigFile"
        Me.tbxConfigFile.Size = New System.Drawing.Size(194, 20)
        Me.tbxConfigFile.TabIndex = 73
        '
        'tbxHPF_ResRelays
        '
        Me.tbxHPF_ResRelays.Location = New System.Drawing.Point(170, 431)
        Me.tbxHPF_ResRelays.Name = "tbxHPF_ResRelays"
        Me.tbxHPF_ResRelays.Size = New System.Drawing.Size(76, 20)
        Me.tbxHPF_ResRelays.TabIndex = 72
        '
        'lblHPF_ResRelays
        '
        Me.lblHPF_ResRelays.AutoSize = True
        Me.lblHPF_ResRelays.Location = New System.Drawing.Point(79, 431)
        Me.lblHPF_ResRelays.Name = "lblHPF_ResRelays"
        Me.lblHPF_ResRelays.Size = New System.Drawing.Size(85, 13)
        Me.lblHPF_ResRelays.TabIndex = 71
        Me.lblHPF_ResRelays.Text = "HPF Res Relays"
        '
        'tbxLPF_CapRelays
        '
        Me.tbxLPF_CapRelays.Location = New System.Drawing.Point(170, 399)
        Me.tbxLPF_CapRelays.Name = "tbxLPF_CapRelays"
        Me.tbxLPF_CapRelays.Size = New System.Drawing.Size(76, 20)
        Me.tbxLPF_CapRelays.TabIndex = 70
        '
        'lblLPF_CapRelays
        '
        Me.lblLPF_CapRelays.AutoSize = True
        Me.lblLPF_CapRelays.Location = New System.Drawing.Point(79, 399)
        Me.lblLPF_CapRelays.Name = "lblLPF_CapRelays"
        Me.lblLPF_CapRelays.Size = New System.Drawing.Size(83, 13)
        Me.lblLPF_CapRelays.TabIndex = 69
        Me.lblLPF_CapRelays.Text = "LPF Cap Relays"
        '
        'tbxLPF_ResRelays
        '
        Me.tbxLPF_ResRelays.Location = New System.Drawing.Point(169, 363)
        Me.tbxLPF_ResRelays.Name = "tbxLPF_ResRelays"
        Me.tbxLPF_ResRelays.Size = New System.Drawing.Size(76, 20)
        Me.tbxLPF_ResRelays.TabIndex = 68
        '
        'lblLPF_ResRelays
        '
        Me.lblLPF_ResRelays.AutoSize = True
        Me.lblLPF_ResRelays.Location = New System.Drawing.Point(78, 363)
        Me.lblLPF_ResRelays.Name = "lblLPF_ResRelays"
        Me.lblLPF_ResRelays.Size = New System.Drawing.Size(83, 13)
        Me.lblLPF_ResRelays.TabIndex = 67
        Me.lblLPF_ResRelays.Text = "LPF Res Relays"
        '
        'tbxHPF_Res
        '
        Me.tbxHPF_Res.Location = New System.Drawing.Point(169, 297)
        Me.tbxHPF_Res.Name = "tbxHPF_Res"
        Me.tbxHPF_Res.Size = New System.Drawing.Size(53, 20)
        Me.tbxHPF_Res.TabIndex = 66
        '
        'lblHPF_Res
        '
        Me.lblHPF_Res.AutoSize = True
        Me.lblHPF_Res.Location = New System.Drawing.Point(78, 297)
        Me.lblHPF_Res.Name = "lblHPF_Res"
        Me.lblHPF_Res.Size = New System.Drawing.Size(84, 13)
        Me.lblHPF_Res.TabIndex = 65
        Me.lblHPF_Res.Text = "HPF Resistance"
        '
        'tbxLPF_Cap
        '
        Me.tbxLPF_Cap.Location = New System.Drawing.Point(169, 265)
        Me.tbxLPF_Cap.Name = "tbxLPF_Cap"
        Me.tbxLPF_Cap.Size = New System.Drawing.Size(53, 20)
        Me.tbxLPF_Cap.TabIndex = 64
        '
        'lblLPF_Cap
        '
        Me.lblLPF_Cap.AutoSize = True
        Me.lblLPF_Cap.Location = New System.Drawing.Point(78, 265)
        Me.lblLPF_Cap.Name = "lblLPF_Cap"
        Me.lblLPF_Cap.Size = New System.Drawing.Size(89, 13)
        Me.lblLPF_Cap.TabIndex = 63
        Me.lblLPF_Cap.Text = "LPF Capacitance"
        '
        'tbxLPF_Res
        '
        Me.tbxLPF_Res.Location = New System.Drawing.Point(169, 232)
        Me.tbxLPF_Res.Name = "tbxLPF_Res"
        Me.tbxLPF_Res.Size = New System.Drawing.Size(53, 20)
        Me.tbxLPF_Res.TabIndex = 62
        '
        'lblLPF_Res
        '
        Me.lblLPF_Res.AutoSize = True
        Me.lblLPF_Res.Location = New System.Drawing.Point(78, 232)
        Me.lblLPF_Res.Name = "lblLPF_Res"
        Me.lblLPF_Res.Size = New System.Drawing.Size(82, 13)
        Me.lblLPF_Res.TabIndex = 61
        Me.lblLPF_Res.Text = "LPF Resistance"
        '
        'tbxIndexToTables
        '
        Me.tbxIndexToTables.Location = New System.Drawing.Point(169, 194)
        Me.tbxIndexToTables.Name = "tbxIndexToTables"
        Me.tbxIndexToTables.Size = New System.Drawing.Size(53, 20)
        Me.tbxIndexToTables.TabIndex = 60
        '
        'lblIndexToTables
        '
        Me.lblIndexToTables.AutoSize = True
        Me.lblIndexToTables.Location = New System.Drawing.Point(74, 196)
        Me.lblIndexToTables.Name = "lblIndexToTables"
        Me.lblIndexToTables.Size = New System.Drawing.Size(78, 13)
        Me.lblIndexToTables.TabIndex = 59
        Me.lblIndexToTables.Text = "IndexToTables"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(78, 126)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(54, 30)
        Me.btnStart.TabIndex = 58
        Me.btnStart.Text = "Read"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblWattage
        '
        Me.lblWattage.AutoSize = True
        Me.lblWattage.Location = New System.Drawing.Point(71, 80)
        Me.lblWattage.Name = "lblWattage"
        Me.lblWattage.Size = New System.Drawing.Size(118, 13)
        Me.lblWattage.TabIndex = 57
        Me.lblWattage.Text = "Dimmer Rated Wattage"
        '
        'tbxWattage
        '
        Me.tbxWattage.Location = New System.Drawing.Point(74, 98)
        Me.tbxWattage.Name = "tbxWattage"
        Me.tbxWattage.Size = New System.Drawing.Size(115, 20)
        Me.tbxWattage.TabIndex = 56
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(451, 364)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(99, 20)
        Me.TextBox8.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(453, 348)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "1st Relay"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(451, 305)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(99, 20)
        Me.TextBox7.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(453, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "ResRelaysToClose"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(644, 436)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(72, 20)
        Me.TextBox6.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(646, 420)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Value in HPF at LPF Index"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(644, 380)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(72, 20)
        Me.TextBox5.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(646, 364)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Index in Array HPF"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(637, 150)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(114, 20)
        Me.TextBox4.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(770, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "HPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(770, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "LPF"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(639, 305)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(72, 20)
        Me.TextBox3.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(641, 289)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Index in Array LPF"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(638, 115)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 42
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(639, 84)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 20)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Find Value"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(638, 43)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 25)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "filereader"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmFileRead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 498)
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
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Name = "frmFileRead"
        Me.Text = "Form2"
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
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Timer1 As Timer
End Class
