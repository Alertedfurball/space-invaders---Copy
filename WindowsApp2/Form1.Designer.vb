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
        Me.allen1 = New System.Windows.Forms.PictureBox()
        Me.shipp = New System.Windows.Forms.PictureBox()
        Me.AllenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.allen2 = New System.Windows.Forms.PictureBox()
        Me.allen3 = New System.Windows.Forms.PictureBox()
        Me.allen4 = New System.Windows.Forms.PictureBox()
        Me.allen5 = New System.Windows.Forms.PictureBox()
        Me.allen6 = New System.Windows.Forms.PictureBox()
        CType(Me.allen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shipp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allen3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allen4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allen5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allen6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'allen1
        '
        Me.allen1.Image = CType(resources.GetObject("allen1.Image"), System.Drawing.Image)
        Me.allen1.Location = New System.Drawing.Point(197, 12)
        Me.allen1.Name = "allen1"
        Me.allen1.Size = New System.Drawing.Size(65, 60)
        Me.allen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.allen1.TabIndex = 0
        Me.allen1.TabStop = False
        Me.allen1.Tag = "left"
        '
        'shipp
        '
        Me.shipp.BackgroundImage = Global.WindowsApp2.My.Resources.Resources._501_5011901_space_invaders_ship_transparent_hd_png_download
        Me.shipp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shipp.Location = New System.Drawing.Point(361, 355)
        Me.shipp.Name = "shipp"
        Me.shipp.Size = New System.Drawing.Size(94, 83)
        Me.shipp.TabIndex = 1
        Me.shipp.TabStop = False
        '
        'AllenTimer
        '
        Me.AllenTimer.Enabled = True
        '
        'allen2
        '
        Me.allen2.Image = CType(resources.GetObject("allen2.Image"), System.Drawing.Image)
        Me.allen2.Location = New System.Drawing.Point(268, 12)
        Me.allen2.Name = "allen2"
        Me.allen2.Size = New System.Drawing.Size(65, 60)
        Me.allen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.allen2.TabIndex = 2
        Me.allen2.TabStop = False
        Me.allen2.Tag = "left"
        '
        'allen3
        '
        Me.allen3.Image = CType(resources.GetObject("allen3.Image"), System.Drawing.Image)
        Me.allen3.Location = New System.Drawing.Point(339, 12)
        Me.allen3.Name = "allen3"
        Me.allen3.Size = New System.Drawing.Size(65, 60)
        Me.allen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.allen3.TabIndex = 3
        Me.allen3.TabStop = False
        Me.allen3.Tag = "left"
        '
        'allen4
        '
        Me.allen4.Image = CType(resources.GetObject("allen4.Image"), System.Drawing.Image)
        Me.allen4.Location = New System.Drawing.Point(410, 12)
        Me.allen4.Name = "allen4"
        Me.allen4.Size = New System.Drawing.Size(65, 60)
        Me.allen4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.allen4.TabIndex = 4
        Me.allen4.TabStop = False
        Me.allen4.Tag = "left"
        '
        'allen5
        '
        Me.allen5.Image = CType(resources.GetObject("allen5.Image"), System.Drawing.Image)
        Me.allen5.Location = New System.Drawing.Point(481, 12)
        Me.allen5.Name = "allen5"
        Me.allen5.Size = New System.Drawing.Size(65, 60)
        Me.allen5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.allen5.TabIndex = 5
        Me.allen5.TabStop = False
        Me.allen5.Tag = "left"
        '
        'allen6
        '
        Me.allen6.Image = CType(resources.GetObject("allen6.Image"), System.Drawing.Image)
        Me.allen6.Location = New System.Drawing.Point(552, 12)
        Me.allen6.Name = "allen6"
        Me.allen6.Size = New System.Drawing.Size(65, 60)
        Me.allen6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.allen6.TabIndex = 6
        Me.allen6.TabStop = False
        Me.allen6.Tag = "left"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.allen6)
        Me.Controls.Add(Me.allen5)
        Me.Controls.Add(Me.allen4)
        Me.Controls.Add(Me.allen3)
        Me.Controls.Add(Me.allen2)
        Me.Controls.Add(Me.shipp)
        Me.Controls.Add(Me.allen1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.allen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shipp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allen3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allen4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allen5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allen6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents allen1 As PictureBox
    Friend WithEvents shipp As PictureBox
    Friend WithEvents AllenTimer As Timer
    Friend WithEvents allen2 As PictureBox
    Friend WithEvents allen3 As PictureBox
    Friend WithEvents allen4 As PictureBox
    Friend WithEvents allen5 As PictureBox
    Friend WithEvents allen6 As PictureBox
End Class
