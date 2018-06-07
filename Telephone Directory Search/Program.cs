using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_Directory_Search
{
	public class Program
	{
		

		static void Main(string[] args)
		{
            int sel = 0;
            string path = @"A:\\Telephone Directory Search\\Telephone Directory Search\\directory.txt";
			if (!File.Exists(path))
			{
				using (StreamWriter sw = File.CreateText(path))
				{
					sw.WriteLine("Name\tNumber\tAddress\tOcupation\tConnection Date");
				}
			}
            
            Program p = new Program();
            p.ReadInput(sel);

        }
        public int ReadInput(int choice)
        {
            telephone t = new telephone();
            int sel = choice;

            while (sel <= 6)
            {

                Console.Clear();
                Console.WriteLine("1 : enter information");
                Console.WriteLine("2 : display information");
                Console.WriteLine("3 : search information");
                Console.WriteLine("4 : edit information");
                Console.WriteLine("5 : delete information");
                Console.WriteLine("6 : exit");

                Console.Write("\nenter your choose : ");

                sel = Convert.ToInt32(Console.ReadLine());
                if(sel > 6 || sel<= 0 )
                {
                    throw new ArgumentException();
                }
                    switch (sel)
                {
                    case 1:
                        t.enter_info();

                        break;
                    case 2:
                        t.show_info();
                        break;
                    case 3:
                        t.search_ifo();
                        break;
                    case 4:
                        t.edit_info();
                        break;
                    case 5:
                        t.delet_ifo();
                        break;
                }
            }
            return 0;
        }
	}
}
