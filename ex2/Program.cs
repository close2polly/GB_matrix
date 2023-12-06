int[,] array = new int[5,5] {
    {0,1,2,3,4},
    {5,6,7,8,9},
    {10,11,12,13,14},
    {15,16,17,18,19},
    {20,21,22,23,24}
};

int[] firstLine = new int[array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
{
    firstLine[i] = array[0, i];
}

int[] lastLine = new int[array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
{
    lastLine[i] = array[array.GetLength(0) - 1, i];
}

for (int i = 0; i < array.GetLength(1); i++)
{
    array[0, i] = lastLine[i];
}

for (int i = 0; i < array.GetLength(1); i++)
{
    array[array.GetLength(0) - 1, i] = firstLine[i];
}






