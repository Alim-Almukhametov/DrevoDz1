namespace Drevo
{
    internal class Program
    {
        static void InitializePersonsFamily(Person me, Person mother, Person father, Person wifeOrHusband, params Person[] child)
        {
            if (father == null) 
            {
            me.Father=null;
            }
            if (wifeOrHusband == null) { me.WifeOrHusband=null;}
            if(mother == null) { me.Mother=null; }
            if (child.Length == 0 || child == null) { me.Children = null; }
            else
            {
                me.Children = new Person[me.CildsCount];
                for (int i = 0; i < me.CildsCount; i++)
                {
                    me.Children[i] = child[i];
                }
            }
            me.WifeOrHusband = wifeOrHusband;
            me.Father = father;
            me.Mother = mother;
        }
        static void InitializePersonsFamily(Person me, Person wifeOrHusband, params Person[] child)
        {
            
            if (wifeOrHusband == null) { me.WifeOrHusband = null; }

            if (child.Length == 0 || child == null) { me.Children = null; }
            else
            {
                me.Children = new Person[me.CildsCount];
                for (int i = 0; i < me.CildsCount; i++)
                {
                    me.Children[i] = child[i];
                }
                me.WifeOrHusband = wifeOrHusband;
            }
        }
        static void Main(string[] args)
        {
            Person me = new Person { Name="Tata" , Age = 37 ,Gender = Gender.Female, CildsCount = 1 };
            Person mother = new Person { Name="Karine" , Gender = Gender.Female , Age =70 ,CildsCount = 1 };
            Person father = new Person { Name="Garegin", Age=72 ,Gender = Gender.Male, CildsCount=1 };
            Person alise = new Person { Name="Alise" , Age = 12 , Gender = Gender.Female  , CildsCount=0};
            Person timur = new Person { Name="Timur" , Gender= Gender.Male , Age=30 , CildsCount=1};
            Person grandMothM = new Person { Name = "Seda", Gender = Gender.Female,CildsCount=2 };
            Person grandFathM = new Person { Name = "Suren", Gender = Gender.Male, CildsCount=2 };
            Person grandMothF = new Person { Name ="Mane" , Gender =Gender.Female, CildsCount=2 };
            Person grandFathF = new Person { Name ="Ashot" , Gender =Gender.Male , CildsCount=2};
           

            InitializePersonsFamily(me,mother,father,timur,alise);
            InitializePersonsFamily(mother,grandMothM ,grandFathM ,father ,me);
            InitializePersonsFamily(father,grandMothF ,grandFathF, mother , me);
            InitializePersonsFamily(timur,me,alise);
            InitializePersonsFamily(alise, me ,timur ,new Person());
            grandMothM.PrintME();
            grandFathM.PrintME();
            Console.Write(" & ");
            grandFathF.PrintME();
            grandMothF.PrintME();
            Console.WriteLine();
            Console.Write("\t");
            mother.PrintME();
            Console.Write("&");
            father.PrintME();
            Console.WriteLine();
            Console.Write("\t"+"   ");
            me.PrintME();
            timur.PrintME();
            Console.WriteLine();
            Console.Write("\t" + "      ");
            alise.PrintME();

            //На консоли вывод всей информации не красиво получается по этому вывожу только имя 
            // так же определила методы отдельного вывода данных по специфике . 
            // Спасибо заранее.






        }
    }
}
