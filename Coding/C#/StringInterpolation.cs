//C#: String Interpolation
var derivedInfo = GetDerivedDetails(10);
//Usual way
Console.WriteLine("Age: {0} Experience: (1}", derivedInfo.Age, derivedInfo.ProfessionalExperience); 
//Shortened version
Console.WriteLine($"Age: {derivedInfo.Age} Experience: {derivedInfo.ProfessionalExperience}");
Console.WriteLine($"Gratuity:{(derivedInfo.ProfessionalExperience > 5 ? "Allowed":"N/A")}");