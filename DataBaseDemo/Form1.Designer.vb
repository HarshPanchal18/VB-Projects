<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TBoxNo = New System.Windows.Forms.TextBox()
        Me.RollLbl = New System.Windows.Forms.Label()
        Me.TBoxNm = New System.Windows.Forms.TextBox()
        Me.NmLbl = New System.Windows.Forms.Label()
        Me.TBoxCity = New System.Windows.Forms.TextBox()
        Me.CtLbl = New System.Windows.Forms.Label()
        Me.TBoxSem = New System.Windows.Forms.TextBox()
        Me.SemLbl = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InsBtn = New System.Windows.Forms.Button()
        Me.SrchBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.UpdBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SrchNm = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBoxNo
        '
        Me.TBoxNo.Location = New System.Drawing.Point(36, 26)
        Me.TBoxNo.Name = "TBoxNo"
        Me.TBoxNo.Size = New System.Drawing.Size(76, 23)
        Me.TBoxNo.TabIndex = 0
        '
        'RollLbl
        '
        Me.RollLbl.AutoSize = True
        Me.RollLbl.Location = New System.Drawing.Point(12, 29)
        Me.RollLbl.Name = "RollLbl"
        Me.RollLbl.Size = New System.Drawing.Size(18, 15)
        Me.RollLbl.TabIndex = 1
        Me.RollLbl.Text = "ID"
        '
        'TBoxNm
        '
        Me.TBoxNm.Location = New System.Drawing.Point(12, 79)
        Me.TBoxNm.Name = "TBoxNm"
        Me.TBoxNm.Size = New System.Drawing.Size(100, 23)
        Me.TBoxNm.TabIndex = 0
        '
        'NmLbl
        '
        Me.NmLbl.AutoSize = True
        Me.NmLbl.Location = New System.Drawing.Point(12, 61)
        Me.NmLbl.Name = "NmLbl"
        Me.NmLbl.Size = New System.Drawing.Size(39, 15)
        Me.NmLbl.TabIndex = 1
        Me.NmLbl.Text = "Name"
        '
        'TBoxCity
        '
        Me.TBoxCity.Location = New System.Drawing.Point(12, 123)
        Me.TBoxCity.Name = "TBoxCity"
        Me.TBoxCity.Size = New System.Drawing.Size(100, 23)
        Me.TBoxCity.TabIndex = 0
        '
        'CtLbl
        '
        Me.CtLbl.AutoSize = True
        Me.CtLbl.Location = New System.Drawing.Point(12, 105)
        Me.CtLbl.Name = "CtLbl"
        Me.CtLbl.Size = New System.Drawing.Size(28, 15)
        Me.CtLbl.TabIndex = 1
        Me.CtLbl.Text = "City"
        '
        'TBoxSem
        '
        Me.TBoxSem.Location = New System.Drawing.Point(12, 167)
        Me.TBoxSem.Name = "TBoxSem"
        Me.TBoxSem.Size = New System.Drawing.Size(100, 23)
        Me.TBoxSem.TabIndex = 0
        '
        'SemLbl
        '
        Me.SemLbl.AutoSize = True
        Me.SemLbl.Location = New System.Drawing.Point(12, 149)
        Me.SemLbl.Name = "SemLbl"
        Me.SemLbl.Size = New System.Drawing.Size(55, 15)
        Me.SemLbl.TabIndex = 1
        Me.SemLbl.Text = "Semester"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(118, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(438, 198)
        Me.DataGridView1.TabIndex = 2
        '
        'InsBtn
        '
        Me.InsBtn.Location = New System.Drawing.Point(12, 229)
        Me.InsBtn.Name = "InsBtn"
        Me.InsBtn.Size = New System.Drawing.Size(75, 23)
        Me.InsBtn.TabIndex = 3
        Me.InsBtn.Text = "Insert"
        Me.InsBtn.UseVisualStyleBackColor = True
        '
        'SrchBtn
        '
        Me.SrchBtn.Location = New System.Drawing.Point(6, 22)
        Me.SrchBtn.Name = "SrchBtn"
        Me.SrchBtn.Size = New System.Drawing.Size(93, 24)
        Me.SrchBtn.TabIndex = 3
        Me.SrchBtn.Text = "Search by ID"
        Me.SrchBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Location = New System.Drawing.Point(93, 230)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(75, 23)
        Me.DelBtn.TabIndex = 3
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'UpdBtn
        '
        Me.UpdBtn.Location = New System.Drawing.Point(174, 230)
        Me.UpdBtn.Name = "UpdBtn"
        Me.UpdBtn.Size = New System.Drawing.Size(75, 23)
        Me.UpdBtn.TabIndex = 3
        Me.UpdBtn.Text = "Update"
        Me.UpdBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SrchNm)
        Me.GroupBox1.Controls.Add(Me.SrchBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 59)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'SrchNm
        '
        Me.SrchNm.Location = New System.Drawing.Point(106, 22)
        Me.SrchNm.Name = "SrchNm"
        Me.SrchNm.Size = New System.Drawing.Size(102, 23)
        Me.SrchNm.TabIndex = 4
        Me.SrchNm.Text = "Search by Name"
        Me.SrchNm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UpdBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.InsBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SemLbl)
        Me.Controls.Add(Me.CtLbl)
        Me.Controls.Add(Me.NmLbl)
        Me.Controls.Add(Me.RollLbl)
        Me.Controls.Add(Me.TBoxSem)
        Me.Controls.Add(Me.TBoxCity)
        Me.Controls.Add(Me.TBoxNm)
        Me.Controls.Add(Me.TBoxNo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBoxNo As TextBox
    Friend WithEvents RollLbl As Label
    Friend WithEvents TBoxNm As TextBox
    Friend WithEvents NmLbl As Label
    Friend WithEvents TBoxCity As TextBox
    Friend WithEvents CtLbl As Label
    Friend WithEvents TBoxSem As TextBox
    Friend WithEvents SemLbl As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InsBtn As Button
    Friend WithEvents SrchBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents UpdBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SrchNm As Button
End Class
