using System;

namespace SkalProj_Datastrukturer_Minne

/*
 1.  Stack och heap.   
Stack – LIFO (last in first out)
Används för statisk minneshantering med LIFO tänk.
Variablarna ”lagras” direkt i minnet och är lätta att få tag i.
När en metod anropas som kontaktar en ytterligare metod och så vidare så pausas svaret innan alla metoder har anropats och metodens returnerar sitt värde.
Stacken är trådspecifik.
Ansvarig för att hålla reda på koden och vilken kod som körs.
Stacken är självförsörjande, vilket innebär att den i princip tar hand om sin egen minneshantering. 

Heap
Används för dynamisk minneshantering. 
Är applikationsspecifik.
Ansvarig för att hålla reda på våra objekt.
Det finns ingen begränsning för vad som kan nås i stacken.  
Heap har Garbage Collection (GC).
Hanterar reference types

Båda lagras i datorns RAM-minne.

2.     Value type o reference types

Value types och reference types är de två huvudkategorierna i C#.
En variabel av en value type innehåller en instans av typen. Ligger i System.ValueType och är t ex bool, double eller char.
Reference type skiljer sig och innehåller en referens till en instans, d v s inte innehåller det faktiska värdet. Den ärver av System.Object och är t ex en class, object eller interface.

3.    
a.     Du skapar x och ger den ett värde av 3. Du skapar y och skriver y = x men samtidigt så ger du y ett värde av 4. Här ändras inte värdet x. Du returnerar här det värdet du eftersöker x vilket är 3.  En value type.
b.     Du skapar ett objekt med värdet x. Därefter skapar du ett objekt med värdet y. y = 3 blir tre men därefter så ändrar du y till 4. Du returnerar värdet y som då blir 4. En reference types
  */
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.substring(1);

            do 
            { 
                Console.WriteLine("Add or remove item to/in list below");
                value = value.Trim();
            
            }
            switch(nav)
            {
                case '+':
                    theList.Add(value);
                    break;
                case '-':
                    theList.Remove(value);
                    break;
                default:    
                    Console.WriteLine("Please add or remove item. ");
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

