<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.MetalCB = New System.Windows.Forms.ComboBox()
        Me.GoldPB = New System.Windows.Forms.PictureBox()
        Me.RoseGoldPB = New System.Windows.Forms.PictureBox()
        Me.SilverPB = New System.Windows.Forms.PictureBox()
        Me.AmethystPB = New System.Windows.Forms.PictureBox()
        Me.AquamarinePB = New System.Windows.Forms.PictureBox()
        Me.DiamondPB = New System.Windows.Forms.PictureBox()
        Me.GarnetPB = New System.Windows.Forms.PictureBox()
        Me.EmeraldPB = New System.Windows.Forms.PictureBox()
        Me.JewelCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GoldPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoseGoldPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SilverPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmethystPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AquamarinePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiamondPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarnetPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmeraldPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetalCB
        '
        Me.MetalCB.FormattingEnabled = True
        Me.MetalCB.Items.AddRange(New Object() {"Gold", "Silver", "Rose Gold"})
        Me.MetalCB.Location = New System.Drawing.Point(49, 64)
        Me.MetalCB.Name = "MetalCB"
        Me.MetalCB.Size = New System.Drawing.Size(121, 24)
        Me.MetalCB.TabIndex = 31
        '
        'GoldPB
        '
        Me.GoldPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GoldPB.Image = Global.Jewlery.My.Resources.Resources.Gold
        Me.GoldPB.Location = New System.Drawing.Point(12, 111)
        Me.GoldPB.Name = "GoldPB"
        Me.GoldPB.Size = New System.Drawing.Size(203, 199)
        Me.GoldPB.TabIndex = 29
        Me.GoldPB.TabStop = False
        Me.GoldPB.Visible = False
        '
        'RoseGoldPB
        '
        Me.RoseGoldPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RoseGoldPB.Image = Global.Jewlery.My.Resources.Resources.rosegold
        Me.RoseGoldPB.Location = New System.Drawing.Point(12, 111)
        Me.RoseGoldPB.Name = "RoseGoldPB"
        Me.RoseGoldPB.Size = New System.Drawing.Size(203, 197)
        Me.RoseGoldPB.TabIndex = 28
        Me.RoseGoldPB.TabStop = False
        Me.RoseGoldPB.Visible = False
        '
        'SilverPB
        '
        Me.SilverPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SilverPB.Image = Global.Jewlery.My.Resources.Resources.silver
        Me.SilverPB.Location = New System.Drawing.Point(12, 111)
        Me.SilverPB.Name = "SilverPB"
        Me.SilverPB.Size = New System.Drawing.Size(205, 199)
        Me.SilverPB.TabIndex = 27
        Me.SilverPB.TabStop = False
        Me.SilverPB.Visible = False
        '
        'AmethystPB
        '
        Me.AmethystPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AmethystPB.Image = Global.Jewlery.My.Resources.Resources.Amethyst
        Me.AmethystPB.Location = New System.Drawing.Point(251, 128)
        Me.AmethystPB.Name = "AmethystPB"
        Me.AmethystPB.Size = New System.Drawing.Size(152, 162)
        Me.AmethystPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AmethystPB.TabIndex = 26
        Me.AmethystPB.TabStop = False
        Me.AmethystPB.Visible = False
        '
        'AquamarinePB
        '
        Me.AquamarinePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AquamarinePB.Image = Global.Jewlery.My.Resources.Resources.Aquamarine
        Me.AquamarinePB.Location = New System.Drawing.Point(251, 128)
        Me.AquamarinePB.Name = "AquamarinePB"
        Me.AquamarinePB.Size = New System.Drawing.Size(152, 162)
        Me.AquamarinePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AquamarinePB.TabIndex = 25
        Me.AquamarinePB.TabStop = False
        Me.AquamarinePB.Visible = False
        '
        'DiamondPB
        '
        Me.DiamondPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DiamondPB.Image = Global.Jewlery.My.Resources.Resources.Diamonds
        Me.DiamondPB.Location = New System.Drawing.Point(253, 128)
        Me.DiamondPB.Name = "DiamondPB"
        Me.DiamondPB.Size = New System.Drawing.Size(150, 162)
        Me.DiamondPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DiamondPB.TabIndex = 24
        Me.DiamondPB.TabStop = False
        Me.DiamondPB.Visible = False
        '
        'GarnetPB
        '
        Me.GarnetPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GarnetPB.Image = Global.Jewlery.My.Resources.Resources.Garnet
        Me.GarnetPB.Location = New System.Drawing.Point(253, 128)
        Me.GarnetPB.Name = "GarnetPB"
        Me.GarnetPB.Size = New System.Drawing.Size(152, 162)
        Me.GarnetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GarnetPB.TabIndex = 23
        Me.GarnetPB.TabStop = False
        Me.GarnetPB.Visible = False
        '
        'EmeraldPB
        '
        Me.EmeraldPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmeraldPB.Image = Global.Jewlery.My.Resources.Resources.Emerald
        Me.EmeraldPB.Location = New System.Drawing.Point(253, 128)
        Me.EmeraldPB.Name = "EmeraldPB"
        Me.EmeraldPB.Size = New System.Drawing.Size(152, 162)
        Me.EmeraldPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmeraldPB.TabIndex = 22
        Me.EmeraldPB.TabStop = False
        Me.EmeraldPB.Visible = False
        '
        'JewelCB
        '
        Me.JewelCB.FormattingEnabled = True
        Me.JewelCB.Items.AddRange(New Object() {"Garnet", "Emerald", "Diamond", "Amethyst", "Aquamarine"})
        Me.JewelCB.Location = New System.Drawing.Point(282, 64)
        Me.JewelCB.Name = "JewelCB"
        Me.JewelCB.Size = New System.Drawing.Size(121, 24)
        Me.JewelCB.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Label2"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JewelCB)
        Me.Controls.Add(Me.MetalCB)
        Me.Controls.Add(Me.GoldPB)
        Me.Controls.Add(Me.RoseGoldPB)
        Me.Controls.Add(Me.SilverPB)
        Me.Controls.Add(Me.AmethystPB)
        Me.Controls.Add(Me.AquamarinePB)
        Me.Controls.Add(Me.DiamondPB)
        Me.Controls.Add(Me.GarnetPB)
        Me.Controls.Add(Me.EmeraldPB)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.GoldPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoseGoldPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SilverPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmethystPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AquamarinePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiamondPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarnetPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmeraldPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoldPB As PictureBox
    Friend WithEvents RoseGoldPB As PictureBox
    Friend WithEvents SilverPB As PictureBox
    Friend WithEvents AmethystPB As PictureBox
    Friend WithEvents AquamarinePB As PictureBox
    Friend WithEvents DiamondPB As PictureBox
    Friend WithEvents GarnetPB As PictureBox
    Friend WithEvents EmeraldPB As PictureBox
    Friend WithEvents MetalCB As ComboBox
    Friend WithEvents JewelCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
