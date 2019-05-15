Imports System.ComponentModel


Public Class frmStability
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file
    Dim myLabelArray(11) As Label       'array of status labels for display results
    Dim s_index As Integer                'index for array of lables

    Dim btnArray(11) As Button

    Private Sub btnLPFMinLoadMinCondAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFMinLoadMinCondAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 0                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "LPF Min Load - Min Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Min Watts"
        lblRes.Text = "Min LPF Res"
        lblCap.Text = "Min LPF Cap"
        'update textbox values
        tbxWatt.Text = MinWattageSelection(MinIndex)
        tbxRes.Text = MinLPF_Res(MinIndex)
        tbxCap.Text = MinLPF_Cap(MinIndex)
        'display titles to relays
        lblResRly.Text = "Min Res Rly"
        lblCapRly.Text = "Min Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(MinLPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(MinLPF_CapRelays, textline)
        tbxCapRly.Text = textline

        'close Relays
        Close_Relays(MinLPF_ResRelays)      'Resistor relays
        Close_Relays(MinLPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btnLPFMinLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFMinLoadMaxConAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 1                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "LPF Min Load - Max Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Min Watts"
        lblRes.Text = "Min LPF Res"
        lblCap.Text = "Min LPF Cap"
        'update textbox values
        tbxWatt.Text = MinWattageSelection(MinIndex)
        tbxRes.Text = MinLPF_Res(MinIndex)
        tbxCap.Text = MinLPF_Cap(MinIndex)
        'display titles to relays
        lblResRly.Text = "Min Res Rly"
        lblCapRly.Text = "Min Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(MinLPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(MinLPF_CapRelays, textline)
        tbxCapRly.Text = textline

        'close Relays
        Close_Relays(MinLPF_ResRelays)      'Resistor relays
        Close_Relays(MinLPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btnHPFMinLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnHPFMinLoadMinConAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 2                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "HPF Min Load - Min Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Min Watts"
        lblRes.Text = "Min LPF Res"
        lblCap.Text = ""
        'update textbox values
        tbxWatt.Text = MinWattageSelection(MinIndex)
        tbxRes.Text = MinHPF_Res(MinIndex)
        tbxCap.Text = ""
        'display titles to relays
        lblResRly.Text = "Min Res Rly"
        lblCapRly.Text = ""
        'display relays
        Dim textline As String = ""
        Display_Relays(MinHPF_ResRelays, textline)
        tbxResRly.Text = textline

        'close Relays
        Close_Relays(MinHPF_ResRelays)      'Resistor relays
        'Close_Relays(MinLPF_CapRelays)      'Capacitor relays

        'Display_Relays(MinLPF_CapRelays, textline)
        tbxCapRly.Text = ""

    End Sub

    Private Sub btnHPFMinLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnHPFMinLoadMaxConAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 3                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "HPF Min Load - Max Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Min Watts"
        lblRes.Text = "Min LPF Res"
        lblCap.Text = "Min LPF Cap"
        'update textbox values
        tbxWatt.Text = MinWattageSelection(MinIndex)
        tbxRes.Text = MinHPF_Res(MinIndex)
        tbxCap.Text = ""
        'display titles to relays
        lblResRly.Text = "Min Res Rly"
        lblCapRly.Text = ""
        'display relays
        Dim textline As String = ""
        Display_Relays(MinHPF_ResRelays, textline)
        tbxResRly.Text = textline

        'close Relays
        Close_Relays(MinHPF_ResRelays)      'Resistor relays

        'Display_Relays(MinLPF_CapRelays, textline)
        tbxCapRly.Text = ""

    End Sub

    Private Sub btnLPFRatedLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoadMinConAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 4                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "LPF Rated Load - Min Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "LPF Res"
        lblCap.Text = "LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = LPF_Res(Index)
        tbxCap.Text = LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = "Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(LPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = textline

        'close Relays
        Close_Relays(LPF_ResRelays)      'Resistor relays
        Close_Relays(LPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btnLPFRatedLoadMinConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoadMinConAngleNegCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 5                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "LPF Rated Load - Min Conduction Angle Neg Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "LPF Res"
        lblCap.Text = "LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = LPF_Res(Index)
        tbxCap.Text = LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = "Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(LPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = textline

        'close Relays
        Close_Relays(LPF_ResRelays)      'Resistor relays
        Close_Relays(LPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btnLPFRatedLoad90degConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoad90degConAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 6                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "LPF Rated Load - 90 Deg Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "LPF Res"
        lblCap.Text = "LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = LPF_Res(Index)
        tbxCap.Text = LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = "Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(LPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = textline

        'close Relays
        Close_Relays(LPF_ResRelays)      'Resistor relays
        Close_Relays(LPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btnLPFRatedLoad90degConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoad90degConAngleNegCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 7                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "LPF Rated Load - 90 Deg Conduction Angle Neg Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "LPF Res"
        lblCap.Text = "LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = LPF_Res(Index)
        tbxCap.Text = LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = "Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(LPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = textline

        'close Relays
        Close_Relays(LPF_ResRelays)      'Resistor relays
        Close_Relays(LPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btnLPF_RatedLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPF_RatedLoadMaxConAnglePosCycle.Click
        Dim DataValue As UInt16

        'do not show until test result done
        s_index = 8                           'associate the label to this test
        'myLabelArray(s_index).Visible = True  'show when test becomes active

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "LPF Rated Load - Max Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "LPF Res"
        lblCap.Text = "LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = LPF_Res(Index)
        tbxCap.Text = LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = "Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(LPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = textline

        'close Relays
        Close_Relays(LPF_ResRelays)      'Resistor relays
        Close_Relays(LPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btnLPF_RatedLoadMaxConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPF_RatedLoadMaxConAngleNegCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 9                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "LPF Rated Load - Max Conduction Angle Neg Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "LPF Res"
        lblCap.Text = "LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = LPF_Res(Index)
        tbxCap.Text = LPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = "Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(LPF_ResRelays, textline)
        tbxResRly.Text = textline

        Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = textline

        'close Relays
        Close_Relays(LPF_ResRelays)      'Resistor relays
        Close_Relays(LPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btn_HPFRatedLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btn_HPFRatedLoadMinConAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 10                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "HPF Rated Load - Min Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "HPF Res"
        lblCap.Text = ""        '"LPF Cap"
        'update textbox values
        tbxWatt.Text = WattageSelection(Index)
        tbxRes.Text = HPF_Res(Index)
        tbxCap.Text = ""        'HPF_Cap(Index)
        'display titles to relays
        lblResRly.Text = "Res Rly"
        lblCapRly.Text = ""     '"Cap Rly"
        'display relays
        Dim textline As String = ""
        Display_Relays(HPF_ResRelays, textline)
        tbxResRly.Text = textline

        'Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline

        'close Relays
        Close_Relays(HPF_ResRelays)      'Resistor relays
        'Close_Relays(LPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub btn_HPFRatedLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btn_HPFRatedLoadMaxConAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

        'do not show until test result done
        s_index = 11                           'associate the label to this test

        'clear all buttons and make this button active
        SetButtonActive()

        'Update Test Status
        lblTestDescription.Text = "HPF Rated Load - Max Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.Text = "Watts"
        lblRes.Text = "HPF Res"
        lblCap.Text = ""        '"HPF Cap"
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

        'Display_Relays(LPF_CapRelays, textline)
        tbxCapRly.Text = ""     'textline

        'close Relays
        Close_Relays(HPF_ResRelays)      'Resistor relays
        'Close_Relays(LPF_CapRelays)      'Capacitor relays

    End Sub

    Private Sub frmStability_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()            'collect garbage - release system memory
        Disconnect_Relays_Bd1_2()
    End Sub

    Private Sub tbxMeasurementEntry_TextChanged(sender As Object, e As EventArgs) Handles tbxMeasurementEntry.TextChanged

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim LPF_Value As String

        If blnTestTitleDone = False Then
            FileWrite("Forward Stability Test")
            blnTestTitleDone = True
        End If

        myLabelArray(s_index).Text = tbxMeasurementEntry.Text     'display result status near select button - save test status
        myLabelArray(s_index).Visible = True  'show when test becomes active

        If Val(lblLimitDsply.Text) >= Val(tbxMeasurementEntry.Text) Then
            lblResultDsply.Text = "PASS"
            myLabelArray(s_index).ForeColor = Color.Black
            myLabelArray(s_index).Text = tbxMeasurementEntry.Text & " - " & "PASS"
        Else
            lblResultDsply.Text = "FAIL"
            myLabelArray(s_index).ForeColor = Color.Red
            myLabelArray(s_index).Text = tbxMeasurementEntry.Text & " - " & "FAIL"
        End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55))
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        FileWrite(tbxComment.Text)

    End Sub

    Private Sub frmStability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myLabelArray(0) = lblStatus0
        myLabelArray(1) = lblStatus1
        myLabelArray(2) = lblStatus2
        myLabelArray(3) = lblStatus3

        myLabelArray(4) = lblStatus4
        myLabelArray(5) = lblStatus5
        myLabelArray(6) = lblStatus6
        myLabelArray(7) = lblStatus7

        myLabelArray(8) = lblStatus8
        myLabelArray(9) = lblStatus9
        myLabelArray(10) = lblStatus10
        myLabelArray(11) = lblStatus11

        btnArray(0) = btnLPFMinLoadMinCondAnglePosCycle
        btnArray(1) = btnLPFMinLoadMaxConAnglePosCycle
        btnArray(2) = btnHPFMinLoadMinConAnglePosCycle
        btnArray(3) = btnHPFMinLoadMaxConAnglePosCycle
        btnArray(4) = btnLPFRatedLoadMinConAnglePosCycle
        btnArray(5) = btnLPFRatedLoadMinConAngleNegCycle
        btnArray(6) = btnLPFRatedLoad90degConAnglePosCycle
        btnArray(7) = btnLPFRatedLoad90degConAngleNegCycle
        btnArray(8) = btnLPF_RatedLoadMaxConAnglePosCycle
        btnArray(9) = btnLPF_RatedLoadMaxConAngleNegCycle
        btnArray(10) = btn_HPFRatedLoadMinConAnglePosCycle
        btnArray(11) = btn_HPFRatedLoadMaxConAnglePosCycle


        'select button test status invisible until test done
        For n = 0 To 11
            myLabelArray(n).Visible = False
            btnArray(n).BackColor = SystemColors.ControlLight
        Next
    End Sub

    Private Sub SetButtonActive()
        For n = 0 To 11
            btnArray(n).BackColor = SystemColors.ControlLight
        Next
        btnArray(s_index).BackColor = Color.LightGreen
    End Sub
End Class