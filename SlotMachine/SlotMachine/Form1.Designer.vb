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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Spin2 = New SlotMachine.Spin()
        Me.Spin3 = New SlotMachine.Spin()
        Me.Spin4 = New SlotMachine.Spin()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cherry.png")
        Me.ImageList1.Images.SetKeyName(1, "7.png")
        Me.ImageList1.Images.SetKeyName(2, "bar.png")
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Broadway", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(1051, 625)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 67)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SPIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'Spin2
        '
        Me.Spin2.Location = New System.Drawing.Point(280, 12)
        Me.Spin2.Name = "Spin2"
        Me.Spin2.Size = New System.Drawing.Size(215, 217)
        Me.Spin2.TabIndex = 4
        '
        'Spin3
        '
        Me.Spin3.Location = New System.Drawing.Point(29, 12)
        Me.Spin3.Name = "Spin3"
        Me.Spin3.Size = New System.Drawing.Size(215, 217)
        Me.Spin3.TabIndex = 5
        '
        'Spin4
        '
        Me.Spin4.Location = New System.Drawing.Point(533, 12)
        Me.Spin4.Name = "Spin4"
        Me.Spin4.Size = New System.Drawing.Size(215, 217)
        Me.Spin4.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 704)
        Me.Controls.Add(Me.Spin4)
        Me.Controls.Add(Me.Spin3)
        Me.Controls.Add(Me.Spin2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Spin2 As Spin
    Friend WithEvents Spin3 As Spin
    Friend WithEvents Spin4 As Spin
End Class
