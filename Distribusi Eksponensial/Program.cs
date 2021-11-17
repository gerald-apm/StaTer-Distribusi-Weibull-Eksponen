using System;

namespace Distribusi_Eksponensial
{
    class Program
    {
        static void Main(string[] args)
        {

            double probabilitas = 0, lambda = 0, rerata = 0, nilaix = 0;
            double x1 = 0, x2 = 0;
            string angka, ulang;

            int pilihan;

            do
            {
                Console.Clear();
                Console.WriteLine("Program Distribusi Eksponensial (18410200053)");
                Console.WriteLine("\n");

                Console.WriteLine();
                Console.WriteLine("Pilihan Input :\n\n1.  Lambda ({0})\n\n2.  Rata Rata({1})",(char)(955),(char)(956));

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

                } while (!int.TryParse(angka, out pilihan) || (pilihan > 2) || (pilihan < 1));


                switch (pilihan)
                {
                    case 1:
                        //Input lambda
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Masukkan Nilai Lambda (" + (char)(955) + ") : ");
                            angka = Console.ReadLine();
                            if (double.TryParse(angka, out lambda))
                                lambda = double.Parse(angka);
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Angka tidak dikenali !");
                            }

                        } while (!double.TryParse(angka, out lambda));

                        break;
                    case 2:
                        //Input rerata
                        do
                        {
                            Console.WriteLine();
                            Console.Write("Masukkan Nilai Rerata (" + (char)(956) + ") : ");
                            angka = Console.ReadLine();
                            if (double.TryParse(angka, out rerata))
                                rerata = double.Parse(angka);
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Angka tidak dikenali !");
                            }

                        } while (!double.TryParse(angka, out rerata));

                        lambda = 1 / rerata;

                        break;
                }

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
                        Console.WriteLine("Distribusi Eksponensial Kurang Dari");
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
                        Console.WriteLine("P(X <= {0}) = 1 - E^( -({1} * {2}))", x1, lambda, x1);

                        nilaix = x1;
                        probabilitas = Math.Round(1 - Math.Exp(-1 * lambda * nilaix), 4, MidpointRounding.AwayFromZero);

                        Console.WriteLine();
                        Console.WriteLine("P(X < {0}) = {1}", nilaix, probabilitas);
                        Console.WriteLine();
                        Console.WriteLine("Probabilitas Distribusi Eksponensial \"Kurang Dari\" adalah : " + probabilitas + " atau " + probabilitas * 100 + "%");
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Distribusi Eksponensial Lebih Dari");
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
                        Console.WriteLine("P(X > {0}) = 1 - (1 - E^( -({1} * {2})))", x1, lambda, x1);
                        nilaix = x1;

                        probabilitas = Math.Round(1 - Math.Exp(-1 * lambda * nilaix), 4, MidpointRounding.AwayFromZero);

                        probabilitas = 1 - Math.Round(1 - Math.Exp(-1 * lambda * nilaix), 4, MidpointRounding.AwayFromZero);

                        Console.WriteLine();
                        Console.WriteLine("1 - P(X > {0}) = {1}", nilaix, probabilitas);
                        Console.WriteLine();
                        Console.WriteLine("Probabilitas Distribusi Eksponensial \"Lebih Dari\" adalah : " + probabilitas + " atau " + probabilitas * 100 + "%");

                        break;

                    case 3:
                        double probabilitas1, nilaix1;
                        Console.WriteLine();
                        Console.WriteLine("Distribusi Eksponensial Di Antara");
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
                        Console.WriteLine("P(X <= {0}) - P(X <= {1}) = P(1 - E^( -({2} * {3}))) - P(1 - E^( -({4} * {5})))", x2, x1, x2, lambda, x2, lambda, x1);


                        nilaix = x2;
                        probabilitas = Math.Round(Math.Exp(-1 * Math.Pow(nilaix / rerata, lambda)), 4, MidpointRounding.AwayFromZero);
                        nilaix1 = x1;
                        probabilitas1 = Math.Round(Math.Exp(-1 * Math.Pow(nilaix1 / rerata, lambda)), 4, MidpointRounding.AwayFromZero);

                        Console.WriteLine();
                        Console.WriteLine("P(Z <= {0}) - P(Z <= {1}) = {2} - {3}", nilaix, nilaix1, probabilitas, probabilitas1);

                        Console.WriteLine();
                        Console.WriteLine("{0} - {1} = {2}", probabilitas, probabilitas1, probabilitas - probabilitas1);

                        probabilitas1 = probabilitas - Math.Round(Math.Exp(-1 * lambda * nilaix), 4, MidpointRounding.AwayFromZero);

                        Console.WriteLine();
                        Console.WriteLine("Probabilitas Distribusi Eksponensial \"Di Antara\" adalah : " + probabilitas1 + " atau " + probabilitas1 * 100 + "%");


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
