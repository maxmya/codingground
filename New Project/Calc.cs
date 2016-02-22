using System;

namespace Calc
{
	class MainClass
	{
		static void Main ()
		{
			
			while (true) {
				Console.Write ("1-add 2-substrac 3-multiply 4-devide 5-num1 power num2 6-quit\n");
				string stringop = Console.ReadLine();
				int op = Convert.ToInt32(stringop); 
				if (op == 6)
					break;
				Console.Write ("enter number1  ");
				string stringnum1 = Console.ReadLine ();
				int num1 = Convert.ToInt32 (stringnum1);
				Console.Write ("enter number2  ");
				string stringnum2 = Console.ReadLine ();
				int num2 = Convert.ToInt32 (stringnum2);
				if (op == 1)
					Console.Write (num1 + num2+"\n");
				if(op == 2)
					Console.Write (num1 - num2+"\n");
				if(op == 3)
					Console.Write (num1 * num2+"\n");
				if(op == 4)
					Console.Write (num1 / num2+"\n");
				if(op == 5){
					int ans = 1;
					for (int i = 0; i < num2; i++)
						ans *= num1;
					Console.Write (ans+"\n");
					}
			}
		}
	}
}
