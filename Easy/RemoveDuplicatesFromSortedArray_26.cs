namespace LeetCode.Easy;

/// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class RemoveDuplicatesFromSortedArray_26
{
    public int RemoveDuplicates(int[] nums) {
        var k = 1;
        var prev = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != prev)
                nums[k++] = nums[i];
            prev = nums[i];
        }
        return k;
    }
}