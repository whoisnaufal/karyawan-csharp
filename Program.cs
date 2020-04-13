using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2643
{
	class Program
	{
		static void Main(string[] args)
		{
			Karyawan karyawan1 = new Karyawan(1,"190302123", "Naufal", 3000000);
			Karyawan karyawan2 = new Karyawan(2,"190302124", "Joni", 2000000);

			header1();
			CetakGaji(karyawan1);
			CetakGaji(karyawan2);

			header2();
			NaikGaji(karyawan1);
			NaikGaji(karyawan2);

			Console.ReadKey();
		}

		static void CetakGaji(Karyawan kry)
		{
			Console.WriteLine(kry.No +". "+ kry.Nik + "\t" + kry.Nama + "\t" + kry.GajiBulanan);
		}

		static void NaikGaji(Karyawan kry)
		{
			double kenaikan;
			kenaikan = kry.GajiBulanan * 0.1;
			kry.GajiBulanan = kry.GajiBulanan + kenaikan;
			Console.WriteLine(kry.No + ". " + kry.Nik + "\t" + kry.Nama + "\t" + kry.GajiBulanan);
		}

		static void header1()
		{
			Console.WriteLine("No Nik/Nama\tGaji Bulanan");
			Console.WriteLine("------------------------------");
		}

		static void header2()
		{
			Console.WriteLine("\nKenaikan Gaji 10%");
			Console.WriteLine("No Nik/Nama\tGaji Bulanan");
			Console.WriteLine("------------------------------");
		}
	}
}
