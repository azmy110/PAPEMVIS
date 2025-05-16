Imports System.IO

Public Class Form1

    Dim pathBukti As String = "C:\Users\syhaf\Documents\AZMY\Visual Studio 2022\SKYLINEE\SKYLINEE\Bukti Pembayaran\"

    Private Sub FormPemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Paket
        cmbPaket.Items.Add("Wedding - Foto & Video (Rp 4.000.000)")
        cmbPaket.Items.Add("Wedding - Foto Only (Rp 2.500.000)")
        cmbPaket.Items.Add("Event - Dokumentasi Lengkap (Rp 3.500.000)")
        cmbPaket.Items.Add("Graduation - Foto Only (Rp 1.500.000)")
        cmbPaket.Items.Add("Others")
        txtDeskripsiAcara.Enabled = False
    End Sub

    Private Sub cmbPaket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaket.SelectedIndexChanged
        If cmbPaket.SelectedItem = "Others" Then
            txtDeskripsiAcara.Enabled = True
        Else
            txtDeskripsiAcara.Enabled = False
            txtDeskripsiAcara.Text = ""
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If openFile.ShowDialog() = DialogResult.OK Then
            pathBukti = openFile.FileName
            picBukti.Image = Image.FromFile(pathBukti)
        End If
    End Sub

    Private Sub btnLanjutkan_Click(sender As Object, e As EventArgs) Handles btnLanjutkann.Click
        ' Validasi input
        If txtNama.Text = "" OrElse txtTelepon.Text = "" OrElse txtAlamat.Text = "" OrElse cmbPaket.SelectedIndex = -1 Then
            MessageBox.Show("Harap isi semua data terlebih dahulu.")
            Exit Sub
        End If

        Dim jenisKelamin As String = ""
        If rbLaki.Checked Then
            jenisKelamin = "Laki-laki"
        ElseIf rbPerempuan.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Harap pilih jenis kelamin.")
            Exit Sub
        End If

        ' Kirim data ke Form2
        Dim frm2 As New Form2
        With frm2
            .lblNama.Text = txtNama.Text
            .lblJenisKelamin.Text = jenisKelamin
            .lblTelepon.Text = txtTelepon.Text
            .lblAlamat.Text = txtAlamat.Text
            .lblPaket.Text = If(cmbPaket.SelectedItem IsNot Nothing, cmbPaket.SelectedItem.ToString(), "")
            .lblDeskripsiAcara.Text = txtDeskripsiAcara.Text
            .picPreviewBukti.Image = picBukti.Image
            .PathBukti = pathBukti
            .Show()
        End With

        Me.Hide()
    End Sub

    Private Sub btnCekStatuss_Click(sender As Object, e As EventArgs) Handles btnCekStatuss.Click
        FormStatus.Show()
        Me.Hide()
    End Sub

    Private Sub picAdmin_Click(sender As Object, e As EventArgs) Handles picAdmin.Click
        FormLogin.Show()

    End Sub

End Class
