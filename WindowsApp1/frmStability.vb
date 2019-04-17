Imports System.ComponentModel

Public Class frmStability
    Private Sub btnLPFMinLoadMinCondAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFMinLoadMinCondAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Black
        Dim DataValue As UInt16
        DataValue = 14
        PortATest(DataValue)
        'PortBTest(DataValue)

        'Save Results
        'Dim WriteData = "LPF Min Load / Min Conduction Angle / Pos Half Cycle"
        'FileWrite(WriteData)

        'Update Test Status
        lblTestDescription.Text = "LPF Min Load - Min Conduction Angle Positive Cycle"
        lblLimitDsply.Text = "50"
        'Clear Measurement, Result & Comment sections
        tbxMeasurementEntry.Text = ""
        lblResultDsply.Text = ""
        tbxComment.Text = ""
    End Sub

    Private Sub btnLPFMinLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFMinLoadMaxConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Blue
        Dim DataValue As UInt16
        DataValue = 15
        PortATest(DataValue)
        'PortBTest(DataValue)

        'Save Results
        Dim WriteData = "LPF Min Load / Max Conduction Angle / Pos Half Cycle"
        FileWrite(WriteData)
    End Sub

    Private Sub btnHPFMinLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnHPFMinLoadMinConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Brown
        Dim DataValue As UInt16
        DataValue = 14
        PortATest1(DataValue)
    End Sub

    Private Sub btnHPFMinLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnHPFMinLoadMaxConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Red
        Dim DataValue As UInt16
        DataValue = 15
        PortATest1(DataValue)
    End Sub

    Private Sub btnLPFRatedLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoadMinConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Pink
        Dim DataValue As UInt16
        DataValue = 1
        'PortATest(DataValue)
        PortCTest(DataValue)
    End Sub

    Private Sub btnLPFRatedLoadMinConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoadMinConAngleNegCycle.Click
        RadioButton1.ForeColor = Color.PowderBlue
        Dim DataValue As UInt16
        DataValue = 0
        'PortATest(DataValue)
        PortCTest(DataValue)
    End Sub

    Private Sub btnLPFRatedLoad90degConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoad90degConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.SaddleBrown
        Dim DataValue As UInt16
        DataValue = 1
        PortATest(DataValue)
    End Sub

    Private Sub btnLPFRatedLoad90degConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPFRatedLoad90degConAngleNegCycle.Click
        RadioButton1.ForeColor = Color.Green
        Dim DataValue As UInt16
        DataValue = 0
        PortATest(DataValue)
    End Sub

    Private Sub btnLPF_RatedLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btnLPF_RatedLoadMaxConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Orange
        Dim DataValue As UInt16
        DataValue = 1
        PortATest(DataValue)
    End Sub

    Private Sub btnLPF_RatedLoadMaxConAngleNegCycle_Click(sender As Object, e As EventArgs) Handles btnLPF_RatedLoadMaxConAngleNegCycle.Click
        RadioButton1.ForeColor = Color.Gold
        Dim DataValue As UInt16
        DataValue = 0
        PortATest(DataValue)
    End Sub

    Private Sub btn_HPFRatedLoadMinConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btn_HPFRatedLoadMinConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.Crimson
        Dim DataValue As UInt16
        DataValue = 1
        PortATest(DataValue)
    End Sub

    Private Sub btn_HPFRatedLoadMaxConAnglePosCycle_Click(sender As Object, e As EventArgs) Handles btn_HPFRatedLoadMaxConAnglePosCycle.Click
        RadioButton1.ForeColor = Color.White
        Dim DataValue As UInt16
        DataValue = 0
        PortATest(DataValue)
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