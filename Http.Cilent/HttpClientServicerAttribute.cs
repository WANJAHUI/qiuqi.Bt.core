using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Http.Cilent
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class HttpClientServicerAttribute : Attribute

    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly HttpClientType _httpClientType;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _url;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _prefix;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private NameConventionType _nameConventionType = NameConventionType.Pascal;

        public HttpClientType HttpClientType 
        {
            get { return _httpClientType; }
        }
        public string BaseUrl
        {
            get { return _url; }
        }
        public string Prefix
        {
            get { return _prefix; }
        }
        public NameConventionType NameConventionType { get { return _nameConventionType; } }
        public HttpClientServicerAttribute(HttpClientType httpClientType, string baseurl)
        {
            _httpClientType = httpClientType;
            _url = baseurl;
         
        }
        public HttpClientServicerAttribute(string baseUrl)
        : this(HttpClientType.NormalClient, baseUrl)
        {
        }
        public HttpClientServicerAttribute(HttpClientType httpClientType)
        : this(httpClientType, null)
        {
        }
        public HttpClientServicerAttribute()
        : this(HttpClientType.NormalClient, null)
        {
        }

    }
}
