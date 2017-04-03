using System;
using System.Reflection;

class main
{

    public static void Main()
    {

        Assembly assem = Assembly.LoadFrom("C:/Users/Renee/Desktop/CS4exercise/forPrimeSys/ClassLibrary2/bin/Debug/ClassLibrary2.dll");
        Type[] assem_t = assem.GetTypes();
        
        foreach (Type t in assem_t)
        {
            Console.Write("type name: "+ t.Name);
            ConstructorInfo[] cons_info = t.GetConstructors();

            for(int y = 0; y < cons_info.Length; y++)
            {
                ParameterInfo[] pa = cons_info[y].GetParameters();
                 
                if (pa.Length > 0)
                {
                    if (y == 0)
                    {
                        Console.Write("(");
                    }
                    foreach (ParameterInfo p in pa)
                        Console.Write(p.ParameterType + " " + p.Name);

                    if (y == pa.Length - 1)
                    {
                        Console.WriteLine(")");
                    }
                }
                else
                {
                    Console.WriteLine();   
                }


                
            }
        }
    }
}



class interrogateAssenbly
{


}
