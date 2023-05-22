List<string> languages = new List<string> { "C#", "Java", "C++" };
Console.WriteLine("Selecciona un lenguaje:");
for (int i = 0; i < languages.Count; i++)
{
    Console.WriteLine("{0}. {1}", i + 1, languages[i]);
}

string input = Console.ReadLine();
string selectedLanguage;
switch (input)
{
    case "1":
    case "a":
        selectedLanguage = languages[0];
        break;
    case "2":
    case "b":
        selectedLanguage = languages[1];
        break;
    case "3":
    case "c":
        selectedLanguage = languages[2];
        break;
    default:
        selectedLanguage = "Invalid selection";
        break;
}
Console.WriteLine("Lenguaje Seleccionado: {0}", selectedLanguage);