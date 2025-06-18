Imports System.Data
'Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlClient

Public Class DBConnClass
    Dim constr As String
    ' Dim constr As String = "packet size=4096;user id=; password=; data source=;persist security info=False;initial catalog=master;Max Pool Size=100"
    Public Function DBConnect(ByVal srv As String, ByVal un As String, ByVal pw As String) As String
        Dim ret As String
        constr = "packet size=4096;user id=" & un & "; password=" & pw & "; data source=" & srv & ";persist security info=False;initial catalog=master;Max Pool Size=100"
        Dim con As New SqlConnection(constr)
        con.Open()
        If con.State = 1 Then
            ret = constr
        Else
            ret = ""
        End If
        Return ret
    End Function
    Public Function ReturnDataSet(ByVal qry As String, ByVal constr As String) As DataSet
        Dim con As New SqlConnection(constr)
        con.Open()
        Dim sda As New SqlDataAdapter(qry, con)
        Dim ds As New DataSet()
        sda.Fill(ds)
        con.Close()
        Return ds
    End Function


    Public Function ExeReader(ByVal DMLSql As String) As SqlCommand
        Dim con As New SqlConnection(constr)
        con.Open()
        Dim cmd As New SqlCommand(DMLSql, con)
        cmd.ExecuteReader()
        con.Close()
        Return cmd
    End Function

    Public Function ConvertDate(ByVal InputDate As String) As String
        Return (Mid(InputDate, 7, 4) & "-" & Mid(InputDate, 4, 2) & "-" & Mid(InputDate, 1, 2))
    End Function
End Class