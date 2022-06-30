using Microsoft.Extensions.FileProviders;
using System.Diagnostics;
using System.Runtime.CompilerServices;
// Bt.JsonFileOptions
namespace Bt
{
    public class JsonFileOptions
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private IFileProvider _fileProvider = null;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private string _path;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private bool _optional;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private bool _reloadOnChange;

        public IFileProvider FileProvider
        {
            get { return _fileProvider; }
            set { _fileProvider = value; }
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public bool Optional
        {
            get { return _optional; }
            set
            {
                _optional = value;
            }
        }
        public bool ReloadOnChange
        {
            get { return _reloadOnChange; }
            set
            {
                _reloadOnChange = value;
            }
        }
    }
}
