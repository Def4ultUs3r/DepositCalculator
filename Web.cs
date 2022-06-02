using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    internal class Web
    {
        public static string GetWebContent(string UriString)
        {
            string webResponseString;

            // Create a request for the URL.
            WebRequest request = WebRequest.Create(UriString);
            request.Method = WebRequestMethods.Http.Get;
            //request.Credentials = CredentialCache.DefaultCredentials;
            try
            {


                using (WebResponse response = request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader streamRdr = new StreamReader(dataStream);
                        webResponseString = streamRdr.ReadToEnd();
                    }
                };
            }
            catch(Exception e)
            {
                webResponseString = null;
            }
            return webResponseString;
        }
    }
}
