using System;

public interface IAnimal
{
    string name {
        get;
        set;
    }
    string type
    {
        get;
        set;
    }
    string GetInfo();
    void ShowInfo();

    bool allowNameChange(string x);

    string this[int index]
    {
        get;
        set;
    }
}
class Animal : IAnimal {

    string _name;
    string _type;
    int _legNumber;
    string[] legCondition;

    public Animal(string name, string type, int legNumber = 4)
    {
        this.name = name;
        this.type = type;
        _legNumber = legNumber;
        legCondition = new string[4];
    }
    bool IAnimal.allowNameChange(string newName) {
        if (name == newName) return false;
        else return true;
    }

    public void nameChange(string newName) {
        IAnimal a = this;
        if (a.allowNameChange(newName))
            name = newName;
    }
    

    public string this[int index] {
        get
        {
            if (index >= 0 && index < 4)
                return legCondition[index];
            else
                return "wrong index";
        }
        set
        {
            if (index >= 0 && index < 4)
                legCondition[index] = value;
        }
    }

    public int legNumber
    {
        get
        {
            return _legNumber;
        }
    }
    public string name {
        get {
            return _name;
        }
        set {
            _name = value;
        }
    }

    public string type {
        get {
            return _type;
        }
        set {
            _type = value;
        }
    }


    public virtual string GetInfo()
    {
        return "Name: " + name + "\nType: " + type + "\n";
    }

    
    public virtual void ShowInfo()
    {
        Console.WriteLine(GetInfo());
    } 

    public static void sayHI()
    {
        Console.WriteLine("hi");

    }
}

class Cat : Animal {

    string color;
    int age;


    public Cat(string name, string color, int age) : base(name, "Cat")
    {
        this.name = name;
        this.color = color;
        this.age = age;
    }

 
    public override string GetInfo()
    {
        return "Name: " + name + "\nType: " + type + "\nColor: " + color + "\nAge: " + age;
    }

    public override void ShowInfo()
    {
        Console.WriteLine(GetInfo());
    }

}

struct mouse
{
    public enum mouseType { red, yellow, pink};

    public static void findMouse(mouseType mt)
    {
        switch (mt) {
            case mouseType.red:
                Console.WriteLine("red mouse");
                break;
            case mouseType.pink:
                Console.WriteLine("pink mouse");
                break;
            case mouseType.yellow:
                Console.WriteLine("yellow mouse");
                break;
            default:
                Console.WriteLine("no mouse");
                break;
    }

    }
}

