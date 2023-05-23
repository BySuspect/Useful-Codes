Token = "~Token~";         

RestClient client = new RestClient("~URL~");
RestRequest request = new RestRequest();
request.AddHeader("Authorization", Token);
request.AddHeader("Content-Type", "application/json");
var res = await client.ExecuteAsync(request, Method.Post);
var data = JsonConvert.DeserializeObject<~ROOTCLASS~>(res.Content);
