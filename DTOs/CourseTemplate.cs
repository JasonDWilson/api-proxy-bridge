using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.Bridge.DTOs
{
    public class CourseTemplate
    {
        public DateTime? archived_at { get; set; }
        public int attachments_count { get; set; }
        public Author author { get; set; }
        public BrandingOverride branding_override { get; set; }
        public List<string> categories { get; set; }
        public object continuing_education_credits { get; set; }
        public string course_type { get; set; }
        public DateTime created_at { get; set; }
        public int? default_days_until_due { get; set; }
        public DateTime? default_due_on_date { get; set; }
        public string description { get; set; }
        public bool direct_messaging_enabled { get; set; }
        public string due_date_type { get; set; }
        public EnrollmentCounts enrollment_counts { get; set; }
        public int? enrollments_count { get; set; }
        public int? estimated_time { get; set; }
        public object external_course_id { get; set; }
        public string external_status { get; set; }
        public object external_status_message { get; set; }
        public bool has_been_unpublished { get; set; }
        public bool has_certificate { get; set; }
        public bool has_cover_slide { get; set; }
        public bool has_shared_enrollments { get; set; }
        public bool has_unpublished_changes { get; set; }
        public string id { get; set; }
        public int incomplete_enrollments_count { get; set; }
        public bool is_archived { get; set; }
        public bool is_published { get; set; }
        public Links links { get; set; }
        public bool maintain_branding_in_sub_account { get; set; }
        public List<string> matching_tags { get; set; }
        public int? max_quiz_attempts { get; set; }
        public Meta meta { get; set; }
        public DateTime? next_section_due { get; set; }
        public bool open_book { get; set; }
        public int passing_threshold { get; set; }
        public int quizzes_count { get; set; }
        public bool retain { get; set; }
        public bool show_correct_response { get; set; }
        public SubAccount sub_account { get; set; }
        public List<string> tags { get; set; }
        public object third_party_course_id { get; set; }
        public string title { get; set; }
        public bool unarchive_locked { get; set; }
        public DateTime updated_at { get; set; }
        public bool within_subaccount_scope { get; set; }
    }
}
