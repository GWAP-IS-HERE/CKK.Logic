using CKK.DB.UOW;
using CKK.DB.Interfaces;
namespace CKK.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseConnectionFactory dat = new DatabaseConnectionFactory();
            IUnitOfWork unitOf = new UnitOfWork(dat);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(unitOf));
        }
    }
}