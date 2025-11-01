using System;
using System.Windows.Forms;

public class TransparentPanel : Panel
{
    public TransparentPanel()
    {
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = System.Drawing.Color.Transparent;
    }
}
