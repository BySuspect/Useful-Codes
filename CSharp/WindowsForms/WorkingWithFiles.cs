string Path = "C:\\TestFolder";
string FileName = "\\test.txt";

void WriteDataToFile(string _data)
{
    //Writing data to file.
    using (StreamWriter file = new StreamWriter(Path + FileName, true))
    {
        file.WriteLine(_data);
    }
}

private void CheckFile()
{
    // Checking folder returns true or false.
    if (!Directory.Exists(Path))
    {
        Directory.CreateDirectory(Path);
    }//Creaing Folder
    // Checking file returns true or false.
    if (!File.Exists(Path + FileName))
    {
        using (File.Create(Path + FileName))
        { }// Creating file.
    }
}

async Task<List<string>> ReadFile()
{
    //returning file lines to list
    return (File.ReadAllLines(Path + FileName)).ToList<string>();
}
