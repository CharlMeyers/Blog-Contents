using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Domain
{
    public class ClientBrowserInfo
    {
        public Guid BrowserClientID { get; set; }
        public string UserAgentString { get; set; }
        public int DisplayResolutionHeight { get; set; }
        public int DisplayResolutionWidth { get; set; }
    }
}
