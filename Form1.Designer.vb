<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        UsernameTb = New TextBox()
        PasswordTb = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(614, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 54)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(483, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 38)
        Label4.TabIndex = 3
        Label4.Text = "Username :"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(492, 300)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 38)
        Label5.TabIndex = 4
        Label5.Text = "Password :"' 
        ' UsernameTb
        ' 
        UsernameTb.Location = New Point(748, 197)
        UsernameTb.Name = "UsernameTb"
        UsernameTb.Size = New Size(186, 27)
        UsernameTb.TabIndex = 7
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(748, 311)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(186, 27)
        PasswordTb.TabIndex = 8
        PasswordTb.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(457, 513)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 35)
        Button1.TabIndex = 9
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(823, 513)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 35)
        Button2.TabIndex = 10
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(940, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 20)
        Label2.TabIndex = 11
        Label2.Text = "*Enter The Username*"
        Label2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(940, 318)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 20)
        Label3.TabIndex = 12
        Label3.Text = "*Enter The Password*"
        Label3.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(614, 396)
        Label6.Name = "Label6"
        Label6.Size = New Size(236, 20)
        Label6.TabIndex = 13
        Label6.Text = "*Wrong Username or Password*"
        Label6.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1386, 754)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PasswordTb)
        Controls.Add(UsernameTb)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents UsernameTb As TextBox
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
