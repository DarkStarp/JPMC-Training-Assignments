namespace ClassesAssignment
{
    internal class Account
    {
        public int Acc_no;
        public double balance;
        public string Cust_name;
        public string Acc_type;
        public char Trans_type;
        public double amount;

        public void accept(int a, string b, string c, double d,char e)
        {
            Acc_no = a;
            Cust_name = b;
            Acc_type = c;
            balance = d;
            Trans_type = e;
        }
        public void withdrawl(double a)
        {
            amount = a;
            balance = balance - amount;
        }
        public void deposit(double a)
        {
            amount = a;
            balance = balance + amount;  
        }
        public void Details()
        {
            Console.WriteLine($"Account number: {Acc_no} \n Customer name: {Cust_name} \n Remaining balance: {balance} \n ");
        }


    }
    
}