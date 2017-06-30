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
        	var input 				= Console.ReadLine();
        	string[] 	inputValues = input.Split(' ');
        	int n 					= int.Parse(inputValues[0]);
        	int m 					= int.Parse(inputValues[1]);
        	Console.WriteLine(fibonacciHuge(n,m));
            Console.ReadKey();
        }
        
        public static double fibonacciHuge(int n, int m)
        {
        	if (n <= 1)
            	return n;

	        double previous = 0;
	        double current  = 1;

	        for (long i = 0; i < n - 1; ++i) {
	            double tmp_previous = previous;
	            previous = current;
	            current = tmp_previous + current;
	        }

        	return	current % m;
        	   
        }
        
     
 }
 */