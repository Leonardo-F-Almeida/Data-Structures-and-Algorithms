/*
using System;

namespace Week1
{
    class MaxPairwise
    {


        static void Main(string[] args)
        {
            var n 						= Console.ReadLine();
            var inputOfNumbers  		= Console.ReadLine();
            string[] 	numbersString  	= inputOfNumbers.Split(' ');
            long[] numbers = new long[long.Parse(n)];
			            
            for (int i = 0; i < long.Parse(n); i++)
            {
            	numbers[i] = long.Parse(numbersString[i]);
            }
            
            MaxPairwise maxPair 			= new MaxPairwise();
            Console.WriteLine( maxPair.MaxPairwiseProductFast(numbers));
            Console.ReadKey();
        }
        
        long ComputeMaxPairwise(long[] numbers)
        {
        	long result = 0;
			int n = numbers.Length;
			
			for (int i = 0; i < n; ++i) 
			{
			    for (int j = i + 1; j < n; ++j) 
			    {
			    	if (numbers[i]* numbers[j] > result)
			      	{
			    		result = numbers[i] * numbers[j];
			      	}
			    }
			  }
			  
			return result;
        }
        
        long MaxPairwiseProductFast(long[] numbers)
        {
        	int n = numbers.Length;
		
		  int max_index1 = -1;
		  for (int i = 0; i < n; ++i)
		    if ((max_index1 == -1) || (numbers[i] > numbers[max_index1]))
		      max_index1 = i;
		
		  int max_index2 = -1;
		  for (int j = 0; j < n; ++j)
		    if (j != max_index1 && ((max_index2 == -1) || (numbers[j] > numbers[max_index2])))
		      max_index2 = j;
		
		  return  numbers[max_index1] * numbers[max_index2];
		}
    }
}
*/