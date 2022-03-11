using System;

public class Kodepos
{
    public static void Main(string[] args)
    {

        static int getKodePos(int kodePos)
        {
            int[] KP = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286
                     , 40272, 40274, 40273 };

            string[] kel = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
                         "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };

            return KP[kodePos];

        }
        int i = 0;
        while(i < 11)
        {
            Console.WriteLine(getKodePos(i));
            i++;
        }

        
    }
}