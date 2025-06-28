<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckIn
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
        Me.lblGuestaname = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblRoomNumber = New System.Windows.Forms.Label()
        Me.lblCheckInDate = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cmbRoomNumber = New System.Windows.Forms.ComboBox()
        Me.dtpCheckInDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGuestaname
        '
        Me.lblGuestaname.AutoSize = True
        Me.lblGuestaname.Location = New System.Drawing.Point(22, 55)
        Me.lblGuestaname.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGuestaname.Name = "lblGuestaname"
        Me.lblGuestaname.Size = New System.Drawing.Size(197, 37)
        Me.lblGuestaname.TabIndex = 0
        Me.lblGuestaname.Text = "Guest Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(22, 163)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(233, 37)
        Me.lblPhone.TabIndex = 1
        Me.lblPhone.Text = "Phone Number"
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Location = New System.Drawing.Point(29, 271)
        Me.lblRoomNumber.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(226, 37)
        Me.lblRoomNumber.TabIndex = 2
        Me.lblRoomNumber.Text = "Room Number"
        '
        'lblCheckInDate
        '
        Me.lblCheckInDate.AutoSize = True
        Me.lblCheckInDate.Location = New System.Drawing.Point(22, 379)
        Me.lblCheckInDate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCheckInDate.Name = "lblCheckInDate"
        Me.lblCheckInDate.Size = New System.Drawing.Size(219, 37)
        Me.lblCheckInDate.TabIndex = 3
        Me.lblCheckInDate.Text = "Check-In Date"
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(345, 48)
        Me.txtGuestName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(492, 44)
        Me.txtGuestName.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(345, 158)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(492, 44)
        Me.txtPhone.TabIndex = 8
        '
        'cmbRoomNumber
        '
        Me.cmbRoomNumber.FormattingEnabled = True
        Me.cmbRoomNumber.Location = New System.Drawing.Point(345, 268)
        Me.cmbRoomNumber.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbRoomNumber.Name = "cmbRoomNumber"
        Me.cmbRoomNumber.Size = New System.Drawing.Size(492, 45)
        Me.cmbRoomNumber.TabIndex = 9
        '
        'dtpCheckInDate
        '
        Me.dtpCheckInDate.Location = New System.Drawing.Point(345, 379)
        Me.dtpCheckInDate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpCheckInDate.Name = "dtpCheckInDate"
        Me.dtpCheckInDate.Size = New System.Drawing.Size(492, 44)
        Me.dtpCheckInDate.TabIndex = 10
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Location = New System.Drawing.Point(423, 564)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(166, 45)
        Me.btnCheckIn.TabIndex = 11
        Me.btnCheckIn.Text = "Check In"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(820, 564)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(166, 45)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGuestName)
        Me.GroupBox1.Controls.Add(Me.lblGuestaname)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.dtpCheckInDate)
        Me.GroupBox1.Controls.Add(Me.lblRoomNumber)
        Me.GroupBox1.Controls.Add(Me.cmbRoomNumber)
        Me.GroupBox1.Controls.Add(Me.lblCheckInDate)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1002, 482)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Details"
        '
        'frmCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1174, 685)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmCheckIn"
        Me.Text = "frmCheckIn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblGuestaname As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblRoomNumber As Label
    Friend WithEvents lblCheckInDate As Label
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cmbRoomNumber As ComboBox
    Friend WithEvents dtpCheckInDate As DateTimePicker
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
