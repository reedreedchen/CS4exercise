using System;
delegate void countIt();
delegate string StrMod(string str);

class try_delegate
{    
    public static string ReplaceSpaces(string s)
    {
        return s.Replace(' ', '-');
    }

    public static string RemoveSpaces(string s)
    {
        string temp = "";
        int i;

        for (i = 0; i < s.Length; i++)
            if (s[i] != ' ') temp += s[i];

        return temp;
    }

    public static string reverseSTring(string s)
    {
        string temp = "";
        int i;
        for (i = s.Length-1; i >=0 ; i--)
        {
            temp += s[i];
        }
        return temp;
    }
          
}
