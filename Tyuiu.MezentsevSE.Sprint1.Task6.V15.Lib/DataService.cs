using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MezentsevSE.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string x)
        {
            int countB = x.Count(char.IsLetter);
            int Len = x.Length;
            int countA = Len - countB;
            if (countA < countB)
            {
                return true;
            }
            else
            {
                return false;
            }

            
                
        }
    }
}
