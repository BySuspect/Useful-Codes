
///on custom object class 

Color _color;
public CustomBoxView() : base()
{
_color=this.Color;
this.PropertyChanged += (s, e) =>
{
    if (_color != Color) OnColorChanged(new ColorChangedEventArgs(_color, Color));
};
}

public event EventHandler<ColorChangedEventArgs> ColorChanged;
protected virtual void OnColorChanged(ColorChangedEventArgs e)
{
    EventHandler<ColorChangedEventArgs> handler = ColorChanged;
    handler?.Invoke(this, e);
}



///only for color changed event handler its for custom event handler

public class ColorChangedEventArgs : EventArgs
{
    public ColorChangedEventArgs(Color oldColor, Color newColor)
    {
        OldColor = oldColor;
        NewColor = newColor;
    }

    public Color OldColor { get; private set; }
    public Color NewColor { get; private set; }
}
