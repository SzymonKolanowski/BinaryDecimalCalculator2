using System;

namespace KonwersjaBinarno_Dziesiętna
{
	

	
	class Program
	{
		//private static int Maks = 10;
		private static String pattern = "0123456789";

		public static String convertTo(int n, int newBase)
		{
			String result = "";

			//base is too big or too small
			//if ((newBase > Maks) || (newBase < 2))
			//	return null;

			//n is equal to 0, do not process, return "0"
			//if (n == 0)
			//	return "0";

			//process until n > 0
			while (n > 0)
			{
				result = n % newBase + result;
				n /= newBase;
			}

			return result;
		}

		private static int valueOf(char x, int baseOfX)
		{
			for (int i = 0; i < baseOfX; i++)
			{
				if (x == pattern[i])
				{
					return i;
				}
			}
			return -1;
		}

		public static int convertFrom(string n, int baseOfN)
		{
			int i, x;
			int p = 1;
			int result = 0;

			//base is too big or too small
			//if ((baseOfN > Maks) || (baseOfN < 2))
			//	return 0;

			//n = n.ToUpper();

			for (i = n.Length - 1; i >= 0; i--)
			{
				x = valueOf(n[i], baseOfN);
				if (x < 0)
				{
					return 0;
				}
				result += (x * p);
				p *= baseOfN;
			}

			return result;
		}


		static void Main(string[] args)
		{

			

			Console.WriteLine("podaj liczbę dziesiętną");
			string text = Console.ReadLine();
			int liczba = int.Parse(text);

			Console.WriteLine(liczba +  " w systemie dwójkowym to " + convertTo(liczba, 2));

			Console.WriteLine("podaj liczbę dbinarną");
			string text2 = Console.ReadLine();
			//int liczba2 = int.Parse(text2);

			Console.WriteLine(text2 + " w systemie dziewsiątkowym to " + convertFrom(text2, 2));

			

		}
	}
}
