
//int[] array = new int [4];
string text = "1234";
int[] arr = text.Select(x => x - '0').ToArray();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = text[i] - 48;
//}
string result = string.Join(", ", arr);
System.Console.WriteLine(result);


void Main()
{
    string str = "34,,534aann5345ghkc34535fhfghfgcbvbcvb";
    Console.WriteLine(str);
    int i = 0;
    while (true)
    {
        var tmp = str[i].ToString();
        str = str.Replace(tmp, "");
        str = str.Insert(i, tmp);
        i++;
        if (str.Length - 1 < i)
            break;
    }
    Console.WriteLine(str);
    Console.WriteLine();
}
Main();


int[] indexLowerRowArray = indexLowerRowList.Select(x => x - '0').ToArray();
int[] indexLowerColumnArray = indexLowerColumnList.Select(x => x - '0').ToArray();


void DeleteDuplicateElements(string text)
{
    int index = 0;
    while (true)
    {
        var temp = text[index].ToString();
        text = text.Replace(temp, "");
        text = text.Insert(index, temp);
        index++;
        if (text.Length - 1 < index)
        {
            break;
        }
    }
}
