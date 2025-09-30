namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /*private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }*/


        private void rolardadoBtn_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(LadosPicker.SelectedItem);
            int valor;
            Random rnd = new();
            valor = rnd.Next(1, n + 1);
            NumeroSorteadoLabel.Text = Convert.ToString(valor);
        }
    }

}
