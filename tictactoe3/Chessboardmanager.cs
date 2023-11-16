using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Forms;
using tictactoe3;

namespace Tic_Tac_Toe
{
    public class Chessboardmanager
    {
        #region Properties

        private Panel chessboard;

        public Panel ChessBoard
        {
            get { return chessboard; }
            set { chessboard = value; }
        }

        private List<Player> player;
        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }

        private int currentplayer;

        public int CurrentPlayer
        {
            get { return currentplayer; }
            set { currentplayer = value; }
        }
        //private TextBox playername;
        //public TextBox PlayerName
        //{
        //    get { return playername; }
        //    set { playername = value; }
        //}
        //private TextBox robotname;
        //public TextBox RobotName
        //{
        //    get { return robotname; }
        //    set { robotname = value; }
        //}
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        #endregion

        #region Initialize

        public Chessboardmanager(Panel chessboard/*, TextBox playername, TextBox robotname*/)
        {
            this.chessboard = chessboard;
            //this.PlayerName = playername;
            //this.RobotName = robotname;
            this.Player = new List<Player>()
            {
                new Player("Fat",Image.FromFile(Application.StartupPath + "\\Resources\\3515278.png")),
                new Player("AI", Image.FromFile(Application.StartupPath + "\\Resources\\1998595.png"))
            };

            CurrentPlayer = 0;
            //ChangePlayer();

        }

        #endregion

        #region Methods
        public void draw_chess_board()
        {
            Matrix = new List<List<Button>>();

            Button oldbutton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.chess_board_height; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.chess_board_width; j++)
                {

                    Button btn = new Button()
                    {
                        Width = Cons.chess_width,
                        Height = Cons.chess_height,
                        Location = new Point(oldbutton.Location.X + oldbutton.Width, oldbutton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    //btn.Width = 50;
                    //btn.Height = 50;
                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldbutton = btn;
                }
                oldbutton.Location = new Point(0, oldbutton.Location.Y + Cons.chess_height);
                oldbutton.Width = 0;
                oldbutton.Height = 0;
            }
        }
        int dem = 0;
        void btn_Click(object sender, EventArgs e)
        {
           
            Button btn = sender as Button;
            dem++;
            //btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\X.png");
            if (btn.BackgroundImage != null) { return; }
            Mark(btn);
            //ChangePlayer();
            if (isEndGame(btn))
            {
                EndGame();
            }
            else if (dem==9)
            {
                DrawGame();
            }
        }
        
        private void EndGame()
        {
            MessageBox.Show("End game!");
        }
        private void DrawGame()
        {
            MessageBox.Show("Draw!");
        }
   
        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Cons.chess_board_width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 3;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.chess_board_height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 3;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.chess_board_width - point.X; i++)
            {
                if (point.Y + i >= Cons.chess_board_height || point.X + i >= Cons.chess_board_width)
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 3;
        }
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.chess_board_width || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.chess_board_width - point.X; i++)
            {
                if (point.Y + i >= Cons.chess_board_height || point.X - i < 0)
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 3;
        }
        private void Mark(Button btn) // change X->0 or O->X
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
        //private void ChangePlayer()
        //{
        //    PlayerName.Text = Player[CurrentPlayer].Name;
        //    RobotName.Text = Player[CurrentPlayer].Name;
        //}
        #endregion
    }
}

