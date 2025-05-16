Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FormPanelAdmin
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim selectedId As Integer = -1

    ' String koneksi
    Dim connString As String = "server=localhost;user id=root;password=;database=db_skyline"

    ' Untuk menyimpan path bukti pembayaran lama
    Dim oldBuktiPath As String = ""
    ' Untuk menyimpan path bukti pembayaran baru jika diubah
    Dim newBuktiPath As String = ""

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

            ' Format tampilan kolom pada DataGridView
            FormatDataGridView()

            ' Reset form setelah load data
            ResetForm()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatDataGridView()
        ' Format tampilan kolom jika diperlukan
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

            ' Sembunyikan kolom bukti_pembayaran karena path file terlalu panjang
            dgvPemesanan.Columns("bukti_pembayaran").Visible = False
        End If
    End Sub

    Private Sub ResetForm()
        ' Reset form fields
        txtNama.Text = ""
        txtJenisKelamin.Text = ""
        txtTelepon.Text = ""
        txtAlamat.Text = ""
        txtPaket.Text = ""
        txtDeskripsi.Text = ""
        txtStatus.Text = ""

        ' Nonaktifkan semua fields
        SetEditMode(False)

        selectedId = -1
        picBukti.Image = Nothing
        oldBuktiPath = ""
        newBuktiPath = ""
    End Sub

    Private Sub SetEditMode(isEdit As Boolean)
        ' Mengatur apakah fields bisa diedit atau tidak
        txtNama.ReadOnly = Not isEdit
        txtJenisKelamin.Enabled = isEdit
        txtTelepon.ReadOnly = Not isEdit
        txtAlamat.ReadOnly = Not isEdit
        txtPaket.Enabled = Not isEdit
        txtDeskripsi.ReadOnly = Not isEdit
        txtStatus.Enabled = isEdit
        btnUploadBukti.Enabled = isEdit

        ' Tampilkan/sembunyikan tombol
        btnSave.Visible = isEdit
        btnCancelEditt.Visible = isEdit
        btnEdit.Visible = Not isEdit
    End Sub

    Private Sub FormPanelAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Status dengan pilihan yang sesuai database
        txtStatus.Items.Clear()
        txtStatus.Items.Add("Pending")
        txtStatus.Items.Add("Approved")

        ' Isi ComboBox Jenis Kelamin
        txtJenisKelamin.Items.Clear()
        txtJenisKelamin.Items.Add("Laki-Laki")
        txtJenisKelamin.Items.Add("Perempuan")

        ' Isi ComboBox Paket
        txtPaket.Items.Clear()
        txtPaket.Items.Add("Wedding - Foto & Video (Rp 4.000.000)")
        txtPaket.Items.Add("Wedding - Foto Only (Rp 2.500.000)")
        txtPaket.Items.Add("Event - Dokumentasi Lengkap (Rp 3.500.000)")
        txtPaket.Items.Add("Graduation - Foto Only (Rp 1.500.000)")
        txtPaket.Items.Add("Others")

        ' Nonaktifkan mode edit saat awal
        SetEditMode(False)

        ' Load data pemesanan
        LoadData()
    End Sub

    Private Sub dgvPemesanan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPemesanan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPemesanan.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id").Value)
            txtNama.Text = row.Cells("nama").Value.ToString()

            ' Set jenis kelamin
            txtJenisKelamin.Text = row.Cells("jenis_kelamin").Value.ToString()

            txtTelepon.Text = row.Cells("telepon").Value.ToString()
            txtAlamat.Text = row.Cells("alamat").Value.ToString()

            txtPaket.Text = row.Cells("paket").Value.ToString()

            ' Periksa apakah nilai deskripsi tidak DBNull
            If Not IsDBNull(row.Cells("deskripsi_acara").Value) Then
                txtDeskripsi.Text = row.Cells("deskripsi_acara").Value.ToString()
            Else
                txtDeskripsi.Text = ""
            End If

            txtStatus.Text = row.Cells("status").Value.ToString()

            ' Reset gambar bukti
            picBukti.Image = Nothing

            ' Simpan path bukti lama
            If Not IsDBNull(row.Cells("bukti_pembayaran").Value) Then
                oldBuktiPath = row.Cells("bukti_pembayaran").Value.ToString()
            Else
                oldBuktiPath = ""
            End If

            ' Reset path bukti baru
            newBuktiPath = ""

            ' Tampilkan bukti jika ada
            LihatBukti()
        End If
    End Sub

    Private Sub LihatBukti()
        If selectedId = -1 Or String.IsNullOrEmpty(oldBuktiPath) Then
            Return
        End If

        Try
            If IO.File.Exists(oldBuktiPath) Then
                picBukti.Image = Image.FromFile(oldBuktiPath)
                picBukti.SizeMode = PictureBoxSizeMode.Zoom
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLihatBukti_Click(sender As Object, e As EventArgs) Handles btnLihatBukti.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Koneksi()
            cmd = New MySqlCommand("SELECT bukti_pembayaran FROM pemesanan WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", selectedId)
            Dim buktiPath As Object = cmd.ExecuteScalar()
            conn.Close()

            If buktiPath IsNot Nothing AndAlso Not IsDBNull(buktiPath) AndAlso buktiPath.ToString().Trim() <> "" Then
                oldBuktiPath = buktiPath.ToString()

                If IO.File.Exists(oldBuktiPath) Then
                    picBukti.Image = Image.FromFile(oldBuktiPath)
                    picBukti.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    MessageBox.Show("File bukti tidak ditemukan di lokasi: " & oldBuktiPath,
                                   "File Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Bukti pembayaran tidak tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan bukti: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUploadBukti_Click(sender As Object, e As EventArgs) Handles btnUploadBukti.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If openFile.ShowDialog() = DialogResult.OK Then
            Try
                ' Simpan path bukti baru
                newBuktiPath = openFile.FileName

                ' Tampilkan gambar baru
                picBukti.Image = Image.FromFile(newBuktiPath)
                picBukti.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
                MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Aktifkan mode edit
        SetEditMode(True)
    End Sub

    Private Sub btnCancelEditt_Click(sender As Object, e As EventArgs) Handles btnCancelEditt.Click
        ' Nonaktifkan mode edit
        SetEditMode(False)

        ' Jika ada data yang dipilih, tampilkan kembali data asli
        If selectedId <> -1 Then
            Try
                dgvPemesanan_CellClick(dgvPemesanan, New DataGridViewCellEventArgs(0, dgvPemesanan.CurrentRow.Index))
            Catch ex As Exception
                ' Jika gagal reload, reset form
                ResetForm()
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi input wajib
        If txtNama.Text.Trim() = "" Or txtTelepon.Text.Trim() = "" Or
           txtJenisKelamin.Text.Trim() = "" Or txtStatus.Text.Trim() = "" Then
            MessageBox.Show("Nama, Telepon, Jenis Kelamin, dan Status tidak boleh kosong.",
                          "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Koneksi()

            ' Proses bukti pembayaran jika diganti
            Dim finalBuktiPath As String = oldBuktiPath
            If Not String.IsNullOrEmpty(newBuktiPath) Then
                ' Buat folder jika belum ada
                Dim folderPath As String = "C:\Skyline\BuktiPembayaran\"
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                ' Buat nama file unik
                Dim fileExt As String = Path.GetExtension(newBuktiPath)
                Dim newFileName As String = "bukti_" & DateTime.Now.ToString("yyyyMMddHHmmss") & fileExt
                finalBuktiPath = folderPath & newFileName

                ' Salin file ke folder tujuan
                File.Copy(newBuktiPath, finalBuktiPath, True)
            End If

            ' Update data ke database
            cmd = New MySqlCommand("UPDATE pemesanan SET nama=@nama, jenis_kelamin=@jenis_kelamin, " &
                                 "telepon=@telepon, alamat=@alamat, alamat_acara=@alamat_acara, " &
                                 "paket=@paket, deskripsi_acara=@deskripsi, " &
                                 "bukti_pembayaran=@bukti, status=@status " &
                                 "WHERE id=@id", conn)

            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
            cmd.Parameters.AddWithValue("@jenis_kelamin", txtJenisKelamin.Text.Trim())
            cmd.Parameters.AddWithValue("@telepon", txtTelepon.Text.Trim())
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim())
            cmd.Parameters.AddWithValue("@alamat_acara", txtAlamat.Text.Trim()) ' Menggunakan alamat yang sama untuk alamat acara
            cmd.Parameters.AddWithValue("@paket", txtPaket.Text.Trim())
            cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text.Trim())
            cmd.Parameters.AddWithValue("@bukti", finalBuktiPath)
            cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim())
            cmd.Parameters.AddWithValue("@id", selectedId)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Nonaktifkan mode edit
            SetEditMode(False)

            ' Refresh data
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Gagal update data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi = MessageBox.Show("Yakin akan menghapus data ini? Data yang dihapus tidak dapat dikembalikan.",
                                       "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Try
                ' Hapus file bukti pembayaran terlebih dahulu jika ada
                Koneksi()
                cmd = New MySqlCommand("SELECT bukti_pembayaran FROM pemesanan WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", selectedId)
                Dim buktiPath As Object = cmd.ExecuteScalar()

                ' Hapus data dari database
                cmd = New MySqlCommand("DELETE FROM pemesanan WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", selectedId)
                cmd.ExecuteNonQuery()
                conn.Close()

                ' Hapus file bukti jika ada
                If buktiPath IsNot Nothing AndAlso Not IsDBNull(buktiPath) AndAlso buktiPath.ToString().Trim() <> "" Then
                    If IO.File.Exists(buktiPath.ToString()) Then
                        ' Coba hapus file
                        Try
                            IO.File.Delete(buktiPath.ToString())
                        Catch ex As Exception
                            ' Lewati error penghapusan file
                        End Try
                    End If
                End If

                MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Gagal hapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim konfirmasi = MessageBox.Show("Yakin ingin logout?", "Konfirmasi Logout",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub
    Private Sub PrintNotavbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintNotavbToolStripMenuItem.Click
        ' Buka form PrintNota
        Dim PrintNota As New PrintNota()
        PrintNota.ShowDialog()
    End Sub
End Class