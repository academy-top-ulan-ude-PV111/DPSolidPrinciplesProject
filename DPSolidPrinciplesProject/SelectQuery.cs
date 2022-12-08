using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSolidPrinciplesProject
{
    interface IPrinter
    {
        void Print(string text);
    }

    class Report
    {
        public string Text { set; get; }
        public IPrinter Printer { set; get; }

        public Report(IPrinter printer)
        {
            Printer = printer;
        }   

        public void Print()
        {
            Printer.Print(Text);
        }
    }

    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    class WindowPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать в окно " + text);
        }
    }


    interface IDrive
    {
        void Drive();
    }
    interface IFly
    { 
        void Fly();
    }

    internal class SelectQuery
    {
        public string Result { set; get; }
        public void SelectName() => Console.WriteLine("Выборка по именам");
        public void SelectAge() => Console.WriteLine("Выборка по возрасту");
        public void SelectAddress() => Console.WriteLine("Выборка по адресу");
        
    }

    class ConsolePrint
    {
        public string Result { set; get; }

        public ConsolePrint(string result)
        { 
            Result = result;
        }

           public void Print()
        {
            Console.WriteLine("Выборка:");
            Console.WriteLine(Result);
        }
    }
}
