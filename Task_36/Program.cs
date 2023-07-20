// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] nums = new int[30];
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 20);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < nums.Length; j++){


    if (j % 2 != 0)

    {
        sum = sum + nums[j];
    }

}
Console.Write(sum);
