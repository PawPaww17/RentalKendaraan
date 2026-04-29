List<Kendaraan> data_kendaraan = new List<Kendaraan>()
{
    new Kendaraan("Beat", 3000000, "P 4444 W", true),
    new Mobil("Jhonson", 15000000, "P 4444 W", true)
};

class Kendaraan
{
    protected string _namaKendaraan;
    protected double _hargaSewaPerHari;
    protected string _nomorPolisi;
    bool IsAvailable = true;

    public Kendaraan(string nama_kendaraan, double harga_sewa, string nomor_polisi, bool isAvailable)
    {
        _namaKendaraan = nama_kendaraan;
        _hargaSewaPerHari = harga_sewa;
        _nomorPolisi = nomor_polisi;
        IsAvailable = isAvailable;
    }
    public string Nama_Kendaraan
    {
        get { return _namaKendaraan; }
        set { _namaKendaraan = value; }
    }
    public double Harga_Sewa
    {
        get { return _hargaSewaPerHari; }
        set
        {
            if (value > 0)
            {
                _hargaSewaPerHari = value;
            }
            else
            {
                Console.WriteLine("Harga sewa harus lebih dari 0.");
            }
        }
    }
    public string Nomor_Polisi
    {
        get { return _nomorPolisi; }
    }
    public bool Is_Available
    {
        get { return IsAvailable; }
    }
    public void tampilkanInfo()
    {
        Console.WriteLine($"Nama Kendaraan: {_namaKendaraan}");
        Console.WriteLine($"Harga Sewa Per Hari: {_hargaSewaPerHari}");
        Console.WriteLine($"Nomer Polisi: {_nomorPolisi}");
        Console.WriteLine($"Ketersediaan: {(IsAvailable ? "Tersedia" : "Tidak Tersedia")}");
    }
    public void ubahStatus()
    {
        IsAvailable =!IsAvailable;
    }
    public virtual double hitungTotal(int jumlahHari)
    {
        return _hargaSewaPerHari * jumlahHari;
    }
}
class Mobil : Kendaraan
{
    private double _biayaAnsuransi;
    public Mobil(string nama_kendaraan, double harga_sewa, string nomor_polisi, bool is_available) : base(nama_kendaraan, harga_sewa, nomor_polisi, is_available)
    {
        _biayaAnsuransi = 50000;
    }
    public override double hitungTotal(int jumlahHari)
    {
        return base.hitungTotal(jumlahHari) + _biayaAnsuransi;
    }
}
class miniBuss : Kendaraan
{
    private double _biayaSopir;
    public miniBuss(string nama_kendaraan, double harga_sewa, string nomor_polisi, bool is_available) : base(nama_kendaraan, harga_sewa, nomor_polisi, is_available)
    {
        _biayaSopir = 100000;
    }
    public override double hitungTotal(int jumlahHari)
    {
        return base.hitungTotal(jumlahHari) + _biayaSopir;
    }
}

