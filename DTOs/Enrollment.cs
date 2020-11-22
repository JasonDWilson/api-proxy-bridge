using System;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class Enrollment
    {
        public bool active { get; set; }

        public bool allow_re_enroll { get; set; }

        public bool can_be_made_optional { get; set; }

        public bool can_be_removed { get; set; }

        public DateTime? completed_at { get; set; }

        public string course_template { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? end_at { get; set; }

        public object expires_at { get; set; }

        public string id { get; set; }

        public bool is_archived { get; set; }

        public bool is_permanently_failed { get; set; }

        public Links links { get; set; }

        public double progress { get; set; }

        public bool required { get; set; }

        public int score { get; set; }

        public string state { get; set; }

        public DateTime updated_at { get; set; }
    }
}
