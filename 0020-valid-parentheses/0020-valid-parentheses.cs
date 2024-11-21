public class Solution {
    public bool IsValid(string s) {
        Stack<char> temp = new Stack<char>();
        foreach(char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
                temp.Push(c);
            else
            {
                if(temp.Count == 0)
                    return false;
                char top = temp.Pop();
                if((c == ')' && top != '(') ||
                (c == ']' && top != '[') ||
                (c == '}' && top != '{'))
                    return false;
            }
        }
        return temp.Count == 0;
    }
}