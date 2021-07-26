 public static int jumpingOnClouds(List<int> c)
        {

            int count = 0;
            int i = 0;
            while (i < c.Count - 1)
            {
                if (i + 2 < c.Count && c[i + 2] != 1)
                {
                    count++;
                    i = i + 2;
                }
                else
                {
                    count++;
                    i++;
                }
            }
            return count;

        }