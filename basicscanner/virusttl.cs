using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using System;


class visvol
{
    static void beginVirus(string[] args)
    {
        string apiKey = "YOUR_API_KEY";
        var client = new RestClient("https://www.virustotal.com/api/v3/files/id");
        var request = new RestRequest("{file_id}", Method.Get);
        request.AddHeader("x-apikey", apiKey);
        request.AddHeader("accept", "application/json");

        request.AddUrlSegment("file_id", "file_id_placeholder");

        var response = client.Execute(request);

        if (response.IsSuccessful)
        {
            
            dynamic result = JsonConvert.DeserializeObject<dynamic>(response.Content);

            Console.WriteLine(result);
        }
        else{
            Console.WriteLine("Error: {0}", response.StatusCode);
            Console.WriteLine(response.ErrorMessage);
        }

    }
}