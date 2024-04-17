namespace AkinsoftExcellOkuma.Server.Utils
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
