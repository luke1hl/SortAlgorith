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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Filename = New System.Windows.Forms.Label()
        Me.bubblecomp = New System.Windows.Forms.Label()
        Me.bubbleswaps = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Filename
        '
        Me.Filename.Location = New System.Drawing.Point(316, 44)
        Me.Filename.Name = "Filename"
        Me.Filename.Size = New System.Drawing.Size(227, 36)
        Me.Filename.TabIndex = 0
        Me.Filename.Text = "Label1"
        Me.Filename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bubblecomp
        '
        Me.bubblecomp.Location = New System.Drawing.Point(116, 172)
        Me.bubblecomp.Name = "bubblecomp"
        Me.bubblecomp.Size = New System.Drawing.Size(227, 36)
        Me.bubblecomp.TabIndex = 1
        Me.bubblecomp.Text = "number of comparisons - "
        Me.bubblecomp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bubbleswaps
        '
        Me.bubbleswaps.Location = New System.Drawing.Point(128, 208)
        Me.bubbleswaps.Name = "bubbleswaps"
        Me.bubbleswaps.Size = New System.Drawing.Size(227, 36)
        Me.bubbleswaps.TabIndex = 2
        Me.bubbleswaps.Text = "number of swaps - "
        Me.bubbleswaps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bubbleswaps)
        Me.Controls.Add(Me.bubblecomp)
        Me.Controls.Add(Me.Filename)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Filename As Label
    Friend WithEvents bubblecomp As Label
    Friend WithEvents bubbleswaps As Label
End Class
