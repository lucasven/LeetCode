public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // Sort the array of strings
        Array.Sort(strs);
        
        // Use StringBuilder to store the common prefix
        StringBuilder sb = new StringBuilder();
        
        // Get the first and last strings in the sorted array
        string first = strs[0];
        string last = strs[strs.Length - 1];
        
        // Compare characters of the first and last strings
        for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
        {
            if (first[i] != last[i])
            {
                return sb.ToString();
            }
            sb.Append(first[i]);
        }
        
        return sb.ToString();
    }
}