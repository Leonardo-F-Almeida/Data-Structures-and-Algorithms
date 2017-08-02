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
    class FractionalKnapsack
    {
    	
        static void Main(string[] args)
        {        	
        	var input 				= Console.ReadLine();
        	string[] 	inputValues = input.Split(' ');
        	int n 					= int.Parse(inputValues[0]);
        	double capacity 			= double.Parse(inputValues[1]);
        	
        	double[] values 			= new double[n];
        	double[] weights 		= new double[n];
        	
        	for (int i = 0; i < n; i++) 
        	{
        		var input2 					= Console.ReadLine();
        		string[] 	inputValues2  	= input2.Split(' ');
        		values[i] 					= double.Parse(inputValues2[0]);
        		weights[i] 					= double.Parse(inputValues2[1]);
        	}
        
         	//Console.WriteLine(getOptimalValue(capacity, values, weights));
         	//Console.WriteLine("{0:N2}", getOptimalValue(capacity, values, weights));
         	Console.WriteLine(string.Format("{0:0.000000}", getOptimalValue(capacity, values, weights)));
         	Console.ReadKey();
        }
        
        private static double getOptimalValue(double capacity, double[] values, double[] weights) 
        {
        	int items 		= values.Length;
        	double total 	= 0;
        	double[] totalWeightUsed = new double[items];
        	
        	for (int i = 0; i < items; i++) 
        	{
        		totalWeightUsed[i] 					= 0;
        	}
        	
        	while(capacity > 0)
        	{
        		int bestFitIndex = -1;
        		double lastValue = 0;
        		
        		
        		for(int i = 0; i < items; i ++)
        		{
        			double value = values[i]/weights[i];
        			
        			if(value > lastValue)
        			{
        				if((weights[i] - totalWeightUsed[i]) > 0)
        				{
        					bestFitIndex = i;
        					lastValue = value;	
        				}
        			}
        		}
        		
        		//Theres no more items
        		if(bestFitIndex < 0)
        		{
        			return total;
        		}
        		
        		
        		if((weights[bestFitIndex]  - totalWeightUsed[bestFitIndex]) < capacity && (weights[bestFitIndex]  - totalWeightUsed[bestFitIndex]) > 0)
        		{
        			capacity -= (weights[bestFitIndex] - totalWeightUsed[bestFitIndex]);
        			total += (values[bestFitIndex] / weights[bestFitIndex]) * (weights[bestFitIndex] - totalWeightUsed[bestFitIndex]);
        			totalWeightUsed[bestFitIndex] = (weights[bestFitIndex]  - totalWeightUsed[bestFitIndex]);
        		}
        		else if((weights[bestFitIndex]  - totalWeightUsed[bestFitIndex]) > 0)
				{
					total += (values[bestFitIndex] / weights[bestFitIndex]) * capacity;
					totalWeightUsed[bestFitIndex] = ((weights[bestFitIndex]  - totalWeightUsed[bestFitIndex]) - capacity);
					capacity = 0;
				}
        		
        	}
        	
        	return total;
    	}
        
       
	}
}
*/
