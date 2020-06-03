
Imports System.Speech.Synthesis
Public Class Form1

    Dim falar As New SpeechSynthesizer()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.inicialc = False Then
            Form2.Show()
            My.Settings.inicialc = True
            My.Settings.Save()
        End If

        lbuser.Text = My.Settings.noeuser
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "oi" Then
            falar.Speak("olá")
            TextBox1.Clear()
        End If

        If TextBox1.Text = "como vai?" Then
            falar.Speak("Bem, estou sempre atualizando e Você")
            TextBox1.Clear()
        End If

        If TextBox1.Text = "bem" Then
            falar.Speak("Que ôtimo")
            TextBox1.Clear()
        End If

        If TextBox1.Text = "você conhece a Cortana?" Then
            falar.Speak("Sim, não Gosto muito dela não eu em.")
            TextBox1.Clear()
        End If

        If TextBox1.Text = "reset" Then
            My.Settings.Reset()
            TextBox1.Clear()
        End If

        If TextBox1.Text = "qual é o meu nome?" Then
            falar.Speak(My.Settings.noeuser)
            TextBox1.Clear()
        End If

        If TextBox1.Text = "qual é o seu nome?" Then
            falar.Speak("Maria roberta de segunda de Constantino fernanda de Guanabara.")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub
End Class
