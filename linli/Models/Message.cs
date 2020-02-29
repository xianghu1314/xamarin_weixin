using System;

namespace linli.Models
{
    public enum MessageType
    {
        Text,
        Image,
        Video,
        Audio,
        File
    }
    public class Message
    {
        public string Id { get; set; }
        public MessageType MessageType { get; set; }
        /// <summary>
        /// url
        /// </summary>
        public string Content { get; set; } 
        public User FromUser { get; set; }
        public User ToUser { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsMySelf { get; set; }
        
    }
}
