
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bt.core.Model
{
    public class ServiceConfigurationContext
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly IServiceCollection ᜀ;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly IDictionary<string, object> ᜁ;
        public IServiceCollection Services 
        {
            [CompilerGenerated]
            get; 
        }
       
        public IDictionary<string, object> Items 
        {
            [CompilerGenerated]
            get;
        
        }

        public object this[string key]
        {
         
            get
            {
               

                return Items.GetOrDefault(key);


            }
            set
            {
                Items[key] = value;
            }
        }

        public ServiceConfigurationContext(IServiceCollection services)
        {
            this.Services = services;
            this.Items = new Dictionary<string, object>();
        }
    }
}