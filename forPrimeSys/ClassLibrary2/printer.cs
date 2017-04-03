using System;

public class printer{

    internal string i;

    public printer(string i)
    {
        this.i = i;
    }

    public void print()
    {
        Console.WriteLine(i);
    }

}