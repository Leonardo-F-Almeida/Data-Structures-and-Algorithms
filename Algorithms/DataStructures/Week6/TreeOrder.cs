/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 09/04/2017
 * Time: 14:43
 * 
 * Problem Description
	Task. You are given a rooted binary tree. Build and output its in-order, pre-order and post-order traversals.
	Input Format. The frst line contains the number of vertices �. The vertices of the tree are numbered
	from 0 to � − 1. Vertex 0 is the root.
	The next � lines contain information about vertices 0, 1, ..., �− 1 in order. Each of these lines contains
	three integers ����, ����� and ���ℎ�� — ���� is the key of the �-th vertex, ����� is the index of the left
	child of the �-th vertex, and ���ℎ�� is the index of the right child of the �-th vertex. If � doesn’t have
	left or right child (or both), the corresponding ����� or ���ℎ�� (or both) will be equal to −1.
	Constraints. 1 ≤ � ≤ 105; 0 ≤ ���� ≤ 109; −1 ≤ �����, ���ℎ�� ≤ � − 1. It is guaranteed that the input
	represents a valid binary tree. In particular, if ����� ̸= −1 and ���ℎ�� ̸= −1, then ����� ̸= ���ℎ��. Also,
	a vertex cannot be a child of two diﬀerent vertices. Also, each vertex is a descendant of the root vertex.
	Output Format. Print three lines. The frst line should contain the keys of the vertices in the in-order
	traversal of the tree. The second line should contain the keys of the vertices in the pre-order traversal
	of the tree. The third line should contain the keys of the vertices in the post-order traversal of the tree.

	Sample 1.
	Input:
	5
	4 1 2
	2 3 4
	5 -1 -1
	1 -1 -1
	3 -1 -1
	
	Output:
	1 2 3 4 5
	4 2 1 3 5
	1 3 2 5 4
 */

using System;
using System.Collections;
using System.Collections.Generic;

/*
public static class TreeOrder
{
	static int[] key, left, right;
	
	
	static void Main(string[] args)
	{	
		ProcessInput();
	}
	
	static void ProcessInput()
	{
		
		
		int numberOfOperations = int.Parse(Console.ReadLine());
		
		key = new int[numberOfOperations];
		left = new int[numberOfOperations];
		right = new int[numberOfOperations];
		
		for (int i = 0; i < numberOfOperations; i++)
		{
			string 	input		= Console.ReadLine();
			string[] data		= input.Split(' ');
			
			key[i] 		= int.Parse(data[0]);
			left[i] 	= int.Parse(data[1]);
			right[i] 	= int.Parse(data[2]);
		}
		
		InOrder(0);
		Console.WriteLine();
		PreOrder(0);
		Console.WriteLine();
		PostOrder(0);
		
		Console.ReadKey();
	}
	
	static void InOrder(int index) 
	{
		if(index < 0) return;

		InOrder(left[index]);
		Console.Write(key[index] + " ");
		
		InOrder(right[index]);
	}

	static void PreOrder(int index) 
	{
		if(index < 0) return;

		Console.Write(key[index] + " ");
		PreOrder(left[index]);
		PreOrder(right[index]);	
	}

	static void PostOrder(int index) 
	{
		if(index < 0) return;

		PostOrder(left[index]);
		PostOrder(right[index]);	
		Console.Write(key[index] + " ");
		
	}
	
}
*/