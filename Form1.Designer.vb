<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtUser = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        txtButton = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Programmer_Blank_Poster_removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(699, 344)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(195, 235)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("ROG Fonts", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 32)
        Label1.TabIndex = 2
        Label1.Text = "HACKER LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(36), CByte(228), CByte(40))
        Label2.Location = New Point(12, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 64)
        Label2.TabIndex = 3
        Label2.Text = "MAKE" & vbCrLf & "SURE" & vbCrLf & "ACCOUNT IS" & vbCrLf & "SECURE" & vbCrLf
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("ROG Fonts", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUser.Location = New Point(249, 187)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(347, 23)
        txtUser.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(36), CByte(228), CByte(40))
        Label3.Location = New Point(336, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 14)
        Label3.TabIndex = 5
        Label3.Text = "ENTER YOUR HACKER ID" & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(36), CByte(228), CByte(40))
        Label4.Location = New Point(333, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 14)
        Label4.TabIndex = 6
        Label4.Text = "ENTER YOUR PASSWORD" & vbCrLf
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("ROG Fonts", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(249, 261)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.Size = New Size(347, 23)
        TextBox1.TabIndex = 7
        ' 
        ' txtButton
        ' 
        txtButton.BackColor = Color.Transparent
        txtButton.BackgroundImage = My.Resources.Resources._01010_Binary
        txtButton.FlatAppearance.BorderSize = 2
        txtButton.Font = New Font("ROG Fonts", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtButton.ForeColor = Color.White
        txtButton.Location = New Point(336, 344)
        txtButton.Name = "txtButton"
        txtButton.Size = New Size(185, 42)
        txtButton.TabIndex = 8
        txtButton.Text = "LOGIN"
        txtButton.TextImageRelation = TextImageRelation.TextAboveImage
        txtButton.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(36), CByte(228), CByte(40))
        Label5.Location = New Point(336, 243)
        Label5.Name = "Label5"
        Label5.Size = New Size(178, 14)
        Label5.TabIndex = 9
        Label5.Text = "ENTER YOUR PASSWORD" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Verdana", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(36), CByte(228), CByte(40))
        Label6.Location = New Point(249, 295)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 14)
        Label6.TabIndex = 10
        Label6.Text = "FORGOT PASSWORD ?"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Verdana", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(36), CByte(228), CByte(40))
        Label8.Location = New Point(528, 295)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 14)
        Label8.TabIndex = 12
        Label8.Text = "REGISTER"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(850, 500)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtButton)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtUser)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label

End Class
