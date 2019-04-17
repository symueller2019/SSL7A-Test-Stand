<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffStateOperation
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbx10ohm = New System.Windows.Forms.CheckBox()
        Me.cbx40ohm = New System.Windows.Forms.CheckBox()
        Me.cbx400ohm = New System.Windows.Forms.CheckBox()
        Me.cbx3kohm = New System.Windows.Forms.CheckBox()
        Me.cbx8kohm = New System.Windows.Forms.CheckBox()
        Me.cbx15kohm = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxLimitDsply = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblTestDescription = New System.Windows.Forms.Label()
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.tbxComment = New System.Windows.Forms.TextBox()
        Me.lblResultDsply = New System.Windows.Forms.Label()
        Me.tbxMeasurementEntry = New System.Windows.Forms.TextBox()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.DmrOffStateCurrent_03142019
        Me.PictureBox1.Location = New System.Drawing.Point(91, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(753, 647)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'cbx10ohm
        '
        Me.cbx10ohm.AutoSize = True
        Me.cbx10ohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx10ohm.Location = New System.Drawing.Point(30, 28)
        Me.cbx10ohm.Name = "cbx10ohm"
        Me.cbx10ohm.Size = New System.Drawing.Size(98, 28)
        Me.cbx10ohm.TabIndex = 8
        Me.cbx10ohm.Text = "10 ohm"
        Me.cbx10ohm.UseVisualStyleBackColor = True
        '
        'cbx40ohm
        '
        Me.cbx40ohm.AutoSize = True
        Me.cbx40ohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx40ohm.Location = New System.Drawing.Point(192, 28)
        Me.cbx40ohm.Name = "cbx40ohm"
        Me.cbx40ohm.Size = New System.Drawing.Size(98, 28)
        Me.cbx40ohm.TabIndex = 9
        Me.cbx40ohm.Text = "40 ohm"
        Me.cbx40ohm.UseVisualStyleBackColor = True
        '
        'cbx400ohm
        '
        Me.cbx400ohm.AutoSize = True
        Me.cbx400ohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx400ohm.Location = New System.Drawing.Point(354, 28)
        Me.cbx400ohm.Name = "cbx400ohm"
        Me.cbx400ohm.Size = New System.Drawing.Size(109, 28)
        Me.cbx400ohm.TabIndex = 10
        Me.cbx400ohm.Text = "400 ohm"
        Me.cbx400ohm.UseVisualStyleBackColor = True
        '
        'cbx3kohm
        '
        Me.cbx3kohm.AutoSize = True
        Me.cbx3kohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx3kohm.Location = New System.Drawing.Point(512, 28)
        Me.cbx3kohm.Name = "cbx3kohm"
        Me.cbx3kohm.Size = New System.Drawing.Size(97, 28)
        Me.cbx3kohm.TabIndex = 11
        Me.cbx3kohm.Text = "3k ohm"
        Me.cbx3kohm.UseVisualStyleBackColor = True
        '
        'cbx8kohm
        '
        Me.cbx8kohm.AutoSize = True
        Me.cbx8kohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx8kohm.Location = New System.Drawing.Point(675, 28)
        Me.cbx8kohm.Name = "cbx8kohm"
        Me.cbx8kohm.Size = New System.Drawing.Size(97, 28)
        Me.cbx8kohm.TabIndex = 12
        Me.cbx8kohm.Text = "8k ohm"
        Me.cbx8kohm.UseVisualStyleBackColor = True
        '
        'cbx15kohm
        '
        Me.cbx15kohm.AutoSize = True
        Me.cbx15kohm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx15kohm.Location = New System.Drawing.Point(835, 28)
        Me.cbx15kohm.Name = "cbx15kohm"
        Me.cbx15kohm.Size = New System.Drawing.Size(108, 28)
        Me.cbx15kohm.TabIndex = 13
        Me.cbx15kohm.Text = "15k ohm"
        Me.cbx15kohm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.tbxLimitDsply)
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Controls.Add(Me.lblTestDescription)
        Me.GroupBox1.Controls.Add(Me.lblMeasurement)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.lblComment)
        Me.GroupBox1.Controls.Add(Me.tbxComment)
        Me.GroupBox1.Controls.Add(Me.lblResultDsply)
        Me.GroupBox1.Controls.Add(Me.tbxMeasurementEntry)
        Me.GroupBox1.Controls.Add(Me.lblLimit)
        Me.GroupBox1.Controls.Add(Me.lblTest)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(933, 121)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'tbxLimitDsply
        '
        Me.tbxLimitDsply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLimitDsply.Location = New System.Drawing.Point(345, 50)
        Me.tbxLimitDsply.MaximumSize = New System.Drawing.Size(76, 65)
        Me.tbxLimitDsply.Multiline = True
        Me.tbxLimitDsply.Name = "tbxLimitDsply"
        Me.tbxLimitDsply.Size = New System.Drawing.Size(76, 53)
        Me.tbxLimitDsply.TabIndex = 22
        Me.tbxLimitDsply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'frmOffStateOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 893)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbx15kohm)
        Me.Controls.Add(Me.cbx8kohm)
        Me.Controls.Add(Me.cbx3kohm)
        Me.Controls.Add(Me.cbx400ohm)
        Me.Controls.Add(Me.cbx40ohm)
        Me.Controls.Add(Me.cbx10ohm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmOffStateOperation"
        Me.Text = "frmOffStateOperation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbx10ohm As CheckBox
    Friend WithEvents cbx40ohm As CheckBox
    Friend WithEvents cbx400ohm As CheckBox
    Friend WithEvents cbx3kohm As CheckBox
    Friend WithEvents cbx8kohm As CheckBox
    Friend WithEvents cbx15kohm As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxLimitDsply As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblTestDescription As Label
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents tbxComment As TextBox
    Friend WithEvents lblResultDsply As Label
    Friend WithEvents tbxMeasurementEntry As TextBox
    Friend WithEvents lblLimit As Label
    Friend WithEvents lblTest As Label
End Class
