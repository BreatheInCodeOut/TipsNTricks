/* Yield 
 1) It provides custom iteration without creating temp collections
 2) It provides deferred execution solution for each iteration item, which will be useful to traverse through large amount of data/pagination or any
    other scenario where items needs to be processed on a need basis in small numbers instead of processing entire data
*/

public class ClsYield
{
    public IEnumerable<int> GetDetails()
    {
        int val = 0;
        Console.WriteLine("GetDetails 0");
        yield return val;
        
        for (; val < 10; val++)
        {
            if (val % 2 == 0)
            {
                Console.WriteLine("GetDetails" + val);
                yield return val;
            }
        }
        Console.WriteLine("GetDetails 15");
        yield return 15;
        Console.WriteLine("GetDetails 100");
        yield return 100;
    }
}

/*
ClsYield yld = new ClsYield();

foreach (int item in yld.GetDetails())
{
    Console.WriteLine(item);
} 
*/

/* Output:
GetDetails 0
0
GetDetails0
0
GetDetails2
2
GetDetails4
4
GetDetails6
6
GetDetails8
8
GetDetails 15
15
GetDetails 100
100
*/