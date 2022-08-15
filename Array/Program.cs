//// Declare a single-dimensional array of 5 integers.
//int[] array1 = new int[5];
//// Declare and set array element values.
//int[] array2 = new int[] { 1, 3, 5, 7, 9 };
//// Alternative syntax.
//int[] array3 = { 1, 2, 3, 4, 5, 6 };

//// Declare a two dimensional array.
//int[,] multiDimensionalArray1 = new int[2, 3];
//// Declare and set array element values.
//int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

//// Declare a jagged array.
//int[][] jaggedArray = new int[6][];

//string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

//Console.WriteLine(weekDays2[0]);
//Console.WriteLine(weekDays2[1]);
//Console.WriteLine(weekDays2[2]);
//Console.WriteLine(weekDays2[3]);
//Console.WriteLine(weekDays2[4]);
//Console.WriteLine(weekDays2[5]);
//Console.WriteLine(weekDays2[6]);

// Two-dimensional array.
//int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
//// The same array with dimensions specified.
//int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
//// A similar array with string elements.
//string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
//                                        { "five", "six" } };
//// Three-dimensional array.
//int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
//                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
//// The same array with dimensions specified.
//int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
//                                       { { 7, 8, 9 }, { 10, 11, 12 } } };


// Accessing array elements.
//System.Console.WriteLine(array2D[0, 0]);
//System.Console.WriteLine(array2D[0, 1]);
//System.Console.WriteLine(array2D[1, 0]);
//System.Console.WriteLine(array2D[1, 1]);
//System.Console.WriteLine(array2D[3, 0]);
//System.Console.WriteLine(array2Db[1, 0]);
//System.Console.WriteLine(array3Da[1, 0, 1]);
//System.Console.WriteLine(array3D[1, 1, 2]);

// Getting the total count of elements or the length of a given dimension.
//var allLength = array3D.Length;
//var total = 1;
//for (int i = 0; i < array3D.Rank; i++)
//{
//    total *= array3D.GetLength(i);
//}
//System.Console.WriteLine("{0} equals {1}", allLength, total);

//int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
//foreach (int i in numbers)
//{
//    System.Console.Write("{0} ", i);
//}
//20:08
//int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

//foreach (int i in numbers2D)
//{
//    System.Console.Write("{0} ", i);
//}

//static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
//// Change the array by reversing its elements.
//static void ChangeArray(string[] arr) => Array.Reverse(arr);
//static void ChangeArrayElements(string[] arr)
//{
//    // Change the value of the first three array elements.
//    arr[0] = "Mon";
//    arr[1] = "Wed";
//    arr[2] = "Fri";
//}

//// Declare and initialize an array.
//string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
//// Display the array elements.
//DisplayArray(weekDays);
//Console.WriteLine();
//// Reverse the array.
//ChangeArray(weekDays);
//// Display the array again to verify that it stays reversed.
//Console.WriteLine("Array weekDays after the call to ChangeArray:");
//DisplayArray(weekDays);
//Console.WriteLine();
//// Assign new values to individual array elements.
//ChangeArrayElements(weekDays);
//// Display the array again to verify that it has changed.
//Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
//DisplayArray(weekDays);

//void Sum(params int[] numbers)
//{
//    int result = 0;
//    foreach (var n in numbers)
//    {
//        result += n;
//    }
//    Console.WriteLine(result);
//}

//int[] nums = { 1, 2, 3, 4, 5 };
//Sum(nums);
//Sum(1, 2, 3, 4);
//Sum(1, 2, 3);
//Sum();

//void Sum(int initialValue, params int[] numbers)
//{
//    int result = initialValue;
//    foreach (var n in numbers)
//    {
//        result += n;
//    }
//    Console.WriteLine(result);
//}

//int[] nums = { 1, 2, 3, 4, 5 };
//Sum(10, nums);
//Sum(1, 2, 3, 4);
//Sum(1, 2, 3);
//Sum(20);

//int[][] jaggedArray = new int[3][];

//jaggedArray[0] = new int[5];
//jaggedArray[1] = new int[4];
//jaggedArray[2] = new int[2];

//jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
//jaggedArray[1] = new int[] { 0, 2, 4, 6 };
//jaggedArray[2] = new int[] { 11, 22 };

//int[][] jaggedArray2 = new int[][]
//{
//new int[] { 1, 3, 5, 7, 9 },
//new int[] { 0, 2, 4, 6 },
//new int[] { 11, 22 }
//};

//int[][] jaggedArray3 =
//{
//    new int[] { 1, 3, 5, 7, 9 },
//    new int[] { 0, 2, 4, 6 },
//    new int[] { 11, 22 }
//};

//// Assign 77 to the second element ([1]) of the first array ([0]):
//jaggedArray3[0][1] = 77;
//// Assign 88 to the second element ([1]) of the third array ([2]):
//jaggedArray3[2][1] = 88;

//// Declare the array of two elements.
//int[][] arr = new int[2][];
//// Initialize the elements.
//arr[0] = new int[5] { 1, 3, 5, 7, 9 };
//arr[1] = new int[4] { 2, 4, 6, 8 };
//// Display the array elements.
//for (int i = 0; i < arr.Length; i++)
//{
//    System.Console.Write("Element({0}): ", i);
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
//    }
//    System.Console.WriteLine();
//}
//// Keep the console window open in debug mode.
//System.Console.WriteLine("Press any key to exit.");
//System.Console.ReadKey();

//var tuple = (5, 10);
//Console.WriteLine(tuple.Item1);
//tuple.Item1 += 26;
//Console.WriteLine(tuple.Item1);

//(int, int) tuple = (5, 10);
//(string, int, double) person = ("Tom", 25, 81.23);


//using System;

//class SelectionSort
//{
//    static void arraySort(int[] arr)
//    {
//        int n = arr.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            int min_idx = i;
//            for (int j = i + 1; j < n; j++)
//                if (arr[j] < arr[min_idx])
//                    min_idx = j;

//            int temp = arr[min_idx];
//            arr[min_idx] = arr[i];
//            arr[i] = temp;
//        }
//    }


//        static void bubbleSort(int[] arr)
//        {
//            int n = arr.Length;
//            for (int i = 0; i < n - 1; i++)
//                for (int j = 0; j < n - i - 1; j++)
//                    if (arr[j] > arr[j + 1])
//                    {
//                        int temp = arr[j];
//                        arr[j] = arr[j + 1];
//                        arr[j + 1] = temp;
//                    }
//        }





//        void insertionSort(int[] arr)
//        {
//            int n = arr.Length;
//            for (int i = 1; i < n; ++i)
//            {
//                int key = arr[i];
//                int j = i - 1;


//                while (j >= 0 && arr[j] > key)
//                {
//                    arr[j + 1] = arr[j];
//                    j = j - 1;
//                }
//                arr[j + 1] = key;
//            }


//        public static void Main()
//        {
//            int[] arr1 = { 1, 25, 30, 40, 252 };
//            int[] arr2 = { 1, 25, 30, 78, -34 };
//            int[] arr3 = { 1, 25, 30, 585, 13 };

//            arraySort(arr1);
//            bubbleSort(arr2);
//            insertionSort(arr3);

//            Console.WriteLine("Selection Sort array");
//            PrintArray(arr1);
//            Console.WriteLine("Bubble Sort array");
//            PrintArray(arr2);
//            Console.WriteLine("Insertion Sort array");
//            PrintArray(arr3);
//        }




//    }
//avoid commented code

using System;

class Program
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min_idx])
                {
                    min_idx = j;
                }
            }
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void BubbleSort(int[] arr1)
    {
        int n = arr1.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
                if (arr1[j] > arr1[j + 1])
                {
                    int temp = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = temp;
                }
        }
    }
    static void InsertionSort(int[] arr2)
    {
        int n = arr2.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr2[i];
            int j = i - 1;

            while (j >= 0 && arr2[j] > key)
            {
                arr2[j + 1] = arr2[j];
                j = j - 1;
            }
            arr2[j + 1] = key;
        }
    }
    public static void Main()
    {
        int[] arr1 = { 178, 33, 14, 82, 1 };
        int[] arr2 = { 175, -328, 4, 15, 132 };
        int[] arr3 = { -135, 35, 252, -1100, 300 };

        SelectionSort(arr1);
        BubbleSort(arr2);
        InsertionSort(arr3);

        Console.WriteLine("Selection Sort array");
        PrintArray(arr1);
        Console.WriteLine("Bubble Sort array");
        PrintArray(arr2);
        Console.WriteLine("Insertion Sort array");
        PrintArray(arr3);

    }

}
//checked











