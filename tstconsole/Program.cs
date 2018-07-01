using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace tstconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getfltnumber("5").ToString());
            Console.ReadKey();
        }

        static int getfltnumber(string flt_number)
        {
            string TARGETURL = "https://agfaviobookpusher.azurewebsites.net/Api/Flights/" + flt_number;
            int i2r = 0;
            string result = "";
            try
            {
                HttpClientHandler handler = new HttpClientHandler { Credentials = new NetworkCredential("userName", "Password") };

                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    var url = TARGETURL;
                    var response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;
                        //Console.WriteLine(responseContent.Headers.ContentLanguage);
                        result = responseContent.ReadAsStringAsync().Result;

                        XmlNode myXmlNode = JsonConvert.DeserializeXmlNode(result, "Rootobject");
                        result = NodeToString(myXmlNode, 2);
                        //Console.WriteLine(result);
                    }
                }
            }
            catch (Exception e)
            {
                i2r = -1;
                Console.WriteLine(e.Message);
            }
            i2r = getintfromjson(result, true);
            return i2r;
        }

        static string NodeToString(XmlNode node, int indentation)
        {
            try
            {
                using (var sw = new System.IO.StringWriter())
                {
                    using (var xw = new System.Xml.XmlTextWriter(sw))
                    {
                        xw.Formatting = System.Xml.Formatting.Indented;
                        xw.Indentation = indentation;
                        node.WriteContentTo(xw);
                    }
                    return sw.ToString();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return "Convert to XML error";
            }
        }

        static int getintfromjson(string result, bool isxml)
        {
            int i2r = 0;

            try
            {
                if (isxml)
                {
                    //var xmldoc = new XmlDocument();
                    //xmldoc.LoadXml(result);
                    //json = JsonConvert.SerializeXmlNode(xmldoc);
                    i2r = getintfromxml(result);
                }
                else
                {
                    string json = "";
                    Rootobject obj = JsonConvert.DeserializeObject<Rootobject>(json);
                    i2r = obj.Flight;
                }
            }
            catch (Exception e)
            {
                i2r = -2;
                Console.WriteLine(e.Message);
            }

            return i2r;
        }

        static int getintfromxml(string result)
        {
            int i2r = 0;
            try
            {
                using (TextReader sr = new StringReader(result))
                {
                    var serializer = new XmlSerializer(typeof(Rootobject));
                    Rootobject xml = (Rootobject)serializer.Deserialize(sr);
                    i2r = xml.Flight;
                }
            }
            catch (Exception e)
            {
                i2r = -3;
                Console.WriteLine(e.Message);
            }

            return i2r;
        }
    }
}
