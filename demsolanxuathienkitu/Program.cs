using System;

namespace demsolanxuathienkitu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "anh", "trung", "dep", "trai", "trung" };
            Console.WriteLine("Nhap ky tu co trong mang : ");
            string x = Console.ReadLine();
            Console.WriteLine("So lan xuat hien cua ky tu {0} là  ", x);
            count(s, x);
            static void count(string[] z, string n)
            {
                int dem = 0;
                for (int i = 0; i < z.Length; i++)
                {
                    if (z[i] == n)
                        dem++;

                }
                Console.WriteLine(dem);
            }
        }
    }
}
