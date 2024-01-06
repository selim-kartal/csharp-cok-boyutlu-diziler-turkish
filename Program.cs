namespace C__cok_boyutlu_diziler_alistirma
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Matris bilgileri oluşturma
			Console.Title = "Diziler";
			Console.ForegroundColor = ConsoleColor.White;
			int satir, sutun;
			Console.Write("Matrislerin satır sayısını girin: ");
			satir = Convert.ToInt32(Console.ReadLine());
			Console.Write("Matrislerin sütun sayısını girin: ");
			sutun = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Red;

			// Birinci matris değerleri oluşturma
			Console.WriteLine("Birinci matris değerleri girin");
			Console.ForegroundColor = ConsoleColor.White;
			int[,] dizi = new int[satir, sutun];
			for (int i = 0; i < satir; i++)
			{
				for (int j = 0; j < sutun; j++)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write($"({i} , {j}) matris değerini giriniz: ");
					Console.ForegroundColor = ConsoleColor.White;
					dizi[i, j] = Convert.ToInt32(Console.ReadLine());
				}
				Console.WriteLine();
			}

			// İkinci matris değerlerini oluşturma
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("İkinci matris değerleri girin");
			Console.ForegroundColor = ConsoleColor.White;
			int[,] dizi_ = new int[satir, sutun];
			for (int k = 0; k < satir; k++)
			{
				for (int l = 0; l < sutun; l++)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write($"({k} , {l}) matris değerini giriniz: ");
					Console.ForegroundColor = ConsoleColor.White;
					dizi_[k, l] = Convert.ToInt32(Console.ReadLine());
				}
				Console.WriteLine();
			}

			// Birinci matris çıktısı
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Birinci matris çıktısı;");
			Console.ForegroundColor = ConsoleColor.White;
			for (int k = 0; k < satir; k++)
			{
				for (int l = 0; l < sutun; l++)
				{
					Console.Write($"{dizi[k, l]} ");
				}
				Console.WriteLine();
			}

			// Birinci matris transpozesi
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Birinci matris transpozesi;");
			Console.ForegroundColor = ConsoleColor.White;
			for (int k = 0; k < sutun; k++)
			{
				for (int l = 0; l < satir; l++)
				{
					Console.Write($"{dizi[l, k]} ");
				}
				Console.WriteLine();
			}

			// İkinci matris çıktısı
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("İkinci matris çıktısı;");
			Console.ForegroundColor = ConsoleColor.White;
			for (int q = 0; q < satir; q++)
			{
				for (int r = 0; r < sutun; r++)
				{
					Console.Write($"{dizi_[q, r]} ");
				}
				Console.WriteLine();
			}

			// İkinci matris transpozesi
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("İkinci matris transpozesi;");
			Console.ForegroundColor = ConsoleColor.White;
			for (int q = 0; q < sutun; q++)
			{
				for (int r = 0; r < satir; r++)
				{
					Console.Write($"{dizi_[r, q]} ");
				}
				Console.WriteLine();
			}

			// Toplam matrisi çıktısı
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Toplam matrisi çıktısı;");
			Console.ForegroundColor = ConsoleColor.White;
			int[,] dizi_toplam = new int[satir, sutun];
			for (int a = 0; a < satir; a++)
			{
				for (int b = 0; b < sutun; b++)
				{
					dizi_toplam[a, b] = dizi[a, b] + dizi_[a, b];
				}
			}
			for (int a = 0; a < satir; a++)
			{
				for (int b = 0; b < sutun; b++)
				{
					Console.Write(dizi_toplam[a, b] + " ");
				}
				Console.WriteLine();
			}

			// Çarpım matrisi çıktısı
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Çarpım matrisi çıktısı;");
			Console.ForegroundColor = ConsoleColor.White;
			int[,] dizi_carpim = new int[satir, sutun];
			for (int x = 0; x < satir; x++)
			{
				for (int y = 0; y < sutun; y++)
				{
					dizi_carpim[x, y] = dizi[x, y] * dizi_[x, y];
				}
			}
			for (int x = 0; x < satir; x++)
			{
				for (int y = 0; y < sutun; y++)
				{
					Console.Write(dizi_carpim[x, y] + " ");
				}
				Console.WriteLine();
			}
			Console.Read();
		}
	}
}