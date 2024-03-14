//Фиббоначи
/*int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(F(i));
}


int F(int n)
{
    if (n < 3) { return 1; }
    return F(n - 1) + F(n - 2);
}
*/

//Ряд Фарея
/*
int n = int.Parse(Console.ReadLine());
F(n);

void F(int n)
{
    int a = 0, b = 1, c = 1, d = n;
    Console.WriteLine($"{a}/{b}");
    while (c <= n)
    {
        int k = (n + b) / d;
        int ac = a * k + c;
        int bd = b * k + d;
        Console.WriteLine($"{ac}/{bd}");
        a = c;
        b = d;
        c = ac;
        d = bd;
    }
}*/

//HomeWork
//LexSort


/*string[] arr = { "кувалда", "беспилотник", "амфитеатр", "лопата", "золото" };

static void Swap(string[] array, int i, int j)
{
    string temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}


void Sort(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (SCompare(array[j], array[i]) < 0)
            {
                Swap(array, i, j);
            }
        }
    }
}

int SCompare(string s1, string s2)
{
    var len1 = s1.Length;
    var len2 = s2.Length;
    var lenght = Math.Min(len1, len2);

    for (int i = 0; i < lenght; i++)
    {
        if (s1[i] < s2[i])
            return -1;
        if (s1[i] > s2[i])
            return 1;
    }

    if (len1 > len2)
        return 1;
    if (len1 < len2)
        return -1;

    return 0;
}

Sort(arr);

foreach (string str in arr)
{
    Console.Write($"{str} "); ;
}
*/


/*
int[] arr = new int[] { 7, 1, 4, 2, 5, 8};

static void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}
static void InsertionSort(int[] array)
{
    int x;
    int j;
    for (int i = 1; i < array.Length; i++)
    {
        x = array[i];
        j = i;
        while (j > 0 && array[j - 1] > x)
        {
            Swap(array, j, j - 1);
            j -= 1;
        }
        array[j] = x;
    }
}

static int[] InsertSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j > 0; j--)
        {
            if (array[j - 1] > array[j])
            {
                int temp = array[j - 1];
                array[j - 1] = array[j];
                array[j] = temp;
            }
            else { break; }
        }
    }
    return array;
}


Console.WriteLine("-----------------------------------------------------");
InsertionSort(arr);
var arr2 = InsertSort(arr);
foreach (int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------------------");
foreach (int i in arr2)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------------------");

*/

//SelectSort
/*
int[] n = new int[] { 7,1,4,2,5,8};
int[] SelectSort(int[] numArray)
{
    var arrayLength = numArray.Length;
    for (int i = 0; i < arrayLength - 1; i++)
    {
        var min = i;
        for (int j = i + 1; j < arrayLength; j++)
        {
            if (numArray[j] < numArray[min])
            {
                min = j;
            }
        }
        var tempVar = numArray[min];
        numArray[min] = numArray[i];
        numArray[i] = tempVar;
    }
    return numArray;
}
var answer = SelectSort(n);

foreach (int num in answer)
{
    Console.WriteLine(num);
}*/

// Merge Sort

/*static void Sort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int mid = (left + right) / 2;

        Sort(arr, left, mid);
        Sort(arr, mid + 1, right);

        Merge(arr, left, mid, right);
    }
}

static void Merge(int[] arr, int left, int mid, int right)
{
    int len1 = mid - left + 1;
    int len2 = right - mid;

    int[] leftArray = new int[len1];
    int[] rightArray = new int[len2];

    Array.Copy(arr, left, leftArray, 0, len1);
    Array.Copy(arr, mid + 1, rightArray, 0, len2);

    int a = 0, b = 0, c = left;

    while (a < len1 && b < len2)
    {
        if (leftArray[a] <= rightArray[b])
        {
            arr[c] = leftArray[a];
            a++;
        }
        else
        {
            arr[c] = rightArray[b];
            b++;
        }
        c++;
    }

    while (a < len1)
    {
        arr[c] = leftArray[a];
        a++;
        c++;
    }

    while (b < len2)
    {
        arr[c] = rightArray[b];
        b++;
        c++;
    }
}

int[] arr = { 9, 8, 7, 1, 2, 3, 6, 5, 4, 0 };

foreach (int num in arr)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Sort(arr, 0, arr.Length - 1);

foreach (int num in arr)
{
    Console.Write(num + " ");
}
*/

//29/02/2024

























































































