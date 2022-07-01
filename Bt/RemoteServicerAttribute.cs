using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Interface)]
    public class RemoteServicerAttribute:Attribute
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isEnabled;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isMetadataEnabled;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string name;
        public bool IsEnabled {
            [CompilerGenerated]
            get { return isEnabled; }
            [CompilerGenerated]
            set
            {
                isEnabled = value;
            } }
        public string Name { [CompilerGenerated] get { return name; } [CompilerGenerated] set { name = value; } }

        public bool IsMetadataEnabled { [CompilerGenerated] get { return isMetadataEnabled; } [CompilerGenerated] set { isMetadataEnabled = value; } }
        public RemoteServicerAttribute(bool isEnabled = true)
        {
            IsEnabled = isEnabled;
            IsMetadataEnabled = true;
        }


    }
}
