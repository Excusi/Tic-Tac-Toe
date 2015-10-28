using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
  public class GameController
  {
    private GameView view;

    private TicTacToeController ticTacToe;
    //private ScoreboardController scoreboard;

    public GameController()
    {
      view = new GameView(this);

      ticTacToe = new TicTacToeController(this);

      ticTacToe.MaximumClicks = 3;
      ticTacToe.NumberOfButtons = 9;

      ticTacToe.initialize();

      //scoreboard = new ScoreboardController(this);
    }

    /*public void modelHasChanged()
     * {
     *  scoreboard.updateView();
     * }
     */

    public GameView getView()
    {
      return view;
    }

    public TicTacToeView getViewTicTacToe()
    {
      return ticTacToe.getView();
    }

    /*public ScoreboardView getViewScoreboard()
     {
        return scoreboard.getView();
     } */
    
    public int MaximumClicks
    {
      get
      {
        return ticTacToe.MaximumClicks;
      }
    }

    public int CurrentNumberOfClicks
    {
      get
      {
        return ticTacToe.CurrentNumberOfClicks;
      }
    }

  }
}
