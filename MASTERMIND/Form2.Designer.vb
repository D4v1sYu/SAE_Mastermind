﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setter
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
        Label1 = New Label()
        txt1 = New TextBox()
        txt2 = New TextBox()
        txt3 = New TextBox()
        txt4 = New TextBox()
        txt5 = New TextBox()
        btnPlay = New Button()
        Label2 = New Label()
        lblChar = New Label()
        pnlCombi = New Panel()
        pnlCombi.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(427, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 0
        Label1.Text = "Master Mind"
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(6, 23)
        txt1.Margin = New Padding(3, 4, 3, 4)
        txt1.MaxLength = 1
        txt1.Name = "txt1"
        txt1.Size = New Size(114, 27)
        txt1.TabIndex = 1
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(147, 23)
        txt2.Margin = New Padding(3, 4, 3, 4)
        txt2.MaxLength = 1
        txt2.Name = "txt2"
        txt2.Size = New Size(114, 27)
        txt2.TabIndex = 2
        ' 
        ' txt3
        ' 
        txt3.Location = New Point(294, 23)
        txt3.Margin = New Padding(3, 4, 3, 4)
        txt3.MaxLength = 1
        txt3.Name = "txt3"
        txt3.Size = New Size(114, 27)
        txt3.TabIndex = 3
        ' 
        ' txt4
        ' 
        txt4.Location = New Point(435, 23)
        txt4.Margin = New Padding(3, 4, 3, 4)
        txt4.MaxLength = 1
        txt4.Name = "txt4"
        txt4.Size = New Size(114, 27)
        txt4.TabIndex = 4
        ' 
        ' txt5
        ' 
        txt5.Location = New Point(581, 23)
        txt5.Margin = New Padding(3, 4, 3, 4)
        txt5.MaxLength = 1
        txt5.Name = "txt5"
        txt5.Size = New Size(114, 27)
        txt5.TabIndex = 5
        ' 
        ' btnPlay
        ' 
        btnPlay.Location = New Point(792, 184)
        btnPlay.Margin = New Padding(3, 4, 3, 4)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(86, 31)
        btnPlay.TabIndex = 6
        btnPlay.Text = "Hide"
        btnPlay.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(747, 291)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 20)
        Label2.TabIndex = 7
        Label2.Text = "Caractères jouables"
        ' 
        ' lblChar
        ' 
        lblChar.AutoSize = True
        lblChar.Location = New Point(779, 324)
        lblChar.Name = "lblChar"
        lblChar.Size = New Size(60, 20)
        lblChar.TabIndex = 8
        lblChar.Text = "#$£%@"
        ' 
        ' pnlCombi
        ' 
        pnlCombi.Controls.Add(txt5)
        pnlCombi.Controls.Add(txt4)
        pnlCombi.Controls.Add(txt3)
        pnlCombi.Controls.Add(txt2)
        pnlCombi.Controls.Add(txt1)
        pnlCombi.Location = New Point(61, 161)
        pnlCombi.Margin = New Padding(2, 3, 2, 3)
        pnlCombi.Name = "pnlCombi"
        pnlCombi.Size = New Size(702, 77)
        pnlCombi.TabIndex = 9
        ' 
        ' Setter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 589)
        Controls.Add(pnlCombi)
        Controls.Add(lblChar)
        Controls.Add(Label2)
        Controls.Add(btnPlay)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        MaximumSize = New Size(930, 636)
        MinimumSize = New Size(930, 636)
        Name = "Setter"
        Text = "Setter"
        pnlCombi.ResumeLayout(False)
        pnlCombi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblChar As Label
    Friend WithEvents pnlCombi As Panel
End Class
