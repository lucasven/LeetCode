public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i] == 0)
            {
                bool usedWhile = false;
                int j = 1;
                while(nums.Length > i+j+1 && nums[i + j] == 0)
                {
                    if(nums.Length > i+j+1 && nums[i + j + 1] == 0)
                    {
                        j++;
                        continue;
                    }
                    j++;
                    usedWhile = true;
                    nums[i] = nums[i+j];
                    nums[i+j] = 0;
                    break;
                }
                if(!usedWhile)
                {
                    usedWhile = false;
                    nums[i] = nums[i + 1];
                    nums[i + 1] = 0;
                }
            }
        }
    }
}