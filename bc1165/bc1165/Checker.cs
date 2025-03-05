namespace bc1165
{
    static class Checker
    {
        static public bool PrimeCheck(int num)
        {
            for (int i = 2; i < (num - 1); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
