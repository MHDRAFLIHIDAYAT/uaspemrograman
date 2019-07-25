using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                TampilMenu();
                
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            int jmlpiutang;
            string id, namacust;

            Console.WriteLine("Tambah Data");
            Console.WriteLine();

            Console.Write("Kode Customer : ");
            id = Console.ReadLine();
            Console.Write("Nama Customer : ");
            namacust = Console.ReadLine();
            Console.Write("Total Piutang : ");
            jmlpiutang = int.Parse(Console.ReadLine());

            Customer cust = new Customer();
            cust.id = id;
            cust.namaCustomer = namacust;
            cust.totpiutang = jmlpiutang;

            daftarCustomer.Add(cust);

            Console.WriteLine("\nData berhasil ditambahkan");

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data");
            Console.WriteLine();

            Console.Write("Masukkan No Customer : ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            daftarCustomer.RemoveAt(pilih - 1);

            Console.WriteLine("\nData berhasil dihapus");

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            Console.WriteLine("Data Customer");
            Console.WriteLine();

            Console.WriteLine("No.\tKode Customer\tNama Customer\tTotal Piutang");

            int i = 1;
            foreach (Customer custo in daftarCustomer)
            {
                Console.WriteLine("{0} \t{1} \t\t{2} \t\t{3}", i, custo.id, custo.namaCustomer, custo.totpiutang);
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
