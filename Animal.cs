abstract class Animal
{
    // How much oxygen and food the animal consumes
    // X - fields can't be abstract, use property instead
    //abstract public int size = 1;
    public int size = 1;
    //required means the object creator needs to set it, so incompatible with protected
    //protected required string NAME;
    protected readonly string? name;
    // X - static also can't be marked abstract - static means it can't change between instances, so why would it b
    //abstract static int REQUIRED_FOOD = 6;
    const int REQUIRED_FOOD = 7;

    private int _foobar = 5;

    protected Animal(string name)
    {
        this.name = name;
        Console.WriteLine("I am an animal");
    }

    public int rawField = 5;

    public int GetManualProperty()
    {
        return _foobar;
    }

    public void SetManualProperty(int new_foobar)
    {
        _foobar = new_foobar;
    }

    public int ProperProperty { get; set;} = 5;

    private float growth_progress;
    protected int growth_rate;

    // idk why I used a property, it only needs to be set once and doesn't need getting outside of it
    // public abstract int growth_rate
    // {
    //     get;
    //     set;
    // }

    public int Breathe(int oxygen)
    {
        return oxygen - size;
    }

    public void Eat(int food)
    {
        Console.WriteLine($"Current {growth_progress}");
        growth_progress += food * growth_rate;
        if (growth_progress >= REQUIRED_FOOD)
        {
            int initial_size = size;
            size++;
            growth_progress -= REQUIRED_FOOD;
            Console.WriteLine($"I have grown from {initial_size} to {size} ({food} {growth_progress})");
        }
    }

    public abstract string Speak();
}

class Cat : Animal
{
    public Cat() : base("cat")
    {
        // In Java super() must be the first call if used, in C# it's inline
        growth_rate = 2;
        Console.WriteLine($"I am a {name} and the above ^");
    }

    // This would really be implemented in Animal and set the different "word" for each animal in constructor
    // Keep it like this anyway as an example of abstract
    public override string Speak()
    {
        /*switch(size)
        {
            case 1:
                return "meow";
            case 2:
                return "MEOW";
            default:
                return "BIG MEOW";
        }*/
        return size switch
        {
            1 => "meow",
            2 => "MEOW",
            _ => "BIG MEOW"
        };
    }

    public void FurBall()
    {
        Console.WriteLine("hoiking up some fur");
    }

    public void Run()
    {
        Console.WriteLine($"Running like a {name}");
    }
}

class Dog : Animal
{
    public Dog() : base("dog")
    {
        growth_rate = 1;
        Console.WriteLine($"I am a {name} and the above ^");
        // not possible to call super in c#? I think it is in Java, and almost definitely Python
        // base()
    }

    public override string Speak()
    {
        return size switch
        {
            1 => "woof",
            2 => "WOOF",
            _ => "BIG WOOF",
        };
    }

    public void Fetch()
    {
        Console.WriteLine("gimme stick");
    }

    public void Run()
    {
        Console.WriteLine($"Running like a {name}");
    }
}

// Make it into an interface? Then make dog and cat which inherit from it?