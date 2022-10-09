// Найти сумму всех натуральных чисел от1 до N. N задается с клавиатуры.
int SumLoop(int N)
{
    int sum=0;
    while(N>0)
    {
        sum+=N;
        N--;
    }
    return sum;
}

Console.WriteLine(SumLoop(5));

int SumRec(int N)
{
    if (N==0)return 0;
    return N+SumRec(N-1);
}
Console.WriteLine(SumRec(5));
