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
				Console.Write ("enter num1 ");
				string stringnum1 = Console.ReadLine ();
				double num1 = Convert.ToDouble (stringnum1);
				Console.Write ("enter num2 ");
				string stringnum2 = Console.ReadLine ();
			    	double num2 = Convert.ToDouble (stringnum2);
			    	switch(op){
				case 1:
					Console.Write ((num1 +" + " + num2 +" = " )+ (num1 + num2)+"\n");
					break;
				case 2:
					Console.Write ((num1 +" - " + num2 +" = " )+ (num1 - num2)+"\n");
					break;
				case 3:
					Console.Write ((num1 +" * " + num2 +" = " )+ (num1 * num2)+"\n");
					break;
				case 4:{
				    	if (num2 != 0)
					Console.Write ((num1 +" / " + num2 +" = " )+ (num1 / num2)+"\n");
					else
					Console.Write("cannot devide by 0 !\n");
					break;
				    }
				case 5:{
					double ans = 1;
					for (double i = 0; i < num2; i++)
						ans *= num1;
					Console.Write ((num1 +" ^ " + num2 +" = " )+ (ans)+"\n");
					break;
					}
			    }
			}
		}
	}
}
  
