using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace consoleApp3
{
	class Program
	{
		private static void Main(string[] args)
		{
			string A = "Name";
			string B = "last Name";
			string C = "Age";
			string D = "Sex";
			string E = "PESEL Number";
			string F = "employee number";
			Console.WriteLine(A);
			Console.WriteLine(B);
			Console.WriteLine(C);
			Console.WriteLine(D);
			Console.WriteLine(E);
			Console.WriteLine(F);
			string choice = Console.ReadLine();
			Console.WriteLine($"You have chosen option number");
			int chosenOption = 0;
			Int32.TryParse(choice, out chosenOption);
			char a = ('1');
			char b = ('2');
			char c = ('3');
			Console.WriteLine(c);
			Console.WriteLine(b);
			Console.WriteLine(a);
		    int y = 10;
			string x = "szkoła dotneta";
			decimal h=12,5;
			Console.WriteLine(y);
			Console.WriteLine(x);
			Console.WriteLine(h);
			string g = "name";
			string i = "last name";
			string j = "Age";
			string k = "sex";
			string l = "Pesel number";
			string m = "email address";
			string n = "growth";
			string o = "libra";
			string p = "telephone number";
			string choice2 = Console.ReadLine();
			string g =Console.ReadLine();
			string i = Console.ReadLine();
			string j = Console.ReadLine();
			string k = Console.ReadLine();
			string l = Console.ReadLine();
			string m = Console.ReadLine();
			string n = Console.ReadLine();
			string o = Console.ReadLine();
			string p = Console.ReadLine();
			Int32.TryParse(choice2, out chosenOption);
		}
	}
}	