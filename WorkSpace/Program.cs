using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace WorkSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filtering => Where

            ////Where : Filter Data Based On Some Condition
            ///// Input Sequence -> (Linq Operator) -> Output Sequence
            //EX: IEnumerable<T> filteredCollection = collection.Where(condition);
            ///collection : The input sequence(List, Array, etc.).
            ///condition : delegate input parameter of type Func<T1, T> | Func<T, int(index), T> 
            /// Func<T1, bool>  => take one input parameter and return bool Type
            /// Func<T, int(index), bool> => take two input parameter second must be int (index) and return bool Type
            ///filteredCollection : IEnumerable<T> return type 

            //List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<string> names = new List<string>() { "Ali", "Ahmed", "Sally", "Mohahmed", "Hasan", "hussen" };

            ////input parameter is a Func<T,bool> delegate 
            //var OutputSequence = lst.Where((lstElement) => lstElement % 2 == 0);
            //var OutputSequence2 = names.Where((name) => name.Length>3 );

            ////input parameter is a Func<T,T,bool> delegate
            //List<int> lst2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OutputSequence3 = lst2.Where((value , index) => ( (value%2==0) && (index>=5) ) );

            //foreach (var item in OutputSequence)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //foreach (var item in OutputSequence2)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //foreach (var item in OutputSequence3)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            #endregion

            #region Projection => Select , SelectMany

            #region Select

            /////Select : Project every Element and do some operation on it
            /////Input Sequence -> (Linq Operator) -> Output Sequence(with Same Size as input)
            ////EX: IEnumerable<T> filteredCollection = collection.Select(condition);
            /////collection : The input sequence(List, Array, etc.).
            /////condition : delegate input parameter of type Func<T1, T> | Func<T, int(index), T> 
            /////Func<T1, T>    => take one input parameter and return T Type
            ///// Func<T, int(index), T> => take two input parameter second must be int (index) and return T Type
            /////filteredCollection : IEnumerable<T> return type 


            //List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var outputSequence1 = lst.Select(element => (element * 2));


            //List<string> names = new List<string>() { "Ali", "Ahmed", "Sally", "Mohahmed", "Hasan", "hussen" };
            //var outputSequence2 = names.Select( element => element.ToUpper() );



            //foreach (var item in outputSequence1)
            //{
            //    Console.Write($" {item} "); 
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var item in outputSequence2)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();

            #endregion

            #region SelectMany

            //// SelectMany :  Flattening List of Lists => make one list of many lists
            //// Input Sequence -> (Linq Operator) -> Output Sequence

            ////XE: IEnumerable<TResult> SelectMany<TSource, TResult>(Func<TSource, IEnumerable<TResult>> selector)
            /////TSource → Type of elements in the source collection.
            /////TResult → Type of elements in the flattened collection.
            /////selector → A function that transforms TSource into IEnumerable<TResult>.
            /////📌 Return Type: IEnumerable<TResult>(single, flattened sequence).


            ////List of int arrays
            //List<int[]> lstOfInts = new List<int[]>();
            //lstOfInts.Add(new int[] { 1, 2 });
            //lstOfInts.Add(new int[] { 3 });
            //lstOfInts.Add(new int[] { 4,5,6 });

            //var outputSequence1 = lstOfInts.SelectMany(arrayElement => arrayElement);

            ////List of int arrays
            //List<string[]> lstOfNames = new List<string[]>();
            //lstOfNames.Add(new string[] { "Ahmed" });
            //lstOfNames.Add(new string[] { "Ali"  , "Salma"});
            //lstOfNames.Add(new string[] { "Hassan" , "Sayed" });

            //var outputSequence2 = lstOfNames.SelectMany(arrayEOfNames => arrayEOfNames);

            //foreach (var item in outputSequence1)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var item in outputSequence2)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            #endregion

            #endregion

            #region Sort => OrderBy - OrderByDescending - ThenBy - ThenByDescending - Reverse

            #region OrderBy
            ////OrderBy(Ascending Order)

            ////IOrderedEnumerable<TSource> OrderBy<TSource, TKey>( Func<TSource, TKey> keySelector)
            ////TSource → Type of elements in the source collection.
            ////TKey → Type of the key used for sorting.
            ////keySelector → A function that extracts the sorting key.

            //List<int> lst = new List<int>() { 6, 4, 2, 1, 5, 3 };
            //var outputSequence = lst.OrderBy(keyElement => keyElement);

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee() {Name = "Ahmed" , Age=20} ,
            //    new Employee() {Name = "Salma" , Age=25} ,
            //    new Employee() {Name = "Hassam" , Age=30} ,

            //};
            //var ouputSequence2 = employees.OrderBy(employee => employee.Age);

            //foreach (var item in outputSequence)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var item in ouputSequence2)
            //{
            //    Console.Write($" [{item.ToString()}]   ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            #endregion

            #region OrderByDescending
            ////OrderByDescending => (Descending Order)

            ////IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>( Func<TSource, TKey> keySelector)
            ////TSource → Type of elements in the source collection.
            ////TKey → Type of the key used for sorting.
            ////keySelector → A function that extracts the sorting key.

            //List<int> lst = new List<int>() { 6, 4, 2, 1, 5, 3 };

            //var outputSequence = lst.OrderByDescending(keyElement => keyElement);


            //foreach (var item in outputSequence)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            #endregion

            #region ThenBy
            ////ThenBy(Secondary Sorting in Ascending Order)
            ////    Used when sorting by multiple criteria.

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee() {Name = "Ahmed" , Age=20} ,
            //    new Employee() {Name = "Salma" , Age=25} ,
            //    new Employee() {Name = "Hassam" , Age=30} ,
            //    new Employee() {Name = "Ali" , Age=30} ,

            //};
            //var ouputSequence2 = employees.OrderBy(employee => employee.Age).ThenBy(employee => employee.Name);

            //foreach (var item in ouputSequence2)
            //{
            //    Console.Write($" [{item.ToString()}]   ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            #endregion

            #region Reverse
            //// Reverse (Reverses Order Without Sorting)
            //// void function and Take No input parameter
            //// Same input sequence Type


            //List<int> lst = new List<int>() { 1, 3, 0, 7, 2 };
            //lst.Reverse();

            //foreach (int item in lst)
            //{
            //    Console.Write($"{item}  ");
            //}
            //Console.WriteLine();

            #endregion



            #endregion

            #region Grouping => GroupBy
            ////GroupBy
            ////IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(Func<TSource, TKey> keySelector)
            ////TSource → Type of elements in the source collection.
            ////TKey → Type of the key used for grouping.
            ////keySelector → A function that extracts the grouping key.
            ////📌 Return Type: IEnumerable<IGrouping<TKey, TSource>>(a collection of groups).

            //List<Employee> employees = new List<Employee>()
            //{
            //        new Employee() {Name = "Ahmed" , Age=20} ,
            //        new Employee() {Name = "Salma" , Age=20} ,
            //        new Employee() {Name = "Hassam" , Age=30} ,
            //        new Employee() {Name = "Ali" , Age=30} ,
            //        new Employee() {Name = "Mazen" , Age=40} ,
            //        new Employee() {Name = "Mena" , Age=40} ,
            //};

            //var SequenceOfGroups = employees.GroupBy(employee => employee.Age);

            //foreach (var group in SequenceOfGroups)
            //{
            //    foreach (var employee in group)
            //    {
            //        Console.Write($"Group of Age : {group.Key} => ");
            //        Console.Write($" [ {employee.ToString()} ]  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine();


            //var AllGroupsOnSameSequence = employees.GroupBy(employee => employee.Age)
            //                                       .SelectMany(GroupOfEmps => GroupOfEmps);

            //Console.Write($" [ ");
            //foreach (var employee in AllGroupsOnSameSequence)
            //{
            //    Console.Write($"({employee.ToString()}) , ");
            //}
            //Console.Write($" ] ");
            //Console.WriteLine();
            //Console.WriteLine();

            #endregion

            #region Joining => Join - GroupJoin

            #region Join
            ////Join (Inner Join)
            ////Used to combine elements from two collections where keys match.
            ////Similar to an SQL INNER JOIN.
            ////📌 Signature:
            ////IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(
            ////    IEnumerable<TInner> inner,
            ////    Func<TOuter, TKey> outerKeySelector,
            ////    Func<TInner, TKey> innerKeySelector,
            ////    Func<TOuter, TInner, TResult> resultSelector)

            ////TOuter → Type of elements in the first(left) collection.
            ////TInner → Type of elements in the second(right) collection.
            ////TKey → Type of the key used for joining.
            ////TResult → Type of elements in the result.
            //var employees = new List<Employee>
            //{
            //    new Employee { Id = 1, Name = "Ali", DepartmentId = 1 },
            //    new Employee { Id = 2, Name = "Sara", DepartmentId = 2 },
            //    new Employee { Id = 3, Name = "Omar", DepartmentId = 1 }
            //};

            //var departments = new List<Department>
            //{
            //    new Department { Id = 1, DepartmentName = "IT" },
            //    new Department { Id = 2, DepartmentName = "HR" }
            //};

            //var outputSequence = departments.Join(
            //                                        employees,
            //                                        (department) => department.Id,
            //                                        (employee) => employee.DepartmentId,
            //                                        (dept, emp) => new { emp.Name, dept.DepartmentName , dept.Id }
            //                                        );

            ////Console.WriteLine( outputSequence.GetType() );
            //Console.WriteLine("[EmployeeName , DepartmentName , DepartmentId]");
            //foreach(var AnonymousObj in outputSequence)
            //{
            //    Console.WriteLine($"[ {AnonymousObj.Name}::{AnonymousObj.DepartmentName}::{AnonymousObj.Id} ]   " );
            //}
            //Console.WriteLine();
            #endregion

            #endregion

            #region Set Operators => Distinct - Union - Inersect - Execpt

            #region Distinct
            ////Distinct (Remove Duplicates)
            ////Removes duplicate elements from a collection.
            ////📌 Signature: IEnumerable<TSource> Distinct<TSource>()
            ////📌 Return Type: IEnumerable<TSource>(unique elements).

            //List<int> list = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };

            //var Distinct = list.Distinct();

            //foreach (int item in Distinct)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();


            #endregion

            #region Union

            ////Union(Combine Two Collections, Removing Duplicates)
            ////Combines two collections into one, removing duplicates.
            ////Similar to SQL UNION.
            ////📌 Signature:

            ////IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> second)
            ////📌 Return Type: IEnumerable<TSource>(unique elements from both collections).

            //List<int> list = new List<int>() { 1,2,3,4 };
            //List<int> listTwo = new List<int>() { 5,6,7,8 };

            //var UnionList = list.Union(listTwo);

            //foreach (int item in UnionList)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();

            #endregion

            #region Intersect - Except

            ////Intersect(Find Common Elements)
            ////Returns only the elements that exist in both collections.
            ////Similar to SQL INTERSECT.
            ////📌 Signature:
            ////IEnumerable<TSource> Intersect<TSource>(IEnumerable<TSource> second)
            ////📌 Return Type: IEnumerable<TSource>(common elements).

            //List<int> list = new List<int>() { 1, 2, 3, 4 };
            //List<int> listTwo = new List<int>() { 2,3,4, 8 };
            //List<int> listThree = new List<int>() { 3,4,5,6 };

            //var InersectList = list.Intersect(listTwo);
            //var ExceptList = list.Except(listThree);

            //foreach (int item in InersectList)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //foreach (int item in ExceptList)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            #endregion

            #endregion

            #region Aggregation => Count - Sum - Average - Max - Min - Aggregate
            //// Count
            ////📌 Signature
            ////int Count<TSource>()
            ////int Count<TSource>(Func<TSource, bool> predicate)

            ////Sum - Average - Max - Min
            ////📌 Signature
            ////int Sum()
            ////int Sum(Func<TSource, int> selector)

            ////Aggregate(Custom Aggregation)
            ////Performs a custom calculation on the sequence.
            ////Works like a folding/ reduction function.
            ////📌 Signature:
            ////TSource Aggregate(Func < TSource, TSource, TSource > func)
            ////TAccumulate Aggregate<TSource, TAccumulate>(
            ////          TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)

            //////First Signature
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine($"Count: {list.Count()} :: Sum: {list.Sum()} :: Average {list.Average()}");

            ////Second Signature
            //List<int> listTwo = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int CountOfAllEven = list.Count(num => num % 2 == 0);
            //Console.WriteLine($"Count of All Even Numbers: {CountOfAllEven}");

            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Ali", Salary = 3000 },
            //    new Employee { Name = "Sara", Salary = 4000 },
            //    new Employee { Name = "Omar", Salary = 3500 }
            //};

            //var MaxSalary = employees.Max(emp => emp.Salary);
            //Console.WriteLine($"Employee Max Salary : {MaxSalary}");

            #endregion

            #region Quantifiers => Any - All - Contains

            #region Any
            //// Any (Check if Any Element Exists or Matches a Condition)
            ////Returns true if at least one element in the collection matches the condition.
            ////📌 Signature:
            ////bool Any()
            ////bool Any(Func<TSource, bool> predicate)

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var ContainsElementMatches = list.Any();
            //Console.WriteLine($"List Contains Any : {ContainsElementMatches}");

            //var AnyElementMatches = list.Any(element => element>10);
            //Console.WriteLine($"Any Element > 10 : {AnyElementMatches}");

            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Ali", Salary = 3000 },
            //    new Employee { Name = "Sara", Salary = 5000 }
            //};
            //var AnyEmployeeMatches = employees.Any(employee => employee.Salary > 4000);
            //Console.WriteLine($"Any Employee Salary > 4000 : {AnyEmployeeMatches}");
            #endregion

            #region All
            //// All(Check if All Elements Match a Condition)
            ////Returns true if all elements satisfy the given condition.
            ////📌 Signature:
            ////bool All(Func<TSource, bool> predicate)
            ////📌 Return Type: bool.

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var AllElementsMatches = list.All(element => element>0) ;
            //Console.WriteLine($"All Elements>0 : {AllElementsMatches}");

            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Ali", Salary = 3000 },
            //    new Employee { Name = "Sara", Salary = 5000 }
            //};
            //var CheckOnAllEmployeesSalary = employees.All(employee => employee.Salary>1000);
            //Console.WriteLine($"Are All Employees Salary > 1000: {CheckOnAllEmployeesSalary}");
            #endregion

            #region Contains

            ////Contains(Check if a Specific Element Exists)
            ////Checks if a collection contains a specific element.
            ////📌 Signature:
            ////bool Contains(TSource value)
            ////bool Contains(TSource value, IEqualityComparer<TSource>? comparer)
            ////📌 Return Type: bool.

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var ContainsElement = list.Contains(5);
            //Console.WriteLine($"List Contains Element 5 : {ContainsElement}");

            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Ali", Salary = 3000 },
            //    new Employee { Name = "Sara", Salary = 5000 }
            //};

            //Employee Ali = new Employee() { Name = "Ali", Salary = 3000 };

            //var IsListContainsAli = employees.Contains(Ali , new EmployeeComparer() );
            //Console.WriteLine($"employees List Contains Ali : {IsListContainsAli}");

            //var AnonymousEmployee = new { Id = 0 , DepartmentId=0, Name = "Ali", Age=0, Salary = 3000 };

            //var CheckAnonymousEmployee = employees.Contains(Ali, new EmployeeComparer());
            //Console.WriteLine($"employees List Contains AnonymousEmployee : {CheckAnonymousEmployee}");
            #endregion

            #endregion

            #region Element Selection => First - Last - FirstOrDefault - LastOrDefault - ElementAt - ElementAtOrDefault

            #region First - Last - ElementAt
            ////First or Last (Get the First or Last Element)
            ////Returns the first element in a collection.
            ////Throws an exception if the collection is empty.
            ////📌 Signature:
            ////TSource First();
            ////TSource First(Func<TSource, bool> predicate);
            ////📌 Return Type: The first element of type TSource.
            ////📌 Return Type : Exception Error if List is Empty

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine($"list First Number: {list.First()}");
            //Console.WriteLine($"list First Even Number  : {list.First(num => num%2==0)}");

            //List<int> EmptyList = new List<int>() { };
            //Console.WriteLine($"First in Empty list: {EmptyList.First()}"); //Fire Exception

            #endregion

            #region FirstOrDefault - LastOrDefault - ElementAtOrDefault
            ////FirstOrDefault(Get First Element or Default)
            ////Returns the first element, but returns default(TSource) if empty(e.g., null for reference types, 0 for integers).
            ////Does not throw an exception like First().
            ////📌 Signature:
            ////TSource? FirstOrDefault();
            ////TSource? FirstOrDefault(Func<TSource, bool> predicate);

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine($"list First Number: {list.FirstOrDefault()}");
            //Console.WriteLine($"list First Even Number  : {list.FirstOrDefault(num => num % 2 == 0)}");

            //List<int> EmptyList = new List<int>() { };
            //Console.WriteLine($"First in list Or Default if Empty   : {EmptyList?.FirstOrDefault()}"); //NO Exception Return Null
            #endregion

            #region ElementAt

            #endregion


            #endregion

            #region Partioning => Take - Skip - TakeWhile - SkipWhile

            #region Take - Skip
            ////Take(n) → Get the First n Elements
            ////Extracts the first n elements from a collection.
            ////If n is greater than the collection size, it returns all elements(does not throw an exception).
            ////📌 Signature:
            ////IEnumerable<TSource> Take(int count)

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var TakeFromTOSequence = list.Take(1..2);//Range Take

            //var NewSequence = list.Take(3);
            //Console.Write("Fake First 3 Elements");
            //foreach ( var item in NewSequence)
            //    Console.Write($" {item} ");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.Write("Skip First 3 Elements");
            //var NewSequence2 = list.Skip(3);
            //foreach (var item in NewSequence2)
            //    Console.Write($" {item} ");
            //Console.WriteLine();
            //Console.WriteLine();



            #endregion

            #region TakeWhile - SkipWhile
            ////TakeWhile(predicate) → Take Elements While Condition is True
            ////Starts taking elements from the beginning and stops when the condition first fails.
            ////📌 Signature:
            ////IEnumerable<TSource> TakeWhile(Func<TSource, bool> predicate)
            //// ✅ (Condition is true)
            //// ✅ (Condition is true)
            //// ❌ (Condition fails → Stops here)


            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            //var takeWhile = list.TakeWhile(element => element<5);

            //Console.Write("TakeWhile All elements>5: ");
            //foreach (var item in takeWhile)
            //    Console.Write($" {item} ");

            //Console.WriteLine();
            //Console.WriteLine();

            //var skipWhile = list.SkipWhile(element => element<5);

            //Console.Write("SkipWhile All elements>5:  ");
            //foreach (var item in skipWhile)
            //    Console.Write($" {item} ");
            //Console.WriteLine();
            //Console.WriteLine();
            #endregion

            #endregion

            #region Generate => Range - Repeat - Empty

            #region Range
            ////Enumerable.Range(start, count) → Generate a Range of Numbers
            ////Creates a sequence of consecutive integers starting from start and containing count elements.
            ////📌 Signature:
            ////IEnumerable<int> Enumerable.Range(int start, int count)

            //var Sequence = Enumerable.Range(0, 10);

            //foreach (var item in Sequence)
            //{
            //    Console.Write($" {item} ");
            //}

            #endregion

            #region Repeat
            ////Enumerable.Repeat(element, count) → Repeat an Element Multiple Times
            ////Creates a sequence containing the same value repeated count times.
            ////📌 Signature:
            ////IEnumerable<T> Enumerable.Repeat(T element, int count)

            //var sequenece = Enumerable.Repeat(1, 10);
            //foreach (var item in sequenece)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //var sequence2 = Enumerable.Repeat(new { Id = 1, Name = "Ahmed" } , 3);
            //foreach (var item in sequence2)
            //{
            //    Console.Write($" {item} ");
            //}

            #endregion

            #region Empty
            ////Enumerable.Empty<T>() → Create an Empty Sequence
            ////Returns an empty sequence of type T(useful for returning an empty list).
            ////📌 Signature:
            ////IEnumerable<T> Enumerable.Empty<T>()

            //var emptySequence = Enumerable.Empty<int>();
            //Console.WriteLine(emptySequence.GetType());
            #endregion

            #endregion

            #region Conversion => ToList - ToArray - ToDictionary - ToLookUp

            #region ToDictionary
            ////ToDictionary() → Convert to Dictionary<TKey, TValue>
            ////Converts an IEnumerable<T> to a dictionary (Dictionary<TKey, TValue>).
            ////📌 Signature:
            ////Dictionary<TKey, TValue> ToDictionary<TSource, TKey>(Func<TSource, TKey> keySelector)
            ////Dictionary<TKey, TValue> ToDictionary<TSource, TKey, TValue>(
            ////    Func<TSource, TKey> keySelector,
            ////    Func<TSource, TValue> elementSelector
            ////)

            //var ListOfemployees = new List<Employee>()
            //{
            //    new Employee(){Id=1 , Name="Ahmed" , Age=20 , Salary=1000 },
            //    new Employee(){Id=2 , Name="Ali" , Age=20, Salary=1000},
            //    new Employee(){Id=3 , Name="Salma", Age=20 , Salary=1000},
            //};

            //var secquenceToDictionary = ListOfemployees.ToDictionary(elementKey => elementKey.Id);

            //foreach(var kvp in secquenceToDictionary)
            //{
            //    Console.Write($" {kvp} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //var secquenceToDictionary2 = ListOfemployees.ToDictionary(
            //                                                            elementKey => elementKey.Id,
            //                                                            elementKey => elementKey.Name
            //                                                            );
            //foreach (var kvp in secquenceToDictionary2)
            //{
            //    Console.Write($" {kvp} ");
            //}

            #endregion

            #region ToLookUp => Dictionary Allows Duplicate Keys

            ////ToLookup() → Convert to ILookup<TKey, TValue>(Grouped Dictionary)
            ////Converts an IEnumerable<T> into a lookup table(ILookup<TKey, TValue>).
            ////📌 Signature:
            ////ILookup<TKey, TSource> ToLookup<TSource, TKey>(Func<TSource, TKey> keySelector)
            ////ILookup<TKey, TValue> ToLookup<TSource, TKey, TValue>(
            ////    Func<TSource, TKey> keySelector,
            ////    Func<TSource, TValue> elementSelector
            ////)
            ////🚀 Why use it?
            ////Allows duplicate keys(unlike Dictionary< TKey, TValue >).
            ////Efficient grouped retrieval(lookup[key] returns multiple values).
            ////Great for grouping data dynamically.

            //var ListOfemployees = new List<Employee>()
            //{
            //    new Employee(){Id=1 , Name="Ahmed" , Age=20 , Salary=1000 },
            //    new Employee(){Id=1 , Name="Ali" , Age=20, Salary=1000},
            //    new Employee(){Id=1 , Name="Magdy" , Age=20, Salary=1000},
            //    new Employee(){Id=3 , Name="Salma", Age=20 , Salary=1000},
            //};

            //var secquenceToLookUp = ListOfemployees.ToLookup(elementKey => elementKey.Id);

            //foreach (var item in secquenceToLookUp[1])
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //var secquenceToLookUp2 = ListOfemployees.ToLookup(
            //                                                            elementKey => elementKey.Id,
            //                                                            elementKey => elementKey.Name
            //                                                            );
            //foreach (var item in secquenceToLookUp2[1])
            //{
            //    Console.Write($" {item} ");
            //}

            #endregion
            #endregion
        }
    }

    class Employee 
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary {  get; set; }


        public int GetHashCode([DisallowNull] Employee obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
           => $"Emp Name: {Name} :: Age {Age}";

    }
    class EmployeeComparer : Employee ,  IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return ((x?.Id == y?.Id) &&
                  (x?.DepartmentId == y?.DepartmentId) &&
                  (x?.Name == y?.Name) &&
                  (x?.Age == y?.Age) &&
                  (x?.Salary == y?.Salary));
        }
    }
    class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
}