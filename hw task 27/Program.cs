int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Razryd(int num)
{
    int count = 0;
    while(num > 0)
    {
        count = count + num % 10;
        num = num /10 ;
    }
    return count;
    
    
}

int A = ReadInt("Введите число: ");
int result = Razryd(A);
Console.WriteLine(result);
