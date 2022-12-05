/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да*/

int Inputint()
{
    Console.WriteLine("Введите пятизначное число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Некорректное число");
        return -1;
    }
}
int num = Inputint();
int[] arr = new int[5];
int[] GetPalindromeNumber(int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = num % 10;
        num = num / 10;
    }
    return arr;
}
int[] Palindrome = GetPalindromeNumber(num);
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(Palindrome);
int[] CheckingPalindrome(int[] arr)
{
    if(arr[0] == arr[4] && arr[1] ==arr[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - НЕ палиндром");
    }
    return arr;
}
CheckingPalindrome(Palindrome);