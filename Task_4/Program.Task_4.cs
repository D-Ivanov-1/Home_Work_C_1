Console.Clear();
int N = 8;
int[] numbers = {1, N}; // 1 2 3 ... N
int index = 1;
while (index <= N)
{
    if (index % 2 == 0)
    Console.Write($"{index}, ");
    index++;
}
