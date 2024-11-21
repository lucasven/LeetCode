public class Solution {
    public string ReverseWords(string s) {
        var splited = s.Trim().Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
        return String.Join(" ", splited);
    }
}