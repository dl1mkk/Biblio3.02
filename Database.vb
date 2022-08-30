Imports System.Data.Common
Imports Biblio3.ClassBUCH
Imports MySqlConnector

Public Class Database

   ' Der Dateipfad, auf dem sich die Applikation befindet
   Public ApplicationPath As String

   ' Der Datenbank-Konnektor für die MySQL-Datenbank
   Public DbCon As New MySqlConnection()

   ' Der aktuelle DbCon.ConnectionString
   Public DbConnection As String

   ' Das aktuelle DbCmd als Datenbank-Kommando-Objekt
   Public DbCmd As New MySqlCommand()

   Public DbFieldNames(100) As String
   Public DbFieldTypes(100) As String
   Public DbFieldCount As Integer
   Public DbField(100) As String

   ' Ein Reader-Instanz herstellen
   Public Function NewReader() As MySqlDataReader
      Dim Reader As MySqlDataReader
      DbCmd.Connection = DbCon
      Reader = DbCmd.ExecuteReader()
      Return Reader
   End Function

   ' Prüft ob ein String Nothing oder "" ist
   Public Function Empty(ByVal S As String) As Boolean
      If S = Nothing Or S = "" Then Return True
      Return False
   End Function


   ' Erzeugt den aktuellen Timestamp als String
   Public Function CurrentTimestamp() As String
      Dim Datum As Date = Now.Date
      Return Format(Datum, "yyyy/MM/dd HH:mm:ss.fff")
   End Function

   Public Function Date_String(ByVal D As Date) As String
      Return Format(D, "yyyy/MM/dd")
   End Function

   Public Function Date_Time_String(ByVal D As Date) As String
      Return Format(D, "yyyy/MM/dd HH:mm:ss")
   End Function

   Private Function _ConnectionString(Hostname As String, User As String, Password As String, Database As String) As String
      Return "Server=" & Hostname & ";User Id=" & User & ";Password=" & Password & ";Database=" & Database
   End Function

   ' Initialisiert die Datenbank
   Public Sub Initialize(Hostname As String, User As String, Password As String, Database As String)
      ' Den Pfad der aktuellen Applikation ermitteln
      ApplicationPath = CurDir()
      DbCon.Close()
      DbCon.ConnectionString = _ConnectionString(Hostname, User, Password, Database)
      Try
         DbCon.Open()
      Catch ex As Exception
         MsgBox("Exception in " & DbCon.ToString() & ": kann Datenbank nicht öffnen.",
                MsgBoxStyle.Critical, ex.Message)
         DbCon.Close()
         Me.Finalize()
         Exit Sub
      End Try
      Try
         DbCmd.Connection = DbCon
      Catch ex As Exception
         MsgBox("Exception in " & DbCon.ToString() & ": kann Datenbank nicht öffnen.",
                MsgBoxStyle.Critical, ex.Message)
         DbCon.Close()
         Me.Finalize()
         Exit Sub
      End Try
   End Sub

   Public Sub New()
      DbCon.ConnectionString = _ConnectionString("localhost", "root", "p3lsk20xp", "pars")
      DbCon.Open()
      DbCmd.Connection = DbCon
   End Sub

   Public Sub Close()
      DbCon.Close()
      Me.Finalize()
   End Sub



   Public Function Exec(SQL As String) As Boolean
      Dim Result As Integer
      DbCmd.CommandText = SQL
      Try
         Result = DbCmd.ExecuteNonQuery()
      Catch ex As Exception
         MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Source)
         Return False
      End Try
      Return True
   End Function

   Public Function Query(SQL As String) As Boolean
      Try
         DbCmd.CommandText = SQL
      Catch ex As Exception
         MsgBox(ex.Message, MsgBoxStyle.Critical, Me.ToString())
         Return False
      End Try
      Return True
   End Function

   Public Function ReadDataset(ByRef R As MySqlDataReader) As Integer
      Dim Text As String
      Dim Result As Integer = -1
      Dim I As Integer
      If R.HasRows Then
         If R.Read() Then
            For I = 0 To 100
               DbField(I) = Nothing
               DbFieldNames(I) = Nothing
               DbFieldTypes(I) = Nothing
            Next
            Result = 0
            DbFieldCount = R.VisibleFieldCount
            For I = 0 To R.VisibleFieldCount - 1
               Result += 1
               Text = R.GetDataTypeName(I)
               If Text = "INT" Then
                  Dim Value As Integer
                  Value = R.GetInt32(I)
                  DbField(I) = Trim(Str(Value))
                  DbFieldNames(I) = R.GetName(I)
                  DbFieldTypes(I) = Text
                  GoTo ReDo1
               End If
               If Text = "VARCHAR" Then
                  Dim Value As String
                  Try
                     Value = R.GetString(I)
                  Catch ex As Exception
                     Value = ""
                  End Try
                  DbField(I) = Value
                  DbFieldNames(I) = R.GetName(I)
                  DbFieldTypes(I) = Text
                  GoTo ReDo1
               End If
               If Text = "DECIMAL" Then
                  Dim Value As Decimal
                  Value = R.GetDecimal(I)
                  DbField(I) = Trim(Str(Value))
                  DbFieldNames(I) = R.GetName(I)
                  DbFieldTypes(I) = Text
                  GoTo ReDo1
               End If
               If Text = "DATE" Then
                  Dim Value As Date
                  Value = R.GetDateTime(I)
                  DbField(I) = Format(Value, "yyyy/MM/dd HH:mm:ss")
                  DbFieldNames(I) = R.GetName(I)
                  DbFieldTypes(I) = Text
                  GoTo ReDo1
               End If
               If Text = "TEXT" Then
                  Dim Value As String
                  Try
                     Value = R.GetString(I)
                  Catch ex As Exception
                     Value = "(unread)"
                  End Try
                  DbField(I) = Value
                  DbFieldNames(I) = R.GetName(I)
                  DbFieldTypes(I) = Text
                  GoTo ReDo1
               Else
                  Stop
               End If
ReDo1:
            Next
         End If
      End If
      Return Result
   End Function

   Public Function GetIndex(Name As String) As Integer
      Dim result As Integer = -1
      Dim i As Integer
      For i = 0 To DbFieldCount - 1
         If DbFieldNames(i) = Name Then
            Return i
         End If
      Next
      Return result
   End Function

   Public Function GetField(Name As String) As String
      Dim I As Integer
      I = GetIndex(Name)
      If I > -1 Then
         Return DbField(I)
      Else
         Return Nothing
      End If
   End Function

   Public Function SOUNDEX(Text As String) As String
      Dim Result As String
      Result = UCase(Mid(Text, 1, 1))
      For I = 2 To Text.Length
         Select Case UCase(Mid(Text, I, 1))
            Case "B"
            Case "F"
            Case "P"
            Case "V"
               Result &= "1"
            Case "C"
            Case "G"
            Case "J"
            Case "K"
            Case "Q"
            Case "S"
            Case "X"
            Case "Z"
               Result &= "2"
            Case "D"
            Case "T"
               Result &= "3"
            Case "L"
               Result &= "4"
            Case "M"
            Case "N"
               Result &= "5"
            Case "R"
               Result &= "6"
         End Select
         If Result.Length > 6 Then Return Result
      Next
      Return Result
   End Function

   Protected Overrides Sub Finalize()
      MyBase.Finalize()
   End Sub

End Class
