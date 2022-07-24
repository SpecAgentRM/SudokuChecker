namespace SudokuChecker
{
    class SudokuChecker {

        static void Main(string[] args) {
            Console.WriteLine("Witamy w programie SudokuChecker!");
            menu();
        }
        static void menu()
        {
            Console.WriteLine("Wybierz co chcesz zrobić:");
            Console.WriteLine("1 - Sprawdź Sudoku");
            Console.WriteLine("2 - Sprawdź wiele Sudoku");
            var decyzja = Console.ReadLine();
            switch(decyzja) {
                case "1":
                    sprawdz();
                    break;
                    case "2":
                    //sprawdz_serie();
                    break;
                    default:
                    Console.WriteLine("Wybór jest nieprawidłowy! Spróbuj ponownie.");
                    menu();
                    break;
            }
        }
        static void sprawdz()
        {
            int[] a = new int[9];
            int[] b = new int[9];
            int[] c = new int[9];
            int[] d = new int[9];
            int[] e = new int[9];
            int[] f = new int[9];
            int[] g = new int[9];
            int[] h = new int[9];
            int[] i = new int[9];

            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 1 wierszu (od góry):");
                try
                {
                    a[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 2 wierszu (od góry):");
                try
                {
                    b[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 3 wierszu (od góry):");
                try
                {
                    c[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 4 wierszu (od góry):");
                try
                {
                    d[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 5 wierszu (od góry):");
                try
                {
                    e[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 6 wierszu (od góry):");
                try
                {
                    f[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 7 wierszu (od góry):");
                try
                {
                    g[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 8 wierszu (od góry):");
                try
                {
                    h[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine("Podaj " + Convert.ToString(j + 1) + " liczbę w 9 wierszu (od góry):");
                try
                {
                    i[j] = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    sprawdz();
                }
            }
            if(a.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 1 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 1 nie zawiera błędów!");
            }
            if (b.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 2 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 2 nie zawiera błędów!");
            }
            if (c.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 3 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 3 nie zawiera błędów!");
            }
            if (d.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 4 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 4 nie zawiera błędów!");
            }
            if (e.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 5 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 5 nie zawiera błędów!");
            }
            if (f.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 6 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 6 nie zawiera błędów!");
            }
            if (g.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 7 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 7 nie zawiera błędów!");
            }
            if (h.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 8 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 8 nie zawiera błędów!");
            }
            if (i.Sum().Equals(45) == false)
            {
                Console.WriteLine("Wiersz 9 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Wiersz 9 nie zawiera błędów!");
            }

            if (a[0] + b[0] + c[0] + d[0] + e[0] + f[0] + g[0] + h[0] + i[0] != 45)
            {
                Console.WriteLine("Kolumna 1 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 1 nie zawiera błędów!");
            }
            if (a[1] + b[1] + c[1] + d[1] + e[1] + f[1] + g[1] + h[1] + i[1] != 45)
            {
                Console.WriteLine("Kolumna 2 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 2 nie zawiera błędów!");
            }
            if (a[2] + b[2] + c[2] + d[2] + e[2] + f[2] + g[2] + h[2] + i[2] != 45)
            {
                Console.WriteLine("Kolumna 3 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 3 nie zawiera błędów!");
            }
            if (a[3] + b[3] + c[3] + d[3] + e[3] + f[3] + g[3] + h[3] + i[3] != 45)
            {
                Console.WriteLine("Kolumna 4 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 4 nie zawiera błędów!");
            }
            if (a[4] + b[4] + c[4] + d[4] + e[4] + f[4] + g[4] + h[4] + i[4] != 45)
            {
                Console.WriteLine("Kolumna 5 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 5 nie zawiera błędów!");
            }
            if (a[5] + b[5] + c[5] + d[5] + e[5] + f[5] + g[5] + h[5] + i[5] != 45)
            {
                Console.WriteLine("Kolumna 6 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 6 nie zawiera błędów!");
            }
            if (a[6] + b[6] + c[6] + d[6] + e[6] + f[6] + g[6] + h[6] + i[6] != 45)
            {
                Console.WriteLine("Kolumna 7 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 7 nie zawiera błędów!");
            }
            if (a[7] + b[7] + c[7] + d[7] + e[7] + f[7] + g[7] + h[7] + i[7] != 45)
            {
                Console.WriteLine("Kolumna 8 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 8 nie zawiera błędów!");
            }
            if (a[8] + b[8] + c[8] + d[8] + e[8] + f[8] + g[8] + h[8] + i[8] != 45)
            {
                Console.WriteLine("Kolumna 8 zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Kolumna 8 nie zawiera błędów!");
            }
            if (a[0] + a[1] + a[2] + b[0] + b[1] + b[2] + c[0] + c[1] + c[2] != 45)
            {
                Console.WriteLine("Sekcja 1 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 1 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
            if (a[3] + a[4] + a[5] + b[3] + b[4] + b[5] + c[3] + c[4] + c[5] != 45)
            {
                Console.WriteLine("Sekcja 2 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 2 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
            if (a[6] + a[7] + a[8] + b[6] + b[7] + b[8] + c[6] + c[7] + c[8] != 45)
            {
                Console.WriteLine("Sekcja 3 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 3 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
            if (d[0] + d[1] + d[2] + e[0] + e[1] + e[2] + f[0] + f[1] + f[2] != 45)
            {
                Console.WriteLine("Sekcja 4 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 4 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
            if (d[3] + d[4] + d[5] + e[3] + e[4] + e[5] + f[3] + f[4] + f[5] != 45)
            {
                Console.WriteLine("Sekcja 5 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 5 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
            if (d[6] + d[7] + d[8] + e[6] + e[7] + e[8] + f[6] + f[7] + f[8] != 45)
            {
                Console.WriteLine("Sekcja 6 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 6 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
            if (g[0] + g[1] + g[2] + h[0] + h[1] + h[2] + i[0] + i[1] + i[2] != 45)
            {
                Console.WriteLine("Sekcja 7 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 7 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
            if (g[3] + g[4] + g[5] + h[3] + h[4] + h[5] + i[3] + i[4] + i[5] != 45)
            {
                Console.WriteLine("Sekcja 8 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 8 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
            if (g[6] + g[7] + g[8] + h[6] + h[7] + h[8] + i[6] + i[7] + i[8] != 45)
            {
                Console.WriteLine("Sekcja 9 (od góry z lewej strony w prawym kierunku) zawiera błędy!");
            }
            else
            {
                Console.WriteLine("Sekcja 9 (od góry z lewej strony w prawym kierunku) nie zawiera błędów!");
            }
        }
    }
}