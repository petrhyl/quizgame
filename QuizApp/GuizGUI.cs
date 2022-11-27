using System.Linq;
using System.Threading.Tasks;
using QuizApp;
using QuizApp.Connector;
using QuizApp.Game;
using QuizApp.Repository;

namespace QuizApp
{
    public partial class GuizGUI : Form
    {
        public GuizGUI()
        {
            InitializeComponent();
        }

        private QuizRequest claimRequest = new();
        private QuizGame game;
        private List<QuizModel> claims;
        private bool answer;

        private async Task SetRequest()
        {
            claimRequest.AmountOfClaims = Convert.ToInt32(this.numCntClaims.Value);
            claimRequest.ClaimsDifficulty = this.cmbClaimDifficulty.GetItemText(this.cmbClaimDifficulty.SelectedItem);
            claims = await claimRequest.GetQuizAsync();
        }

        private void StartGameRound()
        {
            this.lblNumberOfClaims.Text = game.GetNumberOfClaimsToAnswer().ToString();
            this.lblNumberOfPoints.Text = $"{game.Points}/{game.CurrentClaimIndex}";
            this.txbClaim.BackColor = Color.WhiteSmoke;
            this.txbClaim.Text = game.GetCurrentClaim();
            HandleButtons(true);
        }

        private async Task ShowAnswer()
        {
            HandleButtons(false);
            this.txbClaim.TextAlign = HorizontalAlignment.Center;
            if (answer) {
                this.txbClaim.BackColor = Color.Green;
                this.txbClaim.Text = $"{Environment.NewLine}You are right!";
            } else {
                this.txbClaim.BackColor = Color.Red;
                this.txbClaim.Text = $"{Environment.NewLine}You are wrong!";
            }
            await Task.Delay(1200);
            this.txbClaim.BackColor = Color.WhiteSmoke;            
            this.txbClaim.TextAlign = HorizontalAlignment.Left;
        }

        private void NextClaim()
        {
            bool isNextClaim = game.CallNextClaim();
            if (!isNextClaim) {
                this.panel2.Dispose();
                this.panel3.Visible = true;
                this.lblScoreValue.Text = $"You answered {game.Points} from {claims.Count} claims correctly.";
            }
        }

        private async Task HandleTrueFalseAction(bool selectedAnswer)
        {
            answer = game.IsRightAnswer(selectedAnswer);
            await ShowAnswer();
            NextClaim();
            StartGameRound();
        }

        private void HandleButtons(bool anable)
        {
            if (anable) {
                this.btnTrue.Enabled = true;
                this.btnFalse.Enabled=true;
            } else {
                this.btnTrue.Enabled = false;
                this.btnFalse.Enabled = false;
            }
        }

        // --- form's events

        private void GuizGUI_Load(object sender, EventArgs e)
        {
            this.cmbClaimDifficulty.Text = this.cmbClaimDifficulty.GetItemText(this.cmbClaimDifficulty.Items[0]);
            this.cmbClaimDifficulty.ForeColor = Color.ForestGreen;
        }

        private void BtnStart_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnStart.BackColor = Color.Lime;
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            this.panel1.Dispose();
            this.panel2.Enabled = true;
            this.panel2.Visible = true;

            try {
                HandleButtons(false);
                await SetRequest();
                game = new QuizGame(claims);
                StartGameRound();
            } catch (Exception) {
                this.txbClaim.ForeColor = Color.Red;
                this.txbClaim.Text = "Something went wrong.\nPlease, restart the application.";
                HandleButtons(false);
            }
        }

        private async void BtnTrue_Click(object sender, EventArgs e)
        {
            await HandleTrueFalseAction(true);
        }      

        private async void BtnFalse_Click(object sender, EventArgs e)
        {
            await HandleTrueFalseAction(false);
        }
    }
}