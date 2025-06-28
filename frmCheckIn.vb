Imports System.Data.OleDb

Public Class frmCheckIn
    Private Sub frmCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            cmbRoomNumber.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("SELECT RoomNumber FROM Rooms WHERE Status='Available'", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                cmbRoomNumber.Items.Add(dr("RoomNumber").ToString())
            End While
            con.Close()

        Catch ex As Exception
            MsgBox("Error loading rooms: " & ex.Message)
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        dtpCheckInDate.MinDate = Date.Today
        dtpCheckInDate.Value = Date.Today

    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click

        If txtGuestName.Text = "" Or txtPhone.Text = "" Or cmbRoomNumber.Text = "" Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtPhone.Text.Length <> 10 Then
            MessageBox.Show("Phone number must be exactly 10 digits.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Exit Sub
        End If

        Try
            con.Open()

            ' Insert guest into Bookings or Guests table (you choose)
            Dim insertQuery As String = "INSERT INTO Guests (GuestName, Phone, RoomNumber, CheckInDate) VALUES (?, ?, ?, ?)"
            cmd = New OleDbCommand(insertQuery, con)
            cmd.Parameters.AddWithValue("?", txtGuestName.Text)
            cmd.Parameters.AddWithValue("?", txtPhone.Text)
            cmd.Parameters.AddWithValue("?", cmbRoomNumber.Text)
            cmd.Parameters.AddWithValue("?", dtpCheckInDate.Value)
            cmd.ExecuteNonQuery()

            ' Update Room Status
            Dim updateRoom As String = "UPDATE Rooms SET Status='Occupied' WHERE RoomNumber=?"
            cmd = New OleDbCommand(updateRoom, con)
            cmd.Parameters.AddWithValue("?", cmbRoomNumber.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Guest checked in successfully.", MsgBoxStyle.Information)

            con.Close()
            Me.Close()

        Catch ex As Exception
            MsgBox("Check-in failed: " & ex.Message, MsgBoxStyle.Critical)
            If con.State = ConnectionState.Open Then con.Close()
        End Try




    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtGuestName.Clear()
        txtPhone.Clear()
        cmbRoomNumber.SelectedIndex = -1
        dtpCheckInDate.Value = DateTime.Now
        txtGuestName.Focus()


    End Sub


    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True



        End If

    End Sub

    Private Sub dtpCheckInDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckInDate.ValueChanged

        dtpCheckInDate.Value = Date.Today
        dtpCheckInDate.MinDate = Date.Today
        dtpCheckInDate.MaxDate = Date.Today
    End Sub
End Class