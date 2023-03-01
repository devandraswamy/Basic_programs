namespace Basic_programs
{
    internal class FiboSeries
    {
        public static void Main(string[] args)
        {
            int firstnum = 0, secondnum = 1, nextnum, getnum; //we have 4 variable here, firstnum,secondnum are default value,nextnum and getnum are calculating value
            Console.WriteLine("Enter the number that you want to generate Fibo series");
            getnum = Int32.Parse(Console.ReadLine());//converting string to number
            if (getnum < 2)//according to formula we can't perform fibo series for number lessthan 2
            {
                Console.WriteLine("Enter The Number which is bigger than 2");
            }
            else
            {
                Console.WriteLine(firstnum + "\n" + secondnum + "");
                for (int i = 2; i < getnum; i++)
                {
                    nextnum = firstnum + secondnum;
                    Console.WriteLine(nextnum + "");
                    firstnum = secondnum; secondnum = nextnum;

                }

            }


        }
    }
}
