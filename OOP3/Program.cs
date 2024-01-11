using System.Collections.Generic;
using System.Linq.Expressions;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            mortgageLoanManager.Calculate();

            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            vehicleLoanManager.Calculate();

            PersonalFinanceLoanManager personalFinanceLoanManager = new PersonalFinanceLoanManager();
            personalFinanceLoanManager.Calculate();
            */

            /*
            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            mortgageLoanManager.Calculate();

            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            vehicleLoanManager.Calculate();

            ILoanManager personalFinanceLoanManager = new PersonalFinanceLoanManager();
            personalFinanceLoanManager.Calculate();
            */

            /*
            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager personalFinanceLoanManager = new PersonalFinanceLoanManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(mortgageLoanManager);
            applicationManager.MakeApplication(vehicleLoanManager);
            applicationManager.MakeApplication(personalFinanceLoanManager);

            Console.WriteLine("------------------------------");

            List<ILoanManager> loans = new List<ILoanManager>() {mortgageLoanManager, vehicleLoanManager };
            applicationManager.GiveLoanPreliminaryInformation(loans);
            */

            Console.WriteLine("----------Logger-----------");

            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager personalFinanceLoanManager = new PersonalFinanceLoanManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(mortgageLoanManager, new DatabaseLoggerService());
            applicationManager.MakeApplication(vehicleLoanManager, new FileLoggerService());
            applicationManager.MakeApplication(personalFinanceLoanManager, new MailLoggerService());

            Console.WriteLine("----------Multiple Logger-----------");

            List<ILoggerService> loggerServices = new List<ILoggerService>() {new DatabaseLoggerService(), new MailLoggerService() };
            applicationManager.MakeApplication(personalFinanceLoanManager, loggerServices);
        }
    }
}
