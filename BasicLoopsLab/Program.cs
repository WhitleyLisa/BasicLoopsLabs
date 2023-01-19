/// Description
// Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World!" ask the user whether they would like to continue.

bool keepGoing = true;

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue? (y/n)?");
    string userInput = Console.ReadLine().ToLower();

    if (userInput == "y" || userInput == "yes")
    {
        keepGoing = true;
    }
    else if (userInput == "n" || userInput == "no")
    {
        Console.WriteLine("See you next time!");
        keepGoing = false;
    }
}

while (keepGoing == true);


// 
// Prompt the user for a number. Use a for loop to output all the numbers from that number to 0. 
// After that loop finishes, use another loop to output all the numbers from 0 to that number.