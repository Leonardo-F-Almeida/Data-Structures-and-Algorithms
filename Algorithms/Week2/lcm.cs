/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 31/01/2017
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
using System;
namespace Week1
{
    class lcm
    {


        static void Main(string[] args)
        {
            var inputOfNumbers  		= Console.ReadLine();
            string[] 	numbersString  	= inputOfNumbers.Split(' ');
            long a = long.Parse(numbersString[0]);
            long b = long.Parse(numbersString[1]);
            Console.WriteLine(lcm_fast(a,b));
            Console.ReadKey();
        }
        
        private static long gcd_fast(long a, long b) 
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
        	
   			long remainder = a % b;

    		return gcd_fast(b,remainder);
  		}
 		
        private static long lcm_fast(long a, long b) 
        {
        	if(a == 0 && b == 0)
        	{
        		return 0;
        	}
        	
        	
        	long result = (a / gcd_fast(a,b))*b;
        	
        	return result;
    	}
	}
}
*/