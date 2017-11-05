using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace EightQueensApplication
{

    public partial class EightQueens : Form
    {

        public EightQueens()
        {
            InitializeComponent();
           
        }
        String QUEENinput;
        
        int qXshift, qYshift, CurrentQX = 0, CurrentQY = 0, smileCount = 0;
        //set up ChessBoard array - used to calculate queens' "star" positions
        string[,] ChessBoard = new string[10, 10];

        //All these click handlers put Queens on chessboard by mouse
        private void A8_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = A8.Name;
            chessboardcopy();
            A8.Image = new Bitmap(Q2.Image);
            evaluate();
            A8.AccessibleName = "Q";
        }
        private void B8_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = B8.Name;
            chessboardcopy();
            B8.Image = new Bitmap(Q1.Image);
            evaluate();
            B8.AccessibleName = "Q";
        }
        private void C8_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = C8.Name;
            chessboardcopy();
            C8.Image = new Bitmap(Q2.Image);
            evaluate();
            C8.AccessibleName = "Q";
        }
        private void D8_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = D8.Name;
            chessboardcopy();
            D8.Image = new Bitmap(Q1.Image);
            evaluate();
            D8.AccessibleName = "Q";
        }
        private void E8_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = E8.Name;
            chessboardcopy();
            E8.Image = new Bitmap(Q2.Image);
            evaluate();
            E8.AccessibleName = "Q";
        }
        private void F8_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = F8.Name;
            chessboardcopy();
            F8.Image = new Bitmap(Q1.Image);
            evaluate();
            F8.AccessibleName = "Q";
        }
        private void G8_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = G8.Name;
            chessboardcopy();
            G8.Image = new Bitmap(Q2.Image);
            evaluate();
            G8.AccessibleName = "Q";
        }
        private void H8_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = H8.Name;
            chessboardcopy();
            H8.Image = new Bitmap(Q1.Image);
            evaluate();
            H8.AccessibleName = "Q";
        }
        private void H7_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = H7.Name;
            chessboardcopy();
            H7.Image = new Bitmap(Q2.Image);
            evaluate();
            H7.AccessibleName = "Q";
        }
        private void G7_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = G7.Name;
            chessboardcopy();
            G7.Image = new Bitmap(Q1.Image);
            evaluate();
            G7.AccessibleName = "Q";
        }
        private void F7_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = F7.Name;
            chessboardcopy();
            F7.Image = new Bitmap(Q2.Image);
            evaluate();
            F7.AccessibleName = "Q";

        }
        private void E7_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = E7.Name;
            chessboardcopy();
            E7.Image = new Bitmap(Q1.Image);
            evaluate();
            E7.AccessibleName = "Q";
        }
        private void D7_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = D7.Name;
            chessboardcopy();
            D7.Image = new Bitmap(Q2.Image);
            evaluate();
            D7.AccessibleName = "Q";
        }
        private void C7_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = C7.Name;
            chessboardcopy();
            C7.Image = new Bitmap(Q1.Image);
            evaluate();
            C7.AccessibleName = "Q";
        }
        private void B7_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = B7.Name;
            chessboardcopy();
            B7.Image = new Bitmap(Q2.Image);
            evaluate();
            B7.AccessibleName = "Q";
        }
        private void A7_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = A7.Name;
            chessboardcopy();
            A7.Image = new Bitmap(Q1.Image);
            evaluate();
            A7.AccessibleName = "Q";
        }
        private void A6_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = A6.Name;
            chessboardcopy();
            A6.Image = new Bitmap(Q2.Image);
            evaluate();
            A6.AccessibleName = "Q";
        }
        private void B6_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = B6.Name;
            chessboardcopy();
            B6.Image = new Bitmap(Q1.Image);
            evaluate();
            B6.AccessibleName = "Q";
        }
        private void C6_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = C6.Name;
            chessboardcopy();
            C6.Image = new Bitmap(Q2.Image);
            evaluate();
            C6.AccessibleName = "Q";
        }
        private void D6_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = D6.Name;
            chessboardcopy();
            D6.Image = new Bitmap(Q1.Image);
            evaluate();
            D6.AccessibleName = "Q";
        }
        private void E6_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = E6.Name;
            chessboardcopy();
            E6.Image = new Bitmap(Q2.Image);
            evaluate();
            E6.AccessibleName = "Q";
        }
        private void F6_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = F6.Name;
            chessboardcopy();
            F6.Image = new Bitmap(Q1.Image);
            evaluate();
            F6.AccessibleName = "Q";
        }
        private void G6_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = G6.Name;
            chessboardcopy();
            G6.Image = new Bitmap(Q2.Image);
            evaluate();
            G6.AccessibleName = "Q";
        }
        private void H6_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = H6.Name;
            chessboardcopy();
            H6.Image = new Bitmap(Q1.Image);
            evaluate();
            H6.AccessibleName = "Q";
        }
        private void H5_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = H5.Name;
            chessboardcopy();
            H5.Image = new Bitmap(Q2.Image);
            evaluate();
            H5.AccessibleName = "Q";
        }
        private void G5_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = G5.Name;
            chessboardcopy();
            G5.Image = new Bitmap(Q1.Image);
            evaluate();
            G5.AccessibleName = "Q";
        }
        private void F5_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = F5.Name;
            chessboardcopy();
            F5.Image = new Bitmap(Q2.Image);
            evaluate();
            F5.AccessibleName = "Q";
        }
        private void E5_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = E5.Name;
            chessboardcopy();
            E5.Image = new Bitmap(Q1.Image);
            evaluate();
            E5.AccessibleName = "Q";
        }
        private void D5_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = D5.Name;
            chessboardcopy();
            D5.Image = new Bitmap(Q2.Image);
            evaluate();
            D5.AccessibleName = "Q";
        }
        private void C5_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = C5.Name;
            chessboardcopy();
            C5.Image = new Bitmap(Q1.Image);
            evaluate();
            C5.AccessibleName = "Q";
        }
        private void B5_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = B5.Name;
            chessboardcopy();
            B5.Image = new Bitmap(Q2.Image);
            evaluate();
            B5.AccessibleName = "Q";
        }
        private void A5_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = A5.Name;
            chessboardcopy();
            A5.Image = new Bitmap(Q1.Image);
            evaluate();
            A5.AccessibleName = "Q";
        }
        private void A4_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = A4.Name;
            chessboardcopy();
            A4.Image = new Bitmap(Q2.Image);
            evaluate();
            A4.AccessibleName = "Q";
        }
        private void B4_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = B4.Name;
            chessboardcopy();
            B4.Image = new Bitmap(Q1.Image);
            evaluate();
            B4.AccessibleName = "Q";
        }
        private void C4_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = C4.Name;
            chessboardcopy();
            C4.Image = new Bitmap(Q2.Image);
            evaluate();
            C4.AccessibleName = "Q";
        }
        private void D4_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = D4.Name;
            chessboardcopy();
            D4.Image = new Bitmap(Q1.Image);
            evaluate();
            D4.AccessibleName = "Q";
        }
        private void E4_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = E4.Name;
            chessboardcopy();
            E4.Image = new Bitmap(Q2.Image);
            evaluate();
            E4.AccessibleName = "Q";
        }
        private void F4_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = F4.Name;
            chessboardcopy();
            F4.Image = new Bitmap(Q1.Image);
            evaluate();
            F4.AccessibleName = "Q";

        }
        private void G4_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = G4.Name;
            chessboardcopy();
            G4.Image = new Bitmap(Q2.Image);
            evaluate();
            G4.AccessibleName = "Q";

        }
        private void H4_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = H4.Name;
            chessboardcopy();
            H4.Image = new Bitmap(Q1.Image);
            evaluate();
            H4.AccessibleName = "Q";

        }
        private void H3_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = H3.Name;
            chessboardcopy();
            H3.Image = new Bitmap(Q2.Image);
            evaluate();
            H3.AccessibleName = "Q";

        }
        private void G3_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = G3.Name;
            chessboardcopy();
            G3.Image = new Bitmap(Q1.Image);
            evaluate();
            G3.AccessibleName = "Q";

        }
        private void F3_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = F3.Name;
            chessboardcopy();
            F3.Image = new Bitmap(Q2.Image);
            evaluate();
            F3.AccessibleName = "Q";

        }
        private void E3_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = E3.Name;
            chessboardcopy();
            E3.Image = new Bitmap(Q1.Image);
            evaluate();
            E3.AccessibleName = "Q";

        }
        private void D3_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = D3.Name;
            chessboardcopy();
            D3.Image = new Bitmap(Q2.Image);
            evaluate();
            D3.AccessibleName = "Q";

        }
        private void C3_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = C3.Name;
            chessboardcopy();
            C3.Image = new Bitmap(Q1.Image);
            evaluate();
            C3.AccessibleName = "Q";

        }
        private void B3_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = B3.Name;
            chessboardcopy();
            B3.Image = new Bitmap(Q2.Image);
            evaluate();
            B3.AccessibleName = "Q";

        }
        private void A3_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = A3.Name;
            chessboardcopy();
            A3.Image = new Bitmap(Q1.Image);
            evaluate();
            A3.AccessibleName = "Q";

        }
        private void A2_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = A2.Name;
            chessboardcopy();
            A2.Image = new Bitmap(Q2.Image);
            evaluate();
            A2.AccessibleName = "Q";

        }
        private void B2_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = B2.Name;
            chessboardcopy();
            B2.Image = new Bitmap(Q1.Image);
            evaluate();
            B2.AccessibleName = "Q";

        }
        private void C2_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = C2.Name;
            chessboardcopy();
            C2.Image = new Bitmap(Q2.Image);
            evaluate();
            C2.AccessibleName = "Q";

        }
        private void D2_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = D2.Name;
            chessboardcopy();
            D2.Image = new Bitmap(Q1.Image);
            evaluate();
            D2.AccessibleName = "Q";

        }
        private void E2_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = E2.Name;
            chessboardcopy();
            E2.Image = new Bitmap(Q2.Image);
            evaluate();
            E2.AccessibleName = "Q";

        }
        private void F2_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = F2.Name;
            chessboardcopy();
            F2.Image = new Bitmap(Q1.Image);
            evaluate();
            F2.AccessibleName = "Q";

        }
        private void G2_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = G2.Name;
            chessboardcopy();
            G2.Image = new Bitmap(Q2.Image);
            evaluate();
            G2.AccessibleName = "Q";

        }
        private void H2_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = H2.Name;
            chessboardcopy();
            H2.Image = new Bitmap(Q1.Image);
            evaluate();
            H2.AccessibleName = "Q";

        }
        private void H1_Click(object sender, EventArgs e)
        {
            QUEENinput = H1.Name;
            chessboardcopy();
            H1.Image = new Bitmap(Q2.Image);
            evaluate();
            H1.AccessibleName = "Q";

        }
        private void G1_Click(object sender, EventArgs e)
        {
            QUEENinput = G1.Name;
            chessboardcopy();
            G1.Image = new Bitmap(Q1.Image);
            evaluate();
            G1.AccessibleName = "Q";

        }
        private void F1_Click(object sender, EventArgs e)
        {
            QUEENinput = F1.Name;
            chessboardcopy();
            F1.Image = new Bitmap(Q2.Image);
            evaluate();
            F1.AccessibleName = "Q";

        }
        private void E1_Click(object sender, EventArgs e)
        {
            QUEENinput = E1.Name;
            chessboardcopy();
            E1.Image = new Bitmap(Q1.Image);
            evaluate();
            E1.AccessibleName = "Q";

        }
        private void D1_Click(object sender, EventArgs e)
        {
            QUEENinput = D1.Name;
            chessboardcopy();
            D1.Image = new Bitmap(Q2.Image);
            evaluate();
            D1.AccessibleName = "Q";

        }
        private void C1_Click(object sender, EventArgs e)
        {
            QUEENinput = C1.Name;
            chessboardcopy();
            C1.Image = new Bitmap(Q1.Image);
            evaluate();
            C1.AccessibleName = "Q";

        }
        private void B1_Click(object sender, EventArgs e)
        {
            QUEENinput = B1.Name;
            chessboardcopy();
            B1.Image = new Bitmap(Q2.Image);
            evaluate();
            B1.AccessibleName = "Q";

        }
        private void A1_Click(object sender, MouseEventArgs e)
        {
            QUEENinput = A1.Name;
            chessboardcopy();
            A1.Image = new Bitmap(Q1.Image);
            evaluate();
            A1.AccessibleName = "Q";
        }





        //this button click handler controls entering Queens position in text box

        private void EnterQueen_Click(object sender, EventArgs e)
        {





            //queen position input through GUI text box
            String queenINPUT = textBox1.Text;
                   QUEENinput = queenINPUT.ToUpper();

            chessboardcopy();

           
            if (A1.Name == QUEENinput) { A1.Image = new Bitmap(Q1.Image); A1.AccessibleName = "Q"; }
            else if (A2.Name == QUEENinput) { A2.Image = new Bitmap(Q2.Image); A2.AccessibleName = "Q"; }
            else if (A3.Name == QUEENinput) { A3.Image = new Bitmap(Q1.Image); A3.AccessibleName = "Q"; }
            else if (A4.Name == QUEENinput) { A4.Image = new Bitmap(Q2.Image); A4.AccessibleName = "Q"; }
            else if (A5.Name == QUEENinput) { A5.Image = new Bitmap(Q1.Image); A5.AccessibleName = "Q"; }
            else if (A6.Name == QUEENinput) { A6.Image = new Bitmap(Q2.Image); A6.AccessibleName = "Q"; }
            else if (A7.Name == QUEENinput) { A7.Image = new Bitmap(Q1.Image); A7.AccessibleName = "Q"; }
            else if (A8.Name == QUEENinput) { A8.Image = new Bitmap(Q2.Image); A8.AccessibleName = "Q"; }
            else if (B1.Name == QUEENinput) { B1.Image = new Bitmap(Q2.Image); B1.AccessibleName = "Q"; }
            else if (B2.Name == QUEENinput) { B2.Image = new Bitmap(Q1.Image); B2.AccessibleName = "Q"; }
            else if (B3.Name == QUEENinput) { B3.Image = new Bitmap(Q2.Image); B3.AccessibleName = "Q"; }
            else if (B4.Name == QUEENinput) { B4.Image = new Bitmap(Q1.Image); B4.AccessibleName = "Q"; }
            else if (B5.Name == QUEENinput) { B5.Image = new Bitmap(Q2.Image); B5.AccessibleName = "Q"; }
            else if (B6.Name == QUEENinput) { B6.Image = new Bitmap(Q1.Image); B6.AccessibleName = "Q"; }
            else if (B7.Name == QUEENinput) { B7.Image = new Bitmap(Q2.Image); B7.AccessibleName = "Q"; }
            else if (B8.Name == QUEENinput) { B8.Image = new Bitmap(Q1.Image); B8.AccessibleName = "Q"; }
            else if (C1.Name == QUEENinput) { C1.Image = new Bitmap(Q1.Image); C1.AccessibleName = "Q"; }
            else if (C2.Name == QUEENinput) { C2.Image = new Bitmap(Q2.Image); C2.AccessibleName = "Q"; }
            else if (C3.Name == QUEENinput) { C3.Image = new Bitmap(Q1.Image); C3.AccessibleName = "Q"; }
            else if (C4.Name == QUEENinput) { C4.Image = new Bitmap(Q2.Image); C4.AccessibleName = "Q"; }
            else if (C5.Name == QUEENinput) { C5.Image = new Bitmap(Q1.Image); C5.AccessibleName = "Q"; }
            else if (C6.Name == QUEENinput) { C6.Image = new Bitmap(Q2.Image); C6.AccessibleName = "Q"; }
            else if (C7.Name == QUEENinput) { C7.Image = new Bitmap(Q1.Image); C7.AccessibleName = "Q"; }
            else if (C8.Name == QUEENinput) { C8.Image = new Bitmap(Q2.Image); C8.AccessibleName = "Q"; }
            else if (D1.Name == QUEENinput) { D1.Image = new Bitmap(Q2.Image); D1.AccessibleName = "Q"; }
            else if (D2.Name == QUEENinput) { D2.Image = new Bitmap(Q1.Image); D2.AccessibleName = "Q"; }
            else if (D3.Name == QUEENinput) { D3.Image = new Bitmap(Q2.Image); D3.AccessibleName = "Q"; }
            else if (D4.Name == QUEENinput) { D4.Image = new Bitmap(Q1.Image); D4.AccessibleName = "Q"; }
            else if (D5.Name == QUEENinput) { D5.Image = new Bitmap(Q2.Image); D5.AccessibleName = "Q"; }
            else if (D6.Name == QUEENinput) { D6.Image = new Bitmap(Q1.Image); D6.AccessibleName = "Q"; }
            else if (D7.Name == QUEENinput) { D7.Image = new Bitmap(Q2.Image); D7.AccessibleName = "Q"; }
            else if (D8.Name == QUEENinput) { D8.Image = new Bitmap(Q1.Image); D8.AccessibleName = "Q"; }
            else if (E1.Name == QUEENinput) { E1.Image = new Bitmap(Q1.Image); E1.AccessibleName = "Q"; }
            else if (E2.Name == QUEENinput) { E2.Image = new Bitmap(Q2.Image); E2.AccessibleName = "Q"; }
            else if (E3.Name == QUEENinput) { E3.Image = new Bitmap(Q1.Image); E3.AccessibleName = "Q"; }
            else if (E4.Name == QUEENinput) { E4.Image = new Bitmap(Q2.Image); E4.AccessibleName = "Q"; }
            else if (E5.Name == QUEENinput) { E5.Image = new Bitmap(Q1.Image); E5.AccessibleName = "Q"; }
            else if (E6.Name == QUEENinput) { E6.Image = new Bitmap(Q2.Image); E6.AccessibleName = "Q"; }
            else if (E7.Name == QUEENinput) { E7.Image = new Bitmap(Q1.Image); E7.AccessibleName = "Q"; }
            else if (E8.Name == QUEENinput) { E8.Image = new Bitmap(Q2.Image); E8.AccessibleName = "Q"; }
            else if (F1.Name == QUEENinput) { F1.Image = new Bitmap(Q2.Image); F1.AccessibleName = "Q"; }
            else if (F2.Name == QUEENinput) { F2.Image = new Bitmap(Q1.Image); F2.AccessibleName = "Q"; }
            else if (F3.Name == QUEENinput) { F3.Image = new Bitmap(Q2.Image); F3.AccessibleName = "Q"; }
            else if (F4.Name == QUEENinput) { F4.Image = new Bitmap(Q1.Image); F4.AccessibleName = "Q"; }
            else if (F5.Name == QUEENinput) { F5.Image = new Bitmap(Q2.Image); F5.AccessibleName = "Q"; }
            else if (F6.Name == QUEENinput) { F6.Image = new Bitmap(Q1.Image); F6.AccessibleName = "Q"; }
            else if (F7.Name == QUEENinput) { F7.Image = new Bitmap(Q2.Image); F7.AccessibleName = "Q"; }
            else if (F8.Name == QUEENinput) { F8.Image = new Bitmap(Q1.Image); F8.AccessibleName = "Q"; }
            else if (G1.Name == QUEENinput) { G1.Image = new Bitmap(Q1.Image); G1.AccessibleName = "Q"; }
            else if (G2.Name == QUEENinput) { G2.Image = new Bitmap(Q2.Image); G2.AccessibleName = "Q"; }
            else if (G3.Name == QUEENinput) { G3.Image = new Bitmap(Q1.Image); G3.AccessibleName = "Q"; }
            else if (G4.Name == QUEENinput) { G4.Image = new Bitmap(Q2.Image); G4.AccessibleName = "Q"; }
            else if (G5.Name == QUEENinput) { G5.Image = new Bitmap(Q1.Image); G5.AccessibleName = "Q"; }
            else if (G6.Name == QUEENinput) { G6.Image = new Bitmap(Q2.Image); G6.AccessibleName = "Q"; }
            else if (G7.Name == QUEENinput) { G7.Image = new Bitmap(Q1.Image); G7.AccessibleName = "Q"; }
            else if (G8.Name == QUEENinput) { G8.Image = new Bitmap(Q2.Image); G8.AccessibleName = "Q"; }
            else if (H1.Name == QUEENinput) { H1.Image = new Bitmap(Q2.Image); H1.AccessibleName = "Q"; }
            else if (H2.Name == QUEENinput) { H2.Image = new Bitmap(Q1.Image); H2.AccessibleName = "Q"; }
            else if (H3.Name == QUEENinput) { H3.Image = new Bitmap(Q2.Image); H3.AccessibleName = "Q"; }
            else if (H4.Name == QUEENinput) { H4.Image = new Bitmap(Q1.Image); H4.AccessibleName = "Q"; }
            else if (H5.Name == QUEENinput) { H5.Image = new Bitmap(Q2.Image); H5.AccessibleName = "Q"; }
            else if (H6.Name == QUEENinput) { H6.Image = new Bitmap(Q1.Image); H6.AccessibleName = "Q"; }
            else if (H7.Name == QUEENinput) { H7.Image = new Bitmap(Q2.Image); H7.AccessibleName = "Q"; }
            else if (H8.Name == QUEENinput) { H8.Image = new Bitmap(Q1.Image); H8.AccessibleName = "Q"; }


            else { MessageBox.Show("INPUT ACCEPTABILE RANGE is A1....H8"); goto next; }


            //conversion of current queen coordinates string^ to int


            evaluate();
           
            next:;
        }


        public void evaluate()
        {
            // assinment of "q" to ChessBoard fields fired by queens - queen's "stars"

            for (qXshift = 1; qXshift < 9; qXshift++)
            {
                for (qYshift = 1; qYshift < 9; qYshift++)
                {
                    if (ChessBoard[qXshift, qYshift] == "Q")
                        queenposition(qXshift, qYshift, ChessBoard);
                }
               
            }



            //making "frown" if queen's position is bad or "smile" if  queen's position is good
            if (ChessBoard[CurrentQX, CurrentQY] == "q" || ChessBoard[CurrentQX, CurrentQY] == "Q")
            {
                frown.Visible = true;
                try
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception a) {
                   
                    MessageBox.Show(a.Message);
                    MessageBox.Show("Do not hurry up! Let me finish playing sound...");
                }
            }
            else {
                smile.Visible = true; ++smileCount;
                try
                {
                    backgroundWorker2.RunWorkerAsync();
                }
               catch (Exception b) {
                    
                    MessageBox.Show(b.Message);

                    MessageBox.Show("Do not hurry up! Let me finish playing sound...");
                }
                      }

            if (smileCount == 8 && frown.Visible == false) MessageBox.Show("CONGRATULATIONS - all queens are at the safe places");

        }



        //this handler makes set up for New Game

        private void NewGame_Click(object sender, EventArgs e)
        {

            backgroundWorker3.RunWorkerAsync();
            // New Game dialogue

            MessageBox.Show("New Game /Put each of 8 queens (like a4 or g7) to safe place");        // New Game dialogue

            // remove queens from chessboard
            // remove queens from chessboard
            A1.Image = new Bitmap(Field1.Image);
            A2.Image = new Bitmap(Field2.Image);
            A3.Image = new Bitmap(Field1.Image);
            A4.Image = new Bitmap(Field2.Image);
            A5.Image = new Bitmap(Field1.Image);
            A6.Image = new Bitmap(Field2.Image);
            A7.Image = new Bitmap(Field1.Image);
            A8.Image = new Bitmap(Field2.Image);
            B1.Image = new Bitmap(Field2.Image);
            B2.Image = new Bitmap(Field1.Image);
            B3.Image = new Bitmap(Field2.Image);
            B4.Image = new Bitmap(Field1.Image);
            B5.Image = new Bitmap(Field2.Image);
            B6.Image = new Bitmap(Field1.Image);
            B7.Image = new Bitmap(Field2.Image);
            B8.Image = new Bitmap(Field1.Image);
            C1.Image = new Bitmap(Field1.Image);
            C2.Image = new Bitmap(Field2.Image);
            C3.Image = new Bitmap(Field1.Image);
            C4.Image = new Bitmap(Field2.Image);
            C5.Image = new Bitmap(Field1.Image);
            C6.Image = new Bitmap(Field2.Image);
            C7.Image = new Bitmap(Field1.Image);
            C8.Image = new Bitmap(Field2.Image);
            D1.Image = new Bitmap(Field2.Image);
            D2.Image = new Bitmap(Field1.Image);
            D3.Image = new Bitmap(Field2.Image);
            D4.Image = new Bitmap(Field1.Image);
            D5.Image = new Bitmap(Field2.Image);
            D6.Image = new Bitmap(Field1.Image);
            D7.Image = new Bitmap(Field2.Image);
            D8.Image = new Bitmap(Field1.Image);
            E1.Image = new Bitmap(Field1.Image);
            E2.Image = new Bitmap(Field2.Image);
            E3.Image = new Bitmap(Field1.Image);
            E4.Image = new Bitmap(Field2.Image);
            E5.Image = new Bitmap(Field1.Image);
            E6.Image = new Bitmap(Field2.Image);
            E7.Image = new Bitmap(Field1.Image);
            E8.Image = new Bitmap(Field2.Image);
            F1.Image = new Bitmap(Field2.Image);
            F2.Image = new Bitmap(Field1.Image);
            F3.Image = new Bitmap(Field2.Image);
            F4.Image = new Bitmap(Field1.Image);
            F5.Image = new Bitmap(Field2.Image);
            F6.Image = new Bitmap(Field1.Image);
            F7.Image = new Bitmap(Field2.Image);
            F8.Image = new Bitmap(Field1.Image);
            G1.Image = new Bitmap(Field1.Image);
            G2.Image = new Bitmap(Field2.Image);
            G3.Image = new Bitmap(Field1.Image);
            G4.Image = new Bitmap(Field2.Image);
            G5.Image = new Bitmap(Field1.Image);
            G6.Image = new Bitmap(Field2.Image);
            G7.Image = new Bitmap(Field1.Image);
            G8.Image = new Bitmap(Field2.Image);
            H1.Image = new Bitmap(Field2.Image);
            H2.Image = new Bitmap(Field1.Image);
            H3.Image = new Bitmap(Field2.Image);
            H4.Image = new Bitmap(Field1.Image);
            H5.Image = new Bitmap(Field2.Image);
            H6.Image = new Bitmap(Field1.Image);
            H7.Image = new Bitmap(Field2.Image);
            H8.Image = new Bitmap(Field1.Image);
            A1.AccessibleName = "-";
            A2.AccessibleName = "-";
            A3.AccessibleName = "-";
            A4.AccessibleName = "-";
            A5.AccessibleName = "-";
            A6.AccessibleName = "-";
            A7.AccessibleName = "-";
            A8.AccessibleName = "-";
            B1.AccessibleName = "-";
            B2.AccessibleName = "-";
            B3.AccessibleName = "-";
            B4.AccessibleName = "-";
            B5.AccessibleName = "-";
            B6.AccessibleName = "-";
            B7.AccessibleName = "-";
            B8.AccessibleName = "-";
            C1.AccessibleName = "-";
            C2.AccessibleName = "-";
            C3.AccessibleName = "-";
            C4.AccessibleName = "-";
            C5.AccessibleName = "-";
            C6.AccessibleName = "-";
            C7.AccessibleName = "-";
            C8.AccessibleName = "-";
            D1.AccessibleName = "-";
            D2.AccessibleName = "-";
            D3.AccessibleName = "-";
            D4.AccessibleName = "-";
            D5.AccessibleName = "-";
            D6.AccessibleName = "-";
            D7.AccessibleName = "-";
            D8.AccessibleName = "-";
            E1.AccessibleName = "-";
            E2.AccessibleName = "-";
            E3.AccessibleName = "-";
            E4.AccessibleName = "-";
            E5.AccessibleName = "-";
            E6.AccessibleName = "-";
            E7.AccessibleName = "-";
            E8.AccessibleName = "-";
            F1.AccessibleName = "-";
            F2.AccessibleName = "-";
            F3.AccessibleName = "-";
            F4.AccessibleName = "-";
            F5.AccessibleName = "-";
            F6.AccessibleName = "-";
            F7.AccessibleName = "-";
            F8.AccessibleName = "-";
            G1.AccessibleName = "-";
            G2.AccessibleName = "-";
            G3.AccessibleName = "-";
            G4.AccessibleName = "-";
            G5.AccessibleName = "-";
            G6.AccessibleName = "-";
            G7.AccessibleName = "-";
            G8.AccessibleName = "-";
            H1.AccessibleName = "-";
            H2.AccessibleName = "-";
            H3.AccessibleName = "-";
            H4.AccessibleName = "-";
            H5.AccessibleName = "-";
            H6.AccessibleName = "-";
            H7.AccessibleName = "-";
            H8.AccessibleName = "-";

            //set smileCount to 0 for new game
            smileCount = 0;
            smile.Visible = false;      // remove smile
            frown.Visible = false;      // remove frown

            for (int u = 0; u <= 9; u++)
            {
                for (int w = 0; w <= 9; w++)
                { ChessBoard[u, w] = "-"; }
            }


        }

        //backgroundWorker code for sound accompanying "smile", "frown" and new game start
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "c:\\windows\\media\\chimes.wav";
            player.Load();
            player.PlaySync();
           

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            
            SoundPlayer player = new SoundPlayer();

                player.SoundLocation = "c:\\windows\\media\\tada.wav";
                player.Load();
                player.PlaySync();
           

           
        }

        
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "c:\\windows\\media\\ringout.wav";
            player.Load();
            player.PlaySync();
        }

 

       


        // this function evaluates queens' positions on chessboard 
        string queenposition(int qX_shift, int qY_shift, String[,] Chess_Board)
        {
            for (int j = 1; j < 9; j++)
            {
                //horizontal fields "shot" by queens
                if (Chess_Board[qX_shift, j] != "Q") Chess_Board[qX_shift, j] = "q";

                //vertical fields "shot" by queens
                if (Chess_Board[j, qY_shift] != "Q") Chess_Board[j, qY_shift] = "q";
            }

            //diagonal fields "shot" by queens
            int xnew = qX_shift;
            int ynew = qY_shift;

            while ((xnew < 9) || (ynew < 9))
            {
                if ((xnew == 8) || (ynew == 8)) break;
                xnew = xnew + 1;
                ynew = ynew + 1;
                if (Chess_Board[xnew, ynew] != "Q") Chess_Board[xnew, ynew] = "q";
                if ((xnew == 8) || (ynew == 8)) break;
            }

            xnew = qX_shift;
            ynew = qY_shift;
            while ((xnew >= 1) || (ynew >= 1))
            {
                if ((xnew == 1) || (ynew == 1)) break;
                xnew = xnew - 1;
                ynew = ynew - 1;

                if (Chess_Board[xnew, ynew] != "Q") Chess_Board[xnew, ynew] = "q";
                if ((xnew == 1) || (ynew == 1)) break;
            };

            xnew = qX_shift;
            ynew = qY_shift;
            while ((xnew >= 1) || (ynew < 9))
            {
                if ((xnew == 1) || (ynew == 8)) break;
                xnew = xnew - 1;
                ynew = ynew + 1;

                if (Chess_Board[xnew, ynew] != "Q") Chess_Board[xnew, ynew] = "q";
                if ((xnew == 1) || (ynew == 8)) break;
            };

            xnew = qX_shift;
            ynew = qY_shift;
            while ((xnew < 9) || (ynew >= 1))
            {
                if ((xnew == 8) || (ynew == 1)) break;
                xnew = xnew + 1;
                ynew = ynew - 1;

                if (Chess_Board[xnew, ynew] != "Q") Chess_Board[xnew, ynew] = "q";
                if ((xnew == 8) || (ynew == 1)) break;
            };

            return "0";


        }

//this function copies queens' star positions from GUI chessboard to ChessBoard array
        public void chessboardcopy()
        {


            if (QUEENinput.Substring(0, 1) == "A") CurrentQX = 1;
            if (QUEENinput.Substring(0, 1) == "B") CurrentQX = 2;
            if (QUEENinput.Substring(0, 1) == "C") CurrentQX = 3;
            if (QUEENinput.Substring(0, 1) == "D") CurrentQX = 4;
            if (QUEENinput.Substring(0, 1) == "E") CurrentQX = 5;
            if (QUEENinput.Substring(0, 1) == "F") CurrentQX = 6;
            if (QUEENinput.Substring(0, 1) == "G") CurrentQX = 7;
            if (QUEENinput.Substring(0, 1) == "H") CurrentQX = 8;

            if (QUEENinput.Substring(1, 1) == "1") CurrentQY = 1;
            if (QUEENinput.Substring(1, 1) == "2") CurrentQY = 2;
            if (QUEENinput.Substring(1, 1) == "3") CurrentQY = 3;
            if (QUEENinput.Substring(1, 1) == "4") CurrentQY = 4;
            if (QUEENinput.Substring(1, 1) == "5") CurrentQY = 5;
            if (QUEENinput.Substring(1, 1) == "6") CurrentQY = 6;
            if (QUEENinput.Substring(1, 1) == "7") CurrentQY = 7;
            if (QUEENinput.Substring(1, 1) == "8") CurrentQY = 8;


            if (A1.AccessibleName == "Q") ChessBoard[1, 1]="Q";
if (A2.AccessibleName == "Q") ChessBoard[1, 2]="Q";
if (A3.AccessibleName == "Q") ChessBoard[1, 3]="Q";
if (A4.AccessibleName == "Q") ChessBoard[1, 4]="Q";
if (A5.AccessibleName == "Q") ChessBoard[1, 5]="Q";
if (A6.AccessibleName == "Q") ChessBoard[1, 6]="Q";
if (A7.AccessibleName == "Q") ChessBoard[1, 7]="Q";
if (A8.AccessibleName == "Q") ChessBoard[1, 8]="Q";

if (B1.AccessibleName == "Q") ChessBoard[2, 1]="Q";
if (B2.AccessibleName == "Q") ChessBoard[2, 2]="Q";
if (B3.AccessibleName == "Q") ChessBoard[2, 3]="Q";
if (B4.AccessibleName == "Q") ChessBoard[2, 4]="Q";
if (B5.AccessibleName == "Q") ChessBoard[2, 5]="Q";
if (B6.AccessibleName == "Q") ChessBoard[2, 6]="Q";
if (B7.AccessibleName == "Q") ChessBoard[2, 7]="Q";
if (B8.AccessibleName == "Q") ChessBoard[2, 8]="Q";

if (C1.AccessibleName == "Q") ChessBoard[3, 1]="Q";
if (C2.AccessibleName == "Q") ChessBoard[3, 2]="Q";
if (C3.AccessibleName == "Q") ChessBoard[3, 3]="Q";
if (C4.AccessibleName == "Q") ChessBoard[3, 4]="Q";
if (C5.AccessibleName == "Q") ChessBoard[3, 5]="Q";
if (C6.AccessibleName == "Q") ChessBoard[3, 6]="Q";
if (C7.AccessibleName == "Q") ChessBoard[3, 7]="Q";
if (C8.AccessibleName == "Q") ChessBoard[3, 8]="Q";

if (D1.AccessibleName == "Q") ChessBoard[4, 1]="Q";
if (D2.AccessibleName == "Q") ChessBoard[4, 2]="Q";
if (D3.AccessibleName == "Q") ChessBoard[4, 3]="Q";
if (D4.AccessibleName == "Q") ChessBoard[4, 4]="Q";
if (D5.AccessibleName == "Q") ChessBoard[4, 5]="Q";
if (D6.AccessibleName == "Q") ChessBoard[4, 6]="Q";
if (D7.AccessibleName == "Q") ChessBoard[4, 7]="Q";
if (D8.AccessibleName == "Q") ChessBoard[4, 8]="Q";

if (E1.AccessibleName == "Q") ChessBoard[5, 1]="Q";
if (E2.AccessibleName == "Q") ChessBoard[5, 2]="Q";
if (E3.AccessibleName == "Q") ChessBoard[5, 3]="Q";
if (E4.AccessibleName == "Q") ChessBoard[5, 4]="Q";
if (E5.AccessibleName == "Q") ChessBoard[5, 5]="Q";
if (E6.AccessibleName == "Q") ChessBoard[5, 6]="Q";
if (E7.AccessibleName == "Q") ChessBoard[5, 7]="Q";
if (E8.AccessibleName == "Q") ChessBoard[5, 8]="Q";

if (F1.AccessibleName == "Q") ChessBoard[6, 1]="Q";
if (F2.AccessibleName == "Q") ChessBoard[6, 2]="Q";
if (F3.AccessibleName == "Q") ChessBoard[6, 3]="Q";
if (F4.AccessibleName == "Q") ChessBoard[6, 4]="Q";
if (F5.AccessibleName == "Q") ChessBoard[6, 5]="Q";
if (F6.AccessibleName == "Q") ChessBoard[6, 6]="Q";
if (F7.AccessibleName == "Q") ChessBoard[6, 7]="Q";
if (F8.AccessibleName == "Q") ChessBoard[6, 8]="Q";

if (G1.AccessibleName == "Q") ChessBoard[7, 1]="Q";
if (G2.AccessibleName == "Q") ChessBoard[7, 2]="Q";
if (G3.AccessibleName == "Q") ChessBoard[7, 3]="Q";
if (G4.AccessibleName == "Q") ChessBoard[7, 4]="Q";
if (G5.AccessibleName == "Q") ChessBoard[7, 5]="Q";
if (G6.AccessibleName == "Q") ChessBoard[7, 6]="Q";
if (G7.AccessibleName == "Q") ChessBoard[7, 7]="Q";
if (G8.AccessibleName == "Q") ChessBoard[7, 8]="Q";

if (H1.AccessibleName == "Q") ChessBoard[8, 1]="Q";
if (H2.AccessibleName == "Q") ChessBoard[8, 2]="Q";
if (H3.AccessibleName == "Q") ChessBoard[8, 3]="Q";
if (H4.AccessibleName == "Q") ChessBoard[8, 4]="Q";
if (H5.AccessibleName == "Q") ChessBoard[8, 5]="Q";
if (H6.AccessibleName == "Q") ChessBoard[8, 6]="Q";
if (H7.AccessibleName == "Q") ChessBoard[8, 7]="Q";
if (H8.AccessibleName == "Q") ChessBoard[8, 8]="Q";

}

      
    }





        } 



        
