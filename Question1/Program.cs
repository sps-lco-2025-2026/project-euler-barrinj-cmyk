using System.Numerics;

/*int MAX = 1000;
int total = 0;
for(int i = 1; i < MAX; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        total += i;
    }
}


//Even in fibonacci
int maxFib = 4000000;
int a = 1;
int b = 2;
int evenFibTotal = 0;
while (a < maxFib)
{
    if (a % 2 == 0)
    {
        evenFibTotal += a;
    }
    int temp = a;
    a = b;
    b = temp + b;
}


//Largest prime
long n = 600851475143;
long largestPrime = 0;
for (long i = 2; i <= n; i++)
{
    if (n % i == 0)
    {
        largestPrime = i;
        n /= i;
        i--;
    }
}

//Difference of sum square
int total2 = 0;
int total3 = 0;
for (int i = 1; i<=100; i++)
{
    total2 += i;
    total3 += (i*i);
}


static List<int> PrimeNumbers(int n)
{
    List<int> nums = new List<int>{};
     static bool IsPrime(int num)
    {
    if (num <= 1) return false; 
    if (num == 2) return true; 
    for(int i = 2; i*i <= num; i++) 
        if (num % i == 0) return false;
    return true;
    }

    for (int i = 1; i<=n; i++)
    {
        if (IsPrime(i)==true) nums.Add(i);
    }
    return nums;
}

List<int> primes = PrimeNumbers(1000000);
int totalprimes = 0;
for(int i = 0; totalprimes < 1000000; i++) {
    totalprimes += primes[i];
}

*/

//fibonaci to 1000 digits
static List<BigInteger> fibonacci(int n)
{
    List<BigInteger> fibs = new List<BigInteger>{1, 1};
    while (fibs[fibs.Count - 1].ToString().Length < n) {
        BigInteger nextFib = fibs[fibs.Count - 1] + fibs[fibs.Count - 2];
        fibs.Add(nextFib);
    } 
    return fibs;
}
//Distinct powers

static int LenghtPowers(int a, int b)
{
    HashSet<double> powers = new HashSet<double>{};
    for (int i = 2; i <= a; i++) { 
        for (int j = 2; j <= b; j++) { powers.Add(Math.Pow(i, j)); }
         } 
        return powers.Count;
}

