using Bt.core;
using Bt.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public static class BtModuleHelper
    {
        public static bool IsModule(this Type type)
        {
            TypeInfo typeInfo = default(TypeInfo);
            bool result = default(bool);
            int num = 0;
            if (type.IsClass)
            {
                if (!typeInfo.IsAbstract)
                {
                    if (!typeInfo.IsGenericType)
                    {
                        num = (type.IsAssignableTo(typeof(IBtModule)) ? 1 : 0);
                        goto IL0528;
                    }
                    goto IL0528;
                }
                goto IL0528;
            }
            goto IL0528;
        IL0528:
            result = (byte)num != 0;
            return result;

        }
        public static void AddModuleAndReliesRecursively(List<Type> moduleTypes, Type moduleType, int depth = 0)
        {
            bool flag = default(bool);
            flag = moduleTypes.Contains(moduleType);
            List<Type>.Enumerator enumerator = default(List<Type>.Enumerator);
            if (flag)
            {
                moduleTypes.Remove(moduleType);
                goto IL0832;

            }
            else
            {
                goto IL0832;
            }
        IL0832:
            moduleTypes.Add(moduleType);
            enumerator = GetDependedModuleTypes(moduleType).GetEnumerator();
            try
            {
                if (enumerator.MoveNext())
                {
					Type current = enumerator.Current;
                    AddModuleAndReliesRecursively(moduleTypes, current, depth + 1);
                }
                return;
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
        }
        private static List<Type> GetDependedModuleTypes(Type A_0)
		{
	        List<Type> list = new List<Type>();
	        BtModule.IsBtType(A_0);
	        IEnumerable<IReliedModuleTypes> enumerable = A_0.GetCustomAttributes(inherit: true).ToList().OfType<IReliedModuleTypes>();
	        IEnumerator<IReliedModuleTypes> enumerator = enumerable.GetEnumerator();
            try
            {
                if (enumerator.MoveNext())
                {
                    IReliedModuleTypes current = enumerator.Current;
                    Type[] reliedModuleTypes = current.GetReliedModuleTypes();
                    foreach (Type item in reliedModuleTypes)
                    {
                        list.AddIfNotContains(item);
                    }

                }
            }
            finally
            {
                enumerator.Dispose();
            }    
            return list;
		}
		public static List<Type> GetAllModuleTypes(Type startupModuleType)
        {
			List<Type> list = new List<Type>();
			AddModuleAndReliesRecursively(list, startupModuleType);
			List<Type> result = list;
			return result;

		}
	}
}
