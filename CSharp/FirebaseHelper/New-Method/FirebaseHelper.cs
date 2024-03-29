public class FirebaseHelper
{
    const string auth = "~Firebase Secret~";
    public static FirebaseClient firebase = new FirebaseClient("https://~Your Firebase Url~.firebaseio.com/",
        new FirebaseOptions
        {
            AuthTokenAsyncFactory = () => Task.FromResult(auth)
        });
    public static string mainChild = "mainChild";
    public FirebaseHelper()
    {
    }
    public async Task<Veriler> GetData(string name)
    {
        try
        {
            var AllData = await firebase
             .Child(mainChild)
             .OnceAsync<Veriler>();
            var list = AllData.Select(item => new Veriler
            {
                Name = item.Object.Name,
                testData = item.Object.testData
            }).ToList();
            return new Veriler
            {
                Name = list[0].Name,
                testData = list[0].testData
            };
        }
        catch
        {
            return null;
        }
    }

    public async void UpdateData(string name, string test)
    {
        try
        {
            await firebase
                .Child(mainChild)
                .Child(name)
                .PutAsync(new Veriler() { Name = name, testData = test });
        }
        catch (Exception) { }
    }
    public async Task AddData(string name)
    {
        await firebase
            .Child(mainChild)
            .Child(name)
            .PutAsync(new Veriler() { Name = name, testData = "0" });
    }
    public async Task DeleteData(string name)
    {
        try
        {
            await firebase
            .Child(mainChild)
                .Child(name)
                .DeleteAsync();
        }
        catch { }
    }
}
    
public class Veriler //Firebase Data
{
    public string testData { get; set; }
    public string Name { get; set; }
}
