using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Place;
using Mpc.WinFormsIoC.Presentation.Assets.Strings;
using Mpc.WinFormsIoC.Presentation.Core;
using Mpc.WinFormsIoC.Presentation.Core.Helpers;
using Mpc.WinFormsIoC.Presentation.Review;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mpc.WinFormsIoC.Presentation.Place
{
    public partial class FrmPlaceList : Form
    {
        private IPlaceService _placeService;

        public FrmPlaceList(IPlaceService placeService)
        {
            InitializeComponent();
            _placeService = placeService;
        }

        public int? LogId { get; set; } = null;

        private async void FrmPlaceList_LoadAsync(object sender, EventArgs e)
        {
            Btn_Evaluate.Text = Strings.BtnEvaluate;
            BtnEdit.Text = Strings.BtnEdit;
            BtnNew.Text = Strings.BtnNew;

            await FillPlacesAsync();
        }

        private void Btn_Evaluate_Click(object sender, EventArgs e)
        {
            var userSelected = dgv1.GetSelectedItem<PlaceDto>();

            if (userSelected != null)
            {
                var formEdit = Config.IoC.GetForm<FrmReviewEdit>();
                formEdit.PlaceId = userSelected.Id;
                formEdit.LogId = LogId;
                OpenFormsHelpers.OpenFormDialog(formEdit);
            }
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            OpenFormsHelpers.OpenFormDialog<FrmPlaceEdit>();

            await FillPlacesAsync();
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            var placeSelected = dgv1.GetSelectedItem<PlaceDto>();

            if (placeSelected != null)
            {
                var formEdit = Config.IoC.GetForm<FrmPlaceEdit>();
                formEdit.PlaceId = placeSelected.Id;
                OpenFormsHelpers.OpenFormDialog(formEdit);
            }
            await FillPlacesAsync();
        }

        private async Task FillPlacesAsync()
        {
            using (new ShowLoading())
            {
                var places = await _placeService.GetAllAsync();
                placeDtoBindingSource.DataSource = places;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
