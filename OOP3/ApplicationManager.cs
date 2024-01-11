using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method Injection
        public void MakeApplication(ILoanManager loanManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //
            loanManager.Calculate();
            loggerService.Log();
        }

        public void MakeApplication(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            loanManager.Calculate();
            foreach (ILoggerService loggersService in loggerServices)
            {
                loggersService.Log();
            }
        }

        public void GiveLoanPreliminaryInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
