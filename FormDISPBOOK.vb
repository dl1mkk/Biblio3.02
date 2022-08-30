Imports Biblio3.Database
Imports Biblio3.ClassBUCH
Imports Biblio3.FormMAIN
Imports Biblio3.ClassLOG
Imports System.Runtime.Intrinsics.X86
Imports MySqlConnector

Public Class FormDISPBOOK

   Dim DB As New Database()

   Private Sub Initialisieren()
      Dim LOG As New ClassLOG()
      Dim SQL As String
      Dim ResultB As Boolean
      Dim Result As Integer
      Dim NumRow As Integer = 1
      Dim Reader As MySqlDataReader
      '
      DB.Initialize("localhost", "root", "p3lsk20xp", "pars")
      SQL = "SELECT id, signatur, autor, herausgeber, titel, verlag, jahr, kategorie FROM buch ORDER BY signatur"
      ResultB = DB.Query(SQL)
      Reader = DB.DbCmd.ExecuteReader()
      NumRow = 0
      While ResultB
         Result = DB.ReadDataset(Reader)
         If Result > 0 Then
            GRID.Rows.Add()
            GRID.Rows.Insert(NumRow, DB.GetField("id"), DB.GetField("signatur"), DB.GetField("autor"), DB.GetField("herausgeber"),
                          DB.GetField("titel"), DB.GetField("verlag"), Val(DB.GetField("jahr")), DB.GetField("kategorie"))
            NumRow += 1
         End If
         If Result < 0 Then Exit While
         If NumRow > 100 Then Exit While
      End While
      Reader.Close()
   End Sub

   Private Sub FormDISPBOOK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim LOG As New ClassLOG()
      LOG.LogEntry("FormDISPBOOK", "Initialize", "ADM")
      Initialisieren()
   End Sub

   Private Sub OKAY_Click(sender As Object, e As EventArgs) Handles OKAY.Click
      Me.Hide()
      FormMAIN.Activate()
      FormMAIN.Visible = True
      Me.Dispose()
   End Sub
End Class