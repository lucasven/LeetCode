public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var splitted = sentence.Split(' ');
        for(int i = 0; i < splitted.Length; i++)
        {
            if(splitted[i].StartsWith(searchWord))
                return i+1;
        }
        return -1;
    }
}