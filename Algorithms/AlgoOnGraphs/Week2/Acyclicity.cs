/*
 * Created by SharpDevelop.
 * User: Leonardo F.Almeida
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgoOnGraphs.week2
{
	
	enum Status
	{
		unvisited,
		visiting,
		visited
	}
	
	class Graph
	{
		public int value;
		public Status status = Status.unvisited;
		public Dictionary<int,Graph> nextGraph =  new Dictionary<int, Graph>();
	}
	
	
    class Acyclicity
    {
    	public static Dictionary<int,Graph> graphList = new Dictionary<int,Graph>();
    	public static Graph rootElement;
    	public static int founded = 0;
    	public static List<string> stackVisited = new List<string>();
    	
        static void Main(string[] args)
        {   
        	
        	var input 				= Console.ReadLine();
        	string[] inputValues    = input.Split(' ');
        	int vertices			= int.Parse(inputValues[0]);
        	int edges 				= int.Parse(inputValues[1]);
        	
        	for(int i = 0; i < edges; ++i)
        	{
        		var graph  				= Console.ReadLine();
        		string[] graphInput 	= graph.Split(' ');
        		int value				= int.Parse(graphInput[0]);
        		int nextGraphValue 		= int.Parse(graphInput[1]);
        		DefineGraph(value,nextGraphValue);
        	}
        
        	FindAcycliticity();

        	Console.WriteLine(founded);
         	Console.ReadKey();
        }
       
        static void FindAcycliticity()
        {
        	foreach (KeyValuePair<int, Graph>  firstGraph in graphList) 
    		{
        		clearVisited();
        		
        		if(founded > 0) return;
        		
        		find(firstGraph.Value);
        	}
        	
        
        }
        
        static void find(Graph graph)
        {
        	if(founded > 0) return;
        	
        	graph.status = Status.visiting;
        	
        	foreach (KeyValuePair<int, Graph>  nextGraph in graph.nextGraph)
    		{
        		if(nextGraph.Value.status == Status.visiting)
        		{
        			founded = 1;
        			return;
        		}
        		
    			find(nextGraph.Value);
    		}
        	
        	graph.status = Status.visited;
        }
        
        static void clearVisited()
        {
        	//clear
    		foreach (KeyValuePair<int, Graph>  firstGraph in graphList) 
			{
    			firstGraph.Value.status = Status.unvisited;
    		}
        }
     
       static void DefineGraph(int value, int nextGraphValue)
       {
       		if(graphList.ContainsKey(value))
       		{
       			if(graphList.ContainsKey(nextGraphValue))
       			{
       				graphList[value].nextGraph.Add(nextGraphValue,graphList[nextGraphValue]);
       			}
       			else
       			{
       				Graph nextGraph = new Graph();
       				nextGraph.value = nextGraphValue;
       				graphList[value].nextGraph.Add(nextGraphValue,nextGraph); 
					graphList.Add(nextGraphValue,nextGraph);       				
       			}
       		}
       		else
       		{
       			if(graphList.ContainsKey(nextGraphValue))
       			{
       				Graph graph = new Graph();
            		graph.value = value;
            		graph.nextGraph.Add(nextGraphValue,graphList[nextGraphValue]);
            		graphList.Add(value, graph);
       			}
		        else
		        {
		        	Graph graph =  new Graph();
		            graph.value = value;
		            Graph nextGraph =  new Graph();
		            nextGraph.value = nextGraphValue;
		            graph.nextGraph.Add(nextGraphValue,nextGraph);
		            graphList.Add(value, graph);
		            graphList.Add(nextGraphValue,nextGraph);  
		        }
       		}
		}
	}
}