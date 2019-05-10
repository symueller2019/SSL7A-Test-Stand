Imports System.ComponentModel

Public Class frmMax_MinOnStateConAngle
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file

    Private Sub frmMax_MinOnStateConAngle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxMaxMinOnStateConductionAngle.Image = Image.FromFile("C:\Temp\Max_MinOnStateConductionAngle 03142019.PNG")
    End Sub

    Private Sub frmMax_MinOnStateConAngle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'pbxMaxMinOnStateConductionAngle.Image.Dispose()
        GC.Collect()
        'turn off dimmer power

        'Open all Res & Cap Relays
        Disconnect_Relays_Bd1_2()
        'Dim DataValue As UInt16
        'DataValue = 0
        'PortATest(DataValue)
    End Sub

    Private Sub cbxMinLoad_MinAngle_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbxMinLoad_MinAngle.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        If (cbxMinLoad_MinAngle.Checked = True) Then

            'clear out previous value
            tbxMeasurementEntry.Text = ""

            'Disable other controls
            cbxRatedLoad_MinAngle.Enabled = False
            cbxMinLoad_MaxAngle.Enabled = False
            cbxRatedLoad_MaxAngle.Enabled = False

            ''display title of test
            'cbxMaxCondAngle.Text = "LPF 120% Rated Load-Max Conduction Angle - Dimmer ON"
            'cbx90DegCondAngle.Enabled = False
            'display title of test in Group box
            lblTestDescription.Text = "HPF Min Load - Min Conduction Angle"
            lblResultDsply.Text = ""
            'display limits
            'lblLimitDsply.Text = "1.619msec to 2.081msec"
            tbxLimitDsply.Text = "1.619 msec" & vbCrLf & "to" & vbCrLf & "2.081 msec"

            DisplayLoad_Min_Min()

            'close Relays - connect loads & power
            Close_Relays(MinHPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'keep entered value
            tbxMinLoad.Text = tbxMeasurementEntry.Text

            'Restore other controls
            cbxRatedLoad_MinAngle.Enabled = True
            cbxMinLoad_MaxAngle.Enabled = True
            cbxRatedLoad_MaxAngle.Enabled = True
        End If
    End Sub

    Private Sub cbxRatedLoad_MinAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRatedLoad_MinAngle.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        If (cbxRatedLoad_MinAngle.Checked = True) Then

            'clear out previous value
            tbxMeasurementEntry.Text = ""

            'Disable other controls
            cbxMinLoad_MinAngle.Enabled = False
            cbxMinLoad_MaxAngle.Enabled = False
            cbxRatedLoad_MaxAngle.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "HPF Rated Load - Min Conduction Angle"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = "1.619 msec" & vbCrLf & "to" & vbCrLf & "2.081 msec"

            DisplayLoad_Rated_Min()

            'close Relays - connect loads & power
            Close_Relays(LPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'keep entered value
            tbxRatedLoad.Text = tbxMeasurementEntry.Text

            'Restore other controls
            cbxMinLoad_MinAngle.Enabled = True
            cbxMinLoad_MaxAngle.Enabled = True
            cbxRatedLoad_MaxAngle.Enabled = True
        End If
    End Sub

    Private Sub cbxMinLoad_MaxAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMinLoad_MaxAngle.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        If (cbxMinLoad_MaxAngle.Checked = True) Then

            'clear out previous value
            tbxMeasurementEntry.Text = ""

            'Disable other controls
            cbxMinLoad_MinAngle.Enabled = False
            cbxRatedLoad_MinAngle.Enabled = False
            cbxRatedLoad_MaxAngle.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "HPF Min Load - Max Conduction Angle"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = ">130 Deg" & vbCrLf & "(6.02 msec)"

            DisplayLoad_Min_Max()

            'close Relays - connect loads & power
            Close_Relays(MinHPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'keep entered value
            tbxMinLoad2.Text = tbxMeasurementEntry.Text

            'Restore other controls
            cbxMinLoad_MinAngle.Enabled = True
            cbxRatedLoad_MinAngle.Enabled = True
            cbxRatedLoad_MaxAngle.Enabled = True
        End If
    End Sub

    Private Sub cbxRatedLoad_MaxAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRatedLoad_MaxAngle.CheckedChanged
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        If (cbxRatedLoad_MaxAngle.Checked = True) Then

            'clear out previous value
            tbxMeasurementEntry.Text = ""

            'Disable other controls
            cbxMinLoad_MinAngle.Enabled = False
            cbxRatedLoad_MinAngle.Enabled = False
            cbxMinLoad_MaxAngle.Enabled = False

            'display title of test in Group box
            lblTestDescription.Text = "HPF Rated Load - Max Conduction Angle"
            lblResultDsply.Text = ""
            'display limits in Group box
            tbxLimitDsply.Text = ">130 Deg" & vbCrLf & "(6.02 msec)"

            DisplayLoad_Rated_Max()

            'close Relays - disconnect loads & power
            Close_Relays(HPF_ResRelays)      'Resistor relays
            'Close_Relays(LPF_CapRelays)      'Capacitor relays

        Else
            'keep entered value
            tbxRatedLoad2.Text = tbxMeasurementEntry.Text

            'Restore other controls
            cbxMinLoad_MinAngle.Enabled = True
            cbxRatedLoad_MinAngle.Enabled = True
            cbxMinLoad_MaxAngle.Enabled = True
        End If
    End Sub

    Private Sub DisplayLoad_Min_Min()
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Min Watts"
        lblRes.Text = "Min HPF Res"
        lblCap.Text = ""        '"Rated LPF Cap"
        'update textbox values
        tbxWatt.Text = MinWattageSelection(MinIndex)
        tbxRes.Text = MinHPF_Res(MinIndex)
        tbxCap.Text = ""        'LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(MinHPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub

    Private Sub DisplayLoad_Rated_Min()
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Rated Watts"
        lblRes.Text = "Rated HPF Res"
        lblCap.Text = ""        '"Rated LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = HPF_Res(Index)
        tbxCap.Text = ""        'LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(HPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub

    Private Sub DisplayLoad_Min_Max()
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Min Watts"
        lblRes.Text = "Min HPF Res"
        lblCap.Text = ""        '"Rated LPF Cap"
        'update textbox values
        tbxWatt.Text = MinWattageSelection(MinIndex)
        tbxRes.Text = MinHPF_Res(MinIndex)
        tbxCap.Text = ""        'LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(MinHPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub

    Private Sub DisplayLoad_Rated_Max()
        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Rated Watts"
        lblRes.Text = "Rated HPF Res"
        lblCap.Text = ""        '"Rated LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = HPF_Res(Index)
        tbxCap.Text = ""        'LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(HPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If blnTestTitleDone = False Then
            FileWrite("Max & Min On-State Conduction Angle")
            blnTestTitleDone = True
        End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55))
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        'FileWriteNoCrLf(lblResultDsply.Text.PadRight(5))
        FileWrite(tbxComment.Text)
    End Sub
End Class