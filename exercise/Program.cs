using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {

        //bool boo= IsPowerOfThree(45);
        //Console.WriteLine(boo.ToString());
        int[] nums = { 0, 12, 0, 1, 3 };
        MoveZeroes(nums);
        //int[] num = { 2, 2, 1 };
        ////int[] num = { 4, 1, 2, 1, 2 };
        //int n=  SingleNumber(num);
        //Console.WriteLine(n);


    }
    /// <summary>
    /// 輸入一個整數陣列，每個數字都會出現兩次，只有一個數字不是，找出那單一的數字。 
    /// 請考慮最佳效能，及是否能在不宣告其他變數下完成
    /// </summary>
    public static int SingleNumber(int[] numbers)
    {
        int singleNumber = 0;

        foreach (int num in numbers)
        {
            singleNumber ^= num;
        }

        return singleNumber;


    }
    /// <summary>
    /// 給定一個整數，寫一個函數來確定它是否為3的乘冪。
    /// </summary>
    public static bool IsPowerOfThree(int n)
    {
         if (n <= 0)
         {
            return false;
         }
         else
         {
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
         }
    }
    /// <summary>
    /// 將數字陣列裡所有0的元素移到最後面
    /// 不改變其他數字的排序
    /// 直接在該陣列物件完成操作,不可複製或建立新的陣列
    /// </summary>

    public static void MoveZeroes(int[] nums)
    {
        int noZeroIndex=0;

        for (int i = 0; i < nums .Length; i++)
        {
            if (nums[i] != 0)
            {
                if (i != noZeroIndex)
                {
                    (nums[i], nums[noZeroIndex]) = (nums[noZeroIndex], nums[i]);
                }
                noZeroIndex++;
            }
        }
         
        foreach(int n in nums)
        {
            Console.WriteLine(n);
        }
        Console.ReadLine();
    }
}