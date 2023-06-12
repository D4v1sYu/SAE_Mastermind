<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        lstNom = New ListBox()
        btnRetour = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cboNom = New ComboBox()
        Label7 = New Label()
        lstTrie = New ListBox()
        Label8 = New Label()
        btnStats = New Button()
        lstScore = New ListBox()
        lstTempsR = New ListBox()
        lstFirst = New ListBox()
        lstSecond = New ListBox()
        lstTempsT = New ListBox()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' lstNom
        ' 
        lstNom.FormattingEnabled = True
        lstNom.ItemHeight = 20
        lstNom.Location = New Point(33, 132)
        lstNom.Name = "lstNom"
        lstNom.Size = New Size(118, 164)
        lstNom.TabIndex = 0
        ' 
        ' btnRetour
        ' 
        btnRetour.Location = New Point(691, 414)
        btnRetour.Name = "btnRetour"
        btnRetour.Size = New Size(94, 29)
        btnRetour.TabIndex = 1
        btnRetour.Text = "Retour"
        btnRetour.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 5
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(212, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 6
        Label2.Text = "Score"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(331, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 7
        Label3.Text = "Temps Record"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(483, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 8
        Label4.Text = "Partie Setter"
        ' 
        ' cboNom
        ' 
        cboNom.FormattingEnabled = True
        cboNom.Location = New Point(177, 353)
        cboNom.Name = "cboNom"
        cboNom.Size = New Size(151, 28)
        cboNom.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(118, 356)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 20)
        Label7.TabIndex = 10
        Label7.Text = "Joueur"
        ' 
        ' lstTrie
        ' 
        lstTrie.FormattingEnabled = True
        lstTrie.ItemHeight = 20
        lstTrie.Location = New Point(177, 414)
        lstTrie.Name = "lstTrie"
        lstTrie.Size = New Size(151, 124)
        lstTrie.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(118, 460)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 20)
        Label8.TabIndex = 12
        Label8.Text = "Trie"
        ' 
        ' btnStats
        ' 
        btnStats.Location = New Point(347, 352)
        btnStats.Name = "btnStats"
        btnStats.Size = New Size(94, 29)
        btnStats.TabIndex = 13
        btnStats.Text = "Statistiques"
        btnStats.UseVisualStyleBackColor = True
        btnStats.Visible = False
        ' 
        ' lstScore
        ' 
        lstScore.FormattingEnabled = True
        lstScore.ItemHeight = 20
        lstScore.Location = New Point(177, 132)
        lstScore.Name = "lstScore"
        lstScore.Size = New Size(118, 164)
        lstScore.TabIndex = 14
        ' 
        ' lstTempsR
        ' 
        lstTempsR.FormattingEnabled = True
        lstTempsR.ItemHeight = 20
        lstTempsR.Location = New Point(323, 132)
        lstTempsR.Name = "lstTempsR"
        lstTempsR.Size = New Size(118, 164)
        lstTempsR.TabIndex = 15
        ' 
        ' lstFirst
        ' 
        lstFirst.FormattingEnabled = True
        lstFirst.ItemHeight = 20
        lstFirst.Location = New Point(469, 132)
        lstFirst.Name = "lstFirst"
        lstFirst.Size = New Size(118, 164)
        lstFirst.TabIndex = 16
        ' 
        ' lstSecond
        ' 
        lstSecond.FormattingEnabled = True
        lstSecond.ItemHeight = 20
        lstSecond.Location = New Point(614, 132)
        lstSecond.Name = "lstSecond"
        lstSecond.Size = New Size(118, 164)
        lstSecond.TabIndex = 17
        ' 
        ' lstTempsT
        ' 
        lstTempsT.FormattingEnabled = True
        lstTempsT.ItemHeight = 20
        lstTempsT.Location = New Point(760, 132)
        lstTempsT.Name = "lstTempsT"
        lstTempsT.Size = New Size(118, 164)
        lstTempsT.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(623, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 20)
        Label5.TabIndex = 19
        Label5.Text = "Partie Guesser"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(774, 99)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 20)
        Label6.TabIndex = 20
        Label6.Text = "Temps Total"
        ' 
        ' Scores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 599)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lstTempsT)
        Controls.Add(lstSecond)
        Controls.Add(lstFirst)
        Controls.Add(lstTempsR)
        Controls.Add(lstScore)
        Controls.Add(btnStats)
        Controls.Add(Label8)
        Controls.Add(lstTrie)
        Controls.Add(Label7)
        Controls.Add(cboNom)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnRetour)
        Controls.Add(lstNom)
        Name = "Scores"
        Text = "Scores"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstNom As ListBox
    Friend WithEvents btnRetour As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboNom As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lstTrie As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnStats As Button
    Friend WithEvents lstScore As ListBox
    Friend WithEvents lstTempsR As ListBox
    Friend WithEvents lstFirst As ListBox
    Friend WithEvents lstSecond As ListBox
    Friend WithEvents lstTempsT As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
