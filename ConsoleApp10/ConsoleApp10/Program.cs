using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{
			int branch = tree();
			int wood = log();
			recounter(wood, branch);


		}

		static int log()
		{
			Console.WriteLine("Enter the width of Log between 4 and 6.");
			string width = Console.ReadLine();
			Int32.TryParse(width, out int lw);
			if (lw > 6 || lw < 4)
			{
				Console.WriteLine("You have entered invalid value.");
				return log();
			}
			else
			{
				return lw;
			}

		}

		static int tree()
		{
			Console.WriteLine("Enter the widht of tree between 5 and 7.");
			string width = Console.ReadLine();
			Int32.TryParse(width, out int tr);
			if (tr > 7 || tr < 5)
			{
				Console.WriteLine("You have entered invalid value.");
				return tree();
			}
			else
			{
				return tr;
			}
		}

		static void recounter(int wood, int branch)
		{
			int j = 1;
			int fullwidth = wood + branch;
			int triangle = branch;
			int height = 1;
			int kmen = wood;
			int vetev = branch;
			int zuzeni = vetev;
			Console.SetCursorPosition(((((Console.WindowWidth - 1) / 2) - (wood / 2))+1), (Console.WindowHeight - 1));
			log(wood);
			Reset:
			if (wood != 0)
			{
				for (int i = vetev - 1; i >= 0; i--)
				{
					Console.SetCursorPosition((((Console.WindowWidth - 1) / 2) - ((kmen / 2) + triangle)), ((Console.WindowHeight - 1) - height));
					triangle--;
					star();
					slash(zuzeni);
					log(kmen);
					rslash(zuzeni);
					star();
					zuzeni--;
					height++;
				}
			}
			else
			{
				goto end;
			}
			zuzeni = branch - j;
			vetev = branch - j;
			j++;
			kmen--;
			triangle = vetev;
			goto Reset;
			end:
			Console.ReadLine();
		}

		static void star()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("*");
		}

		static void slash(int count)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			for (int i = 1; i <= count; i++)
			{
				Console.Write("/");
			}

		}

		static void rslash(int count)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			for (int i = 1; i <= count; i++)
			{
				Console.Write(@"\");
			}
		}

		static void log(int count)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			for (int i = 1; i <= count; i++)
			{
				Console.Write("|");

			}
		}
	}
}
