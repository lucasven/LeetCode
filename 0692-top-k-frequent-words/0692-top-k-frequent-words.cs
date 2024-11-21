public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach(var word in words)
        {
            if(frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        return frequency.OrderByDescending(c => c.Value).ThenBy(c => c.Key).Take(k).Select(c => c.Key).ToList();
    }
}