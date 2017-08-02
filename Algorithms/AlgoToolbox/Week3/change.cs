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
using System.Collections.Generic;

namespace Week3
{
    class change
    {
    	
        static void Main(string[] args)
        {
        	

        	
        	int input  		= int.Parse(Console.ReadLine());

            Console.WriteLine(getChange(input));
            Console.ReadKey();
        }
        
        private static int getChange(int money)
        {
        	List<int> coins = new List<int>();
          	coins.Add(10);
        	coins.Add(5);
        	coins.Add(1);
        	int total = 0;
        	int totalOfCoins = 0;
        	
        	while(total < money)
        	{
        		for(int i = 0; i < coins.Count; i ++)
        		{
        			while(total + coins[i] <= money)
        			{
        				total += coins[i];
        				totalOfCoins += 1;	
        			}
        		}
        	}
        	
        	return totalOfCoins;
        }
        
       
	}
}
*/