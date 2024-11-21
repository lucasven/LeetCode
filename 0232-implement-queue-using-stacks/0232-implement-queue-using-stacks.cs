public class MyQueue {
    private Stack<int> inputStack = new Stack<int>();
    private Stack<int> outputStack = new Stack<int>();

    public void Push(int x) {
        inputStack.Push(x);   
    }
    
    public int Pop() {
        if(outputStack.Count == 0)
        {
            while(inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }
        return outputStack.Pop();
    }
    
    public int Peek() {
        if(outputStack.Count == 0)
        {
            while(inputStack.Count > 0)
                outputStack.Push(inputStack.Pop());
        }
        return outputStack.Peek();
    }
    
    public bool Empty() {
        return inputStack.Count == 0 && outputStack.Count == 0;
    }
}
// public class MyQueue {
    

    

// }

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */