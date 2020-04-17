using System;
using System.Collections.Generic;
using System.Text;

    namespace project.Models
    {
        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class Welcome
        {
            [JsonProperty("html_attributions")]
            public object[] HtmlAttributions { get; set; }

            [JsonProperty("results")]
            public Result[] Results { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
    }

        public partial class Result
        {
            [JsonProperty("geometry")]
            public Geometry Geometry { get; set; }

            [JsonProperty("icon")]
            public Uri Icon { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("opening_hours", NullValueHandling = NullValueHandling.Ignore)]
            public OpeningHours OpeningHours { get; set; }

            [JsonProperty("photos")]
            public Photo[] Photos { get; set; }

            [JsonProperty("place_id")]
            public string PlaceId { get; set; }

            [JsonProperty("reference")]
            public string Reference { get; set; }

            [JsonProperty("types")]
            public string[] Types { get; set; }

            [JsonProperty("vicinity")]
            public string Vicinity { get; set; }
        }

        public partial class Geometry
        {
            [JsonProperty("location")]
            public Location Location { get; set; }
        }

        public partial class Location
        {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lng")]
            public double Lng { get; set; }
        }

        public partial class OpeningHours
        {
            [JsonProperty("open_now")]
            public bool OpenNow { get; set; }
        }

        public partial class Photo
        {
            [JsonProperty("height")]
            public long Height { get; set; }

            [JsonProperty("html_attributions")]
            public object[] HtmlAttributions { get; set; }

            [JsonProperty("photo_reference")]
            public string PhotoReference { get; set; }

            [JsonProperty("width")]
            public long Width { get; set; }
        }


        public partial class Welcome
        {
            public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, project.Models.Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, project.Models.Converter.Settings);
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

