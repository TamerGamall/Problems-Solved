public class Solution {
  bool IsPrime(int num)
{
    if (num < 2) return false;
    if (num == 2) return true;
    if (num % 2 == 0) return false;

    for (int i = 3; i * i <= num; i += 2)
    {
        if (num % i == 0)
            return false;
    }

    return true;
}
    public int CountPrimes(int n) {
       if (n <= 2) return 0;

    int count = 1; 

    for (int i = 3; i < n; i += 2)
    {
        if (IsPrime(i))
            count++;
    }

    return count;
    }
}