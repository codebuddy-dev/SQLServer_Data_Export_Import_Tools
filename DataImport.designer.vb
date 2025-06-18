<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataImport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbDatabase = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Chkbox = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnBrowseFile = New System.Windows.Forms.Button()
        Me.filepath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbTable = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPwd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 124)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destination SQL Server"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(584, 87)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Password"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(119, 92)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(100, 20)
        Me.txtPwd.TabIndex = 2
        Me.txtPwd.Text = "nic@123"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "User Name"
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(119, 65)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(100, 20)
        Me.txtUname.TabIndex = 1
        Me.txtUname.Text = "sa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Server Name "
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(119, 19)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(540, 20)
        Me.txtServer.TabIndex = 0
        Me.txtServer.Text = "127.0.0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Select Database "
        '
        'CmbDatabase
        '
        Me.CmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDatabase.FormattingEnabled = True
        Me.CmbDatabase.Location = New System.Drawing.Point(140, 144)
        Me.CmbDatabase.Name = "CmbDatabase"
        Me.CmbDatabase.Size = New System.Drawing.Size(524, 21)
        Me.CmbDatabase.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Data Files"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(511, 240)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(72, 22)
        Me.btnImport.TabIndex = 8
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Chkbox
        '
        Me.Chkbox.AutoSize = True
        Me.Chkbox.Location = New System.Drawing.Point(18, 240)
        Me.Chkbox.Name = "Chkbox"
        Me.Chkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chkbox.Size = New System.Drawing.Size(136, 17)
        Me.Chkbox.TabIndex = 16
        Me.Chkbox.Text = "Create Database Table"
        Me.Chkbox.UseVisualStyleBackColor = True
        Me.Chkbox.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnBrowseFile
        '
        Me.BtnBrowseFile.Location = New System.Drawing.Point(589, 204)
        Me.BtnBrowseFile.Name = "BtnBrowseFile"
        Me.BtnBrowseFile.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowseFile.TabIndex = 7
        Me.BtnBrowseFile.Text = "Browse File"
        Me.BtnBrowseFile.UseVisualStyleBackColor = True
        '
        'filepath
        '
        Me.filepath.Location = New System.Drawing.Point(140, 204)
        Me.filepath.Name = "filepath"
        Me.filepath.Size = New System.Drawing.Size(443, 20)
        Me.filepath.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Select Table"
        '
        'CmbTable
        '
        Me.CmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTable.FormattingEnabled = True
        Me.CmbTable.Location = New System.Drawing.Point(140, 171)
        Me.CmbTable.Name = "CmbTable"
        Me.CmbTable.Size = New System.Drawing.Size(524, 21)
        Me.CmbTable.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(589, 240)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 22)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(542, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Note: The table in which the data to  imported should have same structure of expo" &
    "rted table"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(13, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(404, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "(IP address or SQL Server Instance name installed on your system)"
        '
        'DataImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 289)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbTable)
        Me.Controls.Add(Me.filepath)
        Me.Controls.Add(Me.BtnBrowseFile)
        Me.Controls.Add(Me.Chkbox)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbDatabase)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DataImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Import Tool- SQL Server"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbDatabase As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents Chkbox As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnBrowseFile As System.Windows.Forms.Button
    Friend WithEvents filepath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbTable As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
End Class
