using Bt.core.Collections;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model.Pluggable
{
    public class FolderPlugInSource : IPlugInSource
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly string _folder;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly SearchOption _searchOption;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private Func<string,bool> _filter;
         public string Folder
        {
            get { return _folder; }
        }
        public SearchOption SearchOption
        {
            get { return _searchOption; }
        }
        public Func<string,bool> Filter
        {
            get { return _filter; }
        }
        public FolderPlugInSource(string folder,SearchOption searchOption)
        {
			this._folder = folder;
			this._searchOption = searchOption;
        }

		/// <summary>
		/// 筛选过滤获取程序集集合
		/// </summary>
		/// <returns></returns>
		private List<Assembly> AssemblyList()
        {
			int a_ = 15;
			short num = 24874;
			short num2 = num;
			num = 24874;
			int num3 = default(int);
			IEnumerable<string> source = default(IEnumerable<string>);
			bool flag = default(bool);
			List<Assembly> result = default(List<Assembly>);
			switch (num2 == num)
			{
				default:
					num = 0;
					if (num != 0)
					{
					}
					switch (0)
					{
						case 0:
							goto IL_0077;
					}
					goto IL_005d;
				case false:
				case true:
					goto IL_0196;
				IL_0077:
					num = 2;
					num3 = num;
					goto IL_005d;
				IL_005d:
					while (true)
					{
						switch (num3)
						{
							case 2:
								source = Directory.EnumerateFiles(Folder, ServiceCollectionRegistrationActionExtensions.b("\uefc4\ue9c6\ue3c8", a_), SearchOption).Where(delegate (string A_0)
								{
									
									int a_2 = 3;
									while (true)
									{
										short num4 = 0;
										_ = num4;
										num4 = 1;
										int num5 = num4;
										while (true)
										{
											int result2;
											switch (num5)
											{
												case 1:
													switch (0)
													{
														default:
															continue;
														case 0:
															break;
													}
													goto default;
												default:
													if (!A_0.EndsWith(ServiceCollectionRegistrationActionExtensions.b("鞸\udfba톼펾", a_2)))
													{
														num4 = 0;
														num5 = num4;
													}
													else
													{
														num4 = 2;
														num5 = num4;
													}
													continue;
												case 2:
													num4 = 1;
													if (num4 != 0)
													{
													}
													result2 = 1;
													goto IL_014a;
												case 0:
													break;
												case 3:
													{
														result2 = (A_0.EndsWith(ServiceCollectionRegistrationActionExtensions.b("鞸\udeba얼\udabe", a_2)) ? 1 : 0);
														goto IL_014a;
													}
												IL_014a:
													return (byte)result2 != 0;
											}
											num4 = 11327;
											short num6 = num4;
											num4 = 11327;
											switch (num6 == num4)
											{
												case false:
												case true:
													break;
												default:
													num4 = 0;
													if (num4 != 0)
													{
													}
													num4 = 3;
													num5 = num4;
													continue;
											}
											break;
										}
									}
								});
								flag = Filter != null;
								num = 1;
								num3 = num;
								continue;
							case 3:
								source = source.Where(Filter);
								num = 0;
								_ = num;
								num = 0;
								num3 = num;
								continue;
							case 1:
								num = 1;
								if (num != 0)
								{
								}
								if (flag)
								{
									num = 3;
									num3 = num;
									continue;
								}
								goto IL_0196;
							case 0:
								goto IL_0196;
							case 4:
								return result;
						}
						break;
					}
					goto IL_0077;
				IL_0196:
					result = source.Select(new Func<string, Assembly>(AssemblyLoadContext.Default.LoadFromAssemblyPath)).ToList();
					num = 4;
					num3 = num;
					goto IL_005d;
			}
			}
		//从程序集中获取模块集合
        public TypeList<IBtModule> GetModules()
        {
			int a_ = 13;
			short num = 0;
			switch (num)
			{
				default:
					{
						num = 1;
						if (num != 0)
						{
						}
						TypeList<IBtModule> typeList = new TypeList<IBtModule>();
                        using (List<Assembly>.Enumerator enumerator = AssemblyList().GetEnumerator())
						{
							Assembly current = default(Assembly);
							bool flag = default(bool);
							int num3 = default(int);
							Type[] types = default(Type[]);
							Type type = default(Type);
							while (true)
							{
								num = 5;
								int num2 = num;
								while (true)
								{
									switch (num2)
									{
										case 2:
											goto end_IL_0097;
										case 5:
											switch (0)
											{
												default:
													continue;
												case 0:
													break;
											}
											goto default;
										default:
											{
												num = -5015;
												short num4 = num;
												num = -5015;
												switch (num4 == num)
												{
													case false:
													case true:
														break;
													default:
														goto IL_010c;
												}
												break;
											}
										case 0:
											num = 4;
											num2 = num;
											continue;
										case 4:
											if (!enumerator.MoveNext())
											{
												num = 3;
												num2 = num;
											}
											else
											{
												current = enumerator.Current;
												num = 1;
												num2 = num;
											}
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
																case 4:
																	if (flag)
																	{
																		num = 6;
																		num2 = num;
																		continue;
																	}
																	goto case 0;
																case 3:
																case 7:
																	num = 1;
																	num2 = num;
																	continue;
																case 1:
																	if (num3 < types.Length)
																	{
																		type = types[num3];
																		flag = type.IsModule();
																		num = 4;
																		num2 = num;
																	}
																	else
																	{
																		num = 5;
																		num2 = num;
																	}
																	continue;
																case 0:
																	num3++;
																	num = 3;
																	num2 = num;
																	continue;
																case 6:
																	typeList.AddIfNotContains(type);
																	num = 0;
																	num2 = num;
																	continue;
																case 5:
																	num = 2;
																	num2 = num;
																	continue;
																case 2:
																	goto end_IL_01a4;
															}
															break;
														}
														goto case 0;
													case 0:
														types = current.GetTypes();
														num3 = 0;
														num = 7;
														num2 = num;
														goto default;
												}
											end_IL_01a4:;
											}
											catch (Exception)
											{
												throw new Exception(ServiceCollectionRegistrationActionExtensions.b("캌㡄ঈ슲䒔\u0b5a", a_) + current.FullName + ServiceCollectionRegistrationActionExtensions.b("\uee8c片備\ue8a2鲝", a_));
											}
											num = 0;
											num2 = num;
											continue;
										case 3:
											{
												num = 2;
												num2 = num;
												continue;
											}
										IL_010c:
											num = 0;
											if (num == 0)
											{
											}
											goto case 0;
									}
									break;
								}
							}
						end_IL_0097:;
						}
						num = 0;
						_ = num;
						return typeList;
					}
			}
		}
    }
}
