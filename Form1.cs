using PRODIGY_SD_04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRODIGY_SD_04
{
    public partial class SudokuSolver : Form
    {
        private TextBox[,] textBoxes = new TextBox[9,9];
        public SudokuSolver()
        {
            InitializeComponent();
            this.Text = "Sudoku Solver";
            this.Width = 290;
            this.Height = 400;

            for (int i=0;i<9;i++)
            {
                for (int j=0;j<9;j++)
                {
                    textBoxes[i,j] = new TextBox
                    {
                        Width=30,
                        Height=30,
                        Font=new System.Drawing.Font("Arial",12),
                        TextAlign=HorizontalAlignment.Center,
                        Location=new System.Drawing.Point(i*30,j*30),                    
                    };
                    this.Controls.Add(textBoxes[i,j]);
                }
            }
            
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            int[,] board = new int[9,9];
            for (int i=0;i<9;i++)
            {
                for (int j=0;j<9;j++)
                {
                    if (textBoxes[i,j].Text!="")
                    {
                        board[i,j]=int.Parse(textBoxes[i,j].Text);
                    }
                }
            }
            if (Solve(board,0,0))
            {
                for (int i=0;i<9;i++)
                {
                    for (int j=0;j<9;j++)
                    {
                        textBoxes[i,j].Text=board[i,j].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No solution");
            }
        }

        private bool IsValid(int[,] board,int row,int col,int num)
        {
            for (int x=0;x<9;x++)
            {
                if (board[row,x]==num)
                {
                    return false;
                }
            }

            for (int x=0;x<9;x++)
            {
                if (board[x,col]==num)
                {
                    return false;
                }
            }

            int startRow=row-row%3;
            int startCol=col-col%3;
            for (int i=0;i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    if (board[i+startRow,j+startCol]==num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Solve(int[,] board,int row,int col)
        {
            if (row==9)
            {
                return true;
            }

            if (col==9)
            {
                return Solve(board,row+1,0);
            }

            if (board[row,col]!=0)
            {
                return Solve(board,row,col+1);
            }

            for (int num=1;num<=9;num++)
            {
                if (IsValid(board,row,col,num))
                {
                    board[row,col]=num;
                    if (Solve(board,row,col+1))
                    {
                        return true;
                    }
                    board[row,col] = 0;
                }
            }
            return false;
        }
        private void SudokuSolver_Load(object sender, EventArgs e) { }
    }
}
