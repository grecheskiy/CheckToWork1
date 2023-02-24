void FillMass(string[] array)
{for(int i = 0; i < array.Length; i++)
{array[i] = Console.ReadLine() ?? "";}}

void PrintMass(string[] array)
{for(int i = 0; i < array.Length; i++)
{Console.Write($"{array[i]} ");}}

void ThreeMass(string[] array, string[] three)
{int count = 0;
for (int i = 0; i < array.Length; i++)
{if(array[i].Length <= 3)
{three[count] = array[i];
count++;}}}

void PrintThree(string[] three)
{for(int i = 0; i < three.Length; i++)
{Console.Write($"{three[i]} ");}}

string[] array = new string[5];
string[] three = new string[array.Length];
Console.Write("Enter any 5 words through <Enter>: ");
FillMass(array);
PrintMass(array);
Console.Write("--> ");
ThreeMass(array,three);
PrintThree(three);
Console.WriteLine();