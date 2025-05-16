Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private connString As String = "server=localhost;userid=root;password=;database=db_skyline"
    ' Deklarasi variable untuk status password
    Private showPassword As Boolean = False

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPasswordd.Text.Trim() ' Perbaikan nama variable

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM admin WHERE username=@username AND password=@password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If result > 0 Then
                        MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        Dim adminPanel As New FormPanelAdmin()
                        adminPanel.Show()
                    Else
                        MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error koneksi database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set password secara default tersembunyi saat form dimuat
        txtPasswordd.UseSystemPasswordChar = True

        ' Set icon awal untuk tombol show password
        btnShowPassword.Image = My.Resources.eye_closed
    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        ' Toggle status visibility password
        showPassword = Not showPassword

        ' Ubah UseSystemPasswordChar berdasarkan status
        txtPasswordd.UseSystemPasswordChar = Not showPassword

        ' Ganti gambar mata berdasarkan status
        If showPassword Then
            btnShowPassword.Image = My.Resources.eye_open
        Else
            btnShowPassword.Image = My.Resources.eye_closed
        End If
    End Sub
End Class