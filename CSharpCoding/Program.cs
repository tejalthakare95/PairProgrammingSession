// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using CSharpCoding;

ArrayProg ap = new ArrayProg();
//ap.IntArrayProg();
//ap.IntArrayReverse();
int[] IntArray = {1,2,3,4,5, 6};
ap.IntArrayReverseRecursion(IntArray, 0, IntArray.Length-1);
foreach (int i in IntArray)
{
    Console.Write(i + " ");
}
    