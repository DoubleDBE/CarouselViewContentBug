namespace CarouselViewContentBug;

public partial class MainPage : ContentPage
{
    public List<List<string>> Items { get; } = new List<List<string>>();

    public MainPage()
	{
        int cnt = 1;

        for (int i = 0; i < 5; i++)
        {
            var lst = new List<string>();

            for (int p = 0; p < 30; p++)
            {
                lst.Add($"Item {cnt}");

                cnt++;
            }

            Items.Add(lst);
        }

        BindingContext = this;
        InitializeComponent();
    }
}