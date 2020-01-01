public partial class Solution
{
    public int SingleNumber(int[] nums)
    {
        var r = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            r = r ^ nums[i];
        }

        return r;
    }
}