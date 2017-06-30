/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 30/01/2017
 * Time: 20:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
using System;

 class fibonacci_last_digit
    {


        static void Main(string[] args)
        {
        	int n 						= Convert.ToInt32(Console.ReadLine());
        	Console.WriteLine(fibonacciLastDigit(n));
            Console.ReadKey();
        }
        
        
        public static long fibonacciLastDigit(int n)
        {
        	if(n == 0 || n < 0) return 0;
        	if(n == 1) return 1;
        	
        	Int64 previous = 0;
        	Int64 current  = 1;
			Int64 tmp_previous;
			Int64 i;
        	for(i = 2; i <= n; i++)
        	{
        		tmp_previous = previous;
            	previous = current;
            	current = (tmp_previous % 10) + (current % 10);
        	}
        	
        	string lastNumber = current.ToString();
        	int result = Int32.Parse(lastNumber[lastNumber.Length-1].ToString());
        	return result;
        }
 }
 */