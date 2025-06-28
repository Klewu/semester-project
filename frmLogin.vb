Imports System.Data.OleDb

Public Class frmLogin
    Public Shared LoggedInRole As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ' Prepare SQL query
            Dim sql As String = "SELECT * FROM Users WHERE Username = ? AND Password = ?"
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                LoggedInRole = dr("Role").ToString()
                MsgBox("Login successful! Role: " & LoggedInRole, MsgBoxStyle.Information, "Success")
                FrmMain.Show()
                Me.Hide()

                ' Optionally: pass the role to frmMain using a public variable
                ' frmMain.userRole = role

            Else
                MsgBox("Invalid username or password", MsgBoxStyle.Critical, "Login Failed")
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try





    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()

    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub
End Class