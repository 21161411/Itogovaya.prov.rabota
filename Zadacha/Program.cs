string[] array = {"Hello", "2", "4", "world", "GeekBrains","GB", "41241", "qwe", "-78"};
string[] array2 = new string[0];
int k = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        Array.Resize(ref array2, array2.Length + 1);
        array2[k] = array[i];
        k++;
    } 
}
Console.WriteLine("[" + string.Join(", ", array2) + "]");

