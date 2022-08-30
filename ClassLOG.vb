Imports Biblio3.Database
Imports Biblio3.FormMAIN

Public Class ClassLOG
   Dim DB As New Database()
   Dim Logtime As Date
   Dim Session As String
   Dim User As String = "admin"
   Dim Mode As String = "ADM"
   Dim App As String
   Dim Msg As String

   Public Sub New()
      DB.Initialize("localhost", "root", "p3lsk20xp", "pars")
   End Sub

   Public Sub Close()
      DB.Close()
   End Sub

   Public Sub LogEntry(Apps As String, Mesg As String, AMode As String)
      Dim SQL As String
      Dim Result As Integer
      Logtime = Now
      Session = Me.GetHashCode
      App = Apps
      Msg = Mesg
      Mode = AMode
      SQL = "INSERT INTO log SET uname='" & User & "',modus='" & Mode & "',session='" & Session &
            "',url='" & App & "',msg='" & Msg & "'"
      DB.DbCmd.CommandText = SQL
      Try
         Result = DB.DbCmd.ExecuteNonQuery()
      Catch ex As Exception
         MsgBox(ex.Message, MsgBoxStyle.Critical, "Biblio3.ClassLog")
         Close()
         Biblio3.FormMAIN.Close()
      End Try

   End Sub


End Class
