using System.Collections.Generic;

namespace DictionaryPractice;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> rookieOfTheYear = new Dictionary<int, string>();
        
        rookieOfTheYear.Add(2000,"John Doe");
        rookieOfTheYear.Add(2001,"Jane Doe");
        rookieOfTheYear.Add(2002,"Mike Tyson");
        rookieOfTheYear.Add(2023,"Jason Kelce");

        //Non zero based count of dictionary items
        Console.WriteLine(rookieOfTheYear.Count);

        //Retrieve value by key look up
        Console.WriteLine(rookieOfTheYear[2000]);

        //Dictionary can also store complex objects
        Dictionary<string, List<string>> wishList = new Dictionary<string, List<string>>();
        wishList.Add("Tim Corey",new List<string>{"Xbox", "Laptop", "Desk"});
        wishList.Add("Gaby",new List<string>{"House","Money","Peace"});

        //This is useful to know, you can specify you are looping through a key, value pair
        foreach (var (key,value) in wishList)
        {
             Console.WriteLine(key + " would like: ");
             foreach (var item in value)
             {
                Console.WriteLine(item);
             }
        }


        
    }
}
