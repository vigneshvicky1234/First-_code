using System;
    // 1 
    // 2 1
    // 3 2 1
    // 4 3 2 1
    // 5 4 3 2 1
   //  6 5 4 3 2 1  
     
namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            int []arr={1,2,3,4,5,6};
            
            for(int i =0;i<=arr.Length;i++)
            {
                for(int j=i;j>=0;j--)
            {
            Console.Write(arr[j]);
        }
        Console.WriteLine();
            }
        }
    }
}
      