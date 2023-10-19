/* 
// --- Вид 1. Методы которые ничего не принмают, ничего не возвращают --- // 
void Method1()
    {
Console.WriteLine("Автор ... ");
    }
Method1(); 
*/



/* 
// --- Вид 2. Методы которые что-то принмают, ничего не возвращают --- //
void Method2(string msg)
{
   Console.WriteLine(msg); 
}
Method2(msg: "Текст сообщения"); 

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg); 
        i++;
    }
}
Method21(msg: "Текст", count: 4); 
Method21(count: 4, msg: "Новый текст"); // Порядок не важен, переменные можно указывть в любом порядке
*/


/* 
//--- Вид 3. Методы которые нчиего не принимают, что-то возвращают ---//
int Method3() // обязательно указать тип данных, значения которых мы ожидаем
{
    return DateTime.Now.Year;// обязательно испольюуем итератор return
}

int year = Method3();
Console.WriteLine(year); 
*/


/* 
//--- Вид 4. Методы которые что-то принимают, что-то возвращают ---//
string Method4(int count, string text)
{
    int i = 0; // возьмем цикл
    string result = String.Empty; // переменная, куда будем класть конечный результат  =  пустая строка
while (i<count) // цикл 
{
    result = result + text;
    i++;
}
return result;
}

string res = Method4(10, "asfd");
Console.WriteLine(res);
*/


/*
string Method4(int count, string text)
{
    string result = String.Empty; // переменная, куда будем класть конечный результат  =  пустая строка
    for (int i = 0;i < count; i++) // инициализация счетчка; проверка условия; инкремент (увеличение счетчика)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asfd");
Console.WriteLine(res); 
*/

/*
// Задача: вывод таблицы умножения на экран//

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/


/*
// Задача: Дан текст. В тексте нужно все пробелы заменить черточками, //
// маленькие буквы "к" заменить большими "К" . а большие "С" заменить маленькими "с" //

using System.Reflection.PortableExecutable;

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приcтупом согласие прусского короля. "
            + "Вы так красноречивы, Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);

*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // задаем массив
void PrintArray(int[] array) // метод вывода масcива на экран
{
    int count = array.Length; // счетчик = длина массива
    for (int i = 0; i < count; i++) // цикл: если i = 0 меньше счетчика, добавляй единицу
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // метод для упорядочивания массива (в качестве аргумента приходит массив)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i; // находим самую меньшую позицию
        for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minPosition]) minPosition = j;
    }

    //замена элемента//
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
}
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);