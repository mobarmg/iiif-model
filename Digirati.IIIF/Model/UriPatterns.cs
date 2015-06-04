﻿using System.Globalization;

namespace Digirati.IIIF.Model
{
    public static class UriPatterns
    {
        public const string IIIF2Context = "http://iiif.io/api/presentation/2/context.json";

        // recommended patterns
        public const string Collection = "{scheme}://{host}/{prefix}/collection/{name}";
        public const string Manifest = "{scheme}://{host}/{prefix}/{identifier}/manifest";
        public const string Sequence = "{scheme}://{host}/{prefix}/{identifier}/sequence/{name}";
        public const string Canvas = "{scheme}://{host}/{prefix}/{identifier}/canvas/{name}";
        public const string Annotation = "{scheme}://{host}/{prefix}/{identifier}/annotation/{name}";
        public const string AnnotationList = "{scheme}://{host}/{prefix}/{identifier}/list/{name}";
        public const string Range = "{scheme}://{host}/{prefix}/{identifier}/range/{name}";
        public const string Layer = "{scheme}://{host}/{prefix}/{identifier}/layer/{name}";
        public const string Content = "{scheme}://{host}/{prefix}/{identifier}/res/{name}.{format}";

        // Image service URI
        public const string ImageResource = "{scheme}://{host}/{prefix}/{identifier}-{seqIndex}/res/{name}";

        // Our extensions ss IIIF:                        {scheme}://{host}{/prefix}/{___________identifier___________}/{region}/{size}/{rotation}/{quality}.{format}
        public const string ImageService = "{scheme}://{host}/{prefix}-img/{identifier}-{seqIndex}/{name}";
        public const string ImageAnnotation = "{scheme}://{host}/{prefix}/{identifier}/imageanno/{name}";
        public const string OcrAltoContent = "{scheme}://{host}/{prefix}/{identifier}/contentAsText/{name}";

        // X extensions:
        public const string XAnnotation = "{scheme}://{host}/{prefix}/{identifier}/xanno/{name}";

        public const string ImageServiceProfile = "http://iiif.io/api/image/2/level1.json";

        // Transition
        public const string WellcomeThumbs = "{scheme}://{host}";


        public static string WithIdentifier(this string s, string identifier)
        {
            return s.Replace("{identifier}", identifier);
        }

        public static string WithName(this string s, string name)
        {
            return s.Replace("{name}", name);
        }

        public static string WithNumericalName(this string s, string prefix, int index)
        {
            return s.Replace("{name}", prefix + index);
        }

        public static string WithSequenceIndex(this string s, int index)
        {
            return s.Replace("{seqIndex}", index.ToString(CultureInfo.InvariantCulture));
        }

        public static MetaDataValue AsMetaDataValue(this string s)
        {
            return new MetaDataValue(s);
        }
    }
}