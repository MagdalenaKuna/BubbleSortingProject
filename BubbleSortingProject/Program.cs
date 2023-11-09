int[] tableToSort = { 23, 55, 55, 87, 34, 2, 4532, 7, 0, 100};
int anyChanges = 0;
int counter1 = 0;
int counter2 = 1;

Console.WriteLine("initial table:");
Console.WriteLine("[{0}]", string.Join(", ", tableToSort));

Console.WriteLine("Table during looping (every new start position):");
while (true)
{
    if (tableToSort[counter1] > tableToSort[counter2])
    {
        int copyValue = tableToSort[counter2];
        tableToSort[counter2] = tableToSort[counter1];
        tableToSort[counter1] = copyValue;
        anyChanges += 1;
    }
    counter1++;
    counter2++;

    if (counter2 == tableToSort.Length)
    {
        if (anyChanges == 0)
        {
            break;
        }
        anyChanges = 0;
        counter1 = 0;
        counter2 = 1;
        Console.WriteLine("[{0}]", string.Join(", ", tableToSort));
    }

}

Console.WriteLine("sorted table: ");
Console.WriteLine("[{0}]", string.Join(", ", tableToSort));