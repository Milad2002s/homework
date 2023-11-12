Console.WriteLine("this program created for display menu ");


int[,] nums = new int[2, 3];
nums[0, 0] = 0;
nums[0, 1] = 36;
nums[0, 2] = 18;
nums[1, 0] = 1;
nums[1, 1] = 97;
nums[1, 2] = 13;

funRecur(0,0,nums);




static void funRecur(int x, int y, int[,] nums)
{
    if (x < 2 && y <= 3)
    {
        if (y == 0)
        {
            Console.Write($"Root ({x}) " + ":");
        }
        else
        {
            Console.Write(nums[x, y] + "\t");
        }

        y++;
        if (y == 3)
        {
            Console.WriteLine();
            y = 0;
            x++;
        }
        funRecur(x, y, nums);
    }
    else
    {
        return;
    }
}