namespace LeetCode.Easy;

/// https://leetcode.com/problems/remove-element/
public class RemoveElement_27
{
    public int RemoveElement(int[] nums, int val)
    {
        var index = 0;
        foreach (var num in nums)
            if (num != val)
                nums[index++] = num;
        return index;
    }
}