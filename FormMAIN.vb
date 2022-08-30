Imports System.Windows.Forms.VisualStyles
Imports Biblio3.ClassLOG

Public Class FormMAIN


   Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click
      FormNEWBOOK.Activate()
      FormNEWBOOK.Visible = True
      Me.Hide()
   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
      Me.Close()
   End Sub

   Private Sub FormMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim Log As New ClassLOG()
      Log.LogEntry("FormMAIN:Form_Main_Load", "Initialize", "ADM")
   End Sub

   Private Sub AnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnzeigenToolStripMenuItem.Click
      FormDISPBOOK.Activate()
      FormDISPBOOK.Visible = True
      Me.Hide()
   End Sub
End Class