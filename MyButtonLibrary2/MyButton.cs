using MyButtonLibrary2.Properties;
using System.ComponentModel;

namespace MyButtonLibrary2
{
    [Designer("MyButtonLibrary2.Design.MyButtonDesigner, MyButtonLibrary2.Design")]
    public class MyButton: Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Text = "DesignMode:" + DesignMode + Environment.NewLine
                + "Process:" + System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            base.OnPaint(pevent);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.Text = "Run-time DesignMode value: " + DesignMode;
        }
    }
}