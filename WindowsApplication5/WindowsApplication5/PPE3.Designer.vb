<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choixChauffeur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.listeTournee = New System.Windows.Forms.ListView()
        Me.detailsChauffeurGroupBox = New System.Windows.Forms.GroupBox()
        Me.coordonnees = New System.Windows.Forms.GroupBox()
        Me.afficheLongitude = New System.Windows.Forms.Label()
        Me.afficheLatitude = New System.Windows.Forms.Label()
        Me.latitudeCordonnees = New System.Windows.Forms.Label()
        Me.longitudeCoordonnees = New System.Windows.Forms.Label()
        Me.affichePrenom = New System.Windows.Forms.Label()
        Me.afficheNom = New System.Windows.Forms.Label()
        Me.labelPrenom = New System.Windows.Forms.Label()
        Me.labelNom = New System.Windows.Forms.Label()
        Me.labelListeChauffeur = New System.Windows.Forms.Label()
        Me.listeChauffeur = New System.Windows.Forms.ComboBox()
        Me.afficheMap = New System.Windows.Forms.PictureBox()
        Me.bouttonMapTable = New System.Windows.Forms.Button()
        Me.afficheVehiculeKmCompteur = New System.Windows.Forms.Label()
        Me.afficheVehiculeMarque = New System.Windows.Forms.Label()
        Me.afficheVehicule = New System.Windows.Forms.Label()
        Me.afficheVehiculeImmat = New System.Windows.Forms.Label()
        Me.afficheTournee = New System.Windows.Forms.Label()
        Me.afficheEtapes = New System.Windows.Forms.DataGridView()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.detailsChauffeurGroupBox.SuspendLayout()
        Me.coordonnees.SuspendLayout()
        CType(Me.afficheMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.afficheEtapes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.listeTournee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.detailsChauffeurGroupBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.labelListeChauffeur)
        Me.SplitContainer1.Panel1.Controls.Add(Me.listeChauffeur)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.afficheMap)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bouttonMapTable)
        Me.SplitContainer1.Panel2.Controls.Add(Me.afficheVehiculeKmCompteur)
        Me.SplitContainer1.Panel2.Controls.Add(Me.afficheVehiculeMarque)
        Me.SplitContainer1.Panel2.Controls.Add(Me.afficheVehicule)
        Me.SplitContainer1.Panel2.Controls.Add(Me.afficheVehiculeImmat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.afficheTournee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.afficheEtapes)
        Me.SplitContainer1.Size = New System.Drawing.Size(982, 717)
        Me.SplitContainer1.SplitterDistance = 353
        Me.SplitContainer1.TabIndex = 0
        '
        'listeTournee
        '
        Me.listeTournee.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.listeTournee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.listeTournee.FullRowSelect = True
        Me.listeTournee.GridLines = True
        Me.listeTournee.Location = New System.Drawing.Point(13, 251)
        Me.listeTournee.Name = "listeTournee"
        Me.listeTournee.Size = New System.Drawing.Size(322, 456)
        Me.listeTournee.TabIndex = 0
        Me.listeTournee.UseCompatibleStateImageBehavior = False
        Me.listeTournee.Visible = False
        '
        'detailsChauffeurGroupBox
        '
        Me.detailsChauffeurGroupBox.Controls.Add(Me.coordonnees)
        Me.detailsChauffeurGroupBox.Controls.Add(Me.affichePrenom)
        Me.detailsChauffeurGroupBox.Controls.Add(Me.afficheNom)
        Me.detailsChauffeurGroupBox.Controls.Add(Me.labelPrenom)
        Me.detailsChauffeurGroupBox.Controls.Add(Me.labelNom)
        Me.detailsChauffeurGroupBox.Location = New System.Drawing.Point(13, 73)
        Me.detailsChauffeurGroupBox.Name = "detailsChauffeurGroupBox"
        Me.detailsChauffeurGroupBox.Size = New System.Drawing.Size(322, 172)
        Me.detailsChauffeurGroupBox.TabIndex = 3
        Me.detailsChauffeurGroupBox.TabStop = False
        Me.detailsChauffeurGroupBox.Text = "Détails du chauffeur"
        Me.detailsChauffeurGroupBox.Visible = False
        '
        'coordonnees
        '
        Me.coordonnees.Controls.Add(Me.afficheLongitude)
        Me.coordonnees.Controls.Add(Me.afficheLatitude)
        Me.coordonnees.Controls.Add(Me.latitudeCordonnees)
        Me.coordonnees.Controls.Add(Me.longitudeCoordonnees)
        Me.coordonnees.Location = New System.Drawing.Point(6, 92)
        Me.coordonnees.Name = "coordonnees"
        Me.coordonnees.Size = New System.Drawing.Size(200, 74)
        Me.coordonnees.TabIndex = 9
        Me.coordonnees.TabStop = False
        Me.coordonnees.Text = "Coordonnées"
        '
        'afficheLongitude
        '
        Me.afficheLongitude.AutoSize = True
        Me.afficheLongitude.Location = New System.Drawing.Point(62, 48)
        Me.afficheLongitude.Name = "afficheLongitude"
        Me.afficheLongitude.Size = New System.Drawing.Size(0, 13)
        Me.afficheLongitude.TabIndex = 11
        '
        'afficheLatitude
        '
        Me.afficheLatitude.AutoSize = True
        Me.afficheLatitude.Location = New System.Drawing.Point(62, 25)
        Me.afficheLatitude.Name = "afficheLatitude"
        Me.afficheLatitude.Size = New System.Drawing.Size(0, 13)
        Me.afficheLatitude.TabIndex = 10
        '
        'latitudeCordonnees
        '
        Me.latitudeCordonnees.AutoSize = True
        Me.latitudeCordonnees.Location = New System.Drawing.Point(6, 25)
        Me.latitudeCordonnees.Name = "latitudeCordonnees"
        Me.latitudeCordonnees.Size = New System.Drawing.Size(31, 13)
        Me.latitudeCordonnees.TabIndex = 8
        Me.latitudeCordonnees.Text = "Lat. :"
        '
        'longitudeCoordonnees
        '
        Me.longitudeCoordonnees.AutoSize = True
        Me.longitudeCoordonnees.Location = New System.Drawing.Point(6, 48)
        Me.longitudeCoordonnees.Name = "longitudeCoordonnees"
        Me.longitudeCoordonnees.Size = New System.Drawing.Size(40, 13)
        Me.longitudeCoordonnees.TabIndex = 5
        Me.longitudeCoordonnees.Text = "Long. :"
        '
        'affichePrenom
        '
        Me.affichePrenom.AutoSize = True
        Me.affichePrenom.Location = New System.Drawing.Point(68, 75)
        Me.affichePrenom.Name = "affichePrenom"
        Me.affichePrenom.Size = New System.Drawing.Size(0, 13)
        Me.affichePrenom.TabIndex = 6
        '
        'afficheNom
        '
        Me.afficheNom.AutoSize = True
        Me.afficheNom.Location = New System.Drawing.Point(68, 38)
        Me.afficheNom.Name = "afficheNom"
        Me.afficheNom.Size = New System.Drawing.Size(0, 13)
        Me.afficheNom.TabIndex = 3
        '
        'labelPrenom
        '
        Me.labelPrenom.AutoSize = True
        Me.labelPrenom.Location = New System.Drawing.Point(7, 62)
        Me.labelPrenom.Name = "labelPrenom"
        Me.labelPrenom.Size = New System.Drawing.Size(49, 13)
        Me.labelPrenom.TabIndex = 2
        Me.labelPrenom.Text = "Prenom :"
        '
        'labelNom
        '
        Me.labelNom.AutoSize = True
        Me.labelNom.Location = New System.Drawing.Point(6, 25)
        Me.labelNom.Name = "labelNom"
        Me.labelNom.Size = New System.Drawing.Size(35, 13)
        Me.labelNom.TabIndex = 1
        Me.labelNom.Text = "Nom :"
        '
        'labelListeChauffeur
        '
        Me.labelListeChauffeur.AutoSize = True
        Me.labelListeChauffeur.Location = New System.Drawing.Point(10, 24)
        Me.labelListeChauffeur.Name = "labelListeChauffeur"
        Me.labelListeChauffeur.Size = New System.Drawing.Size(135, 13)
        Me.labelListeChauffeur.TabIndex = 1
        Me.labelListeChauffeur.Text = "Selectionner un chauffeur :"
        '
        'listeChauffeur
        '
        Me.listeChauffeur.FormattingEnabled = True
        Me.listeChauffeur.Location = New System.Drawing.Point(144, 21)
        Me.listeChauffeur.Name = "listeChauffeur"
        Me.listeChauffeur.Size = New System.Drawing.Size(191, 21)
        Me.listeChauffeur.TabIndex = 0
        '
        'afficheMap
        '
        Me.afficheMap.Location = New System.Drawing.Point(10, 107)
        Me.afficheMap.Name = "afficheMap"
        Me.afficheMap.Size = New System.Drawing.Size(600, 600)
        Me.afficheMap.TabIndex = 8
        Me.afficheMap.TabStop = False
        Me.afficheMap.Visible = False
        '
        'bouttonMapTable
        '
        Me.bouttonMapTable.Location = New System.Drawing.Point(466, 24)
        Me.bouttonMapTable.Name = "bouttonMapTable"
        Me.bouttonMapTable.Size = New System.Drawing.Size(144, 34)
        Me.bouttonMapTable.TabIndex = 7
        Me.bouttonMapTable.Text = "Afficher la carte"
        Me.bouttonMapTable.UseVisualStyleBackColor = True
        Me.bouttonMapTable.Visible = False
        '
        'afficheVehiculeKmCompteur
        '
        Me.afficheVehiculeKmCompteur.AutoSize = True
        Me.afficheVehiculeKmCompteur.Location = New System.Drawing.Point(434, 83)
        Me.afficheVehiculeKmCompteur.Name = "afficheVehiculeKmCompteur"
        Me.afficheVehiculeKmCompteur.Size = New System.Drawing.Size(0, 13)
        Me.afficheVehiculeKmCompteur.TabIndex = 5
        '
        'afficheVehiculeMarque
        '
        Me.afficheVehiculeMarque.AutoSize = True
        Me.afficheVehiculeMarque.Location = New System.Drawing.Point(224, 82)
        Me.afficheVehiculeMarque.Name = "afficheVehiculeMarque"
        Me.afficheVehiculeMarque.Size = New System.Drawing.Size(0, 13)
        Me.afficheVehiculeMarque.TabIndex = 4
        '
        'afficheVehicule
        '
        Me.afficheVehicule.AutoSize = True
        Me.afficheVehicule.Location = New System.Drawing.Point(8, 60)
        Me.afficheVehicule.Name = "afficheVehicule"
        Me.afficheVehicule.Size = New System.Drawing.Size(54, 13)
        Me.afficheVehicule.TabIndex = 3
        Me.afficheVehicule.Text = "Vehicule :"
        Me.afficheVehicule.Visible = False
        '
        'afficheVehiculeImmat
        '
        Me.afficheVehiculeImmat.AutoSize = True
        Me.afficheVehiculeImmat.Location = New System.Drawing.Point(13, 83)
        Me.afficheVehiculeImmat.Name = "afficheVehiculeImmat"
        Me.afficheVehiculeImmat.Size = New System.Drawing.Size(0, 13)
        Me.afficheVehiculeImmat.TabIndex = 2
        '
        'afficheTournee
        '
        Me.afficheTournee.AutoSize = True
        Me.afficheTournee.Location = New System.Drawing.Point(12, 13)
        Me.afficheTournee.Name = "afficheTournee"
        Me.afficheTournee.Size = New System.Drawing.Size(0, 13)
        Me.afficheTournee.TabIndex = 1
        '
        'afficheEtapes
        '
        Me.afficheEtapes.AllowUserToAddRows = False
        Me.afficheEtapes.AllowUserToDeleteRows = False
        Me.afficheEtapes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.afficheEtapes.BackgroundColor = System.Drawing.Color.White
        Me.afficheEtapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.afficheEtapes.GridColor = System.Drawing.Color.White
        Me.afficheEtapes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.afficheEtapes.Location = New System.Drawing.Point(11, 107)
        Me.afficheEtapes.Name = "afficheEtapes"
        Me.afficheEtapes.ReadOnly = True
        Me.afficheEtapes.RowHeadersVisible = False
        Me.afficheEtapes.Size = New System.Drawing.Size(599, 600)
        Me.afficheEtapes.TabIndex = 0
        Me.afficheEtapes.Visible = False
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'choixChauffeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 717)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "choixChauffeur"
        Me.Text = "CHAUFFEUR"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.detailsChauffeurGroupBox.ResumeLayout(False)
        Me.detailsChauffeurGroupBox.PerformLayout()
        Me.coordonnees.ResumeLayout(False)
        Me.coordonnees.PerformLayout()
        CType(Me.afficheMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.afficheEtapes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents listeChauffeur As System.Windows.Forms.ComboBox
    Friend WithEvents labelListeChauffeur As System.Windows.Forms.Label
    Friend WithEvents detailsChauffeurGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents longitudeCoordonnees As System.Windows.Forms.Label
    Friend WithEvents afficheNom As System.Windows.Forms.Label
    Friend WithEvents labelPrenom As System.Windows.Forms.Label
    Friend WithEvents labelNom As System.Windows.Forms.Label
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents affichePrenom As System.Windows.Forms.Label
    Friend WithEvents latitudeCordonnees As System.Windows.Forms.Label
    Friend WithEvents coordonnees As System.Windows.Forms.GroupBox
    Friend WithEvents afficheLongitude As System.Windows.Forms.Label
    Friend WithEvents afficheLatitude As System.Windows.Forms.Label
    Friend WithEvents listeTournee As System.Windows.Forms.ListView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents afficheEtapes As System.Windows.Forms.DataGridView
    Friend WithEvents afficheTournee As System.Windows.Forms.Label
    Friend WithEvents afficheVehiculeImmat As System.Windows.Forms.Label
    Friend WithEvents afficheVehicule As System.Windows.Forms.Label
    Friend WithEvents afficheVehiculeMarque As System.Windows.Forms.Label
    Friend WithEvents afficheVehiculeKmCompteur As System.Windows.Forms.Label
    Friend WithEvents bouttonMapTable As System.Windows.Forms.Button
    Friend WithEvents afficheMap As System.Windows.Forms.PictureBox

End Class
