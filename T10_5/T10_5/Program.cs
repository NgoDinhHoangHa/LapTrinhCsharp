using System;

namespace T10_5
{
    class Program
    {
        public static void Main()
        {

            int[] arr213 = new int[100];
            int i213,j213, mx213, mn213, n213;


            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n213 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n213);
            for (i213 = 0; i213 < n213; i213++)
            {
                Console.Write("Phan tu - {0}: ", i213);
                arr213[i213] = Convert.ToInt32(Console.ReadLine());
            }


            mx213 = arr213[0];
            mn213 = arr213[0];

            for (i213 = 1; i213 < n213; i213++)
            {
                if (arr213[i213] > mx213)
                {
                    mx213 = arr213[i213];
                }


                if (arr213[i213] < mn213)
                {
                    mn213 = arr213[i213];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx213);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn213);

            Console.WriteLine("mang theo thu tu tang dan");
            for ( i213 = 0; i213 < n213; i213++)
            {
                for ( j213 = i213 + 1; j213 < n213; j213++)
                {
                    if (arr213[i213] > arr213[j213])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp = arr213[i213];
                        arr213[i213] = arr213[j213];
                        arr213[j213] = temp;
                    }
                }
            }   

            for (i213 = 0; i213 < n213; i213++)
            {
                Console.Write(arr213[i213] + " ");
            }
            Console.ReadKey();

        }
    }

}
