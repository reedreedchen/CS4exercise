
using System;
using System.Linq;

class dog {
    internal string name;
    internal string color;
    int _age;
    internal int birthYear;

    public dog() { }

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


    public int age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value > 0)
                _age = value;
        }
    }
    

    public virtual void speak(string[] c) { }
    public virtual void showInfo() { }
    public static void sayhi1()
    {
        Console.WriteLine("hi");

    }

}

class pug : dog {
    public bool snorer;

    public pug() { }


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

    public override void speak(string[] dialog)
    {
     
       var selectedDialog = from n in dialog
                             where true
                             select n;

        foreach(string s in selectedDialog) 
            Console.WriteLine(name + " says: " + s);

        dialog[1] = "hehehe";

        foreach (string s in selectedDialog)
            Console.WriteLine(name + " says: " + s);
        if (dialog.Length >= 3) throw new dogException();
        //if (dialog.Length > 3) throw new dogException();
    }

    [Obsolete("this is obsolete", false)]
    [System.Diagnostics.Conditional("Trial")]
    public static void writedown()
    {
        Console.WriteLine("trial condition");

    }
}

class chihuahua : dog {

  
    public bool isGroomed;
    public chihuahua() { }
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

    public override void speak(string[] dialog)
    {
     //   if (dialog.Length > 3) throw new dogException();

        for (int i = 0; i < dialog.Length; i++)
            Console.WriteLine(name + " says: " + dialog[i]);

        dialog[1] = "hehehe";

        for (int i = 0; i < dialog.Length; i++)
            Console.WriteLine(name + " says: " + dialog[i]);
    }


    public static implicit operator pug(chihuahua i)
    {
        pug p = new pug(i.name, i.color, i.age, i.birthYear, i.isGroomed);
        return p;
    }

}

class dogException : Exception {

    public dogException() {}
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