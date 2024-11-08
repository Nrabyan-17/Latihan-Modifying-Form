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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPelanggan = New System.Windows.Forms.ComboBox()
        Me.txPelanggan = New System.Windows.Forms.TextBox()
        Me.cbBarang = New System.Windows.Forms.ComboBox()
        Me.txKodeBrg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txJenis = New System.Windows.Forms.TextBox()
        Me.txJumlah = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txSubTotal = New System.Windows.Forms.TextBox()
        Me.txTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txHargaJual = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txFaktur = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pelanggan:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pelanggan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Barang:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Faktur Penjualan:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(270, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Barang:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jenis:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jumlah Beli:"
        '
        'cbPelanggan
        '
        Me.cbPelanggan.FormattingEnabled = True
        Me.cbPelanggan.Location = New System.Drawing.Point(132, 41)
        Me.cbPelanggan.Name = "cbPelanggan"
        Me.cbPelanggan.Size = New System.Drawing.Size(100, 21)
        Me.cbPelanggan.TabIndex = 7
        '
        'txPelanggan
        '
        Me.txPelanggan.Location = New System.Drawing.Point(132, 81)
        Me.txPelanggan.Name = "txPelanggan"
        Me.txPelanggan.Size = New System.Drawing.Size(100, 20)
        Me.txPelanggan.TabIndex = 8
        '
        'cbBarang
        '
        Me.cbBarang.FormattingEnabled = True
        Me.cbBarang.Location = New System.Drawing.Point(132, 114)
        Me.cbBarang.Name = "cbBarang"
        Me.cbBarang.Size = New System.Drawing.Size(100, 21)
        Me.cbBarang.TabIndex = 9
        '
        'txKodeBrg
        '
        Me.txKodeBrg.Location = New System.Drawing.Point(366, 76)
        Me.txKodeBrg.Name = "txKodeBrg"
        Me.txKodeBrg.Size = New System.Drawing.Size(130, 20)
        Me.txKodeBrg.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(524, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tanggal:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(527, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'txJenis
        '
        Me.txJenis.Location = New System.Drawing.Point(366, 111)
        Me.txJenis.Name = "txJenis"
        Me.txJenis.Size = New System.Drawing.Size(130, 20)
        Me.txJenis.TabIndex = 14
        '
        'txJumlah
        '
        Me.txJumlah.Location = New System.Drawing.Point(366, 142)
        Me.txJumlah.Name = "txJumlah"
        Me.txJumlah.Size = New System.Drawing.Size(130, 20)
        Me.txJumlah.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(79, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(639, 163)
        Me.DataGridView1.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 39)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(257, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Sub Total:"
        '
        'txSubTotal
        '
        Me.txSubTotal.Location = New System.Drawing.Point(328, 362)
        Me.txSubTotal.Name = "txSubTotal"
        Me.txSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txSubTotal.TabIndex = 21
        '
        'txTotal
        '
        Me.txTotal.Location = New System.Drawing.Point(328, 400)
        Me.txTotal.Name = "txTotal"
        Me.txTotal.Size = New System.Drawing.Size(100, 20)
        Me.txTotal.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(257, 400)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Total:"
        '
        'txHargaJual
        '
        Me.txHargaJual.Location = New System.Drawing.Point(566, 360)
        Me.txHargaJual.Name = "txHargaJual"
        Me.txHargaJual.Size = New System.Drawing.Size(100, 20)
        Me.txHargaJual.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(484, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(484, 365)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Harga Jual:"
        '
        'txFaktur
        '
        Me.txFaktur.Location = New System.Drawing.Point(366, 44)
        Me.txFaktur.Name = "txFaktur"
        Me.txFaktur.Size = New System.Drawing.Size(130, 20)
        Me.txFaktur.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txFaktur)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txHargaJual)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txSubTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txJumlah)
        Me.Controls.Add(Me.txJenis)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txKodeBrg)
        Me.Controls.Add(Me.cbBarang)
        Me.Controls.Add(Me.txPelanggan)
        Me.Controls.Add(Me.cbPelanggan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbPelanggan As ComboBox
    Friend WithEvents txPelanggan As TextBox
    Friend WithEvents cbBarang As ComboBox
    Friend WithEvents txKodeBrg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txJenis As TextBox
    Friend WithEvents txJumlah As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txSubTotal As TextBox
    Friend WithEvents txTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txHargaJual As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txFaktur As TextBox
End Class
