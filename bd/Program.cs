using System;
using System.Windows.Forms;

namespace bd
{
    internal static class Program
    {
        public static ApplicationContext Context { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Context = new ApplicationContext(new forms.login());
            //Context = new ApplicationContext(new forms.drug(2));
            Application.Run(Context);
            //Application.Run(new forms.login());
        }
    }
}
