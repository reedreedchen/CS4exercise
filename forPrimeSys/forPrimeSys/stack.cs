using System;

class Stack {

    char[] stck;
    int tos; //index of the top of the stack

    public Stack(int stackSize) {
        stck = new char[stackSize];
    }


    public void Push(char ch) {
        if(tos == stck.Length) { Console.WriteLine(" -- Stack if full.");
            return;
        }

        stck[tos] = ch;
        tos++;
    }

    public char Pop()
    {
        if (tos == 0) {
            Console.WriteLine(" --Stack is empty. ");
            return (char)0;
        }

        tos--;
        return stck[tos];
    }

    public bool IsFull() {
        return stck.Length == tos;
    }

    public bool IsEmpty() {
        return tos == 0;
    }

    public int Capacity()
    {
        return stck.Length;
    }

    public int GetNum()
    {
        return tos;
    }
}