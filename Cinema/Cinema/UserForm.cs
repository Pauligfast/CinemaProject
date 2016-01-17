// Decompiled with JetBrains decompiler
// Type: Cinema.UserForm
// Assembly: Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 93C9DD96-8ED5-40E1-AA89-2D6DD39249D6
// Assembly location: C:\Users\Paulig\Source\Repos\CinemaProject\Cinema\Cinema\obj\Debug\Cinema.exe

using System.ComponentModel;
using System.Windows.Forms;

namespace Cinema
{
  public class UserForm : Form
  {
    private IContainer components = (IContainer) null;

    public UserForm()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Text = "UserForm";
    }
  }
}
