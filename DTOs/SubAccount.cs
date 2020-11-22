using System;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class SubAccount
    {
        public string id { get; set; }

        public bool is_root { get; set; }

        public string name { get; set; }

        public bool not_current { get; set; }

        public bool sub_accounts_exist { get; set; }

        public object tac_custom_body_markup { get; set; }

        public string tac_type { get; set; }

        public DateTime tac_updated_at { get; set; }
    }
}
