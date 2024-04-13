namespace LeetCode.Medium;
//https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii
public class RemoveDuplicatesFromSortedArrayII_80
{
    public int RemoveDuplicates(int[] nums)
    {
        var k = 0;
        var shouldBeGraterThanPrev = false;
        for (var i = 1; i < nums.Length; i++)
        {
            var isCurrentTwice = nums[k] == nums[i];
            if(!isCurrentTwice || !shouldBeGraterThanPrev)
                nums[++k] = nums[i];
            shouldBeGraterThanPrev = isCurrentTwice;
        }
        Console.WriteLine(string.Join(", ", nums));
        return k + 1;
    }
}