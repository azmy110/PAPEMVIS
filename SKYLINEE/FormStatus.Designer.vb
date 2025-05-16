<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatus
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
        Me.lblInstruksi = New System.Windows.Forms.Label()
        Me.txtCariNama = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.grpHasil = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPaket = New System.Windows.Forms.Label()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpHasil.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInstruksi
        '
        Me.lblInstruksi.AutoSize = True
        Me.lblInstruksi.Location = New System.Drawing.Point(57, 33)
        Me.lblInstruksi.Name = "lblInstruksi"
        Me.lblInstruksi.Size = New System.Drawing.Size(238, 16)
        Me.lblInstruksi.TabIndex = 0
        Me.lblInstruksi.Text = "Masukkan nama Anda untuk cek status"
        '
        'txtCariNama
        '
        Me.txtCariNama.Location = New System.Drawing.Point(60, 64)
        Me.txtCariNama.Name = "txtCariNama"
        Me.txtCariNama.Size = New System.Drawing.Size(236, 22)
        Me.txtCariNama.TabIndex = 1
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(302, 63)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Search"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'grpHasil
        '
        Me.grpHasil.Controls.Add(Me.lblStatus)
        Me.grpHasil.Controls.Add(Me.lblPaket)
        Me.grpHasil.Controls.Add(Me.lblTelepon)
        Me.grpHasil.Controls.Add(Me.lblNama)
        Me.grpHasil.Location = New System.Drawing.Point(59, 119)
        Me.grpHasil.Name = "grpHasil"
        Me.grpHasil.Size = New System.Drawing.Size(318, 196)
        Me.grpHasil.TabIndex = 3
        Me.grpHasil.TabStop = False
        Me.grpHasil.Text = "GroupBox1"
        Me.grpHasil.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(29, 140)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(48, 16)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Label1"
        '
        'lblPaket
        '
        Me.lblPaket.AutoSize = True
        Me.lblPaket.Location = New System.Drawing.Point(29, 103)
        Me.lblPaket.Name = "lblPaket"
        Me.lblPaket.Size = New System.Drawing.Size(48, 16)
        Me.lblPaket.TabIndex = 0
        Me.lblPaket.Text = "Label1"
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Location = New System.Drawing.Point(29, 67)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(48, 16)
        Me.lblTelepon.TabIndex = 0
        Me.lblTelepon.Text = "Label1"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(29, 34)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(48, 16)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Label1"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(60, 335)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 41)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FormStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 418)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpHasil)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCariNama)
        Me.Controls.Add(Me.lblInstruksi)
        Me.Name = "FormStatus"
        Me.Text = "FormStatus"
        Me.grpHasil.ResumeLayout(False)
        Me.grpHasil.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruksi As Label
    Friend WithEvents txtCariNama As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents grpHasil As GroupBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblPaket As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents btnBack As Button
End Class
