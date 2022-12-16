int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[8];

for (int i = 0; i < 8; i++)
            {
                array[i] = ReadInt("Введите число: ");
                
            }
foreach (int s in array) Console.Write(s+ " ");
Console.ReadLine();

