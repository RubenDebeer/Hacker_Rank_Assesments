class Progream
{
    public static int sockMerchant(int NUmber_Of_Socks, List<int> Sock_List)
        {
            int Number_Of_Pairs = 0;
            HashSet<int> Colors = new HashSet<int>();

            for (int i = 0 ; i < NUmber_Of_Socks; i++)
            {
                if (Colors.Contains(Sock_List[i]))
                {
                     Number_Of_Pairs = Number_Of_Pairs + 1;
                    Colors.Remove(Sock_List[i]);
                }
                else
                {
                    Colors.Add(Sock_List[i]);
                }
            }
            return Number_Of_Pairs;
        }

}