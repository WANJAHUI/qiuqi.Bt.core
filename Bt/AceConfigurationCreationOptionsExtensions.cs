using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public static class AceConfigurationCreationOptionsExtensions
    {
		public static BtFrameworkCreateOptions AddJsonFile(this BtFrameworkCreateOptions options, IFileProvider provider, string path, bool optional, bool reloadOnChange)
		{
			options.BtConfigurationBuilderOptions.JsonFileOptionsList.Add(new JsonFileOptions
			{
				FileProvider = provider,
				Path = path,
				Optional = optional,
				ReloadOnChange = reloadOnChange
			});
			return options;
		}
		public static BtFrameworkCreateOptions AddJsonFile(this BtFrameworkCreateOptions options, string path)
		{
			options.BtConfigurationBuilderOptions.JsonFileOptionsList.Add(new JsonFileOptions
			{
				Path = path
			});
			return options;
		}
		public static BtFrameworkCreateOptions AddJsonFile(this BtFrameworkCreateOptions options, string path, bool optional)
		{
			options.BtConfigurationBuilderOptions.JsonFileOptionsList.Add(new JsonFileOptions
			{
				Path = path,
				Optional = optional
			});
			return options;
		}
		public static BtFrameworkCreateOptions AddJsonFile(this BtFrameworkCreateOptions options, string path, bool optional, bool reloadOnChange)
		{
			options.BtConfigurationBuilderOptions.JsonFileOptionsList.Add(new JsonFileOptions
			{
				Path = path,
				Optional = optional,
				ReloadOnChange = reloadOnChange
			});
			return options;

		}
		}
}
