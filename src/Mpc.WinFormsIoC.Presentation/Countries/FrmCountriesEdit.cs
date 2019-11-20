using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Countries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mpc.WinFormsIoC.Presentation.Countries
{
    public partial class FrmCountriesEdit : Form
    {

        private ICountryService _countryService;

        public FrmCountriesEdit(ICountryService countryService)
        {
            InitializeComponent();
            _countryService = countryService;
        }

        public int? CountryId { get; set; } = null;

        private async void FrmCountriesEdit_Load(object sender, EventArgs e)
        {
            if (!CountryId.HasValue)
            {
                return;
            }

            using (new Core.ShowLoading())
            {
                var existCountry = await _countryService.FindAsync(CountryId.Value);

                if (existCountry != null)
                {
                    FillCountry(existCountry);
                }
            }
        }

        private async void Btn_save_Click(object sender, EventArgs e)
        {
            if (CountryId.HasValue)
            {
                await UpdateCountryAsync();
                Core.Messages.Information.ShowMessage("Country updated", "Countries");
            }
            else
            {
                await SaveCountryAsync();
                Core.Messages.Information.ShowMessage("Country created", "Countries");
            }
            Close();
        }

        private async Task UpdateCountryAsync()
        {
            var country = GetCountry();
            country.Id = CountryId.Value;
            await _countryService.UpdateAsync(country);
        }

        private async Task SaveCountryAsync()
        {
            var country = GetCountry();

            await _countryService.CreateAsync(country);
        }

        private CountryDto GetCountry()
        {
            var country = new CountryDto
            {
                Name = TxtName.Text,
                Alias = TxtAlias.Text
            };

            return country;
        }
        
        private void FillCountry(CountryDto country)
        {
            TxtId.Text = country.Id.ToString();
            TxtName.Text = country.Name;
            TxtAlias.Text = country.Alias;
        }
    }
}
