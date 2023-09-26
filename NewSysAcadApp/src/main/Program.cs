using NewSysAcadApp.src.main.sysacad.service;
using NewSysAcadApp.src.main.sysacad.service.impl;

namespace NewSysAcadApp.src.main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LoginService loginService = new LoginServiceImpl();
            loginService.checkCredential("pepe", "pepe");
        }
    }
}