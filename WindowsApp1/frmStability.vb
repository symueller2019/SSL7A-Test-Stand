Imports System.ComponentModel

Public Class frmStability
    Private Sub btnLPFMinLoadMinCondAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFMinLoadMinCondAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Black
        Dim DataValue As UInt16
        DataValue = 14
        PortATest(DataValue)

        'Save Results
        'Dim WriteData = "LPF Min Load / Min Conduction Angle / Pos Half Cycle"
        'FileWrite(WriteData)

        'Update Test Status
        lblTestDescription.Text = "LPF Min Load - Min Conduction Angle Pos Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""

        'update labels & textboxes with load & relay info
        'assign titles to labels
        lblWatt.text = "Min Watts"
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

    End Sub

    Private Sub btnLPFMinLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFMinLoadMaxConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Blue
        Dim DataValue As UInt16
        DataValue = 15
        PortATest(DataValue)

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

        'Save Results
        Dim WriteData = "LPF Min Load / Max Conduction Angle / Pos Half Cycle"
        FileWrite(WriteData)
    End Sub

    Private Sub btnHPFMinLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnHPFMinLoadMinConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Brown
        Dim DataValue As UInt16
        DataValue = 14
        PortATest1(DataValue)

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

        'Display_Relays(MinLPF_CapRelays, textline)
        tbxCapRly.Text = ""
    End Sub

    Private Sub btnHPFMinLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnHPFMinLoadMaxConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Red
        Dim DataValue As UInt16
        DataValue = 15
        PortATest1(DataValue)

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

        'Display_Relays(MinLPF_CapRelays, textline)
        tbxCapRly.Text = ""
    End Sub

    Private Sub btnLPFRatedLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoadMinConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Pink
        Dim DataValue As UInt16
        DataValue = 1
        PortCTest(DataValue)

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
    End Sub

    Private Sub btnLPFRatedLoadMinConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoadMinConAngleNegCycle.Click
        RadioButton1.ForeColor = Color.PowderBlue
        Dim DataValue As UInt16
        DataValue = 0
        PortCTest(DataValue)

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
    End Sub

    Private Sub btnLPFRatedLoad90degConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoad90degConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.SaddleBrown
        Dim DataValue As UInt16
        DataValue = 1
        PortATest(DataValue)

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
    End Sub

    Private Sub btnLPFRatedLoad90degConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoad90degConAngleNegCycle.Click
        RadioButton1.ForeColor = Color.Green
        Dim DataValue As UInt16
        DataValue = 0
        PortATest(DataValue)

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
    End Sub

    Private Sub btnLPF_RatedLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPF_RatedLoadMaxConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Orange
        Dim DataValue As UInt16
        DataValue = 1
        PortATest(DataValue)

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
    End Sub

    Private Sub btnLPF_RatedLoadMaxConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPF_RatedLoadMaxConAngleNegCycle.Click
        RadioButton1.ForeColor = Color.Gold
        Dim DataValue As UInt16
        DataValue = 0
        PortATest(DataValue)

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
    End Sub

    Private Sub btn_HPFRatedLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btn_HPFRatedLoadMinConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Crimson
        Dim DataValue As UInt16
        DataValue = 1
        PortATest(DataValue)

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
    End Sub

    Private Sub btn_HPFRatedLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btn_HPFRatedLoadMaxConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.White
        Dim DataValue As UInt16
        DataValue = 0
        PortATest(DataValue)

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
    End Sub

    Private Sub frmStability_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()            'collect garbage - release system memory
    End Sub

    Private Sub tbxMeasurementEntry_TextChanged(sender As Object, e As EventArgs) Handles tbxMeasurementEntry.TextChanged

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim LPF_Value As String
        'LPF_Value = lblTestDescription.Text ' & tbxMeasurementEntry.Text
        'Determine Pass/Fail status

        If Val(lblLimitDsply.Text) >= Val(tbxMeasurementEntry.Text) Then
            lblResultDsply.Text = "PASS"
        Else
            lblResultDsply.Text = "FAIL"
        End If

        FileWriteNoCrLf(lblTestDescription.Text.PadRight(55))
        FileWriteNoCrLf(tbxMeasurementEntry.Text.PadRight(6) & lblResultDsply.Text.PadRight(6))
        'FileWriteNoCrLf(lblResultDsply.Text.PadRight(5))
        FileWrite(tbxComment.Text)

        'LPF_Value = tbxMeasurementEntry.Text & tbxComment.Text
        'FileWrite(LPF_Value)

        'LPF_Value = tbxComment.Text
    End Sub

End Class