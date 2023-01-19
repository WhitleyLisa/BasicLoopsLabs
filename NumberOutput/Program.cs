// Description 
// Prompt the user for a number. Use a for loop to output all the numbers from that number to 0. 
//After that loop finishes, use another loop to output all the numbers from 0 to that number.

string keepGoing = null;
do
{
    Console.WriteLine("Please enter an integer:");
    string usersInput = Console.ReadLine();

    Console.WriteLine();
    int usersNumber = int.Parse(usersInput);

    for (int i = usersNumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    for (int i = 0; i <= usersNumber; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Would you like to enter another integer? (y/n)");
    keepGoing = Console.ReadLine().ToLower();
    } 

while (keepGoing == "y");