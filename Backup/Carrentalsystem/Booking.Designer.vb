﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txtprocess = New System.Windows.Forms.TextBox
        Me.Cboxcustomer = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cboxcarname = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txtotal = New System.Windows.Forms.TextBox
        Me.Txtnodays = New System.Windows.Forms.TextBox
        Me.Txtrent = New System.Windows.Forms.TextBox
        Me.Txtboxplate = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Btnload = New System.Windows.Forms.Button
        Me.Btnsave = New System.Windows.Forms.Button
        Me.Btndelete = New System.Windows.Forms.Button
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Btnpayment = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Txtstatus = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txtproces = New System.Windows.Forms.TextBox
        Me.Cbcusname = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Cbcarname = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Txttotal = New System.Windows.Forms.TextBox
        Me.Txtndays = New System.Windows.Forms.TextBox
        Me.Txtrday = New System.Windows.Forms.TextBox
        Me.Txtpno = New System.Windows.Forms.TextBox
        Me.btnrefresh = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txtprocess)
        Me.GroupBox1.Controls.Add(Me.Cboxcustomer)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Cboxcarname)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txtotal)
        Me.GroupBox1.Controls.Add(Me.Txtnodays)
        Me.GroupBox1.Controls.Add(Me.Txtrent)
        Me.GroupBox1.Controls.Add(Me.Txtboxplate)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 315)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Reservation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Process by"
        '
        'Txtprocess
        '
        Me.Txtprocess.Enabled = False
        Me.Txtprocess.Location = New System.Drawing.Point(71, 265)
        Me.Txtprocess.Name = "Txtprocess"
        Me.Txtprocess.Size = New System.Drawing.Size(180, 20)
        Me.Txtprocess.TabIndex = 17
        '
        'Cboxcustomer
        '
        Me.Cboxcustomer.FormattingEnabled = True
        Me.Cboxcustomer.Location = New System.Drawing.Point(94, 20)
        Me.Cboxcustomer.Name = "Cboxcustomer"
        Me.Cboxcustomer.Size = New System.Drawing.Size(157, 21)
        Me.Cboxcustomer.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Customer Name"
        '
        'Cboxcarname
        '
        Me.Cboxcarname.FormattingEnabled = True
        Me.Cboxcarname.Location = New System.Drawing.Point(71, 56)
        Me.Cboxcarname.Name = "Cboxcarname"
        Me.Cboxcarname.Size = New System.Drawing.Size(180, 21)
        Me.Cboxcarname.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(71, 126)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(180, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "No Days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Rent/Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rent Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Plate No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Car Name"
        '
        'Txtotal
        '
        Me.Txtotal.Enabled = False
        Me.Txtotal.Location = New System.Drawing.Point(71, 233)
        Me.Txtotal.Name = "Txtotal"
        Me.Txtotal.Size = New System.Drawing.Size(180, 20)
        Me.Txtotal.TabIndex = 3
        '
        'Txtnodays
        '
        Me.Txtnodays.Enabled = False
        Me.Txtnodays.Location = New System.Drawing.Point(71, 198)
        Me.Txtnodays.Name = "Txtnodays"
        Me.Txtnodays.Size = New System.Drawing.Size(180, 20)
        Me.Txtnodays.TabIndex = 2
        '
        'Txtrent
        '
        Me.Txtrent.Enabled = False
        Me.Txtrent.Location = New System.Drawing.Point(71, 163)
        Me.Txtrent.Name = "Txtrent"
        Me.Txtrent.Size = New System.Drawing.Size(180, 20)
        Me.Txtrent.TabIndex = 1
        '
        'Txtboxplate
        '
        Me.Txtboxplate.Enabled = False
        Me.Txtboxplate.Location = New System.Drawing.Point(71, 94)
        Me.Txtboxplate.Name = "Txtboxplate"
        Me.Txtboxplate.Size = New System.Drawing.Size(180, 20)
        Me.Txtboxplate.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(275, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 303)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(592, 274)
        Me.DataGridView1.TabIndex = 0
        '
        'Btnload
        '
        Me.Btnload.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnload.ForeColor = System.Drawing.Color.Black
        Me.Btnload.Location = New System.Drawing.Point(332, 365)
        Me.Btnload.Name = "Btnload"
        Me.Btnload.Size = New System.Drawing.Size(96, 23)
        Me.Btnload.TabIndex = 2
        Me.Btnload.Text = "Load"
        Me.Btnload.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.ForeColor = System.Drawing.Color.Black
        Me.Btnsave.Location = New System.Drawing.Point(453, 365)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(96, 23)
        Me.Btnsave.TabIndex = 3
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndelete.ForeColor = System.Drawing.Color.Black
        Me.Btndelete.Location = New System.Drawing.Point(574, 365)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(96, 23)
        Me.Btndelete.TabIndex = 4
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.ForeColor = System.Drawing.Color.Black
        Me.Btnclose.Location = New System.Drawing.Point(701, 365)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(96, 23)
        Me.Btnclose.TabIndex = 5
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(430, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 31)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Booking"
        '
        'Btnpayment
        '
        Me.Btnpayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Btnpayment.Enabled = False
        Me.Btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnpayment.ForeColor = System.Drawing.Color.Black
        Me.Btnpayment.Location = New System.Drawing.Point(62, 362)
        Me.Btnpayment.Name = "Btnpayment"
        Me.Btnpayment.Size = New System.Drawing.Size(118, 42)
        Me.Btnpayment.TabIndex = 7
        Me.Btnpayment.Text = "Proceed to payment"
        Me.Btnpayment.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Txtstatus)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Txtproces)
        Me.GroupBox3.Controls.Add(Me.Cbcusname)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Cbcarname)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Txttotal)
        Me.GroupBox3.Controls.Add(Me.Txtndays)
        Me.GroupBox3.Controls.Add(Me.Txtrday)
        Me.GroupBox3.Controls.Add(Me.Txtpno)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(890, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 329)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "View Reservation"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Status"
        '
        'Txtstatus
        '
        Me.Txtstatus.Enabled = False
        Me.Txtstatus.Location = New System.Drawing.Point(71, 262)
        Me.Txtstatus.Name = "Txtstatus"
        Me.Txtstatus.Size = New System.Drawing.Size(180, 20)
        Me.Txtstatus.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Process by"
        '
        'Txtproces
        '
        Me.Txtproces.Enabled = False
        Me.Txtproces.Location = New System.Drawing.Point(71, 295)
        Me.Txtproces.Name = "Txtproces"
        Me.Txtproces.Size = New System.Drawing.Size(180, 20)
        Me.Txtproces.TabIndex = 17
        '
        'Cbcusname
        '
        Me.Cbcusname.Enabled = False
        Me.Cbcusname.FormattingEnabled = True
        Me.Cbcusname.Location = New System.Drawing.Point(94, 20)
        Me.Cbcusname.Name = "Cbcusname"
        Me.Cbcusname.Size = New System.Drawing.Size(157, 21)
        Me.Cbcusname.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Customer Name"
        '
        'Cbcarname
        '
        Me.Cbcarname.Enabled = False
        Me.Cbcarname.FormattingEnabled = True
        Me.Cbcarname.Location = New System.Drawing.Point(71, 56)
        Me.Cbcarname.Name = "Cbcarname"
        Me.Cbcarname.Size = New System.Drawing.Size(180, 21)
        Me.Cbcarname.TabIndex = 13
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(71, 126)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(180, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "No Days"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Rent/Day"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Rent Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Plate No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Car Name"
        '
        'Txttotal
        '
        Me.Txttotal.Enabled = False
        Me.Txttotal.Location = New System.Drawing.Point(71, 233)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(180, 20)
        Me.Txttotal.TabIndex = 3
        '
        'Txtndays
        '
        Me.Txtndays.Enabled = False
        Me.Txtndays.Location = New System.Drawing.Point(71, 198)
        Me.Txtndays.Name = "Txtndays"
        Me.Txtndays.Size = New System.Drawing.Size(180, 20)
        Me.Txtndays.TabIndex = 2
        '
        'Txtrday
        '
        Me.Txtrday.Enabled = False
        Me.Txtrday.Location = New System.Drawing.Point(71, 163)
        Me.Txtrday.Name = "Txtrday"
        Me.Txtrday.Size = New System.Drawing.Size(180, 20)
        Me.Txtrday.TabIndex = 1
        '
        'Txtpno
        '
        Me.Txtpno.Enabled = False
        Me.Txtpno.Location = New System.Drawing.Point(71, 94)
        Me.Txtpno.Name = "Txtpno"
        Me.Txtpno.Size = New System.Drawing.Size(180, 20)
        Me.Txtpno.TabIndex = 0
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.ForeColor = System.Drawing.Color.Black
        Me.btnrefresh.Location = New System.Drawing.Point(744, 12)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(96, 23)
        Me.btnrefresh.TabIndex = 9
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1167, 416)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Btnpayment)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Btnload)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Booking"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btnload As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtotal As System.Windows.Forms.TextBox
    Friend WithEvents Txtrent As System.Windows.Forms.TextBox
    Friend WithEvents Txtboxplate As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtnodays As System.Windows.Forms.TextBox
    Friend WithEvents Cboxcarname As System.Windows.Forms.ComboBox
    Friend WithEvents Cboxcustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txtprocess As System.Windows.Forms.TextBox
    Friend WithEvents Btnpayment As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txtproces As System.Windows.Forms.TextBox
    Friend WithEvents Cbcusname As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Cbcarname As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Txtndays As System.Windows.Forms.TextBox
    Friend WithEvents Txtrday As System.Windows.Forms.TextBox
    Friend WithEvents Txtpno As System.Windows.Forms.TextBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
End Class
