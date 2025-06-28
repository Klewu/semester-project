Imports System.Data.OleDb

Public Class frmCheckOut
    Private Sub frmCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load







        Try
            cmbRoomNumber.Items.Clear()
            con.Open()
            cmd = New OleDbCommand("SELECT RoomNumber FROM Rooms WHERE Status='Occupied'", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                cmbRoomNumber.Items.Add(dr("RoomNumber").ToString())
            End While
            con.Close()
        Catch ex As Exception
            MsgBox("Error loading rooms: " & ex.Message)
            If con.State = ConnectionState.Open Then con.Close()
        End Try


    End Sub

    Private Sub cmbRoomNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoomNumber.SelectedIndexChanged

        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM Guests WHERE RoomNumber = ?", con)
            cmd.Parameters.AddWithValue("?", cmbRoomNumber.Text)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtGuestName.Text = dr("GuestName").ToString()
                txtPhone.Text = dr("Phone").ToString()
                txtCheckInDate.Text = Convert.ToDateTime(dr("CheckInDate")).ToShortDateString()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error loading guest info: " & ex.Message)
            If con.State = ConnectionState.Open Then con.Close()
        End Try


    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click

        If cmbRoomNumber.Text = "" Then
            MsgBox("Please select a room to check out.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtPhone.Text.Length <> 10 Then
            MessageBox.Show("Phone number must be exactly 10 digits.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Exit Sub
        End If

        Try
            con.Open()

            ' Option A: Delete the guest record
            Dim deleteGuest As String = "DELETE FROM Guests WHERE RoomNumber=?"
            cmd = New OleDbCommand(deleteGuest, con)
            cmd.Parameters.AddWithValue("?", cmbRoomNumber.Text)
            cmd.ExecuteNonQuery()

            ' Option B: (If using a CheckOutDate column, just update instead)

            ' Update Room Status
            Dim updateRoom As String = "UPDATE Rooms SET Status='Available' WHERE RoomNumber=?"
            cmd = New OleDbCommand(updateRoom, con)
            cmd.Parameters.AddWithValue("?", cmbRoomNumber.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Check-out successful.", MsgBoxStyle.Information)
            con.Close()
            Me.Close()

        Catch ex As Exception
            MsgBox("Check-out failed: " & ex.Message)
            If con.State = ConnectionState.Open Then con.Close()
        End Try



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        cmbRoomNumber.SelectedIndex = -1
        txtGuestName.Clear()
        txtPhone.Clear()
        txtCheckInDate.Clear()
        cmbRoomNumber.Focus()

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True



        End If

    End Sub
End Class