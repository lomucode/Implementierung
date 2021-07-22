using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testcsharp.ViewModel
{
    public partial class Distans
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
