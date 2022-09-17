// This is a comment to my code: ＞︿＜
// Application asks for your name.
// Application greets the user by their name. 

Console.WriteLine("Enter your name:"); // Output

// String - stores word type of data.

string username = Console.ReadLine(); // Input
Console.WriteLine("Okay, so you are " + username + "!"); // Output

// String interpolation (Better thing to use.)

Console.WriteLine($"Okay, so you are {username}!"); // Output