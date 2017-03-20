
/*
 * I just started an empty project.
 * 
 * I am testing it.
 * 
 * and this multiline comment.
 * */

using System;
//namespace->defines a declarative region->doesn't conflict 
//System is the namespace reserved for items associated with the .NET Framework class library
//I can create my own namespace
namespace Renee
{
    class Tests
    {
        public static void sayHi() //entry point. always runs first. the static modification makes sure Main runs before the objects this class defines are created.
        {
            Console.WriteLine("Hello. This is Renee.");//WriteLine is a member of the Console class. The string is pass to WriteLine's argument.
        }

        public static void variables()
        {
            int x, y;

            x = 100;
            Console.WriteLine("x contains " + x); //it can output value of any C# built-in types
            y = x / 2;
            Console.Write("x/2=");
            Console.WriteLine(y);
        }
        public static void floatDouble()
        {
            double doubleVar;
            float fVar;
            decimal decimalVar;

            doubleVar = 100f / 3;
            fVar = 100f / 3;
            decimalVar = 100;
            decimalVar /= 3;
            Console.WriteLine("doubleVar = " + doubleVar);
            Console.WriteLine("fVar = " + fVar);
            Console.WriteLine("decimalVar = " + decimalVar);
        }
        public static void circles()
        {
            double area;

            area = 10f;
            Console.WriteLine("radius = " + Math.Sqrt(area / 3.1416));
        }
        public static void identifierTest()
        {
            var @for = 100f; // @ can be the identifier.

            @for = @for / 3;

            Console.WriteLine("@for = " + @for);
        }
        public static void trigonometry()
        {
            for (double theta = 0; theta <= 360; theta += 45)
            {
                Console.WriteLine("Sine of " + theta + " is " + Math.Sin(theta * Math.PI / 180));
                Console.WriteLine("Cosine of " + theta + " is " + Math.Cos(theta * Math.PI / 180));
                Console.WriteLine("Tangent of " + theta + " is " + Math.Tan(theta * Math.PI / 180));
            }
        }
        public static void discount()
        {
            decimal price = 19.95m;
            Console.WriteLine("price = " + (price - (price * 0.15m)));
        }
        public static void @char()
        {
            char ch = '8';

            Console.WriteLine(ch);

        }

        public static void format()
        {

            Console.WriteLine("February has {0,5} or {1} days.", 28, 29);
            Console.WriteLine("Here is\t 100000000000.0/3: {0,5:###,###.#}", 100000000000.0 / 3.0);

            Console.WriteLine("Here is\t 100000000000.0/3: {0,5:C}", 100000000000.0 / 3.0);
            Console.WriteLine(@"Value\tSquared\tCubed");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
            }
        }
        public static void hypotenuse()
        {
            double s1 = 4, s2 = 5;

            double hypotenuse = Math.Sqrt((s1 * s1) + (s2 * s2));

            Console.WriteLine("Hypotenuse of triangle with sides {0} by {1} is {2:#.##}", s1, s2, hypotenuse);
        }
        public static void casting()
        {
            int vInt = 258;
            Console.WriteLine("(byte)int is " + (byte)vInt);// data lost

            int xInt = 88;
            Console.WriteLine("xChar=" + (char)xInt);

        }
        public static void bitwiseOperators()
        {
            ushort num;
            for (int i = 1; i <= 10; i++)
            {
                num = (ushort)i;//1
                Console.WriteLine("num: {0}", num);
                num = (ushort)(num & 0xFFFE);//001 & 1111111111111110 & -> only when both are 1, the result will be one
                Console.WriteLine("num after turning off bit zero: {0}\n", num);

            }
        }

        public static void oddNumber()
        {
            int num;
            num = 10;//11
            if ((num & 1) == 0) //1011 & 1 = 1
                Console.WriteLine("num: {0}\n", num);
        }

        public static void showBits()
        {
            int t;
            sbyte b = -34;
            string result;
            for (t = 128; t > 0; t /= 2)
            {

                result = ((b & t) != 0) ? "1" : "0";
                Console.Write(result);
            }

            Console.WriteLine();
            for (t = 128; t > 0; t /= 2)//128 64 32 16 8 4 2 0
                                        //1   0   0  0 0 0 0 0
            {
                result = ((b & t) != 0) ? "1" : "0";
                Console.Write(result);
            }
        }

        public static void shifts()
        {
            int val = 1;
            string result;

            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    result = ((val & t) != 0) ? "1" : "0";
                    Console.Write(result);
                }
                Console.WriteLine();
                val = val << 1; //shift left doubles the value, shift right squire root the value
            }
        }
        public static void shiftDevide()
        {
            int n;
            n = 10;

            n = n << 1;
            n = n >> 1;
            Console.WriteLine("n={0}", n);
        }

        public static void questionMark()
        {
            for (int i = -5; i < 6; i++)
            {
                if (i != 0 ? (i % 2 == 0) : false)
                {
                    Console.WriteLine("100/{0} is {1}.", i, 100 / i);
                }
            }
        }

        public static void charPlus()
        {
            for (char ch = '0'; ch <= 'Z'; ch++)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }

        public static void swithcNoFallThrough()
        {
            for (int i = 0; i < 11; i++)
            {
                switch (i)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("1 or 2");
                        break;
                    default:
                        Console.WriteLine("else");
                        break;
                }

            }
        }

        public static void findPrime()
        {

            int num;
            int i;
            int factor;
            bool isPrime;

            for (num = 2; num < 20; num++)
            {
                isPrime = true;
                factor = 0;

                for (i = 2; i <= num / 2; i++)
                { //1 * num = num, 2 * largest factor = num
                    if ((num % i) == 0)
                    {
                        isPrime = false;
                        factor = i;
                    }
                };
                Console.WriteLine(isPrime ? (num + "is prime.") : ("Largest factor of " + num + " is " + factor + "."));
            }
        }

        public static void findFactor()
        {
            int i;
            int smallestFactor, largestFactor;
            int num;

            num = 100;

            smallestFactor = largestFactor = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if ((smallestFactor == 0) && (num % i == 0)) smallestFactor = i;
            }

            largestFactor = num / smallestFactor;
            Console.WriteLine("Smallest Factor: " + smallestFactor);
            Console.WriteLine("Largest Factor: " + largestFactor);

        }

        public static void tryGoto()
        {
            int x = 1;
        loop1: x++;
            if (x < 100) goto loop1;
            Console.WriteLine(x);
        }

        public static void build()
        {
            //  Building house = new Building("house1", 2, 500, 3);
            //   Building house2 = new Building("house2", 5, 5000, 2);

            //  house = house2;

            //   Console.WriteLine("{0} people lives in house1.{1} lives in house 2", house.occupants, house2.occupants);//2,2
            //   Console.WriteLine("Each occupant shares {0} units of the house.", house.areaPerPerson());
        }


        public static void tryString()
        {
            char[] charray = new char[] { 't', 'e', 's', 't' };
            string str1 = new string(charray);
            string str2 = "test this";
            string str3 = str2.Substring(5, 4);
            Console.WriteLine(str1);

            Console.WriteLine(str3);

        }

        public static void aboutStack()
        {

            Stack stck = new Stack(6);
            string str = "i love";
            //stack
            foreach (char c in str)
            {
                if (!stck.IsFull()) stck.Push(c);
            }
            string str1 = "";

            //pop
            for (int i = 0; !stck.IsEmpty(); i++)
            {
                str1 += stck.Pop();
            }
            Console.WriteLine(str1);
        }


        public static void valueTypeRef()
        {
            int value;
            value = 5;

            refIteration.minus(ref value, 1);

            int doubleSize;
            value = refIteration.plusAndDouble(value, 5, out doubleSize);

            Console.WriteLine(value + ", " + doubleSize); //5-1+5 = 9, 8;

        }

        public static void swapHouse()
        {
            /*
            Building house1 = new Building("house1", 2, 1000, 5);
            Building house2 = new Building("house2", 5, 3000, 10);

            Building.swapHouse(ref house1, ref house2);

            Building[] houses = { house1, house2 };

            Building combinedHouse;
            Building.combine(out combinedHouse, houses);

            if(combinedHouse.buildingName != null)
                Console.WriteLine("{0}+{1}+{2}+{3}", combinedHouse.buildingName, combinedHouse.floors, combinedHouse.area, combinedHouse.occupants);

            */
        }
        public static void tryFindMinValue()
        {
            int min;
            min = refIteration.minValue(50, 88, 1021, 943, 898);
            Console.WriteLine("minValue: " + min);
        }
        /*
                public static void houseFactory()
                {
                    Building house3 = Building.CreateBuilding("house3", 5, 2000, 2);
                    house3.ShowHouseInfo();
                }
                */
        public static void houseThis()
        {
            Building house3 = new Building(5, 3000);
            Console.WriteLine("overloading constructor invoke: " + house3.buildingName);
            Building house4 = new Building { buildingName = "house5", floors = 10, area = 3000, occupants = 20 }; //object initializers, mostly used only for LINQ expressions
            Console.WriteLine("object initializer:" + house4.buildingName);
            house4.setBuildingName(); //if name is not entered, it runs the default one;
            Console.WriteLine("Optional Arguments:" + house4.buildingName);
        }
        public static void tryRecrusion()
        {
            recursion.DisplayRev("this is fun.");
        }
        public static void operatorOverloading()
        {
            Building house3 = new Building("house3", 5, 3000, 10);
            Building house4 = new Building { buildingName = "house5", floors = 10, area = 3000, occupants = 20 };
            Building house5 = new Building();

            house5 = house3 + house4; // operator overloading 
            house3 -= 3; // operator overloading 
            Console.WriteLine(house5.buildingName + ", " + house5.floors + ", " + house5.area + ", " + house5.occupants);
            Console.WriteLine(house3.buildingName + " has " + house3.occupants + " tenets.");

            int a = house5;

            Console.WriteLine(a);
            car beetle;

            beetle = (car)house5;

            Console.WriteLine("\"" + beetle.carName + "\" has " + beetle.occupantsNum + "occupants");

        }

        public static void carIndexer()
        {
            car beetle = new car("beetle", 1, 2, 2);
            Console.WriteLine(beetle.occupantsNum);
        }


        public static void dogInheritance()
        {
            pug Emma = new pug("Emma", "fawn", 3, 2014, false);

            chihuahua Eagle = new chihuahua("Eagle", "fawn", 6, 2010, false);
            Emma.showInfo();
            pug Emily = new pug(Emma);



            Emily.name = "Emily";

            Console.WriteLine("Equals: " + Emily.Equals(Emma));
            Console.WriteLine("Operator Equals: " + (Emily == Emma) + "\n");
            Emily.showInfo();
            Eagle.showInfo();

            int i = 5;
            object a = i;
            Console.WriteLine(a);
            try
            {
                try
                {
                    Emma.speak(new string[] {"hi","my name is Emma.","I am a talkative pug", "as you can see"} );
                    Eagle.speak(new string[] {"hi", "my name is Eagle."});

                  //  throw new DivideByZeroException(); //manually throw to catch
                }
                catch // this will catch dogException
                {

                    Console.WriteLine("bad");
                    //throw; //manually throw outter catch
                }
                finally {
                    Console.WriteLine("finally");
                }
            }
            catch {
                Console.WriteLine("got");
            }

        }


        public static void tryInterface()
        {
            Animal newAnimal = new Animal("buddy", "bird");
            Cat newCat = new Cat("kitty", "black", 2);

            newAnimal.ShowInfo();
            newCat.ShowInfo();

            for (int i = 0; i < newAnimal.legNumber; i++)
            {
                newAnimal[i] = newAnimal.name + "'s Leg " + (i + 1) + " is in a good condition.";
                Console.WriteLine(newAnimal[i]);
            }
            Console.WriteLine();
            newCat.nameChange("fatCat");
            for (int i = 0; i < newCat.legNumber; i++)
            {
                newCat[i] = newCat.name + "'s Leg " + (i + 1) + " is in a good condition.";
                Console.WriteLine(newCat[i]);
            }


        }

        public static void tryEnum() {

            mouse.findMouse(mouse.mouseType.pink);
            
        }

        public static void checkOverflow()
        {
            byte a = 127;
            byte b = 127;
            try
            {
                Console.WriteLine(unchecked((byte)(a * b)));
            }
            catch (OverflowException exc) {
                Console.WriteLine(exc);
            }
        }

    }
}