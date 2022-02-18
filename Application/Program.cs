using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForBank
{
    public delegate void Bank(AccountDetails obj);
    public class AccountDetails
    {
        public string CustomerName = string.Empty, CustomerAddress = string.Empty, BankName = string.Empty;
        public double InitialBalance = 0,Amount = 0;
        public int age = 0, numbers = 0,count = 0;
        public double phonenumber;
        public bool IsATMRequired;
        public string typeofaccount = string.Empty, TransactionsPerDay = string.Empty;
        public string ErrorMsg = string.Empty;
    }

    class CreateBankAccount : AccountDetails
    {
        public void CreateAccountBYTypeAccount(AccountDetails obj)
        {
            try
            {
                Console.WriteLine("Enter the Bank Name");
                BankName = Console.ReadLine();
                Console.WriteLine($"                                      Welcome To {BankName}");
                Console.WriteLine("                                      ====================");
                Console.WriteLine("*****************************************************************************************************************");
                Console.WriteLine(@"1. I am an Existing Custmer,I Want Bank Service                    2.I am an Existing Customer,I want  ATM Service
3.I am a New Customer,Want to create an Account");
                Console.WriteLine("___________________________________________________________________________________________________________________");
                Console.WriteLine("Enter your choice");
                Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Enter type of Bank Account do you have");
                        typeofaccount = Console.ReadLine();
                        BankService();
                        break;
                    case 2:
                        AtmService();
                        break;
                    case 3:
                        List<AccountDetails> Acdetails = new List<AccountDetails>();
                        
                        Console.WriteLine("Instructions");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        Console.WriteLine("Choose the type of Account you want");
                        Console.WriteLine("For Savings Account : Enter 1");
                        Console.WriteLine("For Current Account : Enter 2");
                        Console.WriteLine("For ChildCare Account : Enter 3");
                        Console.WriteLine("====================================");
                        Console.WriteLine("Enter the type of Account you have");
                        int type = Convert.ToInt32(Console.ReadLine());
                        if (type == 1)
                        {
                            typeofaccount = "Savings Account";

                            Console.WriteLine($"Please use this same {typeofaccount} for transactions");
                            GetAccountDetails();


                        }
                        else if (type == 2)
                        {
                            typeofaccount = "Current Account";

                            Console.WriteLine($"Please use this same {typeofaccount} for transactions");
                            GetAccountDetails();


                        }
                        else if (type == 3)
                        {
                            typeofaccount = "ChildCare Account";

                            Console.WriteLine($"Please use this same {typeofaccount} for transactions");
                            GetAccountDetails();


                        }
                        break;

                }

            } catch(Exception e)
            {
                throw new Exception();
            }
            Console.ReadKey();

        }
        public int Choice;
        public void BankWelome()
        {
            

        }


        public void  AtmService()
        {
            Console.WriteLine($"                                      Welcome To {BankName} ATM Service");
            Console.WriteLine("                                      ====================");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine(@"1.Deposit                                                                                      2.Withdrawal
3.Check Balance");
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine("Enter your choice");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    Console.WriteLine("Enter the Amount you want to Deposit");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    DepositAmount();
                    break;
                case 2:
                    Console.WriteLine("Enter the Amount you want to Deposit");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    WithdrawAmount();
                    break;
                case 3:
                    Console.WriteLine(InitialBalance);
                    break;

            }

        }
        public void DepositAmount()
        {
           

            if (typeofaccount == "Saving Account" || Amount <= 100000)
            {


                try
                {

                    Console.WriteLine("Your Amount gets deposited");
                    InitialBalance += Amount;
                    count += 1;
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
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
                                Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {InitialBalance - 500}");
                                InitialBalance = InitialBalance - 500;
                            }
                            Console.WriteLine("                                   ");
                            Console.WriteLine("===================================");
                            Console.WriteLine("                                   ");
                            AtmService();
                            break;
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + ErrorMsg);
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
                    InitialBalance += Amount;
                    count += 1;
                    Console.WriteLine($"The balance in your account is  {InitialBalance}");
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
                                Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {InitialBalance - 500}");
                                InitialBalance = InitialBalance - 500;
                            }
                            Console.WriteLine($"The Balance in your Account is {InitialBalance}");
                            Console.WriteLine("                                   ");
                            Console.WriteLine("===================================");
                            Console.WriteLine("                                   ");
                            AtmService();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + ErrorMsg);
                }
                Console.ReadKey();

            }
            else if (typeofaccount == "ChildCare Account" && Amount <= 50000)
            {

                try
                {
                    Console.WriteLine("Your Amount gets deposited");
                    InitialBalance += Amount;
                    count += 1;
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
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
                                Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {InitialBalance - 500}");
                                InitialBalance = InitialBalance - 500;
                            }
                            Console.WriteLine("                                   ");
                            Console.WriteLine("===================================");
                            Console.WriteLine("                                   ");
                            AtmService();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + ErrorMsg);
                }
                Console.ReadKey();

            }

        }
        public void WithdrawAmount()
        {
            if (typeofaccount == "Saving Account" || Amount <= 100000)
            {


                try
                {

                    Console.WriteLine("Your Amount gets withdrawed");
                    InitialBalance -= Amount;
                    count += 1;
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
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
                                Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {InitialBalance - 500}");
                                InitialBalance = InitialBalance - 500;
                            }
                            Console.WriteLine("                                   ");
                            Console.WriteLine("===================================");
                            Console.WriteLine("                                   ");
                            AtmService();
                            break;
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + ErrorMsg);
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
                    InitialBalance -= Amount;
                    count += 1;
                    Console.WriteLine($"The balance in your account is  {InitialBalance}");
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
                                Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {InitialBalance - 500}");
                                InitialBalance = InitialBalance - 500;
                            }
                            Console.WriteLine("                                   ");
                            Console.WriteLine("===================================");
                            Console.WriteLine("                                   ");
                            AtmService();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + ErrorMsg);
                }
                Console.ReadKey();

            }
            else if (typeofaccount == "ChildCare Account" && Amount <= 50000)
            {
                try
                {
                    Console.WriteLine("Your Amount gets Withdrawed");
                    InitialBalance -= Amount;
                    count += 1;
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
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
                                Console.WriteLine($"The Penalty of rupees 500 charged from your account, Now your balance is {InitialBalance - 500}");
                                InitialBalance = InitialBalance - 500;
                            }
                            Console.WriteLine("                                   ");
                            Console.WriteLine("===================================");
                            Console.WriteLine("                                   ");
                            AtmService();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + ErrorMsg);
                }
                Console.ReadKey();

            }

        }

        public void BankService()
        {
            Console.WriteLine($"                                      Welcome To {BankName} Bank Service");
            Console.WriteLine("                                      ====================");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine(@"1.Deposit                                                                                      2.Withdrawal
3.Check Balance");
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine("Enter your choice");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    Console.WriteLine("Enter the Amount you want to Deposit");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    DepositAmountBank();
                    break;
                case 2:
                    Console.WriteLine("Enter the Amount you want to Withdraw");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    WithdrawAmountBank();
                    break;
                case 3:
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
                    break;

            }

        }
        public void DepositAmountBank()
        {


            if (typeofaccount == "Saving Account" || Amount < 100000)
            {


                try
                {

                    Console.WriteLine("Your Amount gets deposited");
                    InitialBalance += Amount;
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
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
                            BankService();
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
                    Console.WriteLine("Your Amount gets deposited");
                    InitialBalance += Amount;
                    Console.WriteLine($"The balance in your account is  {InitialBalance}");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Are you want to continue further: 0-exit and 1-banking again");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 0:
                            System.Environment.Exit(0);
                            break;
                        case 1:
                            Console.WriteLine($"The Balance in your Account is {InitialBalance}");
                            Console.WriteLine("                                   ");
                            Console.WriteLine("===================================");
                            Console.WriteLine("                                   ");
                            BankService();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + ErrorMsg);
                }
                Console.ReadKey();

            }
            else if (typeofaccount == "ChildCare Account" || Amount <= 50000)
            {

                try
                {
                    Console.WriteLine("Your Amount gets deposited");
                    InitialBalance += Amount;
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
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
                            BankService();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your Amount is Exceeded Our Daily Limit" + ErrorMsg);
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
                    InitialBalance -= Amount;
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
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
                            BankService();
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
                    InitialBalance -= Amount;
                    Console.WriteLine($"The balance in your account is  {InitialBalance}");
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
                            BankService();
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
                    InitialBalance -= Amount;
                    Console.WriteLine($"The Balance in your Account is {InitialBalance}");
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
                            BankService();
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
        public void GetAccountDetails()
        {
            try
            {
                Console.WriteLine("Enter Customer Name");
               CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Customer Address");
                CustomerAddress = Console.ReadLine();
                Console.WriteLine("Enter Owner age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Owner Phonenumber");
                phonenumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Amount For Initial Balance");
                InitialBalance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("                                                                    ");
                Console.WriteLine("====================================================================");
                Console.WriteLine($"A {typeofaccount}  Is created for {CustomerName}");
                Console.WriteLine("====================================================================");
                Console.WriteLine("                                                                    ");
                Console.WriteLine("Do you Want ATM For Transactions ?");
                Console.WriteLine(@"!!!! Only 3 Transactions Per day allowed,
If you want more than 3 transactions better to choose Bank,
otherwise 500 rupees will be cut per every transaction !!!!");
                Console.WriteLine("                                                                    ");
                Console.WriteLine("====================================================================");
                Console.WriteLine("                                                                    ");
                Console.WriteLine("Yes - I Want ATM-true                      No - I Don't want -False");
                IsATMRequired = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("                                               ");
                Console.WriteLine("                                               ");
                if (IsATMRequired == true)
                {
                    AtmService();
                }
                else
                {
                    BankService();
                }
            }
            catch (Exception e)
            {
                ErrorMsg += "The Exception has raised Beacuse of selecting invalid number for creating Account";
            }
        }
    }
    class Program : CreateBankAccount
    {
        static void Main(string[] args)
        {
            CreateBankAccount CrAc = new CreateBankAccount();
            Bank DoBanking= new Bank(CrAc.CreateAccountBYTypeAccount);
            DoBanking(CrAc);
            
        }
    }
}
