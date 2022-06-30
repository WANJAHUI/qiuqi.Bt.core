using Bt.BeprndencyInjection;
using Bt.core.Model;

// Microsoft.Extensions.DependencyInjection.ServiceCollectionRegistrationActionExtensions
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionRegistrationActionExtensions
    {

		public static void OnRegistred(this IServiceCollection services, Action<IOnServiceRegistredContext> registrationAction)
		{
			GetᜀserviceRegistrationActionList(services).Add(registrationAction);
		}
		private static ServiceRegistrationActionList GetᜀserviceRegistrationActionList(IServiceCollection A_0)
        {
			bool flag = default(bool);
			ServiceRegistrationActionList serviceRegistrationActionList = default(ServiceRegistrationActionList);
			ServiceRegistrationActionList result = default(ServiceRegistrationActionList);
			Object obj;
			IObjectAccessor<ServiceRegistrationActionList> singletonInstanceOrNull = A_0.GetSingletonInstanceOrNull<IObjectAccessor<ServiceRegistrationActionList>>();
			if (singletonInstanceOrNull != null)
			{
				obj = singletonInstanceOrNull.Value;
				goto IL_0129;
			}
            else
            {
				obj = null;
				goto IL_0129;
			}
		    IL_0129:
			serviceRegistrationActionList = (ServiceRegistrationActionList)obj;
			flag = serviceRegistrationActionList == null;
			if (flag)
			{
				serviceRegistrationActionList = new ServiceRegistrationActionList();
				A_0.AddObjectAccessor(serviceRegistrationActionList);
			}
			else
			{
				result = serviceRegistrationActionList;
			}
			return result;
		}
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((nint)(12565590 + A_1) + (nint)55 + 25 + 15);
			int i=0;
            if (i >= 1)
            {
				goto IL_0029;
            }
			goto IL_005c;
		    IL_005c:
			if (i >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_0029;
		    IL_0029:
			int j = i;
			char str = array[j];
            byte b = (byte)((str & 0xFFu) ^ (uint)num++);
			byte b2 = (byte)(((int)str >> 8) ^ num++);
			byte str1 = b2;
			b2 = b;
			b = str1;
			array[j] = (char)((b2 << 8) | b);
			i++;
			goto IL_005c;
		}
	}
}
