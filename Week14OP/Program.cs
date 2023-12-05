Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);


Dog neighboursDog = new Dog("Good girl");



//myDog._name = "Good boy";
//neighboursDog._name = "Good girl";


Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbours dog name is {neighboursDog.Name}");


myDog.Rename("Bad boy");


while (myDog.levelofhapiness != 5)
{
    myDog = Bark();
}

myDog.WagTail();

class dog
{
    private string _name;
    private int _levelofhapiness;

    public dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelofhapiness = 0;
    }

    public string Name
    {
        get { return _name; }

    }


        public int levelofhapiness
    {
        get { return levelofhapiness; }   
    }
        
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof");
        _levelofhapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle");
    }

}