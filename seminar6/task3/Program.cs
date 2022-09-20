// Фибоначи без рекурсии
// f(n) = f(n-1) + f(n-2)
int[] fibonachi(int N)
{
    int []res=new int[N];
    res[0]=0;  // записываем первое значение из массива
    res[1]=1;  // записываем второе значение из массива
    for (int i=2; i<res.Length;i++)res[i]=res[i-1]+res[i-2];
    return res;
}
Console.WriteLine("enter an integer");
int arg1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(", ",(fibonachi(arg1))));