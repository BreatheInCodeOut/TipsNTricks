using System.Globalization;

double value = 1234567890.598;
//Convert to Currency
Console.WriteLine(value.ToString("C2")); // $12345,67,890.60

//Custom specifiers "0" "." "," "#"
Console.WriteLine(value.ToString("0,0.00", CultureInfo.InvariantCulture)); // 12345,67,890.60
Console.WriteLine(value.ToString("(###) ###-####")); // (123) 456-7891

// "%" Custom Specifier
value = .06;
Console.WriteLine(value.ToString("#0.##%")); // 6%, .7856 => 78.56%, .78 => 7.8%

// ";" Section seperator => To format numeric values >0 <0 =0
value = 55;
Console.WriteLine(value.ToString("+##;(##);-")); // +55
value = -5;
Console.WriteLine(value.ToString("+##;(##);-")); // (5)
value = 0;
Console.WriteLine(value.ToString("+##;(##);Zero")); // Zero