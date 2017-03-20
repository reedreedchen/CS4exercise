﻿using System;

class recursion {

    public static void DisplayRev(string str) {
        if (str.Length <= 0) return;

        DisplayRev(str.Substring(1, str.Length - 1));

        Console.WriteLine(str[0]);
    }

}