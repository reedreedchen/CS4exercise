using System;

class PowerOfTwo
{
    int savePwr;
    int pwr(int p)
    {
        int result = 1;
        for (int i = 0; i < p; i++)
        {
            result *= 2;
        }

        return result;
    }
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < 16) return pwr(index);
            else return -1;
        }
        set {
            if(index==1)
            savePwr = value;
       
        }
    }

    public static void runPowerOfTwo() {
        PowerOfTwo pwr = new PowerOfTwo();
        for (int i = 0; i < 16; i++)
        {
            Console.WriteLine(pwr[i]);
        }

        pwr[1] = 1000;
        Console.WriteLine(pwr.savePwr);
    }

}

