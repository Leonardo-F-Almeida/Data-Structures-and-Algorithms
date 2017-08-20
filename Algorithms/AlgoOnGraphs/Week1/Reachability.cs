/*
 * Created by SharpDevelop.
 * User: Leonardo F.Almeida
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgoOnGraphs.week1
{
	
	class Node
	{
		public int value;
		public bool visited = false;
		public Dictionary<int,Node> neighborhood =  new Dictionary<int, Node>();
	}
	
    class Reachability
    {
    	public static Dictionary<int,Node> nodeList = new Dictionary<int,Node>();
    	public static int founded = 0;
    	public static int endNode;
    	
        static void Main(string[] args)
        {   
        	//Console.WriteLine("Values:");
        	var input 				= Console.ReadLine();
        	string[] inputValues    = input.Split(' ');
        	int vertices			= int.Parse(inputValues[0]);
        	int edges 				= int.Parse(inputValues[1]);
        	
        	for(int i = 0; i < edges; ++i)
        	{
        		var graph  				= Console.ReadLine();
        		string[] graphInput 	= graph.Split(' ');
        		int value				= int.Parse(graphInput[0]);
        		int neighborhoodValue 	= int.Parse(graphInput[1]);
        		DefineNode(value,neighborhoodValue);
        	}
        	//Console.WriteLine("Path to find:");
        	var pathInput 			 = Console.ReadLine();
        	string[] pathInputValues = pathInput.Split(' ');
        	int startNode			 = int.Parse(pathInputValues[0]);
        	endNode 	 	    	 = int.Parse(pathInputValues[1]);
        	Explore(startNode);
        	Console.WriteLine(founded);
         	Console.ReadKey();
        }
       
        
       static void Explore(int nodeValue)
       {
       		if(nodeList.ContainsKey(nodeValue))
       	    {
       			if(nodeList[nodeValue].visited) return;
       			
       			nodeList[nodeValue].visited = true;
       			
       			if(founded > 0) return;
       			
       			if(nodeList[nodeValue].value == endNode)
       			{
       				founded = 1;
       				return;
       			}
       			
       			if(nodeList[nodeValue].neighborhood.Count <= 0)
       			{	
       				return;
       			}
       			
       	   		foreach (KeyValuePair<int, Node> pair in nodeList[nodeValue].neighborhood)
       	   		{	
       	   			Explore(pair.Value.value);
       	   		}
       	   		
       	    }
       }
        
        
       static void DefineNode(int value, int neighborhoodValue)
       {
       		if(nodeList.ContainsKey(value))
       		{
       			if(nodeList.ContainsKey(neighborhoodValue))
       			{
       				nodeList[value].neighborhood.Add(neighborhoodValue,nodeList[neighborhoodValue]);
       				nodeList[neighborhoodValue].neighborhood.Add(value,nodeList[value]);
       			}
       			else
       			{
       				Node neighborhood = new Node();
       				neighborhood.value = neighborhoodValue;
       				nodeList[value].neighborhood.Add(neighborhoodValue,neighborhood);       				
       				nodeList.Add(neighborhoodValue,neighborhood);
       				nodeList[neighborhoodValue].neighborhood.Add(value,nodeList[value]);
       			}
       		}
       		else
       		{
       			if(nodeList.ContainsKey(neighborhoodValue))
       			{
       				Node node = new Node();
            		node.value = value;
            		node.neighborhood.Add(neighborhoodValue,nodeList[neighborhoodValue]);
            		nodeList.Add(value,node);
            		nodeList[neighborhoodValue].neighborhood.Add(value,nodeList[value]);
       			}
		        else
		        {
		        	Node node =  new Node();
		            node.value = value;
		            Node neighborhood =  new Node();
		            neighborhood.value = neighborhoodValue;
		            node.neighborhood.Add(neighborhoodValue,neighborhood);
		            nodeList.Add(value, node);
		            nodeList.Add(neighborhoodValue, neighborhood);
		            neighborhood.neighborhood.Add(value,node);
		        }
       		}
		}
	}
}
*/