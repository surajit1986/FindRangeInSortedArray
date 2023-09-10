// See https://aka.ms/new-console-template for more information
using FindRangeInSortedArray;

Console.WriteLine("Hello, World!");

int[] arr = new int[] { 10, 11, 11, 11, 14, 15 };
int target = 11;
FindRange obj = new FindRange();

int[] result = obj.FindRangeFunc(arr, target);
Console.Write($"Start Index: {result[0]}, Last Index:{result[1]}");
Console.ReadKey();
