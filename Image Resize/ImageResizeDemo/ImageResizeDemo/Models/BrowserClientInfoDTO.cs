using System;

namespace ImageResizeDemo.Models
{
    public class BrowserClientInfoDTO
    {
        public Guid BrowserClientID { get; set; }
        public string UserAgentString { get; set; }
        public int DisplayResolutionHeight { get; set; }
        public int DisplayResolutionWidth { get; set; }
    }
}