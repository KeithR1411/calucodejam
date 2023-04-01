using System.Runtime.InteropServices;

namespace PasswordManager
{
    public partial class Home : Form
    {
        //Import Microsoft Desktop Window Manager API 
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern void DwmSetWindowAttribute(IntPtr hwnd,
                                                DWMWINDOWATTRIBUTE attribute,
                                                ref int pvAttribute,
                                                uint cbAttribute);

        //DMWINDOWATTRIBUTE Class: Used for importing the ability to set the program's 
        //border color to be the user's Windows taskbar color/theme.
        public enum DWMWINDOWATTRIBUTE : uint
        {
            DWMWA_NCRENDERING_ENABLED,
            DWMWA_NCRENDERING_POLICY,
            DWMWA_TRANSITIONS_FORCEDISABLED,
            DWMWA_ALLOW_NCPAINT,
            DWMWA_CAPTION_BUTTON_BOUNDS,
            DWMWA_NONCLIENT_RTL_LAYOUT,
            DWMWA_FORCE_ICONIC_REPRESENTATION,
            DWMWA_FLIP3D_POLICY,
            DWMWA_EXTENDED_FRAME_BOUNDS,
            DWMWA_HAS_ICONIC_BITMAP,
            DWMWA_DISALLOW_PEEK,
            DWMWA_EXCLUDED_FROM_PEEK,
            DWMWA_CLOAK,
            DWMWA_CLOAKED,
            DWMWA_FREEZE_REPRESENTATION,
            DWMWA_PASSIVE_UPDATE_MODE,
            DWMWA_USE_HOSTBACKDROPBRUSH,
            DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
            DWMWA_WINDOW_CORNER_PREFERENCE = 33,
            DWMWA_BORDER_COLOR,
            DWMWA_CAPTION_COLOR,
            DWMWA_TEXT_COLOR,
            DWMWA_VISIBLE_FRAME_BORDER_THICKNESS,
            DWMWA_SYSTEMBACKDROP_TYPE,
            DWMWA_LAST
        }
        public Home()
        {
            InitializeComponent();
            //Set the border color of all forms to match the user's Windows color/theme.
            var preference = Convert.ToInt32(true);
            DwmSetWindowAttribute(this.Handle,
                                  DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE,
                                  ref preference, sizeof(uint));
        }
        

        //HOME PAGE NAVIGATION BUTTONS:


        //Generate Passwords Button: Takes the user to the Generate Form
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Instantiate and show the Generate Form
            Generate gForm = new Generate();
            gForm.Show();
            //Set the visibility of the Home Form to false
            Visible = false;

        }

        //Manage Passwords Button: Takes the user to the Management Form
        private void btnManage_Click(object sender, EventArgs e)
        {
            //Instantiate and show the Generate Form
            Management mForm = new Management();
            mForm.Show();
            //Set the visibility of the Home Form to false
            Visible = false;
        }

        //Options Button: Takes the user to the Options Form
        private void btnOptions_Click(object sender, EventArgs e)
        {
            //Instantiate and show the Generate Form
            Options oForm = new Options();
            oForm.Show();
            //Set the visibility of the Home Form to false
            Visible = false;
        }

        //Exit Button: Used to close the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Execute shutdown process
            Application.Exit();
        }
    }
}