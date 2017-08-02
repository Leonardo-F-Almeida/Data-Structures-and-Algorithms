/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 03/03/2017
 * Time: 19:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 /*
using System;
using System.Collections.Generic;

namespace Algorithms.DataStructures.Week1
{
	/// <summary>
	/// Description of BracketsCheck.
	/// </summary>
	public class BracketsCheck
	{
		
		
	  	static void Main(string[] args)
        {

	  			var input = Console.ReadLine();
            	isBalanced(input);
	            Console.ReadKey();	
        }
	  	
	  	static void isBalanced(String str)
	  	{
	  		List<Char> stack = new List<Char>();
	  		List<int> charPosition = new List<int>();
	  		int firstCharWithError = 0;
	  		bool hasError = false;
	  		
	  		if(str.Length == 1)
	  		{
	  			Console.WriteLine("1");
	  			return;
	  		}
	  		
	  		for (int i = 0; i < str.Length; i++) 
	  		{
	  			if(str[i] == '[' || 
	  			   str[i] == '(' ||
	  			   str[i] == '{')
	  			{
	  				stack.Add(str[i]);
	  				charPosition.Add(i);
	  			}
	  			else if(str[i] == ']'||
	  			        str[i] == ')'||
	  			        str[i] == '}')
	  			{	
	  				
	  				if(stack.Count >= 1)
	  				{
	  					char topChar = stack[stack.Count-1];
	  					if(topChar == '[' && str[i] == ']'||
	  				    topChar == '(' && str[i] == ')'||
	  				    topChar == '{' && str[i] == '}')
	  				 	{
	  						//Console.WriteLine("Match");
	  						stack.RemoveAt(stack.Count -1);
	  						charPosition.RemoveAt(charPosition.Count -1);
	  					}
	  					else if(!hasError)
	  					{
	  						firstCharWithError = i;	
	  						hasError = true;
	  					}
	  				}
	  				else
	  				{
	  					if(!hasError)
	  					{
	  						firstCharWithError = i;	
	  						hasError = true;
	  					}
	  				}
	  			
	  			}
	  		}
	  		
	  		if(hasError)
	  		{
	  			Console.WriteLine(firstCharWithError+1);
	  			return;
	  		}
			
	  		if(stack.Count > 0)
	  		{
	  			Console.WriteLine(charPosition[0]+1);
	  			return;
	  		}
	  		
	  		Console.WriteLine("Success");
	  		return;
	  	}
	}
}
*/