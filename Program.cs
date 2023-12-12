Console.Write("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine()); //Запрашиваем размер массива у пользователя
string[] strings = new string[n];

FillArray(strings); 

void FillArray(string[] str) //Метод которвый позволяет пользователю заполнить массив произвольными значениям
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

string[] newStrings = strings.Where(x => x.Length < 4).ToArray(); // Заполняем новый массив только теми значениями которые удовлетворяют нашим требованиям

Console.WriteLine(string.Join(", ", newStrings)); //Выводим новый массив в терминал