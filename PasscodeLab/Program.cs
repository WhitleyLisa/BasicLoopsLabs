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