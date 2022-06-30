using Bt.core.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model.Pluggable
{
    public static class PlugInSourceExtensions
    {
        public static IEnumerable<Type> GetModulesWithAllDependencies(this IPlugInSource plugInSource)
        {
			short num = 479;
			short num2 = num;
			num = 479;
			switch (num2 == num)
			{
				default:
					{
						num = 0;
						_ = num;
						num = 1;
						if (num != 0)
						{
						}
						num = 0;
						if (num != 0)
						{
						}
						TypeList<IBtModule> modules = plugInSource.GetModules();
						return modules.SelectMany(delegate (Type A_0)
						{
							//Discarded unreachable code: IL_0037, IL_00a5
							short num3 = 25415;
							short num4 = num3;
							num3 = 25415;
							int num5 = default(int);
							List<Type> list = default(List<Type>);
							bool flag = default(bool);
							IEnumerable<Type> result2 = default(IEnumerable<Type>);
							switch (num4 == num3)
							{
								default:
									num3 = 0;
									_ = num3;
									goto case true;
								case false:
								case true:
									{
										num3 = 2;
										num5 = num3;
										goto IL_007d;
									}
								IL_0093:
									num3 = 1;
									if (num3 != 0)
									{
									}
									list = new List<Type>();
									flag = A_0.IsModule();
									num3 = 1;
									num5 = num3;
									goto IL_007d;
								IL_007d:
									while (true)
									{
										switch (num5)
										{
											case 1:
												if (flag)
												{
													num3 = 0;
													num5 = num3;
													continue;
												}
												goto IL_00f7;
											case 3:
												goto IL_00f7;
											case 0:
												BtModuleHelper.AddModuleAndReliesRecursively(list, A_0);
												num3 = 3;
												num5 = num3;
												continue;
											case 2:
												return result2;
										}
										break;
									}
									goto IL_0093;
								IL_00f7:
									result2 = list;
									goto case false;
							}
						}).Distinct();
					}
				case false:
				case true:
					{
						IEnumerable<Type> result = default(IEnumerable<Type>);
						return result;
					}
			}
		}

    }
}
