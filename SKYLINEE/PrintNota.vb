Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class PrintNota
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim selectedId As Integer = -1

    ' String koneksi
    Dim connString As String = "server=localhost;user id=root;password=;database=db_skyline"

    ' Data untuk print
    Dim namaPemesan As String = ""
    Dim jenisKelamin As String = ""
    Dim telepon As String = ""
    Dim alamat As String = ""
    Dim alamatAcara As String = ""
    Dim paket As String = ""
    Dim deskripsi As String = ""
    Dim status As String = ""
    Dim tanggalPemesanan As String = ""

    Sub Koneksi()
        conn = New MySqlConnection(connString)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub LoadData()
        Try
            Koneksi()
            da = New MySqlDataAdapter("SELECT * FROM pemesanan ORDER BY tanggal_pemesanan DESC", conn)
            dt = New DataTable()
            da.Fill(dt)
            dgvPemesanan.DataSource = dt
            conn.Close()

            ' Format tampilan kolom
            FormatDataGridView()

            ' Reset detail nota
            ResetDetailNota()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatDataGridView()
        ' Format tampilan kolom
        If dgvPemesanan.Columns.Count > 0 Then
            dgvPemesanan.Columns("id").HeaderText = "ID"
            dgvPemesanan.Columns("nama").HeaderText = "Nama"
            dgvPemesanan.Columns("jenis_kelamin").HeaderText = "Jenis Kelamin"
            dgvPemesanan.Columns("telepon").HeaderText = "Telepon"
            dgvPemesanan.Columns("alamat").HeaderText = "Alamat"
            dgvPemesanan.Columns("alamat_acara").HeaderText = "Alamat Acara"
            dgvPemesanan.Columns("paket").HeaderText = "Paket"
            dgvPemesanan.Columns("deskripsi_acara").HeaderText = "Deskripsi"
            dgvPemesanan.Columns("bukti_pembayaran").HeaderText = "Bukti Pembayaran"
            dgvPemesanan.Columns("status").HeaderText = "Status"
            dgvPemesanan.Columns("tanggal_pemesanan").HeaderText = "Tanggal Pemesanan"

            ' Set lebar kolom
            dgvPemesanan.Columns("id").Width = 50
            dgvPemesanan.Columns("nama").Width = 150
            dgvPemesanan.Columns("telepon").Width = 120
            dgvPemesanan.Columns("status").Width = 100
            dgvPemesanan.Columns("tanggal_pemesanan").Width = 150

            ' Sembunyikan kolom yang tidak perlu
            dgvPemesanan.Columns("bukti_pembayaran").Visible = False
        End If
    End Sub

    Private Sub ResetDetailNota()
        ' Reset info detail nota
        lblNamaCustomer.Text = "Nama: -"
        lblJenisKelamin.Text = "Jenis Kelamin: -"
        lblTelepon.Text = "Telepon: -"
        lblAlamat.Text = "Alamat: -"
        lblPaket.Text = "Paket: -"
        lblDeskripsi.Text = "Deskripsi: -"
        lblStatus.Text = "Status: -"
        lblTanggalPemesanan.Text = "Tanggal: -"

        ' Reset variabel data
        namaPemesan = ""
        jenisKelamin = ""
        telepon = ""
        alamat = ""
        alamatAcara = ""
        paket = ""
        deskripsi = ""
        status = ""
        tanggalPemesanan = ""

        ' Reset ID terpilih
        selectedId = -1
    End Sub

    Private Sub PrintNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data saat form dibuka
        LoadData()
    End Sub

    Private Sub dgvPemesanan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPemesanan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPemesanan.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id").Value)

            ' Simpan data untuk dicetak
            namaPemesan = row.Cells("nama").Value.ToString()
            jenisKelamin = row.Cells("jenis_kelamin").Value.ToString()
            telepon = row.Cells("telepon").Value.ToString()
            alamat = row.Cells("alamat").Value.ToString()
            alamatAcara = row.Cells("alamat_acara").Value.ToString()
            paket = row.Cells("paket").Value.ToString()

            ' Periksa apakah nilai deskripsi tidak DBNull
            If Not IsDBNull(row.Cells("deskripsi_acara").Value) Then
                deskripsi = row.Cells("deskripsi_acara").Value.ToString()
            Else
                deskripsi = "-"
            End If

            status = row.Cells("status").Value.ToString()
            tanggalPemesanan = Convert.ToDateTime(row.Cells("tanggal_pemesanan").Value).ToString("dd/MM/yyyy HH:mm:ss")

            ' Tampilkan di label
            lblNamaCustomer.Text = "Nama: " & namaPemesan
            lblJenisKelamin.Text = "Jenis Kelamin: " & jenisKelamin
            lblTelepon.Text = "Telepon: " & telepon
            lblAlamat.Text = "Alamat: " & alamat
            lblPaket.Text = "Paket: " & paket
            lblDeskripsi.Text = "Deskripsi: " & deskripsi
            lblStatus.Text = "Status: " & status
            lblTanggalPemesanan.Text = "Tanggal: " & tanggalPemesanan
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data pemesanan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Tampilkan preview cetak
        previewNota.Document = docPrintNota
        previewNota.ShowDialog()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub docPrintNota_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docPrintNota.PrintPage
        ' Pengaturan font
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim subtitleFont As New Font("Arial", 12, FontStyle.Bold)
        Dim normalFont As New Font("Arial", 10, FontStyle.Regular)
        Dim smallFont As New Font("Arial", 8, FontStyle.Regular)

        ' Pengaturan pen
        Dim blackPen As New Pen(Color.Black, 1)

        ' Posisi awal
        Dim startX As Integer = 50
        Dim startY As Integer = 50
        Dim offset As Integer = 20

        ' Header Nota
        e.Graphics.DrawString("SKYLINE STUDIO", titleFont, Brushes.Black, startX, startY)
        startY += 30
        e.Graphics.DrawString("Jl. Raya Bogor No. 123, Jakarta Timur", normalFont, Brushes.Black, startX, startY)
        startY += 20
        e.Graphics.DrawString("Telp: 021-12345678 | Email: info@skylinestudio.com", normalFont, Brushes.Black, startX, startY)
        startY += 20
        e.Graphics.DrawLine(blackPen, startX, startY, startX + 700, startY)
        startY += 20

        ' Judul Nota
        e.Graphics.DrawString("NOTA PEMESANAN", subtitleFont, Brushes.Black, startX, startY)
        startY += 20
        e.Graphics.DrawString($"No. Pemesanan: SKY-{selectedId}", normalFont, Brushes.Black, startX, startY)
        startY += 20
        e.Graphics.DrawString($"Tanggal: {tanggalPemesanan}", normalFont, Brushes.Black, startX, startY)
        startY += 30

        ' Informasi Pemesan
        e.Graphics.DrawString("DATA PEMESAN:", subtitleFont, Brushes.Black, startX, startY)
        startY += 25
        e.Graphics.DrawString($"Nama: {namaPemesan}", normalFont, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString($"Jenis Kelamin: {jenisKelamin}", normalFont, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString($"No. Telepon: {telepon}", normalFont, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString($"Alamat: {alamat}", normalFont, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString($"Alamat Acara: {alamatAcara}", normalFont, Brushes.Black, startX, startY)
        startY += 30

        ' Informasi Paket
        e.Graphics.DrawString("DETAIL PEMESANAN:", subtitleFont, Brushes.Black, startX, startY)
        startY += 25
        e.Graphics.DrawString($"Paket: {paket}", normalFont, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString($"Deskripsi Acara: {deskripsi}", normalFont, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString($"Status Pemesanan: {status}", normalFont, Brushes.Black, startX, startY)
        startY += 40

        ' Harga paket
        Dim harga As String = "0"
        Select Case True
            Case paket.Contains("Rp 4.000.000")
                harga = "Rp 4.000.000"
            Case paket.Contains("Rp 2.500.000")
                harga = "Rp 2.500.000"
            Case paket.Contains("Rp 3.500.000")
                harga = "Rp 3.500.000"
            Case paket.Contains("Rp 1.500.000")
                harga = "Rp 1.500.000"
            Case Else
                harga = "Rp (sesuai kesepakatan)"
        End Select

        ' Tabel Harga
        e.Graphics.DrawString("RINCIAN BIAYA:", subtitleFont, Brushes.Black, startX, startY)
        startY += 25
        Dim tableX As Integer = startX
        Dim tableWidth As Integer = 500

        ' Header tabel
        e.Graphics.DrawLine(blackPen, tableX, startY, tableX + tableWidth, startY)
        startY += 2
        e.Graphics.DrawString("Deskripsi", normalFont, Brushes.Black, tableX + 10, startY)
        e.Graphics.DrawString("Harga", normalFont, Brushes.Black, tableX + 400, startY)
        startY += 20
        e.Graphics.DrawLine(blackPen, tableX, startY, tableX + tableWidth, startY)
        startY += 2

        ' Isi tabel
        e.Graphics.DrawString(paket, normalFont, Brushes.Black, tableX + 10, startY)
        e.Graphics.DrawString(harga, normalFont, Brushes.Black, tableX + 400, startY)
        startY += 20
        e.Graphics.DrawLine(blackPen, tableX, startY, tableX + tableWidth, startY)
        startY += 5
        e.Graphics.DrawString("Total", normalFont, Brushes.Black, tableX + 10, startY)
        e.Graphics.DrawString(harga, normalFont, Brushes.Black, tableX + 400, startY)
        startY += 20
        e.Graphics.DrawLine(blackPen, tableX, startY, tableX + tableWidth, startY)
        startY += 40

        ' Footer
        e.Graphics.DrawString("Terima kasih telah mempercayakan momen berharga Anda kepada kami.", normalFont, Brushes.Black, startX, startY)
        startY += 20
        e.Graphics.DrawString("Skyline Studio - Menangkap Setiap Momen Berharga Anda", smallFont, Brushes.Black, startX, startY)
        startY += 40

        ' Tanda tangan
        e.Graphics.DrawString("Hormat kami,", normalFont, Brushes.Black, startX, startY)
        startY += 60
        e.Graphics.DrawLine(blackPen, startX, startY, startX + 150, startY)
        startY += 5
        e.Graphics.DrawString("Skyline Studio", normalFont, Brushes.Black, startX, startY)
    End Sub

End Class