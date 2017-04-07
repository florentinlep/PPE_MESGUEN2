Public Class Connexion

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As Collection

    Private Sub Submit_Click(sender As System.Object, e As System.EventArgs) Handles Submit.Click

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.216)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA16)));Uid=u_mesguen;Pwd=mesguen_password;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim query As String = "SELECT emplLoggin, emplMdp FROM employe WHERE emplLoggin='" & Username.Text & "' AND emplMdp='" & Password.Text & "'"
        donnee = New Collection

        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            donnee.Add(myReader.GetString(0))
        End While

        If donnee.Count > 0 Then
            choixChauffeur.Show()
        Else
            MessageBox.Show("Connexion Échouée")
        End If

        myConnection.Close()
    End Sub
End Class