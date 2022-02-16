


using System;
using System.Collections.Generic;

public class Test{
    static void Main(string[] args){
        List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    	list1.Remove(5);
		foreach (var item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(list1.Count);
    }
}