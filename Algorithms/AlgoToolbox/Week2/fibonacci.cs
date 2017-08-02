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

 class fibonacci
    {


        static void Main(string[] args)
        {
        	int n 						= Convert.ToInt32(Console.ReadLine());
        	Console.WriteLine(fibonacciFast(n));
            Console.ReadKey();
        }
        
        
        public static long fibonacciNaive(int n)
        {
        	   if (n <= 1)
        			return n;

    			return fibonacciNaive(n - 1) + fibonacciNaive(n - 2);
        }
        
        public static long fibonacciFast(int n)
        {
        	if(n == 0 || n < 0) return 0;
        	if(n == 1) return 1;
        	
        	int[] fib = new int[n+1];
        	fib[0] = 0;
        	fib[1] = 1;
        	int i;
        	
        	for(i = 2; i <= n; i++)
        	{
        		fib[i] = fib[i-1] + fib[i-2];
        	}
        	
        	return fib[n];
        	   
        }
 }
 */