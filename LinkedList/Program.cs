using System;
using LinkedList;


class Program
{
    static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Select a number: \n1.Adding Node ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Linked_List<int> list = new Linked_List<int>();
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    break;
                default:
                    Console.WriteLine("Wrong item selected. Try again.");
                    Console.WriteLine("\n");
                    break;
            }
        }
    }
        
}

    
            
    
