<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button_Login = New System.Windows.Forms.Button()
        Me.textBox_Username = New System.Windows.Forms.TextBox()
        Me.label_ChooseThrow = New System.Windows.Forms.Label()
        Me.pictureBoxTitle = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pictureBoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button_Login
        '
        Me.button_Login.BackColor = System.Drawing.Color.BurlyWood
        Me.button_Login.Font = New System.Drawing.Font("A Goblin Appears!", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Login.ForeColor = System.Drawing.SystemColors.Info
        Me.button_Login.Location = New System.Drawing.Point(130, 319)
        Me.button_Login.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.button_Login.Name = "button_Login"
        Me.button_Login.Size = New System.Drawing.Size(139, 45)
        Me.button_Login.TabIndex = 0
        Me.button_Login.Text = "Play!"
        Me.button_Login.UseVisualStyleBackColor = False
        '
        'textBox_Username
        '
        Me.textBox_Username.Font = New System.Drawing.Font("Monocraft", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox_Username.Location = New System.Drawing.Point(90, 267)
        Me.textBox_Username.Name = "textBox_Username"
        Me.textBox_Username.Size = New System.Drawing.Size(218, 25)
        Me.textBox_Username.TabIndex = 1
        '
        'label_ChooseThrow
        '
        Me.label_ChooseThrow.AutoSize = True
        Me.label_ChooseThrow.BackColor = System.Drawing.Color.Transparent
        Me.label_ChooseThrow.Font = New System.Drawing.Font("A Goblin Appears!", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ChooseThrow.ForeColor = System.Drawing.Color.DimGray
        Me.label_ChooseThrow.Location = New System.Drawing.Point(47, 241)
        Me.label_ChooseThrow.Name = "label_ChooseThrow"
        Me.label_ChooseThrow.Size = New System.Drawing.Size(299, 12)
        Me.label_ChooseThrow.TabIndex = 20
        Me.label_ChooseThrow.Text = "Input your username first:"
        '
        'pictureBoxTitle
        '
        Me.pictureBoxTitle.InitialImage = Global.VBNET_RockPaperScissors_Game.My.Resources.Resources.title
        Me.pictureBoxTitle.Location = New System.Drawing.Point(101, 34)
        Me.pictureBoxTitle.Name = "pictureBoxTitle"
        Me.pictureBoxTitle.Size = New System.Drawing.Size(194, 186)
        Me.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxTitle.TabIndex = 21
        Me.pictureBoxTitle.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("A Goblin Appears!", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(128, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 8)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "© Bayla, Angelo (2023)"
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(396, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pictureBoxTitle)
        Me.Controls.Add(Me.label_ChooseThrow)
        Me.Controls.Add(Me.textBox_Username)
        Me.Controls.Add(Me.button_Login)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Login_Form"
        Me.Text = "Rock, Paper, Scissors! [LOGIN]"
        CType(Me.pictureBoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_Login As Button
    Friend WithEvents textBox_Username As TextBox
    Friend WithEvents label_ChooseThrow As Label
    Friend WithEvents pictureBoxTitle As PictureBox
    Friend WithEvents Label1 As Label
End Class
