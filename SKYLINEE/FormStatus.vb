Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormStatus

    Dim conn As MySqlConnection
    Dim connString As String = "server=localhost;userid=root;password=;database=db_skyline"

    Private Sub BukaKoneksi()
        conn = New MySqlConnection(connString)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpHasil.Visible = False 'sembunyikan hasil saat awal form load
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCariNama.Text.Trim() = "" Then
            MessageBox.Show("Masukkan nama terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()
            Dim query As String = "SELECT * FROM pemesanan WHERE nama = @nama"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", txtCariNama.Text.Trim())

            Dim rd As MySqlDataReader = cmd.ExecuteReader()
            If rd.Read() Then
                lblNama.Text = "Nama: " & rd("nama").ToString()
                lblTelepon.Text = "Telepon: " & rd("telepon").ToString()
                lblPaket.Text = "Paket: " & rd("paket").ToString()
                lblStatus.Text = "Status: " & rd("status").ToString()

                grpHasil.Visible = True
            Else
                MessageBox.Show("Nama tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                grpHasil.Visible = False
            End If
            rd.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal cek status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub grpHasil_Enter(sender As Object, e As EventArgs) Handles grpHasil.Enter

    End Sub
End Class
