using ChuckNorrisAPI;

namespace ChuckNorrisFormApp
{
    public partial class jokesForm : Form
    {
        public jokesForm()
        {
            InitializeComponent();
        }       

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            JokeContainer.Text = "";
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var category in categories)
            {
                categoryCB.Items.Add(category);
            }
        }
        private async void JokesBtn_Click(object sender, EventArgs e)
        {
            Joke haha = await ChuckNorrisClient.GetRandomJoke();
            JokeContainer.Text = haha.JokeText;
        }
    }
}