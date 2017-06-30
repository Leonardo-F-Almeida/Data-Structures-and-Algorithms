/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 31/01/2017
 * Time: 19:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
using System;
namespace Week1
{
    class gcd
    {


        static void Main(string[] args)
        {
            var inputOfNumbers  		= Console.ReadLine();
            string[] 	numbersString  	= inputOfNumbers.Split(' ');
            int a = int.Parse(numbersString[0]);
            int b = int.Parse(numbersString[1]);
            Console.WriteLine(gcd_fast(a,b));
            Console.ReadKey();
        }
        
        private static int gcd_fast(int a, int b) 
        {
        	if(a == b)
        	{
        		return a;
        	}
        	if(a == 0)
   			{
   				return b;
   			}
        	
        	if(b == 0)
        	{
        		return a;
        	}
        	
   			int remainder = a % b;

    		return gcd_fast(b,remainder);;
  		}
 
    }
}
*/