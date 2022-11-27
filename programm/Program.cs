//Сделать реверс массива (массив в обратном направлении)

int[] array = new int[] { 10, 11, 5, 23, 11 };
int[] arrayReverse = new int[array.Length];
int temp = array.Length - 1;


for (int i = array.Length - 1; i >= 0; i--)
{
    arrayReverse[temp] = array[i];
    temp--;
    Console.WriteLine(arrayReverse[i]);

}
Console.ReadLine();