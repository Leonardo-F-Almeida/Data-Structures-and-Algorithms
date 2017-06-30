/*
 * Created by SharpDevelop.
 * User: Leonardo
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
using System;
using System.Collections.Generic;

namespace Week5
{
    class Knapsack
    {
    	
        static void Main(string[] args)
        {        	
        	var input 				= Console.ReadLine();
        	string[] 	inputValues = input.Split(' ');
        	int knapsackCapacity	= int.Parse(inputValues[0]);
        	int totalBarOfGolds 	= int.Parse(inputValues[1]);
        	
        	int[] weights 			= new int[totalBarOfGolds+1];
        	
        	var input2 					= Console.ReadLine();
        	string[] 	inputValues2 	= input2.Split(' ');
        		
        	weights[0] = 0;
        	
        	for(int i = 1; i <= totalBarOfGolds; ++i)
        	{
        		weights[i] = int.Parse(inputValues2[i-1]);
        	}
			
        	getBestValue(totalBarOfGolds+1, knapsackCapacity+1, weights);
        	
         	Console.ReadKey();
        }
        
        static void getBestValue(int itemsLength, int totalWeight, int[] itemsWeight)
        {
        	int[,] matriz = new int[itemsLength,totalWeight];
    		
    		
    		for(int i = 1; i< itemsLength; ++i)
    		{
    			for(int j = 1; j < totalWeight; ++j)
    			{
    				if(i == 0 || totalWeight == 0)
    				{
    					matriz[i,j] = 0;
    				}
    				//J in this case is the max weight - M
    				else if(itemsWeight[i] > j)
    				{
    					matriz[i,j] = matriz[i-1,j];
    				}
    				
    				//J in this case is the max weight - M
    				else if(i > 0)
    				{
    					if(itemsWeight[i] <= j)
    					{
    						matriz[i,j] = max(itemsWeight[i] + matriz[i-1,(j-itemsWeight[i])], matriz[i-1,j]);
    					}
    				}
    			}
    		}

    		Console.Write(matriz[itemsLength-1,totalWeight-1]);
    		
    		Console.ReadKey();
        }
        
        static int max(int value1, int value2)
        {
        	int maxValue = value1;
        	
        	if(value2 > maxValue)
        	{
        		maxValue = value2;
        	}
        	
        	return maxValue;
        }
       
	}
}
*/