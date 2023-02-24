string[] array = new string[4] {"hello", "2", "world", ":-)"};
string[] result = new string[array.Length];

void ArraySearch(string[] array, string[] result)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        result[count] = array[i];
        count++;
        }
    }
}