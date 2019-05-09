Imports System.ComponentModel


Public Class frmStability
    Dim blnTestTitleDone As Boolean         'used to just write the test name once to test results file

    Private Sub btnLPFMinLoadMinCondAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFMinLoadMinCondAnglePosCycle.Click
        Dim DataValue As UInt16

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

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

        'Open Relays & Reset Saved Port Masks
        Disconnect_Relays_Bd1_2()

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

        If Val(lblLimitDsply.Text) >= Val(tbxMeasurementEntry.Text) Then
            lblResultDsply.Text = "PASS"
        Else
            lblResultDsply.Text = "FAIL"
        End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55))
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        FileWrite(tbxComment.Text)

    End Sub


End Class