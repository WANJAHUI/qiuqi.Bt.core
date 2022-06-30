using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

namespace Bt.core.Collections
{
    public class TypeList<TBaseType> : ITypeList<TBaseType>, IList<Type>, ICollection<Type>, IEnumerable<Type>, IEnumerable
    {
        private readonly List<Type> _types;  
        public  int Count { get { return _types.Count; } }
        public bool IsReadOnly { get { return false; } }
        public Type this[int index]
        {
            get
            {
                return this._types[index];
            }
            set
            {
                this._types[index] = value;
            }

        }
        public TypeList()
        {
            this._types = new List<Type>();
        }
        public void Add<T>() where T : TBaseType
        {
            this._types.Add(typeof(T));
        }

        public bool TryAdd<T>() where T : TBaseType
        {
            Add<T>();
            return true;

        }
        public void Add(Type item)
        {
            this._types.Add(item);
        }
        public void Insert(int index, Type item)
        {
            this._types.Insert(index, item);

        }
        public int IndexOf(Type item)
        {
            return this._types.IndexOf(item);
        }
        public void Clear()
        {
           this._types.Clear();
        }

        public bool Contains<T>() where T : TBaseType
        {
            return Contains(typeof(T));
        }

        public bool Contains(Type item)
        {
          return  this._types.Contains(item);
        }

        public void CopyTo(Type[] array, int arrayIndex)
        {
           this._types.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Type> GetEnumerator()
        {
            return this._types.GetEnumerator();
            
        }

        public void Remove<T>() where T : TBaseType
        {
            this._types.Remove(typeof(T));
        }

        public bool Remove(Type item)
        {
           return this._types.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this._types.RemoveAt(index);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._types.GetEnumerator();
        }
        private static void InterpolatedStringHandler(Type A_0)
        {
            int a_ = 16;
            while (!typeof(TBaseType).GetTypeInfo().IsAssignableFrom(A_0))
            {
                DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
                defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("臅ꇇ볉꧋ꃍ\uf0cfꛑ귓ꛕ뷗龎\uf4db", a_));
                defaultInterpolatedStringHandler.AppendFormatted(A_0.AssemblyQualifiedName);
                defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("\uefc5\ue8c7막\ua4cbꇍꗏ뻑냓\uf6d5뫗뿙ﳛ럝軟釡郣蟥蛧觩觫컭\u9fef铱퓳", a_));
                defaultInterpolatedStringHandler.AppendFormatted(typeof(TBaseType).AssemblyQualifiedName);
                defaultInterpolatedStringHandler.AppendLiteral(ServiceCollectionRegistrationActionExtensions.b("\ue6c5", a_));
                throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear(), ServiceCollectionRegistrationActionExtensions.b("꿅볇꿉ꇋ", a_));
            }
        }
    }
}
