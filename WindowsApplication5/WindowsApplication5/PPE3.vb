Imports System.Text
Imports System.Net
Imports System.IO


Public Class choixChauffeur
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Function connexionBdd()
        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.216)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA16)));Uid=u_mesguen_ppe3;Pwd=mesguen_password;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Return myConnection
    End Function

    Private Sub choixChauffeur_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        Dim myConnection = connexionBdd()

        query = "SELECT emplId, emplNom, emplPrenom, emplGPS FROM employe WHERE emplCat='Chauffeur' ORDER BY emplNom, emplPrenom"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        listeChauffeur.Text = "Choisissez un chauffeur"

        While myReader.Read
            listeChauffeur.Items.Add(New Employe(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3)))
        End While

        listeTournee.Columns.Add(New ColumnHeader)
        listeTournee.Columns(0).Text = "Tournée"
        listeTournee.Columns(0).Width = -2
        listeTournee.View = View.Details

        myConnection.Close()
    End Sub

    Private Sub listeChauffeur_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles listeChauffeur.SelectedIndexChanged
        detailsChauffeurGroupBox.Visible = True
        listeTournee.Visible = True

        afficheNom.Text = listeChauffeur.SelectedItem._emplNom
        affichePrenom.Text = listeChauffeur.SelectedItem._emplPrenom
        afficheLatitude.Text = listeChauffeur.SelectedItem.getEmplGPS(0)
        afficheLongitude.Text = listeChauffeur.SelectedItem.getEmplGPS(1)

        listeTournee.Clear()
        listeTournee.Columns.Add(New ColumnHeader)
        listeTournee.Columns(0).Text = "Tournée"
        listeTournee.Columns(0).Width = -2
        listeTournee.View = View.Details

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.216)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA16)));Uid=u_mesguen_ppe3;Pwd=mesguen_password;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim tournee As Tournee
        Dim query As String = "SELECT trnNum, chfId, vehMat, trnDepChf FROM tournee WHERE chfId=" & listeChauffeur.SelectedItem._emplId
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            tournee = New Tournee(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3))
            listeTournee.Scrollable = True
            listeTournee.Items.Add(tournee._trnNum)
        End While

        myConnection.Close()
    End Sub

    Private Sub listeTournee_SelectedIndexChanged_2(sender As System.Object, e As System.EventArgs) Handles listeTournee.MouseClick
        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.216)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA16)));Uid=u_mesguen_ppe3;Pwd=mesguen_password;"
        myConnection.ConnectionString = connString

        afficheTournee.Text = "Tournee n°" & listeTournee.SelectedItems.Item(0).Text
        afficheVehicule.Visible = True

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT vehicule.vehMat, vehMarque, vehKmCompteur FROM vehicule, tournee WHERE vehicule.vehMat=tournee.vehMat AND trnNum=" & listeTournee.SelectedItems.Item(0).Text
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        Dim vehicule As Vehicule

        While myReader.Read
            vehicule = New Vehicule(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2))
            afficheVehiculeImmat.Text = vehicule._vehMat
            afficheVehiculeMarque.Text = vehicule._vehMarque
            afficheVehiculeKmCompteur.Text = vehicule._vehKmCompteur & " km"
        End While

        bouttonMapTable.Visible = True

        myConnection.Close()

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.216)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA16)));Uid=u_mesguen_ppe3;Pwd=mesguen_password;"
        myConnection.ConnectionString = connString

        afficheEtapes.Visible = True

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        query = "SELECT etpId, lieuNom, comNom, etpRDV FROM etape, lieu, commune WHERE trnNum=" & listeTournee.SelectedItems.Item(0).Text & " AND etape.lieuId=lieu.lieuId AND lieu.comId=commune.comId ORDER BY etpRDV"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader


        Dim donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        afficheEtapes.DataSource = donnee

        myConnection.Close()
    End Sub

    Private Sub bouttonMapTable_Click(sender As System.Object, e As System.EventArgs) Handles bouttonMapTable.Click
        If afficheEtapes.Visible = True Then
            afficheEtapes.Visible = False
            afficheMap.Visible = True
            bouttonMapTable.Text = "Afficher le tableau"
            affichePointsMap()
        Else
            afficheEtapes.Visible = True
            afficheMap.Visible = False
            bouttonMapTable.Text = "Afficher la carte"
        End If
    End Sub

    Public Sub affichePointsMap()
        Dim tClient As WebClient = New WebClient
        Dim lieu As Lieu

        Dim url = New StringBuilder("https://maps.googleapis.com/maps/api/staticmap?center=46.7949846,2.1176723&zoom=6&size=800x600&maptype=roadmap")

        connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.216)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA16)));Uid=u_mesguen_ppe3;Pwd=mesguen_password;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query = "SELECT lieu.lieuId, lieuNom, comId, lieuGps FROM etape, lieu WHERE trnNum=" & listeTournee.SelectedItems.Item(0).Text & " AND etape.lieuId=lieu.lieuId"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            lieu = New Lieu(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3))
            url.Append("&markers=" & lieu._lieuGps)
        End While

        url.Append("&key=AIzaSyA3zvNv-ETo8ZrrlvjtoHrOAJv3MfzlvBU")

        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(url.ToString)))

        afficheMap.Image = tImage

        myConnection.Close()
    End Sub
End Class
