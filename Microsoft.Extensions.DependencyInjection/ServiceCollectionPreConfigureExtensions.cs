
using Bt.core.Model;
using Bt.core.Options;
//Microsoft.Extensions.DependencyInjection.ServiceCollectionPreConfigureExtensions
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionPreConfigureExtensions
    {
        public static IServiceCollection PreConfigure<TOptions>(this IServiceCollection services, Action<TOptions> optionsAction)
        {
            //Discarded unreachable code: IL_004a, IL_0060
            short num = 4049;
            short num2 = num;
            num = 4049;
            switch (num2 == num)
            {
                default:
                    num = 1;
                    if (num != 0)
                    {
                    }
                    num = 0;
                    _ = num;
                    num = 0;
                    if (num != 0)
                    {
                    }
                    services.GetPreConfigureActions<TOptions>().Add(optionsAction);
                    return services;
                case false:
                case true:
                    {
                        IServiceCollection result = default(IServiceCollection);
                        return result;
                    }
            }
        }
        public static PreConfigureActionList<TOptions> GetPreConfigureActions<TOptions>(this IServiceCollection services)
        {
            bool flag = default(bool);
            PreConfigureActionList<TOptions> preConfigureActionList = default(PreConfigureActionList<TOptions>);
            PreConfigureActionList<TOptions> result = default(PreConfigureActionList<TOptions>);
            object obj;
            IObjectAccessor<PreConfigureActionList<TOptions>> singletonInstanceOrNull = services.GetSingletonInstanceOrNull<IObjectAccessor<PreConfigureActionList<TOptions>>>();
            if (singletonInstanceOrNull != null)
            {
                obj = singletonInstanceOrNull.Value;

            }
            else
            {
                obj = null;
            }
            preConfigureActionList = (PreConfigureActionList<TOptions>)obj;
            flag = preConfigureActionList == null;
            if (flag)
            {
                preConfigureActionList = new PreConfigureActionList<TOptions>();
                services.AddObjectAccessor(preConfigureActionList);
            }
            result = preConfigureActionList;
            return result;


        }
        public static TOptions ExecutePreConfiguredActions<TOptions>(this IServiceCollection services) where TOptions : new()
        {
            short num = -26767;
            short num2 = num;
            num = -26767;
            TOptions result = default(TOptions);
            switch (num2 == num)
            {
                default:
                    num = 0;
                    if (num != 0)
                    {
                    }
                    num = 0;
                    _ = num;
                    result = ExecutePreConfiguredActions(services, new TOptions());
                    break;
                case false:
                case true:
                    break;
            }
            num = 1;
            if (num != 0)
            {
            }
            return result;
        }
        public static TOptions ExecutePreConfiguredActions<TOptions>(this IServiceCollection services, TOptions options)
        {
            short num = 6535;
            short num2 = num;
            num = 6535;
            switch (num2 == num)
            {
                default:
                    num = 0;
                    if (num != 0)
                    {
                    }
                    num = 0;
                    _ = num;
                    num = 1;
                    if (num != 0)
                    {
                    }
                    services.GetPreConfigureActions<TOptions>().Configure(options);
                    return options;
                case false:
                case true:
                    {
                        TOptions result = default(TOptions);
                        return result;
                    }
            }
        }

        }
}
