<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSwitsfwrdd
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
        Me.lblTeitl = New System.Windows.Forms.Label()
        Me.btnSefyllfa1 = New System.Windows.Forms.Button()
        Me.btnGadael = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTeitl
        '
        Me.lblTeitl.AutoSize = True
        Me.lblTeitl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeitl.Location = New System.Drawing.Point(37, 46)
        Me.lblTeitl.Name = "lblTeitl"
        Me.lblTeitl.Size = New System.Drawing.Size(280, 29)
        Me.lblTeitl.TabIndex = 0
        Me.lblTeitl.Text = "Penderfyniadau Medygol"
        '
        'btnSefyllfa1
        '
        Me.btnSefyllfa1.Location = New System.Drawing.Point(38, 113)
        Me.btnSefyllfa1.Name = "btnSefyllfa1"
        Me.btnSefyllfa1.Size = New System.Drawing.Size(129, 36)
        Me.btnSefyllfa1.TabIndex = 1
        Me.btnSefyllfa1.Text = "Sefyllfa 1"
        Me.btnSefyllfa1.UseVisualStyleBackColor = True
        '
        'btnGadael
        '
        Me.btnGadael.Location = New System.Drawing.Point(301, 113)
        Me.btnGadael.Name = "btnGadael"
        Me.btnGadael.Size = New System.Drawing.Size(75, 28)
        Me.btnGadael.TabIndex = 4
        Me.btnGadael.Text = "Gadael"
        Me.btnGadael.UseVisualStyleBackColor = True
        '
        'frmSwitsfwrdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 325)
        Me.Controls.Add(Me.btnGadael)
        Me.Controls.Add(Me.btnSefyllfa1)
        Me.Controls.Add(Me.lblTeitl)
        Me.Name = "frmSwitsfwrdd"
        Me.Text = "Penderfyniadau Meddygol  - Switsfwrdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTeitl As System.Windows.Forms.Label
    Friend WithEvents btnSefyllfa1 As System.Windows.Forms.Button
    Friend WithEvents btnGadael As System.Windows.Forms.Button

End Class
