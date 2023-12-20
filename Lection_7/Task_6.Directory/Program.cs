// получить информацию о директории
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " "); // " " позволяет нам сделать отступ, чтобы лучше увидеть структуру директории
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"\Users\Елена\Desktop\Geekbrains\Знакомство с ЯП. C#\Lectures\Lection_1";
CatalogInfo(path);