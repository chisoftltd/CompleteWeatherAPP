using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CompleteWeatherAPP.Helper
{
    public class ApiCaller
    {
        public static async Task<ApiReponse> Get(string url, string authId = null)
        {
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrWhiteSpace(authId))
                
                    client.DefaultRequestHeaders.Add("Authorization", authId);

                  var request = await client.GetAsync(url);
                  if (request.IsSuccessStatusCode)
                  {
                      return new ApiReponse { Response = await request.Content.ReadAsStringAsync() };
                  }
                  else
                      return new ApiReponse { ErrorMessage = request.ReasonPhrase };
                
                
            }
        
        }
    }

    public class ApiCaller2
    {
        public static async Task<ApiReponse> Get(string url, string authId = null)
        {
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrWhiteSpace(authId))

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", authId);

                var request = await client.GetAsync(url);
                if (request.IsSuccessStatusCode)
                {
                    return new ApiReponse { Response = await request.Content.ReadAsStringAsync() };
                }
                else
                    return new ApiReponse { ErrorMessage = request.ReasonPhrase };
            }
        }
    }

    public class ApiReponse
    {
        public bool Successful => ErrorMessage == null;
        public string ErrorMessage { get; set; }

        public string Response { get; set; }
    
    }
}
