using NewSysAcadApp.src.main.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadApp.src.main.sysacad
{
    public class SysAcadApp
    {
        private User _user;

        private List<Student> _students;
        private List<Course> _courses;

        public SysAcadApp(User user, List<Student> students, List<Course> courses){
            _user = user;
            _students = students;
            _courses = courses;
        }
    }
}
