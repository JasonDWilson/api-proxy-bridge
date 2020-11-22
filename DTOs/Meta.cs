using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class Meta
    {
        public int archived_count { get; set; }
        public bool can_masquerade { get; set; }
        public string next { get; set; }
        public List<Permission> permissions { get; set; }
        public int unarchived_count { get; set; }
    }
}
