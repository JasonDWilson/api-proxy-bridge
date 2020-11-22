using Jwpro.Api.Proxy.Bridge.Configuration;
using Jwpro.Api.Proxy.Bridge.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Jwpro.Api.Proxy.Bridge
{
    public class DataManager
    {
        private BridgeApiConfiguration _config;
        private HttpClient _httpClient = new HttpClient();

        public DataManager(BridgeApiConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _config.Key);
        }


        private string get(string url)
        {
            HttpResponseMessage result = _httpClient.GetAsync(url).Result;
            var response = result.Content.ReadAsStringAsync().Result;
            if(result.StatusCode == HttpStatusCode.OK)
                return response;
            throw new Exception($"Failed to Get [{url}]: [{result.StatusCode}]: [{response}]");
        }

        public IEnumerable<CourseTemplate> GetCourseTemplates(int returnLimit = 1000, string titleFilter = null)
        {
            string url = $"{_config.Url}/api/author/course_templates?limit={returnLimit}";
            if(!string.IsNullOrWhiteSpace(titleFilter))
                url = $"{url}&search={titleFilter}";
            string result = get(url);
            var queryResult = JsonConvert.DeserializeObject<CourseTemplateQueryResult>(result);
            if(queryResult != null)
                return queryResult.course_templates;
            return null;
        }

        public IEnumerable<Enrollment> GetEnrollments(string courseTemplateId, int returnLimit = 1000)
        {
            string url = $"{_config.Url}/api/author/course_templates/{courseTemplateId}/enrollments?limit={returnLimit}";
            string result = get(url);
            var queryResult = JsonConvert.DeserializeObject<EnrollmentQueryResult>(result);
            if(queryResult != null)
                return queryResult.enrollments;
            return null;
        }

        public IEnumerable<User> GetUsers(int returnLimit = 1000)
        {
            string url = $"{_config.Url}/api/author/users?limit={returnLimit}";
            string result = get(url);
            var queryResult = JsonConvert.DeserializeObject<UserQueryResult>(result);
            if(queryResult != null)
                return queryResult.users;
            return null;
        }
    }
}
