using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    public class ObjectAccessor<T>: IObjectAccessor<T>	
    {
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value { get; set; }

		public ObjectAccessor()
		{
		}

		public ObjectAccessor(T obj)
		{
			Value = obj;
		}
	}
}
