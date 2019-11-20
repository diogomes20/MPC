using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Reviews;
using Mpc.WinFormsIoC.Presentation.Core;
using Mpc.WinFormsIoC.Presentation.Core.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mpc.WinFormsIoC.Presentation.Review
{
    public partial class FrmReviewList : Form
    {
        private readonly IReviewService _reviewService;


        public FrmReviewList(IReviewService reviewService)
        {
            InitializeComponent();
            _reviewService = reviewService;
        }

        public int? LogId { get; set; } = null;

        private async void FrmReviewList_Load(object sender, EventArgs e)
        {
            await FillUsersAsync();
        }

        private async Task FillUsersAsync()
        {
            using (new ShowLoading())
            {
                var reviews = await _reviewService.GetAllAsync();
                reviewDtoBindingSource.DataSource = reviews;
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            var reviewSelected = dataGridView1.GetSelectedItem<ReviewDto>();

            if (reviewSelected != null)
            {
                var formEdit = Config.IoC.GetForm<FrmReviewEdit>();
                formEdit.PlaceId = reviewSelected.PlaceId;
                formEdit.ReviewId = reviewSelected.Id;
                formEdit.List = true;
                OpenFormsHelpers.OpenFormDialog(formEdit);
            }
        }
    }
}
