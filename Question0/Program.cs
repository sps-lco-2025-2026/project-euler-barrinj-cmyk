long total = 0;
long count = 0;
for (long i = 1; count < 452000; i+=2)
{
total = total + (i*i);
count++;
}
Console.WriteLine(total);