using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Bt
{
    public class RouteBuilderContext
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private IServiceProvider ᜀ;

        public IServiceProvider ServiceProvider
        {
            [CompilerGenerated]
            get;
            [CompilerGenerated]
            set;
        }

        public RouteBuilderContext([NotNull] IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
