using System;

public class DrawAction
{
    public char type { get; set; }
    public Circle circle { get; set; }
    public Drawing.Color color { get; set; }
    //.....

    public DrawAction(char type_, Circle circle_, Drawing.Color color_)
    { 
        type = type_; circle = circle_; color = color_; 
    }
}
