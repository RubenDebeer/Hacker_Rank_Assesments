class Program
{
     public static int countingValleys(int steps, string path)
        {
            int sum = 0;
            int valey = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'D')
                {
                    if (sum == 0)
                    {
                        valey = valey + 1;
                        sum = sum - 1;
                    }
                    else
                    {
                        sum = sum - 1;
                    }
                }else if(path[i]== 'U')
                {
                    sum = sum + 1;
                }
            }

            return valey;
        }
}