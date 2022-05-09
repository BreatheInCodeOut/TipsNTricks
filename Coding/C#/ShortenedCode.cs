// See https://aka.ms/new-console-template for more information
string strDeptName = null;
string? deptName = null;
string strDefault = "Not assigned";

/* 
if (deptName != null)
{
    strDeptName = deptName;
}
else
{
    strDeptName = strDefault;
}*/

//Ternary if  instead of regular if else
strDeptName = (deptName != null ? deptName : strDefault);
//Can be further shortened  by Nul Coalescing operator (??)
strDeptName = deptName ?? strDefault;

//Value assignment if null
/*if (strDeptName == null)
{
    strDeptName = strDefault;
}*/

//Use Null coalescing assignment operator (??=)
strDeptName ??= strDefault;
Console.WriteLine(strDeptName);

