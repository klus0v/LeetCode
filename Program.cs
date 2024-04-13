using LeetCode.Easy;
using LeetCode.Medium;

namespace LeetCode;

public static class Program
{
    public static void Main(string[] args)
    {
        var mergeSortedArray = new RemoveDuplicatesFromSortedArrayII_80();
        var result = mergeSortedArray.RemoveDuplicates(new []{ 1,1,1,2,2,3 });
    }
}