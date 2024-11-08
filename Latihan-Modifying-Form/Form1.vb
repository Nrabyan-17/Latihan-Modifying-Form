Imports MySql.Data.MySqlClient
Public Class Form1

    Dim conn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader

    'Function untuk koneksi Database'
    Sub koneksi()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; userid=root; password=''; database=db_latihan"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("Koneksi Berhasil...")
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal..." & ex.Message)
        End Try
    End Sub

    Sub totalHarga()
        If Not String.IsNullOrEmpty(txHargaJual.Text) And Not String.IsNullOrEmpty(txJumlah.Text) Then
            ' Konversi harga dan jumlah ke integer
            Dim harga As Integer = Convert.ToInt32(txHargaJual.Text)
            Dim jumlah As Integer = Convert.ToInt32(txJumlah.Text)

            ' Hitung subtotal
            Dim subtotal As Integer = harga * jumlah
            txSubTotal.Text = subtotal.ToString()

            ' Hitung total jika perlu (misal menjumlahkan dengan total lainnya)
            Dim total As Integer = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                total += Convert.ToInt32(row.Cells("sub_total").Value)
            Next
            total = subtotal ' Tambahkan subtotal saat ini ke total
            txTotal.Text = total.ToString()
        Else
            txSubTotal.Clear()
            txTotal.Clear()
        End If
    End Sub

    Sub LoadDataGridView()
        Try
            Dim query As String = "SELECT * FROM tbl_penjualan_rinci"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet
            da.Fill(ds, "tbl_penjualan_rinci")
            DataGridView1.DataSource = ds.Tables("tbl_penjualan_rinci")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Sub IsiComboBox()
        Try
            'Isi dari tabel pelanggan'
            Dim query As String = "SELECT kode_pelanggan FROM tbl_pelanggan"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()
            cbPelanggan.Items.Clear()
            While dr.Read()
                cbPelanggan.Items.Add(dr("kode_pelanggan").ToString())
            End While
            dr.Close()

            'Isi dari tabel barang'
            Dim query1 As String = "SELECT Nama_Barang, Jenis FROM tblbarang"
            cmd = New MySqlCommand(query1, conn)
            dr = cmd.ExecuteReader()
            cbBarang.Items.Clear()
            While dr.Read()
                cbBarang.Items.Add(dr("Nama_Barang").ToString())
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call IsiComboBox()
        Call LoadDataGridView()
    End Sub

    'Function dari Combo Box Pelanggan'
    Private Sub cbPelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPelanggan.SelectedIndexChanged
        Try
            Dim selectedItem As String = cbPelanggan.SelectedItem.ToString()
            Dim query As String = "SELECT nama_pelanggan FROM tbl_pelanggan WHERE kode_pelanggan = @selectedItem"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add(New MySqlParameter("@selectedItem", selectedItem))
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txPelanggan.Text = dr("nama_pelanggan").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    'Function dari Combo Box Barang'
    Private Sub cbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBarang.SelectedIndexChanged
        Try
            Dim selectedItem As String = cbBarang.SelectedItem.ToString()
            Dim query As String = "SELECT Kode_Barang, Jenis, Harga_Beli, Harga_Jual FROM tblbarang WHERE Nama_Barang = @Kode_Barang"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add(New MySqlParameter("@Kode_Barang", selectedItem))
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txKodeBrg.Text = dr("Kode_Barang").ToString()
                txJenis.Text = dr("Jenis").ToString()
                txHargaJual.Text = dr("Harga_Jual").ToString()
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txJumlah_TextChanged(sender As Object, e As EventArgs) Handles txJumlah.TextChanged
        Call totalHarga()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            'Insert Data untuk tabel penjualan'
            Dim queryRinci = "INSERT INTO tbl_penjualan (faktur_penjualan, tgl_penjualan, kode_pelanggan, total) VALUES (@faktur_penjualan, @tgl_penjualan, @kode_pelanggan, @total)"
            cmd = New MySqlCommand(queryRinci, conn)
            cmd.Parameters.AddWithValue("@faktur_penjualan", txFaktur.Text)
            cmd.Parameters.AddWithValue("@tgl_penjualan", DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@kode_pelanggan", cbPelanggan.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@total", Convert.ToInt32(txTotal.Text))
            cmd.ExecuteNonQuery()

            'Insert Data untuk tabel penjualan rinci'
            Dim queryPenjualan As String = "INSERT INTO tbl_penjualan_rinci (faktur_penjualan, Kode_Barang , harga_jual, jumlah, sub_total, total) VALUES (@faktur_penjualan, @Kode_Barang, @harga_jual, @jumlah, @sub_total, @total)"
            cmd = New MySqlCommand(queryPenjualan, conn)
            cmd.Parameters.AddWithValue("@faktur_penjualan", txFaktur.Text)
            '  cmd.Parameters.AddWithValue("@kode_pelanggan", cbPelanggan.SelectedItem.ToString()) ''
            cmd.Parameters.AddWithValue("@Kode_Barang", txKodeBrg.Text)
            'cmd.Parameters.AddWithValue("@Nama_Barang", cbBarang.SelectedItem.ToString())'
            cmd.Parameters.AddWithValue("@harga_jual", txHargaJual.Text)
            cmd.Parameters.AddWithValue("@jumlah", Convert.ToInt16(txJumlah.Text))
            cmd.Parameters.AddWithValue("@sub_total", Convert.ToInt32(txSubTotal.Text))
            cmd.Parameters.AddWithValue("@total", Convert.ToInt32(txTotal.Text))
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil disimpan")
            Call LoadDataGridView()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
