using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using siad_app.Models;

namespace siad_app.Services
{
    public class ApiService : IApiService
    {

        public ApiService()
        {
        }

        const string UriApi = "http://5c6c94d5d51de300146f5bdf.mockapi.io/api/v1/tutores";

        public async Task<List<TutoresModel>> GetTutores(string filter)
        {
            try
            {
                Debug.WriteLine("===========/filter/==========" + filter + "=============end");
                var queryString = string.Empty;
                if (!string.IsNullOrEmpty(filter))
                {
                    //queryString += $"?name={System.Net.WebUtility.UrlEncode(filter)}";
                    queryString += $"?filter={WebUtility.UrlEncode(filter)}";


                }
                var result = await this.MakeHttpCall<List<TutoresModel>>(queryString);



                return result;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("===========/ex.Message/==========" + ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// Makes the http call. //este es reutilizable para cualquier api
        /// </summary>
        /// <returns>The http call.</returns>
        /// <param name="filter">Filter.</param>
        /// <typeparam name="TOutput">The 1st type parameter.</typeparam>
        private async Task<TOutput> MakeHttpCall<TOutput>(string filter)
        {
            string url = $"{UriApi}{filter}";

            var client = new HttpClient()
            {
                Timeout = TimeSpan.FromMinutes(1)
            };

            HttpResponseMessage response = new HttpResponseMessage();
            try
            {

                response = await client.GetAsync(url);

                string responseText = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<TOutput>(responseText);
                }
                else
                {
                    throw new Exception(string.Format("Response Statuscode for {0}: {1}", url, response.StatusCode));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("===========//==========" + ex.Message);
                throw ex;
            }
        }
    }

}
