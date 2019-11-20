using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Countries;
using Mpc.WinFormsIoC.Presentation.Core;
using Mpc.WinFormsIoC.Presentation.Core.Helpers;

namespace Mpc.WinFormsIoC.Presentation.Countries
{
    public partial class FrmCountryList : Form
    {
        private ICountryService _countryService;

        public FrmCountryList(ICountryService countryService)
        {
            InitializeComponent();
            _countryService = countryService;
        }

        private async void FrmCountryList_Load(object sender, System.EventArgs e)
        {
            using (new Core.ShowLoading())
            {
                var countries = await _countryService.GetAllAsync();

                countryDtoBindingSource.DataSource = countries;
                countryDtoBindingSource.ResetBindings(false);
            }
        }

        private async Task FillCountriesAsync()
        {
            using (new ShowLoading())
            {
                var countries = await _countryService.GetAllAsync();

                countryDtoBindingSource.DataSource = countries;
                countryDtoBindingSource.ResetBindings(false);
            }
        }

        private async void Btn_new_Click(object sender, System.EventArgs e)
        {
            OpenFormsHelpers.OpenFormDialog<FrmCountriesEdit>();

            await FillCountriesAsync();
        }

        private async void Btn_Edit_Click(object sender, System.EventArgs e)
        {
            var countrySelected = dgvCountries.GetSelectedItem<CountryDto>();

            if (countrySelected != null)
            {
                var formEdit = Config.IoC.GetForm<FrmCountriesEdit>();
                formEdit.CountryId = countrySelected.Id;
                OpenFormsHelpers.OpenFormDialog(formEdit);
            }

            await FillCountriesAsync();
        }
        
        private async void Btn_Delete_Click(object sender, System.EventArgs e)
        {
            try
            {
                var countrySelected = dgvCountries.GetSelectedItem<CountryDto>();

                if (countrySelected != null)
                {
                    await _countryService.DeleteAsync(countrySelected);
                    Core.Messages.Information.ShowMessage("Country deleted", "Countries");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void countryDtoBindingSource_CurrentChanged(object sender, System.EventArgs e)
        {

        }
    }
}
