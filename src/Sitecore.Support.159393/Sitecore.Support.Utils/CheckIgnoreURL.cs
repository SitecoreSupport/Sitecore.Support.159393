using Sitecore.Configuration;
using System;

namespace Sitecore.Support.Utils
{
	public static class CheckIgnoreURL
	{
		public static bool Check(string url)
		{
			string setting = Settings.GetSetting("AbsoluteIgnoreUrlPrefixes");
			if (!string.IsNullOrEmpty(setting))
			{
				string[] array = setting.Split(new char[]
				{
					'|'
				});
				if (array.Length > 0)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (url.StartsWith(array[i], StringComparison.OrdinalIgnoreCase))
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
