<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportObjects
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
        Me.GenScript = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbTable = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbDatabase = New System.Windows.Forms.ComboBox()
        Me.BtnBrowseFile = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.filepath = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.RdFun = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RdProc = New System.Windows.Forms.RadioButton()
        Me.RdTable = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GenScript
        '
        Me.GenScript.Location = New System.Drawing.Point(469, 221)
        Me.GenScript.Name = "GenScript"
        Me.GenScript.Size = New System.Drawing.Size(86, 23)
        Me.GenScript.TabIndex = 11
        Me.GenScript.Text = "Generate SQL Script"
        Me.GenScript.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPwd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 86)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source SQL Server"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(541, 55)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(439, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Password"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(517, 19)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(100, 20)
        Me.txtPwd.TabIndex = 2
        Me.txtPwd.Text = "nic@123"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "User Name"
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(305, 19)
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
        Me.txtServer.Size = New System.Drawing.Size(100, 20)
        Me.txtServer.TabIndex = 0
        Me.txtServer.Text = "127.0.0.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Select Object"
        '
        'CmbTable
        '
        Me.CmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTable.FormattingEnabled = True
        Me.CmbTable.Location = New System.Drawing.Point(128, 51)
        Me.CmbTable.Name = "CmbTable"
        Me.CmbTable.Size = New System.Drawing.Size(196, 21)
        Me.CmbTable.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Select Database "
        '
        'CmbDatabase
        '
        Me.CmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDatabase.FormattingEnabled = True
        Me.CmbDatabase.Location = New System.Drawing.Point(128, 19)
        Me.CmbDatabase.Name = "CmbDatabase"
        Me.CmbDatabase.Size = New System.Drawing.Size(196, 21)
        Me.CmbDatabase.TabIndex = 4
        '
        'BtnBrowseFile
        '
        Me.BtnBrowseFile.Location = New System.Drawing.Point(542, 79)
        Me.BtnBrowseFile.Name = "BtnBrowseFile"
        Me.BtnBrowseFile.Size = New System.Drawing.Size(86, 23)
        Me.BtnBrowseFile.TabIndex = 10
        Me.BtnBrowseFile.Text = "Browse Folder"
        Me.BtnBrowseFile.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Choose Folder"
        '
        'filepath
        '
        Me.filepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filepath.Location = New System.Drawing.Point(128, 78)
        Me.filepath.Multiline = True
        Me.filepath.Name = "filepath"
        Me.filepath.Size = New System.Drawing.Size(406, 24)
        Me.filepath.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(562, 221)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RdFun
        '
        Me.RdFun.AutoSize = True
        Me.RdFun.Location = New System.Drawing.Point(557, 24)
        Me.RdFun.Name = "RdFun"
        Me.RdFun.Size = New System.Drawing.Size(71, 17)
        Me.RdFun.TabIndex = 7
        Me.RdFun.Text = "Functions"
        Me.RdFun.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Create Script for"
        '
        'RdProc
        '
        Me.RdProc.AutoSize = True
        Me.RdProc.Location = New System.Drawing.Point(478, 23)
        Me.RdProc.Name = "RdProc"
        Me.RdProc.Size = New System.Drawing.Size(79, 17)
        Me.RdProc.TabIndex = 6
        Me.RdProc.Text = "Procedures"
        Me.RdProc.UseVisualStyleBackColor = True
        '
        'RdTable
        '
        Me.RdTable.AutoSize = True
        Me.RdTable.Location = New System.Drawing.Point(420, 23)
        Me.RdTable.Name = "RdTable"
        Me.RdTable.Size = New System.Drawing.Size(57, 17)
        Me.RdTable.TabIndex = 5
        Me.RdTable.Text = "Tables"
        Me.RdTable.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbTable)
        Me.GroupBox2.Controls.Add(Me.RdFun)
        Me.GroupBox2.Controls.Add(Me.CmbDatabase)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RdProc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.RdTable)
        Me.GroupBox2.Controls.Add(Me.filepath)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.BtnBrowseFile)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(633, 111)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Database and Its Objects"
        '
        'ExportObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 250)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GenScript)
        Me.Name = "ExportObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Script Tool- SQL Server"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GenScript As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbTable As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbDatabase As System.Windows.Forms.ComboBox
    Friend WithEvents BtnBrowseFile As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents filepath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents RdFun As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RdProc As System.Windows.Forms.RadioButton
    Friend WithEvents RdTable As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
