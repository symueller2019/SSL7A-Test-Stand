<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRepetitivePeakCurrent
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
        Me.pbxRepetitivePeakCurrentText = New System.Windows.Forms.PictureBox()
        Me.tbxRepetitivePeakCurrent = New System.Windows.Forms.TextBox()
        Me.lblPeakCurrent = New System.Windows.Forms.Label()
        Me.tbxRepetitivePeakCurrentTime = New System.Windows.Forms.TextBox()
        Me.lblRepetitivePeakCurrentTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblTestDescription = New System.Windows.Forms.Label()
        Me.lblLimitDsply = New System.Windows.Forms.Label()
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.tbxComment = New System.Windows.Forms.TextBox()
        Me.lblResultDsply = New System.Windows.Forms.Label()
        Me.tbxMeasurementEntry = New System.Windows.Forms.TextBox()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.cbxRepPeakCurrent = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbxCapRly = New System.Windows.Forms.TextBox()
        Me.tbxResRly = New System.Windows.Forms.TextBox()
        Me.lblCapRly = New System.Windows.Forms.Label()
        Me.lblResRly = New System.Windows.Forms.Label()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.lblWatt = New System.Windows.Forms.Label()
        Me.tbxCap = New System.Windows.Forms.TextBox()
        Me.tbxRes = New System.Windows.Forms.TextBox()
        Me.tbxWatt = New System.Windows.Forms.TextBox()
        CType(Me.pbxRepetitivePeakCurrentText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxRepetitivePeakCurrentText
        '
        Me.pbxRepetitivePeakCurrentText.Image = Global.WindowsApp1.My.Resources.Resources.RepetitivePeakCurrent_03142019
        Me.pbxRepetitivePeakCurrentText.Location = New System.Drawing.Point(128, 413)
        Me.pbxRepetitivePeakCurrentText.Name = "pbxRepetitivePeakCurrentText"
        Me.pbxRepetitivePeakCurrentText.Size = New System.Drawing.Size(716, 201)
        Me.pbxRepetitivePeakCurrentText.TabIndex = 0
        Me.pbxRepetitivePeakCurrentText.TabStop = False
        '
        'tbxRepetitivePeakCurrent
        '
        Me.tbxRepetitivePeakCurrent.Location = New System.Drawing.Point(188, 25)
        Me.tbxRepetitivePeakCurrent.Name = "tbxRepetitivePeakCurrent"
        Me.tbxRepetitivePeakCurrent.Size = New System.Drawing.Size(109, 20)
        Me.tbxRepetitivePeakCurrent.TabIndex = 1
        '
        'lblPeakCurrent
        '
        Me.lblPeakCurrent.AutoSize = True
        Me.lblPeakCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeakCurrent.Location = New System.Drawing.Point(17, 29)
        Me.lblPeakCurrent.Name = "lblPeakCurrent"
        Me.lblPeakCurrent.Size = New System.Drawing.Size(149, 16)
        Me.lblPeakCurrent.TabIndex = 2
        Me.lblPeakCurrent.Text = "Measured Peak Current"
        '
        'tbxRepetitivePeakCurrentTime
        '
        Me.tbxRepetitivePeakCurrentTime.Location = New System.Drawing.Point(188, 68)
        Me.tbxRepetitivePeakCurrentTime.Name = "tbxRepetitivePeakCurrentTime"
        Me.tbxRepetitivePeakCurrentTime.Size = New System.Drawing.Size(109, 20)
        Me.tbxRepetitivePeakCurrentTime.TabIndex = 1
        '
        'lblRepetitivePeakCurrentTime
        '
        Me.lblRepetitivePeakCurrentTime.AutoSize = True
        Me.lblRepetitivePeakCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepetitivePeakCurrentTime.Location = New System.Drawing.Point(86, 72)
        Me.lblRepetitivePeakCurrentTime.Name = "lblRepetitivePeakCurrentTime"
        Me.lblRepetitivePeakCurrentTime.Size = New System.Drawing.Size(82, 16)
        Me.lblRepetitivePeakCurrentTime.TabIndex = 3
        Me.lblRepetitivePeakCurrentTime.Text = "Time in Test"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Controls.Add(Me.lblTestDescription)
        Me.GroupBox1.Controls.Add(Me.lblLimitDsply)
        Me.GroupBox1.Controls.Add(Me.lblMeasurement)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.lblComment)
        Me.GroupBox1.Controls.Add(Me.tbxComment)
        Me.GroupBox1.Controls.Add(Me.lblResultDsply)
        Me.GroupBox1.Controls.Add(Me.tbxMeasurementEntry)
        Me.GroupBox1.Controls.Add(Me.lblLimit)
        Me.GroupBox1.Controls.Add(Me.lblTest)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(933, 121)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(457, 81)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(68, 22)
        Me.btnEnter.TabIndex = 21
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblTestDescription
        '
        Me.lblTestDescription.AutoSize = True
        Me.lblTestDescription.BackColor = System.Drawing.SystemColors.Window
        Me.lblTestDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTestDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestDescription.Location = New System.Drawing.Point(14, 50)
        Me.lblTestDescription.MinimumSize = New System.Drawing.Size(300, 20)
        Me.lblTestDescription.Name = "lblTestDescription"
        Me.lblTestDescription.Size = New System.Drawing.Size(300, 20)
        Me.lblTestDescription.TabIndex = 20
        Me.lblTestDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLimitDsply
        '
        Me.lblLimitDsply.AutoSize = True
        Me.lblLimitDsply.BackColor = System.Drawing.SystemColors.Window
        Me.lblLimitDsply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLimitDsply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimitDsply.Location = New System.Drawing.Point(365, 50)
        Me.lblLimitDsply.MinimumSize = New System.Drawing.Size(40, 20)
        Me.lblLimitDsply.Name = "lblLimitDsply"
        Me.lblLimitDsply.Size = New System.Drawing.Size(40, 20)
        Me.lblLimitDsply.TabIndex = 19
        '
        'lblMeasurement
        '
        Me.lblMeasurement.AutoSize = True
        Me.lblMeasurement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeasurement.Location = New System.Drawing.Point(431, 19)
        Me.lblMeasurement.Name = "lblMeasurement"
        Me.lblMeasurement.Size = New System.Drawing.Size(123, 16)
        Me.lblMeasurement.TabIndex = 18
        Me.lblMeasurement.Text = "Measurement Entry"
        Me.lblMeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(576, 19)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(46, 16)
        Me.lblResult.TabIndex = 17
        Me.lblResult.Text = "Result"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(742, 19)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(72, 16)
        Me.lblComment.TabIndex = 16
        Me.lblComment.Text = "Comments"
        '
        'tbxComment
        '
        Me.tbxComment.Location = New System.Drawing.Point(644, 38)
        Me.tbxComment.Multiline = True
        Me.tbxComment.Name = "tbxComment"
        Me.tbxComment.Size = New System.Drawing.Size(266, 65)
        Me.tbxComment.TabIndex = 15
        '
        'lblResultDsply
        '
        Me.lblResultDsply.AutoSize = True
        Me.lblResultDsply.BackColor = System.Drawing.SystemColors.Window
        Me.lblResultDsply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultDsply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultDsply.Location = New System.Drawing.Point(576, 50)
        Me.lblResultDsply.MinimumSize = New System.Drawing.Size(40, 20)
        Me.lblResultDsply.Name = "lblResultDsply"
        Me.lblResultDsply.Size = New System.Drawing.Size(46, 20)
        Me.lblResultDsply.TabIndex = 14
        Me.lblResultDsply.Text = "PASS"
        Me.lblResultDsply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbxMeasurementEntry
        '
        Me.tbxMeasurementEntry.Location = New System.Drawing.Point(457, 50)
        Me.tbxMeasurementEntry.Name = "tbxMeasurementEntry"
        Me.tbxMeasurementEntry.Size = New System.Drawing.Size(68, 20)
        Me.tbxMeasurementEntry.TabIndex = 13
        '
        'lblLimit
        '
        Me.lblLimit.AutoSize = True
        Me.lblLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimit.Location = New System.Drawing.Point(359, 19)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(62, 16)
        Me.lblLimit.TabIndex = 12
        Me.lblLimit.Text = "Limit (uS)"
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTest.Location = New System.Drawing.Point(100, 19)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(106, 16)
        Me.lblTest.TabIndex = 11
        Me.lblTest.Text = "Test Description"
        '
        'cbxRepPeakCurrent
        '
        Me.cbxRepPeakCurrent.AutoSize = True
        Me.cbxRepPeakCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRepPeakCurrent.Location = New System.Drawing.Point(406, 25)
        Me.cbxRepPeakCurrent.Name = "cbxRepPeakCurrent"
        Me.cbxRepPeakCurrent.Size = New System.Drawing.Size(248, 28)
        Me.cbxRepPeakCurrent.TabIndex = 17
        Me.cbxRepPeakCurrent.Text = "Repetitive Peak Current"
        Me.cbxRepPeakCurrent.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbxCapRly)
        Me.GroupBox2.Controls.Add(Me.tbxResRly)
        Me.GroupBox2.Controls.Add(Me.lblCapRly)
        Me.GroupBox2.Controls.Add(Me.lblResRly)
        Me.GroupBox2.Controls.Add(Me.lblCap)
        Me.GroupBox2.Controls.Add(Me.lblRes)
        Me.GroupBox2.Controls.Add(Me.lblWatt)
        Me.GroupBox2.Controls.Add(Me.tbxCap)
        Me.GroupBox2.Controls.Add(Me.tbxRes)
        Me.GroupBox2.Controls.Add(Me.tbxWatt)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 151)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Load Description"
        '
        'tbxCapRly
        '
        Me.tbxCapRly.Location = New System.Drawing.Point(337, 88)
        Me.tbxCapRly.Name = "tbxCapRly"
        Me.tbxCapRly.Size = New System.Drawing.Size(130, 20)
        Me.tbxCapRly.TabIndex = 18
        '
        'tbxResRly
        '
        Me.tbxResRly.Location = New System.Drawing.Point(337, 60)
        Me.tbxResRly.Name = "tbxResRly"
        Me.tbxResRly.Size = New System.Drawing.Size(130, 20)
        Me.tbxResRly.TabIndex = 4
        '
        'lblCapRly
        '
        Me.lblCapRly.AutoSize = True
        Me.lblCapRly.Location = New System.Drawing.Point(273, 92)
        Me.lblCapRly.Name = "lblCapRly"
        Me.lblCapRly.Size = New System.Drawing.Size(51, 13)
        Me.lblCapRly.TabIndex = 2
        Me.lblCapRly.Text = "lblCapRly"
        '
        'lblResRly
        '
        Me.lblResRly.AutoSize = True
        Me.lblResRly.Location = New System.Drawing.Point(273, 63)
        Me.lblResRly.Name = "lblResRly"
        Me.lblResRly.Size = New System.Drawing.Size(51, 13)
        Me.lblResRly.TabIndex = 3
        Me.lblResRly.Text = "lblResRly"
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.Location = New System.Drawing.Point(32, 91)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(36, 13)
        Me.lblCap.TabIndex = 1
        Me.lblCap.Text = "lblCap"
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Location = New System.Drawing.Point(32, 62)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(36, 13)
        Me.lblRes.TabIndex = 1
        Me.lblRes.Text = "lblRes"
        '
        'lblWatt
        '
        Me.lblWatt.AutoSize = True
        Me.lblWatt.Location = New System.Drawing.Point(32, 35)
        Me.lblWatt.Name = "lblWatt"
        Me.lblWatt.Size = New System.Drawing.Size(40, 13)
        Me.lblWatt.TabIndex = 1
        Me.lblWatt.Text = "lblWatt"
        '
        'tbxCap
        '
        Me.tbxCap.Location = New System.Drawing.Point(114, 88)
        Me.tbxCap.Name = "tbxCap"
        Me.tbxCap.Size = New System.Drawing.Size(130, 20)
        Me.tbxCap.TabIndex = 0
        '
        'tbxRes
        '
        Me.tbxRes.Location = New System.Drawing.Point(114, 59)
        Me.tbxRes.Name = "tbxRes"
        Me.tbxRes.Size = New System.Drawing.Size(130, 20)
        Me.tbxRes.TabIndex = 0
        '
        'tbxWatt
        '
        Me.tbxWatt.Location = New System.Drawing.Point(114, 32)
        Me.tbxWatt.Name = "tbxWatt"
        Me.tbxWatt.Size = New System.Drawing.Size(130, 20)
        Me.tbxWatt.TabIndex = 0
        '
        'frmRepetitivePeakCurrent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 626)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbxRepPeakCurrent)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblRepetitivePeakCurrentTime)
        Me.Controls.Add(Me.lblPeakCurrent)
        Me.Controls.Add(Me.tbxRepetitivePeakCurrentTime)
        Me.Controls.Add(Me.tbxRepetitivePeakCurrent)
        Me.Controls.Add(Me.pbxRepetitivePeakCurrentText)
        Me.Name = "frmRepetitivePeakCurrent"
        Me.Text = "Repetitive Peak Current"
        CType(Me.pbxRepetitivePeakCurrentText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxRepetitivePeakCurrentText As PictureBox
    Friend WithEvents tbxRepetitivePeakCurrent As TextBox
    Friend WithEvents lblPeakCurrent As Label
    Friend WithEvents tbxRepetitivePeakCurrentTime As TextBox
    Friend WithEvents lblRepetitivePeakCurrentTime As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblTestDescription As Label
    Friend WithEvents lblLimitDsply As Label
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents tbxComment As TextBox
    Friend WithEvents lblResultDsply As Label
    Friend WithEvents tbxMeasurementEntry As TextBox
    Friend WithEvents lblLimit As Label
    Friend WithEvents lblTest As Label
    Friend WithEvents cbxRepPeakCurrent As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbxCapRly As TextBox
    Friend WithEvents tbxResRly As TextBox
    Friend WithEvents lblCapRly As Label
    Friend WithEvents lblResRly As Label
    Friend WithEvents lblCap As Label
    Friend WithEvents lblRes As Label
    Friend WithEvents lblWatt As Label
    Friend WithEvents tbxCap As TextBox
    Friend WithEvents tbxRes As TextBox
    Friend WithEvents tbxWatt As TextBox
End Class
