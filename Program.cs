// ENTRY POINT INTO THE CSHARP APP #
// using == import
using csharp_day_1.models;

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

Console.Clear();

// Console.WriteLine("Welcome To Skynet");

// Console.Write("Username: ");
// var name = Console.ReadLine();

// Bool and conditional
// if (name != null)
// {
//   Console.WriteLine($@"
// Hello {name}");

// }

// Collection types (arrays suck!)

// string[] names = new string[3] { "mark", "jake", "harrington" };
// names[0] = "Mark";
// names[1] = "Jake";
// names[2] = "Harrington";
// names[1] = null;

// List<string> names = new List<string>() { "mark" };
// names.Add("Jake");
// names.Add("Harrington");

// names.Remove("Jake");

// for (int i = 0; i < names.Count; i++)
// {
//   System.Console.WriteLine(names[i]);
// }
// names.ForEach(n => Console.WriteLine(n));


// Objects (or the lack there of)
// DO NOT USE PLAIN OL C# OBJECTS (POCO)

// dictionary ( key, value )

// Dictionary<string, string> greetings = new Dictionary<string, string>(){
//   {"mark", "M'Lord"},
//   {"jake", "Sir"},
//   {"harrington", "Bro"}
// };

// greetings.Add("brittany", "M'Lady");
User jake = new User("Jake", 33, "Sir", null);


User mark = new User("Mark", 33, "M'Lord", null);
User brittany = new User("Brittany", 33, "M'lady", mark);
mark.AddValentine(brittany);

Card card = new Card(mark, brittany, "Happy Valentines Day!");
Card card2 = new Card(jake, mark, "Enjoy a week off!");

bool running = true;
while (running)
{
  System.Console.WriteLine(card.GetCard());
  System.Console.WriteLine(card2.GetCard());
  System.Console.WriteLine("Again? (y/n)");
  var choice = Console.ReadKey().KeyChar;
  if (choice == 'n')
  {
    running = false;
  }
}









// Dictionary<string, User> greetings = new Dictionary<string, User>()
// {
//   {mark.Name.ToLower(), mark},
//   {jake.Name.ToLower(), jake},
//   {brittany.Name.ToLower(), brittany},
// };

// if (greetings.ContainsKey(name.ToLower()))
// {
//   System.Console.WriteLine(greetings[name.ToLower()].GreetValentine());
// }
// else
// {
//   System.Console.WriteLine("new language who dis?");
// }





//------------------- RPS -------------//

// Choose Your Weapon
// choice: _____
/// (computer making random choice and returning "win", "lose", "draw")
// hint: set the values in an array and have random get a random index from the array

// Stretch goals 
// create a 'Game' class
// use a while loop for 'playing' and keep track of wins/losses/draws
// use a dictionary for win conditions
// rock, paper, scissors, lizard, spock


