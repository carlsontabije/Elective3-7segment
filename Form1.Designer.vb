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
        Me.A = New System.Windows.Forms.Button()
        Me.C = New System.Windows.Forms.Button()
        Me.D = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.G = New System.Windows.Forms.Button()
        Me.E = New System.Windows.Forms.Button()
        Me.F = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'A
        '
        Me.A.BackColor = System.Drawing.Color.Gray
        Me.A.Location = New System.Drawing.Point(101, 29)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(139, 23)
        Me.A.TabIndex = 0
        Me.A.UseVisualStyleBackColor = False
        '
        'C
        '
        Me.C.BackColor = System.Drawing.Color.Gray
        Me.C.Location = New System.Drawing.Point(236, 192)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(24, 118)
        Me.C.TabIndex = 1
        Me.C.UseVisualStyleBackColor = False
        '
        'D
        '
        Me.D.BackColor = System.Drawing.Color.Gray
        Me.D.Location = New System.Drawing.Point(101, 309)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(139, 23)
        Me.D.TabIndex = 2
        Me.D.UseVisualStyleBackColor = False
        '
        'B
        '
        Me.B.BackColor = System.Drawing.Color.Gray
        Me.B.Location = New System.Drawing.Point(236, 51)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(24, 117)
        Me.B.TabIndex = 3
        Me.B.UseVisualStyleBackColor = False
        '
        'G
        '
        Me.G.BackColor = System.Drawing.Color.Gray
        Me.G.Location = New System.Drawing.Point(101, 169)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(139, 23)
        Me.G.TabIndex = 4
        Me.G.Text = " "
        Me.G.UseVisualStyleBackColor = False
        '
        'E
        '
        Me.E.BackColor = System.Drawing.Color.Gray
        Me.E.Location = New System.Drawing.Point(80, 192)
        Me.E.Name = "E"
        Me.E.Size = New System.Drawing.Size(24, 118)
        Me.E.TabIndex = 5
        Me.E.UseVisualStyleBackColor = False
        '
        'F
        '
        Me.F.BackColor = System.Drawing.Color.Gray
        Me.F.Location = New System.Drawing.Point(80, 50)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(24, 118)
        Me.F.TabIndex = 6
        Me.F.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(347, 389)
        Me.Controls.Add(Me.F)
        Me.Controls.Add(Me.E)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A As Button
    Friend WithEvents C As Button
    Friend WithEvents D As Button
    Friend WithEvents B As Button
    Friend WithEvents G As Button
    Friend WithEvents E As Button
    Friend WithEvents F As Button
    Friend WithEvents Timer1 As Timer
End Class
