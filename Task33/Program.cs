//Задайте массив и напишите программу, которая определяет присутствует ли заданное число в массиве

Console.Clear();
Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите искомое число: ");
int num = int.Parse(Console.ReadLine());
int[] rand = new int[size];
bool A = false; // bool - тип данных

for (int i = 0; i < rand.Length; i++){//забиваем наш массив цифрами от 9 до 10
    rand[i] = new Random() .Next(9, 10);//забиваем наш массив цифрами от 9 до 10
    Console.WriteLine(rand[i]+" ");//и сразу же выводим наш массив на экран, этой строчкой
    if (rand[i] == num)// в цикле For добавляем  If спрашиваем  в даннос случае(rand[i]) элемент, который сейчас забивается 
    //равно элементу num который мы ввели чуть выше

    A = true;  
}
    Console.WriteLine();

if (A == true)
Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}