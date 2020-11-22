using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class EnrollmentQueryResult
    {
        public List<Enrollment> enrollments { get; set; }

        public Linked linked { get; set; }

        public Meta meta { get; set; }
    }
}
