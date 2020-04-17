namespace Rand.Model
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    /*
     * This page holds my JSON data that was converted to C# using
     * https://app.quicktype.io/#l=cs&r=json2csharp
     * Where the API will generate a URI which will be converted to a string as "message" from random_pic class then sent back to the function 
     * to use in the application.
     * 
     * The api that we used is called Dog API
     * https://dog.ceo/dog-api/
     * 
     */
    public partial class random_pic
    {
        [JsonProperty("message")]
        public Uri Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class random_pic
    {
        public static random_pic FromJson(string json) => JsonConvert.DeserializeObject<random_pic>(json, Rand.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this random_pic self) => JsonConvert.SerializeObject(self, Rand.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}