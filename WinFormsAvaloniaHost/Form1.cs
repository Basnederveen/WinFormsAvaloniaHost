using Avalonia.Win32.Interoperability;
using AvaloniaApp.Views;


namespace WinFormsAvaloniaHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AvaloniaApp.Program.BuildAvaloniaApp().SetupWithoutStarting();

            var wfControl = new WinFormsAvaloniaControlHost();
            wfControl.Content = new UserControl1();

            this.Controls.Add(wfControl);
            wfControl.Dock = DockStyle.Fill;
        }
    }
}
