//Задайте массив и напишите программу, которая определяет присутствует ли заданное число в массиве
Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = GetArray(size, -9, 9);

Console.WriteLine(String.Join(" ", array));

Console.WriteLine("Введите значение");
int findNumber = int.Parse(Console.ReadLine());
Console.WriteLine(array.FirstOrDefault(p=>p == findNumber) ! = 0 ? "Да" : "Нет");

int [] GetArray(int size, int min, int max){
    int[] result = new int [size];

    for (int i = 0; i < size; i++){
result[i] = new Random() .Next(min, max +1);
    }
}