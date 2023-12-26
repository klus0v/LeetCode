namespace LeetCode.Easy;

/// https://leetcode.com/problems/merge-sorted-array/
public class MergeSortedArray_88
{
    public static void Main()
    {
        var x = new MergeSortedArray_88();
        x.Merge(new []{2, 0}, 1, new []{1}, 1);
    }
    
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        var i2 = n-1;
        var i1 = m - 1;
        var setIndex = m + n - 1;

        while (i2 >= 0)
        {
            if (i1 >= 0 && nums1[i1] > nums2[i2])
            {
                nums1[setIndex] = nums1[i1];
                i1--;
            }
            else
            {
                nums1[setIndex] = nums2[i2];
                i2--;
            }
            setIndex--;
        }
    }
}