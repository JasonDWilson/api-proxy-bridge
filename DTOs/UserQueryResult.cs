using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class UserQueryResult
    {
        public Linked linked { get; set; }

        public Meta meta { get; set; }

        public List<User> users { get; set; }
    }
}
