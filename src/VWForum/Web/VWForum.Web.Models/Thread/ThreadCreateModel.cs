namespace VWForum.Web.Models.Thread
{
    public class ThreadCreateModel
    {
        public string CommunityId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public List<string> Tags { get; set; }
    }
}
