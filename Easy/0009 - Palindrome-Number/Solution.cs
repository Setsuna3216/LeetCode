public class Solution
{
    public bool IsPalindrome(int x)
    {

        int orign = x;
        long reversedNum = 0;

        if (x >= 0)
        {
            while (x > 0)
            {
                reversedNum = reversedNum * 10 + x % 10;
                x = x / 10;
            }

            if (reversedNum == orign)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        else
        {
            return false;
        }


    }
}