using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projeksayur
{
    public class Sayur
    {
        public int idProduk { get; private set; }
        public string namaProduk { get; set; }
        public string Deskripsi { get; set; }   
        public int Harga { get; set; }
        public int StokProduk { get; set; } 
        public byte[] GambarProduk { get; set; }

        //construktor
        public Sayur(int idproduk, string namaproduk, string deskripsi, int harga, int stokProduk, byte[] gambarproduk = null)
        {
            idProduk = idproduk;
            namaProduk = namaproduk;
            Deskripsi = deskripsi;
            Harga = harga;
            StokProduk = stokProduk;
            GambarProduk = gambarproduk;
        }

        //method untuk menampilkan informasi produk
        public virtual void TampilkanInfoProduk()
        {
            Console.WriteLine($"Id Produk: {idProduk}");
            Console.WriteLine($"nama produk: {namaProduk}");
            Console.WriteLine($"Deskripsi :{Deskripsi}");
            Console.WriteLine($"Harga :{Harga}");
            Console.WriteLine($"stok produk: {StokProduk}");
            Console.WriteLine(GambarProduk != null ? "Gambar: Tersedia" : "Gambar: Tidak tersedia");
        }

        //method untuk mengurangi stok
        public bool KurangiStok(int jumlah)
        {
            if (StokProduk >= jumlah)
            {
                StokProduk -= jumlah;
                Console.WriteLine($"Stok produk {namaProduk} berhasil dikurangi sebanyak {jumlah}. ");
                return true;
            }
            else
            {
                Console.WriteLine("Stok tidak mencukupi");
                return false;
            }
        }
    }

    //class turunan sayur hijau
    public class SayurHijau : Sayur
    {
        //construktor untuk sayur hijau
        public SayurHijau(int idproduk, string namaproduk, string deskripsi, int harga, int stokproduk, byte[] gambarproduk = null)
            : base(idproduk, namaproduk, deskripsi, harga, stokproduk, gambarproduk)
        {
            
        }

        //override method untuk menampilkan informasi sayur hijau
        public override void TampilkanInfoProduk()
        {
            base.TampilkanInfoProduk();
            Console.WriteLine("Kategori: Sayur Hijau");
        }
    }

    //class turunan untuk sayur kuning
    public class SayurKuning : Sayur
    {
        //constructor untuk sayur kuning
        public SayurKuning(int idproduk, string namaproduk, string deskripsi, int harga, int stokproduk, byte[] gambarproduk = null)
            : base(idproduk, namaproduk, deskripsi, harga, stokproduk, gambarproduk)
        {
        }
        //override method untuk menampilkan informasi sayur kuning
        public override void TampilkanInfoProduk()
        {
            base.TampilkanInfoProduk();
            Console.WriteLine("Kategori: Sayur Kuning");
        }
    }

    //main program
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek sayurhijau
            SayurHijau bayam = new SayurHijau(1, "Bayam", "Sayur hijau", 3000, 50);
            bayam.TampilkanInfoProduk();
            Console.WriteLine();

            //membuat objek sayurkuning
            SayurKuning wortel = new SayurKuning(2, "wortel", "sayur kuning", 5000, 30);
            wortel.TampilkanInfoProduk();
        }
    }
}
