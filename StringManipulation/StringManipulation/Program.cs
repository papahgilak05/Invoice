using System;
using System.Globalization;

namespace StringManipulation
{
    class manipulation 
    {

        static String intToRoman(int num)
        {
            // storing roman values of digits from 0-9
            // when placed at different places
            String[] m = { "", "M", "MM", "MMM" };
            String[] c = { "",  "C",  "CC",  "CCC",  "CD",
                       "D", "DC", "DCC", "DCCC", "CM" };
            String[] x = { "",  "X",  "XX",  "XXX",  "XL",
                       "L", "LX", "LXX", "LXXX", "XC" };
            String[] i = { "",  "I",  "II",  "III",  "IV",
                       "V", "VI", "VII", "VIII", "IX" };

            // Converting to roman
            String thousands = m[num / 1000];
            String hundreds = c[(num % 1000) / 100];
            String tens = x[(num % 100) / 10];
            String ones = i[num % 10];

            String ans = thousands + hundreds + tens + ones;

            return ans;
        }


        static void Main(string[] args) 
        {
            const string inv = "INV";
            int nomorsurat;
            const int counter = 1;
            string day, date, bulan, year;

            Console.WriteLine(" Masukan nomor surat ");
            nomorsurat = Convert.ToInt32(Console.ReadLine());
            int nomorsuratcounter = nomorsurat + counter;




            Console.WriteLine(" Masukan Hari dalam bahasa inggris");
            day = Console.ReadLine();
            string day2 = day.ToUpper();

            Console.WriteLine(" Masukan Tanggal");
            date = Console.ReadLine();

            Console.WriteLine("Masukan Bulan dalam bahasa inggris");
            bulan = Console.ReadLine();

            Console.WriteLine(" Masukan Tahun");
            year = Console.ReadLine();





            //mengambil nama bulan menjadi angka
            int bulann = DateTime.ParseExact(bulan, "MMMM", CultureInfo.CurrentCulture).Month;

            //


            Console.WriteLine
                (inv + "/" + 
                year + bulann.ToString("D2") + "/" + 
                day2.Substring(0,2) + "/" +
                bulann.ToString("D2") + "/" +
                intToRoman(int.Parse(date.Substring(0,2))) + "/" +
                intToRoman(int.Parse(year.Substring(0,2))) + intToRoman(int.Parse(year.Substring(1,2))) + "/" + 
                nomorsuratcounter);
            
            //Untuk mengambil 2 character pada hari gunakan identifier.substring(mulai.panjang huruf)


        }

    }

}