namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe[] EmpArr = new Employe[3];
            EmpArr[0] = new Employe(1, "ahmed", Securitylevel.guest, 125, 25, 9, 2022, Gender.male);
            EmpArr[1] = new Employe(2, "mohmaed", Securitylevel.secretaryAndDBA, 125, 25, 2, 2021, Gender.male);
            EmpArr[2] = new Employe(3, "sayed", Securitylevel.guest | Securitylevel.secretaryAndDBA | Securitylevel.Developer, 125, 25, 9, 2020, Gender.male);
            DateOnly d1 = DateOnly.FromDateTime(DateTime.Now);
            DateOnly d2 = DateOnly.FromDateTime(DateTime.Now);
            bool b,b1;
            Employe temp;
            for (int i = 0; i< EmpArr.Length; i++) {
            for (int j = 0; j < EmpArr.Length-i-1; j++) {
                b = DateOnly.TryParse(EmpArr[j].HiringDate.ToString(), out d1);
                b1 = DateOnly.TryParse(EmpArr[j+1].HiringDate.ToString(), out d2);
                if (b &&b1&& d1 > d2)
                {
                        temp = EmpArr[j];
                        EmpArr[j] = EmpArr[j+1];
                        EmpArr[j+1] = temp;
                }
            }
            }
            foreach(Employe e in EmpArr)
                Console.WriteLine($"{e.HiringDate.ToString() }");
        }
    }
}
