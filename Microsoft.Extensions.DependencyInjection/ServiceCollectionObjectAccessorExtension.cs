
using Bt.core.Model;

namespace Microsoft.Extensions.DependencyInjection
{
	// Microsoft.Extensions.DependencyInjection.ServiceCollectionObjectAccessorExtensions
	public static class ServiceCollectionObjectAccessorExtension
    {
        public static ObjectAccessor<T> TryAddObjectAccessor<T>(this IServiceCollection services)
        {
			int num = default(int);
			switch (0)
			{
				default:
					{
						bool flag = default(bool);
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
						ObjectAccessor<T> result = default(ObjectAccessor<T>);
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
						while (true)
						{
							short num2;
							switch (num)
							{
								case 3:
									flag = services.Any(delegate (ServiceDescriptor A_0)
									{
										
										short num4 = 29881;
										short num5 = num4;
										num4 = 29881;
										switch (num5 == num4)
										{
											default:
												num4 = 0;
												_ = num4;
												num4 = 0;
												if (num4 != 0)
												{
												}
												num4 = 1;
												if (num4 != 0)
												{
												}
												return A_0.ServiceType == typeof(ObjectAccessor<T>);
										}
									});
									goto IL_0084;
								case 2:
									result = services.GetSingletonInstance<ObjectAccessor<T>>();
									num2 = 1;
									num = num2;
									continue;
								case 0:
									{
										num2 = -6546;
										short num3 = num2;
										num2 = -6546;
										switch (num3 == num2)
										{
											case false:
											case true:
												break;
											default:
												num2 = 1;
												if (num2 != 0)
												{
												}
												num2 = 0;
												if (num2 != 0)
												{
												}
												if (flag)
												{
													num2 = 2;
													num = num2;
												}
												else
												{
													result = services.AddObjectAccessor<T>();
													num2 = 4;
													num = num2;
												}
												continue;
										}
										goto IL_0084;
									}
								case 1:
								case 4:
									{
#pragma warning disable CS8603 // 可能返回 null 引用。
										return result;
#pragma warning restore CS8603 // 可能返回 null 引用。
									}
								IL_0084:
									num2 = 0;
									_ = num2;
									num2 = 0;
									num = num2;
									continue;
							}
							break;
						}
						goto case 0;
					}
				case 0:
					{
						short num2 = 3;
						num = num2;
						goto default;
					}
			}
		}
		public static ObjectAccessor<T> AddObjectAccessor<T>(this IServiceCollection services)
		{
			short num = 23098;
			short num2 = num;
			num = 23098;
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
					return services.AddObjectAccessor(new ObjectAccessor<T>());
				case false:
				case true:
					{
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
						ObjectAccessor<T> result = default(ObjectAccessor<T>);
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
#pragma warning disable CS8603 // 可能返回 null 引用。
						return result;
#pragma warning restore CS8603 // 可能返回 null 引用。
					}
			}
		}
		public static ObjectAccessor<T> AddObjectAccessor<T>(this IServiceCollection services, T obj)
		{
			//Discarded unreachable code: IL_004c, IL_0085
			short num = -6656;
			short num2 = num;
			num = -6656;
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
					return services.AddObjectAccessor(new ObjectAccessor<T>(obj));
				case false:
				case true:
					{
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
						ObjectAccessor<T> result = default(ObjectAccessor<T>);
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
						return result;
					}
			}
		}
		public static ObjectAccessor<T> AddObjectAccessor<T>(this IServiceCollection services, ObjectAccessor<T> accessor)
        {
			int a_ = 8;
			bool flag = default(bool);
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
			ObjectAccessor<T> result = default(ObjectAccessor<T>);
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
			flag = services.Any(delegate (ServiceDescriptor A_0)
			{
				return A_0.ServiceType == typeof(ObjectAccessor<T>);
			});
            if (!flag)
            {
				try
				{
					services.Insert(0, ServiceDescriptor.Singleton(typeof(ObjectAccessor<T>), accessor));
					services.Insert(0, ServiceDescriptor.Singleton(typeof(IObjectAccessor<T>), accessor));
				}
				catch (Exception)
				{
					result = accessor;
				}
				result = accessor;
				return result;
            }
            else
            {
			   
				throw new Exception(ServiceCollectionRegistrationActionExtensions.b("䟦ꄳ絊⩖꺓\ue090놵䞜薃鶝₌㲿媄숨", a_) + typeof(T).AssemblyQualifiedName);
			}

			}
		public static T GetObjectOrNull<T>(this IServiceCollection services) where T : class
		{
			T val = default(T);
			T result = default(T);
			T val2;
			IObjectAccessor<T> singletonInstanceOrNull = services.GetSingletonInstanceOrNull<IObjectAccessor<T>>();
			if (singletonInstanceOrNull == null)
            {
				val = null;
				val2 = val;
			}
            else
            {
				val2 = singletonInstanceOrNull.Value;
			}
			result=val2;
			return result;

		}
		public static T GetObject<T>(this IServiceCollection services) where T : class
		{
			int a_ = 10;
			short num = -5128;
			short num2 = num;
			num = -5128;
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
					return services.GetObjectOrNull<T>() ?? throw new Exception(ServiceCollectionRegistrationActionExtensions.b("\ue8e8쾦斑\ue6c5", a_) + typeof(T).AssemblyQualifiedName + ServiceCollectionRegistrationActionExtensions.b("\ue0bf\uef8f몡쮋\uf895亿㖐꽁틿\uf2d1⍘뢭\u0598犹㦕鎏龐쪔⍬\ua7e5賧軩ꏫ賭髯韱音苵맷駹\u9ffb鯽珿焁欃琅৸", a_));
				case false:
				case true:
					{
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
						T result = default(T);
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
						return result;
					}
			}

		}
	}
}
