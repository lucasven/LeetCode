public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] charCount = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            charCount[s[i] - 'a']++;
            charCount[t[i] - 'a']--;
        }
        foreach (var count in charCount)
        {
            if (count != 0)
                return false;
        }
        return true;
    }
}