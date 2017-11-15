using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.EFCore.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        public DateTime EnrollmentDate { get; internal set; }

        public int StudentCount { get; internal set; }
    }
}
