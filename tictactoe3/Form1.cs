using Tic_Tac_Toe;

namespace tictactoe3
{
    public partial class Form1 : Form
    {
        #region Properties
        Chessboardmanager chessboard;
        #endregion

        public Form1()
        {
            InitializeComponent();
            chessboard = new Chessboardmanager(pannelchessboard/*, textBoxplayer, textBoxrobot*/);

            chessboard.draw_chess_board();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxrobot_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelinformation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}