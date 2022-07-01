using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RESTfulAttribute:Attribute
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string url;
        public string Url { [CompilerGenerated] get { return url; } }

        public RESTfulAttribute()
        {
        }

        public RESTfulAttribute(string _url)
        {
           url= _url;
        }
        public string GetUrl()
        {
            return url;
        }
    }
}
