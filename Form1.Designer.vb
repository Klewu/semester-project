<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.btnGuests = New System.Windows.Forms.Button()
        Me.btnCheckIN = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(703, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome To Hotel Reservation System"
        '
        'btnRooms
        '
        Me.btnRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.Location = New System.Drawing.Point(7, 59)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(170, 107)
        Me.btnRooms.TabIndex = 1
        Me.btnRooms.Text = "Manage Rooms"
        Me.btnRooms.UseVisualStyleBackColor = True
        '
        'btnReservations
        '
        Me.btnReservations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.Location = New System.Drawing.Point(7, 314)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(170, 107)
        Me.btnReservations.TabIndex = 2
        Me.btnReservations.Text = "Book Room"
        Me.btnReservations.UseVisualStyleBackColor = True
        '
        'btnGuests
        '
        Me.btnGuests.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuests.Location = New System.Drawing.Point(7, 184)
        Me.btnGuests.Name = "btnGuests"
        Me.btnGuests.Size = New System.Drawing.Size(170, 107)
        Me.btnGuests.TabIndex = 3
        Me.btnGuests.Text = "Register Guest"
        Me.btnGuests.UseVisualStyleBackColor = True
        '
        'btnCheckIN
        '
        Me.btnCheckIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIN.Location = New System.Drawing.Point(7, 583)
        Me.btnCheckIN.Name = "btnCheckIN"
        Me.btnCheckIN.Size = New System.Drawing.Size(170, 107)
        Me.btnCheckIN.TabIndex = 4
        Me.btnCheckIN.Text = "Check In"
        Me.btnCheckIN.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.Location = New System.Drawing.Point(7, 454)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(170, 107)
        Me.btnCheckOut.TabIndex = 5
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1203, 921)
        Me.Controls.Add(Me.btnCheckIN)
        Me.Controls.Add(Me.btnRooms)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnReservations)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuests)
        Me.IsMdiContainer = True
        Me.Name = "FrmMain"
        Me.Text = "Hotel Reservation System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRooms As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnCheckIN As Button
    Friend WithEvents btnCheckOut As Button
End Class
