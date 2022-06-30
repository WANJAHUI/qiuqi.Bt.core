using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Bt.core.Model
{
    public class ApplicationInitializationContext
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

        public ApplicationInitializationContext([NotNull] IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
