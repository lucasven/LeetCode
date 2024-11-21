public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int biggestLength = word1.Length > word2.Length ? word1.Length : word2.Length;
        
        string output = "";
        for(int i = 0; i < biggestLength; i++)
        {
            if(word1.Length > i)
                output += word1[i];
            if(word2.Length > i)
                output += word2[i];
        }
        return output;
    }
}