using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.DependencyInjection
{
    public  interface IBtLazyServiceProvider
    {
		T LazyGetRequiredService<T>();

		object LazyGetRequiredService(Type serviceType);

		T LazyGetService<T>();

		object LazyGetService(Type serviceType);

		T LazyGetService<T>(Func<IServiceProvider, object> factory);

		object LazyGetService(Type serviceType, Func<IServiceProvider, object> factory);
	}
}
