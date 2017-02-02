using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pac_man
{
    public partial class Form1 : Form
    {
        int moveX = 0;
        int moveY = 0;
        int GmoveX = 0;
        int GmoveY = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    moveX = 0;
                    moveY = -5;
                    eatscore();
                    pacman.Image = pac_man.Properties.Resources.pacmanUp;
                    break;
                case Keys.Left:
                    moveX = -5;
                    moveY = 0;
                    eatscore();
                    pacman.Image = pac_man.Properties.Resources.pacmanLeft;
                    break;
                case Keys.Right:
                    moveX = 5;
                    moveY = 0;
                    eatscore();
                    pacman.Image = pac_man.Properties.Resources.pacmanRight;
                    break;
                case Keys.Down:
                    moveX = 0;
                    moveY = 5;
                    pacman.Image = pac_man.Properties.Resources.pacmanDown;
                    eatscore();
                    break;
            }
            timer.Enabled = true;
            timer1.Enabled = true;
        }
        bool eatghost = false;
        int Eatghost = 100;
        void eatscore()
        {
            Rectangle tempRect = new Rectangle(pacman.Location.X + moveX, pacman.Location.Y + moveY, pacman.Width, pacman.Height);

            for (int i = 0; i < 146; i++)
            {
                if ((tempRect.IntersectsWith(beans[i])) && eatbeans[i] == 0)
                {
                    img[i].Image = pac_man.Properties.Resources.black;
                    eatbeans[i] = 1;
                    score = score + 10;
                    label1.Text = score.ToString();
                }
            }
            for (int i = 146; i < 150; i++)
            {
                if ((tempRect.IntersectsWith(beans[i])) && eatbeans[i] == 0)
                {
                    img[i].Image = pac_man.Properties.Resources.black;
                    eatbeans[i] = 1;
                    score = score + 10;
                    label1.Text = score.ToString();
                    eatghost = true;
                    timer.Interval = 70;
                    Eatghost = 0;
                    ghost1.Image = pac_man.Properties.Resources.ghost;
                    ghost2.Image = pac_man.Properties.Resources.ghost;
                    ghost3.Image = pac_man.Properties.Resources.ghost;
                    ghost4.Image = pac_man.Properties.Resources.ghost;
                    label3.Text = "快吃他!!";
                }
            }
        }
        Rectangle[] block;
        PictureBox[] img;
        Rectangle[] rects;
        Rectangle[] beans;
        PictureBox[] wall;
        int[] eatbeans = new int[150];

        void CreateBeans()
        {
            beans = new Rectangle[150];
            img = new PictureBox[150];
            img[0] = pictureBox1;
            img[1] = pictureBox2;
            img[2] = pictureBox3;
            img[3] = pictureBox4;
            img[4] = pictureBox5;
            img[5] = pictureBox6;
            img[6] = pictureBox7;
            img[7] = pictureBox8;
            img[8] = pictureBox9;
            img[9] = pictureBox10;
            img[10] = pictureBox11;
            img[11] = pictureBox12;
            img[12] = pictureBox13;
            img[13] = pictureBox14;
            img[14] = pictureBox15;
            img[15] = pictureBox16;
            img[16] = pictureBox17;
            img[17] = pictureBox18;
            img[18] = pictureBox19;
            img[19] = pictureBox20;
            img[20] = pictureBox21;
            img[21] = pictureBox22;
            img[22] = pictureBox23;
            img[23] = pictureBox24;
            img[24] = pictureBox25;
            img[25] = pictureBox26;
            img[26] = pictureBox27;
            img[27] = pictureBox28;
            img[28] = pictureBox29;
            img[29] = pictureBox30;
            img[30] = pictureBox31;
            img[31] = pictureBox32;
            img[32] = pictureBox33;
            img[33] = pictureBox34;
            img[34] = pictureBox35;
            img[35] = pictureBox36;
            img[36] = pictureBox37;
            img[37] = pictureBox38;
            img[38] = pictureBox39;
            img[39] = pictureBox40;
            img[40] = pictureBox41;
            img[41] = pictureBox42;
            img[42] = pictureBox43;
            img[43] = pictureBox44;
            img[44] = pictureBox45;
            img[45] = pictureBox46;
            img[46] = pictureBox47;
            img[47] = pictureBox48;
            img[48] = pictureBox49;
            img[49] = pictureBox50;
            img[50] = pictureBox51;
            img[51] = pictureBox52;
            img[52] = pictureBox53;
            img[53] = pictureBox54;
            img[54] = pictureBox55;
            img[55] = pictureBox56;
            img[56] = pictureBox57;
            img[57] = pictureBox58;
            img[58] = pictureBox59;
            img[59] = pictureBox60;
            img[60] = pictureBox61;
            img[61] = pictureBox62;
            img[62] = pictureBox63;
            img[63] = pictureBox64;
            img[64] = pictureBox65;
            img[65] = pictureBox66;
            img[66] = pictureBox67;
            img[67] = pictureBox68;
            img[68] = pictureBox69;
            img[69] = pictureBox70;
            img[70] = pictureBox71;
            img[71] = pictureBox72;
            img[72] = pictureBox73;
            img[73] = pictureBox74;
            img[74] = pictureBox75;
            img[75] = pictureBox76;
            img[76] = pictureBox79;
            img[77] = pictureBox81;
            img[78] = pictureBox84;
            img[79] = pictureBox89;
            img[80] = pictureBox92;
            img[81] = pictureBox94;
            img[82] = pictureBox96;
            img[83] = pictureBox108;
            img[84] = pictureBox109;
            img[85] = pictureBox110;
            img[86] = pictureBox111;
            img[87] = pictureBox112;
            img[88] = pictureBox113;
            img[89] = pictureBox114;
            img[90] = pictureBox115;
            img[91] = pictureBox116;
            img[92] = pictureBox117;
            img[93] = pictureBox118;
            img[94] = pictureBox119;
            img[95] = pictureBox120;
            img[96] = pictureBox121;
            img[97] = pictureBox122;
            img[98] = pictureBox125;
            img[99] = pictureBox126;
            img[100] = pictureBox127;
            img[101] = pictureBox128;
            img[102] = pictureBox129;
            img[103] = pictureBox130;
            img[104] = pictureBox131;
            img[105] = pictureBox132;
            img[106] = pictureBox133;
            img[107] = pictureBox134;
            img[108] = pictureBox135;
            img[109] = pictureBox136;
            img[110] = pictureBox137;
            img[111] = pictureBox138;
            img[112] = pictureBox139;
            img[113] = pictureBox140;
            img[114] = pictureBox141;
            img[115] = pictureBox142;
            img[116] = pictureBox143;
            img[117] = pictureBox144;
            img[118] = pictureBox145;
            img[119] = pictureBox146;
            img[120] = pictureBox147;
            img[121] = pictureBox148;
            img[122] = pictureBox149;
            img[123] = pictureBox150;
            img[124] = pictureBox151;
            img[125] = pictureBox152;
            img[126] = pictureBox153;
            img[127] = pictureBox154;
            img[128] = pictureBox155;
            img[129] = pictureBox156;
            img[130] = pictureBox157;
            img[131] = pictureBox158;
            img[132] = pictureBox159;
            img[133] = pictureBox160;
            img[134] = pictureBox161;
            img[135] = pictureBox162;
            img[136] = pictureBox163;
            img[137] = pictureBox164;
            img[138] = pictureBox165;
            img[139] = pictureBox166;
            img[140] = pictureBox167;
            img[141] = pictureBox168;
            img[142] = pictureBox169;
            img[143] = pictureBox170;
            img[144] = pictureBox171;
            img[145] = pictureBox172;
            img[146] = bigbean1;
            img[147] = bigbean2;
            img[148] = bigbean3;
            img[149] = bigbean4;
            for (int i = 0; i < 150; i++)
            {
                beans[i] = new Rectangle(img[i].Location.X, img[i].Location.Y, img[i].Width, img[i].Height);
            }
        }

        void CreateOutOfBounds()
        {
            block = new Rectangle[2];
            rects = new Rectangle[50];
            wall = new PictureBox[50];
            block[0] = new Rectangle(block1.Location.X, block1.Location.Y, block1.Width, block1.Height);
            block[1] = new Rectangle(block2.Location.X, block2.Location.Y, block2.Width, block2.Height);
            wall[0] = wall1;
            wall[1] = wall2;
            wall[2] = wall3;
            wall[3] = wall4;
            wall[4] = wall5;
            wall[5] = wall6;
            wall[6] = wall7;
            wall[7] = wall8;
            wall[8] = wall9;
            wall[9] = wall10;
            wall[10] = wall11;
            wall[11] = wall12;
            wall[12] = wall13;
            wall[13] = wall14;
            wall[14] = wall15;
            wall[15] = wall16;
            wall[16] = wall17;
            wall[17] = wall18;
            wall[18] = wall19;
            wall[19] = wall20;
            wall[20] = wall21;
            wall[21] = wall22;
            wall[22] = wall23;
            wall[23] = wall24;
            wall[24] = wall25;
            wall[25] = wall26;
            wall[26] = wall27;
            wall[27] = wall28;
            wall[28] = wall29;
            wall[29] = wall30;
            wall[30] = wall31;
            wall[31] = wall32;
            wall[32] = wall33;
            wall[33] = wall34;
            wall[34] = wall35;
            wall[35] = wall36;
            wall[36] = wall37;
            wall[37] = wall38;
            wall[38] = wall39;
            wall[39] = wall40;
            wall[40] = wall41;
            wall[41] = wall42;
            wall[42] = wall43;
            wall[43] = wall44;
            wall[44] = wall45;
            wall[45] = wall46;
            wall[46] = wall47;
            wall[47] = wall48;
            wall[48] = wall49;
            wall[49] = wall50;
            for (int i = 0; i < 50; i++)
            {
                rects[i] = new Rectangle(wall[i].Location.X, wall[i].Location.Y, wall[i].Width, wall[i].Height);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CreateOutOfBounds();
            CreateBeans();
        }
        bool CheckBounds()
        {
            Rectangle tempRect = new Rectangle(pacman.Location.X + moveX, pacman.Location.Y + moveY, pacman.Width, pacman.Height);

            bool tempReturn = true;

            for (int i = 0; i < 50; i++)
            {
                if (tempRect.IntersectsWith(rects[i]))
                    tempReturn = false;
            }
            if (tempRect.IntersectsWith(block[0]))
            {
                pacman.Location = new Point(728, 275);
                tempReturn = false;
            }
            if (tempRect.IntersectsWith(block[1]))
            {
                pacman.Location = new Point(162, 275);
                tempReturn = false;
            }
            return tempReturn;
        }
        int lifeleft = 3;
        void Checklife()
        {
            Rectangle tempRect = new Rectangle(pacman.Location.X + moveX, pacman.Location.Y + moveY, pacman.Width, pacman.Height);
            ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
            ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
            ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
            ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
            for (int i = 0; i < 4; i++)
            {
                if (tempRect.IntersectsWith(ghosts[i]))
                {
                    timer.Stop();
                    timer1.Stop();
                    MessageBox.Show("被鬼碰到了喔!!");
                    lifeleft--;
                    if (lifeleft == 2)
                    {
                        life1.Image = pac_man.Properties.Resources.black;
                    }
                    if (lifeleft == 1)
                    {
                        life2.Image = pac_man.Properties.Resources.black;
                    }
                    if (lifeleft == 0)
                    {
                        life3.Image = pac_man.Properties.Resources.black;
                        MessageBox.Show("Game over!!");
                        End();
                        this.Close();
                    }
                    ghost1.Location = new Point(396, 260);
                    ghost2.Location = new Point(431, 260);
                    ghost3.Location = new Point(463, 260);
                    ghost4.Location = new Point(396, 289);
                    pacman.Image = pac_man.Properties.Resources.pacmanRight;
                    pacman.Location = new Point(447, 438);
                    ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
                    ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
                    ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
                    ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
                    B = 0;
                }
            }
        }
        Random rnd = new Random();
        int Gway = 2;
        int B = 0;
        Rectangle[] ghosts = new Rectangle[4];
        void Ghost1()
        {
            if (pacman.Location.Y < 220)
            {
                if (Gway == 1)//up
                {
                    GmoveX = -10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost1))
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost1))
                            Gway = rnd.Next(1, 3);
                        else
                            Gway = 2;
                    }
                    else
                    {
                        GmoveX = 10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost1))
                        {
                            GmoveX = 0;
                            GmoveY = -10;
                            if (CheckghostBound(ghost1))
                            {
                                Gway = rnd.Next(1, 3);
                                if (Gway == 2)
                                    Gway = 3;
                            }
                            else
                                Gway = 3;
                        }
                    }
                }
                if (Gway == 2)//left
                {
                    GmoveX = 0;
                    GmoveY = -10;
                    if (CheckghostBound(ghost1))
                    {
                        Gway = 1;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost1))
                        {
                            GmoveX = -10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost1))
                            {
                                Gway = rnd.Next(2, 5);
                                if (Gway == 3)
                                    Gway = 2;
                            }
                            else
                                Gway = 4;
                        }
                    }
                }
                if (Gway == 3)//right
                {
                    GmoveX = 0;
                    GmoveY = -10;
                    if (CheckghostBound(ghost1))
                    {
                        Gway = 1;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost1))
                        {
                            GmoveX = 10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost1))
                            {
                                Gway = rnd.Next(2, 5);
                                if (Gway == 2)
                                    Gway = 3;

                            }
                            else
                                Gway = 4;
                        }
                    }

                }
                if (Gway == 4)//down
                {
                    GmoveX = -10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost1))
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost1))
                        {
                            Gway = rnd.Next(2, 4);
                            if (Gway == 3)
                                Gway = 4;
                        }
                        else
                            Gway = 2;
                    }
                    else
                    {
                        GmoveX = 10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost1))
                        {
                            GmoveX = 0;
                            GmoveY = 10;
                            if (CheckghostBound(ghost1))
                                Gway = rnd.Next(3, 5);
                            else
                                Gway = 3;
                        }
                    }
                }
            }
            if (pacman.Location.Y > 220)
            {
                if (Gway == 1)//up
                {
                    GmoveX = 10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost1))
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost1))
                        {
                            Gway = rnd.Next(1, 3);
                            if (Gway == 2)
                                Gway = 3;
                        }
                        else
                            Gway = 3;
                    }
                    else
                    {
                        GmoveX = -10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost1))
                        {
                            GmoveX = 0;
                            GmoveY = -10;
                            if (CheckghostBound(ghost1))
                                Gway = rnd.Next(1, 3);
                            else
                                Gway = 2;
                        }
                    }
                }
                if (Gway == 2)//left
                {
                    GmoveX = 0;
                    GmoveY = 10;
                    if (CheckghostBound(ghost1))
                    {
                        Gway = 4;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost1))
                        {
                            GmoveX = -10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost1))
                            {
                                Gway = rnd.Next(1, 4);
                                if (Gway == 3)
                                    Gway = 2;
                            }
                            else
                                Gway = 1;
                        }
                    }
                }
                if (Gway == 3)//right
                {
                    GmoveX = 0;
                    GmoveY = 10;
                    if (CheckghostBound(ghost1))
                    {
                        Gway = 4;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost1))
                        {
                            GmoveX = 10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost1))
                            {
                                Gway = rnd.Next(1, 4);
                                if (Gway == 2)
                                    Gway = 3;
                            }
                            else
                                Gway = 1;
                        }
                    }

                }
                if (Gway == 4)//down
                {
                    GmoveX = 10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost1))
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost1))
                            Gway = rnd.Next(3, 5);
                        else
                            Gway = 3;
                    }
                    else
                    {
                        GmoveX = -10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost1))
                        {
                            GmoveX = 0;
                            GmoveY = 10;
                            if (CheckghostBound(ghost1))
                            {
                                Gway = rnd.Next(2, 4);
                                if (Gway == 3)
                                    Gway = 4;
                            }
                            else
                                Gway = 2;
                        }
                    }
                }
            }
            if (Gway == 1)//UP
            {
                GmoveX = 0;
                GmoveY = -5;
            }
            if (Gway == 2)//LEFT
            {
                GmoveX = -5;
                GmoveY = 0;
            }
            if (Gway == 3)//RIGHT
            {
                GmoveX = 5;
                GmoveY = 0;
            }
            if (Gway == 4)//DOWN
            {
                GmoveX = 0;
                GmoveY = 5;
            }
            if (CheckghostBound(ghost1))
            {
                ghost1.Location = new Point(ghost1.Location.X + GmoveX, ghost1.Location.Y + GmoveY);
                ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
                if (eatghost)
                {
                    EATGHOST();
                }
                else
                {
                    if (ghosts[0].IntersectsWith(Pacman))
                    {
                        timer.Stop();
                        timer1.Stop();
                        MessageBox.Show("被鬼碰到了喔!!");
                        lifeleft--;
                        if (lifeleft == 2)
                        {
                            life1.Image = pac_man.Properties.Resources.black;
                        }
                        if (lifeleft == 1)
                        {
                            life2.Image = pac_man.Properties.Resources.black;
                        }
                        if (lifeleft == 0)
                        {
                            life3.Image = pac_man.Properties.Resources.black;
                            MessageBox.Show("Game over!!");
                            End();
                            this.Close();
                        }
                        ghost1.Location = new Point(396, 260);
                        ghost2.Location = new Point(431, 260);
                        ghost3.Location = new Point(463, 260);
                        ghost4.Location = new Point(396, 289);
                        pacman.Image = pac_man.Properties.Resources.pacmanRight;
                        pacman.Location = new Point(447, 438);
                        ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
                        ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
                        ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
                        ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
                        B = 0;
                    }
                }
            }
            ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);

        }
        int Gway2 = 3;
        void Ghost2()
        {
            if (pacman.Location.Y < 220)
            {
                if (Gway2 == 1)//up
                {
                    GmoveX = -10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost2))
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost2))
                            Gway2 = rnd.Next(1, 3);
                        else
                            Gway2 = 2;
                    }
                    else
                    {
                        GmoveX = 10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost2))
                        {
                            GmoveX = 0;
                            GmoveY = -10;
                            if (CheckghostBound(ghost2))
                            {
                                Gway2 = rnd.Next(1, 3);
                                if (Gway2 == 2)
                                    Gway2 = 3;
                            }
                            else
                                Gway2 = 3;
                        }
                    }
                }
                if (Gway2 == 2)//left
                {
                    GmoveX = 0;
                    GmoveY = -10;
                    if (CheckghostBound(ghost2))
                    {
                        Gway2 = 1;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost2))
                        {
                            GmoveX = -10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost2))
                            {
                                Gway2 = rnd.Next(3, 6);
                                if (Gway2 == 3 || Gway2 == 5)
                                    Gway2 = 2;
                            }
                            else
                                Gway2 = 4;
                        }

                    }
                }
                if (Gway2 == 3)//right
                {
                    GmoveX = 0;
                    GmoveY = -10;
                    if (CheckghostBound(ghost2))
                    {
                        Gway2 = 1;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost2))
                        {
                            GmoveX = 10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost2))
                            {
                                Gway2 = rnd.Next(2, 5);
                                if (Gway2 == 2)
                                    Gway2 = 3;
                            }
                            else
                                Gway2 = 4;
                        }
                    }

                }
                if (Gway2 == 4)//down
                {
                    GmoveX = -10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost2))
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost2))
                        {
                            Gway2 = rnd.Next(2, 4);
                            if (Gway2 == 3)
                                Gway2 = 4;
                        }
                        else
                            Gway2 = 2;
                    }
                    else
                    {
                        GmoveX = 10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost2))
                        {
                            GmoveX = 0;
                            GmoveY = 10;
                            if (CheckghostBound(ghost2))
                                Gway2 = rnd.Next(3, 5);
                            else
                                Gway2 = 3;
                        }
                    }
                }
            }
            if (pacman.Location.Y > 220)
            {
                if (Gway2 == 1)//up
                {
                    GmoveX = 10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost2))
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost2))
                        {
                            Gway2 = rnd.Next(1, 3);
                            if (Gway2 == 2)
                                Gway2 = 3;
                        }
                        else
                            Gway2 = 3;
                    }
                    else
                    {
                        GmoveX = -10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost2))
                        {
                            GmoveX = 0;
                            GmoveY = -10;
                            if (CheckghostBound(ghost2))
                                Gway2 = rnd.Next(1, 3);
                            else
                                Gway2 = 2;
                        }
                    }
                }
                if (Gway2 == 2)//left
                {
                    GmoveX = 0;
                    GmoveY = 10;
                    if (CheckghostBound(ghost2))
                    {
                        Gway2 = 4;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost2))
                        {
                            GmoveX = -10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost2))
                            {
                                Gway2 = rnd.Next(1, 4);
                                if (Gway2 == 3)
                                    Gway2 = 2;
                            }
                            else
                                Gway2 = 1;
                        }
                    }
                }
                if (Gway2 == 3)//right
                {
                    GmoveX = 0;
                    GmoveY = 10;
                    if (CheckghostBound(ghost2))
                    {
                        Gway2 = 4;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost2))
                        {
                            GmoveX = 10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost2))
                            {
                                Gway2 = rnd.Next(1, 4);
                                if (Gway2 == 2)
                                    Gway2 = 3;
                            }
                            else
                                Gway2 = 1;
                        }
                    }

                }
                if (Gway2 == 4)//down
                {
                    GmoveX = 10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost2))
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost2))
                            Gway2 = rnd.Next(3, 5);
                        else
                            Gway2 = 3;
                    }
                    else
                    {
                        GmoveX = -10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost2))
                        {
                            GmoveX = 0;
                            GmoveY = 10;
                            if (CheckghostBound(ghost2))
                            {
                                Gway2 = rnd.Next(2, 4);
                                if (Gway2 == 3)
                                    Gway2 = 4;
                            }
                            else
                                Gway2 = 2;
                        }
                    }
                }
            }
            if (Gway2 == 1)//UP
            {
                GmoveX = 0;
                GmoveY = -5;
            }
            if (Gway2 == 2)//LEFT
            {
                GmoveX = -5;
                GmoveY = 0;
            }
            if (Gway2 == 3)//RIGHT
            {
                GmoveX = 5;
                GmoveY = 0;
            }
            if (Gway2 == 4)//DOWN
            {
                GmoveX = 0;
                GmoveY = 5;
            }
            if (CheckghostBound(ghost2))
            {
                ghost2.Location = new Point(ghost2.Location.X + GmoveX, ghost2.Location.Y + GmoveY);
                ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
                if (eatghost)
                {
                    EATGHOST();
                }
                else
                {
                    if (ghosts[1].IntersectsWith(Pacman))
                    {
                        timer.Stop();
                        timer1.Stop();
                        MessageBox.Show("被鬼碰到了喔!!");
                        lifeleft--;
                        if (lifeleft == 2)
                        {
                            life1.Image = pac_man.Properties.Resources.black;
                        }
                        if (lifeleft == 1)
                        {
                            life2.Image = pac_man.Properties.Resources.black;
                        }
                        if (lifeleft == 0)
                        {
                            life3.Image = pac_man.Properties.Resources.black;
                            MessageBox.Show("Game over!!");
                            End();
                            this.Close();
                        }
                        ghost1.Location = new Point(396, 260);
                        ghost2.Location = new Point(431, 260);
                        ghost3.Location = new Point(463, 260);
                        ghost4.Location = new Point(396, 289);
                        pacman.Image = pac_man.Properties.Resources.pacmanRight;
                        pacman.Location = new Point(447, 438);
                        ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
                        ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
                        ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
                        ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
                        B = 0;
                    }
                }
            }
            ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
        }
        int Gway3 = 2;
        void Ghost3()
        {
            if (pacman.Location.Y < 220)
            {
                if (Gway3 == 1)//up
                {
                    GmoveX = -10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost3))
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost3))
                            Gway3 = rnd.Next(1, 3);
                        else
                            Gway3 = 2;
                    }
                    else
                    {
                        GmoveX = 10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost3))
                        {
                            GmoveX = 0;
                            GmoveY = -10;
                            if (CheckghostBound(ghost3))
                            {
                                Gway3 = rnd.Next(1, 3);
                                if (Gway3 == 2)
                                    Gway3 = 3;
                            }
                            else
                                Gway3 = 3;
                        }
                    }
                }
                if (Gway3 == 2)//left
                {
                    GmoveX = 0;
                    GmoveY = -10;
                    if (CheckghostBound(ghost3))
                    {
                        Gway3 = 1;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost3))
                        {
                            GmoveX = -10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost3))
                            {
                                Gway3 = rnd.Next(3, 6);
                                if (Gway3 == 3 || Gway3 == 5)
                                    Gway3 = 2;
                            }
                            else
                                Gway3 = 4;
                        }

                    }
                }
                if (Gway3 == 3)//right
                {
                    GmoveX = 0;
                    GmoveY = -10;
                    if (CheckghostBound(ghost3))
                    {
                        Gway3 = 1;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost3))
                        {
                            GmoveX = 10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost3))
                            {
                                Gway3 = rnd.Next(2, 5);
                                if (Gway3 == 2)
                                    Gway3 = 3;
                            }
                            else
                                Gway3 = 4;
                        }
                    }

                }
                if (Gway3 == 4)//down
                {
                    GmoveX = -10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost3))
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost3))
                        {
                            Gway3 = rnd.Next(2, 4);
                            if (Gway3 == 3)
                                Gway3 = 4;
                        }
                        else
                            Gway3 = 2;
                    }
                    else
                    {
                        GmoveX = 10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost3))
                        {
                            GmoveX = 0;
                            GmoveY = 10;
                            if (CheckghostBound(ghost3))
                                Gway3 = rnd.Next(3, 5);
                            else
                                Gway3 = 3;
                        }
                    }
                }
            }
            if (pacman.Location.Y > 220)
            {
                if (Gway3 == 1)//up
                {
                    GmoveX = 10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost3))
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost3))
                        {
                            Gway3 = rnd.Next(1, 3);
                            if (Gway3 == 2)
                                Gway3 = 3;
                        }
                        else
                            Gway3 = 3;
                    }
                    else
                    {
                        GmoveX = -10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost3))
                        {
                            GmoveX = 0;
                            GmoveY = -10;
                            if (CheckghostBound(ghost3))
                                Gway3 = rnd.Next(1, 3);
                            else
                                Gway3 = 2;
                        }
                    }
                }
                if (Gway3 == 2)//left
                {
                    GmoveX = 0;
                    GmoveY = 10;
                    if (CheckghostBound(ghost3))
                    {
                        Gway3 = 4;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost3))
                        {
                            GmoveX = -10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost3))
                            {
                                Gway3 = rnd.Next(1, 4);
                                if (Gway3 == 3)
                                    Gway3 = 2;
                            }
                            else
                                Gway3 = 1;
                        }
                    }
                }
                if (Gway3 == 3)//right
                {
                    GmoveX = 0;
                    GmoveY = 10;
                    if (CheckghostBound(ghost3))
                    {
                        Gway3 = 4;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost3))
                        {
                            GmoveX = 10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost3))
                            {
                                Gway3 = rnd.Next(1, 4);
                                if (Gway3 == 2)
                                    Gway3 = 3;
                            }
                            else
                                Gway3 = 1;
                        }
                    }

                }
                if (Gway3 == 4)//down
                {
                    GmoveX = 10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost3))
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost3))
                            Gway3 = rnd.Next(3, 5);
                        else
                            Gway3 = 3;
                    }
                    else
                    {
                        GmoveX = -10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost3))
                        {
                            GmoveX = 0;
                            GmoveY = 10;
                            if (CheckghostBound(ghost3))
                            {
                                Gway3 = rnd.Next(2, 4);
                                if (Gway3 == 3)
                                    Gway3 = 4;
                            }
                            else
                                Gway3 = 2;
                        }
                    }
                }
            }
            if (Gway3 == 1)//UP
            {
                GmoveX = 0;
                GmoveY = -5;
            }
            if (Gway3 == 2)//LEFT
            {
                GmoveX = -5;
                GmoveY = 0;
            }
            if (Gway3 == 3)//RIGHT
            {
                GmoveX = 5;
                GmoveY = 0;
            }
            if (Gway3 == 4)//DOWN
            {
                GmoveX = 0;
                GmoveY = 5;
            }
            if (CheckghostBound(ghost3))
            {
                ghost3.Location = new Point(ghost3.Location.X + GmoveX, ghost3.Location.Y + GmoveY);
                ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
                if (eatghost)
                {
                    EATGHOST();
                }
                else
                {
                    if (ghosts[2].IntersectsWith(Pacman))
                    {
                        timer.Stop();
                        timer1.Stop();
                        MessageBox.Show("被鬼碰到了喔!!");
                        lifeleft--;
                        if (lifeleft == 2)
                        {
                            life1.Image = pac_man.Properties.Resources.black;
                        }
                        if (lifeleft == 1)
                        {
                            life2.Image = pac_man.Properties.Resources.black;
                        }
                        if (lifeleft == 0)
                        {
                            life3.Image = pac_man.Properties.Resources.black;
                            MessageBox.Show("Game over!!");
                            End();
                            this.Close();
                        }
                        ghost1.Location = new Point(396, 260);
                        ghost2.Location = new Point(431, 260);
                        ghost3.Location = new Point(463, 260);
                        ghost4.Location = new Point(396, 289);
                        pacman.Image = pac_man.Properties.Resources.pacmanRight;
                        pacman.Location = new Point(447, 438);
                        ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
                        ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
                        ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
                        ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
                        B = 0;
                    }
                }
            }
            ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
        }
        int Gway4 = 3;
        void Ghost4()
        {
            if (pacman.Location.Y < 220)
            {
                if (Gway4 == 1)//up
                {
                    GmoveX = -10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost4))
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost4))
                            Gway4 = rnd.Next(1, 3);
                        else
                            Gway4 = 2;
                    }
                    else
                    {
                        GmoveX = 10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost4))
                        {
                            GmoveX = 0;
                            GmoveY = -10;
                            if (CheckghostBound(ghost4))
                            {
                                Gway4 = rnd.Next(1, 3);
                                if (Gway4 == 2)
                                    Gway4 = 3;
                            }
                            else
                                Gway4 = 3;
                        }
                    }
                }
                if (Gway4 == 2)//left
                {
                    GmoveX = 0;
                    GmoveY = -10;
                    if (CheckghostBound(ghost4))
                    {
                        Gway4 = 1;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost4))
                        {
                            GmoveX = -10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost4))
                            {
                                Gway4 = rnd.Next(2, 5);
                                if (Gway4 == 3)
                                    Gway4 = 2;
                            }
                            else
                                Gway4 = 4;
                        }
                    }
                }
                if (Gway4 == 3)//right
                {
                    GmoveX = 0;
                    GmoveY = -10;
                    if (CheckghostBound(ghost4))
                    {
                        Gway4 = 1;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost4))
                        {
                            GmoveX = 10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost4))
                            {
                                Gway4 = rnd.Next(2, 5);
                                if (Gway4 == 2)
                                    Gway4 = 3;

                            }
                            else
                                Gway4 = 4;
                        }
                    }

                }
                if (Gway4 == 4)//down
                {
                    GmoveX = -10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost4))
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost4))
                        {
                            Gway4 = rnd.Next(2, 4);
                            if (Gway4 == 3)
                                Gway4 = 4;
                        }
                        else
                            Gway4 = 2;
                    }
                    else
                    {
                        GmoveX = 10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost4))
                        {
                            GmoveX = 0;
                            GmoveY = 10;
                            if (CheckghostBound(ghost4))
                                Gway4 = rnd.Next(3, 5);
                            else
                                Gway4 = 3;
                        }
                    }
                }
            }
            if (pacman.Location.Y > 220)
            {
                if (Gway4 == 1)//up
                {
                    GmoveX = 10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost4))
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost4))
                        {
                            Gway4 = rnd.Next(1, 3);
                            if (Gway4 == 2)
                                Gway4 = 3;
                        }
                        else
                            Gway4 = 3;
                    }
                    else
                    {
                        GmoveX = -10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost4))
                        {
                            GmoveX = 0;
                            GmoveY = -10;
                            if (CheckghostBound(ghost4))
                                Gway4 = rnd.Next(1, 3);
                            else
                                Gway4 = 2;
                        }
                    }
                }
                if (Gway4 == 2)//left
                {
                    GmoveX = 0;
                    GmoveY = 10;
                    if (CheckghostBound(ghost4))
                    {
                        Gway4 = 4;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost4))
                        {
                            GmoveX = -10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost4))
                            {
                                Gway4 = rnd.Next(1, 4);
                                if (Gway4 == 3)
                                    Gway4 = 2;
                            }
                            else
                                Gway4 = 1;
                        }
                    }
                }
                if (Gway4 == 3)//right
                {
                    GmoveX = 0;
                    GmoveY = 10;
                    if (CheckghostBound(ghost4))
                    {
                        Gway4 = 4;
                    }
                    else
                    {
                        GmoveX = 0;
                        GmoveY = -10;
                        if (CheckghostBound(ghost4))
                        {
                            GmoveX = 10;
                            GmoveY = 0;
                            if (CheckghostBound(ghost4))
                            {
                                Gway4 = rnd.Next(1, 4);
                                if (Gway4 == 2)
                                    Gway4 = 3;
                            }
                            else
                                Gway4 = 1;
                        }
                    }

                }
                if (Gway4 == 4)//down
                {
                    GmoveX = 10;
                    GmoveY = 0;
                    if (CheckghostBound(ghost4))
                    {
                        GmoveX = 0;
                        GmoveY = 10;
                        if (CheckghostBound(ghost4))
                            Gway4 = rnd.Next(3, 5);
                        else
                            Gway4 = 3;
                    }
                    else
                    {
                        GmoveX = -10;
                        GmoveY = 0;
                        if (CheckghostBound(ghost4))
                        {
                            GmoveX = 0;
                            GmoveY = 10;
                            if (CheckghostBound(ghost4))
                            {
                                Gway4 = rnd.Next(2, 4);
                                if (Gway4 == 3)
                                    Gway4 = 4;
                            }
                            else
                                Gway4 = 2;
                        }
                    }
                }
            }
            if (Gway4 == 1)//UP
            {
                GmoveX = 0;
                GmoveY = -5;
            }
            if (Gway4 == 2)//LEFT
            {
                GmoveX = -5;
                GmoveY = 0;
            }
            if (Gway4 == 3)//RIGHT
            {
                GmoveX = 5;
                GmoveY = 0;
            }
            if (Gway4 == 4)//DOWN
            {
                GmoveX = 0;
                GmoveY = 5;
            }
            if (CheckghostBound(ghost4))
            {
                ghost4.Location = new Point(ghost4.Location.X + GmoveX, ghost4.Location.Y + GmoveY);
                ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
                if (eatghost)
                {
                    EATGHOST();
                }
                else
                {
                    if (ghosts[3].IntersectsWith(Pacman))
                    {
                        timer.Stop();
                        timer1.Stop();
                        MessageBox.Show("被鬼碰到了喔!!");
                        lifeleft--;
                        if (lifeleft == 2)
                        {
                            life1.Image = pac_man.Properties.Resources.black;
                        }
                        if (lifeleft == 1)
                        {
                            life2.Image = pac_man.Properties.Resources.black;
                        }
                        if (lifeleft == 0)
                        {
                            life3.Image = pac_man.Properties.Resources.black;
                            MessageBox.Show("Game over!!");
                            End();
                            this.Close();
                        }
                        ghost1.Location = new Point(396, 260);
                        ghost2.Location = new Point(431, 260);
                        ghost3.Location = new Point(463, 260);
                        ghost4.Location = new Point(396, 289);
                        pacman.Image = pac_man.Properties.Resources.pacmanRight;
                        pacman.Location = new Point(447, 438);
                        ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
                        ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
                        ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
                        ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
                        B = 0;
                    }
                }
            }
            ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
        }
        Rectangle Pacman = new Rectangle();
        bool G = true;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (G)
            {
                if (B == 10)
                    ghost1.Location = new Point(447, 219);
                if (B == 50)
                    ghost2.Location = new Point(447, 219);
                if (B == 100)
                    ghost3.Location = new Point(447, 219);
                if (B == 150)
                    ghost4.Location = new Point(447, 219);
            }
            else
            {
                if (B == 10 && ghost1.Location == new Point(396, 260))
                    ghost1.Location = new Point(447, 219);
                if (B == 50 && ghost2.Location == new Point(431, 260))
                    ghost2.Location = new Point(447, 219);
                if (B == 100 && ghost3.Location == new Point(463, 260))
                    ghost3.Location = new Point(447, 219);
                if (B == 150 && ghost4.Location == new Point(396, 289))
                    ghost4.Location = new Point(447, 219);
            }
            if (B > 10 || ghost1.Location != new Point(396, 260))
                Ghost1();
            if (B > 50 || ghost2.Location != new Point(431, 260))
                Ghost2();
            if (B > 100 || ghost3.Location != new Point(463, 260))
                Ghost3();
            if (B > 150 || ghost4.Location != new Point(396, 289))
                Ghost4();
            B++;
        }



        bool CheckghostBound(PictureBox GHOST)
        {
            bool A = true;
            Rectangle ghost = new Rectangle(GHOST.Location.X + GmoveX, GHOST.Location.Y + GmoveY, GHOST.Width, GHOST.Height);
            for (int i = 0; i < 50; i++)
            {
                if (ghost.IntersectsWith(rects[i]))
                    A = false;
                if (ghost.IntersectsWith(block[0]))
                {
                    GHOST.Location = new Point(728, 275);
                    A = false;
                }
                if (ghost.IntersectsWith(block[1]))
                {
                    GHOST.Location = new Point(162, 275);
                    A = false;
                }
            }
            return A;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Eatghost > 70 && Eatghost < 100)
            {
                label3.Text = "快要變回來了喔";
            }
            if (Eatghost == 99)
            {
                eatghost = false;
                ghost1.Image = pac_man.Properties.Resources.ghost1;
                ghost2.Image = pac_man.Properties.Resources.ghost1;
                ghost3.Image = pac_man.Properties.Resources.ghost1;
                ghost4.Image = pac_man.Properties.Resources.ghost1;
                label3.Text = "鬼";
                timer.Interval = 50;
                B = 0;
                G = false;
            }
            if (eatghost)
            {
                if (CheckBounds())
                {
                    ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
                    ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
                    ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
                    ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
                    EATGHOST();
                    eatscore();
                    pacman.Location = new Point(pacman.Location.X + moveX, pacman.Location.Y + moveY);
                    Pacman = new Rectangle(pacman.Location.X, pacman.Location.Y, pacman.Width, pacman.Height);
                }
            }
            else
            {
                if (CheckBounds())
                {
                    ghosts[0] = new Rectangle(ghost1.Location.X, ghost1.Location.Y, ghost1.Width, ghost1.Height);
                    ghosts[1] = new Rectangle(ghost2.Location.X, ghost2.Location.Y, ghost2.Width, ghost2.Height);
                    ghosts[2] = new Rectangle(ghost3.Location.X, ghost3.Location.Y, ghost3.Width, ghost3.Height);
                    ghosts[3] = new Rectangle(ghost4.Location.X, ghost4.Location.Y, ghost4.Width, ghost4.Height);
                    Checklife();
                    eatscore();
                    pacman.Location = new Point(pacman.Location.X + moveX, pacman.Location.Y + moveY);
                    Pacman = new Rectangle(pacman.Location.X, pacman.Location.Y, pacman.Width, pacman.Height);
                }
            }
            Eatghost++;
            END = 0;
            for (int i = 0; i < 150; i++)
            {
                END = END + eatbeans[i];
            }
            if (END == 150)
            {
                timer.Stop();
                timer1.Stop();
                MessageBox.Show("遊戲結束!!");
                End();
                this.Close();
            }
        }
        int END = 0;
        void EATGHOST()
        {
            Rectangle tempRect = new Rectangle(pacman.Location.X + moveX, pacman.Location.Y + moveY, pacman.Width, pacman.Height);
            if (tempRect.IntersectsWith(ghosts[0]))
            {
                ghost1.Location = new Point(396, 260);
                score = score + 100;
                label1.Text = score.ToString();
            }
            if (tempRect.IntersectsWith(ghosts[1]))
            {
                ghost2.Location = new Point(431, 260);
                score = score + 100;
                label1.Text = score.ToString();
            }
            if (tempRect.IntersectsWith(ghosts[2]))
            {
                ghost3.Location = new Point(463, 260);
                score = score + 100;
                label1.Text = score.ToString();
            }
            if (tempRect.IntersectsWith(ghosts[3]))
            {
                ghost4.Location = new Point(396, 289);
                score = score + 100;
                label1.Text = score.ToString();
            }
        }
        void End()
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "INSERT INTO SCORES (player ,scores ) VALUES ('" + this.Text + "','" + label1.Text + "')";
            oleDbCommand1.ExecuteNonQuery();
            oleDbConnection1.Close();
        }
    }
}