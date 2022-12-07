/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int N = InputInt();
int[] TableSquares = GetTableSqures(N);
PrintArray(TableSquares);

int InputInt()
{
    Console.WriteLine("Введите целое положительное число");
    bool isNum = int.TryParse(Console.ReadLine(), out int N);
    if (isNum) {
        if (N >= 0){
        return N;
        } else {
            return N*(-1);
        }
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return 0; 
    }
}

int[] GetTableSqures(int N)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = (int)(Math.Pow(i+1, 3));
    }
return arr;
}

void PrintArray (int[] arr){
    for (int i = 0; i< arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
