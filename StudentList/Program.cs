using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        class Teacher
        {
            public string name;
            public string major;
        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "함기훈", major="정보컴퓨터" });
            list.Add(new Teacher() { name = "박성래", major="수학" });
            list.Add(new Teacher() { name = "민주리", major="정보컴퓨터" });
            list.Add(new Teacher() { name = "박지우", major="정보컴퓨터" });
            list.Add(new Teacher() { name = "김보경", major="가정" });
            list.Add(new Teacher() { name = "장민주", major="디자인" });


            for(int i=0; i<list.Count; i++)
            {
                if(list[i].major == "정보컴퓨터")
                {
                    list.RemoveAt(i);
                }
            }


            foreach(var item in list)
            {
                if (item.major == "정보컴퓨터")
                {
                    list.Remove(item);
                }
                //Console.WriteLine(item.name + " : "+ item.major);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : "+ item.major);
            }
        }
    }
}
