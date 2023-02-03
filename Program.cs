//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int row = new Random().Next(3,8);
int col = new Random().Next(2,10);;
int[,] array = new int[row,col];
NewArray(array);
SumArray(array);
void NewArray (int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(1,100);
        }   
    }
}
void SumArray(int[,] array)
{   
    int sum = 0;
    for (int k = 0; k < col; k++)
    {
        sum = sum + array[0,k];
        Console.Write($"{array[0,k]} ");
    }
    Console.WriteLine($"- сумма = {sum}");
    int min = sum;
    int minrow = 1;
    for (int i = 1; i < row; i++)
    {
        int summ = 0;
        for (int j = 0; j < col; j++)
        {
            summ = summ + array[i,j]; 
            Console.Write($"{array[i,j]} ");  
        }
        Console.WriteLine($"- сумма = {summ}");
        if (summ<min)
        {
            minrow = i+1;
            min = summ;
        }
    }  
    Console.WriteLine($"{minrow} - строка с минимальной суммой элементов"); 
}