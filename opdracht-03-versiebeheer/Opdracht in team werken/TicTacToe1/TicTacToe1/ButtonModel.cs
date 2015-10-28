using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  public class ButtonModel
  {
    private bool isLocked;
    public String _value;

    public ButtonModel()
    {
      isLocked = false;
    }

    public void toggleLocked()
    {
      isLocked = !isLocked;
    }

    public void onClick()
    {
      _value = "X";
    }

    public bool Locked
    {
      get
      {
        return isLocked;
      }
    }
  }
}
