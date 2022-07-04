using Bt;
using Bt.core.Http.Cilent;
using Bt.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionConventionalRegistrationExtensions
    {
        [CompilerGenerated]
        private sealed class TargetType
        {
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
            public Type Type;
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。

            internal bool IsTargetType(Type A_0)
            {
                int result;
                if (A_0 != Type)
                {
                    result = (Type.IsAssignableFrom(A_0) ? 1 : 0);
                }
                result = 0;
                return (byte)result != 0;

            }
        }
        public static void AddTypes(this IServiceCollection services, Assembly assembly)
        {
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
            Type[] array = default(Type[]);
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
            int num4 = default(int);
            Type[] array2 = assembly.GetTypes().Where(delegate (Type A_0)
            {
                int result;
             
                if (A_0 != null)
                {
                    if (A_0.IsClass)
                    {
                        if (!A_0.IsAbstract)
                        {
                            result = ((!A_0.IsGenericType) ? 1 : 0);

                        }

                    }
                 }
                result = 0;

                return (byte)result != 0;
            }).ToArray();
            array = array2;
            IL0523:
            if (num4 < array.Length)
            {
                Type a_ = array[num4];
                AddService(services, a_);
                num4++;
                goto IL0523;
            }
            else
            {
                return;
            }
        }

        public static void AddAssemblyOf<T>(this IServiceCollection services)
        {
            services.AddTypes(typeof(T).Assembly);

        }
        private static void AddService(IServiceCollection A_0, Type A_1)
        {
            int a_ = 7;

            ServiceLifetime? serviceLifetime2 = default(ServiceLifetime?);
            ServiceLifetime? serviceLifetime5 = default(ServiceLifetime?);
            Bt.DependencyAttribute dependencyAttribute = default(Bt.DependencyAttribute);
            dependencyAttribute = GetDependencyAttributeᜁ(A_1);
            serviceLifetime5 = A_1.GetLifeTimeOrNull();
            serviceLifetime2 = serviceLifetime5;
            bool flag2 = default(bool);
            string text = default(string);
            int num3 = default(int);
            Type[] interfaces = default(Type[]);
            Type type = default(Type);
            bool flag = default(bool);
            ServiceLifetime? serviceLifetime3 = default(ServiceLifetime?);
            List<Type> list = default(List<Type>);
            Type current = default(Type);
            bool flag6 = default(bool);
            bool flag5 = default(bool);
            List<Type>.Enumerator enumerator = default(List<Type>.Enumerator);
            ServiceDescriptor serviceDescriptor = default(ServiceDescriptor);
            bool flag4 = default(bool);
            bool flag3 = default(bool);
            ServiceLifetime? serviceLifetime;
            ServiceLifetime? serviceLifetime4;
            if (!serviceLifetime2.HasValue)
            {
                if (A_1.GetCustomAttribute(typeof(RemoteServicerAttribute), inherit: true) == null)
                {
                    serviceLifetime3 = null;
                    serviceLifetime = serviceLifetime3;
                }
                else
                {
                    serviceLifetime = ServiceLifetime.Transient;
                }
                serviceLifetime5 = serviceLifetime;
                serviceLifetime2 = serviceLifetime5;
                if (!serviceLifetime2.HasValue)
                {
                    if (!(A_1.BaseType!.FullName == ServiceCollectionRegistrationActionExtensions.b("ﲼ쪾뗀곂裄ꛆ마믊\ua8cc뷎\uffd0菒\ua7d4룖뿘닚뇜뫞", a_)))
                    {
                        serviceLifetime3 = null;
                        serviceLifetime4 = serviceLifetime3;
                        serviceLifetime5 = serviceLifetime4;
                        flag3 = !serviceLifetime5.HasValue;
                    }
                    else
                    {
                        serviceLifetime4 = ServiceLifetime.Transient;
                        serviceLifetime5 = serviceLifetime4;
                        flag3 = !serviceLifetime5.HasValue;
                    }
                        if (!flag3)
                        {
                            list = new List<Type>();
                            list.Add(A_1);
                            interfaces = A_1.GetTypeInfo().GetInterfaces();
                            num3 = 0;
                            
                            while (num3 < interfaces.Length)
                            {
                                type = interfaces[num3];
                                text = type.Name;
                                flag = text.StartsWith(ServiceCollectionRegistrationActionExtensions.b("\uf4bc", a_));
                                if (flag)
                                {
                                    string text2 = text;
                                    text = text2.Substring(1, text2.Length - 1);
                                    flag2 = A_1.Name.EndsWith(text);
                                    if (flag2)
                                    {
                                        list.Add(type);
                                        num3++;

                                    }
                                }
                            }
                            enumerator = list.GetEnumerator();
                            try
                            {
                                int num5;
                                int num4;
                                while (enumerator.MoveNext())
                                {
                                    current = enumerator.Current;
                                    serviceDescriptor = null;
                                    serviceDescriptor = ServiceDescriptor.Describe(current, A_1, serviceLifetime5.Value);
                                    flag4 = serviceDescriptor != null;
                                    
                                    if (flag4)
                                    {
                                        if (dependencyAttribute != null)
                                        {
                                            if (!dependencyAttribute.IsTryAddServices)
                                            {
                                                num4 = ((current.GetCustomAttribute<HttpClientServicerAttribute>() != null) ? 1 : 0);
                                            }
                                            else
                                            {
                                                num4 = 1;
                                            }
                                            flag5 = (byte)num4 != 0;
                                            if (flag5)
                                            {
                                                A_0.TryAdd(serviceDescriptor);
                                            }
                                            else
                                            {
                                                if (dependencyAttribute != null)
                                                {
                                                    num5 = (dependencyAttribute.IsReplaceServices ? 1 : 0);
                                                }
                                                else
                                                {
                                                    num5 = 0;
                                                }
                                                flag6 = (byte)num5 != 0;
                                                if (!flag6)
                                                {
                                                    A_0.Add(serviceDescriptor);
                                                }
                                                else
                                                {
                                                    A_0.Replace(serviceDescriptor);
                                                }
                                                }

                                            }
                                        }
                                    }
                            }
                    finally 
                    {
                        enumerator.Dispose();
                    }
                     }
                  }
              }


        }
        private static Bt.DependencyAttribute GetDependencyAttributeᜁ(Type A_0)
        {
            Bt.DependencyAttribute dependencyAttribute=A_0.GetCustomAttribute<Bt.DependencyAttribute>(inherit:true);
            return dependencyAttribute;
        }
        private static Type GetTargetType(Type A_0, Type A_1, List<Type> A_2)
        {
            bool flag3 = default(bool);
            TargetType targetType = default(TargetType);
            targetType=new TargetType();
            targetType.Type= A_1;
            flag3 = A_2.Count < 2;
            bool flag2 = default(bool);
            Type result = default(Type);
            bool flag = default(bool);
            if (flag3)
            {
                result = null;

            }
            else
            {
                flag2 = targetType.Type == A_0;
                if (flag2)
                {
                    result = null;
                }
                else
                {
                    flag = A_2.Contains(A_0);
                    if (!flag)
                    {
                        result = A_2.FirstOrDefault(new Func<Type, bool>(targetType.IsTargetType));
                    }
                    else
                    {
                        result = A_0;

                    }
                  }
               }
            return result;
            }
        public static ServiceLifetime? GetLifeTimeOrNull(this Type type)
        {
            ServiceLifetime? result = GetLifeTime(type);
            return result;
        }
        private static ServiceLifetime? GetLifeTime(Type A_0)
        {
            ServiceLifetime? result = default(ServiceLifetime?);
            bool flag3 = default(bool);
            bool flag2 = default(bool);
            bool flag = default(bool);
            int num3;
            int num4;
            int num5;
            if (!typeof(ITransientDependency).GetTypeInfo().IsAssignableFrom(A_0))
            {
                num5 = ((A_0.GetCustomAttributes<TransientDependencyAttribute>().Count() > 0) ? 1 : 0);
            }
            else {
                num5 = 1;
            }
            flag3 = (byte)num5 != 0;
            if (!flag3)
            {
                if (!typeof(ISingletonDependency).GetTypeInfo().IsAssignableFrom(A_0))
                {
                    num3 = ((A_0.GetCustomAttributes<SingletonDependencyAttribute>().Count() > 0) ? 1 : 0);
                }
                else
                {
                    num3 = 1;
                }
                 flag2 = (byte)num3 != 0;
                    if (flag2)
                    {
                        result = ServiceLifetime.Singleton;
                    }
                    else
                    {
                        if (typeof(IScopedDependency).GetTypeInfo().IsAssignableFrom(A_0))
                        {
                            num4 = 1;
                        }
                        else
                        {
                        num4 = ((A_0.GetCustomAttributes<ScopedDependencyAttribute>().Count() > 0) ? 1 : 0);
                        }
                         flag = (byte)num4 != 0;
                        if (!flag)
                        {
                            result = null;
                        }
                        else
                        {
                        result = ServiceLifetime.Scoped;
                        }
                }
                }
            else
            {
                result = ServiceLifetime.Transient;
            }
           return result;

        }
        }
    }
