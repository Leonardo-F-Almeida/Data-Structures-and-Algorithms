/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 30/06/2017
 * Time: 16:17
 * 
 * Problem Description
	Task. You are given a binary tree with integers as its keys. You need to test whether it is a correct binary
	search tree. The defnition of the binary search tree is the following: for any node of the tree, if its
	key is �, then for any node in its left subtree its key must be strictly less than �, and for any node in
	its right subtree its key must be strictly greater than �. In other words, smaller elements are to the
	left, and bigger elements are to the right. You need to check whether the given binary tree structure
	satisfes this condition. You are guaranteed that the input contains a valid binary tree. That is, it is a
	tree, and each node has at most two children.
	Input Format. The frst line contains the number of vertices �. The vertices of the tree are numbered
	from 0 to � − 1. Vertex 0 is the root.
	The next � lines contain information about vertices 0, 1, ..., �− 1 in order. Each of these lines contains
	three integers ����, ����� and ���ℎ�� — ���� is the key of the �-th vertex, ����� is the index of the left
	child of the �-th vertex, and ���ℎ�� is the index of the right child of the �-th vertex. If � doesn’t have
	left or right child (or both), the corresponding ����� or ���ℎ�� (or both) will be equal to −1.
	Constraints. 0 ≤ � ≤ 105; −231 < ���� < 231 − 1; −1 ≤ �����, ���ℎ�� ≤ � − 1. It is guaranteed that the
	input represents a valid binary tree. In particular, if ����� ̸= −1 and ���ℎ�� ̸= −1, then ����� ̸= ���ℎ��.
	Also, a vertex cannot be a child of two diﬀerent vertices. Also, each vertex is a descendant of the root
	vertex. All keys in the input will be diﬀerent.
	Output Format. If the given binary tree is a correct binary search tree (see the defnition in the problem
	description), output one word “CORRECT” (without quotes). Otherwise, output one word “INCORRECT” (without quotes).
 */
/*
using System;
using System.Collections;
using System.Collections.Generic;


public static class IsABinarySearchTree
{
	static long[] key, left, right;
	static bool isABinarySearchTree = true;
	static long? lastValue = null;
	
	static void Main(string[] args)
	{	
		ProcessInput();
	}
	
	static void ProcessInput()
	{
		
		
		int numberOfOperations = int.Parse(Console.ReadLine());
		
		if(numberOfOperations == 0)
		{
			Console.WriteLine("CORRECT");
			return;
		}
		
		
		key = new long[numberOfOperations];
		left = new long[numberOfOperations];
		right = new long[numberOfOperations];
		
		for (int i = 0; i < numberOfOperations; i++)
		{
			string 	input		= Console.ReadLine();
			string[] data		= input.Split(' ');
			
			key[i] 		= long.Parse(data[0]);
			left[i] 	= long.Parse(data[1]);
			right[i] 	= long.Parse(data[2]);
		}
		
		InOrder(0);
		if(isABinarySearchTree)
		{
			Console.WriteLine("CORRECT");	
		}
		Console.ReadKey();
		
	}
	
	static void InOrder(long index) 
	{
		if(!isABinarySearchTree) return;
		
		if(index < 0) return;

		
		InOrder(left[index]);

		if(lastValue > key[index])
		{
			Console.WriteLine("INCORRECT");
			isABinarySearchTree = false;
		}
		lastValue = key[index];

		InOrder(right[index]);
	}
	
}
*/