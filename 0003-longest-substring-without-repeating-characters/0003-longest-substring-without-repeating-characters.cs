public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int maxLength = 0;
        int left = 0;
        for(int right = 0; right < s.Length; right++)
        {
            while(set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(maxLength, right-left+1);
        }
        return maxLength;
    }
}