using System;

namespace linli.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string HeadImgUrl { get; set; }
        public string Sex { get; set; }
        public int MessageNum { get; set; }
        public DateTime CreateTime { get; set; }
        
    }
}