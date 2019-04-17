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
        Me.lblDisplay = New System.Windows.Forms.Label()
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
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.CausesValidation = False
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDisplay.Location = New System.Drawing.Point(641, 82)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(131, 22)
        Me.lblDisplay.TabIndex = 1
        Me.lblDisplay.Text = "                        "
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBox1.Location = New System.Drawing.Point(367, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 115)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date && Time"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(17, 70)
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
        Me.GroupBox2.Location = New System.Drawing.Point(367, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 84)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Test ID #"
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(592, 132)
        Me.btnHigh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(88, 24)
        Me.btnHigh.TabIndex = 8
        Me.btnHigh.Text = "High"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(592, 160)
        Me.btnLow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(88, 24)
        Me.btnLow.TabIndex = 9
        Me.btnLow.Text = "Low"
        Me.btnLow.UseVisualStyleBackColor = True
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
        'MainForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 548)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOnStateDmrSupplyCurrent)
        Me.Controls.Add(Me.lblDisplay)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents lblDisplay As Label
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
    Friend WithEvents btnHigh As Button
    Friend WithEvents btnLow As Button
    Friend WithEvents btnReadFile As Button
End Class
