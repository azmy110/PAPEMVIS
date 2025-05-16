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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.cmbPaket = New System.Windows.Forms.ComboBox()
        Me.txtDeskripsiAcara = New System.Windows.Forms.TextBox()
        Me.btnLanjutkann = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnCekStatuss = New System.Windows.Forms.Button()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.picAdmin = New System.Windows.Forms.PictureBox()
        Me.picBukti = New System.Windows.Forms.PictureBox()
        Me.pictSkyline = New System.Windows.Forms.PictureBox()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBukti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictSkyline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(70, 166)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(167, 22)
        Me.txtNama.TabIndex = 0
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(70, 284)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(167, 22)
        Me.txtTelepon.TabIndex = 0
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(70, 333)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(167, 22)
        Me.txtAlamat.TabIndex = 0
        '
        'cmbPaket
        '
        Me.cmbPaket.FormattingEnabled = True
        Me.cmbPaket.Location = New System.Drawing.Point(283, 164)
        Me.cmbPaket.Name = "cmbPaket"
        Me.cmbPaket.Size = New System.Drawing.Size(228, 24)
        Me.cmbPaket.TabIndex = 1
        '
        'txtDeskripsiAcara
        '
        Me.txtDeskripsiAcara.Enabled = False
        Me.txtDeskripsiAcara.Location = New System.Drawing.Point(282, 222)
        Me.txtDeskripsiAcara.Multiline = True
        Me.txtDeskripsiAcara.Name = "txtDeskripsiAcara"
        Me.txtDeskripsiAcara.Size = New System.Drawing.Size(167, 22)
        Me.txtDeskripsiAcara.TabIndex = 2
        '
        'btnLanjutkann
        '
        Me.btnLanjutkann.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLanjutkann.Location = New System.Drawing.Point(226, 386)
        Me.btnLanjutkann.Name = "btnLanjutkann"
        Me.btnLanjutkann.Size = New System.Drawing.Size(86, 38)
        Me.btnLanjutkann.TabIndex = 5
        Me.btnLanjutkann.Text = "Lanjutkan"
        Me.btnLanjutkann.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(278, 284)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(86, 38)
        Me.btnUpload.TabIndex = 5
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnCekStatuss
        '
        Me.btnCekStatuss.BackColor = System.Drawing.Color.Yellow
        Me.btnCekStatuss.Location = New System.Drawing.Point(176, 439)
        Me.btnCekStatuss.Name = "btnCekStatuss"
        Me.btnCekStatuss.Size = New System.Drawing.Size(188, 38)
        Me.btnCekStatuss.TabIndex = 5
        Me.btnCekStatuss.Text = "Cek Status Pemesanan"
        Me.btnCekStatuss.UseVisualStyleBackColor = False
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(70, 226)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(88, 20)
        Me.rbLaki.TabIndex = 7
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki - Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(164, 226)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(98, 20)
        Me.rbPerempuan.TabIndex = 8
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "No Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Alamat Acara"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(279, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pilih Paket"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(280, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Deskripsi Paket (opsional)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 17.0!)
        Me.Label7.Location = New System.Drawing.Point(178, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 32)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Form Pemesanan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(279, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Bukti Pembayaran"
        '
        'picAdmin
        '
        Me.picAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAdmin.Image = Global.SKYLINEE.My.Resources.Resources.vecteezy_profile_icon_design_vector_5544718
        Me.picAdmin.Location = New System.Drawing.Point(516, 12)
        Me.picAdmin.Name = "picAdmin"
        Me.picAdmin.Size = New System.Drawing.Size(37, 36)
        Me.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAdmin.TabIndex = 6
        Me.picAdmin.TabStop = False
        '
        'picBukti
        '
        Me.picBukti.Location = New System.Drawing.Point(402, 262)
        Me.picBukti.Name = "picBukti"
        Me.picBukti.Size = New System.Drawing.Size(95, 60)
        Me.picBukti.TabIndex = 4
        Me.picBukti.TabStop = False
        '
        'pictSkyline
        '
        Me.pictSkyline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictSkyline.Image = Global.SKYLINEE.My.Resources.Resources.Skyline_Hitam
        Me.pictSkyline.Location = New System.Drawing.Point(207, -35)
        Me.pictSkyline.Name = "pictSkyline"
        Me.pictSkyline.Size = New System.Drawing.Size(167, 164)
        Me.pictSkyline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictSkyline.TabIndex = 3
        Me.pictSkyline.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 529)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbPerempuan)
        Me.Controls.Add(Me.rbLaki)
        Me.Controls.Add(Me.picAdmin)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnCekStatuss)
        Me.Controls.Add(Me.btnLanjutkann)
        Me.Controls.Add(Me.picBukti)
        Me.Controls.Add(Me.pictSkyline)
        Me.Controls.Add(Me.txtDeskripsiAcara)
        Me.Controls.Add(Me.cmbPaket)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBukti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictSkyline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cmbPaket As ComboBox
    Friend WithEvents txtDeskripsiAcara As TextBox
    Friend WithEvents picBukti As PictureBox
    Friend WithEvents btnLanjutkann As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnCekStatuss As Button
    Friend WithEvents picAdmin As PictureBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pictSkyline As PictureBox
End Class
