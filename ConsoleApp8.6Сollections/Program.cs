namespace ConsoleApp8._6Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listRandomNum = WorkingAList.RandomListNum(0, 100, 100);

            WorkingAList.СonclusionListNum(listRandomNum);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");


            var listRemoveRange = WorkingAList.RemoveNumRange(25, 50, listRandomNum);

            WorkingAList.СonclusionListNum(listRemoveRange);
        }
    }
}
