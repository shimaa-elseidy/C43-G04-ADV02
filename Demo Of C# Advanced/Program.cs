namespace Demo_Of_C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is DS
            // Collection     :: built in DS In c#
            // Array          :: container has data
            // Data Structure :: has array based & node based
            // array based    :: like array every element has index  ====> Linear DS
            // node based     :: value itself & next elemnt (Address)===> Non-Linear DS || Linear DS
            // Hash Tables    :: DS of type Array Based el elemnt has [Key - Value] ==> key unique
            // Hash Tables    :: help us to deal with big amount of data and complex
            #endregion
            #region What is collection
            // Collections in C# in two categories[Generic - Non Generic]
            // 1. lists
            // 2. Hash Tables [key - value]
            // Lists :: Generic - Non-Generic
            // Non generic lists :: such [ array list - stack - queue ]
            // Generic Lists     :: such [ list - linked list - stack - queue]

            // Hash Tables :: Generic - Non-Generic
            // Non generic hashtables :: such [ Hash Table ]
            // Generic hashtables     :: such [ Dictionary - sorted dictionary - hash set +....]
            #endregion
            #region Non-Generic Lists [Array List]
            // Array list like ==> Array
            // Array based     ==> index
            // Array      :: Indexed collection ==> fixed size
            // Array List :: Indexed collection ==> dynamic size

            // index : 0 1 2 3 4 5
            // items : 1 2 3 4 5 6
            // size  : 6
            // arr[1]==> 2

            //int[] nums = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(nums[1]);
            //nums[1] = 12;
            //Console.WriteLine(nums[1]);

            //ArrayList list = new ArrayList();
            //Console.WriteLine(list.Count); // 0 as it empty
            //Console.WriteLine(list.Capacity); // 0 // el zone elly hagzahah ll array list
            //list.Add(1);

            //Console.WriteLine(list.Count); // === 1
            //Console.WriteLine(list.Capacity); // 4 byte



            //ArrayList  arrayList = new ArrayList(new int[] {1,3,7,9,4,5,0});
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 7 , 7 el capacity kman 7 b size elly ana b3to
            //arrayList.Add(1);
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 8 , 14

            //ArrayList arrayList = new ArrayList(6);// 6 refere to capacity
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 0 , 6
            //arrayList.Add(3);
            //arrayList.Add(8);
            //arrayList.Add(0);
            //arrayList.Add(38);
            //arrayList.Add(2);
            //arrayList.Add(30);
            //arrayList.Add(33);
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}");   // 7 , 12


            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 1 , 4 
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(5);
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 4 , 4 
            //arrayList.Add(6);
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 5 , 8
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(5);
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 8 ,8
            //arrayList.Add(3);
            //arrayList.Add(5);
            //arrayList.Add(8);
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 11 , 16 


            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine(arrayList.IsFixedSize);// FALSE
            //Console.WriteLine(arrayList.IsReadOnly);// FALSE
            //arrayList.Add(3);
            //arrayList.Add(5);
            //arrayList.Add(8);
            //Console.WriteLine(arrayList[2]); // 8
            //arrayList[2] = 12;
            //Console.WriteLine(arrayList[2]); // 12



            //ArrayList arrayList = new ArrayList();
            //arrayList.AddRange(new[] {10,3,7,9,0} );
            //PrintArray(arrayList); // 10 3 7 9 0


            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(3);
            //arrayList.Add(5);
            //arrayList.Add(8);
            //// bb3tlha value btsearch 3aleha
            //Console.WriteLine(arrayList.BinarySearch(8)); // btreturn el index


            //Employee Emp01 = new Employee() { Id = 0, Name = "shimaa", Age = 24, Salary = 50000 } ;
            //Employee Emp02 = new Employee() { Id = 1, Name = "ayla", Age = 20, Salary = 10000 };
            //Employee Emp03 = new Employee() { Id = 2, Name = "mbfdr", Age = 27, Salary = 20000 };
            //Employee Emp04 = new Employee() { Id = 3, Name = "amoi", Age = 26, Salary = 30000 };
            //Employee Emp05 = new Employee() { Id = 4, Name = "mory", Age = 29, Salary = 40000 };

            //ArrayList arrayList = new ArrayList();
            //arrayList.AddRange(new Employee[] { Emp01 , Emp02 , Emp03, Emp04, Emp05});
            //foreach (Employee item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arrayList.BinarySearch(Emp03));//2
            // int index = arrayList.BinarySearch(Emp03);
            //Console.WriteLine(index);//2
            //int index= arrayList.BinarySearch(Emp03,new EmployeeCompareName());
            //Console.WriteLine(index);//2

            //Console.WriteLine(arrayList.BinarySearch("mory"));// Error

            //int indexName = arrayList.BinarySearch(new Employee() {Name= "mory" },new EmployeeCompareName());
            //Console.WriteLine(indexName);
            //int index = arrayList.BinarySearch(0, 3 , new Employee() { Name="mory"},null);
            //Console.WriteLine(index); // -1 default
            // within using comperer ==> EmployeeCompareName()
            //int index = arrayList.BinarySearch(0, 3, new Employee() { Name = "ayla" }, new EmployeeCompareName());
            //Console.WriteLine(index); // 1




            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 3 , 4
            //Console.WriteLine(arrayList[0]); // 1
            //arrayList.Clear();
            //Console.WriteLine(arrayList[0]); // out of range 34an el array empty

            //Console.WriteLine(arrayList.Contains(1));// true
            //int[] arr = new int[4];
            //arrayList.CopyTo(arr);
            //Console.WriteLine(arr[1]); // 2


            //int[] arr = new int[10];
            //arrayList.CopyTo(arr,3);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item); /*0
            //0
            //0
            //1
            //2
            //                               3
            //                               0
            //                               0
            //                               0
            //                               0
            //                              */
            //}// elly 2blha b zero welly b3dha b zero
            //Console.WriteLine(arr[2]); // 2


            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);   
            //arrayList.Add(5);   
            //arrayList.Add(1);   
            //arrayList.Add(8);
            //arrayList.Add(9);
            //arrayList.Add(10);
            //ArrayList array = arrayList.GetRange(0, 2);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item); // 1 2
            //}
            // Console.WriteLine(arrayList.IndexOf(1)); // 0  ==> return the first index of 1 hata law mtkrara hata5od el 2ola

            // Console.WriteLine(arrayList.IndexOf(1,2)); // 5 ==> mn 2 search 3la el 1

            // Console.WriteLine(arrayList.IndexOf(1, 2,5)); // 5 ==> mn 2 l 5 search 3la el 1 

            //arrayList.Insert(0, 100); // fe index 0 insert 100
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.InsertRange(0, new int[] { 2, 7, 0, 4, 7 });
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //int i = arrayList.LastIndexOf(1); // 5
            //Console.WriteLine(i);

            // arrayList.Remove(1) // remove the first 1 in array
            // arrayList.RemoveAt(0); // remove el value elly fe index 0
            // arrayList.RemoveRange(0, 3); // mn 0 e3ml delete l 3 items
            // arrayList.SetRange(0, new int[] { 10, 80, 90, 900 }); // set items ==> by3ml override 3la 4 elemnt fe original array
            // arrayList.Sort(); // to sort array
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 9 , 16 
            // arrayList.TrimToSize(); // capacity ==> bt3ml release l'l un used items
            //Console.WriteLine($"Count: {arrayList.Count} , Capacity: {arrayList.Capacity}"); // 9 , 9
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Problems with Non Generic List
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //int sum01 = SumArrayList(list);
            //Console.WriteLine(sum01); // 15

            //list.Add("Hello");
            //list.Add(new Employee());
            //list.Add(2.7);
            //int sum02 = SumArrayList(list);
            //Console.WriteLine(sum02); // InvalidCastException // b3d ama 3mlt condition list[i] is int el result ===> 15
            #endregion
            #region Generic Lists
            // Generic Lists :: List
            // List Version Generic Of Array List
            // List :: Like Array List Like Array But Generic  ===> Dynamic Size
            // List<int> list = new List<int>(new int[] {1,2,3,4,5,6,7,8,9,10});
            // list.Add("shimaa");// ERRORRRRR
            // PrintList(list);

            //int sum = SumArrayList(list);
            //Console.WriteLine(sum); // 55
            //list.AddRange(new List<int> { 1, 2, 3, 5, 6, 7, 8, 9 });
            //PrintList(list);

            //===========================
            //Employee Emp01 = new Employee() { Id = 0, Name = "shimaa", Age = 24, Salary = 50000 };
            //Employee Emp02 = new Employee() { Id = 1, Name = "ayla", Age = 20, Salary = 10000 };
            //Employee Emp03 = new Employee() { Id = 2, Name = "mbfdr", Age = 27, Salary = 20000 };
            //Employee Emp04 = new Employee() { Id = 3, Name = "amoi", Age = 26, Salary = 30000 };
            //Employee Emp05 = new Employee() { Id = 4, Name = "mory", Age = 29, Salary = 40000 };

            //List<Employee> employees = new List<Employee> { Emp01, Emp02, Emp03, Emp04, Emp05 };
            //Console.WriteLine(employees[1]);

            //Console.WriteLine(employees.BinarySearch(Emp05));// 4
            //Console.WriteLine(employees.BinarySearch(Emp01,new EmployeeCompareNameGeneric()));


            //Console.WriteLine($"Count: {list.Count} , Capacity: {list.Capacity}");// 10 ,10
            //Console.WriteLine(list.EnsureCapacity(20));// 20
            //Console.WriteLine($"Count: {list.Count} , Capacity: {list.Capacity}"); // 10 ,20

            //List<Employee> employees1 =  employees.Slice(0,2 ); // Create a shallow copy
            //PrintList( employees1 );

            //List<Employee> employees01 = employees.GetRange(0, 2);
            //PrintList(employees01);
            #endregion
        }
    }
}
