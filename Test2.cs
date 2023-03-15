string [] FillIntRandomArray (int size)
{
    string [] array = new string [size];
   Random rnd = new Random ();
    for (int i = 0; i < size; i++)
    {
       array [i] = rnd.Next (0,2000).ToString ();
    }
    return array;
}
void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.WriteLine ($"{array[i]} ");
    }
}

string [] ShrinkArrayByElementLength (string [] array, int length)
{
   int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            counter++;
        }
    } 
    string [] arrayout = new string [counter];
    counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            arrayout [counter] = array[i];
            counter++;
        }
        
    } 
    return arrayout;
}

string [] arr = FillIntRandomArray (8);
PrintArray (arr);
Console.WriteLine ();
string [] arrout = ShrinkArrayByElementLength (arr, 3);
PrintArray (arrout);


