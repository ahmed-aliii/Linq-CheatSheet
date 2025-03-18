using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace vid1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///LINQ : Language Indepenent Query
            ///Use 40+ C# Functions (Query Operator) Aganist Data , Regardless Of Data Store
            ///L2Object , L2XML , L2ADO , L2SQL (ORM) Object Relational Mappers 
            ///.NetFramework 3.5 SP1 : EF (ORM) L2EF
            ///Query Over Any Type Of Data


            #region Implicit Type Local Variable

            //var D = 12.125;

            //Console.WriteLine(D.GetType());

            ////D = "Hello"; ///Not Valid C# Strongly Typed Language 
            #endregion

            #region Extension Method
            //int X = 12345;

            //int Y = Int32Extension.Mirror(X);

            ////Y = X.Mirror();

            //Console.WriteLine(Y);

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //list.First(); 
            #endregion

            #region Anonymous Type
            //Employee E1 = new Employee() { Id = 101, Name = "Ahmed", Salary = 1000 };

            //Console.WriteLine(E1.GetType().Name);

            //Console.WriteLine(E1);

            //Employee E2 = new Employee() { Id = 101, Name = "Ahmed", Salary = 1000 };

            //if(E1.Equals(E2))
            //    Console.WriteLine("Value EQ");
            


            ////Anonymous Type -> Immutable class 
            ////Object E1 = new { Id = 101, Name = "Ahmed", Salary = 1000 };
            //var E1 = new { Id = 101, Name = "Ahmed", Salary = 1000M };

            //Console.WriteLine(E1.GetType().Name);
            ////Console.WriteLine(E1.GetType().FullName);

            //Console.WriteLine(E1);

            ////E1.Id = 1; ///Immutable Object
            ////Immutable class
            ////Once You Create one Object You Can Not change in its data Unless You Create new Object

            ////Same DataType As long As Same Prperty Names (With Same charcter case) , same sequence
            //var E2 = new { Id = 102, Name = "Tamer", Salary = 2222M };
            //Console.WriteLine(E2.GetType().Name);
            //Console.WriteLine(E2);

            ////New Anonymous Type
            //var E3 = new { Name = "Tamer", Id = 102, Salary = 2222M };
            //Console.WriteLine(E3.GetType().Name);
            //Console.WriteLine(E3);

            //var E4 = new { Id = 101, Name = "Ahmed", Salary = 1000M };//same as E1 

            //if (E4.Equals(E1))
            //    Console.WriteLine("Value EQ");

            //Console.WriteLine(E1.GetHashCode());
            //Console.WriteLine(E4.GetHashCode());

            /////GetHashCode based on Values Not Identity

            //var P1 = new { ProductID = 101, Name = "Pens" };
            //Console.WriteLine(P1.GetType()); 


            var o1 = new { Id = 101, Name = "Ahmed", Salary = 1000M };
            Console.WriteLine(o1.GetType().FullName);
            #endregion

            /// Linq Queries Aganist any Sequence 
            /// Sequence : Class Implementing IEnumerable<T> Interface
            /// Local Sequence : L2Object , L2ADO , L2XML
            /// Remote Sequence : L2SQL , L2EF
            /// Sequence Contains Elements
            /// 

            ///Linq Operators(Methods) Catergories
            ///1. Input Sequence -> (Linq Operator ) -> Output Sequence
            ///2. Input Sequence -> (Linq Operator | Aggregation Methods) -> Single Element   
            ///3. No Input -> (Linq Operator | Generation Methods) -> Output Sequence 

            List<int> Lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> NameList = new List<string>() { "Ahmed", "Ali", "Sally", "Mahmoud", "Mai" };


            #region LINQ Static Method & Extension Methods & Query Expression EX01

            ////Func<int, bool> predicate = new Func<int, bool>((int i) => i % 2 == 0);

            ////IEnumerable<int> Result =  Enumerable.Where(Lst, (int i) => i % 2 == 0);

            ////Fluent Syntax
            ////Static Method Member in Enumerable Class
            //var Result = Enumerable.Where(Lst, (int i) => i % 2 == 0);


            ////Extension Methods
            //var R = Lst.Where(i => i > 0);//.OrderByDescending(i => i);


            ////Query Expression \\ Query Syntax (SQL Like) 
            //var RR = from i in Lst
            //         where i % 2 == 0
            //         select i;
            /////sql Like style, valid only for Subset of (40+ LINQ Operators)
            /////Some cases it is easier to write Query using Query Expression vs Fluent Syntax ( Join , Group , Let , Intro)
            /////Start with From, introduce Range Variable (i) : represent each and every element in Input Sequence
            /////End with Select or Group By

            //foreach (int i in Result)
            //    Console.Write(i + " "); 
            #endregion

            #region LINQ EX02 Deffered Execution & Imidiate Execution  EX02

            ////Deffered Execution
            ////Most Of LINQ Operators , Deffered Execution -> Query Update per each foreach
            //var Result = Lst.Where(i => i % 2 == 0);
            ////Result -> is refrence to Lst Hold The Query Not The list
            ////Result Will Updated for every foreach  

            ////Console.WriteLine(Result.GetType());

            //Lst.Add(10);
            //Lst.AddRange(new int[] { 11, 12, 13, 14 });

            //foreach (var i in Result)
            //    Console.Write($"{i} ");
            //Console.WriteLine();


            //Lst.Add(15);
            //Lst.AddRange(new int[] { 16, 17, 18 });

            //foreach (var i in Result)
            //    Console.Write($"{i} ");
            //Console.WriteLine();


            //Imidiate Execution
            //Casting Operators , Element Operators are Imidiate Execution Operators
            //Most Of LINQ Operators , Deffered Execution -> Query Update per each foreach
            //var Result = Lst.Where(i => i % 2 == 0).ToList();

            //Console.WriteLine(Result.GetType());

            //Lst.Add(10);
            //Lst.AddRange(new int[] { 11, 12, 13, 14 });

            //foreach (var i in Result)
            //    Console.Write($"{i} ");
            //Console.WriteLine();

            //Lst.Add(15);
            //Lst.AddRange(new int[] { 16, 17, 18 });

            //foreach (var i in Result)
            //    Console.Write($"{i} ");
            //Console.WriteLine(); 
            #endregion


        }

    }
}