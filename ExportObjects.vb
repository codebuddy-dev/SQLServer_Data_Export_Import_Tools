Imports Microsoft.SqlServer.Management.Smo
Imports System.Text
Imports System.Collections.Specialized
Imports System.IO

Public Class ExportObjects
    Dim DS As New DataSet
    Dim CON As New DBConnClass
    Dim retval, fn As String


    Private Sub CmbDatabase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CmbDatabase.SelectionChangeCommitted
        Try

            If RdTable.Checked = True Then
                Call fill_Tables()
            End If

            If RdProc.Checked = True Then
                Call fill_Procedures()
            End If

            If RdFun.Checked = True Then
                Call fill_Functions()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerateTable()

        Dim sb As New StringBuilder()

        Try
            Dim dbName As String = CmbDatabase.SelectedValue.ToString
            Dim tableName As String = CmbTable.SelectedValue.ToString

            ' set up the SMO server objects - I'm using "integrated security" here for simplicity

            MsgBox("SQL Script is running upto this")
            Dim srv As New Server()

            srv.ConnectionContext.LoginSecure = False
            srv.ConnectionContext.ServerInstance = Me.txtServer.Text
            srv.ConnectionContext.Login = Me.txtUname.Text
            srv.ConnectionContext.Password = Me.txtPwd.Text

            ' get the database in question
            Dim db As New Database()
            db = srv.Databases(dbName)

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

            Dim createScript As String = sb.ToString()
            Dim fname As String
            fname = filepath.Text & "\" & CmbTable.SelectedValue.ToString() & ".sql"
            System.IO.File.WriteAllText(fname, createScript)

            MsgBox("SQL Script is Generated Successfully")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerateTableSQL()

        Dim dbName As String = CmbDatabase.SelectedValue.ToString
        Dim tableName As String = CmbTable.SelectedValue.ToString

        ' set up the SMO server objects - I'm using "integrated security" here for simplicity
        Dim srv As New Server()

        Try
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

            Dim createScript As String = sb.ToString()
            Dim fname As String
            fname = filepath.Text & "\" & CmbTable.SelectedValue.ToString() & ".sql"
            System.IO.File.WriteAllText(fname, createScript)

            MsgBox("SQL Script is Generated Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GenScript_Click(sender As System.Object, e As System.EventArgs) Handles GenScript.Click

        If filepath.Text = "" Then
            MsgBox("Please Browse the folder for creation of file")
            Exit Sub
        Else
            If RdTable.Checked = True Then
                'Call GenerateTableSQL()
                Call GenerateTable()
            ElseIf RdProc.Checked = True Then
                Call GenerateProcedureScript()
            ElseIf RdFun.Checked = True Then
                Call GenerateProcedureScript()
            End If
        End If
        Me.GroupBox2.Enabled = False
        Me.GenScript.Enabled = False

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
                ' MsgBox("Connection to SQL Server is Successful")
                'Call fill_Tables()
                Me.btnConnect.Enabled = False
                GroupBox2.Enabled = True
                GenScript.Enabled = True
            End If
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
    Public Sub fill_Procedures()
        Dim st As String
        Try
            ' st = "use " & CmbDatabase.SelectedValue.ToString & ";SELECT name FROM sys.procedures order by 1"
            st = "use " & CmbDatabase.SelectedValue.ToString & ";SELECT name FROM sys.objects WHERE type_desc LIKE '%procedure%' order by 1"
            DS = CON.ReturnDataSet(st, retval)
            CmbTable.DataSource = DS.Tables(0)
            CmbTable.DisplayMember = "name"
            CmbTable.ValueMember = "name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub fill_Functions()
        Dim st As String
        Try
            ' st = "use " & CmbDatabase.SelectedValue.ToString & ";SELECT name FROM sys.procedures order by 1"
            st = "use " & CmbDatabase.SelectedValue.ToString & ";SELECT name  FROM sys.objects WHERE type_desc LIKE '%FUNCTION%' order by 1"
            DS = CON.ReturnDataSet(st, retval)
            CmbTable.DataSource = DS.Tables(0)
            CmbTable.DisplayMember = "name"
            CmbTable.ValueMember = "name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerateProcedureScript()
        Dim st As String
        Dim sb As New StringBuilder()

        Try
            st = "use " & CmbDatabase.SelectedValue.ToString & "; select definition from sys.sql_modules where object_id = object_id('" & CmbTable.SelectedValue.ToString & "')"
            DS = CON.ReturnDataSet(st, retval)


            sb.Append(DS.Tables(0).Rows(0)("definition"))
            Dim createScript As String = sb.ToString()

            Dim fname As String
            fname = filepath.Text & "\" & CmbTable.SelectedValue.ToString() & ".sql"
            System.IO.File.WriteAllText(fname, createScript)

            MsgBox("SQL Script is Generated Successfully")

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

    
    Private Sub RdTable_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Try
            If RdTable.Checked = True And CmbDatabase.SelectedValue.ToString <> "" Then
                Call fill_Tables()
            End If
        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RdProc_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Try
            If RdProc.Checked = True And CmbDatabase.SelectedValue.ToString <> "" Then
                Call fill_Procedures()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RdFun_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Try
            If RdFun.Checked = True And CmbDatabase.SelectedValue.ToString <> "" Then
                Call fill_Functions()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    
    Private Sub RdTable_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles RdTable.CheckedChanged
        Call fill_Tables()

    End Sub

    Private Sub RdProc_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles RdProc.CheckedChanged
        Call fill_Procedures()
    End Sub

    Private Sub RdFun_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles RdFun.CheckedChanged
        Call fill_Functions()
    End Sub

    Private Sub ExportObjects_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
        GenScript.Enabled = False
    End Sub
End Class