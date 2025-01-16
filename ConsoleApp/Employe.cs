using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp
{
   public enum Gender:byte {male = 1,female =2 }
    enum Securitylevel:byte { guest=1, Developer, secretaryAndDBA }
    internal class Employe
    {
        public Employe(int ID,string Name, Securitylevel securitylevel, decimal salary,int day, int month, int year , Gender gender)
        {
            Id = ID;
            this.Name = Name;
            this.securitylevel = securitylevel;
            this.Salary= salary;
            this.gender = gender;
            HiringDate=new (day,month,year);
        }
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string Name{ get; set; }
       public HiringDateData HiringDate { get; set; }
       public Gender gender{ get; set; }
       public Securitylevel securitylevel { get; set; }

         
        public override string ToString()
        {
            return $"id={Id} Name={Name} Gender={gender} " +
                $"Securitylevel={securitylevel} Salary={string.Format("{0}:c",Salary)}" +
                $"HiringDate={HiringDate.ToString} ";
        }
    }
    internal class HiringDateData
    {
        public HiringDateData(int day,int month ,int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Month}/{Day}/{Year}";
        }
    }
}
