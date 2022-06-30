using Microsoft.Extensions.DependencyInjection;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace Bt.core.Model
{
    public class BtModuleDescriptor : IBtModuleDescriptor
    {
        private readonly List<IBtModuleDescriptor> _relytor;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly Type _type;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly Assembly _assembly;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly IBtModule _instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly bool _isLoadedAsPlugIn;

        public Type Type 
        {
            [CompilerGenerated]
            get { return _type;}
        }

        public Assembly Assembly 
        {
            [CompilerGenerated]
            get { return _assembly; } 
        }

        public IBtModule Instance 
        {
            [CompilerGenerated]
            get { return _instance; }
        }

        public bool IsLoadedAsPlugIn 
        {
            [CompilerGenerated]
            get { return _isLoadedAsPlugIn;}
        }
        public BtModuleDescriptor(Type type, IBtModule instance, bool isLoadedAsPlugIn)
        {
            if (!type.GetTypeInfo().IsAssignableFrom(instance.GetType()))
            {
                throw new ArgumentException( instance.GetType().AssemblyQualifiedName + type.AssemblyQualifiedName);
            }
            _type = type;
            _assembly = type.Assembly;
            _instance = instance;
            _isLoadedAsPlugIn = isLoadedAsPlugIn;
            _relytor = new List<IBtModuleDescriptor>();

        }

        public void AddRely(IBtModuleDescriptor relytor)
        {
            //AddIfBotContains  (System.Collections.Generic)扩展方法
            _relytor.AddIfNotContains(relytor);
        }
    }
}
