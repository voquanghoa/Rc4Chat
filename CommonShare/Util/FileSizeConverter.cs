using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonShare.Util
{
	public class FileSizeConverter
	{
		private static string[] SizeUnit = new[] { "byte", "Kb", "Mb", "Gb" };
		public static string ConvertToString(long size)
		{
			var unit = 0;
			var sizeDouble = (double)size;
			while (sizeDouble > 1024)
			{
				unit++;
				sizeDouble /= 1024;
			}
			return string.Format("{0} {1}", Math.Round(sizeDouble, 1), SizeUnit[unit]);
		}
	}
}
