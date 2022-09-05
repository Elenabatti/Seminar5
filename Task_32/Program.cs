//Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот
Console.Clear();
Console.WriteLine("Укажите длину массива: ");

int size = int.Parse(Console.ReadLine());// значение size длина массива
int [] rand = new int[size]; //создаем сразу 2 массива одинаковой размерности, rand и  rand2
int [] rand2 = new int [size];
for (int i = 0; i < rand.Length; i++) {//  забиваем наш массив длиной rand  элементами от -99 до 100
    rand[i] = new Random{}.Next(-99, 100);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
for (int i = 0; i < rand.Length; i++){// прогоняем тот же самый  for  по первому массиву и 
    rand2 [i] =rand [i] * -1;// coздаем 2й массив и прогоняем все 
    //  берем элемент с таким же номером у первого массива, соответствующие элементам 2го умножаем на -1 
    Console.Write(rand2[i]+" ");
}
Console.WriteLine();