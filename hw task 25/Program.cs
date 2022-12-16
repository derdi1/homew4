int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInt("Введите число A ");
int B = ReadInt("Введите число B ");

int res = A;
for(int i = 1; i < B; i++)
{
    res *= A;
}
Console.WriteLine(res);