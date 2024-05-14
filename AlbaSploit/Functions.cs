using System;
using System.IO;
using System.Windows.Forms;

namespace Executor
{
	// Token: 0x02000003 RID: 3
	internal class Functions
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003500 File Offset: 0x00001700
		public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			DirectoryInfo dinfo = new DirectoryInfo(Folder);
			FileInfo[] Files = dinfo.GetFiles(FileType);
			foreach (FileInfo file in Files)
			{
				lsb.Items.Add(file.Name);
			}
		}
	}
}
