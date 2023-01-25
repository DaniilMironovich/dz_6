//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Программа которая выдает таблицу кубов");
Console.Write("Введите число N: ");
int cube ;
if (!int.TryParse(Console.ReadLine(), out cube))
    Console.Write("Введите целое число");
    void Cube(int[] cube)
    {
        int i = 1;
        int length = cube.Length;
        while (i < length){
        cube[i] = Convert.ToInt32(Math.Pow(i, 3));
        i++;
        }
    }
void printArr (int[] coll)
{
    int index = 1;
    int lenght_2 = coll.Length;
    while (index < lenght_2)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}
int[] arr = new int[cube + 1];
Cube(arr);
printArr(arr);