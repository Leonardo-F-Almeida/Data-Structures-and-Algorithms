/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 05/03/2017
 * Time: 19:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 /*
using System;
using System.Collections.Generic;

namespace Algorithms.DataStructures.Week1
{
	/// <summary>
	/// Description of TreeHeight.
	/// </summary>
	/// 
	
	struct Leaf
	{
		public int 	leafValue;
		public List<int>	childs;
	}
	
	
	public class TreeHeight
	{
			static Leaf[] myLeafs;
			static int maxLevel = 1;
			static int level = 1;
			static int nodeLeaf;
			
			static void Main(string[] args)
    		{
  				var input 					= Console.ReadLine();
  				int total					= int.Parse(input);
  				
  				string[] tree = new string[total];
  				
  				var treeInput 				= Console.ReadLine();
  				tree						= treeInput.Split(' ');
  				
  				MakeTree(tree);
  				PrintHeight(myLeafs[nodeLeaf]);
  				//Console.WriteLine("Tamanho da árvore: " + maxLevel);
  				Console.WriteLine(maxLevel);
  				Console.ReadKey();
    		}
			
			static void MakeTree(String[] tree)
			{
				myLeafs = new Leaf[tree.Length];
				
				for (int i = 0; i < tree.Length; i++) 
				{
					int leafParentIndex = int.Parse(tree[i]);
					
					if(leafParentIndex >= 0)
					{
						if(myLeafs[leafParentIndex].childs == null)
						{
							myLeafs[leafParentIndex].childs = new List<int>();
						}
						myLeafs[i].leafValue = i;
						myLeafs[leafParentIndex].childs.Add(i);	
					}
					else
					{
						nodeLeaf = i;
					}
				}
			}
			
			
			static void PrintHeight(Leaf leaf)
			{
				if(leaf.childs != null)
				{
					
					for (int i = 0; i < leaf.childs.Count; i++) 
					{
						level += 1;
						PrintHeight(myLeafs[leaf.childs[i]]);
					}
					
					level -=1;
					//Console.WriteLine(leaf.leafValue);
				}
				else
				{
					if(maxLevel < level)
					{
						maxLevel = level;
					}
					
					level -=1;
					
					//Console.WriteLine(leaf.leafValue);
				}
			}
			
			
		
	}
}
*/