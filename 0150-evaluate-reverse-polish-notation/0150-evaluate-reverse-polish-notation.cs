public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> temp = new Stack<int>();
        for(int i = 0; i < tokens.Length; i++)
        {
            if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
            {
                int pop2 = temp.Pop();
                int pop1 = temp.Pop();
                switch(tokens[i]){
                    case "+": temp.Push(pop1 + pop2);break;
                    case "-": temp.Push(pop1 - pop2);break;
                    case "*": temp.Push(pop1 * pop2);break;
                    case "/": temp.Push(pop1 / pop2);break;
                }
            }
            else
            {
                temp.Push(Int32.Parse(tokens[i]));
            }

        }
        return temp.Pop();
    
    }
}