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
        Me.MetalCB = New System.Windows.Forms.ComboBox()
        Me.JewelCB = New System.Windows.Forms.ComboBox()
        Me.CostTB = New System.Windows.Forms.TextBox()
        Me.LengthTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.JewelCTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SizeTB = New System.Windows.Forms.TextBox()
        Me.GoldPB = New System.Windows.Forms.PictureBox()
        Me.AmethystPB = New System.Windows.Forms.PictureBox()
        Me.AquamarinePB = New System.Windows.Forms.PictureBox()
        Me.DiamondPB = New System.Windows.Forms.PictureBox()
        Me.GarnetPB = New System.Windows.Forms.PictureBox()
        Me.EmeraldPB = New System.Windows.Forms.PictureBox()
        Me.RoseGoldPB = New System.Windows.Forms.PictureBox()
        Me.SilverPB = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.GoldPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmethystPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AquamarinePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiamondPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarnetPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmeraldPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoseGoldPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SilverPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetalCB
        '
        Me.MetalCB.FormattingEnabled = True
        Me.MetalCB.Items.AddRange(New Object() {"Gold ", "Silver", "Rose Gold"})
        Me.MetalCB.Location = New System.Drawing.Point(49, 61)
        Me.MetalCB.Name = "MetalCB"
        Me.MetalCB.Size = New System.Drawing.Size(121, 24)
        Me.MetalCB.TabIndex = 8
        '
        'JewelCB
        '
        Me.JewelCB.FormattingEnabled = True
        Me.JewelCB.Items.AddRange(New Object() {"Emerald", "Garnet", "Amethyst", "Diamond", "Aquamarine"})
        Me.JewelCB.Location = New System.Drawing.Point(266, 61)
        Me.JewelCB.Name = "JewelCB"
        Me.JewelCB.Size = New System.Drawing.Size(121, 24)
        Me.JewelCB.TabIndex = 9
        '
        'CostTB
        '
        Me.CostTB.Location = New System.Drawing.Point(550, 162)
        Me.CostTB.Name = "CostTB"
        Me.CostTB.Size = New System.Drawing.Size(100, 22)
        Me.CostTB.TabIndex = 10
        '
        'LengthTB
        '
        Me.LengthTB.Location = New System.Drawing.Point(118, 381)
        Me.LengthTB.Name = "LengthTB"
        Me.LengthTB.Size = New System.Drawing.Size(76, 22)
        Me.LengthTB.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Length (in)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(450, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Chain cost/in"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Metals"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(298, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jewels"
        '
        'Total
        '
        Me.Total.Cursor = System.Windows.Forms.Cursors.Default
        Me.Total.Location = New System.Drawing.Point(550, 217)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(99, 22)
        Me.Total.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(486, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(440, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Jewel cost/carat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'JewelCTB
        '
        Me.JewelCTB.Location = New System.Drawing.Point(550, 134)
        Me.JewelCTB.Name = "JewelCTB"
        Me.JewelCTB.Size = New System.Drawing.Size(99, 22)
        Me.JewelCTB.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Size (p/carat)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SizeTB
        '
        Me.SizeTB.Location = New System.Drawing.Point(118, 356)
        Me.SizeTB.Name = "SizeTB"
        Me.SizeTB.Size = New System.Drawing.Size(76, 22)
        Me.SizeTB.TabIndex = 22
        '
        'GoldPB
        '
        Me.GoldPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GoldPB.Image = Global.Jewlery.My.Resources.Resources.Gold
        Me.GoldPB.Location = New System.Drawing.Point(12, 106)
        Me.GoldPB.Name = "GoldPB"
        Me.GoldPB.Size = New System.Drawing.Size(203, 199)
        Me.GoldPB.TabIndex = 18
        Me.GoldPB.TabStop = False
        Me.GoldPB.Visible = False
        '
        'AmethystPB
        '
        Me.AmethystPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AmethystPB.Image = Global.Jewlery.My.Resources.Resources.Amethyst
        Me.AmethystPB.Location = New System.Drawing.Point(251, 120)
        Me.AmethystPB.Name = "AmethystPB"
        Me.AmethystPB.Size = New System.Drawing.Size(152, 162)
        Me.AmethystPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AmethystPB.TabIndex = 7
        Me.AmethystPB.TabStop = False
        Me.AmethystPB.Visible = False
        '
        'AquamarinePB
        '
        Me.AquamarinePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AquamarinePB.Image = Global.Jewlery.My.Resources.Resources.Aquamarine
        Me.AquamarinePB.Location = New System.Drawing.Point(251, 120)
        Me.AquamarinePB.Name = "AquamarinePB"
        Me.AquamarinePB.Size = New System.Drawing.Size(152, 162)
        Me.AquamarinePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AquamarinePB.TabIndex = 6
        Me.AquamarinePB.TabStop = False
        Me.AquamarinePB.Visible = False
        '
        'DiamondPB
        '
        Me.DiamondPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DiamondPB.Image = Global.Jewlery.My.Resources.Resources.Diamonds
        Me.DiamondPB.Location = New System.Drawing.Point(249, 120)
        Me.DiamondPB.Name = "DiamondPB"
        Me.DiamondPB.Size = New System.Drawing.Size(150, 162)
        Me.DiamondPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DiamondPB.TabIndex = 5
        Me.DiamondPB.TabStop = False
        Me.DiamondPB.Visible = False
        '
        'GarnetPB
        '
        Me.GarnetPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GarnetPB.Image = Global.Jewlery.My.Resources.Resources.Garnet
        Me.GarnetPB.Location = New System.Drawing.Point(249, 120)
        Me.GarnetPB.Name = "GarnetPB"
        Me.GarnetPB.Size = New System.Drawing.Size(152, 162)
        Me.GarnetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GarnetPB.TabIndex = 4
        Me.GarnetPB.TabStop = False
        Me.GarnetPB.Visible = False
        '
        'EmeraldPB
        '
        Me.EmeraldPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmeraldPB.Image = Global.Jewlery.My.Resources.Resources.Emerald
        Me.EmeraldPB.Location = New System.Drawing.Point(249, 120)
        Me.EmeraldPB.Name = "EmeraldPB"
        Me.EmeraldPB.Size = New System.Drawing.Size(152, 162)
        Me.EmeraldPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmeraldPB.TabIndex = 3
        Me.EmeraldPB.TabStop = False
        Me.EmeraldPB.Visible = False
        '
        'RoseGoldPB
        '
        Me.RoseGoldPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RoseGoldPB.Image = Global.Jewlery.My.Resources.Resources.rosegold
        Me.RoseGoldPB.Location = New System.Drawing.Point(12, 108)
        Me.RoseGoldPB.Name = "RoseGoldPB"
        Me.RoseGoldPB.Size = New System.Drawing.Size(203, 197)
        Me.RoseGoldPB.TabIndex = 2
        Me.RoseGoldPB.TabStop = False
        Me.RoseGoldPB.Visible = False
        '
        'SilverPB
        '
        Me.SilverPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SilverPB.Image = Global.Jewlery.My.Resources.Resources.silver
        Me.SilverPB.Location = New System.Drawing.Point(12, 106)
        Me.SilverPB.Name = "SilverPB"
        Me.SilverPB.Size = New System.Drawing.Size(205, 199)
        Me.SilverPB.TabIndex = 0
        Me.SilverPB.TabStop = False
        Me.SilverPB.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(550, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Rings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(550, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(13, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Length (in)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(74, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Metals"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(287, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 21)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Jewels"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(429, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 21)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Jewel cost/carat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(15, 355)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 21)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Size (p/carat)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(875, 472)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SizeTB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.JewelCTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GoldPB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LengthTB)
        Me.Controls.Add(Me.CostTB)
        Me.Controls.Add(Me.JewelCB)
        Me.Controls.Add(Me.MetalCB)
        Me.Controls.Add(Me.AmethystPB)
        Me.Controls.Add(Me.AquamarinePB)
        Me.Controls.Add(Me.DiamondPB)
        Me.Controls.Add(Me.GarnetPB)
        Me.Controls.Add(Me.EmeraldPB)
        Me.Controls.Add(Me.RoseGoldPB)
        Me.Controls.Add(Me.SilverPB)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GoldPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmethystPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AquamarinePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiamondPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarnetPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmeraldPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoseGoldPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SilverPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SilverPB As PictureBox
    Friend WithEvents RoseGoldPB As PictureBox
    Friend WithEvents EmeraldPB As PictureBox
    Friend WithEvents GarnetPB As PictureBox
    Friend WithEvents DiamondPB As PictureBox
    Friend WithEvents AquamarinePB As PictureBox
    Friend WithEvents AmethystPB As PictureBox
    Friend WithEvents MetalCB As ComboBox
    Friend WithEvents JewelCB As ComboBox
    Friend WithEvents CostTB As TextBox
    Friend WithEvents LengthTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GoldPB As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents JewelCTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SizeTB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
