/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 13/02/2017
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
using System;
using System.Collections.Generic;

namespace Week4
{
    class MajorityElement
    {
    	
        static void Main(string[] args)
        {            	
        	var input 					= Console.ReadLine();
        	int arrayLength 			= int.Parse(input);
        	string[] dados 				= new string[arrayLength];
        	var input2					= Console.ReadLine();
        	int[] arrayOfvalues 		= new int[arrayLength];
        	arrayOfvalues				= Array.ConvertAll(input2.Split(' '), int.Parse);

        	quicksort(arrayOfvalues,0,arrayLength-1);
        	Console.WriteLine(getMajorityElement(arrayOfvalues, (arrayLength/2)));
        	Console.ReadKey();
        }
        
        //METODO ZUADO
        public static int getMajorityElement(int[] array, int majority)
        {
        	int arrayLength = array.Length;
        	int lastMajorityCount = 0;
        	bool firstMajorityElement = true;
        	int currentCount = 1;
        	
        	for(int i = 0; i < arrayLength -1; i++)
        	{
        		if(i+1 <= arrayLength -1)
        		{
        			if(array[i] == array[i+1])
        			{
        				currentCount++;
        			}
        			else
        			{
        				if(firstMajorityElement)
        				{
	        				lastMajorityCount = currentCount;
        					currentCount = 1;	
        					firstMajorityElement = false;
        				}
        				else
        				{
        					if(currentCount > lastMajorityCount)
        					{
	        					lastMajorityCount = currentCount;
        						currentCount = 1;	
        					}
        				}
        			}
        		}
        	}
        	if(currentCount > lastMajorityCount)
        	{
	        					lastMajorityCount = currentCount;
        						currentCount = 1;	
       		}
        	
        	if(lastMajorityCount > majority)
        	{
        		return 1;
        	}
        	
        	return 0;
        }
        
        public static void quicksort(int[] array, int left, int right)
        {
        	if(left >= right)
        	{
        		return;
        	}
        	
        	int pivot = array[(left + right)/2];
        	int index = partition(array,left,right,pivot);
        	quicksort(array, left, index-1);
        	quicksort(array,index,right);
        }
        
        
        
        
        public static int partition(int[] array, int left, int right, int pivot)
        {
        	while(left <= right)
        	{
        		while(array[left] < pivot)
        		{
        			left++;
        		}
        		
        		while( array[right] > pivot)
        		{
        			right--;
        		}
        		
        		if(left <= right)
        		{
        			swap(ref array[left],ref array[right]);
        			left++;
        			right--;
        		}
        	}
        	return left;
        }
        
         static void swap(ref int a, ref int b)
    	 {
        	int temp = a;
        	a = b;
        	b = temp;
    }
        
	}
}
*/
