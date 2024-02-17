//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//my intro by console.writeline//

//string fire = "tooba tariq";
//Console.WriteLine(fire);

// lil program convertor dollar into pkr//


//int resulr = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"dollar to pkr is {resulr*278.59} ");

//second program by helping arthimatic operators


//int a = 4;
//a = a + 5;
//Console.WriteLine(a);

//int b = 4;
//b = b + 5;
//Console.WriteLine(b);

//if(a == b && b == a)
//{
//    Console.WriteLine("both condition are true");
//}
//else
//{
//    {
//        Console.WriteLine("false condition");
//    }
//}

//int num = (35 + 5) % 7;
//Console.WriteLine(num);
                               

                                    //new programm



        string str; // Declaring a variable to store the input string

        // Prompting the user to input a string
        Console.Write("Input a string : ");
        str = Console.ReadLine(); // Reading the input string from the user

        // Checking if the input string has a length of at least 1 character
        if (str.Length >= 1)
        {
            var s = str.Substring(0, 1); // Extracting the first character of the string

            // Printing the string with the first character added at the beginning and end
            Console.WriteLine(s + str + s);
        }
