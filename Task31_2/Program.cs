//Задайте массив из 12 элементов, заполненный случайними числами из промежутка[-9, 9]
//Найдите сумму отрицательных и положительных элементов массива
Console.Clear();
Console.Write("Массив: ");
int [] rand = new int[12];
int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < rand.Length; i++) {
    rand [i] = new Random{} .Next(-9, 10);
    Console.Write(rand[i]+" ");
    if (rand[i] > 0)
    sumPositive +=rand[i];
    if (rand[i] < 0)
    sumNegative += rand[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных: {sumPositive}");
Console.WriteLine($"Сумма отрицательных: {sumNegative}");