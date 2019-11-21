using System;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Countries;
using Mpc.WinFormsIoC.Application.Services.Users;

namespace Mpc.WinFormsIoC.Presentation.Users
{
    public partial class FrmUserEdit : Form
    {
        private IUserService _userService;
        private ICountryService _countryService;

        public FrmUserEdit(IUserService userService, ICountryService countryService)
        {
            InitializeComponent();
            _userService = userService;
            _countryService = countryService;
        }

        public int? UserId { get; set; } = null;

        private async void FrmUserEdit_Load(object sender, System.EventArgs e)
        {
            if (!UserId.HasValue)
            {
                await ListaPaisesAsync();
            }
            else
            {
                using (new Core.ShowLoading())
                {
                    var existUser = await _userService.FindAsync(UserId.Value);

                    if (existUser != null)
                    {
                        FillUser(existUser);

                        await ListaPaisesAsync();
                    }
                }
            }

        }

        private async void BtnSave_ClickAsync(object sender, System.EventArgs e)
        {
            string country = comboBox1.SelectedValue == null ? string.Empty : comboBox1.SelectedValue.ToString(); ;
            bool validEmail = IsValidEmail(TxtEmail.Text);
            bool validUser = await ExistUsername(TxtUsername.Text);
            var errors = NotNulls(TxtEmail.Text, TxtName.Text, TxtPassword.Text, TxtUsername.Text, country);

            if (UserId.HasValue)
            {
                if (validEmail == true && validUser == true && errors == string.Empty)
                {
                    await UpdateUserAsync();
                    Core.Messages.Information.ShowMessage("User updated", "Users");
                    Close();
                }
                else
                {
                    Core.Messages.Information.ShowMessage("All fields are required!" + errors, "Users");
                }
            }
            else
            {
                if (validEmail == true && errors == string.Empty)
                {
                    await SaveUserAsync();
                    Core.Messages.Information.ShowMessage("User created", "Users");
                    Close();
                }
                else
                {
                    Core.Messages.Information.ShowMessage("All fields are required!" + errors, "Users");
                }
            }
            
        }

        private void FillUser(UserDto user)
        {
            TxtId.Text = user.Id.ToString();
            TxtEmail.Text = user.Email;
            TxtName.Text = user.Name;
            TxtPassword.Text = user.Password;
            TxtUsername.Text = user.Username;
        }

        private async Task<UserDto> GetUserAsync()
        {
            CountryDto country = await _countryService.FindAsync(int.Parse(comboBox1.SelectedValue.ToString()));

            var user = new UserDto
            {
                Email = TxtEmail.Text,
                Name = TxtName.Text,
                Password = TxtPassword.Text,
                Username = TxtUsername.Text,
                PaisId = int.Parse(comboBox1.SelectedValue.ToString()),
                PaisNome = country.Name
            };

            return user;
        }
        
        private async Task SaveUserAsync()
        {
            var user = await GetUserAsync();

            await _userService.CreateAsync(user);
        }

        private async Task UpdateUserAsync()
        {
            var user = await GetUserAsync();
            user.Id = UserId.Value;
            user.Password = string.Empty;

            await _userService.UpdateAsync(user);
        }

        private async Task ListaPaisesAsync()
        {
            var lista = await _countryService.GetAllAsync();

            this.comboBox1.DataSource = lista;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Id";

            if (UserId != null)
            {
                var existUser = await _userService.FindAsync(UserId.Value);
                comboBox1.SelectedValue = existUser.PaisId;
            }
            else
                comboBox1.SelectedValue = "";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private string NotNulls(string email, string name, string password, string username, string country)
        {
            var errors = string.Empty;

            if (username == string.Empty)
                errors += "\n- Username";
            if (password == string.Empty)
                errors += "\n- Password";
            if (name == string.Empty)
                errors += "\n- Name";
            if (email == string.Empty)
                errors += "\n- Email";
            if (country == string.Empty)
                errors += "\n- Country";

            return errors;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                Core.Messages.Information.ShowMessage("Email field was not accepted!", "Users");
                return false;
            }
            catch (Exception)
            { return false; }
        }

        private async Task<bool> ExistUsername(string username)
        {
            var listUsers = await _userService.GetAllAsync();

            foreach (var item in listUsers)
            {
                if (username == item.Username && TxtId.Text != item.Id.ToString())
                {
                    Core.Messages.Information.ShowMessage("Username already exists!", "Users");
                    return false;
                }
            }
            return true;
        }




        private void LblEmail_Click(object sender, System.EventArgs e)
        {

        }

        private void LblName_Click(object sender, System.EventArgs e)
        {

        }

        private void LblPassword_Click(object sender, System.EventArgs e)
        {

        }

        private void LblUsername_Click(object sender, System.EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void LblId_Click(object sender, System.EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
