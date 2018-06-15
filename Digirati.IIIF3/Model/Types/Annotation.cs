﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digirati.IIIF3.Model.JSONLD;
using Newtonsoft.Json;

namespace Digirati.IIIF3.Model.Types
{
    public class Annotation : JSONLDBase
    {

        public List<JSONLDString> Label { get; set; }
        public string Motivation { get; set; }
        public string Target { get; set; }
        public Resource Body { get; set; }
        public override string Type => "Annotation";

    }
}