Console.Write("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] strings = new string[n];

void FillArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 0)
        {
        Console.Write("Введите что-нибудь: ");
        str[i] = Console.ReadLine();
        }
        else
        {
        Console.Write("Введите что-нибудь ещё: ");
        str[i] = Console.ReadLine();
        }
    }
}
