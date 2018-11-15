using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Program
    {
       public static void Main(string[] args)
        {
			
	     Console.Write("please Enter deposite  Amount Here:");
            int depositeAmount = Convert.ToInt32(Console.ReadLine());
			
            
            int Notes500;
            int Notes100;
            int Note50;
            int Note10; 
            int Note5;

			
		   Console.WriteLine("Total Balance is:-"+depositeAmount);
		  // Console.WriteLine("Withdraw amount is"+WithdrawAmount);
		  // Console.WriteLine("Withdraw amount is"+EnteringAmount);
		   
			do
			{	
			  Notes500 = 0;
           		  Notes100 = 0;
           		  Note50 = 0;
           		  Note10 = 0;
           		  Note5 = 0;

				
				Console.Write("please Enter Amount Here:");
				int WithdrawAmount = Convert.ToInt32(Console.ReadLine());
				int EnteringAmount = WithdrawAmount;
				
			
				if (EnteringAmount % 5 == 0 && depositeAmount > WithdrawAmount)
				{
					if (EnteringAmount >= 500)
					{
						Notes500 = EnteringAmount / 500;
						EnteringAmount = EnteringAmount - (Notes500 * 500);
					}
					if (EnteringAmount >= 100)
					{
						Notes100 = EnteringAmount / 100;
						EnteringAmount = EnteringAmount - (Notes100 * 100);
					}
					if (EnteringAmount >= 50)
					{
						Note50 = EnteringAmount / 50;
						EnteringAmount = EnteringAmount - (Note50 * 50);
					}
					if (EnteringAmount >= 10)
					{
						Note10 = EnteringAmount / 10;
						EnteringAmount = EnteringAmount - (Note10 * 10);
					}
					if (EnteringAmount >= 5)
					{
						Note5 = EnteringAmount / 5;
						EnteringAmount = EnteringAmount - (Note5 * 5);
					}
				
			
					

					Console.WriteLine("No.of 500  *:" + Notes500);
					Console.WriteLine("No.of 100  *:" + Notes100);
					Console.WriteLine("No.of 50   *:" + Note50);
					Console.WriteLine("No.of 10   *:" + Note10);
					Console.WriteLine("No.of 5    *:" + Note5);
					
					depositeAmount = depositeAmount - WithdrawAmount; 
					
					Console.WriteLine("Final  Amount remaining:-" + depositeAmount);
                                         Console.WriteLine("Widthraw amount:-" + WithdrawAmount);
					Console.ReadLine();
				}

				else
				{
					Console.WriteLine("Invalid Amount");
					Console.ReadLine();
				}		
					
				
			}while(depositeAmount >= 0);  
		   Console.WriteLine("Invalid Amount");
		   
		}
    }

