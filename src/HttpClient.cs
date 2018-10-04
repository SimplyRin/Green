using System;
using System.IO;
using System.Net;

/**
 * Created by SimplyRin on 2018/10/04.
 */
public class HttpClient {

    public static String rawWithAgent(String url) {
        return rawWithAgent(url, "Mozilla/5.0");
    }
    
    public static String rawWithAgent(String url, String userAgent) {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(url);
        httpWebRequest.UserAgent = userAgent;
        httpWebRequest.Method = "GET";
    
        HttpWebResponse httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse();
    
        Stream stream = httpWebResponse.GetResponseStream();
        StreamReader streamReader = new StreamReader(stream);
    
        return streamReader.ReadToEnd();
    }

}
