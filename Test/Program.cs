// Console.WriteLine("Введите любое целое число");
// int number = Convert.ToInt32(Console.ReadLine());


// int NumberDigit(int num) // int num = number
// {
//     int digit = 0;
//     while (num != 0)
//     {
//         num = num / 10;
//         digit++;
//     }
//     return digit == 0 ? 1 : digit;
// }

// int digitNumber = NumberDigit(number);
// Console.WriteLine($"{number} -> {digitNumber}");

int[] array = new int[8];
 // 0  1  2  3  4  5  6  7
//  0, 0, 0, 0, 0, 0, 0, 0
//int[] array2 = new int[5] { 4, 6, 7, 9, 0 };
//int[] array1 = { 1, 4, 5, 5, 8 };

//return array;

array[0] = 345;
array[1] = 44;
array[6] = 87;
array[6] = 87;
array[6] = 87;

for (int i = 0; i < array.Length; i++)
{
    array[i] = i*i;
}

System.Console.WriteLine(array);




