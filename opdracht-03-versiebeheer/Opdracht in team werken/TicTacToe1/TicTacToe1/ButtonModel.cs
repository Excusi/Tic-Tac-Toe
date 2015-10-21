using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  class ButtonModel
  {
    private bool isLocked;


    public ButtonModel()
    {
      isLocked = false;
    }

    public void toggleLocked()
    {
      isLocked = !isLocked;
    }

    public bool Locked
    {
      get
      {
        return isLocked;
      }
    }

    public void onClick()
    {
    }

  }
}
