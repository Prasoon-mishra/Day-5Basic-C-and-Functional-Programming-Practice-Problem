namespace Functional_Programming
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Presss 1 for Heads or tails");
            Console.WriteLine("Presss 2 Leap year");
            Console.WriteLine("Presss 3 for power of two");
            Console.WriteLine("Presss 4 for harmonic series");
            Console.WriteLine("Presss 5 for Prime Factors");
            Console.WriteLine("Presss 6 for swaping two numbers");
            Console.WriteLine("Presss 7 to check Even or Odd");
            Console.WriteLine("Presss 8 to check whether entered character is vowels or consonants");
            Console.WriteLine("Presss 9 to check the largest among three numbers");
            int check=Convert.ToInt32(Console.ReadLine());

            switch(check)
            {
                case 1:
                    HeadorTails hd = new HeadorTails();
                    hd.HeadsOrTailPercentage();
                    break;
                case 2:
                    LeapYear Lp = new LeapYear();
                    Lp.leapYear();
                    break;
                case 3:
                    PowerOfTwo Pw = new PowerOfTwo();
                    Pw.powOfTwo();
                    break;
                case 4:
                    HarmonicNumber Hp = new HarmonicNumber();
                    Hp.Harmonic();
                    break;
                case 5:
                    PrimeFactor Pm = new PrimeFactor();
                    Pm.Factors();
                    break;
                case 6:
                    Swaping Sp=new Swaping();
                    Sp.SwapingTwoNumbers();
                    break;
                case 7:
                    EvenOdd Ev = new EvenOdd();
                    Ev.EvenOrOdd();
                    break;
                case 8:
                    Vowels Vw = new Vowels();
                    Vw.vowelsOrConsonants();
                    break;
                case 9:
                    Largest Lg=new Largest();
                    Lg.LargestAmongThree();
                    break;
                default:
                    Console.WriteLine("The entered value is wrong");
                    break;
            }  

        }
    }
}
