using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		//Set input data here
		private const int N = 2;
		private const string S = "1K 1F 1A 2G 2D";

		private static List<String> reservedSeats = new List<string>();


		//main method
		static void Main(string[] args)
		{
			int families = 0;
			reservedSeats = CreateReserved(S);

			//iterates through each row and checks reservations
			for (int i = 1; i <= N; i++)
			{
				if (!reservedSeats.Contains(i.ToString() + "A") && !reservedSeats.Contains(i.ToString() + "B") && !reservedSeats.Contains(i.ToString() + "C"))
				{
					families++;
				}

				if (!reservedSeats.Contains(i.ToString() + "H") && !reservedSeats.Contains(i.ToString() + "J") && !reservedSeats.Contains(i.ToString() + "K"))
				{
					families++;
				}

				if (!reservedSeats.Contains(i.ToString() + "E") && !reservedSeats.Contains(i.ToString() + "F"))
				{
					if (!reservedSeats.Contains(i.ToString() + "D") || !reservedSeats.Contains(i.ToString() + "G"))
					{
						families++;
					}
				}

			}
			Console.WriteLine("Rows Available:");
			Console.WriteLine(N);
			Console.WriteLine("Reserved Seats:");
			Console.WriteLine(S);
			Console.WriteLine("Potential number of 3 member familes sitting together:");
			Console.WriteLine(families);
			Console.ReadKey();
		}

		public static List<String> CreateReserved(string reserved)
		{
			if (reserved == "")
			{
				reservedSeats.Add("");
				return reservedSeats;
			}

			string[] seats = reserved.Split(' ');
			foreach (string seat in seats)
			{
				reservedSeats.Add(seat);
			}
			return reservedSeats;
		}

	}
}
