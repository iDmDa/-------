// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] array = new string[] {"aaaaaa", "bbb", "ccccc", "dd", "ee", "ff  fff"};

int count = 0;
foreach(string item in array) {
    if(item.Length <= 3) count++;
}

string[] secondArray = new string[count];

count = 0;
foreach(string item in array) {
    if(item.Length <= 3) secondArray[count++] = item;
}

Console.WriteLine(string.Join(",", secondArray));

