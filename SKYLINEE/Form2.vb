Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2
    Public Property PathBukti As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilan data yang diterima dari Form1 sudah dihandle di Form1.vb
        ' Tidak perlu isi ulang data di sini karena sudah ditetapkan oleh form sebelumnya
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Try
            Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_skyline")
            conn.Open()

            ' Ekstrak jenis kelamin dari labelnya
            Dim jenisKelamin As String = lblJenisKelamin.Text

            ' Simpan bukti pembayaran jika ada
            Dim namaBukti As String = ""
            If Not String.IsNullOrEmpty(PathBukti) AndAlso File.Exists(PathBukti) Then
                ' Buat folder jika belum ada
                Dim folderPath As String = "C:\Skyline\BuktiPembayaran\"
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                ' Buat nama file unik
                namaBukti = "bukti_" & DateTime.Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(PathBukti)

                ' Salin file ke folder tujuan
                File.Copy(PathBukti, folderPath & namaBukti, True)
                namaBukti = folderPath & namaBukti
            End If

            ' Query yang sesuai dengan struktur tabel di database
            Dim query As String = "INSERT INTO pemesanan (nama, jenis_kelamin, telepon, alamat, alamat_acara, paket, deskripsi_acara, bukti_pembayaran, status) " &
                                 "VALUES (@nama, @jenis_kelamin, @telepon, @alamat, @alamat_acara, @paket, @deskripsi_acara, @bukti_pembayaran, 'Pending')"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", lblNama.Text)
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin)
            cmd.Parameters.AddWithValue("@telepon", lblTelepon.Text)
            cmd.Parameters.AddWithValue("@alamat", lblAlamat.Text)
            cmd.Parameters.AddWithValue("@alamat_acara", lblAlamat.Text) ' Tambahkan textbox untuk alamat acara
            cmd.Parameters.AddWithValue("@paket", lblPaket.Text)
            cmd.Parameters.AddWithValue("@deskripsi_acara", lblDeskripsiAcara.Text)
            cmd.Parameters.AddWithValue("@bukti_pembayaran", namaBukti)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Pemesanan berhasil dikirim!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
            Me.Hide()
            Form1.Show()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Tambahkan tombol back ke Form1
    Private Sub btnBackk_Click(sender As Object, e As EventArgs) Handles btnBackk.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class