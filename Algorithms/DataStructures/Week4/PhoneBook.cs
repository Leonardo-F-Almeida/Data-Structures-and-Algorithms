/*
 * Created by SharpDevelop.
 * User: Leonardo
 * Date: 29/03/2017
 * Time: 18:19
 * 
 *  Task. In this task your goal is to implement a simple phone book manager. It should be able to process
 *  the following types of user’s queries:
 *  ∙ add number name. It means that the user adds a person with name name and phone number
 *	number to the phone book. If there exists a user with such number already, then your manager
 *	has to overwrite the corresponding name.
 *	∙ del number. It means that the manager should erase a person with number number from the
 *	phone book. If there is no such person, then it should just ignore the query.
 *	∙ find number. It means that the user looks for a person with phone number number. The manager
 *	should reply with the appropriate name, or with string “not found" (without quotes) if there is
 *	no such person in the book.
 *	Input Format. There is a single integer 𝑁 in the first line — the number of queries. It’s followed by 𝑁
 *	lines, each of them contains one query in the format described above.
 *	Constraints. 1 ≤ 𝑁 ≤ 105
 *	. All phone numbers consist of decimal digits, they don’t have leading zeros,
 *	and each of them has no more than 7 digits. All names are non-empty strings of latin letters, and each
 *	of them has length at most 15. It’s guaranteed that there is no person with name “not found".
 *	Output Format. Print the result of each find query — the name corresponding to the phone number or
 *	“not found" (without quotes) if there is no person in the phone book with such phone number. Output
 *	one result per line in the same order as the find queries are given in the input.
 * 
 * 
 */
/*

using System;
using System.Collections.Generic;

public static class PhoneBook
{
	//In this example i don´t use dynamic hash table
	////FIXED VALUE USED ONLY FOR DIDACTIC PURPOSES*
	public static Contact[] contacts = new Contact[10000000];
	
	static void Main(string[] args)
	{	
		Hash.GenerateHashFamily();
		
		int numberOfOperations = int.Parse(Console.ReadLine());
		String[] commands = new String[numberOfOperations];
		
		for (int i = 0; i < numberOfOperations; i++)
		{
			commands[i] 		= Console.ReadLine();			
		}
		for (int i = 0; i < numberOfOperations; i++)
		{
			ProcessCommand(commands[i]);
		}
		
		Console.ReadKey();
	}
	
	static void ProcessCommand(String command)
	{
		var arguments 		= command.Split(' ');
		string commandType 	= arguments[0];
		int phoneNumber 	= int.Parse(arguments[1]);
		
		if(arguments.Length > 2)
		{
			string name = arguments[2];
			
			Query query = new Query(commandType, name, phoneNumber);
			query.Execute();
		}
		else
		{
			 Query query = new Query(commandType, phoneNumber);
			 query.Execute();
		}
	}
	
	public static void Add(int index,Contact contact)
	{
		contacts[index] = contact;
	}
	
	public static string Find(int index)
	{
		if(contacts[index] != null)
		{
			return contacts[index].name;	
		}
		
		return "not found";
	}
	
	public static void Remove(int index)
	{	
		if(contacts[index] != null)
		{
			contacts[index] = null;
		}
	}
	
};


  public class Contact 
  {
        public String name;
        public int number;
        
        public Contact(String name, int number) 
       {
            this.name = name;
            this.number = number;
       }
  };

    public class Query 
    {
        String type;
        String name = "N/A";
        int number;

        public Query(String type, String name, int number) 
        {
            this.type = type;
            this.name = name;
            this.number = number;
        }

        public Query(String type, int number) 
        {
            this.type = type;
            this.number = number;
        }
        
        public void Execute()
        {
        	int index = this.number;
//        		Hash.HashingPhoneNumber(this.number);
        	Contact contact = new Contact(this.name, this.number);
        	
        	if(type == "add")
        	{
        		PhoneBook.Add(index, contact);
        	}
        	if(type == "del")
        	{
        		PhoneBook.Remove(index);
        	}
        	
        	if(type == "find")
        	{
        		Console.WriteLine(PhoneBook.Find(index));
        	}
        }
        
    }
    
    public static class Hash
    {
    	static ulong firstHash;
    	static ulong secondHash;
    	
    	
    	public static void GenerateHashFamily()
    	{
    		firstHash 	= (ulong)Hash.Random(0,10000018);
    		secondHash 	= (ulong)Hash.Random(1,10000018);
    	}
    	
    	public static int Random(int begin, int universe)
    	{
    		Random rand1 = new System.Random();
    		return rand1.Next(begin ,universe);
    	}
    	
       /**	
        Define maximum length L of a phone number
		Convert phone numbers to integers from
		0 to 10^L − 1
		Choose prime number p > 10^L
		Choose hash table size m
		Choose random hash function from
		universal family ℋp (choose random
		a ∈ [1, p − 1] and b ∈ [0, p − 1])
        */
       /*
        public static int HashingPhoneNumber(int number)
        {
        	//FIXED VALUE USED ONLY FOR DIDACTIC PURPOSES*
        	int 	primeNumber = 	10000019;
        	ulong 	hashTableSize = 100000;
        	
        	ulong a = firstHash;
        	ulong b = secondHash;
        	
        	ulong result = ((a * (ulong)number + b) % (ulong)primeNumber);
			result = result % hashTableSize;
			return (int) result;
        }
    }
    */