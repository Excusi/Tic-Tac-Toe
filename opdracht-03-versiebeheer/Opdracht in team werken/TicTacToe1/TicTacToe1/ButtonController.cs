using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  public class ButtonController
  {
    public ButtonModel model;
    private ButtonView view;

    public ButtonController()
    {
      model = new ButtonModel();
      view = new ButtonView(this);
    }

    public ButtonView getView()
    {
      return view;
    }

    public void onClick()
    {
      if (!model.Locked)
      {
        model._value = "X";
        view.updateUI();
      }
    }

    public void toggleLocked()
    {
      model.toggleLocked();
      view.updateUI();
    }

    public bool Locked
    {
      get
      {
        return model.Locked;
      }
    }

  }
}
