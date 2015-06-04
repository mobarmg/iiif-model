﻿using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class XVideo : XCanvas
    {
        [JsonProperty(Order = 35, PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(Order = 36, PropertyName = "width")]
        public int Width { get; set; }

        public override string Type
        {
            get { return "ixif:Video"; }
        }
    }
}
