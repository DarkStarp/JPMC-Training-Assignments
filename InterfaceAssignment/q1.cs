namespace InterfaceAssignment
{
    interface Igovtrules
    {
        public double EmployeePF(double basicSalary);
        public string LeaveDetails();
        public double GratuityAmount(float sercomp, double basicSalary);
    }
    class TCS: Igovtrules
    {
        public string empid, dept, desg;
        public string empname;
        public double basicSalary;

        public TCS(string empid, string dept, string desg, string empname, double basicSalary)
        {
            this.empid = empid;
            this.dept = dept;
            this.desg = desg;
            this.empname = empname;
            this.basicSalary = basicSalary;
        }
        public double EmployeePF(double basicSalary)
        {
            return 0.12D * basicSalary + 0.833D * basicSalary;
        }
        public string LeaveDetails()
        {
            return ("1 day of casual Leaveper month \n12 days of Sick Leave \n10 days of previlage Leave");
        }
        public double GratuityAmount(float sercomp, double basicSalary)
        {
            if (sercomp > 5)
                return basicSalary / 12;
            else if (sercomp > 10)
                return basicSalary / 6;
            else if (sercomp > 20)
                return basicSalary / 4;
            else
                return 0;
        }
        
    }
    class Accenture : Igovtrules
    {
        public string empid, dept, desg;
        public string empname;
        public double basicSalary;

        public Accenture(string empid, string dept, string desg, string empname, double basicSalary)
        {
            this.empid = empid;
            this.dept = dept;
            this.desg = desg;
            this.empname = empname;
            this.basicSalary = basicSalary;
        }
        public double EmployeePF(double basicSalary)
        {
            return 0.12D * basicSalary + 0.12D * basicSalary;
        }
        public string LeaveDetails()
        {
            return ("2 day of casual Leaveper month \n5 days of Sick Leave \n5 days of previlage Leave");
        }
        public double GratuityAmount(float sercomp, double basicSalary)
        {
            return 0;
        }
    }
    internal class q1
    {
        static void Main(string[] args)
        {
            TCS t = new TCS("N76874644","Software Enginier"," Senior", "Jhonny",60000000);
            Accenture a = new Accenture("N76874644", "Software Enginier", " Senior", "Jhonny", 60000000);
            
        }
    }
}