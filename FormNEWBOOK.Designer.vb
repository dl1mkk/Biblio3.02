<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNEWBOOK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNEWBOOK))
        Me.SIGNATUR = New System.Windows.Forms.TextBox()
        Me.AUTOREN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CHECK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HERAUSGEBER = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TITEL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VERLAG = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BAND = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.JAHR = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MONAT = New System.Windows.Forms.TextBox()
        Me.ORT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ISBN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BESTELLCODE = New System.Windows.Forms.TextBox()
        Me.KATEGORIE = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label_9999 = New System.Windows.Forms.Label()
        Me.SPRACHE = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.EINBAND = New System.Windows.Forms.ComboBox()
        Me.KLAPPENTEXT = New System.Windows.Forms.TextBox()
        Me.LOADPIC = New System.Windows.Forms.Button()
        Me.CANCEL = New System.Windows.Forms.Button()
        Me.SAVE = New System.Windows.Forms.Button()
        Me.BILD = New System.Windows.Forms.PictureBox()
        Me.PREIS = New System.Windows.Forms.TextBox()
        Me.WERT = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LAGERORT = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ANSCHAFFUNG = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.REIHE = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.BILD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SIGNATUR
        '
        Me.SIGNATUR.AcceptsReturn = True
        Me.SIGNATUR.AcceptsTab = True
        Me.SIGNATUR.Location = New System.Drawing.Point(172, 12)
        Me.SIGNATUR.MaxLength = 20
        Me.SIGNATUR.Name = "SIGNATUR"
        Me.SIGNATUR.PlaceholderText = "Neue Signatur verwenden"
        Me.SIGNATUR.Size = New System.Drawing.Size(200, 29)
        Me.SIGNATUR.TabIndex = 1
        '
        'AUTOREN
        '
        Me.AUTOREN.Location = New System.Drawing.Point(172, 47)
        Me.AUTOREN.MaxLength = 80
        Me.AUTOREN.Name = "AUTOREN"
        Me.AUTOREN.PlaceholderText = "(entweder Autor'innen oder Herausgeber'innen)"
        Me.AUTOREN.Size = New System.Drawing.Size(845, 29)
        Me.AUTOREN.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Signatur :"
        '
        'CHECK
        '
        Me.CHECK.Location = New System.Drawing.Point(389, 9)
        Me.CHECK.Name = "CHECK"
        Me.CHECK.Size = New System.Drawing.Size(99, 33)
        Me.CHECK.TabIndex = 2
        Me.CHECK.Text = "Prüfen"
        Me.CHECK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Autor'innen :"
        '
        'HERAUSGEBER
        '
        Me.HERAUSGEBER.Location = New System.Drawing.Point(172, 82)
        Me.HERAUSGEBER.MaxLength = 80
        Me.HERAUSGEBER.Name = "HERAUSGEBER"
        Me.HERAUSGEBER.PlaceholderText = "(entweder Autor'innen oder Herausgeber'innen)"
        Me.HERAUSGEBER.Size = New System.Drawing.Size(845, 29)
        Me.HERAUSGEBER.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Herausgeber'innen :"
        '
        'TITEL
        '
        Me.TITEL.Location = New System.Drawing.Point(172, 117)
        Me.TITEL.MaxLength = 128
        Me.TITEL.Name = "TITEL"
        Me.TITEL.PlaceholderText = "(Buchtitel wie innen)"
        Me.TITEL.Size = New System.Drawing.Size(845, 29)
        Me.TITEL.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Titel :"
        '
        'VERLAG
        '
        Me.VERLAG.Location = New System.Drawing.Point(172, 152)
        Me.VERLAG.MaxLength = 80
        Me.VERLAG.Name = "VERLAG"
        Me.VERLAG.PlaceholderText = "(Verlag wie im Buchtitel innen)"
        Me.VERLAG.Size = New System.Drawing.Size(845, 29)
        Me.VERLAG.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Verlag :"
        '
        'BAND
        '
        Me.BAND.Location = New System.Drawing.Point(172, 270)
        Me.BAND.MaxLength = 5
        Me.BAND.Name = "BAND"
        Me.BAND.Size = New System.Drawing.Size(60, 29)
        Me.BAND.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(172, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "*) wenn mehrbändig! Sonst leer..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(238, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "*)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Band :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(260, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Jahr:"
        '
        'JAHR
        '
        Me.JAHR.Location = New System.Drawing.Point(308, 270)
        Me.JAHR.MaxLength = 4
        Me.JAHR.Name = "JAHR"
        Me.JAHR.Size = New System.Drawing.Size(60, 29)
        Me.JAHR.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(374, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Monat :"
        '
        'MONAT
        '
        Me.MONAT.Location = New System.Drawing.Point(442, 270)
        Me.MONAT.MaxLength = 2
        Me.MONAT.Name = "MONAT"
        Me.MONAT.Size = New System.Drawing.Size(42, 29)
        Me.MONAT.TabIndex = 11
        '
        'ORT
        '
        Me.ORT.Location = New System.Drawing.Point(172, 187)
        Me.ORT.MaxLength = 80
        Me.ORT.Name = "ORT"
        Me.ORT.PlaceholderText = "(Verlag wie im Buchtitel innen)"
        Me.ORT.Size = New System.Drawing.Size(845, 29)
        Me.ORT.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(126, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 21)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Ort :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(84, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 21)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Kaufpreis :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(286, 308)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 21)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Verkaufswert :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(490, 273)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 21)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "ISBN :"
        '
        'ISBN
        '
        Me.ISBN.Location = New System.Drawing.Point(547, 270)
        Me.ISBN.MaxLength = 25
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(140, 29)
        Me.ISBN.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(693, 273)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 21)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Bestellcode :"
        '
        'BESTELLCODE
        '
        Me.BESTELLCODE.Location = New System.Drawing.Point(794, 270)
        Me.BESTELLCODE.MaxLength = 22
        Me.BESTELLCODE.Name = "BESTELLCODE"
        Me.BESTELLCODE.Size = New System.Drawing.Size(140, 29)
        Me.BESTELLCODE.TabIndex = 13
        '
        'KATEGORIE
        '
        Me.KATEGORIE.FormattingEnabled = True
        Me.KATEGORIE.Location = New System.Drawing.Point(172, 340)
        Me.KATEGORIE.Name = "KATEGORIE"
        Me.KATEGORIE.Size = New System.Drawing.Size(213, 29)
        Me.KATEGORIE.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(83, 343)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 21)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Kategorie :"
        '
        'Label_9999
        '
        Me.Label_9999.AutoSize = True
        Me.Label_9999.Location = New System.Drawing.Point(389, 343)
        Me.Label_9999.Name = "Label_9999"
        Me.Label_9999.Size = New System.Drawing.Size(73, 21)
        Me.Label_9999.TabIndex = 29
        Me.Label_9999.Text = "Sprache :"
        '
        'SPRACHE
        '
        Me.SPRACHE.FormattingEnabled = True
        Me.SPRACHE.Location = New System.Drawing.Point(466, 340)
        Me.SPRACHE.Name = "SPRACHE"
        Me.SPRACHE.Size = New System.Drawing.Size(75, 29)
        Me.SPRACHE.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(514, 308)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 21)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Einband :"
        '
        'EINBAND
        '
        Me.EINBAND.FormattingEnabled = True
        Me.EINBAND.Location = New System.Drawing.Point(593, 305)
        Me.EINBAND.Name = "EINBAND"
        Me.EINBAND.Size = New System.Drawing.Size(213, 29)
        Me.EINBAND.TabIndex = 16
        '
        'KLAPPENTEXT
        '
        Me.KLAPPENTEXT.Location = New System.Drawing.Point(172, 431)
        Me.KLAPPENTEXT.MaxLength = 16000
        Me.KLAPPENTEXT.Multiline = True
        Me.KLAPPENTEXT.Name = "KLAPPENTEXT"
        Me.KLAPPENTEXT.PlaceholderText = "(darf nicht leer sein!)"
        Me.KLAPPENTEXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KLAPPENTEXT.Size = New System.Drawing.Size(845, 217)
        Me.KLAPPENTEXT.TabIndex = 19
        '
        'LOADPIC
        '
        Me.LOADPIC.Location = New System.Drawing.Point(38, 654)
        Me.LOADPIC.Name = "LOADPIC"
        Me.LOADPIC.Size = New System.Drawing.Size(91, 52)
        Me.LOADPIC.TabIndex = 21
        Me.LOADPIC.Text = "Bild Laden"
        Me.LOADPIC.UseVisualStyleBackColor = True
        '
        'CANCEL
        '
        Me.CANCEL.Location = New System.Drawing.Point(748, 654)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(99, 33)
        Me.CANCEL.TabIndex = 22
        Me.CANCEL.Text = "Abbruch"
        Me.CANCEL.UseVisualStyleBackColor = True
        '
        'SAVE
        '
        Me.SAVE.Location = New System.Drawing.Point(918, 654)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(99, 33)
        Me.SAVE.TabIndex = 23
        Me.SAVE.Text = "Speichern"
        Me.SAVE.UseVisualStyleBackColor = True
        '
        'BILD
        '
        Me.BILD.Image = CType(resources.GetObject("BILD.Image"), System.Drawing.Image)
        Me.BILD.Location = New System.Drawing.Point(10, 431)
        Me.BILD.Name = "BILD"
        Me.BILD.Size = New System.Drawing.Size(149, 217)
        Me.BILD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BILD.TabIndex = 37
        Me.BILD.TabStop = False
        '
        'PREIS
        '
        Me.PREIS.Location = New System.Drawing.Point(172, 305)
        Me.PREIS.MaxLength = 10
        Me.PREIS.Name = "PREIS"
        Me.PREIS.Size = New System.Drawing.Size(108, 29)
        Me.PREIS.TabIndex = 14
        Me.PREIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'WERT
        '
        Me.WERT.Location = New System.Drawing.Point(400, 305)
        Me.WERT.MaxLength = 10
        Me.WERT.Name = "WERT"
        Me.WERT.Size = New System.Drawing.Size(108, 29)
        Me.WERT.TabIndex = 15
        Me.WERT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(83, 387)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 21)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Lagerort :"
        '
        'LAGERORT
        '
        Me.LAGERORT.FormattingEnabled = True
        Me.LAGERORT.Location = New System.Drawing.Point(172, 375)
        Me.LAGERORT.Name = "LAGERORT"
        Me.LAGERORT.Size = New System.Drawing.Size(213, 29)
        Me.LAGERORT.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(391, 378)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 21)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Kaufdatum :"
        '
        'ANSCHAFFUNG
        '
        Me.ANSCHAFFUNG.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ANSCHAFFUNG.Location = New System.Drawing.Point(490, 375)
        Me.ANSCHAFFUNG.Name = "ANSCHAFFUNG"
        Me.ANSCHAFFUNG.Size = New System.Drawing.Size(113, 29)
        Me.ANSCHAFFUNG.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(172, 407)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 21)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Klappentext :"
        '
        'REIHE
        '
        Me.REIHE.Location = New System.Drawing.Point(172, 222)
        Me.REIHE.MaxLength = 80
        Me.REIHE.Name = "REIHE"
        Me.REIHE.PlaceholderText = "(Verlag wie im Buchtitel innen)"
        Me.REIHE.Size = New System.Drawing.Size(845, 29)
        Me.REIHE.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(110, 222)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 21)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Reihe :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "D:/Source/VB/Bilblio/Bilder/Default.jpg"
        '
        'FormNEWBOOK
        '
        Me.AcceptButton = Me.CHECK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CANCEL
        Me.ClientSize = New System.Drawing.Size(1029, 714)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.REIHE)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.ANSCHAFFUNG)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LAGERORT)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.WERT)
        Me.Controls.Add(Me.PREIS)
        Me.Controls.Add(Me.BILD)
        Me.Controls.Add(Me.SAVE)
        Me.Controls.Add(Me.CANCEL)
        Me.Controls.Add(Me.LOADPIC)
        Me.Controls.Add(Me.KLAPPENTEXT)
        Me.Controls.Add(Me.EINBAND)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.SPRACHE)
        Me.Controls.Add(Me.Label_9999)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.KATEGORIE)
        Me.Controls.Add(Me.BESTELLCODE)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ISBN)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ORT)
        Me.Controls.Add(Me.MONAT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.JAHR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BAND)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.VERLAG)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TITEL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HERAUSGEBER)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CHECK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AUTOREN)
        Me.Controls.Add(Me.SIGNATUR)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormNEWBOOK"
        Me.Text = "Biblio3 - NEUEN BUCHTITEL ERFASSEN"
        CType(Me.BILD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SIGNATUR As TextBox
   Friend WithEvents AUTOREN As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents CHECK As Button
   Friend WithEvents Label2 As Label
   Friend WithEvents HERAUSGEBER As TextBox
   Friend WithEvents Label3 As Label
   Friend WithEvents TITEL As TextBox
   Friend WithEvents Label4 As Label
   Friend WithEvents VERLAG As TextBox
   Friend WithEvents Label5 As Label
   Friend WithEvents BAND As TextBox
   Friend WithEvents Label6 As Label
   Friend WithEvents Label7 As Label
   Friend WithEvents Label8 As Label
   Friend WithEvents Label9 As Label
   Friend WithEvents JAHR As TextBox
   Friend WithEvents Label10 As Label
   Friend WithEvents MONAT As TextBox
   Friend WithEvents ORT As TextBox
   Friend WithEvents Label11 As Label
   Friend WithEvents Label12 As Label
   Friend WithEvents Label13 As Label
   Friend WithEvents Label14 As Label
   Friend WithEvents ISBN As TextBox
   Friend WithEvents Label15 As Label
   Friend WithEvents BESTELLCODE As TextBox
   Friend WithEvents KATEGORIE As ComboBox
   Friend WithEvents Label16 As Label
   Friend WithEvents Label_9999 As Label
   Friend WithEvents SPRACHE As ComboBox
   Friend WithEvents Label17 As Label
   Friend WithEvents EINBAND As ComboBox
   Friend WithEvents KLAPPENTEXT As TextBox
   Friend WithEvents LOADPIC As Button
   Friend WithEvents CANCEL As Button
   Friend WithEvents SAVE As Button
   Friend WithEvents BILD As PictureBox
   Friend WithEvents PREIS As TextBox
   Friend WithEvents WERT As TextBox
   Friend WithEvents Label18 As Label
   Friend WithEvents LAGERORT As ComboBox
   Friend WithEvents Label19 As Label
   Friend WithEvents ANSCHAFFUNG As DateTimePicker
   Friend WithEvents Label20 As Label
   Friend WithEvents REIHE As TextBox
   Friend WithEvents Label21 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
