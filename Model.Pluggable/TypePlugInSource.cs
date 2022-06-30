using Bt.core.Collections;


namespace Bt.core.Model.Pluggable
{
    public class TypePlugInSource : IPlugInSource
    {
        private readonly TypeList<IBtModule> _modules;

        public TypePlugInSource(params Type[] moduleTypes)
        {
            TypeList<IBtModule> source=new TypeList<IBtModule>();
                foreach (Type type in moduleTypes)
			{
				if (type.IsModule())
				{
					source.AddIfNotContains(type);

				}
			}
				_modules = source;

        }
        public TypeList<IBtModule> GetModules()
        {
			short num = 21205;
			short num2 = num;
			num = 21205;
			switch (num2 == num)
			{
				default:
					num = 0;
					_ = num;
					num = 1;
					if (num != 0)
					{
					}
					num = 0;
					if (num != 0)
					{
					}
					return _modules;
				case false:
				case true:
					{
						TypeList<IBtModule> result = default(TypeList<IBtModule>);
						return result;
					}
			}
			}
    }
}
