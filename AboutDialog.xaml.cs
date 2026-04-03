using System.Reflection;
using System.Windows;

namespace MushiForge.App;

public partial class AboutDialog : Window
{
  public AboutDialog()
  {
    InitializeComponent();

    // Set version from assembly
    var version = Assembly.GetExecutingAssembly().GetName().Version;
    if (version != null)
    {
      VersionText.Text = $"MushiForge v{version.Major}.{version.Minor}.{version.Build}";
    }
  }

  private void Close_Click(object sender, RoutedEventArgs e)
  {
    Close();
  }
}
