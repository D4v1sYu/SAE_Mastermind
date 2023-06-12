Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Setter
    Private CombinaisonJoueur1 As String
    Private caracteresAutorises As String = Form4.getCharAutorise()
    Public Function getCombinaisonJoueur()
        Return CombinaisonJoueur1
    End Function

    Private Sub Setter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblChar.Text = caracteresAutorises
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        Dim combinaison As String = txt1.Text & txt2.Text & txt3.Text & txt4.Text & txt5.Text

        If combinaison.Length < 5 Then
            MessageBox.Show("Veuillez saisir les " & 5 - combinaison.Length & " caracteres manquants")
            Return
        End If

        CombinaisonJoueur1 = combinaison

        'Form3.CombinaisonMasquee = CombinaisonJoueur1

        Guesser.Show()
        For Each txt In pnlCombi.Controls
            txt.Text = ""
        Next
        Me.Close()
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress, txt2.KeyPress, txt3.KeyPress, txt4.KeyPress, txt5.KeyPress

        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not caracteresAutorises.Contains(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


End Class
