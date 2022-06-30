using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public  class ModuleOnAttribute : Attribute ,IReliedModuleTypes
    {
		public Type[] ReliedModuleTypes { get; }

		public ModuleOnAttribute(params Type[] reliedModuleTypes)
		{
			if (reliedModuleTypes.IsNullOrEmpty())
			{
				throw new Exception("reliedModuleTypes不能为空");
			}
			ReliedModuleTypes = reliedModuleTypes ?? new Type[0];
		}

		public virtual Type[] GetReliedModuleTypes()
		{
			return ReliedModuleTypes;
		}
	}
}
