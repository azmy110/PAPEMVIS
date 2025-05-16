<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintNota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintNota))
        Me.dgvPemesanan = New System.Windows.Forms.DataGridView()
        Me.lblNamaCustomer = New System.Windows.Forms.Label()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblPaket = New System.Windows.Forms.Label()
        Me.lblTanggalPemesanan = New System.Windows.Forms.Label()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.docPrintNota = New System.Drawing.Printing.PrintDocument()
        Me.previewNota = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvPemesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPemesanan
        '
        Me.dgvPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPemesanan.Location = New System.Drawing.Point(327, 12)
        Me.dgvPemesanan.Name = "dgvPemesanan"
        Me.dgvPemesanan.RowHeadersWidth = 51
        Me.dgvPemesanan.RowTemplate.Height = 24
        Me.dgvPemesanan.Size = New System.Drawing.Size(424, 437)
        Me.dgvPemesanan.TabIndex = 2
        '
        'lblNamaCustomer
        '
        Me.lblNamaCustomer.AutoSize = True
        Me.lblNamaCustomer.Location = New System.Drawing.Point(37, 49)
        Me.lblNamaCustomer.Name = "lblNamaCustomer"
        Me.lblNamaCustomer.Size = New System.Drawing.Size(44, 16)
        Me.lblNamaCustomer.TabIndex = 3
        Me.lblNamaCustomer.Text = "Nama"
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Location = New System.Drawing.Point(37, 81)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(90, 16)
        Me.lblJenisKelamin.TabIndex = 3
        Me.lblJenisKelamin.Text = "Jenis Kelamin"
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Location = New System.Drawing.Point(37, 119)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(58, 16)
        Me.lblTelepon.TabIndex = 3
        Me.lblTelepon.Text = "Telepon"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(37, 159)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(49, 16)
        Me.lblAlamat.TabIndex = 3
        Me.lblAlamat.Text = "Alamat"
        '
        'lblPaket
        '
        Me.lblPaket.AutoSize = True
        Me.lblPaket.Location = New System.Drawing.Point(37, 193)
        Me.lblPaket.Name = "lblPaket"
        Me.lblPaket.Size = New System.Drawing.Size(42, 16)
        Me.lblPaket.TabIndex = 3
        Me.lblPaket.Text = "Paket"
        '
        'lblTanggalPemesanan
        '
        Me.lblTanggalPemesanan.AutoSize = True
        Me.lblTanggalPemesanan.Location = New System.Drawing.Point(37, 301)
        Me.lblTanggalPemesanan.Name = "lblTanggalPemesanan"
        Me.lblTanggalPemesanan.Size = New System.Drawing.Size(134, 16)
        Me.lblTanggalPemesanan.TabIndex = 3
        Me.lblTanggalPemesanan.Text = "Tanggal Pemesanan"
        '
        'lblDeskripsi
        '
        Me.lblDeskripsi.AutoSize = True
        Me.lblDeskripsi.Location = New System.Drawing.Point(37, 227)
        Me.lblDeskripsi.Name = "lblDeskripsi"
        Me.lblDeskripsi.Size = New System.Drawing.Size(64, 16)
        Me.lblDeskripsi.TabIndex = 3
        Me.lblDeskripsi.Text = "Deskripsi"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(37, 264)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(44, 16)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Status"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(48, 355)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(148, 355)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 23)
        Me.btnKembali.TabIndex = 4
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'docPrintNota
        '
        '
        'previewNota
        '
        Me.previewNota.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.previewNota.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.previewNota.ClientSize = New System.Drawing.Size(400, 300)
        Me.previewNota.Enabled = True
        Me.previewNota.Icon = CType(resources.GetObject("previewNota.Icon"), System.Drawing.Icon)
        Me.previewNota.Name = "previewNota"
        Me.previewNota.Visible = False
        '
        'PrintNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 483)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblDeskripsi)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblTanggalPemesanan)
        Me.Controls.Add(Me.lblJenisKelamin)
        Me.Controls.Add(Me.lblPaket)
        Me.Controls.Add(Me.lblNamaCustomer)
        Me.Controls.Add(Me.dgvPemesanan)
        Me.Name = "PrintNota"
        Me.Text = "PrintNota"
        CType(Me.dgvPemesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPemesanan As DataGridView
    Friend WithEvents lblNamaCustomer As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblPaket As Label
    Friend WithEvents lblTanggalPemesanan As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents docPrintNota As Printing.PrintDocument
    Friend WithEvents previewNota As PrintPreviewDialog
End Class
