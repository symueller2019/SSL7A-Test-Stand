﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOffStateOperation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOffStateOperation))
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
        Me.pbxImage1 = New System.Windows.Forms.PictureBox()
        Me.pbxImage2 = New System.Windows.Forms.PictureBox()
        Me.pbxImage3 = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.lblStatus0 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.lblStatus3 = New System.Windows.Forms.Label()
        Me.lblStatus4 = New System.Windows.Forms.Label()
        Me.lblStatus5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxImage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(30, 197)
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
        Me.tbxMeasurementEntry.TabIndex = 0
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
        Me.GroupBox2.Location = New System.Drawing.Point(30, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 129)
        Me.GroupBox2.TabIndex = 24
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
        Me.lblCap.Location = New System.Drawing.Point(18, 91)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(36, 13)
        Me.lblCap.TabIndex = 1
        Me.lblCap.Text = "lblCap"
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Location = New System.Drawing.Point(18, 62)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(36, 13)
        Me.lblRes.TabIndex = 1
        Me.lblRes.Text = "lblRes"
        '
        'lblWatt
        '
        Me.lblWatt.AutoSize = True
        Me.lblWatt.Location = New System.Drawing.Point(18, 35)
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
        'pbxImage1
        '
        Me.pbxImage1.Image = CType(resources.GetObject("pbxImage1.Image"), System.Drawing.Image)
        Me.pbxImage1.Location = New System.Drawing.Point(30, 324)
        Me.pbxImage1.Name = "pbxImage1"
        Me.pbxImage1.Size = New System.Drawing.Size(931, 557)
        Me.pbxImage1.TabIndex = 25
        Me.pbxImage1.TabStop = False
        '
        'pbxImage2
        '
        Me.pbxImage2.Image = CType(resources.GetObject("pbxImage2.Image"), System.Drawing.Image)
        Me.pbxImage2.Location = New System.Drawing.Point(44, 324)
        Me.pbxImage2.Name = "pbxImage2"
        Me.pbxImage2.Size = New System.Drawing.Size(931, 634)
        Me.pbxImage2.TabIndex = 26
        Me.pbxImage2.TabStop = False
        '
        'pbxImage3
        '
        Me.pbxImage3.Image = CType(resources.GetObject("pbxImage3.Image"), System.Drawing.Image)
        Me.pbxImage3.Location = New System.Drawing.Point(94, 324)
        Me.pbxImage3.Name = "pbxImage3"
        Me.pbxImage3.Size = New System.Drawing.Size(800, 700)
        Me.pbxImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxImage3.TabIndex = 27
        Me.pbxImage3.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(898, 324)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(80, 34)
        Me.btnInfo.TabIndex = 28
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'lblStatus0
        '
        Me.lblStatus0.AutoSize = True
        Me.lblStatus0.Location = New System.Drawing.Point(61, 9)
        Me.lblStatus0.Name = "lblStatus0"
        Me.lblStatus0.Size = New System.Drawing.Size(53, 13)
        Me.lblStatus0.TabIndex = 29
        Me.lblStatus0.Text = "lblStatus0"
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.Location = New System.Drawing.Point(221, 9)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(53, 13)
        Me.lblStatus1.TabIndex = 29
        Me.lblStatus1.Text = "lblStatus1"
        '
        'lblStatus2
        '
        Me.lblStatus2.AutoSize = True
        Me.lblStatus2.Location = New System.Drawing.Point(389, 9)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(53, 13)
        Me.lblStatus2.TabIndex = 29
        Me.lblStatus2.Text = "lblStatus2"
        '
        'lblStatus3
        '
        Me.lblStatus3.AutoSize = True
        Me.lblStatus3.Location = New System.Drawing.Point(540, 9)
        Me.lblStatus3.Name = "lblStatus3"
        Me.lblStatus3.Size = New System.Drawing.Size(53, 13)
        Me.lblStatus3.TabIndex = 29
        Me.lblStatus3.Text = "lblStatus3"
        '
        'lblStatus4
        '
        Me.lblStatus4.AutoSize = True
        Me.lblStatus4.Location = New System.Drawing.Point(699, 9)
        Me.lblStatus4.Name = "lblStatus4"
        Me.lblStatus4.Size = New System.Drawing.Size(53, 13)
        Me.lblStatus4.TabIndex = 29
        Me.lblStatus4.Text = "lblStatus4"
        '
        'lblStatus5
        '
        Me.lblStatus5.AutoSize = True
        Me.lblStatus5.Location = New System.Drawing.Point(866, 9)
        Me.lblStatus5.Name = "lblStatus5"
        Me.lblStatus5.Size = New System.Drawing.Size(53, 13)
        Me.lblStatus5.TabIndex = 29
        Me.lblStatus5.Text = "lblStatus5"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(886, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(54, 30)
        Me.btnClose.TabIndex = 116
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmOffStateOperation
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 970)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblStatus5)
        Me.Controls.Add(Me.lblStatus4)
        Me.Controls.Add(Me.lblStatus3)
        Me.Controls.Add(Me.lblStatus2)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.lblStatus0)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.pbxImage2)
        Me.Controls.Add(Me.pbxImage1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbx15kohm)
        Me.Controls.Add(Me.cbx8kohm)
        Me.Controls.Add(Me.cbx3kohm)
        Me.Controls.Add(Me.cbx400ohm)
        Me.Controls.Add(Me.cbx40ohm)
        Me.Controls.Add(Me.cbx10ohm)
        Me.Controls.Add(Me.pbxImage3)
        Me.Name = "frmOffStateOperation"
        Me.Text = "frmOffStateOperation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbxImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxImage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents pbxImage1 As PictureBox
    Friend WithEvents pbxImage2 As PictureBox
    Friend WithEvents pbxImage3 As PictureBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents lblStatus0 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents lblStatus3 As Label
    Friend WithEvents lblStatus4 As Label
    Friend WithEvents lblStatus5 As Label
    Friend WithEvents btnClose As Button
End Class
