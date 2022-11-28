using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8PuzzleBFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        int[] puzzle =
            {
                1, 2, 3,
                4, 5, 6,
                7, 8, 0
            };

        int movesNumber = 0, labelIndex = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            NewGame();
            //ShuffleButtons();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewGame()
        {
            int[] puzzle =
            {
                1, 2, 3,
                4, 5, 6,
                7, 8, 0
            };
            List<int> labelList = new List<int>();


            int i = 9;

            foreach (Button btn in this.pnl.Controls)
            {
                labelIndex = puzzle[i - 1];

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList.Add(labelIndex);
                i--;
            }

            movesNumber = 0;
            lblNoOfMoves.Text = "Number of Moves : " + movesNumber;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ShuffleButtons();
        }

        private async void btnSolve_Click(object sender, EventArgs e)
        {
            PerformSearch ps = new PerformSearch();
            await ps.Search(puzzle);

        }
        /*
        private void Solve()
        {
            Node root = new Node(puzzle);
            //GetPath(root);
            UninformedSearch ui = new UninformedSearch();

            List<Node> solution = ui.BreadthFirstSearch(root);
            //lblNoOfMoves.Text = root.ToString();
            //lblNoOfMoves.Text = solution.Count.ToString();
            /*
            if (solution.Count > 0)
            {
                solution.Reverse();
                for (int i = 0; i < solution.Count; i++)
                {
                    //puzzle = solution[i].PrintPuzzle();
                    //UpdateButtons();
                    lblNoOfMoves.Text = solution[i].ToString();
                }
            }
        }*/

        private void UpdateButtons()
        {
            int i = 9;

            foreach (Button btn in this.pnl.Controls)
            {
                labelIndex = puzzle[i - 1];

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                i--;
            }
        }

        private void ShuffleButtons()
        {
            List<int> labelList = new List<int>();


            Random rand = new Random();
            int i = 0;

            foreach (Button btn in this.pnl.Controls)
            {
                while (labelList.Contains(labelIndex))
                    labelIndex = rand.Next(9);

                this.puzzle[i] = labelIndex;

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList.Add(labelIndex);
                i++;
            }

            movesNumber = 0;
            lblNoOfMoves.Text = "Number of Moves : " + movesNumber;
        }
    }
}
