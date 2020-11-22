using System;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class EnrollmentCounts
    {
        public int all { get; set; }

        public int finished { get; set; }

        public int in_progress { get; set; }

        public int incomplete { get; set; }

        public int incomplete_or_finished { get; set; }

        public int not_started { get; set; }

        public int optional { get; set; }

        public int overdue { get; set; }

        public int required { get; set; }
    }
}
