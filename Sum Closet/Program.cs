//currently too slow to pass https://leetcode.com/problems/3sum-closest/submissions/ 


using System.Security.Cryptography.X509Certificates;

public class Solution
{
    //find three integers in the array that the sum is closest to target
    public int ThreeSumClosest(int[] nums, int target)
    {
        int temp;
        int curCloestSum = int.MaxValue;
        int curCloestDis = int.MaxValue;
        int lenth = nums.Length;

        for(int i = 0; i < lenth - 2; i++)
        {
            for (int j = i+1; j < lenth; j++)
            {
                for (int k = j+1; k < lenth; k++)
                {  
                    temp = nums[i] + nums[j] + nums[k];
                    int distance = Math.Abs(target - temp);
                    if (distance < curCloestDis)
                    {
                        curCloestDis = distance;
                        curCloestSum = temp;

                        if (distance == 0)
                            return curCloestSum;
                    }
                    
                }

            }
            
        }


        
        
        return curCloestSum;
    }
}





public class main
{
    static void Main()
    {
        int[] arr = { 1,2,3,4,5};
        int target = 9;

        Solution test = new Solution();
        Console.WriteLine(test.ThreeSumClosest(arr, target));
        

    }



}