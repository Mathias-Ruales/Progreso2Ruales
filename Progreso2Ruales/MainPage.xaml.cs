namespace Progreso2Ruales
{
    //primer commit 
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }

        private void Chistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chistes());
        }

        private void Info_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Info());   
        }
    }

}
