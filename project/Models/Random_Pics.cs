namespace Rand.Model
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

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