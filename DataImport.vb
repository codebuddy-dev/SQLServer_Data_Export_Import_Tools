Public Class DataImport
    Dim DS As New DataSet
    Dim CON As New DBConnClass
    Dim retval, fn As String
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
                Call fill_Tables()
                Me.btnConnect.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImport_Click(sender As System.Object, e As System.EventArgs) Handles btnImport.Click
        Try
            'Dim procStartInfo As New System.Diagnostics.ProcessStartInfo("cmd", "/c " & "bcp Oceanic.dbo." & dBname & " out C:\ProgramData\Oceanic\" & filename & " -U username -P password -n")
            Dim qry, qry2 As String

            'BCP for Entire table
            'qry = "bcp Northwind.dbo.Orders out E:\texalab\DataTools\Orders-bcp.txt -SRAMESHNIC -Usa -Pnic@123 -w"

            'BCP for OutQuery Static
            'qry = """select * from Northwind.dbo.Orders where CustomerID='RICSU'"""
            'qry2 = " Queryout E:\texalab\DataTools\Orders-bcp4.txt -SRAMESHNIC -Usa -Pnic@123 -w"


            If Me.filepath.Text = "" Then
                MsgBox("Please select the File for Data Porting ")
                Exit Sub
            End If

            If fn <> CmbTable.SelectedValue.ToString Then
                MsgBox("Data Can be Imported to same table with same structure only")
                Exit Sub
            End If
          
            Me.filepath.Enabled = False
            Me.BtnBrowseFile.Enabled = False
            Me.CmbDatabase.Enabled = False
            Me.CmbTable.Enabled = False
            Me.btnImport.Enabled = False

            qry = "bcp """ & CmbDatabase.SelectedValue.ToString & ".dbo." & CmbTable.SelectedValue.ToString & """"
            qry2 = " in " & Me.filepath.Text & " -S" & Me.txtServer.Text & " -U" & Me.txtUname.Text & " -P" & Me.txtPwd.Text & " -w -t"


            qry = qry & qry2

            'Me.filepath.Text = qry

            Dim procStartInfo As New System.Diagnostics.ProcessStartInfo("cmd", "/c " & qry)
            procStartInfo.RedirectStandardOutput = True
            procStartInfo.UseShellExecute = False
            procStartInfo.CreateNoWindow = True
            Dim proc As New System.Diagnostics.Process()
            proc.StartInfo = procStartInfo
            proc.Start()
            Dim result As String = proc.StandardOutput.ReadToEnd()
            MsgBox(result)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBrowseFile_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowseFile.Click
        Try
            ' Me.FolderBrowserDialog1.ShowDialog()
            Dim fname As String
            Me.OpenFileDialog1.ShowDialog()
            'MsgBox(OpenFileDialog1.SafeFileName)
            fname = OpenFileDialog1.FileName
            'MsgBox(fname)
            Me.filepath.Text = fname
            fn = Mid(OpenFileDialog1.SafeFileName, 1, Len(OpenFileDialog1.SafeFileName) - 8)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmbDatabase_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CmbDatabase.SelectionChangeCommitted
        Try
            Dim st As String
            st = "SELECT TABLE_NAME FROM " & CmbDatabase.SelectedValue.ToString & ".information_schema.tables where TABLE_TYPE='BASE TABLE' and TABLE_CATALOG='" & CmbDatabase.SelectedValue.ToString & "' order by 1"
            DS = CON.ReturnDataSet(st, retval)
            CmbTable.DataSource = DS.Tables(0)
            CmbTable.DisplayMember = "TABLE_NAME"
            CmbTable.ValueMember = "TABLE_NAME"


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
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DataImport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class