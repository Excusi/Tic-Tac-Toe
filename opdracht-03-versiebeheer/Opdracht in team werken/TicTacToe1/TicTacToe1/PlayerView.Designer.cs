namespace TicTacToe1
{
  partial class PlayerView
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.turn = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // turn
      // 
      this.turn.AutoSize = true;
      this.turn.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.turn.Location = new System.Drawing.Point(103, 46);
      this.turn.Name = "turn";
      this.turn.Size = new System.Drawing.Size(29, 13);
      this.turn.TabIndex = 0;
      this.turn.Text = "Turn";
      // 
      // PlayerView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.turn);
      this.Name = "PlayerView";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label turn;
  }
}
