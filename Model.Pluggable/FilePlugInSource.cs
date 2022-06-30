using Bt.core.Collections;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace Bt.core.Model.Pluggable
{
    public class FilePlugInSource : IPlugInSource
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string[] filePaths;
        public string[] FilePaths { get { return filePaths; } }
        public FilePlugInSource(params string[]_filepaths)
        {
                filePaths = _filepaths;
        }
        public TypeList<IBtModule> GetModules()
        {
			int a_ = 13;
			short num = 0;
			int num2 = num;
			switch (num2)
			{
				default:
					{
						int num5 = default(int);
						string[] filePaths = default(string[]);
						TypeList<IBtModule> typeList = default(TypeList<IBtModule>);
						switch (0)
						{
							default:
								{
									Assembly assembly = default(Assembly);
									TypeList<IBtModule> result = default(TypeList<IBtModule>);
									int num4 = default(int);
									Type[] types = default(Type[]);
									Type type = default(Type);
									bool flag = default(bool);
									while (true)
									{
										switch (num2)
										{
											case 5:
												num = 4;
												num2 = num;
												continue;
											case 4:
												{
													if (num5 >= filePaths.Length)
													{
														num = 3;
														num2 = num;
														continue;
													}
													string assemblyPath = filePaths[num5];
													assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
													num = 0;
													_ = num;
													num = 1;
													num2 = num;
													continue;
												}
											case 3:
												result = typeList;
												num = 0;
												num2 = num;
												continue;
											case 1:
												try
												{
													switch (0)
													{
														default:
															while (true)
															{
																switch (num2)
																{
																	case 0:
																	case 7:
																		num = 4;
																		num2 = num;
																		continue;
																	case 4:
																		{
																			num = 4111;
																			short num3 = num;
																			num = 4111;
																			switch (num3 == num)
																			{
																				default:
																					{
																						num = 0;
																						if (num != 0)
																						{
																						}
																						if (num4 >= types.Length)
																						{
																							num = 6;
																							num2 = num;
																							continue;
																						}
																						type = types[num4];
																						TypeInfo typeInfo = type.GetTypeInfo();
																						flag = type.IsModule();
																						num = 5;
																						num2 = num;
																						continue;
																					}
																				case false:
																				case true:
																					break;
																			}
																			goto case 1;
																		}
																	case 3:
																		typeList.AddIfNotContains(type);
																		num = 1;
																		num2 = num;
																		continue;
																	case 5:
																		if (flag)
																		{
																			num = 3;
																			num2 = num;
																			continue;
																		}
																		goto case 1;
																	case 1:
																		num4++;
																		num = 0;
																		num2 = num;
																		continue;
																	case 6:
																		num = 2;
																		num2 = num;
																		continue;
																	case 2:
																		goto end_IL_012d;
																}
																break;
															}
															goto case 0;
														case 0:
															types = assembly.GetTypes();
															num4 = 0;
															num = 7;
															num2 = num;
															goto default;
													}
												end_IL_012d:;
												}
												catch (Exception)
												{
													throw new Exception(ServiceCollectionRegistrationActionExtensions.b("캌㡄ঈ슲䒔\u0b5a", a_) + assembly.FullName + ServiceCollectionRegistrationActionExtensions.b("\uee8c片備\ue8a2鲝", a_));
												}
												num5++;
												num = 2;
												num2 = num;
												continue;
											case 2:
												num = 1;
												if (num == 0)
												{
												}
												goto case 5;
											case 0:
												return result;
										}
										break;
									}
									goto case 0;
								}
							case 0:
								typeList = new TypeList<IBtModule>();
								filePaths = FilePaths;
								num5 = 0;
								num = 5;
								num2 = num;
								goto default;
						}
					}
			}
			}
     }
}
