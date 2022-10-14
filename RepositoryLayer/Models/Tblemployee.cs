using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryLayer.Models
{
    public partial class Tblemployee
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? Dcode { get; set; }

        public virtual Designation DcodeNavigation { get; set; }
    }
}
