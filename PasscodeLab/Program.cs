// Description
// A door has a keypad entry. The combination to get in is 13579. Write a while loop (not a do while loop) that asks the user to enter a key code. 
// The loop will repeat as long as the user enters the wrong code. After the user enters the correct code, the program will print out a welcome message.
bool successUnlocked = false;

int timesAttempted = 1;

while (!successUnlocked && timesAttempted <= 5)
{
    Console.WriteLine("Please enter a passcode:");
    int Passcode = int.Parse(Console.ReadLine());
    if (Passcode == 13579)
    {
        Console.WriteLine("Success! You have entered the correct passcode!");
        successUnlocked = true;
    }

    else if (Passcode != 13579)
    {
        timesAttempted += 1;
        Console.WriteLine("Incorrect - Try again!");
        successUnlocked = false;
        if (timesAttempted == 6)
        {
            Console.WriteLine("There have been too many attempts to gain access, self destruction in 5....4...3...2....1!");
        }
    }
}