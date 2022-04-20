using System;

namespace Lat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan ucup = new Karyawan("1", "ucup", 3000000);
            Karyawan eko = new Karyawan("2", "eko", 2000000);
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", ucup.NIK, ucup.Nama, ucup.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", eko.NIK, eko.Nama, eko.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine("Naikkan Gaji Sebesar 10%");
            Console.WriteLine();

            ucup.NaikkanGaji(10);
            eko.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", ucup.NIK, ucup.Nama, ucup.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", eko.NIK, eko.Nama, eko.GajiBulanan);
            Console.ReadKey();
        }
    }
}