using Bt.core;
using Bt.core.Model;
using Bt.core.Model.Pluggable;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public class ApplicationBase : IBtApplication, IDisposable
    {

        [CompilerGenerated]
        private sealed class ActionFrameworkCreateOptions
        {
            public BtFrameworkCreateOptions BtFrameworkCreateOptions;
            internal void ActionbyFrameworkCreateOptions(Action<BtFrameworkCreateOptions> A_0)
            {
                if (A_0 == null)
                {
                    return;
                }
                else
                {
                    A_0(BtFrameworkCreateOptions);
                    return;
                }
            }
        }
        [CompilerGenerated]
        private sealed class IsModuleDescriptor
        {
            public Type Type;
            internal bool IsModuleDescriptors(BtModuleDescriptor btModuleDescriptor)
            {
                return btModuleDescriptor.Type == Type;
            }

        }
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Type startupModuleType;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IServiceCollection service;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly List<IBtModuleDescriptor> descriptors;
        private IServiceProvider serviceProvider;
        public Type StartupModuleType { get { return this.startupModuleType; } }
        public IServiceCollection Service { get { return this.service; } }
        public List<IBtModuleDescriptor> Descriptors { get { return this.descriptors; } }

        public IServiceProvider ServiceProvider { get { return this.serviceProvider; } private set { serviceProvider = value; } }

        public IServiceCollection Services => throw new NotImplementedException();

#pragma warning disable CS8625 // 无法将 null 字面量转换为非 null 的引用类型。
        public ApplicationBase(Type _startupModuleType, IServiceCollection _services, List<Action<BtFrameworkCreateOptions>> _optionsActions = null)
#pragma warning restore CS8625 // 无法将 null 字面量转换为非 null 的引用类型。
            {
                this.startupModuleType = _startupModuleType;
                this.service = _services;
                Service.AddAssemblyOf<IBtApplication>();
                BtFrameworkCreateOptions btFramework = new BtFrameworkCreateOptions(_services);
                _optionsActions?.ForEach(delegate (Action<BtFrameworkCreateOptions> A_0)
                {
                    if (A_0 == null)
                    {
                        return;
                    }
                    else
                    {
                        A_0(btFramework);
                        return;
                    }
                });
                 _services.TryBuildConfiguration(btFramework);
                descriptors = LoadModules(btFramework.PlugInSources);
                Descriptors.Reverse();
                new ModuleContext().ModuleDescriptors = Descriptors;
                _services.AddSingleton(Descriptors);
                _services.TryAddObjectAccessor<IServiceProvider>();
                ConfigureServices();

            }
        public virtual void Shutdown()
        {
            IServiceScope serviceScope = ServiceProvider.CreateScope();
        try
        {
            serviceScope.ServiceProvider.GetRequiredService<ExposeApplicationInitialization>().GetApplicationShutdownContext(new ApplicationShutdownContext(serviceScope.ServiceProvider));
        }
        finally
        {
            if (serviceScope != null)
            {
                serviceScope.Dispose();
            }

        }
            return;
        }
        public virtual void Dispose()
        {

        }
        protected virtual void ConfigureServices()
        {
            int a_ = 11;
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
            ServiceConfigurationContext serviceConfigurationContext = default(ServiceConfigurationContext);
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
            List<IBtModuleDescriptor>.Enumerator enumerator = default(List<IBtModuleDescriptor>.Enumerator);
            serviceConfigurationContext = new ServiceConfigurationContext(Services);
            Services.AddSingleton(serviceConfigurationContext);
            enumerator = Descriptors.GetEnumerator();
            IEnumerator<IBtModuleDescriptor> enumerator2 = default(IEnumerator<IBtModuleDescriptor>);
            IBtModuleDescriptor current3 = default(IBtModuleDescriptor);
            List<IBtModuleDescriptor>.Enumerator enumerator4 = default(List<IBtModuleDescriptor>.Enumerator);
            IBtModuleDescriptor current4 = default(IBtModuleDescriptor);
            List<IBtModuleDescriptor>.Enumerator enumerator3 = default(List<IBtModuleDescriptor>.Enumerator);
            bool flag2 = default(bool);
            IBtModuleDescriptor current2 = default(IBtModuleDescriptor);
            bool flag = default(bool);
            BtModule btModule = default(BtModule);
           
            try
            {
                while (enumerator.MoveNext())
                {
                    IBtModuleDescriptor current = enumerator.Current;
                    btModule = current.Instance as BtModule;
                    flag = btModule != null;
                    if (flag)
                    {
                        btModule.ServiceConfigurationContext = serviceConfigurationContext;
                    }
                 }

            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
            enumerator2 = Descriptors.Where(delegate (IBtModuleDescriptor A_0)
            {
                return A_0.Instance is IPreConfigureServices;
            }).GetEnumerator();
            try
            {
               while (enumerator2.MoveNext())
                {
                    current2 = enumerator2.Current;
                    try
                    {
                        ((IPreConfigureServices)current2.Instance).PreConfigureServices(serviceConfigurationContext);
                    }
                    catch (Exception innerException)
                    {
                        DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(84, 2);
                        defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("胀귂\ue5c4ꋆ믈맊ꋌ뷎\uf1d0볒뛔듖곘\ua9da꿜뫞藠쏢臤鋦鯨苪菬裮퇰", a_));
                        defaultInterpolatedStringHandler.AppendFormatted(ServiceCollectionRegistrationActionExtensions.b("釀뇂ꃄ蓆ꛈꗊꯌꛎ뛐ꛒ\ua7d4닖諘뻚꿜꧞裠胢胤铦", a_));
                        defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("\ue1c0돂귄ꛆ뫈껊\uedccꃎ럐\uf3d2ꇔ뿖볘ﯚ냜냞藠離觤苦짨", a_));
                        defaultInterpolatedStringHandler.AppendFormatted(current2.Type.AssemblyQualifiedName);
                        defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("\uefc0\ue3c2雄ꋆ곈\uebca만\ua7ce듐\uf3d2볔맖럘뻚꿜\uffde蓠鯢蛤苦駨\u9fea蓬胮\u9ff0폲鏴飶诸\udbfa駼髾甀戂氄欆稈┊", a_));
                        throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear(), innerException);
                    }
                }

             }
            finally
            {
                if (enumerator2 != null)
                {
                    enumerator2.Dispose();
                }
            }
            enumerator3 = Descriptors.GetEnumerator();
            try
            {
                while (enumerator3.MoveNext())
                {
                    current4 = enumerator3.Current;
                    BtModule btModule2 = current4.Instance as BtModule;
                    flag2 = btModule2 != null;
                    if (flag2)
                    {
                        Services.AddTypes(current4.Type.Assembly);
                        current4.Instance.ConfigureServices(serviceConfigurationContext);

                    }

                }

            }
            finally
            {
                ((IDisposable)enumerator3).Dispose();

            }
            enumerator4 = Descriptors.GetEnumerator();
            try
            {
                while (enumerator4.MoveNext())
                {
                    current3 = enumerator4.Current;
                    try
                    {
                        ((IPostConfigureServices)current3.Instance).PostConfigureServices(serviceConfigurationContext);
                    }
                    catch (Exception innerException2)
                    {
                        DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(84, 2);
                        defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("胀귂\ue5c4ꋆ믈맊ꋌ뷎\uf1d0볒뛔듖곘\ua9da꿜뫞藠쏢臤鋦鯨苪菬裮퇰", a_));
                        defaultInterpolatedStringHandler.AppendFormatted(ServiceCollectionRegistrationActionExtensions.b("釀곂뛄돆諈\ua4caꏌ\ua9ce룐듒ꃔꗖ볘裚룜귞韠諢蛤苦髨", a_));
                        defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("\ue1c0돂귄ꛆ뫈껊\uedccꃎ럐\uf3d2ꇔ뿖볘ﯚ냜냞藠離觤苦짨", a_));
                        defaultInterpolatedStringHandler.AppendFormatted(current3.Type.AssemblyQualifiedName);
                        defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("\uefc0\ue3c2雄ꋆ곈\uebca만\ua7ce듐\uf3d2볔맖럘뻚꿜\uffde蓠鯢蛤苦駨\u9fea蓬胮\u9ff0폲鏴飶诸\udbfa駼髾甀戂氄欆稈┊", a_));
                        throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear(), innerException2);
                    }
                }
            }
            finally
            {
                ((IDisposable)enumerator4).Dispose();
            }

        }
        protected List<IBtModuleDescriptor> LoadModules(PlugInSourceList plugInSources)
        {
            List<Type>.Enumerator enumerator = default(List<Type>.Enumerator);
            List<BtModuleDescriptor> source = default(List<BtModuleDescriptor>);
            IEnumerator<Type> enumerator2 = default(IEnumerator<Type>);
            List<IBtModuleDescriptor> result = default(List<IBtModuleDescriptor>);
            source = new List<BtModuleDescriptor>();
            enumerator = BtModuleHelper.GetAllModuleTypes(StartupModuleType).GetEnumerator();
            try
            {
                while(enumerator.MoveNext())
                {
                    Type current = enumerator.Current;
                    IBtModule aceModule = (IBtModule)Activator.CreateInstance(current);
                    Service.AddSingleton(current, aceModule);
                    source.AddIfNotContains(new BtModuleDescriptor(current, aceModule, isLoadedAsPlugIn: false));
                }
             }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
            enumerator2 = plugInSources.GetModulesWithAllDependencies().GetEnumerator();
            try
            {
                bool flag = default(bool);
                IsModuleDescriptor isModuleDescriptor = default(IsModuleDescriptor);
                while (enumerator2.MoveNext())
                {
                    isModuleDescriptor= new IsModuleDescriptor();
                    isModuleDescriptor.Type=enumerator2.Current;
                    flag = source.Any(new Func<BtModuleDescriptor, bool>(isModuleDescriptor.IsModuleDescriptors));
                    if (!flag)
                    {
                        IBtModule aceModule2 = (IBtModule)Activator.CreateInstance(isModuleDescriptor.Type);
                        Service.AddSingleton(isModuleDescriptor.Type, aceModule2);
                        source.AddIfNotContains(new BtModuleDescriptor(isModuleDescriptor.Type, aceModule2, isLoadedAsPlugIn: true));

                    }

                    }
            }
            finally
            {
                if (enumerator2 != null)
                {
                    enumerator2.Dispose();
                }
            }
            result = source.Cast<IBtModuleDescriptor>().ToList();
            return result;

        }
        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;

        }
        }
        
}
