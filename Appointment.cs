using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Grad_project_2
{
    public partial class Appointment : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Appointment()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // Set DARK theme

            // Customize color scheme for dark mode
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal700, // Primary color
                Primary.Teal900, // Primary dark color
                Primary.Teal500, // Primary light color
                Accent.LightBlue200, // Accent color
                TextShade.WHITE
            );
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // Add your form load logic here
        }
    }
}
