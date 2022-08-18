//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    static void Main() {
        Console.Write("a= ");
        string sa = Console.ReadLine();
        double a = Convert.ToDouble(sa), b = 1;

        Console.Write("n= ");
        string sn = Console.ReadLine();
        int n = Convert.ToInt32(sn);

       for(int i=0;i<n;i++) b *= a;
        Console.Write(b); Console.Read();
    }

