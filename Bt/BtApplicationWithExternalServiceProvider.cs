using Bt.core.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
#pragma warning disable CS8767 // 参数类型中引用类型的为 Null 性与隐式实现的成员不匹配(可能是由于为 Null 性特性)。
    public class BtApplicationWithExternalServiceProvider : ApplicationBase, IBtApplicationWithExternalServiceProvider, IBtApplication, IDisposable
#pragma warning restore CS8767 // 参数类型中引用类型的为 Null 性与隐式实现的成员不匹配(可能是由于为 Null 性特性)。
	{
        public BtApplicationWithExternalServiceProvider(Type startupModuleType, IServiceCollection services, List<Action<BtFrameworkCreateOptions>> options = null) : base(startupModuleType, services, options)
		{
            services.AddSingleton((IBtApplicationWithExternalServiceProvider)this);
            services.AddTransient(delegate
            {
                return new StackTrace(fNeedFileInfo: true);
            });
        }

        public void Initialize(IServiceProvider serviceProvider)
        {
			SetServiceProvider(serviceProvider);
			InitializeModules();
		}
        public void InitializeModules()
        {
		
			int a_ = 8;
			short num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			int num2 = num;
			switch (num2)
			{
				default:
					{
						IServiceScope serviceScope = base.ServiceProvider.CreateScope();
						try
						{
							RouteBuilderContext context2 = default(RouteBuilderContext);
							ApplicationInitializationContext context = default(ApplicationInitializationContext);
							List<IBtModuleDescriptor> requiredService = default(List<IBtModuleDescriptor>);
							List<IBtModuleDescriptor>.Enumerator enumerator = default(List<IBtModuleDescriptor>.Enumerator);
							switch (0)
							{
								default:
									{
										IBtModule instance4 = default(IBtModule);
										IBtModuleDescriptor current4 = default(IBtModuleDescriptor);
										List<IBtModuleDescriptor>.Enumerator enumerator4 = default(List<IBtModuleDescriptor>.Enumerator);
										IBtModule instance2 = default(IBtModule);
										IBtModuleDescriptor current2 = default(IBtModuleDescriptor);
										List<IBtModuleDescriptor>.Enumerator enumerator2 = default(List<IBtModuleDescriptor>.Enumerator);
										List<IBtModuleDescriptor>.Enumerator enumerator3 = default(List<IBtModuleDescriptor>.Enumerator);
										IBtModule instance3 = default(IBtModule);
										IBtModuleDescriptor current3 = default(IBtModuleDescriptor);
										IBtModule instance = default(IBtModule);
										IBtModuleDescriptor current = default(IBtModuleDescriptor);
										while (true)
										{
											switch (num2)
											{
												case 2:
													try
													{
														num = 2;
														num2 = num;
														while (true)
														{
															switch (num2)
															{
																case 2:
																	switch (0)
																	{
																		default:
																			continue;
																		case 0:
																			break;
																	}
																	goto default;
																case 0:
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
																							{
																								IOnRouteInitialization obj4 = instance4 as IOnRouteInitialization;
																								if (obj4 == null)
																								{
																									num = 2;
																									num2 = num;
																								}
																								else
																								{
																									obj4.OnRouteInitialization(context2);
																									num = 3;
																									num2 = num;
																								}
																								continue;
																							}
																						case 2:
																						case 3:
																							num = 1;
																							num2 = num;
																							continue;
																						case 1:
																							goto end_IL_0179;
																					}
																					break;
																				}
																				goto case 0;
																			case 0:
																				instance4 = current4.Instance;
																				num = 0;
																				num2 = num;
																				goto default;
																		}
																	end_IL_0179:;
																	}
																	catch (Exception ex4)
																	{
																		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 3);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("ꏯ௦풒\u034c춿\ue589ᮚ펾흘㽄\uf2d1", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(current4.Assembly.FullName);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("麽\ue1d5閖䂵變ꚸ\ueac9", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(current4.Type.AssemblyQualifiedName);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("蒽\ue0bf", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(ex4.Message);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("벍\ue0bf쮦랒⁎\u0eb9⮆ꎫ숲❄\u1082ᕚ厄ぇ\ud886\ue485\udced", a_));
																		throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear(), ex4);
																	}
																	num = 1;
																	num2 = num;
																	continue;
																default:
																	num = 4;
																	num2 = num;
																	continue;
																case 4:
																	if (enumerator4.MoveNext())
																	{
																		current4 = enumerator4.Current;
																		num = 0;
																		num2 = num;
																	}
																	else
																	{
																		num = 5;
																		num2 = num;
																	}
																	continue;
																case 5:
																	num = 3;
																	num2 = num;
																	continue;
																case 3:
																	break;
															}
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator4).Dispose();
													}
													num = 3;
													num2 = num;
													continue;
												case 0:
													try
													{
														num = 2;
														num2 = num;
														while (true)
														{
															switch (num2)
															{
																case 2:
																	switch (0)
																	{
																		default:
																			continue;
																		case 0:
																			break;
																	}
																	goto default;
																case 4:
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
																							{
																								IOnApplicationInitialization obj2 = instance2 as IOnApplicationInitialization;
																								if (obj2 == null)
																								{
																									num = 2;
																									num2 = num;
																								}
																								else
																								{
																									obj2.OnApplicationInitialization(context);
																									num = 3;
																									num2 = num;
																								}
																								continue;
																							}
																						case 2:
																						case 3:
																							num = 1;
																							num2 = num;
																							continue;
																						case 1:
																							goto end_IL_03d4;
																					}
																					break;
																				}
																				goto case 0;
																			case 0:
																				instance2 = current2.Instance;
																				num = 0;
																				num2 = num;
																				goto default;
																		}
																	end_IL_03d4:;
																	}
																	catch (Exception ex2)
																	{
																		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 3);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("ꏯ௦풒\u034c춿\ue589ᮚ펾흘㽄\uf2d1", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(current2.Assembly.FullName);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("麽\ue1d5閖䂵變ꚸ\ueac9", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(current2.Type.AssemblyQualifiedName);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("蒽\ue0bf", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(ex2.Message);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("벍\ue0bf쮦랒⁎\u0eb9⮆ꎫ숲❄\u1082ᕚ厄ぇ\ud886\ue485\udced", a_));
																		throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear(), ex2);
																	}
																	goto IL_03ba;
																default:
																	num = 5;
																	num2 = num;
																	continue;
																case 5:
																	if (enumerator2.MoveNext())
																	{
																		current2 = enumerator2.Current;
																		num = 4;
																		num2 = num;
																	}
																	else
																	{
																		num = 1;
																		num2 = num;
																	}
																	continue;
																case 1:
																	{
																		num = -3384;
																		short num3 = num;
																		num = -3384;
																		switch (num3 == num)
																		{
																			case false:
																			case true:
																				break;
																			default:
																				num = 0;
																				if (num != 0)
																				{
																				}
																				num = 3;
																				num2 = num;
																				continue;
																		}
																		goto IL_03ba;
																	}
																case 3:
																	break;
																IL_03ba:
																	num = 0;
																	num2 = num;
																	continue;
															}
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator2).Dispose();
													}
													enumerator3 = requiredService.GetEnumerator();
													num = 4;
													num2 = num;
													continue;
												case 4:
													try
													{
														num = 2;
														num2 = num;
														while (true)
														{
															switch (num2)
															{
																case 2:
																	switch (0)
																	{
																		default:
																			continue;
																		case 0:
																			break;
																	}
																	goto default;
																case 0:
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
																							{
																								IOnPostApplicationInitialization obj3 = instance3 as IOnPostApplicationInitialization;
																								if (obj3 == null)
																								{
																									num = 2;
																									num2 = num;
																								}
																								else
																								{
																									obj3.OnPostApplicationInitialization(context);
																									num = 3;
																									num2 = num;
																								}
																								continue;
																							}
																						case 2:
																						case 3:
																							num = 1;
																							num2 = num;
																							continue;
																						case 1:
																							goto end_IL_06a4;
																					}
																					break;
																				}
																				goto case 0;
																			case 0:
																				instance3 = current3.Instance;
																				num = 0;
																				num2 = num;
																				goto default;
																		}
																	end_IL_06a4:;
																	}
																	catch (Exception ex3)
																	{
																		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 3);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("ꏯ௦풒\u034c춿\ue589ᮚ펾흘㽄\uf2d1", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(current3.Assembly.FullName);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("麽\ue1d5閖䂵變ꚸ\ueac9", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(current3.Type.AssemblyQualifiedName);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("蒽\ue0bf", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(ex3.Message);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("벍\ue0bf쮦랒⁎\u0eb9⮆ꎫ숲❄\u1082ᕚ厄ぇ\ud886\ue485\udced", a_));
																		throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear(), ex3);
																	}
																	num = 4;
																	num2 = num;
																	continue;
																default:
																	num = 5;
																	num2 = num;
																	continue;
																case 5:
																	if (enumerator3.MoveNext())
																	{
																		current3 = enumerator3.Current;
																		num = 0;
																		num2 = num;
																	}
																	else
																	{
																		num = 1;
																		num2 = num;
																	}
																	continue;
																case 1:
																	num = 3;
																	num2 = num;
																	continue;
																case 3:
																	break;
															}
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator3).Dispose();
													}
													enumerator4 = requiredService.GetEnumerator();
													num = 2;
													num2 = num;
													continue;
												case 1:
													try
													{
														num = 2;
														num2 = num;
														while (true)
														{
															switch (num2)
															{
																case 2:
																	switch (0)
																	{
																		default:
																			continue;
																		case 0:
																			break;
																	}
																	goto default;
																case 0:
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
																							{
																								IOnPreApplicationInitialization obj = instance as IOnPreApplicationInitialization;
																								if (obj != null)
																								{
																									obj.OnPreApplicationInitialization(context);
																									num = 2;
																									num2 = num;
																								}
																								else
																								{
																									num = 3;
																									num2 = num;
																								}
																								continue;
																							}
																						case 2:
																						case 3:
																							num = 1;
																							num2 = num;
																							continue;
																						case 1:
																							goto end_IL_08c7;
																					}
																					break;
																				}
																				goto case 0;
																			case 0:
																				instance = current.Instance;
																				num = 0;
																				num2 = num;
																				goto default;
																		}
																	end_IL_08c7:;
																	}
																	catch (Exception ex)
																	{
																		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 3);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("ꏯ௦풒\u034c춿\ue589ᮚ펾흘㽄\uf2d1", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(current.Assembly.FullName);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("麽\ue1d5閖䂵變ꚸ\ueac9", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(current.Type.AssemblyQualifiedName);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("蒽\ue0bf", a_));
																		defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
																		defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("벍\ue0bf쮦랒⁎\u0eb9⮆ꎫ숲❄\u1082ᕚ厄ぇ\ud886\ue485\udced", a_));
																		throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear(), ex);
																	}
																	num = 1;
																	num2 = num;
																	continue;
																default:
																	num = 4;
																	num2 = num;
																	continue;
																case 4:
																	if (enumerator.MoveNext())
																	{
																		current = enumerator.Current;
																		num = 0;
																		num2 = num;
																	}
																	else
																	{
																		num = 5;
																		num2 = num;
																	}
																	continue;
																case 5:
																	num = 3;
																	num2 = num;
																	continue;
																case 3:
																	break;
															}
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator).Dispose();
													}
													enumerator2 = requiredService.GetEnumerator();
													num = 0;
													num2 = num;
													continue;
												case 3:
													return;
											}
											break;
										}
										goto case 0;
									}
								case 0:
									{
										IServiceProvider serviceProvider = serviceScope.ServiceProvider;
										requiredService = base.ServiceProvider.GetRequiredService<List<IBtModuleDescriptor>>();
										context = new ApplicationInitializationContext(serviceProvider);
										context2 = new RouteBuilderContext(serviceProvider);
										enumerator = requiredService.GetEnumerator();
										num = 1;
										num2 = num;
										goto default;
									}
							}
						}
						finally
						{
							num = 0;
							num2 = num;
							while (true)
							{
								switch (num2)
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
										if (serviceScope != null)
										{
											num = 2;
											num2 = num;
											continue;
										}
										break;
									case 2:
										serviceScope.Dispose();
										num = 1;
										num2 = num;
										continue;
									case 1:
										break;
								}
								break;
							}
						}
					}
			}
		}
        }
}
