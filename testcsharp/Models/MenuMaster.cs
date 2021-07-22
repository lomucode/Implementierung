using System;
using System.Collections.Generic;

#nullable disable

namespace testcsharp.models
{
    public partial class MenuMaster
    {
        public int MenuIdentity { get; set; }
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string ParentMenuId { get; set; }
        public string UserRoll { get; set; }
        public string MenuFileName { get; set; }
        public string MenuUrl { get; set; }
        public string UseYn { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
