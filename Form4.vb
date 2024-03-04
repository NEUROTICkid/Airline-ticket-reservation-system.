Imports System.Windows.Forms.VisualStyles

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("New Delhi")
        ComboBox1.Items.Add("Bengaluru")
        ComboBox1.Items.Add("Chennai")
        ComboBox1.Items.Add("Hyderabad")
        ComboBox1.Items.Add("Pune")
        ComboBox1.Items.Add("Amritsar")
        ComboBox1.Items.Add("Coimbatore")
        ComboBox2.Items.Add("New Delhi")
        ComboBox2.Items.Add("Bengaluru")
        ComboBox2.Items.Add("Chennai")
        ComboBox2.Items.Add("Hyderabad")
        ComboBox2.Items.Add("Pune")
        ComboBox2.Items.Add("Amritsar")
        ComboBox2.Items.Add("Coimbatore")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class