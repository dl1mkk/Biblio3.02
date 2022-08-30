Imports System.Data.Common
Imports System.Net.Http
Imports Biblio3.ClassBUCH
Imports Biblio3.Database
Imports MySqlConnector.MySqlDataReader
Imports Biblio3.ClassLOG
Imports MySqlConnector

Public Class FormNEWBOOK

   ' Verbindung mit Datenbank "pars" herstellen
   Dim BUCH As New ClassBUCH()

   ' Die Daten des BUCH Objektes
   Dim REC As RecordBUCH

   ' Vorhanden : Boolean
   Dim Vorhanden As Boolean

   ' Die Datenbank-Verbindung etablieren
   Dim DB As New Database()

   Dim FEHLER As FehlerBUCH

   Dim BUCH_ID As Integer

   ' Liest die Listeneinträge für den Optionsbutton EINBAND
   ' Angehängt wird der Eintrag "(Neu)"
   Private Sub Init_Einband()
      ' Ergebnis Boolean
      Dim Result As Boolean
      ' Neuen Datenbank-Handler starten ...
      Dim DB As New Database()
      ' DataReader etablieren
      Dim DBrdr As MySqlConnector.MySqlDataReader
      '
      DB.Initialize("localhost", "root", "p3lsk20xp", "pars")
      Result = DB.Exec("SELECT einband FROM reinband ORDER BY id")
      DBrdr = DB.NewReader()
      If DBrdr.HasRows Then
         While DBrdr.Read()
            EINBAND.Items.Add(DBrdr.GetString(0))
         End While
         EINBAND.Items.Add("(Neu)")
      End If
      EINBAND.Text = EINBAND.Items.Item(0)
      EINBAND.Update()
      DBrdr.Close()
      DB.Close()
   End Sub

   ' Liest die Listeneinträge für den Optionsbutton KATEGORIE
   ' Angehängt wird der Eintrag "(Neu)"
   Private Sub Init_Kategorie()
      ' Ergebnis Boolean
      Dim Result As Boolean
      ' Neuen Datenbank-Handler starten ...
      Dim DB As New Database()
      ' DataReader etablieren
      Dim DBrdr As MySqlConnector.MySqlDataReader
      '
      DB.Initialize("localhost", "root", "p3lsk20xp", "pars")
      Result = DB.Exec("SELECT kategorie FROM rkategorie ORDER BY id")
      DBrdr = DB.NewReader()
      If DBrdr.HasRows Then
         While DBrdr.Read()
            KATEGORIE.Items.Add(DBrdr.GetString(0))
         End While
         KATEGORIE.Items.Add("(Neu)")
      End If
      KATEGORIE.Text = KATEGORIE.Items.Item(0)
      KATEGORIE.Update()
      DBrdr.Close()
      DB.Close()
   End Sub

   ' Liest die Listeneinträge für den Optionsbutton LAGERORT
   ' Angehängt wird der Eintrag "(Neu)"
   Private Sub Init_Lagerort()
      ' Ergebnis Boolean
      Dim Result As Boolean
      ' Neuen Datenbank-Handler starten ...
      Dim DB As New Database()
      ' DataReader etablieren
      Dim DBrdr As MySqlConnector.MySqlDataReader
      '
      DB.Initialize("localhost", "root", "p3lsk20xp", "pars")
      Result = DB.Exec("SELECT lagerort FROM rlagerort ORDER BY id")
      DBrdr = DB.NewReader()
      If DBrdr.HasRows Then
         While DBrdr.Read()
            LAGERORT.Items.Add(DBrdr.GetString(0))
         End While
         LAGERORT.Items.Add("(Neu)")
      End If
      LAGERORT.Text = LAGERORT.Items.Item(0)
      LAGERORT.Update()
      DBrdr.Close()
      DB.Close()
   End Sub

   ' Liest die Listeneinträge für den Optionsbutton SPRACHE
   ' Angehängt wird der Eintrag "(Neu)"
   Private Sub Init_Sprache()
      ' Ergebnis Boolean
      Dim Result As Boolean
      ' Neuen Datenbank-Handler starten ...
      Dim DB As New Database()
      ' DataReader etablieren
      Dim DBrdr As MySqlConnector.MySqlDataReader
      '
      DB.Initialize("localhost", "root", "p3lsk20xp", "pars")
      Result = DB.Exec("SELECT sprache FROM rsprache ORDER BY id")
      DBrdr = DB.NewReader()
      If DBrdr.HasRows Then
         While DBrdr.Read()
            SPRACHE.Items.Add(DBrdr.GetString(0))
         End While
         SPRACHE.Items.Add("(Neu)")
      End If
      SPRACHE.Text = SPRACHE.Items.Item(0)
      SPRACHE.Update()
      DBrdr.Close()
      DB.Close()
   End Sub

   ' Initialisiert die Felder EINBAND, KATEGORIE, LAGERORT, SPRACHE
   Private Sub InitialisiereFelder()
      ' Liest die Listeneinträge für den Optionsbutton EINBAND
      Init_Einband()
      ' Liest die Listeneinträge für den Optionsbutton KATEGORIE
      Init_Kategorie()
      ' Liest die Listeneinträge für den Optionsbutton LAGERORT
      Init_Lagerort()
      ' Liest die Listeneinträge für den Optionsbutton SPRACHE
      Init_Sprache()
      BUCH_ID = 0
      SIGNATUR.Text = Nothing
      AUTOREN.Text = Nothing
      HERAUSGEBER.Text = Nothing
      TITEL.Text = Nothing
      VERLAG.Text = Nothing
      ORT.Text = Nothing
      REIHE.Text = Nothing
      BAND.Text = Nothing
      JAHR.Text = Nothing
      MONAT.Text = Nothing
      ISBN.Text = Nothing
      BESTELLCODE.Text = Nothing
      PREIS.Text = Nothing
      WERT.Text = Nothing
      KLAPPENTEXT.Text = Nothing
      BILD_default()
   End Sub

   Private Sub LadeSignatur()
      Dim Result As Integer
      Dim URL As String
      Dim Reader As MySqlDataReader
      DB.Initialize("localhost", "root", "p3lsk20xp", "pars")
      DB.DbCmd.CommandText = "SELECT * FROM buch WHERE signatur = '" & SIGNATUR.Text & "'"
      Reader = DB.DbCmd.ExecuteReader
      Result = DB.ReadDataset(Reader)
      If Result > 0 Then
         Vorhanden = True
         REC.Id = Val(DB.GetField("id"))
         BUCH_ID = REC.Id
         SIGNATUR.Text = DB.GetField("signatur")
         AUTOREN.Text = DB.GetField("autor")
         HERAUSGEBER.Text = DB.GetField("herausgeber")
         TITEL.Text = DB.GetField("titel")
         VERLAG.Text = DB.GetField("verlag")
         ORT.Text = DB.GetField("ort")
         REIHE.Text = DB.GetField("reihe")
         BAND.Text = DB.GetField("band")
         JAHR.Text = DB.GetField("jahr")
         MONAT.Text = DB.GetField("monat")
         ISBN.Text = DB.GetField("isbn")
         BESTELLCODE.Text = DB.GetField("bestellcode")
         PREIS.Text = DB.GetField("preis")
         WERT.Text = DB.GetField("wert")
         EINBAND.Text = DB.GetField("einband")
         KATEGORIE.Text = DB.GetField("kategorie")
         SPRACHE.Text = DB.GetField("sprache")
         LAGERORT.Text = DB.GetField("lagerort")
         KLAPPENTEXT.Clear()
         KLAPPENTEXT.AppendText(DB.GetField("klappentext"))
         BILD.ImageLocation = DB.GetField("bildpath")
         URL = DB.GetField("bildurl")
         Lade_BILD_Path(URL)
      Else
         Vorhanden = False
      End If
      Me.Update()
      DB.Close()
   End Sub

   ' Das Formular FormNEWBOOK Laden und anzeigen (leer)
   Private Sub FormNEWBOOK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim LOG As New ClassLOG()
      LOG.LogEntry("FormNEWBOOK:FormNEWBOOK_Load", "Initialize", "ADM")
      ' Initialisiert die Felder EINBAND, KATEGORIE, LAGERORT, SPRACHE
      InitialisiereFelder()
   End Sub

   ' Das Default-Bild laden und anzeigen
   Private Sub BILD_default()
      BILD.ImageLocation = "Bilder/Default.jpg"
      Try
         BILD.Load()
      Catch ex As Exception
         BILD.ImageLocation = Environ("USERPROFILE") & "/Data/sig/Default.jpg"
         BILD.Load()
      End Try

      BILD.Update()
   End Sub

   Private Sub Lade_BILD_Path(Url As String)
      If FileIO.FileSystem.FileExists(Url) Then
         BILD.ImageLocation = Url
         BILD.Load()
         BILD.Update()
      Else
         Dim HomeDir, DefaultPath As String
         HomeDir = Environ("USERPROFILE") & "/Data/sig/" & SIGNATUR.Text & ".jpg"
         If FileIO.FileSystem.FileExists(HomeDir) Then
            BILD.ImageLocation = HomeDir
            BILD.Load()
            BILD.Update()
         Else
            DefaultPath = "D:/Source/VB/Biblio3/Bilder/Default.jpg"
            BILD.ImageLocation = DefaultPath
            BILD.Load()
            BILD.Update()
         End If
      End If
   End Sub

   Private Sub CHECK_Click(sender As Object, e As EventArgs) Handles CHECK.Click
      ' HIER MUSS WEITER GESCHRIEBEN WERDEN:
      If Not DB.Empty(SIGNATUR.Text) Then
         LadeSignatur()
      End If
   End Sub

   Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
      Me.Hide()
      DB.Close()
      FormMAIN.Activate()
      FormMAIN.Visible = True
      Me.Dispose()
   End Sub

   Public Function RecordSetValidate(ByRef Fehler As FehlerBUCH) As Boolean
      REC.Id = BUCH_ID
      REC.Signatur = SIGNATUR.Text
      REC.Autoren = AUTOREN.Text
      REC.Herausgeber = HERAUSGEBER.Text
      REC.Titel = TITEL.Text
      REC.Verlag = VERLAG.Text
      REC.Ort = ORT.Text
      REC.Reihe = REIHE.Text
      REC.Band = BAND.Text
      REC.Jahr = Val(JAHR.Text)
      REC.Monat = Val(MONAT.Text)
      REC.Isbn = ISBN.Text
      REC.Bestellcode = BESTELLCODE.Text
      REC.Preis = Val(PREIS.Text)
      REC.Wert = Val(WERT.Text)
      REC.Einband = EINBAND.Text
      REC.Kategorie = KATEGORIE.Text
      REC.Sprache = SPRACHE.Text
      REC.Lagerort = LAGERORT.Text
      REC.Anschaffung = DB.Date_String(ANSCHAFFUNG.Value)
      REC.Klappentext = KLAPPENTEXT.Text
      REC.BildPath = BILD.ImageLocation
      REC.BildURL = "https://localhost/biblio/sig/" & REC.Signatur & ".jpg"
      REC.sound_Verlag = DB.SOUNDEX(REC.Verlag)
      REC.Sound_Autor = DB.SOUNDEX(REC.Autoren)
      REC.Sound_Herausg = DB.SOUNDEX(REC.Herausgeber)
      REC.Sound_Titel = DB.SOUNDEX(REC.Titel)
      Fehler = BUCH.Validate(REC)
      If Fehler <> FehlerBUCH.Okay Then Return Fehler
      Fehler = FehlerBUCH.Okay
      Return True
   End Function

   Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
      Dim Result As Boolean
      Result = RecordSetValidate(FEHLER)
      If Not Result Then
         MsgBox("#1: " & BUCH.Fehler_ToString(FEHLER), MsgBoxStyle.Critical, Me.ToString())
         DB.Close()
         FormMAIN.Activate()
         FormMAIN.Visible = True
         Me.Dispose()
         Exit Sub
      End If
      If Vorhanden Then
         ' Hier wird ein Update durchgeführt
         BUCH.Update_Buch(REC)
      Else
         ' Hier wird ein Insert durchgeführt
         BUCH.Insert_Buch(REC)
      End If
      DB.Close()
      FormMAIN.Activate()
      FormMAIN.Visible = True
      Me.Dispose()
   End Sub
End Class