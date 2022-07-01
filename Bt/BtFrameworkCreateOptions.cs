using Bt.core.Model.Pluggable;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bt
{
    public  class BtFrameworkCreateOptions
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IServiceCollection services;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly PlugInSourceList plugInSources;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly BtConfigurationBuilderOptions btConfigurationBuilderOptions;
        public IServiceCollection Services
        {
            get { return services; }    
               
        }
        public PlugInSourceList PlugInSources
        {
            get { return plugInSources; }
        }
        public BtConfigurationBuilderOptions BtConfigurationBuilderOptions
        {
            get { return btConfigurationBuilderOptions; }
        }
        public BtFrameworkCreateOptions(IServiceCollection services)
        {
            this.services = services;
            this.plugInSources = new PlugInSourceList();
            this.btConfigurationBuilderOptions = new BtConfigurationBuilderOptions();
        }
        
    }
}
