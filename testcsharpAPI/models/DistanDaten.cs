using System;
using System.Collections.Generic;

#nullable disable

namespace testcsharpAPI.models
{
    public class DistanDaten
    {
        public int Id { get; set; }
        public double? Distanz { get; set; }
        public string DistanzArt { get; set; }
        public int? Aktivitätsdauer { get; set; }
        public double? DistanzManuellAnpassen { get; set; }
        public string UserId { get; set; }
        public DateTime? DistanDatenDatum { get; set; }
    }
}
