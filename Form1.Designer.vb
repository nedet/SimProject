<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PicA = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrA = New System.Windows.Forms.Timer(Me.components)
        Me.Btnstop = New System.Windows.Forms.Button()
        Me.RadSQ = New System.Windows.Forms.RadioButton()
        Me.radCir = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PicA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicA
        '
        Me.PicA.Image = CType(resources.GetObject("PicA.Image"), System.Drawing.Image)
        Me.PicA.Location = New System.Drawing.Point(13, 55)
        Me.PicA.Name = "PicA"
        Me.PicA.Size = New System.Drawing.Size(715, 464)
        Me.PicA.TabIndex = 0
        Me.PicA.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tmrA
        '
        Me.tmrA.Interval = 500
        '
        'Btnstop
        '
        Me.Btnstop.Location = New System.Drawing.Point(78, 13)
        Me.Btnstop.Name = "Btnstop"
        Me.Btnstop.Size = New System.Drawing.Size(38, 23)
        Me.Btnstop.TabIndex = 3
        Me.Btnstop.Text = "stop"
        Me.Btnstop.UseVisualStyleBackColor = True
        '
        'RadSQ
        '
        Me.RadSQ.AutoSize = True
        Me.RadSQ.Location = New System.Drawing.Point(139, 13)
        Me.RadSQ.Name = "RadSQ"
        Me.RadSQ.Size = New System.Drawing.Size(87, 17)
        Me.RadSQ.TabIndex = 4
        Me.RadSQ.TabStop = True
        Me.RadSQ.Text = "Draw Square"
        Me.RadSQ.UseVisualStyleBackColor = True
        '
        'radCir
        '
        Me.radCir.AutoSize = True
        Me.radCir.Location = New System.Drawing.Point(139, 37)
        Me.radCir.Name = "radCir"
        Me.radCir.Size = New System.Drawing.Size(79, 17)
        Me.radCir.TabIndex = 5
        Me.radCir.TabStop = True
        Me.radCir.Text = "Draw Circle"
        Me.radCir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(514, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 531)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radCir)
        Me.Controls.Add(Me.RadSQ)
        Me.Controls.Add(Me.Btnstop)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicA As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tmrA As Timer
    Friend WithEvents Btnstop As Button
    Friend WithEvents RadSQ As RadioButton
    Friend WithEvents radCir As RadioButton
    Friend WithEvents Label1 As Label
End Class
