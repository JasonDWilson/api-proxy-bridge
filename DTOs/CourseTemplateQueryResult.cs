using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class CourseTemplateQueryResult
    {
        public List<CourseTemplate> course_templates { get; set; }

        public Meta meta { get; set; }
    }
}
