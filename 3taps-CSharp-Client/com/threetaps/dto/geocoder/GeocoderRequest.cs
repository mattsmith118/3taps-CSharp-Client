﻿using System;

namespace com.threetaps.dto.geocoder
{
    public class GeocoderRequest
    {
        private float latitude { get; set; }
        private float longitude { get; set; }
        private string country { get; set; }
        private string state { get; set; }
        private string city { get; set; }
        private string locality { get; set; }
        private string postal { get; set; }
        private string text { get; set; }

    }
}
