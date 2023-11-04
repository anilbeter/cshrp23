int i = 0;
while (i < 10)
{
    i++;
    if (i % 2 == 0)
        continue;
    Console.WriteLine(i);
    /*
    Output:
    1
    3
    5
    7
    9
    */
}