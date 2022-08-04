        public async Task<Veriler> GetData(string key)
        {
            try
            {
                string auth = "~Your Firebase Secret~";
                string content = string.Empty;
                var httpClient = new HttpClient();
                HttpResponseMessage httpResponse = null;
                httpResponse = await httpClient.GetAsync("~FirebaseUrl~" + Child + "/" + key + "/.json?auth=" + auth);
                if (httpResponse.IsSuccessStatusCode)
                {
                    content = await httpResponse.Content.ReadAsStringAsync();
                }
                else
                {
                    content = await httpResponse.Content.ReadAsStringAsync();
                }
                return JsonConvert.DeserializeObject<Veriler>(content); //Json Converter
            }
            catch
            {
                return null;
            }
        }
        
    public class Veriler //Json Converter Helper
    {
        public string testData { get; set; }
        public string Name { get; set; }
    }
