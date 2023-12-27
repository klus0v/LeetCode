using LeetCode.Easy;

namespace LeetCode;

public static class Program
{
    public static void Main(string[] args)
    {
        var mergeSortedArray = new RemoveElement_27();
        mergeSortedArray.RemoveElement(new []{0,1,2,2,3,0,4,2}, 2);
    }
}