using ChainOfResponsibilityClassLibrary.ConcreteHandlers;
using ChainOfResponsibilityClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        var general = new GeneralInquiryHandler();
        var technical = new TechnicalSupportHandler();
        var billing = new BillingSupportHandler();
        var account = new AccountSupportHandler();

        general.SetNext(technical).SetNext(billing).SetNext(account);

        Console.WriteLine("Support System\n");
        Client.ClientCode(general);
    }
}