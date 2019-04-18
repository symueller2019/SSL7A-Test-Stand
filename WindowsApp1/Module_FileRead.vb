﻿Module Module_FileRead
    'arrays to hold Rated Load Configuration info from Configuration text file
    Public LPF_Res(50) As String
    Public LPF_Cap(50) As String
    Public HPF_Res(50) As String
    Public WattageSelection(50) As String
    'arrays to hold Min Load Configuration info from Configuration text file
    Public MinLPF_Res(50) As String
    Public MinLPF_Cap(50) As String
    Public MinHPF_Res(50) As String
    Public MinWattageSelection(50) As String
    'arrays to hold Rated Relay address
    Public Index As Integer
    Public LPF_ResRelays(10) As String
    Public LPF_CapRelays(10) As String
    Public HPF_ResRelays(10) As String
    'arrays to hold Min Relay address
    Public MinIndex As Integer
    Public MinLPF_ResRelays(10) As String
    Public MinLPF_CapRelays(10) As String
    Public MinHPF_ResRelays(10) As String
    'Config file locations - read from Configuration text file
    Public FileLoc_Config As String
    Public FileLoc_WattSelect As String
    Public FileLoc_WattsToRelayLPFRes As String
    Public FileLoc_WattsToRelayLPFCap As String
    Public FileLoc_WattsToRelayHPFRes As String
    'Config file locations - read from Configuration text file
    Public FileLoc_MinWattSelect As String
    Public FileLoc_MinWattsToRelayLPFRes As String
    Public FileLoc_MinWattsToRelayLPFCap As String
    Public FileLoc_MinWattsToRelayHPFRes As String

    Public Sub Read_Text_Files()
        'Read in all Wattage selections available in test - get total # of wattage test values available
        '-for each wattage selection there is a corresponding LPF Res & Cap /HPF Res value
        'Dim myreader As New IO.StreamReader("C:\Temp\WattageSelection.txt")
        Dim myreader As New IO.StreamReader(FileLoc_WattSelect)
        Dim line As String

        line = myreader.ReadLine()      'Read 1st line
        WattageSelection = line.Split(",")

        line = myreader.ReadLine()      'Read 2nd line
        LPF_Res = line.Split(",")

        line = myreader.ReadLine()      'Read 3rd line
        LPF_Cap = line.Split(",")

        line = myreader.ReadLine()      'Read 4th line
        HPF_Res = line.Split(",")


        line = myreader.ReadLine()      'Read 5th line
        MinWattageSelection = line.Split(",")

        line = myreader.ReadLine()      'Read 6th line
        MinLPF_Res = line.Split(",")

        line = myreader.ReadLine()      'Read 7th line
        MinLPF_Cap = line.Split(",")

        line = myreader.ReadLine()      'Read 8th line
        MinHPF_Res = line.Split(",")

        myreader.Close()
    End Sub

    Public Sub ReadConfig()
        'Open the Configuration file
        Dim myreader As New IO.StreamReader(frmFileRead.tbxConfigFile.Text)
        FileLoc_Config = myreader.ReadLine()                  'Read line
        FileLoc_WattSelect = myreader.ReadLine()              'Read line
        FileLoc_WattsToRelayLPFRes = myreader.ReadLine()      'Read line
        FileLoc_WattsToRelayLPFCap = myreader.ReadLine()      'Read line
        FileLoc_WattsToRelayHPFRes = myreader.ReadLine()      'Read line

        FileLoc_MinWattSelect = myreader.ReadLine()              'Read line
        FileLoc_MinWattsToRelayLPFRes = myreader.ReadLine()      'Read line
        FileLoc_MinWattsToRelayLPFCap = myreader.ReadLine()      'Read line
        FileLoc_MinWattsToRelayHPFRes = myreader.ReadLine()      'Read line

    End Sub

End Module