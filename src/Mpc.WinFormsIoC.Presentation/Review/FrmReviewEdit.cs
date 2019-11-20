using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Place;
using Mpc.WinFormsIoC.Application.Services.Reviews;

namespace Mpc.WinFormsIoC.Presentation.Review
{
    public partial class FrmReviewEdit : Form
    {

        private IReviewService _reviewService;
        private IPlaceService _placeService;

        public FrmReviewEdit(IReviewService reviewService, IPlaceService placeService)
        {
            InitializeComponent();
            _reviewService = reviewService;
            _placeService = placeService;
        }

        public int? PlaceId { get; set; } = null;
        public bool? List { get; set; } = null;
        public int? ReviewId { get; set; } = null;
        public int? LogId { get; set; } = null;

        private async void FrmReviewEdit_Load(object sender, EventArgs e)
        {
            using (new Core.ShowLoading())
            {
                var existPlace = await _placeService.FindAsync(PlaceId.Value);

                if (existPlace != null)
                {
                    FillPlace(existPlace);
                    
                    if (List == true)
                    {
                        var existReview = await _reviewService.FindAsync(ReviewId.Value);
                        FillReview(existReview);
                        
                        TxtComment.Enabled = false;
                        Btn_Save.Visible = false;
                    }
                }
            }
        }

        private async void Btn_Save_Click(object sender, EventArgs e)
        {
            await SaveReviewAsync();
            Core.Messages.Information.ShowMessage("Review created", "Review");
            Close();
        }

        private void FillPlace(PlaceDto place)
        {
            TxtId.Text = place.Id.ToString();
            TxtName.Text = place.Name;
            TxtAddress.Text = place.Address;
        }

        private void FillReview(ReviewDto review)
        {
            radRating1.Value = review.Classification;
            TxtComment.Text = review.Comments;
        }
        
        private async Task SaveReviewAsync()
        {
            var review = GetReviewAsync();
            await _reviewService.CreateAsync(review);

            await UpdatePlaceClassification(PlaceId.Value);
        }

        private async Task UpdatePlaceClassification(int placeId)
        {
            await _placeService.UpdateClassification(placeId);
        }

        private ReviewDto GetReviewAsync()
        {
            var review = new ReviewDto
            {
                PlaceId = int.Parse(TxtId.Text),
                UserId = LogId.Value,
                Classification = Convert.ToInt32(radRating1.Value),
                Comments = TxtComment.Text
            };

            return review;
        }
    }
}
