using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_Directory_Search
{
	public interface TelephoneDirectoryInterface
	{
		void enter_info();
		void show_info();
		void search_ifo();
		void edit_info();
		void delet_ifo();
		int AppendText(ArrayList lst);
	}
}
