using System;



class X_base
{
    public int val;
}



class Y_child : X_base {
    public int a;
}

delegate X_base changeIt(Y_child y);
delegate Y_child changeIt2(Y_child x);
class ContraVariance {

    //contraconvariance
    public static X_base incrA(X_base obj) {

        Y_child temp = new Y_child();
        temp.val = obj.val + 10;
        return temp;
    }

    //convariance
    public static Y_child incrB(Y_child obj)
    {
        Y_child temp = new Y_child();

        temp.val = obj.val + 1;

        return temp;
    }


}


delegate int CountIt(int end);
class counter
{
    public static CountIt Counter()
    {
        int sum = 0;
        CountIt ct = delegate (int end)
        {
            sum = 0;
            for (int i = 0; i <= end; i++)
            {
                sum += i;

            }
            return sum;
        };
        return ct;
    }
}
