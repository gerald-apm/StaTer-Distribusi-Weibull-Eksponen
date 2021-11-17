using System;

namespace StaTer_Distribusi_Weibull_Eksponen
{
    class Program
    {
        static void Main(string[] args)
        {

            double nilaiz = 0, alfa = 0, beta = 0, nilaix = 0;
            double x1 = 0, x2 = 0;
            string angka, ulang;
            int pilihan;

            do
            {
                Console.Clear();
                Console.WriteLine("Program Distribusi Weibull (18410200053)");
                Console.WriteLine("\n");

                //Input alfa
                do
                {
                    Console.WriteLine();
                    Console.Write("Masukkan Nilai Alfa (" + (char)(945) + ") : ");
                    angka = Console.ReadLine();
                    if (double.TryParse(angka, out alfa))
                        alfa = double.Parse(angka);
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Angka tidak dikenali !");
                    }

                } while (!double.TryParse(angka, out alfa));

                //Input beta
                do
                {
                    Console.WriteLine();
                    Console.Write("Masukkan Nilai Beta (" + (char)(946) + ") : ");
                    angka = Console.ReadLine();
                    if (double.TryParse(angka, out beta))
                        beta = double.Parse(angka);
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Angka tidak dikenali !");
                    }

                } while (!double.TryParse(angka, out beta));

                //pilihan menu probabilitas
                Console.WriteLine();
                Console.WriteLine("Pilihan:\n\n1.  Kurang Dari\n\n2.  Lebih Dari\n\n3.  Di antara");

                do
                {
                    Console.WriteLine();
                    Console.Write("Masukkan Pilihan (" + "1 - 3" + ") : ");
                    angka = Console.ReadLine();
                    if (int.TryParse(angka, out pilihan))
                        pilihan = int.Parse(angka);
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Angka tidak dikenali !");
                    }

                } while (!int.TryParse(angka, out pilihan) || (pilihan > 3) || (pilihan < 1));


                switch (pilihan)
                {
                    //Probabilitas Kurang dari
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Distribusi Weibull Kurang Dari");
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Masukkan Nilai Parameter X : ");
                            angka = Console.ReadLine();
                            if (double.TryParse(angka, out x1))
                                x1 = double.Parse(angka);
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Angka tidak dikenali !");
                            }

                        } while (!double.TryParse(angka, out x1));
                        Console.WriteLine();
                        Console.WriteLine("P(X <= {0}) = 1 - E^( -({1} - {2})^{3})", x1, x1, beta, alfa);

                        nilaix = x1;
                        nilaiz = Math.Round(1 - Math.Exp(-1*Math.Pow((nilaix/beta), alfa)) , 4, MidpointRounding.AwayFromZero);

                        Console.WriteLine();
                        Console.WriteLine("P(X < {0}) = {1}", nilaix, nilaiz);
                        Console.WriteLine();
                        Console.WriteLine("Probabilitas Distribusi Weibull \"Kurang Dari\" adalah : " + nilaiz + " atau " + nilaiz * 100 + "%");
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Distribusi Weibull Lebih Dari");
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Masukkan Nilai Parameter X : ");
                            angka = Console.ReadLine();
                            if (double.TryParse(angka, out x1))
                                x1 = double.Parse(angka);
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Angka tidak dikenali !");
                            }

                        } while (!double.TryParse(angka, out x1));
                        Console.WriteLine();
                        Console.WriteLine("P(X > {0}) = 1 - (1 - E^( -({1} - {2})^{3}))", x1, x1, beta, alfa);
                        nilaix = x1;

                        nilaiz = Math.Round(1 - Math.Exp(-1 * Math.Pow((nilaix / beta), alfa)), 4, MidpointRounding.AwayFromZero);

                        nilaiz = 1 - Math.Round(1 - Math.Exp(-1 * Math.Pow((nilaix / beta), alfa)), 4, MidpointRounding.AwayFromZero);

                        Console.WriteLine();
                        Console.WriteLine("1 - P(X > {0}) = {1}", nilaix, nilaiz);
                        Console.WriteLine();
                        Console.WriteLine("Probabilitas Distribusi Weibull \"Lebih Dari\" adalah : " + nilaiz + " atau " + nilaiz * 100 + "%");

                        break;

                    case 3:
                        double nilaiz1, nilaix1;
                        Console.WriteLine();
                        Console.WriteLine("Distribusi Weibull Di Antara");
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Masukkan Nilai Batas Bawah (X1) : ");
                            angka = Console.ReadLine();
                            if (double.TryParse(angka, out x1))
                                x1 = double.Parse(angka);
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Angka tidak dikenali !");
                            }

                        } while (!double.TryParse(angka, out x1));

                        do
                        {
                            Console.WriteLine();
                            Console.Write("Masukkan Nilai Batas Atas (X2) : ");
                            angka = Console.ReadLine();
                            if (double.TryParse(angka, out x2))
                                x2 = double.Parse(angka);
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Angka tidak dikenali !");
                            }

                        } while (!double.TryParse(angka, out x2));

                        Console.WriteLine();
                        Console.WriteLine("P({0} <= X <= {1}) = P(X <= {2}) - P(X <= {3})", x1, x2, x2, x1);



                        Console.WriteLine();
                        Console.WriteLine("P(X <= {0}) - P(X <= {1}) = P(1 - E^( -({2} - {3})^{4})) - P(1 - E^( -({5} - {6})^{7}))", x2, x1, x2, beta, alfa, x1, beta, alfa);


                        nilaix = x2;
                        nilaiz = 1 - Math.Round(Math.Exp(-1 * Math.Pow((nilaix / beta), alfa)), 4, MidpointRounding.AwayFromZero);
                        nilaix1 = x1;
                        nilaiz1 = 1 - Math.Round(Math.Exp(-1 * Math.Pow((nilaix1 / beta), alfa)), 4, MidpointRounding.AwayFromZero);

                        Console.WriteLine();
                        Console.WriteLine("P(X <= {0}) - P(X <= {1}) = {2} - {3}", nilaix, nilaix1, nilaiz, nilaiz1);

                        Console.WriteLine();
                        Console.WriteLine("{0} - {1} = {2}", nilaiz, nilaiz1, nilaiz - nilaiz1);

                        nilaiz1 = nilaiz - (1 - Math.Round(Math.Exp(-1 * Math.Pow((nilaix1/ beta), alfa)), 4, MidpointRounding.AwayFromZero));

                        Console.WriteLine();
                        Console.WriteLine("Probabilitas Distribusi Weibull \"Di Antara\" adalah : " + nilaiz1 + " atau " + nilaiz1 * 100 + "%");


                        break;
                }

                Console.WriteLine();
                Console.Write("Ingin Mengulang lagi ? [Y/T] : ");
                ulang = Console.ReadLine();
            } while (ulang == "Y" || ulang == "y");

            Console.ReadLine();
        }
    }
}
