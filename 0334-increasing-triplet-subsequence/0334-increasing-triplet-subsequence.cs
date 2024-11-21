public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int n = nums.Length;
        if(n < 3)
            return false;
        
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;
        for(int k = 0; k<n;k++)
        {
            if(nums[k] <= smallest)
                smallest = nums[k];
            else if(nums[k] <= secondSmallest)
                secondSmallest = nums[k];
            else
                return true;
        }
        return false;
    }
}