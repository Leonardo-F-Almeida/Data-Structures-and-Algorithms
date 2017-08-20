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
		public List <Graph> nextGraph =  new List<Graph>();
	}
	
	
    class Toposort
    {
    	public static Graph[] graphList;
    	public static List<int> finalList = new List<int>();
    	
        static void Main(string[] args)
        {   
        	
        	var input 				= Console.ReadLine();
        	string[] inputValues    = input.Split(' ');
        	int vertices			= int.Parse(inputValues[0]);
        	int edges 				= int.Parse(inputValues[1]);
        	graphList 				= new Graph[vertices];
        	
        	for(int i = 0; i < vertices; ++i)
        	{
        		Graph graph = new Graph();
        		graph.value = i+1;
        		graphList[i] = graph;
        	}
        	
        	for(int i = 0; i < edges; ++i)
        	{
        		var graph  				= Console.ReadLine();
        		string[] graphInput 	= graph.Split(' ');
        		int value				= int.Parse(graphInput[0]);
        		int nextGraphValue 		= int.Parse(graphInput[1]);
        		graphList[value-1].nextGraph.Add(graphList[nextGraphValue-1]);
        	}
        	
        
        	ApplyToposort();
        	PrintToposort();
         	Console.ReadKey();
        }
        
        static void PrintToposort()
        {
        	finalList.Reverse();
        	for (int i = 0; i <finalList.Count; i++) {
        		Console.Write(finalList[i]+ " ");
        	}
        }
        
        static void ApplyToposort()
        {
        	foreach (Graph  firstGraph in graphList) 
    		{
        		defineSort(firstGraph);
        	}
        }
               
 
        static void defineSort(Graph graph)
        {
        	if(graph.status == Status.visited) return;
        	
        	graph.status = Status.visited;
        	
        	foreach (Graph  nextGraph in graph.nextGraph)
    		{
    			defineSort(nextGraph);
    		}        	

        	finalList.Add(graph.value);
        }
        
    }
}