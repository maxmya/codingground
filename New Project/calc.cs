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
				Console.Write ("enter num1  ");
				string stringnum1 = Console.ReadLine ();
				double num1 = Convert.ToDouble (stringnum1);
				Console.Write ("enter num2  ");
				string stringnum2 = Console.ReadLine ();
			    double num2 = Convert.ToDouble (stringnum2);
				if (op == 1)
					Console.Write ((num1 +" + " + num2 +" = " )+ (num1 + num2)+"\n");
				if(op == 2)
					Console.Write ((num1 +" - " + num2 +" = " )+ (num1 - num2)+"\n");
				if(op == 3)
					Console.Write ((num1 +" * " + num2 +" = " )+ (num1 * num2)+"\n");
				if(op == 4)
					Console.Write ((num1 +" / " + num2 +" = " )+ (num1 / num2)+"\n");
				if(op == 5){
					double ans = 1;
					for (double i = 0; i < num2; i++)
						ans *= num1;
					Console.Write ((num1 +" ^ " + num2 +" = " )+ (ans)+"\n");
					}
			}
		}
	}
}
  
