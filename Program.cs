int a = 3;

string NewArray(string[] arr)
{
    string result = "";
    for (int i = 0; i < arr.Length; i++)
    {
        // string result = "";
        string found = arr[i];
        int Length = found.Length;

        if (Length <= a)
        {

            System.Console.Write($"{found}  ");
        }


    }
    return result;
}



string[] str = { "ewff", "dcwfe", "fs", "123", "saf" };
string res = NewArray(str);
System.Console.WriteLine(res);

// Второй вариант решения задачи, при котором длина массива и его значения задаются пользователем
string[] MyMass(int m)
{
    string[] strings = new string[m];
    for (int i = 0; i < strings.Length; i++)
    {
        System.Console.WriteLine($"\nВведите элемент массива под индексом {i}:\t");
        strings[i] = Console.ReadLine()!;
    }
    return strings;
}

int a = 3;

string NewArray(string[] arr)
{
    string result = "";
    for (int i = 0; i < arr.Length; i++)
    {

        string found = arr[i];
        int Length = found.Length;

        if (Length <= a)
        {

            System.Console.Write($"{found}  ");
        }



    }
    return result;
}



System.Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] arr = MyMass(n);
string res = NewArray(arr);
System.Console.WriteLine($": новый массив из строк, число символов в которой меньше трёх");