using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drevo
{
    enum Gender 
    {
    Male ='m',
    Female = 'f'
    }
    internal class Person
    {
        public string ?Name { get; set; }
        public int Age { get; set; }
        public Person ?Mother { get; set; }
        public Person ?Father { get; set; }
        public int CildsCount { get; set; }
        public Person [] ?Children { get; set; }

        public Person ?WifeOrHusband {  get; set; } 

        public Gender Gender { get; set; }

        public void PrintME() 
        {
            if (Age == 0)
            {
                Console.Write($" |{Name}|");
            }
            else
            {
                Console.Write($" |{Name}|");
            }
            
            
        }
        public void PrintParents()
        {
            if (Mother == null||Father==null)
            {
                Console.WriteLine("Mother unspesified");
            }
            else
            {
                Console.Write($"Mother {Mother.Name}    Father {Father.Name} \t \t");
            }
        }
        public void PrintChildren( ) 
        {
            if (Children != null || CildsCount == 0)
            {
                Console.WriteLine("No Children");
            }
            else
            {

                for (int i = 0; i < CildsCount; i++)
                {
                    Console.Write($"\t \t  Child{i} : {Children[i]} ");
                }
            }
        }
        public void PrintWifeOrHusband()
        {
            if (WifeOrHusband == null) 
            {
                Console.WriteLine("Have no Wife or Husband");
            }
            else 
            {
                Console.Write($"\t Wife/Husband {WifeOrHusband}");
            }
        }
    }
}
