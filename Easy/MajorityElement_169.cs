namespace LeetCode.Easy;

//https://leetcode.com/problems/majority-element
public class MajorityElement_169
{
    public int MajorityElement(int[] nums)
    {
        var topByCount = 0;
        var topCount = 0;
        
        foreach (var num in nums)
        {
            if (topCount == 0)
                topByCount = num;

            if (num == topByCount)
                topCount++;
            else
                topCount--;
        }

        return topByCount;
    }
}