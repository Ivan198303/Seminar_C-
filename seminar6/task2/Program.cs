// Написать программу которая будет преобразовывать десятичное число в двоичное
string Convert2(int N)
{
    string resalt=String.Empty;
    while (N%2!=N)
    {
        resalt=N%2+resalt;
        N=N/2;
    }
    resalt=N%2+resalt;
    return resalt;
}
Console.WriteLine("enter an integer");
int arg1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Convert2(arg1));
