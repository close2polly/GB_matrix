int[,] array = new int[3,4] {
    {5,6,7,8},
    {9,10,11,12},
    {1,2,3,4},
};


int minStr = 0;
int minSum = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }

    if (i == 0)
    {
        minStr = i;
        minSum = sum;
    }

    if (sum < minSum)
    {
        minStr = i;
        minSum = sum;
    }
}

System.Console.WriteLine($"Наименьшая строка с суммой: {minStr} ({minSum})");