using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryLayer.Models
{
    public partial class Designation
    {
        public Designation()
        {
            Tblemployees = new HashSet<Tblemployee>();
        }

        public int Dcode { get; set; }
        public string Dname { get; set; }

        public virtual ICollection<Tblemployee> Tblemployees { get; set; }
    }
}
