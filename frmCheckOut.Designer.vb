<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblRoomNumber = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblCheckInDate = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtCheckInDate = New System.Windows.Forms.TextBox()
        Me.cmbRoomNumber = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(410, 566)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(175, 41)
        Me.btnCheckOut.TabIndex = 0
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(728, 566)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(175, 41)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Location = New System.Drawing.Point(45, 54)
        Me.lblRoomNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(189, 31)
        Me.lblRoomNumber.TabIndex = 2
        Me.lblRoomNumber.Text = "Room Number"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Location = New System.Drawing.Point(45, 191)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(166, 31)
        Me.lblGuestName.TabIndex = 3
        Me.lblGuestName.Text = "Guest Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(45, 345)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(195, 31)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone Number"
        '
        'lblCheckInDate
        '
        Me.lblCheckInDate.AutoSize = True
        Me.lblCheckInDate.Location = New System.Drawing.Point(45, 492)
        Me.lblCheckInDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheckInDate.Name = "lblCheckInDate"
        Me.lblCheckInDate.Size = New System.Drawing.Size(189, 31)
        Me.lblCheckInDate.TabIndex = 5
        Me.lblCheckInDate.Text = "Check-In Date"
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(410, 191)
        Me.txtGuestName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(503, 38)
        Me.txtGuestName.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(410, 345)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(503, 38)
        Me.txtPhone.TabIndex = 8
        '
        'txtCheckInDate
        '
        Me.txtCheckInDate.Location = New System.Drawing.Point(410, 492)
        Me.txtCheckInDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCheckInDate.Name = "txtCheckInDate"
        Me.txtCheckInDate.ReadOnly = True
        Me.txtCheckInDate.Size = New System.Drawing.Size(503, 38)
        Me.txtCheckInDate.TabIndex = 9
        '
        'cmbRoomNumber
        '
        Me.cmbRoomNumber.FormattingEnabled = True
        Me.cmbRoomNumber.Location = New System.Drawing.Point(410, 54)
        Me.cmbRoomNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbRoomNumber.Name = "cmbRoomNumber"
        Me.cmbRoomNumber.Size = New System.Drawing.Size(503, 39)
        Me.cmbRoomNumber.TabIndex = 10
        '
        'frmCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1127, 717)
        Me.Controls.Add(Me.cmbRoomNumber)
        Me.Controls.Add(Me.txtCheckInDate)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.lblCheckInDate)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblGuestName)
        Me.Controls.Add(Me.lblRoomNumber)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCheckOut"
        Me.Text = "frmCheckOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblRoomNumber As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblCheckInDate As Label
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtCheckInDate As TextBox
    Friend WithEvents cmbRoomNumber As ComboBox
End Class
