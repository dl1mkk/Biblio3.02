<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMAIN
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BücherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusikalienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZeitschriftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberBiblio3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOLDER = New System.Windows.Forms.FolderBrowserDialog()
        Me.OPENFILE = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BücherToolStripMenuItem, Me.MusikalienToolStripMenuItem, Me.ZeitschriftenToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.HilfeToolStripMenuItem, Me.ÜberBiblio3ToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(489, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BücherToolStripMenuItem
        '
        Me.BücherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.AnzeigenToolStripMenuItem, Me.AdministrationToolStripMenuItem1})
        Me.BücherToolStripMenuItem.Name = "BücherToolStripMenuItem"
        Me.BücherToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.BücherToolStripMenuItem.Text = "&Bücher"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NeuToolStripMenuItem.Text = "&Neu"
        '
        'AnzeigenToolStripMenuItem
        '
        Me.AnzeigenToolStripMenuItem.Name = "AnzeigenToolStripMenuItem"
        Me.AnzeigenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AnzeigenToolStripMenuItem.Text = "&Anzeigen"
        '
        'AdministrationToolStripMenuItem1
        '
        Me.AdministrationToolStripMenuItem1.Name = "AdministrationToolStripMenuItem1"
        Me.AdministrationToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AdministrationToolStripMenuItem1.Text = "Ad&ministration"
        '
        'MusikalienToolStripMenuItem
        '
        Me.MusikalienToolStripMenuItem.Name = "MusikalienToolStripMenuItem"
        Me.MusikalienToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.MusikalienToolStripMenuItem.Text = "&Musikalien"
        '
        'ZeitschriftenToolStripMenuItem
        '
        Me.ZeitschriftenToolStripMenuItem.Name = "ZeitschriftenToolStripMenuItem"
        Me.ZeitschriftenToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ZeitschriftenToolStripMenuItem.Text = "&Zeitschriften"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrationToolStripMenuItem.Text = "&Administration"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'ÜberBiblio3ToolStripMenuItem
        '
        Me.ÜberBiblio3ToolStripMenuItem.Name = "ÜberBiblio3ToolStripMenuItem"
        Me.ÜberBiblio3ToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ÜberBiblio3ToolStripMenuItem.Text = "Über Biblio3"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OPENFILE
        '
        Me.OPENFILE.FileName = "OpenFileDialog1"
        '
        'FormMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 137)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMAIN"
        Me.Text = "Biblio3 BIBLIOTHEKS-ADMINISTRATION"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public StandardFontStyle As String
   Friend WithEvents MenuStrip1 As MenuStrip
   Friend WithEvents BücherToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents AnzeigenToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents AdministrationToolStripMenuItem1 As ToolStripMenuItem
   Friend WithEvents MusikalienToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents ZeitschriftenToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents AdministrationToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents ÜberBiblio3ToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FOLDER As FolderBrowserDialog
    Friend WithEvents OPENFILE As OpenFileDialog
End Class
