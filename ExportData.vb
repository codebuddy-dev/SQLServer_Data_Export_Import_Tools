Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo
Imports System.Text
Imports System.Collections.Specialized
Imports System.IO
Public Class ExportData
    Dim DS As New DataSet
    Dim CON As New DBConnClass
    Dim retval As String

    Private Sub CmbDatabase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CmbDatabase.SelectionChangeCommitted
        Try
            Call fill_Tables()
            Call fill_column()
            Call fill_query()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmbTable_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CmbTable.SelectionChangeCommitted
        Try
            Call fill_column()
            Call fill_query()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lstColumn_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstColumn.SelectedIndexChanged
        Try
            Call fill_query()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Dim procStartInfo As New System.Diagnostics.ProcessStartInfo("cmd", "/c " & "bcp Oceanic.dbo." & dBname & " out C:\ProgramData\Oceanic\" & filename & " -U username -P password -n")
        Dim qry, qry2 As String
        Try

            If Me.TxtQuery.Text = "" Then
                MsgBox("Please write the query for Data Export to text file")
                Exit Sub
            End If

            If Me.filepath.Text = "" Then
                MsgBox("Please select the folder where the Data file to be saved")
                Exit Sub
            End If

            Me.lstColumn.Enabled = False
            Me.TxtQuery.Enabled = False
            Me.filepath.Enabled = False
            Me.ChkboxGScript.Enabled = False
            Me.BtnBrowseFile.Enabled = False
            Me.Button1.Enabled = False
            Me.CmbDatabase.Enabled = False
            Me.CmbTable.Enabled = False
            Me.GroupBox2.Enabled = False

            'BCP for Entire table
            'qry = "bcp Northwind.dbo.Orders out E:\texalab\DataTools\Orders-bcp.txt -SRAMESHNIC -Usa -Pnic@123 -w"

            'BCP for OutQuery Static
            'qry = """select * from Northwind.dbo.Orders where CustomerID='RICSU'"""
            'qry2 = " Queryout E:\texalab\DataTools\Orders-bcp4.txt -SRAMESHNIC -Usa -Pnic@123 -w"

            qry = "bcp """ & Me.TxtQuery.Text & """"
            ' qry2 = " Queryout E:\texalab\DataTools\Orders-bcp.txt -S127.0.0.1 -Usa -Pnic@123 -w"
            qry2 = " Queryout " & Me.filepath.Text & "\" & CmbTable.SelectedValue.ToString & "-bcp.txt -S" & Me.txtServer.Text & " -U" & Me.txtUname.Text & " -P" & Me.txtPwd.Text & " -w -t"

            qry = qry & qry2

            Dim procStartInfo As New System.Diagnostics.ProcessStartInfo("cmd", "/c " & qry)
            procStartInfo.RedirectStandardOutput = True
            procStartInfo.UseShellExecute = False
            procStartInfo.CreateNoWindow = True
            Dim proc As New System.Diagnostics.Process()
            proc.StartInfo = procStartInfo
            proc.Start()
            Dim result As String = proc.StandardOutput.ReadToEnd()

            'If Me.ChkboxGScript.Checked = True Then
            '    Call GenerateTableScript()
            'End If

            MsgBox(result)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnConnect_Click(sender As System.Object, e As System.EventArgs) Handles btnConnect.Click
        Try

            retval = CON.DBConnect(Me.txtServer.Text, Me.txtUname.Text, Me.txtPwd.Text)
            If retval <> "" Then
                Me.btnConnect.Enabled = False
                Me.txtServer.Enabled = False
                Me.txtUname.Enabled = False
                Me.txtPwd.Enabled = False

                DS = CON.ReturnDataSet("EXEC sp_databases", retval)
                CmbDatabase.DataSource = DS.Tables(0)
                CmbDatabase.DisplayMember = "DATABASE_NAME"
                CmbDatabase.ValueMember = "DATABASE_NAME"
               ' MsgBox("Connection to SQL Server Database is Successful")

                Me.GroupBox2.Enabled = True
                Me.btnConnect.Enabled = False
                Me.Button1.Enabled = True

                Call fill_Tables()
                Call fill_column()
                Call fill_query()
               
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    
    Private Sub BtnBrowseFile_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowseFile.Click
        Try
            ' Me.FolderBrowserDialog1.ShowDialog()
            Dim fname As String
            Me.FolderBrowserDialog1.ShowDialog()
            'MsgBox(OpenFileDialog1.SafeFileName)
            fname = FolderBrowserDialog1.SelectedPath
            'MsgBox(fname)
            Me.filepath.Text = fname
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub fill_Tables()
        Dim st As String
        Try
            st = "SELECT TABLE_NAME FROM " & CmbDatabase.SelectedValue.ToString & ".information_schema.tables where TABLE_TYPE='BASE TABLE' and TABLE_CATALOG='" & CmbDatabase.SelectedValue.ToString & "' order by 1"
            DS = CON.ReturnDataSet(st, retval)
            CmbTable.DataSource = DS.Tables(0)
            CmbTable.DisplayMember = "TABLE_NAME"
            CmbTable.ValueMember = "TABLE_NAME"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub fill_column()
        Try
            DS = CON.ReturnDataSet("SELECT COLUMN_NAME FROM " & CmbDatabase.SelectedValue.ToString & ".INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='" & CmbTable.SelectedValue.ToString & "'", retval)
            lstColumn.DataSource = DS.Tables(0)
            lstColumn.DisplayMember = "COLUMN_NAME"
            lstColumn.ValueMember = "COLUMN_NAME"
            Me.TxtQuery.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub fill_query()
        Try
            Me.TxtQuery.Text = "select top 100 * from " & CmbDatabase.SelectedValue.ToString & ".dbo." & CmbTable.SelectedValue.ToString & " where " & lstColumn.SelectedValue.ToString & "='" & "PARA'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub GenerateTableScript()
        ' Define your database and table you want to script out
        Dim dbName As String = CmbDatabase.SelectedValue.ToString
        Dim tableName As String = CmbTable.SelectedValue.ToString

        ' set up the SMO server objects - I'm using "integrated security" here for simplicity
        Dim srv As New Server()

        ' srv.ConnectionContext.LoginSecure = True

        srv.ConnectionContext.LoginSecure = False
        srv.ConnectionContext.ServerInstance = Me.txtServer.Text
        srv.ConnectionContext.Login = Me.txtUname.Text
        srv.ConnectionContext.Password = Me.txtPwd.Text

        ' get the database in question
        Dim db As New Database()
        db = srv.Databases(dbName)

        Dim sb As New StringBuilder()

        ' define the scripting options - what options to include or not
        Dim options As New ScriptingOptions()
        options.ClusteredIndexes = True
        options.[Default] = True
        options.DriAll = True
        options.Indexes = True
        options.IncludeHeaders = True

        ' script out the table's creation 
        Dim tbl As Table = db.Tables(tableName)

        Dim coll As StringCollection = tbl.Script(options)

        For Each str As String In coll
            sb.Append(str)
            sb.Append(Environment.NewLine)
        Next

        ' you can get the string that makes up the CREATE script here
        ' do with this CREATE script whatever you like!
        Dim createScript As String = sb.ToString()

        'Using dialog As New SaveFileDialog()
        '    If dialog.ShowDialog(Me) = DialogResult.OK Then
        '        File.WriteAllText(dialog.FileName, sb.ToString())
        '    End If
        'End Using

        'Dim file As New System.IO.StreamWriter("D:\d\mas_gram.txt")
        'file.WriteLine(createScript)
        Dim fname As String
        fname = filepath.Text & "\" & CmbTable.SelectedValue.ToString() & ".sql"

        System.IO.File.WriteAllText(fname, createScript)

    End Sub
    
    Private Sub ExportData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtUname_TextChanged(sender As Object, e As EventArgs) Handles txtUname.TextChanged

    End Sub
End Class
