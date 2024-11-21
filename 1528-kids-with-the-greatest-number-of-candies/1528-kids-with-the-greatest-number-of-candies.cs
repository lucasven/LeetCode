public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> output = new List<bool>();
        foreach(var candie in candies)
        {
            if(candie + extraCandies >= candies.Max())
                output.Add(true);
            else
                output.Add(false);
        }
        return output;
    }
}