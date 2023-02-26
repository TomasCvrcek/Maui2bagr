using System.Diagnostics.Metrics;

namespace MauiApp2.Pages;

public partial class CounterPage : ContentPage
{
    public int _counter { get; set; }
    public CounterPage()
	{
		InitializeComponent();
	}
    private void IncBtn_clicked(object sender, EventArgs e)
    {
		_counter++;
		bagr.Text = _counter.ToString();
    }

    private void DecBtn_clicked(object sender, EventArgs e)
    {
        _counter--;
        bagr.Text = _counter.ToString();
    }
}