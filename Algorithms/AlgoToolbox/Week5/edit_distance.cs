/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 23/02/2017
 * Time: 18:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
using System;

class EditDistance
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine();
            var string2 = Console.ReadLine();
 			
            
        	if(string1.Length > string2.Length)
        	{
        		GetEditDistance(string1,string2);
        	}
            else
            {
            	GetEditDistance(string2,string1);	
            }
            
            Console.ReadKey();
        }
        
        static void GetEditDistance(String stringA, String stringB)
        {
        	//J recebe a maior string
        	int j = stringA.Length;
        	int i = stringB.Length;
        	
        	int[,] matriz = new int[i+1,j+1];
        	
        	// ex 0 1 2 3 4 5 6
    		//    0 0 0 0 0 0 0
    		//    0 0 0 0 0 0 0 
    		for(int count = 0; count <= j; count++)
    		{
    			matriz[0,count] = count;
    		}
    		// ex 0 1 2 3 4 5 6 
    		//    1 0 0 0 0 0 0
    		//    2 0 0 0 0 0 0
    		//    3 0 0 0 0 0 0
    		for(int count = 0; count <= i; count++)
    		{
    			matriz[count,0] = count;
    		}	
    		
    		for(int countJ = 1 ;countJ <= j; countJ++ )
    		{
    			for(int countI = 1 ;countI <= i; countI++ )
    			{
    				int insertion 	= matriz[countI,countJ-1] + 1;
    				int deletion 	= matriz[countI-1,countJ] + 1;
    				int match		= matriz[countI -1,countJ-1];
    				int mismatch	= matriz[countI -1,countJ-1] + 1;
    				int minimumValue;
    			
    				if(stringA[countJ-1] == stringB[countI-1])
    				{
    					minimumValue = GetMinimunValue(insertion,deletion,match);
    				}
    				else
    				{
    					minimumValue = GetMinimunValue(insertion,deletion,mismatch);
    				}
    				
    				matriz[countI, countJ] = minimumValue;
    			}	
    		}
    		
    		Console.WriteLine(matriz[i,j]);
        }
        
        
        static int GetMinimunValue(int value1, int value2, int value3)
        {
        	int minimumValue = value1;
        	
        	if(value2 < minimumValue)
        	{
        		minimumValue = value2;
        	}
        	
        	if(value3 < minimumValue)
        	{
        		minimumValue = value3;
        	}
        	
        	return minimumValue;
        }
    }
*/