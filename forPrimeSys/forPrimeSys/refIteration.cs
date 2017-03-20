using System;

class refIteration
{

    public static void minus(ref int original, int howMuch)
    {
        original -= howMuch;
    }
    public static int plusAndDouble(int original, int howMuch, out int doubleSize) {

        doubleSize = original * 2;

        return original + howMuch;
    }
    public static int minValue(params int[] nums) {

        int m;

        if (nums.Length == 0) { Console.WriteLine("no arguments."); return 0; }

        m = nums[0];

        for (int i = 0; i < nums.Length; i++) {
            if(nums[i] < m) m = nums[i];
        }

        return m;
    }

}