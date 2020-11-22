using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class Permission
    {
        public List<object> actions { get; set; }

        public string id { get; set; }

        public string type { get; set; }
    }
}
