﻿using System;
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
  public partial class ButtonView : UserControl
  {
    private ButtonController controller;

    public ButtonView(ButtonController controller)
    {
      InitializeComponent();
      controller = buttonController;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!controller.Locked)
      {
        controller.onClick();
      }
    }

    public void updateUI()
    {
    }

    private void ButtonView_Load(object sender, EventArgs e)
    {

    }

    private void ButtonView_Load_1(object sender, EventArgs e)
    {

    }

  }
}
