Imports System.Data.OleDb
Module DBConnection
    Public con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data source = HotelDB.accdb")
    ' Public con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data source = C:\Users\Sir. John\source\repos\Hotel Reservation System\bin\Debug\HotelDB.accdb")
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
End Module
