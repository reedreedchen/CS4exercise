using System;

abstract class dog{
    public string name;
    protected string color;
    int _age;
    protected int birthYear;

    public dog(string name, string color, int age, int birthYear)
    {
        this.name = name;
        this.color = color;
        this.age = age;
        this.birthYear = birthYear;
    }
    public dog(dog i)
    {
        name = i.name;
        color = i.color;
        age = i.age;
        birthYear = i.birthYear;
    }


    public int age {
        get {
            return _age;
        }
        set {
            if (value > 0)
                _age = value;
        }
    }

    public abstract void speak(string[] c);
    public abstract void showInfo();

}

class pug : dog {
    public bool snorer;



    public pug(string name, string color, int age, int birthYear, bool snorer) : base(name, color, age, birthYear)
    {
        this.snorer = snorer;
    }

    public pug(pug i) : base(i)
    {
        snorer = i.snorer;
    }

    public override void showInfo() {
        Console.WriteLine("Name:{0}\nColor: {1}\nAge: {2}\nBirth Year: {3}\nSnore: {4}\n", name, color, age, birthYear, snorer);
    }

    //try overriding Equal, ==, !=, GetHashCode

    public override bool Equals(object obj)
    {
        pug temp = (pug) obj;
        if (temp.name == name) return true;
        else
            return false;
    }
    public override int GetHashCode()
    {
        return name.GetHashCode();
    }

    public static bool operator ==(pug pugA, pug pugB) {
 
        if (pugA.name == pugB.name) return true;
        else
            return false;
    }

    public static bool operator !=(pug pugA, pug pugB)
    {
        if (pugA.name == pugB.name) return false;
        else
            return true;
    }
    string[] dialog;
    public override void speak(string[] dialog)
    {
        if (dialog.Length > 3) throw new dogException();


        this.dialog = new string[dialog.Length];   

        for (int i = 0; i < dialog.Length; i++) {
            this.dialog[i] = dialog[i];
        }


        for (int i = 0; i <= dialog.Length; i++)
        {
            Console.WriteLine(name + " says: " + dialog[i]);
        }
     }
}

class chihuahua : dog {

  
    bool isGroomed;
    public chihuahua(string name, string color, int age, int birthYear, bool isGroomed) : base(name, color, age, birthYear)
    {
        this.name = name;
        this.color = color;
        this.age = age;
        this.birthYear = birthYear;
        this.isGroomed = isGroomed;
    }


    public override void showInfo()
    {
        Console.WriteLine("Name:{0}\nColor: {1}\nAge: {2}\nBirth Year: {3}\nGroomed: {4}\n", name, color, age, birthYear, isGroomed);
    }
    string[] dialog;
    public override void speak(string[] dialog)
    {
     //   if (dialog.Length > 3) throw new dogException();


        this.dialog = new string[dialog.Length];

        for (int i = 0; i < dialog.Length; i++)
        {
            this.dialog[i] = dialog[i];
        }


        for (int i = 0; i <= dialog.Length; i++)
        {
            Console.WriteLine(name + " says: " + dialog[i]);
        }
    }

}

class dogException : Exception {

    public dogException() { Console.WriteLine("error: dog talks too much"); }
    public dogException(string message):base(message) {
        Console.WriteLine(message);
    }
    public dogException(string message, Exception innerException) : base(message, innerException) { }
    protected dogException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    public override string ToString()
    {
        return Message;
    }

}