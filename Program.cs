// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Console.Write("Please enter first word ");
// string firstWord = Convert.ToString(Console.ReadLine());
// Console.Write("Please enter second word ");
// string secondWord = Convert.ToString(Console.ReadLine());
// Console.Write("Please enter third word ");
// string thirdWord = Convert.ToString(Console.ReadLine());
// Console.Write("Please enter four word ");
// string fourWord = Convert.ToString(Console.ReadLine());
// Console.Write("Please enter five word ");
// string fiveWord = Convert.ToString(Console.ReadLine());

// string[] array = new string[5] {firstWord, secondWord, thirdWord, fourWord, fiveWord};

//OR

string[] array = new string[6] {"in", "the", "middle", "of", "the", "night"};
string[] new_array = new string[array.Length];

void CreateNewArray(string[] array, string[] new_array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        new_array[count] = array[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CreateNewArray(array, new_array);
PrintArray(array);
PrintArray(new_array);