// Двумерные массивы

 Console.Clear();

// string[,] table = new string [2,3]; // тип данных [две размерности: строки, столбцы] наименование массива =  ... [количество строк, количество столбцов]
//int[,] matrix = new int[5,8]; // 5 строк 

/* string[,] table = new string [2,5];
// String.Empty
// table[0,0] table[0,1] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,3] table[1,4]
table [1,2] = "слово"; // индексы расматриваются от 0

for(int rows = 0; rows < 2; rows++) // ряды
{
    for(int columns = 0; columns < 5; columns++) // столбцы
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

int[,] matrix = new int[3,4];

for(int i = 0; i < matrix.GetLength(0); i++) // имя массива в качестве аргумента передаем количество строк, в нашем случае 0
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}