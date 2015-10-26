using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe1
{
  public partial class TicTacToeView : UserControl
  {

    private TicTacToeController controller;

    public TicTacToeView(TicTacToeController ticTacToeController)
    {
      controller = ticTacToeController;
      InitializeComponent();
    }

    private void TicTacToeView_Load(object sender, EventArgs e)
    {
      List<ButtonView> buttons = controller.getButtonsView();
      int buttonWidth = buttons.First().Width;
      /*int buttonHeight = buttons.First().Heigth;*/ /*deze was nodig voor de smijt ze allemaal knop 
      er onderaan bij te plaatsen -> kan dus van  PasswordPropertyTextAttribute komen? */

      foreach (ButtonView button in buttons)
      {
        ButtonView currentButton = button;
        int xPos = buttons.IndexOf(button) * buttonWidth;
        currentButton.Location = new Point(xPos, 0);
        Controls.Add(currentButton);
      }

    }
  }
}
