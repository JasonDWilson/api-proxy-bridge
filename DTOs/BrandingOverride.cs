using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class BrandingOverride
    {
        public bool color_enabled { get; set; }

        public string font { get; set; }

        public Header header { get; set; }

        public bool maintain_branding_in_sub_account { get; set; }

        public string navigation_color { get; set; }

        public string primary_color { get; set; }

        public int primary_logo_height { get; set; }

        public string primary_logo_url { get; set; }

        public int primary_logo_width { get; set; }

        public int reverse_logo_height { get; set; }

        public string reverse_logo_url { get; set; }

        public int reverse_logo_width { get; set; }

        public Signin signin { get; set; }

        public DateTime updated_at { get; set; }
    }
}
