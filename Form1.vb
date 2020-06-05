
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
            ListBox1.Items.Add(TextBox1.Text)
            ListBox1.Items.Add("Olá")
            TextBox1.Clear()
            Exit Sub

        Else

        End If

        If TextBox1.Text = "como vai?" Then
            falar.Speak("Bem, estou sempre atualizando e Você")
            ListBox1.Items.Add(TextBox1.Text)
            ListBox1.Items.Add("Bem, estou sempre atualizando e Você")
            TextBox1.Clear()
            Exit Sub
        Else

        End If

        If TextBox1.Text = "bem" Then
            falar.Speak("Que ôtimo")
            ListBox1.Items.Add(TextBox1.Text)
            ListBox1.Items.Add("Que ôtimo!")
            TextBox1.Clear()
            Exit Sub

        Else

        End If

        If TextBox1.Text = "você conhece a Cortana?" Then
            falar.Speak("Sim, não Gosto muito dela não eu em.")
            ListBox1.Items.Add(TextBox1.Text)
            ListBox1.Items.Add("Sim,Não gosto muito dela, EU EM.")
            TextBox1.Clear()
            Exit Sub

        Else

        End If

        If TextBox1.Text = "reset" Then
            My.Settings.Reset()
            TextBox1.Clear()
            Exit Sub

        Else

        End If

        If TextBox1.Text = "qual é o meu nome?" Then
            falar.Speak(My.Settings.noeuser)
            ListBox1.Items.Add(My.Settings.noeuser)
            TextBox1.Clear()
            Exit Sub

        Else

        End If


        If TextBox1.Text = "qual é o seu nome?" Then
            falar.Speak("Maria Cyberquantun.")
            ListBox1.Items.Add(TextBox1.Text)
            ListBox1.Items.Add("Maria Cyberquantun")
            TextBox1.Clear()
            Exit Sub

        Else
        End If

        If TextBox1.Text = "Help" Then
            MsgBox("       Visão Geral de Comandos
                    oi
                    qual é o seu nome?
                    qual é o meu nome?
                    Você conhece a Cortana?
                    Como vai?")
            Exit Sub
        End If

        If TextBox1.Text >= "" Then
            ListBox1.Items.Add("Pesquisa: " + TextBox1.Text)
            diferente()
            Exit Sub
        End If





    End Sub

    Private Sub diferente()
        falar.Speak("Achei Alguns Resutados ")
        Process.Start("https://www.google.com/search?q=" + TextBox1.Text)
        TextBox1.Clear()

    End Sub




    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
