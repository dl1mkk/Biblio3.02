<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDISPBOOK
   Inherits System.Windows.Forms.Form

   'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

   'Wird vom Windows Form-Designer benötigt.
   Private components As System.ComponentModel.IContainer

   'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
   'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
   'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FILTER = New System.Windows.Forms.TextBox()
        Me.SUCHEN = New System.Windows.Forms.Button()
        Me.OKAY = New System.Windows.Forms.Button()
        Me.GRID = New System.Windows.Forms.DataGridView()
        Me.Auswahl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Signatur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autoren = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Herausgeber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Titel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Verlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jahr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kategorie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter :"
        '
        'FILTER
        '
        Me.FILTER.Location = New System.Drawing.Point(73, 12)
        Me.FILTER.Name = "FILTER"
        Me.FILTER.Size = New System.Drawing.Size(389, 29)
        Me.FILTER.TabIndex = 1
        '
        'SUCHEN
        '
        Me.SUCHEN.Location = New System.Drawing.Point(481, 9)
        Me.SUCHEN.Name = "SUCHEN"
        Me.SUCHEN.Size = New System.Drawing.Size(80, 33)
        Me.SUCHEN.TabIndex = 2
        Me.SUCHEN.Text = "Suchen"
        Me.SUCHEN.UseVisualStyleBackColor = True
        '
        'OKAY
        '
        Me.OKAY.Location = New System.Drawing.Point(1389, 781)
        Me.OKAY.Name = "OKAY"
        Me.OKAY.Size = New System.Drawing.Size(80, 33)
        Me.OKAY.TabIndex = 3
        Me.OKAY.Text = "Okay"
        Me.OKAY.UseVisualStyleBackColor = True
        '
        'GRID
        '
        Me.GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auswahl, Me.Signatur, Me.Autoren, Me.Herausgeber, Me.Titel, Me.Verlag, Me.Jahr, Me.Kategorie})
        Me.GRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID.Location = New System.Drawing.Point(15, 47)
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowTemplate.Height = 25
        Me.GRID.Size = New System.Drawing.Size(1454, 728)
        Me.GRID.TabIndex = 4
        '
        'Auswahl
        '
        Me.Auswahl.HeaderText = "Auswahl"
        Me.Auswahl.Name = "Auswahl"
        Me.Auswahl.ReadOnly = True
        Me.Auswahl.Width = 94
        '
        'Signatur
        '
        Me.Signatur.HeaderText = "Signatur"
        Me.Signatur.Name = "Signatur"
        Me.Signatur.ReadOnly = True
        Me.Signatur.Width = 94
        '
        'Autoren
        '
        Me.Autoren.HeaderText = "Autoren"
        Me.Autoren.Name = "Autoren"
        Me.Autoren.ReadOnly = True
        Me.Autoren.Width = 91
        '
        'Herausgeber
        '
        Me.Herausgeber.HeaderText = "Herausgeber"
        Me.Herausgeber.Name = "Herausgeber"
        Me.Herausgeber.ReadOnly = True
        Me.Herausgeber.Width = 124
        '
        'Titel
        '
        Me.Titel.HeaderText = "Titel"
        Me.Titel.Name = "Titel"
        Me.Titel.ReadOnly = True
        Me.Titel.Width = 64
        '
        'Verlag
        '
        Me.Verlag.HeaderText = "Verlag"
        Me.Verlag.Name = "Verlag"
        Me.Verlag.ReadOnly = True
        Me.Verlag.Width = 79
        '
        'Jahr
        '
        Me.Jahr.HeaderText = "Jahr"
        Me.Jahr.Name = "Jahr"
        Me.Jahr.ReadOnly = True
        Me.Jahr.Width = 64
        '
        'Kategorie
        '
        Me.Kategorie.HeaderText = "Kategorie"
        Me.Kategorie.Name = "Kategorie"
        Me.Kategorie.ReadOnly = True
        Me.Kategorie.Width = 101
        '
        'FormDISPBOOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1481, 826)
        Me.Controls.Add(Me.GRID)
        Me.Controls.Add(Me.OKAY)
        Me.Controls.Add(Me.SUCHEN)
        Me.Controls.Add(Me.FILTER)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormDISPBOOK"
        Me.Text = "Biblio - BÜCHER ANZEIGEN"
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FILTER As TextBox
    Friend WithEvents SUCHEN As Button
    Friend WithEvents OKAY As Button
    Friend WithEvents GRID As DataGridView
    Friend WithEvents Auswahl As DataGridViewTextBoxColumn
    Friend WithEvents Signatur As DataGridViewTextBoxColumn
    Friend WithEvents Autoren As DataGridViewTextBoxColumn
    Friend WithEvents Herausgeber As DataGridViewTextBoxColumn
    Friend WithEvents Titel As DataGridViewTextBoxColumn
    Friend WithEvents Verlag As DataGridViewTextBoxColumn
    Friend WithEvents Jahr As DataGridViewTextBoxColumn
    Friend WithEvents Kategorie As DataGridViewTextBoxColumn
End Class
