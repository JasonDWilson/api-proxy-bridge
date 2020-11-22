using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class Linked
    {
        public List<CourseTemplate> course_templates { get; set; }
        public List<User> learners { get; set; }
    }
}
