public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            if(frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        return frequency.OrderByDescending(c => c.Value).Take(k).Select(c => c.Key).ToArray();
    }
}