<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOnStateSupplyCurrent
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.cbx100ohm = New System.Windows.Forms.CheckBox()
        Me.cbx350ohm = New System.Windows.Forms.CheckBox()
        Me.cbx800ohm = New System.Windows.Forms.CheckBox()
        Me.cbx1400ohm = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxLimitDsply1 = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblTestDescription = New System.Windows.Forms.Label()
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.tbxComment = New System.Windows.Forms.TextBox()
        Me.lblResultDsply = New System.Windows.Forms.Label()
        Me.tbxMeasurementEntry1 = New System.Windows.Forms.TextBox()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.tbxMeasurementEntry2 = New System.Windows.Forms.TextBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.tbxLimitDsply2 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.DmrOnStateSupplyCurrent_Text_031420191
        Me.PictureBox2.Location = New System.Drawing.Point(26, 250)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(887, 611)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.DmrOnStateSupplyCurrent_03142019
        Me.PictureBox1.Location = New System.Drawing.Point(148, 261)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(571, 477)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(765, 24)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(80, 30)
        Me.btnInfo.TabIndex = 6
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'cbx100ohm
        '
        Me.cbx100ohm.AutoSize = True
        Me.cbx100ohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx100ohm.Location = New System.Drawing.Point(47, 26)
        Me.cbx100ohm.Name = "cbx100ohm"
        Me.cbx100ohm.Size = New System.Drawing.Size(109, 28)
        Me.cbx100ohm.TabIndex = 9
        Me.cbx100ohm.Text = "100 ohm"
        Me.cbx100ohm.UseVisualStyleBackColor = True
        '
        'cbx350ohm
        '
        Me.cbx350ohm.AutoSize = True
        Me.cbx350ohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx350ohm.Location = New System.Drawing.Point(212, 26)
        Me.cbx350ohm.Name = "cbx350ohm"
        Me.cbx350ohm.Size = New System.Drawing.Size(109, 28)
        Me.cbx350ohm.TabIndex = 10
        Me.cbx350ohm.Text = "350 ohm"
        Me.cbx350ohm.UseVisualStyleBackColor = True
        '
        'cbx800ohm
        '
        Me.cbx800ohm.AutoSize = True
        Me.cbx800ohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx800ohm.Location = New System.Drawing.Point(374, 26)
        Me.cbx800ohm.Name = "cbx800ohm"
        Me.cbx800ohm.Size = New System.Drawing.Size(109, 28)
        Me.cbx800ohm.TabIndex = 11
        Me.cbx800ohm.Text = "800 ohm"
        Me.cbx800ohm.UseVisualStyleBackColor = True
        '
        'cbx1400ohm
        '
        Me.cbx1400ohm.AutoSize = True
        Me.cbx1400ohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx1400ohm.Location = New System.Drawing.Point(552, 26)
        Me.cbx1400ohm.Name = "cbx1400ohm"
        Me.cbx1400ohm.Size = New System.Drawing.Size(120, 28)
        Me.cbx1400ohm.TabIndex = 12
        Me.cbx1400ohm.Text = "1400 ohm"
        Me.cbx1400ohm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.tbxLimitDsply2)
        Me.GroupBox1.Controls.Add(Me.lblMax)
        Me.GroupBox1.Controls.Add(Me.lblMin)
        Me.GroupBox1.Controls.Add(Me.tbxMeasurementEntry2)
        Me.GroupBox1.Controls.Add(Me.tbxLimitDsply1)
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Controls.Add(Me.lblTestDescription)
        Me.GroupBox1.Controls.Add(Me.lblMeasurement)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.lblComment)
        Me.GroupBox1.Controls.Add(Me.tbxComment)
        Me.GroupBox1.Controls.Add(Me.lblResultDsply)
        Me.GroupBox1.Controls.Add(Me.tbxMeasurementEntry1)
        Me.GroupBox1.Controls.Add(Me.lblLimit)
        Me.GroupBox1.Controls.Add(Me.lblTest)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(933, 152)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'tbxLimitDsply1
        '
        Me.tbxLimitDsply1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLimitDsply1.Location = New System.Drawing.Point(353, 48)
        Me.tbxLimitDsply1.MaximumSize = New System.Drawing.Size(76, 65)
        Me.tbxLimitDsply1.Multiline = True
        Me.tbxLimitDsply1.Name = "tbxLimitDsply1"
        Me.tbxLimitDsply1.Size = New System.Drawing.Size(76, 22)
        Me.tbxLimitDsply1.TabIndex = 22
        Me.tbxLimitDsply1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(457, 112)
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
        'tbxMeasurementEntry1
        '
        Me.tbxMeasurementEntry1.Location = New System.Drawing.Point(457, 50)
        Me.tbxMeasurementEntry1.Name = "tbxMeasurementEntry1"
        Me.tbxMeasurementEntry1.Size = New System.Drawing.Size(68, 20)
        Me.tbxMeasurementEntry1.TabIndex = 13
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
        'tbxMeasurementEntry2
        '
        Me.tbxMeasurementEntry2.Location = New System.Drawing.Point(457, 83)
        Me.tbxMeasurementEntry2.Name = "tbxMeasurementEntry2"
        Me.tbxMeasurementEntry2.Size = New System.Drawing.Size(68, 20)
        Me.tbxMeasurementEntry2.TabIndex = 23
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(531, 51)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(29, 16)
        Me.lblMin.TabIndex = 24
        Me.lblMin.Text = "Min"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(531, 87)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(33, 16)
        Me.lblMax.TabIndex = 25
        Me.lblMax.Text = "Max"
        '
        'tbxLimitDsply2
        '
        Me.tbxLimitDsply2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLimitDsply2.Location = New System.Drawing.Point(353, 83)
        Me.tbxLimitDsply2.MaximumSize = New System.Drawing.Size(76, 65)
        Me.tbxLimitDsply2.Multiline = True
        Me.tbxLimitDsply2.Name = "tbxLimitDsply2"
        Me.tbxLimitDsply2.Size = New System.Drawing.Size(76, 22)
        Me.tbxLimitDsply2.TabIndex = 26
        Me.tbxLimitDsply2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmOnStateSupplyCurrent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 873)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbx1400ohm)
        Me.Controls.Add(Me.cbx800ohm)
        Me.Controls.Add(Me.cbx350ohm)
        Me.Controls.Add(Me.cbx100ohm)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmOnStateSupplyCurrent"
        Me.Text = "frmOnStateSupplyCurrent"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents cbx100ohm As CheckBox
    Friend WithEvents cbx350ohm As CheckBox
    Friend WithEvents cbx800ohm As CheckBox
    Friend WithEvents cbx1400ohm As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxLimitDsply1 As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblTestDescription As Label
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents tbxComment As TextBox
    Friend WithEvents lblResultDsply As Label
    Friend WithEvents tbxMeasurementEntry1 As TextBox
    Friend WithEvents lblLimit As Label
    Friend WithEvents lblTest As Label
    Friend WithEvents tbxMeasurementEntry2 As TextBox
    Friend WithEvents lblMax As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents tbxLimitDsply2 As TextBox
End Class
