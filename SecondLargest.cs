using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Enter Array elements: ");
        for(int i=0; i<a.Length; i++){
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int l =  a[0];
        int sl = -1;
        for(int i=1; i<a.Length; i++){
            if(a[i]>l){
                sl = l;
                l = a[i];
            }else if(a[i]>sl && a[i]<l){
                sl = a[i];
            }
        }
        Console.WriteLine("Second Largest Element is "+sl);
    }
}