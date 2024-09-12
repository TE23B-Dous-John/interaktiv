using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Username");
string name = Console.ReadLine();
name = name.ToLower();


{
    Console.WriteLine("WELCOME " + name);
}

Console.WriteLine(name + ", you are front of a black door, would you lika to open the door or go away. Open ore Away?");

string choice1 = Console.ReadLine().ToLower();

if ( choice1 == "open")
{
    Console.WriteLine("now, you see a light switch, would you like to turn, On ore off?");


    string choice2 = Console.ReadLine().ToLower();

    if (choice2 == "on")
    {
        Console.WriteLine("The room is to warm, would you like to jump of the window or be in the warm room, Jump or warm");

        string jump = Console.ReadLine().ToLower();
        if ( jump == "jump")
        Console.WriteLine("Congratulations, You are the stupidest man ever, you died");
    }

}

 if ( choice1 == "away")
{
    Console.WriteLine("Go home and play video games alone or play video games with your friends, friends or alone");

    string friends = Console.ReadLine().ToLower();
 
}


Console.ReadLine();


