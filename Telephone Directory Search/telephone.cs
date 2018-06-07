using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Telephone_Directory_Search
{
	public class telephone : TelephoneDirectoryInterface 
	{
		static ArrayList tel_book_arr = new ArrayList();
		public string name,tel,address,occupation,ConnDate;
		public string path = @"A:\\Telephone Directory Search\\Telephone Directory Search\\directory.txt";
		public void enter_info()
		{
			Console.Clear();

			telephone t = new telephone();

			Console.Write("enter name : ");
			t.name = Console.ReadLine();

			Console.Write("enter tel : ");
			t.tel = Console.ReadLine();

			Console.Write("enter Address : ");
			t.address = Console.ReadLine();

			Console.Write("enter Occupation : ");
			t.occupation = Console.ReadLine();

			Console.Write("enter Connection Date : ");
			t.ConnDate = Console.ReadLine();

			tel_book_arr.Add(t);
			AppendText(tel_book_arr);
		}

		public  void show_info()
		{
			Console.Clear();
			
			using (StreamReader sr = File.OpenText(path))
			{
				string s = "";
				while ((s = sr.ReadLine()) != null)
				{
					Console.WriteLine(s);
				}
				Console.ReadKey();
			}

		}

		public void search_ifo()
		{
			Console.Clear();
			Console.Write("Enter the phone number\name to search:");
			string name = Console.ReadLine();
            fetch_details(name);
            Console.ReadKey();

        }
        public string fetch_details(string search)
        {
            string s = "",result="";
            using (StreamReader sr = File.OpenText(path))
            {
                
                while ((s = sr.ReadLine()) != null)
                {

                    if (s.IndexOf(search, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        Console.WriteLine(s);
                        result = s;
                    }
                   /* else
                    {
                        throw new ArgumentNullException();
                        return null;
                    }*/
                }
                
            }
            return result;
        }
		public void edit_info()
		{
			Console.Clear();
			delet_ifo();
			enter_info();
		}
        public void delet_ifo()
        {
            Console.Clear();
            
            Console.Write("Enter the phone Number/Name to edit:");
            string name = Console.ReadLine();
            //string path = @"E:\telDirectory.txt";
            // Open the file to read from.
            deleteinfo(name);
            Console.ReadKey();
        }
        public string deleteinfo(string name)
        {
            string tempFile = Path.GetTempFileName();
            using (StreamReader sr = File.OpenText(path))
			{
				string s = "";
				//
				while ((s = sr.ReadLine()) != null)
				{

					if (s.IndexOf(name, StringComparison.CurrentCultureIgnoreCase) == -1)
					{

						Console.WriteLine(s);
						using (StreamWriter sw = new StreamWriter(tempFile))
						{
							
							sw.WriteLine(s);
							
						}
						
					}
				}
				
			}
			Console.WriteLine("Contact(s) deleted successfully");
			File.Delete(path);
		    File.Move(tempFile, path);
            
            return null ;
			
		}
		public int AppendText(ArrayList lst)
		{
			string contactInfo = "";
			foreach (telephone obj in lst)
			{
				string s = obj.name + "\t" + obj.tel + "\t" + obj.address + "\t" + obj.occupation + "\t" + obj.ConnDate;
				// loop body
				contactInfo = s;
			}
			
		


			using (StreamWriter sw = File.AppendText(path))
			{
				sw.WriteLine(contactInfo);

			}
            return 0;

		}
	}
}
