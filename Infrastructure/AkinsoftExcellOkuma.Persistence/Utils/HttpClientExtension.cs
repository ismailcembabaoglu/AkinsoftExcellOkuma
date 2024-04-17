﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Persistence.Utils
{
    public static class HttpClientExtension
    {
        public async static Task<T> GetServiceResponseAsync<T>(this HttpClient Client, String Url, bool ThrowSuccessException = false)
        {
            var httpRes = await Client.GetFromJsonAsync<T>(Url);


            return httpRes;
        }
    }
}
