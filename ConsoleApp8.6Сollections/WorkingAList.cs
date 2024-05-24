using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8._6Сollections
{
    public class WorkingAList
    {
        static public List<int> RandomListNum(int minNum, int maxNum, int count)
        {
            Random random = new Random();
            List<int> listNum = new List<int>();
            random.Next(minNum, maxNum);

            for(int i = 0; i < count; i++)
            {
                int randomListNum = random.Next(minNum, maxNum);
                listNum.Add(randomListNum);
            }

            return listNum;
            
        }


        static public void СonclusionListNum(List<int> listNum)
        {
            foreach(int num in listNum)
            {
                Console.Write($"{num} ");
            }
        }


        static public List<int> RemoveNumRange(int minNum, int maxNum, List<int> listNum)
        {
            listNum.RemoveAll(x => x > minNum && x < maxNum);

            return listNum;
        }
    }
}
