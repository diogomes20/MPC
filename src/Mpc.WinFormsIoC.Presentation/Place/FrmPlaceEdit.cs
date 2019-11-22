using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Place;
using Mpc.WinFormsIoC.Presentation.Assets.Strings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mpc.WinFormsIoC.Presentation.Place
{
    public partial class FrmPlaceEdit : Form
    {
        private IPlaceService _placeService;

        public FrmPlaceEdit(IPlaceService placeService)
        {
            InitializeComponent();
            _placeService = placeService;
        }

        public int? PlaceId { get; set; } = null;
        public int? LogId { get; set; } = null;

        private async void FrmPlaceEdit_Load(object sender, EventArgs e)
        {
            LblName.Text = Strings.LblName;
            LblAddress.Text = Strings.LblAdress;
            LblPhone.Text = Strings.LblPhone;
            LblWebsite.Text = Strings.LblWebsite;
            BtnSave.Text = Strings.BtnSave;
            BtnCancel.Text = Strings.BtnCancel;

            if (!PlaceId.HasValue)
                return;
            else
            {
                using (new Core.ShowLoading())
                {
                    var existPlace = await _placeService.FindAsync(PlaceId.Value);

                    if (existPlace != null)
                    {
                        FillPlace(existPlace);
                    }
                }
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = NotNulls(TxtName.Text, TxtAddress.Text, TxtPhone.Text, TxtWebsite.Text);

            if (errors == string.Empty)
            {
                var validPhone = IsValidPhone(TxtPhone.Text);
                var validWebsite = IsValidWebsite(TxtWebsite.Text);

                if (PlaceId.HasValue)
                {
                    if (validPhone == true && validWebsite == true)
                    {
                        await UpdatePlaceAsync();
                        Core.Messages.Information.ShowMessage(Strings.PlaceUpdated, Strings.Places);
                        Close();
                    }
                }
                else
                {
                     if (validPhone == true && validWebsite == true)
                     {
                         await SavePlaceAsync();
                         Core.Messages.Information.ShowMessage(Strings.PlaceCreated, Strings.Places);
                         Close();
                     }
                }
            }
            else
                Core.Messages.Information.ShowMessage(Strings.AllFieldsRequired + errors, Strings.Places);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillPlace(PlaceDto place)
        {
            TxtName.Text = place.Name;
            TxtAddress.Text = place.Address;
            TxtPhone.Text = place.PhoneNumber.ToString();
            TxtWebsite.Text = place.Website;
        }

        private async Task UpdatePlaceAsync()
        {
            var place = await GetPlaceAsync();
            place.Id = PlaceId.Value;

            await _placeService.UpdateAsync(place);
        }

        private async Task<PlaceDto> GetPlaceAsync()
        {
            var place = new PlaceDto
            {
                Name = TxtName.Text,
                Address = TxtAddress.Text,
                PhoneNumber = int.Parse(TxtPhone.Text),
                Website = TxtWebsite.Text
            };

            return place;
        }

        private async Task SavePlaceAsync()
        {
            var place = await GetPlaceAsync();

            await _placeService.CreateAsync(place);
        }
        
        private bool IsValidPhone(string phone)
        {
            Regex rx = new Regex(@"9[1,2,3,6]{1}\d{7}|2\d{8}",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            Match m = rx.Match(phone);

            if (m.Success)
                return true;
            else
            {
                Core.Messages.Information.ShowMessage(Strings.PhoneNumberIncorrect, Strings.Places);
                return false;
            }
        }

        private bool IsValidWebsite(string website)
        {
            Regex rx = new Regex(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$|^([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            Match m = rx.Match(website);

            if (m.Success)
                return true;
            else
            {
                Core.Messages.Information.ShowMessage(Strings.WebsiteIncorrect, Strings.Places);
                return false;
            }

        }

        private string NotNulls(string name, string address, string phone, string website)
        {
            var errors = string.Empty;

            if (name == string.Empty)
                errors += Strings.ErrorName;
            if (address == string.Empty)
                errors += Strings.ErrorAddress;
            if (phone == string.Empty)
                errors += Strings.ErrorPhone;
            if (website == string.Empty)
                errors += Strings.ErrorWebsite;

            return errors;
        }
    }
}
