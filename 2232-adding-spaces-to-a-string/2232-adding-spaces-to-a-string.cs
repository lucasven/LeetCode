public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        StringBuilder sb = new StringBuilder("");
        if(spaces[0] == 0)
            sb.Append(" ");
        else
        {
            sb.Append(s.Substring(0, spaces[0]));
            sb.Append(" ");
        }
        for(int i = 1; i < spaces.Length; i++)
        {
            var spaceBefore = spaces[i-1];
            var spaceAfter = spaces[i];
            var substr = s.Substring(spaceBefore, spaceAfter- spaceBefore);
            sb.Append(substr);
            sb.Append(" ");
        }
        sb.Append(s.Substring(spaces[spaces.Length-1], s.Length-spaces[spaces.Length-1]));
        return sb.ToString();
    }
}