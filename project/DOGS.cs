using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public partial class Dog
    {
        [JsonProperty("message")]
        public Uri Message { get; set; }
    }
}
