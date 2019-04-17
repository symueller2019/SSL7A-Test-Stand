<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepetitivePeakVoltage
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
        Me.pbxRepetitivePeakVoltageChart = New System.Windows.Forms.PictureBox()
        Me.pbxRepetitivePeakVoltageText = New System.Windows.Forms.PictureBox()
        Me.tbxRepetitivePeakVoltage = New System.Windows.Forms.TextBox()
        Me.lblRepetitivePeakVoltage = New System.Windows.Forms.Label()
        Me.lblPass_Fail = New System.Windows.Forms.Label()
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
        Me.cbxRepPeakVoltage = New System.Windows.Forms.CheckBox()
        CType(Me.pbxRepetitivePeakVoltageChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRepetitivePeakVoltageText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxRepetitivePeakVoltageChart
        '
        Me.pbxRepetitivePeakVoltageChart.Image = Global.WindowsApp1.My.Resources.Resources.RepetitivePeakVoltageChart_031420191
        Me.pbxRepetitivePeakVoltageChart.Location = New System.Drawing.Point(103, 557)
        Me.pbxRepetitivePeakVoltageChart.Name = "pbxRepetitivePeakVoltageChart"
        Me.pbxRepetitivePeakVoltageChart.Size = New System.Drawing.Size(712, 175)
        Me.pbxRepetitivePeakVoltageChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxRepetitivePeakVoltageChart.TabIndex = 3
        Me.pbxRepetitivePeakVoltageChart.TabStop = False
        '
        'pbxRepetitivePeakVoltageText
        '
        Me.pbxRepetitivePeakVoltageText.Image = Global.WindowsApp1.My.Resources.Resources.RepetitivePeakVoltage_03142019
        Me.pbxRepetitivePeakVoltageText.Location = New System.Drawing.Point(103, 289)
        Me.pbxRepetitivePeakVoltageText.Name = "pbxRepetitivePeakVoltageText"
        Me.pbxRepetitivePeakVoltageText.Size = New System.Drawing.Size(712, 288)
        Me.pbxRepetitivePeakVoltageText.TabIndex = 2
        Me.pbxRepetitivePeakVoltageText.TabStop = False
        '
        'tbxRepetitivePeakVoltage
        '
        Me.tbxRepetitivePeakVoltage.Location = New System.Drawing.Point(194, 44)
        Me.tbxRepetitivePeakVoltage.Name = "tbxRepetitivePeakVoltage"
        Me.tbxRepetitivePeakVoltage.Size = New System.Drawing.Size(66, 20)
        Me.tbxRepetitivePeakVoltage.TabIndex = 4
        '
        'lblRepetitivePeakVoltage
        '
        Me.lblRepetitivePeakVoltage.AutoSize = True
        Me.lblRepetitivePeakVoltage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepetitivePeakVoltage.Location = New System.Drawing.Point(23, 45)
        Me.lblRepetitivePeakVoltage.Name = "lblRepetitivePeakVoltage"
        Me.lblRepetitivePeakVoltage.Size = New System.Drawing.Size(154, 16)
        Me.lblRepetitivePeakVoltage.TabIndex = 5
        Me.lblRepetitivePeakVoltage.Text = "Repetitive Peak Voltage"
        '
        'lblPass_Fail
        '
        Me.lblPass_Fail.AutoSize = True
        Me.lblPass_Fail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass_Fail.Location = New System.Drawing.Point(569, 48)
        Me.lblPass_Fail.Name = "lblPass_Fail"
        Me.lblPass_Fail.Size = New System.Drawing.Size(38, 16)
        Me.lblPass_Fail.TabIndex = 6
        Me.lblPass_Fail.Text = "          "
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(933, 121)
        Me.GroupBox1.TabIndex = 17
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
        Me.lblLimitDsply.Location = New System.Drawing.Point(364, 50)
        Me.lblLimitDsply.MinimumSize = New System.Drawing.Size(50, 20)
        Me.lblLimitDsply.Name = "lblLimitDsply"
        Me.lblLimitDsply.Size = New System.Drawing.Size(50, 20)
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
        'cbxRepPeakVoltage
        '
        Me.cbxRepPeakVoltage.AutoSize = True
        Me.cbxRepPeakVoltage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRepPeakVoltage.Location = New System.Drawing.Point(357, 38)
        Me.cbxRepPeakVoltage.Name = "cbxRepPeakVoltage"
        Me.cbxRepPeakVoltage.Size = New System.Drawing.Size(250, 28)
        Me.cbxRepPeakVoltage.TabIndex = 18
        Me.cbxRepPeakVoltage.Text = "Repetitive Peak Voltage"
        Me.cbxRepPeakVoltage.UseVisualStyleBackColor = True
        '
        'frmRepetitivePeakVoltage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 740)
        Me.Controls.Add(Me.cbxRepPeakVoltage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPass_Fail)
        Me.Controls.Add(Me.lblRepetitivePeakVoltage)
        Me.Controls.Add(Me.tbxRepetitivePeakVoltage)
        Me.Controls.Add(Me.pbxRepetitivePeakVoltageChart)
        Me.Controls.Add(Me.pbxRepetitivePeakVoltageText)
        Me.Name = "frmRepetitivePeakVoltage"
        Me.Text = "frmRepetitivePeakVoltage"
        CType(Me.pbxRepetitivePeakVoltageChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRepetitivePeakVoltageText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxRepetitivePeakVoltageText As PictureBox
    Friend WithEvents pbxRepetitivePeakVoltageChart As PictureBox
    Friend WithEvents tbxRepetitivePeakVoltage As TextBox
    Friend WithEvents lblRepetitivePeakVoltage As Label
    Friend WithEvents lblPass_Fail As Label
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
    Friend WithEvents cbxRepPeakVoltage As CheckBox
End Class
