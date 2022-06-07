Imports System.Data.Odbc


Module Module1
    Public conn As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public CMD As OdbcCommand
    Public RD As OdbcDataReader

    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Driver={Mysql odbc 3.51 driver};database=db_perpus_vbnet;server=localhost;uid=root;port=3307"
        conn = New OdbcConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module