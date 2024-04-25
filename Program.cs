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