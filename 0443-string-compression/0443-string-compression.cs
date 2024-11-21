public class Solution {
    public int Compress(char[] chars) {
        var iterationIndex = 0;
        var replaceIndex = 0;
        while(iterationIndex < chars.Length)
        {
            var currentChar = chars[iterationIndex];
            var currentCharCount = 0;

            while(iterationIndex < chars.Length && chars[iterationIndex] == currentChar)
            {
                iterationIndex++;
                currentCharCount++;
            }

            chars[replaceIndex++] = currentChar;

            if(currentCharCount > 1)
            {
                foreach(var charCount in currentCharCount.ToString())
                {
                    chars[replaceIndex++] = charCount;
                }
            }
        }
        return replaceIndex;
    }
}