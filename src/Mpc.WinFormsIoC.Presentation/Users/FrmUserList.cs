using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Countries;
using Mpc.WinFormsIoC.Application.Services.Users;
using Mpc.WinFormsIoC.Presentation.Core;
using Mpc.WinFormsIoC.Presentation.Core.Helpers;

namespace Mpc.WinFormsIoC.Presentation.Users
{
    public partial class FrmUserList : Form
    {
        private IUserService _userService;
        private ICountryService _countryService;

        public FrmUserList(IUserService userService, ICountryService countryService)
        {
            InitializeComponent();
            _userService = userService;
            _countryService = countryService;
        }

        private async void FrmUserList_Load(object sender, EventArgs e)
        {
            await ListaPaisesAsync();
            await FillUsersAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await FillUsersAsync();
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            var userSelected = DgvUsers.GetSelectedItem<UserDto>();

            if (userSelected != null)
            {
                var formEdit = Config.IoC.GetForm<FrmUserEdit>();
                formEdit.UserId = userSelected.Id;
                OpenFormsHelpers.OpenFormDialog(formEdit);
            }

            await FillUsersAsync();
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            OpenFormsHelpers.OpenFormDialog<FrmUserEdit>();

            await FillUsersAsync();
        }

        private async void BtnDelete_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var userSelected = DgvUsers.GetSelectedItem<UserDto>();

                if (userSelected != null)
                {
                    await _userService.DeleteAsync(userSelected);
                    Core.Messages.Information.ShowMessage("User deleted", "Users");
                    await FillUsersAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task FillUsersAsync()
        {
            using (new ShowLoading())
            {
                if (comboBox_Country.SelectedValue == null)
                {
                    var users = await _userService.GetAllAsync();
                    userDtoBindingSource.DataSource = users;
                }
                else
                {
                    List<UserDto> users = new List<UserDto>();
                    int countryId = int.Parse(comboBox_Country.SelectedValue.ToString());
                    if (countryId == -1)
                    {
                        users = await _userService.GetAllAsync();
                        userDtoBindingSource.DataSource = users;
                    }
                    else
                    {
                        users = await _userService.GetUsersByCountry(countryId);
                        userDtoBindingSource.DataSource = users;
                    }
                }
                userDtoBindingSource.ResetBindings(false);
            }
        }

        private async Task ListaPaisesAsync()
        {
            var lista = await _countryService.GetAllAsync();
            CountryDto country = new CountryDto()
            {
                Alias = "Todos",
                Id = -1,
                Name = "Todos",
                Users = new List<UserDto>()
            };

            lista.Add(country);

            comboBox_Country.DataSource = lista;
            comboBox_Country.DisplayMember = "Name";
            comboBox_Country.ValueMember = "Id";
            comboBox_Country.SelectedValue = "";

            comboBox_Country.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
