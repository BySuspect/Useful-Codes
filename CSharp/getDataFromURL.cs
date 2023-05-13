///HttpClient With dns server

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("URL");
httpClient.DefaultRequestHeaders.Accept.Clear();
httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));
var response = await httpClient.GetAsync("1.1.1.1"); //Set DNS here
var responseBody = await response.Content.ReadAsStringAsync();


// HttpClient with header

var client = new HttpClient();
client.DefaultRequestHeaders.Add("Authorization", "API key");
var response = await client.GetAsync("URL");
if (response.IsSuccessStatusCode)
{
    var result = await response.Content.ReadAsStringAsync();
    //codes
}
else
{
    Debug.WriteLine("Connect Error!");
}
