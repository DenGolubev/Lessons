using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class ToDo
    {
        string Title { get; set; } = null;
        bool IsDone { get; set; } = false;
        public ToDo(string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }
        MyArrayList arrayList = new MyArrayList();

        public void EnterTask()
        {
            arrayList.AddArrayList(Title, IsDone);
        }

    }
}
