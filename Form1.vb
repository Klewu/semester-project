Public Class FrmMain
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnGuests.Click

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                MsgBox("Connected to database successfully!", MsgBoxStyle.Information, "Connection")
            End If
        Catch ex As Exception
            MsgBox("connection Failed:" & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

        ' Manager: Full access
        If frmLogin.LoggedInRole = "Manager" Then
            btnRooms.Visible = True
            btnReservations.Visible = True
            btnGuests.Visible = True
            btnCheckIn.Visible = True
            btnCheckOut.Visible = True
            'btnReports.Visible = True

            ' Receptionist: All except Manage Rooms
        ElseIf frmLogin.LoggedInRole = "Receptionist" Then
            btnRooms.Visible = False
            btnReservations.Visible = True
            btnGuests.Visible = True
            btnCheckIn.Visible = True
            btnCheckOut.Visible = True
            'btnReports.Visible = True

        Else
            MsgBox("Unknown role. Access denied.", MsgBoxStyle.Critical)
            Me.Close()
        End If


    End Sub

    Private Sub btnCheckIN_Click(sender As Object, e As EventArgs) Handles btnCheckIN.Click
        'frmCheckIn.Show()
        frmCheckIn.MdiParent = Me
        frmCheckIn.Show()
        ' frmCheckIn.Dock = DockStyle.Fill

    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        'frmCheckOut.Show()
        'frmCheckOut.Dock = DockStyle.Fill
        frmCheckOut.MdiParent = Me
        frmCheckOut.Show()

    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class
