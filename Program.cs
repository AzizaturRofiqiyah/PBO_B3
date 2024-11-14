// See https://aka.ms/new-console-template for more information


using System;

public interface ILaukPauk
{
    int ID_Produk { get; }
    string NamaProduk { get; set; }
    string Deskripsi { get; set; }
    int Harga { get; set; }
    int StokProduk { get; set; }

    void TampilkanInformasiProduk();
    void PerbaruiStok(int jumlah);
    int Transaksi(int jumlah);
}

public class Daging : ILaukPauk
{
    public int ID_Produk { get; private set; }
    public string NamaProduk { get; set; }
    public string Deskripsi { get; set; }
    public int Harga { get; set; }
    public int StokProduk { get; set; }
    private string Jenis { get; } = "Daging";

    public Daging(int idProduk, string namaProduk, string deskripsi, int harga, int stokProduk)
    {
        ID_Produk = idProduk;
        NamaProduk = namaProduk;
        Deskripsi = deskripsi;
        Harga = harga;
        StokProduk = stokProduk;
    }
    public void TampilkanInformasiProduk()
    {
        Console.WriteLine($"ID Produk:{ID_Produk}");
        Console.WriteLine($"Nama Produk:{NamaProduk}");
        Console.WriteLine($"Deskripsi: {Deskripsi}");
        Console.WriteLine($"Harga: {Harga}");
        Console.WriteLine($"Stok: {StokProduk}");
        Console.WriteLine($"Jenis: {Jenis}");
        Console.WriteLine("-------------------------------");

    }

    public void PerbaruiStok(int jumlah)
    {
        StokProduk = Math.Max(StokProduk + jumlah, 0);
        Console.WriteLine($"Stok diperbarui, stok saat ini:{StokProduk}");
    }

    public int Transaksi(int jumlah)
    {
        if (jumlah > 0 && jumlah <= StokProduk)
        {
            int totalHarga = jumlah * Harga;
            StokProduk -= jumlah;
            Console.WriteLine($"Transaksi berhasil, dengan total harga: Rp{totalHarga}");
            Console.WriteLine($"Sisa stok : {StokProduk}");
            return totalHarga;
        }
        Console.WriteLine("Jumlah stok tidak mencukupi");
        return 0;

    }

}


public class Tahu : ILaukPauk
{

}
