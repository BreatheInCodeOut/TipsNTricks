//C#: Discards
string strDate = "2021/19/19";

/* Usual way -- Declaration of DateTime dtOutput
if (!DateTime.TryParse(strDate, out DateTime dtOutput))
{
    Console.WriteLine("Invalid Start Date");
}
*/

//Alternate approach
//Remove un-necessary variable declarations
//Use Discards _ as they are temporary dummy variables which are read-only
if (!DateTime.TryParse(strDate, out _))
{
    Console.WriteLine("Invalid Start Date");
}