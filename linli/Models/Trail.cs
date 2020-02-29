using System;
using System.Collections.Generic;

namespace linli.Models
{
    public class Trail
    {
        public string Id { get; set; }
        public User CreateUser { get; set; }
        public string Content { get; set; }
        public string[] Images { get; set; }
        public DateTime CreateTime { get; set; }
        public List<TrailComment> Comments { get; set; }

    }
    public class TrailComment
    {
        public string Id { get; set; }
        public User CreateUser { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
