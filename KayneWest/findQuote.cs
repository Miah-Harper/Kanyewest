using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace KayneWest
{
    public class findQuote
    {
        private  HttpClient _client;

        public findQuote(HttpClient client)
        {
            _client = client;
        }

        public string KanyeWest()
        {
            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result; //gets a request over from the url and returns it into a string
                                                                         //get is reading data from the api

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString(); //getquote requires a property name- property name we are looking for it quote (look at api url)

            return kanyeQuote;
        }

        public string RonSwanson()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = _client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim(); //have to use the jarray since it's a jarray. parsing in the ron response,
                                                                                                            //converting it into a string so then we can take advantage of the replace method.
                                                                                                            //The replace method allows us to remove the jarray brackets and replace it with a space.  
                                                                                                            //then the .trim gets rid of the two spaces we created on each side of our string
                                                                                                            //doesn't need get value since it's a JArray

            return ronQuote;
        }
    }
}

