Imports System.Security.Cryptography.Xml
Imports Biblio3.Database
Imports MySqlConnector

Public Class ClassBUCH
   Dim DB As New Database()
   Dim DATA As RecordBUCH
   Dim ID As Integer

   Public Structure RecordBUCH
      Public Id As Integer                ' Integer max 11 Stellen      #0
      Public Signatur As String           ' String mit max. 20 Zeichen  #1
      Public Autoren As String            ' String mit max. 80 Zeichen  #2
      Public Herausgeber As String        ' String mit max. 80 Zeichen  #3
      Public Titel As String              ' string mit max. 128 Zeichen #4
      Public Kategorie As String          ' string mit max. 30 Zeichen  #5
      Public Reihe As String              ' String mit max. 80 Zeichen  #6
      Public Band As String               ' String mit max. 5 Zeichen   #7
      Public Jahr As Integer              ' Integer                     #8
      Public Monat As Integer             ' Integer                     #9
      Public Verlag As String             ' String mit max. 80 Zeichen  #10
      Public Ort As String                ' String mit max. 80 Zeichen  #11
      Public Lagerort As String           ' String mit 20 Zeichen       #12
      Public Bestellcode As String        ' String mit 22 zeichen       #13
      Public Isbn As String               ' String mit 25 zeichen       #14
      Public Klappentext As String        ' Text mit max 16000 zeichen  #15
      Public Anschaffung As Date          ' Nur Datum                   #16
      Public Preis As Decimal             ' Decimal(10,2)               #17
      Public Wert As Decimal              ' Decimal(10,2)               #18
      Public Sprache As String            ' String mit 3 Zeichen        #19
      Public Einband As String            ' string mit 30 Zeichen       #20
      Public BildURL As String            ' string mit 128 Zeichen      #21
      Public BildPath As String           ' string mit 128 zeichen      #22
      Public Sound_Titel As String        ' string mit 25 Zeichen       #23
      Public Sound_Autor As String        ' string mit 25 zeichen       #24
      Public Sound_Herausg As String      ' string mit 25 zeichen       #25
      Public sound_Verlag As String       ' string mit 25 zeichen       #26
   End Structure

   Public Enum FehlerBUCH
      Okay = 0
      Signatur_Fehlt = 1
      Autor_Editor_Konflikt = 2
      Titel_Fehlt = 3
      Jahr_Fehlt = 4
      Verlag_Fehlt = 5
      Klappentext_Fehlt = 6
      Datum_Anschaffung_Fehlt = 7
      Preis_Fehlt = 8
      Wert_Fehlt = 9
      Kategorie_Fehlt = 10
      Lagerort_Fehlt = 11
      Sprache_Fehlt = 12
      Einband_Fehlt = 13
      Reihe_Fehlt = 14
      Kein_Datensatz = 15
   End Enum

   Public Function Fehler_ToString(ByVal Fehler As FehlerBUCH) As String
      Select Case Fehler
         Case FehlerBUCH.Okay
            Return "FehlerBUCH.Okay"
         Case FehlerBUCH.Signatur_Fehlt
            Return "FehlerBUCH.Signatur_Fehlt"
         Case FehlerBUCH.Titel_Fehlt
            Return "FehlerBUCH.Titel_Fehlt"
         Case FehlerBUCH.Jahr_Fehlt
            Return "FehlerBUCH.Jahr_Fehlt"
         Case FehlerBUCH.Verlag_Fehlt
            Return "FehlerBUCH.Verlag_Fehlt"
         Case FehlerBUCH.Klappentext_Fehlt
            Return "FehlerBUCH.Klappentext_Fehlt"
         Case FehlerBUCH.Autor_Editor_Konflikt
            Return "Fehlerbuch.Autor_Editor_Konflikt"
         Case FehlerBUCH.Datum_Anschaffung_Fehlt
            Return "FehlerBUCH.Datum_Anschaffung_Fehlt"
         Case FehlerBUCH.Einband_Fehlt
            Return "FehlerBUCH.Einband_Fehlt"
         Case FehlerBUCH.Preis_Fehlt
            Return "Fehlerbuch.Preis_Fehlt"
         Case FehlerBUCH.Wert_Fehlt
            Return "FehlerBUCH.Wert_Fehlt"
         Case FehlerBUCH.Kategorie_Fehlt
            Return "FehlerBUCH.Kategorie_Fehlt"
         Case FehlerBUCH.Lagerort_Fehlt
            Return "FehlerBUCH.Lagerort_Fehlt"
         Case FehlerBUCH.Sprache_Fehlt
            Return "FehlerBUCH.Sprache_Fehlt"
         Case FehlerBUCH.Einband_Fehlt
            Return "FehlerBUCH.Einband_Fehlt"
         Case FehlerBUCH.Reihe_Fehlt
            Return "FehlerBUCH.Reihe_Fehlt"
         Case FehlerBUCH.Kein_Datensatz
            Return "FehlerBUCH.Kein_Datensatz"
         Case Else
            Return "FehlerBUCH.UNBEKANNT"
      End Select
   End Function

   Public Function Validate(Rec As RecordBUCH) As FehlerBUCH
      If Empty(Rec.Signatur) Then Return FehlerBUCH.Signatur_Fehlt
      If Empty(Rec.Autoren) And Empty(Rec.Herausgeber) Then Return FehlerBUCH.Autor_Editor_Konflikt
      If Empty(Rec.Titel) Then Return FehlerBUCH.Titel_Fehlt
      If Empty(Rec.Jahr) Then Return FehlerBUCH.Jahr_Fehlt
      If Empty(Rec.Verlag) Then Return FehlerBUCH.Verlag_Fehlt
      If Empty(Rec.Klappentext) Then Return FehlerBUCH.Klappentext_Fehlt
      If Empty(Rec.Preis) Then Return FehlerBUCH.Preis_Fehlt
      If Empty(Rec.Wert) Then Return FehlerBUCH.Wert_Fehlt
      If Empty(Rec.Kategorie) Then Return FehlerBUCH.Kategorie_Fehlt
      If Empty(Rec.Lagerort) Then Return FehlerBUCH.Lagerort_Fehlt
      If Empty(Rec.Sprache) Then Return FehlerBUCH.Sprache_Fehlt
      If Empty(Rec.Einband) Then Return FehlerBUCH.Einband_Fehlt
      If Empty(Rec.Reihe) Then Return FehlerBUCH.Reihe_Fehlt
      Return FehlerBUCH.Okay
   End Function


   Public Sub New()
      Dim LOG As New ClassLOG()
      LOG.LogEntry("ClassBUCH:New", "Initilize", "ADM")
      DB.Initialize("localhost", "root", "p3lsk20xp", "pars")
   End Sub

   Function GetField(Name As String) As String
      Return DB.GetField(Name)
   End Function

   Function Empty(S As String) As Boolean
      If S = Nothing Or S = "" Then Return True
      Return False
   End Function

   Function NewReader() As MySqlDataReader
      Return DB.NewReader()
   End Function

   Function ReadDataset(ByRef Reader As MySqlDataReader, ByRef Data As RecordBUCH) As FehlerBUCH
      Dim LOG As New ClassLOG()
      Dim Fehler As FehlerBUCH = FehlerBUCH.Okay
      Dim Result As Integer
      LOG.LogEntry("ClassBUCH:ReadDataset", DB.DbCmd.CommandText, "ADM")
      Result = DB.ReadDataset(Reader)
      If Result < 1 Then Return FehlerBUCH.Kein_Datensatz
      Data.Id = Val(GetField("id"))
      Data.Signatur = GetField("signatur")
      Data.Autoren = GetField("autor")
      Data.Herausgeber = GetField("herausgeber")
      Data.Titel = GetField("titel")
      Data.Kategorie = GetField("kategorie")
      Data.Reihe = GetField("reihe")
      Data.Band = GetField("band")
      Data.Verlag = GetField("verlag")
      Data.Ort = GetField("ort")
      Data.Isbn = GetField("isbn")
      Data.Bestellcode = GetField("bestellcode")
      Data.Klappentext = GetField("klappentext")
      Data.Sprache = GetField("sprache")
      Data.Einband = GetField("einband")
      Data.Lagerort = GetField("lagerort")
      Data.sound_Verlag = GetField("sound_verlag")
      Data.Sound_Autor = GetField("sound_autor")
      Data.Sound_Herausg = GetField("sound_herausg")
      Data.Sound_Titel = GetField("sound_titel")
      Data.Jahr = Val(GetField("jahr"))
      Data.Monat = Val(GetField("monat"))
      Data.Preis = Val(GetField("preis"))
      Data.Wert = Val(GetField("wert"))
      Data.Anschaffung = CDate(GetField("anschaffung"))
      Data.sound_Verlag = DB.SOUNDEX(Data.Verlag)
      Data.Sound_Autor = DB.SOUNDEX(Data.Autoren)
      Data.Sound_Herausg = DB.SOUNDEX(Data.Herausgeber)
      Data.Sound_Titel = DB.SOUNDEX(Data.Titel)
      Return Fehler
   End Function

   Public Sub Update_Buch(ByVal REC As RecordBUCH)
      Dim LOG As New ClassLOG()
      Dim SQL As String
      Dim Result As Integer
      SQL = "UPDATE buch SET signatur='" & REC.Signatur & "',autor='" & REC.Autoren &
            "',herausgeber='" & REC.Herausgeber & "',titel='" & REC.Titel &
            "',verlag='" & REC.Verlag & "',ort='" & REC.Ort & "',reihe='" &
            REC.Reihe & "',jahr='" & Str(REC.Jahr) & "',monat='" & Str(REC.Monat) &
            "',preis='" & Str(REC.Preis) & "',wert='" & Str(REC.Wert) &
            "',band='" & REC.Band & "',einband='" & REC.Einband & "',kategorie='" &
            REC.Kategorie & "',sprache='" & REC.Sprache & "',lagerort='" &
            REC.Lagerort & "',klappentext='" & REC.Klappentext & "',bildurl='" &
            REC.BildURL & "',anschaffung='" & DB.Date_String(REC.Anschaffung) &
            "',bildpath='" & REC.BildPath & "' WHERE id = '" & REC.Id & "'"
      DB.DbCmd.CommandText = SQL
      LOG.LogEntry("ClassBUCH:Update_Buch", "UPDATE Signatur " & REC.Signatur, "ADM")
      Try
         Result = DB.DbCmd.ExecuteNonQuery()
      Catch ex As Exception
         MsgBox("#3update: " & ex.Message, MsgBoxStyle.Critical, Me.ToString())
      End Try
   End Sub

   Public Sub Insert_Buch(ByVal REC As RecordBUCH)
      Dim LOG As New ClassLOG
      Dim SQL As String
      Dim Result As Integer
      SQL = "INSERT INTO buch SET signatur='" & REC.Signatur & "',autor='" & REC.Autoren &
            "',herausgeber='" & REC.Herausgeber & "',titel='" & REC.Titel &
            "',verlag='" & REC.Verlag & "',ort='" & REC.Ort & "',reihe='" &
            REC.Reihe & "',jahr='" & Str(REC.Jahr) & "',monat='" & Str(REC.Monat) &
            "',preis='" & Str(REC.Preis) & "',wert='" & Str(REC.Wert) &
            "',band='" & REC.Band & "',einband='" & REC.Einband & "',kategorie='" &
            REC.Kategorie & "',sprache='" & REC.Sprache & "',lagerort='" &
            REC.Lagerort & "',klappentext='" & REC.Klappentext & "',bildurl='" &
            REC.BildURL & "',anschaffung='" & DB.Date_String(REC.Anschaffung) &
            "',bildpath='" & REC.BildPath & "'"
      DB.DbCmd.CommandText = SQL
      LOG.LogEntry("ClassBUCH:Insert_Buch", "INSERT Signatur " & REC.Signatur, "ADM")
      Try
         Result = DB.DbCmd.ExecuteNonQuery()
      Catch ex As Exception
         MsgBox("#2insert: " & ex.Message, MsgBoxStyle.Critical, Me.ToString())
      End Try
   End Sub

End Class
