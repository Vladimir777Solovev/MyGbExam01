// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами

Console.WriteLine("Input size of elements in massive (not more then 3): ");

// Узнаем у пользователя количество строк или чисел в массиве
int size  = int.Parse(Console.ReadLine());

// Задаем массив

string[] Array1 = new string[size];
// Вводим цикл со счетчиком

for (int i = 0; i < size; i++)
{
	Console.Write("Input an elements of massive (by pushing enter): ");
    string result = Console.ReadLine();
	Array1[i] = result;  
}
// Выводим массив заданный пользователем
Console.WriteLine($"Your massive is {string.Join(",", Array1)}");

int count = 0;
int max = 3;

// Вводим счетчик подходящих элементов
for (int i = 0; i < Array1.Length; i++)
{
	if(Array1[i].Length <= max){
		count++;
	}   
}
Console.WriteLine();
Console.Write("Resulting massive: [");

// Вводим массив выдающий конечный результат
string[] Array2 = new string[count];
int j = 0;
for (int i = 0; i < Array1.Length; i++){
    if(Array1[i].Length <= max){
        Array2[j] = Array1[i];
        Console.Write(Array2[j] + ",");
        j++;
    }
}
Console.Write("]");