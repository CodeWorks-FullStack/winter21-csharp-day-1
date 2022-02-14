
namespace csharp_day_1.models
{
  // access modifier (public, internal, protected, private)
  public class User
  {
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Greeting { get; set; }
    // Private can only be accessed within the class definition
    private User? MyValentine { get; set; }


    public void AddValentine(User v)
    {
      MyValentine = v;
    }

    public void RemoveValentine()
    {
      MyValentine = null;
    }


    // METHOD
    // Access modifier, return type, name
    public string GreetValentine()
    {
      string message = "Happy Valentines Day";
      if (MyValentine != null)
      {
        return message += " to " + MyValentine.Name;
      }
      return message;
    }




    // Constructor access modifier will always be public, no return type, method name is the same as the class
    public User(string name, int age, string greeting, User? myValentine)
    {
      Name = name;
      Age = age;
      Greeting = greeting;
      MyValentine = myValentine;
    }
  }
}