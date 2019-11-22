namespace Mpc.WinFormsIoC.Presentation
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Mpc.WinFormsIoC.Application.Services.Users;
    using Mpc.WinFormsIoC.Presentation.Assets.Strings;
    using Mpc.WinFormsIoC.Presentation.Config;
    using Mpc.WinFormsIoC.Presentation.Core.Helpers;
    using Mpc.WinFormsIoC.Presentation.Place;
    using Mpc.WinFormsIoC.Presentation.Review;

    public partial class FrmMain : Form
    {
        private IUserService _userService;

        public FrmMain(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            Core.ApplicationContext.MainForm = this;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            menuMainGeneral.Text = Strings.MpcApp;
            menuMainConfiguration.Text = Strings.Configuration;
            placesToolStripMenuItem.Text = Strings.Places;
            reviewsToolStripMenuItem.Text = Strings.Reviews;
            menuMainConfigurationCountries.Text = Strings.Countries;
            menuMainConfigurationUsers.Text = Strings.Users;
            BtnLog.Text = Strings.Login;
            statusUserLabel.Text = Strings.LblUsername;

            menuMainGeneral.Enabled = false;
            menuMainConfiguration.Enabled = false;

            Core.Events.Login.SuccessLogin += Login_SuccessLogin;

            var frmLogin = IoC.GetForm<Users.FrmLogin>();
            frmLogin.ShowDialog();

            IsLogged();
        }

        private async void placesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formList = Config.IoC.GetForm<FrmPlaceList>();
            var id = await GetIdByUsername(statusUserName.Text);
            formList.LogId = id;
            OpenFormsHelpers.OpenForm(formList);
        }

        private void reviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormsHelpers.OpenForm<Review.FrmReviewList>();
        }

        private void menuMainConfigurationCountries_Click(object sender, EventArgs e)
        {
            OpenFormsHelpers.OpenForm<Countries.FrmCountryList>();
        }

        private void menuMainConfigurationUsers_Click(object sender, EventArgs e)
        {
            OpenFormsHelpers.OpenForm<Users.FrmUserList>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (statusUserName.Text != string.Empty)
                Logout();
            else
                Login();
        }

        private void Login_SuccessLogin(object sender, Core.Events.SuccessLoginEventArgs e)
        {
            statusUserName.Text = e.Username;
            menuMainGeneral.Enabled = true;
            menuMainConfiguration.Enabled = true;
        }

        private async Task<int> GetIdByUsername(string username)
        {
            var user = await _userService.GetByUsernameAsync(username);

            return user.Id;
        }

        private void IsLogged ()
        {
            if (statusUserName.Text != string.Empty)
                BtnLog.Text = Strings.Logout;
            else
                BtnLog.Text = Strings.Login;
        }
        
        private void Login()
        {
            Core.Events.Login.SuccessLogin += Login_SuccessLogin;

            var frmLogin = IoC.GetForm<Users.FrmLogin>();
            frmLogin.ShowDialog();
            BtnLog.Text = Strings.Logout;
        }

        private void Logout()
        {
            menuMainGeneral.Enabled = false;
            menuMainConfiguration.Enabled = false;
            statusUserName.Text = string.Empty;
            BtnLog.Text = Strings.Login;

            //Fecha todos os forms exceto o FrmMain e FrmLoading
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FrmMain" && Application.OpenForms[i].Name != "FrmLoading")
                    Application.OpenForms[i].Close();
            }
        }

        private void StatusProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
