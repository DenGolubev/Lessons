using System;
using System.Collections.Generic;


namespace Lesson_5
{
    class ToDo
    {
        
        private static string PathName { get;} = AppContext.BaseDirectory;
        TaskList taskList = new TaskList();
        MyList myList = new MyList();
        public void ToDoMyList()
        {
            myList.MyListToDo();
        }

        
    }
}
