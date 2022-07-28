Token = "~Token~";         

RestClient client = new RestClient("~URL~");
RestRequest request = new RestRequest();
request.AddHeader("Authorization", Token);
request.AddHeader("Content-Type", "application/json");
var resCariGrup = await client.ExecuteAsync(request, Method.Post);
var dataCariGrup = JsonConvert.DeserializeObject<~ROOTCLASS~>(resCariGrup.Content);
