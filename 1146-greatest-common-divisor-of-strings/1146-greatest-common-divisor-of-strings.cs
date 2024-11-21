public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(str1+str2 != str2+str1)
            return "";

        return str1.Length > str2.Length ?
            str1.Substring(0, GCD(str1.Length, str2.Length)) :
            str2.Substring(0, GCD(str2.Length, str1.Length));
    }

    private int GCD(int a, int b)
    {
        if(b == 0)
            return a;
        return GCD(b, a % b);
    }
}