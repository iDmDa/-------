// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

#nullable disable

void msgStyle (string message, string status = "Green", int newLine = 1) {
    //Black, DarkBlue, DarkGreen, DarkCyan, 
    //DarkRed, DarkMagenta, DarkYellow, Gray, 
    //DarkGray, Blue, Green, Cyan, 
    //Red, Magenta, Yellow, White

    var cons_color = new Dictionary<string, int>();
    for (int i = 0; i < 16; i++) cons_color.Add(((ConsoleColor)i).ToString(), i);

    Console.ForegroundColor = (ConsoleColor)cons_color[status];
    if(newLine == 1) Console.WriteLine(message);
    else Console.Write(message);
    Console.ForegroundColor = ConsoleColor.Gray;
}

string consoleRead(int len, string charList = "1234567890") {  //Ограничение ввода с клавиатуры
    string str = string.Empty;
    while (true)
    {
        char ch = Console.ReadKey(true).KeyChar;
        if (ch == '\r' && str.Length > 0) break;
        if (ch == 'q' || ch == 'Q') System.Environment.Exit(0);
        if (ch == '\b' && str.Length > 0) {
                str = str.Substring(0, str.Length - 1);
                Console.Write("\b \b");
        }
        else if (str.Length < len && charList.IndexOf(ch) != -1)
        {
            if(ch == '-' && str.Length > 0) continue;
            Console.Write(ch);
            str += ch;
        }
    }
    return str;
}

Console.Clear();
msgStyle("Введите размер массива: ", "Blue", 0);
int arrSize = Convert.ToInt32(consoleRead(1, "123456789"));
Console.WriteLine();

string[] array = new string[arrSize];

for(int i = 0; i < arrSize; i++) {
    msgStyle($"Введите {i + 1} строку: ", "Blue", 0);
    array[i] = Console.ReadLine();
}

int count = 0;
foreach(string item in array) {
    if(item.Length <= 3) count++;
}

string[] secondArray = new string[count];

count = 0;
foreach(string item in array) {
    if(item.Length <= 3) secondArray[count++] = item;
}

string result = "[";
foreach(string item in array) {
    result += $"\"{item}\", ";
}
result = result.Substring(0, result.Length-2);
result += "] → [";

foreach(string item in secondArray) {
    result += $"\"{item}\", ";
}
if(secondArray.Length > 0) result = result.Substring(0, result.Length-2);
result += "]";

msgStyle(result, "Red");

