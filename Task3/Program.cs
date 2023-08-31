// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[5];

void ArrayRandom(double[] array)  // заполнение массива
{
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble()*100,2);
    }
Console.WriteLine(string.Join(",", array));
}

double Max(double[] array){
    double resultMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > resultMax)
        {
            resultMax = array[i];
        }
    }
    return resultMax;
}

double Min(double[] array){
    double resultMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultMin)
        {
            resultMin = array[i];
        }
    }
    return resultMin;
}

ArrayRandom(array);

double max = Max(array);

double min = Min(array);

double diff = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: " + diff);
