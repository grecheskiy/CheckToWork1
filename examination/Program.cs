void FillMass(string[] array)
{for(int i = 0; i < array.Length; i++)
{array[i] = Console.ReadLine() ?? "";}}

void PrintMass(string[] array)
{for(int i = 0; i < array.Length; i++)
{Console.Write($"{array[i]} ");}}

string[] array = new string[5];
string[] three = new string[array.Length];
Console.Write("Enter any 5 words through <Enter>: ");
FillMass(array);
PrintMass(array);