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
			
			short num = 0;
			switch (num)
			{
				default:
					{
						List<Type> list = new List<Type>();
						IEnumerable<IReliedModuleTypes> enumerable = A_0.GetCustomAttributes(inherit: true).ToList().OfType<IReliedModuleTypes>();
						IEnumerator<IReliedModuleTypes> enumerator = enumerable.GetEnumerator();
						try
						{
							num = -14960;
							short num2 = num;
							num = -14960;
							int num3;
							Type[] reliedModuleTypes = default(Type[]);
							int num4 = default(int);
							switch (num2 == num)
							{
								default:
									num = 0;
									if (num != 0)
									{
									}
									num = 1;
									num3 = num;
									goto IL_00dd;
								case false:
								case true:
									{
										num = 3;
										num3 = num;
										goto IL_00dd;
									}
								IL_00dd:
									while (true)
									{
										switch (num3)
										{
											case 2:
												goto end_IL_0072;
											case 1:
												switch (0)
												{
													default:
														continue;
													case 0:
														break;
												}
												break;
											case 3:
												{
													if (!enumerator.MoveNext())
													{
														num = 6;
														num3 = num;
														continue;
													}
											       IReliedModuleTypes current = enumerator.Current;
													reliedModuleTypes = ((ModuleOnAttribute)current).GetReliedModuleTypes();
													num4 = 0;
													num = 8;
													num3 = num;
													continue;
												}
											case 5:
												num = 4;
												num3 = num;
												continue;
											case 7:
											case 8:
												num = 0;
												num3 = num;
												continue;
											case 0:
												{
													if (num4 >= reliedModuleTypes.Length)
													{
														num = 5;
														num3 = num;
														continue;
													}
													Type item = reliedModuleTypes[num4];
													list.AddIfNotContains(item);
													num4++;
													num = 7;
													num3 = num;
													continue;
												}
											case 6:
												num = 2;
												num3 = num;
												continue;
										}
										break;
									}
									goto case false;
							}
						end_IL_0072:;
						}
						finally
						{
							num = 0;
							int num3 = num;
							while (true)
							{
								switch (num3)
								{
									case 0:
										switch (0)
										{
											default:
												continue;
											case 0:
												break;
										}
										goto default;
									default:
										if (enumerator != null)
										{
											num = 2;
											num3 = num;
											continue;
										}
										break;
									case 2:
										enumerator.Dispose();
										num = 1;
										num3 = num;
										continue;
									case 1:
										break;
								}
								break;
							}
						}
						num = 0;
						_ = num;
						List<Type> result = list;
						num = 1;
						if (num != 0)
						{
						}
						return result;
					}
			}
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
