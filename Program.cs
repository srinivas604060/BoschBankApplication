using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        public class AccountOpening
        {
            public string OwnerName, Place;
            public int age,numbers = 0;
            public double phonenumber;
            public string typeofaccount;
            public void CreateAccount()
            {
                numbers++;
                Console.WriteLine(numbers);
                Console.WriteLine("Enter Owner Name");
                OwnerName = Console.ReadLine();
                Console.WriteLine("Enter Owner Location");
                Place = Console.ReadLine();
                Console.WriteLine("Enter Owner age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Owner Phonenumber");
                phonenumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("                                               ");
                Console.WriteLine("                                               ");

            }

            public void ShowAccount()
            {
                Console.WriteLine("Account Details");
                Console.WriteLine(OwnerName);
                Console.WriteLine(Place);
                Console.WriteLine(age);
                Console.WriteLine(phonenumber);
                Console.WriteLine("                                               ");
                Console.WriteLine("                                               ");
            }
        }
        public class Bank : AccountOpening
        {
            string bankname;
            double Amount;
            double initialBalance = 0;
            int count = 0;

            public void GetBank()
            {

                Console.WriteLine("Enter Bank Name and Customer Name ");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine("Enter Bank Name");
                bankname = Console.ReadLine();
            }

            public void AccountType()
            {
                Console.WriteLine("Instructions");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Choose the type of Account you have");
                Console.WriteLine("For Savings Account : Enter 1");
                Console.WriteLine("For Current Account : Enter 2");
                Console.WriteLine("For ChildCare Account : Enter 3");
                Console.WriteLine("====================================");
                Console.WriteLine("Enter the type of Account you have");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == 1)
                {
                    typeofaccount = "Savings Account";
                    Console.WriteLine("                      ");
                    Console.WriteLine("======================");
                    Console.WriteLine("                      ");
                    Console.WriteLine(@"true-Deposit                                                                       false-Withdraw");
                    bool select = Convert.ToBoolean(Console.ReadLine());
                    if (select == true)
                    {
                        Console.WriteLine("Enter the Money You want to Deposit");
                        Amount = Convert.ToDouble(Console.ReadLine());
                        DepositAmount();
                    } else if  (select == false)
                            {
                        Console.WriteLine("Enter the Money You want to Withdraw");
                        Amount = Convert.ToDouble(Console.ReadLine());
                        WithdrawAmount();

                    }
                }
                else if (type == 2)
                {
                    typeofaccount = "Current Account";
                    Console.WriteLine("                      ");
                    Console.WriteLine("======================");
                    Console.WriteLine("                      ");
                    Console.WriteLine(@"true-Deposit                                                                       false-Withdraw");
                    bool select = Convert.ToBoolean(Console.ReadLine());
                    if (select == true)
                    {
                        Console.WriteLine("Enter the Money You want to Deposit");
                        Amount = Convert.ToDouble(Console.ReadLine());
                        DepositAmount();
                    }
                    else if (select == false)
                    {
                        Console.WriteLine("Enter the Money You want to Withdraw");
                        Amount = Convert.ToDouble(Console.ReadLine());
                        WithdrawAmount();

                    }
                }
                else if (type == 3)
                {
                    typeofaccount = "ChildCare Account";
                    Console.WriteLine("                      ");
                    Console.WriteLine("======================");
                    Console.WriteLine("                      ");
                    Console.WriteLine(@"true-Deposit                                                                       false-Withdraw");
                    bool select = Convert.ToBoolean(Console.ReadLine());
                    if (select == true)
                    {
                        Console.WriteLine("Enter the Money You want to Deposit");
                        Amount = Convert.ToDouble(Console.ReadLine());
                        DepositAmount();
                    }
                    else if (select == false)
                    {
                        Console.WriteLine("Enter the Money You want to Withdraw");
                        Amount = Convert.ToDouble(Console.ReadLine());
                        WithdrawAmount();

                    }
                }
                



                void DepositAmount()
                {
                    if (typeofaccount == "Saving Account" || Amount <= 100000)
                    {


                        try
                        {

                            Console.WriteLine("Your Amount gets deposited");
                            initialBalance += Amount;
                            count += 1;
                            Console.WriteLine($"The Balance in your Account is {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    if (count > 2)
                                    {
                                        Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {initialBalance - 500}");
                                        initialBalance = initialBalance - 500;
                                    }
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    AccountType();
                                    break;
                            }


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }
                    else if (typeofaccount == "Current Account" || Amount <= 200000)
                    {
                        try
                        {
                            Console.WriteLine("Enter the Money You want to Deposit");
                            Amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Your Amount gets deposited");
                            initialBalance += Amount;
                            count += 1;
                            Console.WriteLine($"The balance in your account is  {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    if (count > 2)
                                    {
                                        Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {initialBalance - 500}");
                                        initialBalance = initialBalance - 500;
                                    }
                                    Console.WriteLine($"The Balance in your Account is {initialBalance}");
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    AccountType();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }
                    else if (typeofaccount == "ChildCare Account" && Amount <= 50000)
                    {
                        try
                        {
                            Console.WriteLine("Your Amount gets deposited");
                            initialBalance += Amount;
                            count += 1;
                            Console.WriteLine($"The Balance in your Account is {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    if (count > 2)
                                    {
                                        Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {initialBalance - 500}");
                                        initialBalance = initialBalance - 500;
                                    }
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    AccountType();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }

                }
                void WithdrawAmount()
                {
                    if (typeofaccount == "Saving Account" || Amount <= 100000)
                    {


                        try
                        {

                            Console.WriteLine("Your Amount gets withdrawed");
                            initialBalance -= Amount;
                            count += 1;
                            Console.WriteLine($"The Balance in your Account is {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    if (count > 2)
                                    {
                                        Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {initialBalance - 500}");
                                        initialBalance = initialBalance - 500;
                                    }
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    AccountType();
                                    break;
                            }


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }
                    else if (typeofaccount == "Current Account" || Amount <= 200000)
                    {
                        try
                        {
                            Console.WriteLine("Enter the Money You want to Withdraw");
                            Amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Your Amount gets Withdrawed");
                            initialBalance -= Amount;
                            count += 1;
                            Console.WriteLine($"The balance in your account is  {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    if (count > 2)
                                    {
                                        Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {initialBalance - 500}");
                                        initialBalance = initialBalance - 500;
                                    }
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    AccountType();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }
                    else if (typeofaccount == "ChildCare Account" && Amount <= 50000)
                    {
                        try
                        {
                            Console.WriteLine("Your Amount gets Withdrawed");
                            initialBalance -= Amount;
                            count += 1;
                            Console.WriteLine($"The Balance in your Account is {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    if (count > 2)
                                    {
                                        Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {initialBalance - 500}");
                                        initialBalance = initialBalance - 500;
                                    }
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    AccountType();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }

                }

            }
            public class ATM : Bank
            {
                public void DepositWithBank()
                {
                    if (typeofaccount == "Saving Account" || Amount <= 100000)
                    {


                        try
                        {

                            Console.WriteLine("Your Amount gets deposited");
                            initialBalance += Amount;
                            count += 1;
                            Console.WriteLine($"The Balance in your Account is {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("Enter the Money You want to Deposit");
                                    Amount = Convert.ToDouble(Console.ReadLine());
                                    BankTransaction();
                                    break;
                            }


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }
                    else if (typeofaccount == "Current Account" || Amount <= 200000)
                    {
                        try
                        {
                            Console.WriteLine("Enter the Money You want to Deposit");
                            Amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Your Amount gets deposited");
                            initialBalance += Amount;
                            count += 1;
                            Console.WriteLine($"The balance in your account is  {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    BankTransaction();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }
                    else if (typeofaccount == "ChildCare Account" && Amount <= 50000)
                    {
                        try
                        {
                            Console.WriteLine("Your Amount gets deposited");
                            initialBalance += Amount;
                            count += 1;
                            Console.WriteLine($"The Balance in your Account is {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    BankTransaction();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }

                }
                public void WithdrawAmountBank()
                {
                    if (typeofaccount == "Saving Account" || Amount <= 100000)
                    {


                        try
                        {

                            Console.WriteLine("Your Amount gets withdrawed");
                            initialBalance -= Amount;
                            count += 1;
                            Console.WriteLine($"The Balance in your Account is {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("Enter the Money You want to Withdrawed");
                                    Amount = Convert.ToDouble(Console.ReadLine());
                                    BankTransaction();
                                    break;
                            }


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }
                    else if (typeofaccount == "Current Account" || Amount <= 200000)
                    {
                        try
                        {
                            Console.WriteLine("Enter the Money You want to Withdraw");
                            Amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Your Amount gets Withdrawed");
                            initialBalance -= Amount;
                            count += 1;
                            Console.WriteLine($"The balance in your account is  {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    BankTransaction();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }
                    else if (typeofaccount == "ChildCare Account" && Amount <= 50000)
                    {
                        try
                        {
                            Console.WriteLine("Your Amount gets Withdrawed");
                            initialBalance -= Amount;
                            count += 1;
                            Console.WriteLine($"The Balance in your Account is {initialBalance}");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                            int num = Convert.ToInt32(Console.ReadLine());
                            switch (num)
                            {
                                case 0:
                                    System.Environment.Exit(0);
                                    break;
                                case 1:
                                    Console.WriteLine("                                   ");
                                    Console.WriteLine("===================================");
                                    Console.WriteLine("                                   ");
                                    BankTransaction();
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + e);
                        }
                        Console.ReadKey();

                    }

                }
                public void DisplayBalanceWithATM()
                {
                    Console.WriteLine(initialBalance);
                }
                public void BankTransaction()
                {
                    Console.WriteLine($"                                      Welcome To {bankname}");
                    Console.WriteLine("                                      ====================");
                    Console.WriteLine("*****************************************************************************************************************");
                    Console.WriteLine(@"1.Deposit                                                                                      2.Withdrawal
3.Account Details                                                                          4.Check Balance");
                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine("Enter your choice");
                    int Option = Convert.ToInt32(Console.ReadLine());

                    switch (Option)
                    {
                        case 1:
                            DepositWithBank();
                            break;
                        case 2:
                            WithdrawAmountBank();
                            break;
                        case 3:
                            ShowAccount();
                            break;
                        case 4:
                            DisplayBalanceWithATM();
                            break;

                    }

                }

                public void AtmRequired()
                {
                    Console.WriteLine("Do You really want AtM ?");
                    Console.WriteLine("You Can use ATM for Transactions.");
                    Console.WriteLine(@"!!!! Only 3 Transactions Per day allowed,
If you want more than 3 transactions better to choose Bank,
otherwise 500 rupees will be cut per every transaction !!!!");
                    Console.WriteLine("                                                                    ");
                    Console.WriteLine("====================================================================");
                    Console.WriteLine("                                                                    ");
                    Console.WriteLine("@Instructions@");
                    Console.WriteLine("0-Yes");
                    Console.WriteLine("1-No");
                    Console.WriteLine("Enter your choice here");
                    string Ownerchoice = Console.ReadLine();
                    try
                    {
                        if (Ownerchoice == "0")
                        {
                            AccountType();

                        }
                        else if (Ownerchoice == "1")
                        {
                            Console.WriteLine(@"Sorry for Inconvience.
Transactions are not allowed now,Please reachout to Bank");
                        }
                        else
                        {
                            throw new SystemException();
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(@"Invalid Key Entered.
                                                                                    @@@@@@Please Enter Correctly@@@@@@@@");
                        Console.WriteLine("                  ");
                        Console.WriteLine("==================");
                        Console.WriteLine("                  ");

                        AtmRequired();

                    }

                }

            }


            public class WelcomeBank : ATM
            {
                public int Choice;
                public void BankWelome()
                {
                    Console.WriteLine($"                                      Welcome To {bankname}");
                    Console.WriteLine("                                      ====================");
                    Console.WriteLine("*****************************************************************************************************************");
                    Console.WriteLine(@"1.Bank Service                                                                                      2.ATM Service
3.Create Account                                                                          4.Check Account Details");
                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine("Enter your choice");
                    Choice = Convert.ToInt32(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            BankTransaction();
                            break;
                        case 2:
                            AtmRequired();
                            break;
                        case 3:
                            CreateAccount();
                            break;
                        case 4:
                            ShowAccount();
                            break;

                    }

                }

            }
            public class Customer : WelcomeBank
            {
                public int age
                {
                    get; set;
                }
                public string OwnerName
                {
                    get;
                    set;
                }
                public string Place
                {
                    get;
                    set;
                }
                public double phonenumber1
                {
                    get;
                    set;
                }

                public class employee : Customer
                {
                    public int age
                    {
                        get; set;
                    }
                    public string name
                    {
                        get;
                        set;
                    }
                    public string Gender
                    {
                        get;
                        set;
                    }
                    public double salary
                    {
                        get;
                        set;
                    }



                }

                
                public void DisplayDetails()
                {
                    employee emp0 = new employee()
                    {
                        age = 20,
                        name = "ajay",
                        Gender = "M",
                        salary = 200000

                    };
  
                    employee emp1 = new employee()
                    {
                        age = 21,
                        name = "jaya",
                        Gender = "F",
                        salary = 100000

                    };
                    employee emp2 = new employee()
                    {
                        age = 32,
                        name = "amit",
                        Gender = "M",
                        salary = 500000

                    };
                    employee emp3 = new employee()
                    {
                        age = 23,
                        name = "sony",
                        Gender = "F",
                        salary = 300000                   };
                    employee emp4 = new employee()
                    {
                        age = 24,
                        name = "asri",
                        Gender = "F",
                        salary = 200000

                    };
                    List<employee> em = new List<employee>();
                    em.Add(emp0);
                    em.Add(emp1);
                    em.Add(emp2);
                    em.Add(emp3);
                    em.Add(emp4);
                    Console.WriteLine("||===================================||");
                    Console.WriteLine("|| Age ||  Name  || Gender || Salary ||");
                    Console.WriteLine("||===================================||");
                    foreach (employee employer in em)
                    {
                        
                        Console.WriteLine($"|| {employer.age} ||  {employer.name}   ||  {employer.Gender}     || {employer.salary} ||");
                        Console.WriteLine("||===================================||");
                    }

                }


                class Program1 : employee
                {
                    static void Main(string[] args)
                    {
                        
                       
                        
                        Program1 b = new Program1();
                        b.CreateAccount();
                        b.DisplayDetails();
                        b.AccountType();
                        b.BankTransaction();
                        b.DisplayDetails();
                        Console.WriteLine("                                         ");
                        b.GetBank();
                        b.BankWelome();
                        b.AccountType();
                        b.AtmRequired();



                    }
                }
            }



        
        }
    }
}





