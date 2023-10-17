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