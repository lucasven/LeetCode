public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        if(k == 1 && nums.Count >= 2) return true;
        if(nums.Count < k) return false;
        List<int> subArrayIndexes = new List<int>();
        
        for(int i = 0; i < nums.Count - k + 1; i++)
        {
            bool isIncreasing = true;
            for(int j = i; j < i + k - 1; j++)
            {
                if(nums[j] >= nums[j+1])
                {
                    isIncreasing = false;
                    break;
                }
            }
            if(isIncreasing)
            {
                subArrayIndexes.Add(i);
            }
        }
        foreach(var subInd in subArrayIndexes)
        {
            if(subArrayIndexes.Any(c => c == subInd+k))
                return true;
        }
        return false;
    }
}