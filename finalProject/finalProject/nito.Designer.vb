﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nito
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.finalProject.My.Resources.Resources.nito
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 242)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This is Nito the Gravelord. And guess what? There is only one thing you can do to" & _
    " kill him, but that is for you to find out. But just remember, this isn't a seri" & _
    "ous game. It's a me me game."
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(12, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Click here to win!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(195, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ME ME HIM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(327, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 39)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Slap him with your fist"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(195, 367)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 70)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "PIKACHU, I CHOOSE YOU"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(327, 367)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 70)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "bust him with a bball bat"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'nito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(925, 504)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "nito"
        Me.Text = "Nito"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
