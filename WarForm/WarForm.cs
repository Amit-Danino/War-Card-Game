namespace WarForm
{
    public partial class WarForm : Form
    {
        public WarForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            String firstPlayerName = this.tbPlayer1.Text;
            String secondPlayerName = this.tbPlayer2.Text;

            if (firstPlayerName != "" && secondPlayerName != "")
            {
                this.Hide();
                WarGame form = new WarGame(firstPlayerName, secondPlayerName);
                form.ShowDialog();
            }
        }
    }
}