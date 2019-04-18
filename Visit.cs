using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationDZ_18._04._2019
{
    public class Visit
    {
        public Guid Id { get; set; }
        public DateTime TimeOfJoin { get; set; }
        public DateTime TimeOfLeave { get; set; }
        public string Name { get; set; }
        public string IDCardNumber { get; set; }
        public string PointOfVisit { get; set; }
        public Visit()
        {
            Id = Guid.NewGuid();
        }
    }
}
