using System;
using static Tensorflow.Binding;
using static Tensorflow.KerasApi;
using Tensorflow;
using Tensorflow.NumPy;
using Tensorflow.Keras.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace flag_finder_service
{
    public class FlagData
    {
        required public string FlagURL { get; init; }
        required public string Code { get; init; }
        required public string Name { get; init; }
        required public string CountryCode { get; init; }

        FlagData(string flag_url, string code, string country_code, string name)
        {
            Code = code;
            CountryCode = country_code;
            FlagURL = flag_url;
            Name = name;

        }
    }
    
    class Program
    {
        static readonly string file_name = "flag_data.json";
        static readonly string api_endpoint = "https://iso3166-2-api.vercel.app/api/all";
        static string data_dir = Path.Combine(Path.GetTempPath(), "flag_data");

        static public void LoadFlagJson()
        {
            using (StreamReader r = new StreamReader(data_dir))
            {
                string json = r.ReadToEnd();
                JObject items = JObject.Parse(json);
                IList<JToken> results = items.Children().ToList();
                IList<CountryData> countryDatas = new List<CountryData>();
                foreach (JToken result in results)
                {
                    // JToken.ToObject is a helper method that uses JsonSerializer internally
                    Console.WriteLine("test");
                    
                    // string country_code = result["Name"];
                    // CountryData data = new CountryData(result)
                }
        }
        }

        static private void PrepareData()
        {

            Web.Download(api_endpoint, data_dir, file_name);

            data_dir = Path.Combine(data_dir, "flag_data.json");
            LoadFlagJson();

            // keras.preprocessing.image_dataset_from_directory


        }

        static void Main(string[] args)
        {
            PrepareData();


        }

    }
}