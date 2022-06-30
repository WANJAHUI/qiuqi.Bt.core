using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Reflection
{
    public static class ReflectionHelper
    {
		public static bool IsAssignableToGenericType(Type givenType, Type genericType)
		{
			short num = 0;
			int num2 = num;
			switch (num2)
			{
				default:
					{
						TypeInfo typeInfo = default(TypeInfo);
						switch (0)
						{
							default:
								{
									int num3 = default(int);
									Type[] interfaces = default(Type[]);
									Type type = default(Type);
									bool result = default(bool);
									bool flag3 = default(bool);
									bool flag2 = default(bool);
									bool flag = default(bool);
									while (true)
									{
										int num6;
										int num4;
										switch (num2)
										{
											case 7:
												if (typeInfo.IsGenericType)
												{
													num = 14;
													num2 = num;
												}
												else
												{
													num = 0;
													num2 = num;
												}
												continue;
											case 8:
											case 9:
												num = 17;
												num2 = num;
												continue;
											case 17:
												if (num3 >= interfaces.Length)
												{
													num = 16;
													num2 = num;
												}
												else
												{
													type = interfaces[num3];
													num = 13;
													num2 = num;
												}
												continue;
											case 13:
												if (type.GetTypeInfo().IsGenericType)
												{
													num = 12;
													num2 = num;
													continue;
												}
												num = 1;
												if (num != 0)
												{
												}
												num = 1;
												num2 = num;
												continue;
											case 18:
												result = false;
												num = 5;
												num2 = num;
												continue;
											case 0:
												num6 = 0;
												goto IL_0281;
											case 14:
												num = 2;
												num2 = num;
												continue;
											case 2:
												num6 = ((givenType.GetGenericTypeDefinition() == genericType) ? 1 : 0);
												goto IL_0281;
											case 21:
												result = true;
												num = 3;
												num2 = num;
												continue;
											case 12:
												num = 11;
												num2 = num;
												continue;
											case 11:
												num4 = ((type.GetGenericTypeDefinition() == genericType) ? 1 : 0);
												goto IL_036d;
											case 20:
												{
													num = 22732;
													short num5 = num;
													num = 22732;
													switch (num5 == num)
													{
														case false:
														case true:
															break;
														default:
															num = 0;
															if (num != 0)
															{
															}
															if (!flag3)
															{
																interfaces = typeInfo.GetInterfaces();
																num3 = 0;
																num = 9;
																num2 = num;
															}
															else
															{
																num = 21;
																num2 = num;
															}
															continue;
													}
													goto case 12;
												}
											case 1:
												num4 = 0;
												goto IL_036d;
											case 15:
												result = true;
												num = 10;
												num2 = num;
												continue;
											case 6:
												num = 0;
												_ = num;
												if (!flag2)
												{
													num3++;
													num = 8;
													num2 = num;
												}
												else
												{
													num = 15;
													num2 = num;
												}
												continue;
											case 16:
												flag = typeInfo.BaseType == null;
												num = 4;
												num2 = num;
												continue;
											case 4:
												if (!flag)
												{
													result = IsAssignableToGenericType(typeInfo.BaseType, genericType);
													num = 19;
													num2 = num;
												}
												else
												{
													num = 18;
													num2 = num;
												}
												continue;
											case 3:
											case 5:
											case 10:
											case 19:
												{
													return result;
												}
											IL_036d:
												flag2 = (byte)num4 != 0;
												num = 6;
												num2 = num;
												continue;
											IL_0281:
												flag3 = (byte)num6 != 0;
												num = 20;
												num2 = num;
												continue;
										}
										break;
									}
									goto case 0;
								}
							case 0:
								typeInfo = givenType.GetTypeInfo();
								num = 7;
								num2 = num;
								goto default;
						}
					}
			}
		}
	}
}
