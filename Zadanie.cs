class Zadanie
{
    static void Main()
    {
        string st1 = Console.ReadLine();
        int num1 = System.Convert.ToInt32(st1);
        Console.WriteLine(CountBits(num1));
        string st2 = Console.ReadLine();
        int num2 = System.Convert.ToInt32(st2);
        Console.WriteLine(Persistence(num2));
        string st3 = Console.ReadLine();
        int num3 = System.Convert.ToInt32(st3);
        DigitalRoot(num3);

    }

    static int CountBits(int num)
    {
        string bin = Convert.ToString(num, 2);

        int count = 0;

        for (int i = 0; i < bin.Length; i++)
        {
            if (bin[i] == '1')
            {
                count++;
            }
        }

        return count;
    }
    static int Persistence(int num)
    {
        int schet = 0;
        if (num < 10)
        {
            return 1;
        }
        while (num >= 10) 
        {
            int proizved = 1; 
            while (num > 0)
            {
                proizved *= num % 10; 
                num /= 10; 
            }
            num = proizved; 
            schet++; 
        }
        
        return schet; 
    }

    static int DigitalRoot(int num)
    {
        while (num >= 10) 
        {
            int sum = 0;
            int temp = num; 
            
            while (temp > 0)
            {
                int n = temp  % 10; 
                sum += n; 
                temp /= 10; 
            }
            Console.WriteLine(num + " => " + sum); 
            num = sum;
        }
        return 0;
    }
}
