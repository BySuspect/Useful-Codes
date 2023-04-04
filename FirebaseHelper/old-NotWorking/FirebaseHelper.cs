public class Firebase
{
    FirebaseClient firebase = new FirebaseClient("url",
        new FirebaseOptions
        {
            AuthTokenAsyncFactory = () => Task.FromResult("secret")
        });
    private string ChildName = "Child";
    public Firebase(){}

    public async Task<List<Veriler>> GetAllPersons()
    {
        return (await firebase
            .Child(ChildName)
            .OnceAsync<Veriler>()).Select(item => new Veriler
            {
                Name = item.Object.Name,
                testData = item.Object.testData
            }).ToList();
    }
    public async Task<Veriler> GetPerson(string name)
    {
        var allPersons = await GetAllPersons();
        await firebase
            .Child(ChildName)
            .OnceAsync<Veriler>();
        return allPersons.FirstOrDefault(a => a.Name == name);
    }
    public async void Update(string name, string test)
    {
        try
        {
            var toUpdatePerson = (await firebase
                       .Child(ChildName)
                       .OnceAsync<Veriler>()).FirstOrDefault(a => a.Object.Name == name);
            await firebase
                .Child(ChildName)
                .Child(toUpdatePerson.Key)
                .PutAsync(new Veriler() { Name = toUpdatePerson.Object.Name, testData = test });
        }
        catch (Exception) { }
    }
    public async Task AddPerson(string name)
    {
        await firebase
            .Child(ChildName)
            .PutAsync(new Veriler() { Name = name, testData = "0" });
    }
    public async Task DeletePerson(string name)
    {
        try
        {
            var toDeletePerson = (await firebase
                .Child(ChildName)
                .OnceAsync<Veriler>()).FirstOrDefault(a => a.Object.Name == name);
            await firebase
                .Child(ChildName)
                .Child(toDeletePerson.Key).DeleteAsync();
        }
        catch { }
    }
}
    
public class Veriler
{
    public string testData { get; set; }
    public string Name { get; set; }
}
