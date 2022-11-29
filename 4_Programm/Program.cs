string[] basearray = { "hello", "2", "world", ":-)" };
int size = 3;

Console.Write($"{String.Join(", ", basearray)} -> ");
GetResult(basearray, size);

void GetResult(string[] array, int size) // Метод, который находит все элементы строкового массива, больше или равно заданной длины 
{
    for(int i = 0; i < array.Length; i++)
    {
         if (array[i].Length <= size) Console.Write($"{array[i]}, ");
    }
    
}