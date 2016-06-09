using System.Windows.Forms;

namespace Barista3000
{
    /// <summary>
    /// Barista 3000 program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point for the application
        /// </summary>
        /// <param name="args">Startup arguments (not used)</param>
        static void Main(string[] args)
        {
            // General settings
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Runs a new instance of the console GUI
            Application.Run(new WindowsGUI());
        }
    }
}
