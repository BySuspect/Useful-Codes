//Normal Clicked Event
Button.Clicked += (sender, args) =>
{
OnClicked(args);
};

// Public Event
public event EventHandler<EventArgs> Clicked;
protected virtual void OnClicked(EventArgs e)
{
EventHandler<EventArgs> handler = Clicked;
handler?.Invoke(this, e);
}
