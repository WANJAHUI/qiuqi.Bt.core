using Bt.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace Bt.DependencyInjection
{
    public class ExposeServicesAttribute : Attribute, IExposeServicesAttribute
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Type[] _serviceTypes;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool _includeDefault;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool _includeself;
        public Type[] ServiceTypes { get { return _serviceTypes; } set { this._serviceTypes = value; } }
        public bool IncludeDefault { get { return _includeDefault; } set { _includeDefault = value; } }
        public bool IncludeSelf { get { return _includeself; } set { _includeself = value; } }

        public ExposeServicesAttribute(params Type[] serviceTypes)
        {
            ServiceTypes = serviceTypes ?? Array.Empty<Type>();
        }
        public Type[] GetExposedServiceTypes(Type targetType)
        {
            List<Type> list = default(List<Type>);
            bool includeSelf = default(bool);
            bool includeDefaults = default(bool);
            list = ServiceTypes.ToList();
            includeDefaults = IncludeDefault;
            bool includeSelf2 = default(bool);
            List<Type>.Enumerator enumerator = default(List<Type>.Enumerator);
            Type[] result = default(Type[]);
            if (includeDefaults)
            {
                enumerator = GetImpl(targetType).GetEnumerator();
                try
                {

                    while (enumerator.MoveNext())
                    {
                        Type current = enumerator.Current;
                        list.AddIfNotContains(current);

                    }
                }
                finally
                {
                    ((IDisposable)enumerator).Dispose();
                }
                includeSelf = IncludeSelf;
            }
            else
            {
                includeSelf2 = IncludeSelf;
                
            }
            if (includeSelf2)
            {
                list.AddIfNotContains(targetType);
                goto IL_0532;

            }
            if (includeSelf)
            {
                list.AddIfNotContains(targetType);
            }
            IL_0532:
            result = list.ToArray();
            return result;
            
        }

        private static List<Type>GetImpl(Type A_0)
        {
            int a_ = 9;
            List<Type> list = default(List<Type>);
            int num4 = default(int);
            Type[] interfaces = default(Type[]);
            list = new List<Type>();
            interfaces = A_0.GetTypeInfo().GetInterfaces();
            List<Type> result = default(List<Type>);
            Type type = default(Type);
            bool flag = default(bool);
            string text = default(string);
            bool flag2 = default(bool);
            string text2;

            IL_05:
                if (num4 < interfaces.Length)
                {
                    type = interfaces[num4];
                    text = type.Name;
                    flag2 = text.StartsWith(ServiceCollectionRegistrationActionExtensions.b("\uf6be", a_));

                    if (flag2)
                    {
                        text2 = text;
                        text = text2.Substring(1, text2.Length - 1);
                       
                    }
                    flag = A_0.Name.EndsWith(text);
                }
                result= list;
            if (flag)
            {
                list.Add(type);
                num4++;
                goto IL_05;
            }
            return result;
        }
        }
}
