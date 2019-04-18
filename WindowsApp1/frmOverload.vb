﻿Imports System.ComponentModel

Public Class frmOverload
    Private Sub frmOverload_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GC.Collect()        'executed when user presses the 'X' in the top right corner to close form
    End Sub

    Private Sub frmOverload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adjust user controls
        lblLimit.Hide()                       'Hide Limit label
        lblLimitDsply.Hide()                  'Hide Limit display
        lblResult.Hide()                      'Hide Result label
        lblResultDsply.Hide()                 'Hide Result display
    End Sub

    Private Sub cbxMaxCondAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMaxCondAngle.CheckedChanged
        Dim DataValue As UInt16
        If cbxMaxCondAngle.Checked = True Then
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test
            cbxMaxCondAngle.Text = "LPF 120% Rated Load-Max Conduction Angle - Dimmer ON"
            cbx90DegCondAngle.Enabled = False
            'display title of test
            lblTestDescription.Text = "LPF 120% Rated Load - Max Conductive Angle Current"
            lblResultDsply.Text = ""

        Else
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
            'display title of test
            cbxMaxCondAngle.Text = "Max Conduction Angle - Dimmer OFF"
            cbx90DegCondAngle.Enabled = True
        End If
    End Sub

    Private Sub cbx90DegCondAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbx90DegCondAngle.CheckedChanged
        Dim DataValue As UInt16
        If cbx90DegCondAngle.Checked = True Then
            'connect loads & power
            DataValue = 1
            PortATest(DataValue)
            'display title of test
            cbx90DegCondAngle.Text = "LPF 120% Rated Load-90 Deg. Conduction Angle - Dimmer ON"
            cbxMaxCondAngle.Enabled = False
            'display title of test
            lblTestDescription.Text = "LPF 120% Rated Load - 90 Deg. Conductive Angle Current"
            lblResultDsply.Text = ""
        Else
            'disconnect loads & power
            DataValue = 0
            PortATest(DataValue)
            cbx90DegCondAngle.Text = "90 Deg. Conduction Angle - Dimmer OFF"
            cbxMaxCondAngle.Enabled = True
        End If
    End Sub
End Class