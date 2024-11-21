public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] temp = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < temperatures.Length; i++)
        {
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int a = stack.Pop();
                temp[a] = i - a;
            }
            stack.Push(i);
        }
        return temp;
    }
}