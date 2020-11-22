using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class User
    {
        public object anonymized { get; set; }

        public string avatar_url { get; set; }

        public object bio { get; set; }

        public bool deleted { get; set; }

        public object deleted_at { get; set; }

        public string department { get; set; }

        public string email { get; set; }

        public string first_name { get; set; }

        public string full_name { get; set; }

        public string hire_date { get; set; }

        public string hris_id { get; set; }

        public string id { get; set; }

        public bool is_manager { get; set; }

        public string job_title { get; set; }

        public string last_name { get; set; }

        public Links links { get; set; }

        public string locale { get; set; }

        public DateTime? loggedInAt { get; set; }

        public Meta meta { get; set; }

        public string name { get; set; }

        public bool passwordIsSet { get; set; }

        public List<string> roles { get; set; }

        public string sortable_name { get; set; }

        public string type { get; set; }

        public string uid { get; set; }

        public object unsubscribed { get; set; }

        public DateTime? updated_at { get; set; }

        public DateTime? welcomedAt { get; set; }
    }
}
