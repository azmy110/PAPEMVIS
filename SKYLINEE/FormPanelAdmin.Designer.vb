<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPanelAdmin
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCancelEditt = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvPemesanan = New System.Windows.Forms.DataGridView()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpDetail = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.lblPaket = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.ComboBox()
        Me.txtPaket = New System.Windows.Forms.ComboBox()
        Me.txtJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.pnlButtonss = New System.Windows.Forms.Panel()
        Me.grpBukti = New System.Windows.Forms.GroupBox()
        Me.btnUploadBukti = New System.Windows.Forms.Button()
        Me.btnLihatBukti = New System.Windows.Forms.Button()
        Me.menuStripAdmin = New System.Windows.Forms.MenuStrip()
        Me.picBukti = New System.Windows.Forms.PictureBox()
        Me.PrintNotavbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvPemesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpDetail.SuspendLayout()
        Me.pnlButtonss.SuspendLayout()
        Me.grpBukti.SuspendLayout()
        Me.menuStripAdmin.SuspendLayout()
        CType(Me.picBukti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(13, 7)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(106, 32)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit Data"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(125, 47)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 32)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(385, 18)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(106, 32)
        Me.btnLogout.TabIndex = 20
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnCancelEditt
        '
        Me.btnCancelEditt.Location = New System.Drawing.Point(125, 7)
        Me.btnCancelEditt.Name = "btnCancelEditt"
        Me.btnCancelEditt.Size = New System.Drawing.Size(106, 32)
        Me.btnCancelEditt.TabIndex = 17
        Me.btnCancelEditt.Text = "Cancel Edit"
        Me.btnCancelEditt.UseVisualStyleBackColor = True
        Me.btnCancelEditt.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(13, 47)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 32)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvPemesanan
        '
        Me.dgvPemesanan.AllowUserToAddRows = False
        Me.dgvPemesanan.AllowUserToDeleteRows = False
        Me.dgvPemesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPemesanan.ColumnHeadersHeight = 29
        Me.dgvPemesanan.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvPemesanan.Location = New System.Drawing.Point(0, 28)
        Me.dgvPemesanan.MultiSelect = False
        Me.dgvPemesanan.Name = "dgvPemesanan"
        Me.dgvPemesanan.ReadOnly = True
        Me.dgvPemesanan.RowHeadersWidth = 51
        Me.dgvPemesanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPemesanan.Size = New System.Drawing.Size(807, 237)
        Me.dgvPemesanan.TabIndex = 0
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnRefresh)
        Me.pnlButtons.Controls.Add(Me.btnLogout)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtons.Location = New System.Drawing.Point(0, 265)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(807, 69)
        Me.pnlButtons.TabIndex = 26
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(273, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(106, 32)
        Me.btnRefresh.TabIndex = 20
        Me.btnRefresh.Text = "Refresh Data"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 334)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpDetail)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlButtonss)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpBukti)
        Me.SplitContainer1.Size = New System.Drawing.Size(807, 611)
        Me.SplitContainer1.SplitterDistance = 429
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 39
        '
        'grpDetail
        '
        Me.grpDetail.Controls.Add(Me.lblStatus)
        Me.grpDetail.Controls.Add(Me.lblDeskripsi)
        Me.grpDetail.Controls.Add(Me.lblPaket)
        Me.grpDetail.Controls.Add(Me.lblAlamat)
        Me.grpDetail.Controls.Add(Me.lblTelepon)
        Me.grpDetail.Controls.Add(Me.txtStatus)
        Me.grpDetail.Controls.Add(Me.txtPaket)
        Me.grpDetail.Controls.Add(Me.txtJenisKelamin)
        Me.grpDetail.Controls.Add(Me.txtAlamat)
        Me.grpDetail.Controls.Add(Me.txtTelepon)
        Me.grpDetail.Controls.Add(Me.txtDeskripsi)
        Me.grpDetail.Controls.Add(Me.txtNama)
        Me.grpDetail.Controls.Add(Me.lblJenisKelamin)
        Me.grpDetail.Controls.Add(Me.lblNama)
        Me.grpDetail.Location = New System.Drawing.Point(12, 9)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Size = New System.Drawing.Size(572, 348)
        Me.grpDetail.TabIndex = 0
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Detail Pemesanan"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(324, 113)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(44, 16)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status"
        '
        'lblDeskripsi
        '
        Me.lblDeskripsi.AutoSize = True
        Me.lblDeskripsi.Location = New System.Drawing.Point(324, 70)
        Me.lblDeskripsi.Name = "lblDeskripsi"
        Me.lblDeskripsi.Size = New System.Drawing.Size(64, 16)
        Me.lblDeskripsi.TabIndex = 4
        Me.lblDeskripsi.Text = "Deskripsi"
        '
        'lblPaket
        '
        Me.lblPaket.AutoSize = True
        Me.lblPaket.Location = New System.Drawing.Point(324, 30)
        Me.lblPaket.Name = "lblPaket"
        Me.lblPaket.Size = New System.Drawing.Size(42, 16)
        Me.lblPaket.TabIndex = 4
        Me.lblPaket.Text = "Paket"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(12, 155)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(49, 16)
        Me.lblAlamat.TabIndex = 4
        Me.lblAlamat.Text = "Alamat"
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Location = New System.Drawing.Point(12, 110)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(58, 16)
        Me.lblTelepon.TabIndex = 4
        Me.lblTelepon.Text = "Telepon"
        '
        'txtStatus
        '
        Me.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtStatus.Enabled = False
        Me.txtStatus.FormattingEnabled = True
        Me.txtStatus.Location = New System.Drawing.Point(407, 110)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(157, 24)
        Me.txtStatus.TabIndex = 3
        '
        'txtPaket
        '
        Me.txtPaket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPaket.Enabled = False
        Me.txtPaket.FormattingEnabled = True
        Me.txtPaket.Location = New System.Drawing.Point(407, 30)
        Me.txtPaket.Name = "txtPaket"
        Me.txtPaket.Size = New System.Drawing.Size(157, 24)
        Me.txtPaket.TabIndex = 3
        '
        'txtJenisKelamin
        '
        Me.txtJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtJenisKelamin.Enabled = False
        Me.txtJenisKelamin.FormattingEnabled = True
        Me.txtJenisKelamin.Location = New System.Drawing.Point(126, 67)
        Me.txtJenisKelamin.Name = "txtJenisKelamin"
        Me.txtJenisKelamin.Size = New System.Drawing.Size(157, 24)
        Me.txtJenisKelamin.TabIndex = 3
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(126, 152)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ReadOnly = True
        Me.txtAlamat.Size = New System.Drawing.Size(157, 22)
        Me.txtAlamat.TabIndex = 2
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(126, 107)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.ReadOnly = True
        Me.txtTelepon.Size = New System.Drawing.Size(157, 22)
        Me.txtTelepon.TabIndex = 2
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(407, 67)
        Me.txtDeskripsi.Multiline = True
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.ReadOnly = True
        Me.txtDeskripsi.Size = New System.Drawing.Size(157, 22)
        Me.txtDeskripsi.TabIndex = 2
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(126, 32)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(157, 22)
        Me.txtNama.TabIndex = 2
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Location = New System.Drawing.Point(12, 70)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(90, 16)
        Me.lblJenisKelamin.TabIndex = 1
        Me.lblJenisKelamin.Text = "Jenis Kelamin"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(12, 30)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(44, 16)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama"
        '
        'pnlButtonss
        '
        Me.pnlButtonss.Controls.Add(Me.btnDelete)
        Me.pnlButtonss.Controls.Add(Me.btnCancelEditt)
        Me.pnlButtonss.Controls.Add(Me.btnEdit)
        Me.pnlButtonss.Controls.Add(Me.btnSave)
        Me.pnlButtonss.Location = New System.Drawing.Point(559, 38)
        Me.pnlButtonss.Name = "pnlButtonss"
        Me.pnlButtonss.Size = New System.Drawing.Size(236, 98)
        Me.pnlButtonss.TabIndex = 19
        '
        'grpBukti
        '
        Me.grpBukti.Controls.Add(Me.picBukti)
        Me.grpBukti.Controls.Add(Me.btnUploadBukti)
        Me.grpBukti.Controls.Add(Me.btnLihatBukti)
        Me.grpBukti.Location = New System.Drawing.Point(8, 14)
        Me.grpBukti.Name = "grpBukti"
        Me.grpBukti.Size = New System.Drawing.Size(534, 207)
        Me.grpBukti.TabIndex = 0
        Me.grpBukti.TabStop = False
        Me.grpBukti.Text = "Bukti Pembayaran"
        '
        'btnUploadBukti
        '
        Me.btnUploadBukti.Enabled = False
        Me.btnUploadBukti.Location = New System.Drawing.Point(417, 71)
        Me.btnUploadBukti.Name = "btnUploadBukti"
        Me.btnUploadBukti.Size = New System.Drawing.Size(106, 32)
        Me.btnUploadBukti.TabIndex = 20
        Me.btnUploadBukti.Text = " Upload Bukti"
        Me.btnUploadBukti.UseVisualStyleBackColor = True
        '
        'btnLihatBukti
        '
        Me.btnLihatBukti.Location = New System.Drawing.Point(417, 33)
        Me.btnLihatBukti.Name = "btnLihatBukti"
        Me.btnLihatBukti.Size = New System.Drawing.Size(106, 32)
        Me.btnLihatBukti.TabIndex = 20
        Me.btnLihatBukti.Text = "Lihat Bukti" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnLihatBukti.UseVisualStyleBackColor = True
        '
        'menuStripAdmin
        '
        Me.menuStripAdmin.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStripAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintNotavbToolStripMenuItem})
        Me.menuStripAdmin.Location = New System.Drawing.Point(0, 0)
        Me.menuStripAdmin.Name = "menuStripAdmin"
        Me.menuStripAdmin.Size = New System.Drawing.Size(807, 28)
        Me.menuStripAdmin.TabIndex = 40
        Me.menuStripAdmin.Text = "MenuStrip1"
        '
        'picBukti
        '
        Me.picBukti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBukti.Location = New System.Drawing.Point(27, 33)
        Me.picBukti.Name = "picBukti"
        Me.picBukti.Size = New System.Drawing.Size(360, 162)
        Me.picBukti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBukti.TabIndex = 0
        Me.picBukti.TabStop = False
        '
        'PrintNotavbToolStripMenuItem
        '
        Me.PrintNotavbToolStripMenuItem.Name = "PrintNotavbToolStripMenuItem"
        Me.PrintNotavbToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.PrintNotavbToolStripMenuItem.Text = "Print Nota"
        '
        'FormPanelAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 945)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.dgvPemesanan)
        Me.Controls.Add(Me.menuStripAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menuStripAdmin
        Me.MaximizeBox = False
        Me.Name = "FormPanelAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPanelAdmin"
        CType(Me.dgvPemesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpDetail.ResumeLayout(False)
        Me.grpDetail.PerformLayout()
        Me.pnlButtonss.ResumeLayout(False)
        Me.grpBukti.ResumeLayout(False)
        Me.menuStripAdmin.ResumeLayout(False)
        Me.menuStripAdmin.PerformLayout()
        CType(Me.picBukti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCancelEditt As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvPemesanan As DataGridView
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grpDetail As GroupBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents txtJenisKelamin As ComboBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents lblPaket As Label
    Friend WithEvents txtStatus As ComboBox
    Friend WithEvents txtPaket As ComboBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents grpBukti As GroupBox
    Friend WithEvents picBukti As PictureBox
    Friend WithEvents btnUploadBukti As Button
    Friend WithEvents btnLihatBukti As Button
    Friend WithEvents pnlButtonss As Panel
    Friend WithEvents menuStripAdmin As MenuStrip
    Friend WithEvents PrintNotavbToolStripMenuItem As ToolStripMenuItem
End Class
