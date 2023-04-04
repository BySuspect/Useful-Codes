private void OnTextChanged(object sender, TextChangedEventArgs e)
{
    if (!String.IsNullOrEmpty(e.NewTextValue))
       [List View Name].ItemsSource = [Collection].Where(x => x[.item name].ToLower().StartsWith(e.NewTextValue.ToLower())).OrderBy(x => x).ToList();
    else
        [List View Name].ItemsSource = [Collection];
}