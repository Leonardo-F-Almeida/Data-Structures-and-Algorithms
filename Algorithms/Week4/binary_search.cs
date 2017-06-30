/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 12/02/2017
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
using System;
using System.Collections.Generic;

namespace Week4
{
    class BinarySearch
    {
    	
        static void Main(string[] args)
        {            	
        	var input 					= Console.ReadLine();
        	//string[] 	arrayOfvalues 	= input.Split(' ');
        	int[] arrayOfvalues 		= Array.ConvertAll(input.Split(' '), int.Parse);
        	var input2 					= Console.ReadLine();
        	//string[] 	arrayToSearch 	= input.Split(' ');
        	int[] arrayToSearch 		= Array.ConvertAll(input2.Split(' '), int.Parse);
        	
        	int i = 0;
        	
        	int[] firstarray, secondarray;
			firstarray = new int[arrayOfvalues.Length -1];
    		secondarray = new int[arrayToSearch.Length - 1];
    		Array.Copy(arrayOfvalues, 1, firstarray, 0, arrayOfvalues.Length -1);
    		Array.Copy(arrayToSearch, 1, secondarray, 0, secondarray.Length -1);
        	
        	for(i = 0; i < secondarray.Length; i ++)
        	{
        		Console.WriteLine(binarySearch(firstarray, secondarray[i]));
        	}
         	
        	Console.ReadKey();
        }
        
        
        public static int binarySearch(int[] array, int targetValue)
        {
		    int min = 0;
			int max = array.Length - 1;
		    int guess;
		    
		    while(min <= max)
		    {
		        guess = (min+max) / 2;
		        
		        if(array[guess] == targetValue)
		        {
		            return guess;        
		        }
		        else if(array[guess] < targetValue)
		        {
		            min = guess  + 1;
		        }
		        else
		        {
		            max = guess - 1;
		        }
		        
		    }
		
			return -1;
        }
	}
}
*/
