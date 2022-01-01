using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenk
{
    public partial class Tenk1 : Form
    {
        public bool goLeft, goRight, goUp, goDown;
        Random random = new Random();
        TimeSpan trenutnoVrijeme = new TimeSpan();
        TimeSpan ciljanoVrijeme = new TimeSpan();
        TimeSpan startVrijeme = new TimeSpan();
        private int brzinaTenka = 3;
        private int brPoena = 0;
        private int brprikazanihZlatnika = 0;
        private Control[,] polja = new Control[17, 17];
        private Control[] sviZidovi = new Control[287];
        private Control[] sviTravnasti = new Control[300];
        SoundPlayer player = new System.Media.SoundPlayer();
        public Tenk1()
        {     
            InitializeComponent();
            StartProperties();
        }
        private void TenkTimer_Event(object sender, EventArgs e)
        {
            if (goLeft == true)
            {
                if (pbTenk.Left > 0)
                {
                    pbTenk.Left -= brzinaTenka;
                }
            }
            if (goRight == true)
            {
                if (pbTenk.Left < panGamePlay.Width - pbTenk.Width - 2)
                {
                    pbTenk.Left += brzinaTenka;
                    player.Play();
                }
            }
            if (goUp == true)
            {
                if (pbTenk.Top > 0)
                {
                    pbTenk.Top -= brzinaTenka;
                    player.Play();
                }
            }
            if (goDown == true)
            {
                if (pbTenk.Top < panGamePlay.Height - pbTenk.Height - 2)
                {
                    pbTenk.Top += brzinaTenka;
                    player.Play();
                }
            }

            if(ciljanoVrijeme < DateTime.Now.TimeOfDay)
            {
                if (brprikazanihZlatnika < int.Parse(tbBrojPoena.Text))
                {
                    ZlatnikCrtanje();
                    brprikazanihZlatnika++;
                }
                trenutnoVrijeme = DateTime.Now.TimeOfDay;
                ciljanoVrijeme = trenutnoVrijeme.Add(new TimeSpan(0, 0, 0, 5, 0));
            }

            foreach (Control x in panGamePlay.Controls)
            {
                if((string)x.Tag == "polje" && x.BackColor == rbZid.BackColor && x.Bounds.IntersectsWith(pbTenk.Bounds))
                {
                    brzinaTenka = 0;
                    TenkTimer.Stop();
                    MessageBox.Show("GAME OVER");
                    TenkTimer.Stop();
                    this.Close();
                }
                if((string)x.Tag == "Zlatnik" && x.Bounds.IntersectsWith(pbTenk.Bounds) && x.Visible == true)
                {
                    brPoena++;
                    if (brPoena == int.Parse(tbBrojPoena.Text))
                    {
                        TenkTimer.Stop();
                        MessageBox.Show("ČESTITAMO, uspešno ste završili igru.\n" +
                                        "Broj uzetih zlatnika je: " + brPoena.ToString() + "\n" +
                                        "Vrijeme trajanja igre je: " + (ciljanoVrijeme - startVrijeme).ToString());
                        this.Close();
                    }
                    x.Visible = false;
                    lblPoeni.Text = brPoena.ToString();
                }
            }
        }
        private void Polje_Click(object sender, EventArgs e)
        {
            Control polje = sender as Control;
            foreach (Control x in panGamePlay.Controls)
            {
                if(x.Capture == true)
                {
                    int locationX = x.Location.X;
                    int locationY = x.Location.Y;
                    if(x.BackColor == Color.White)
                    {
                        x.Location = new Point(locationX - 1, locationY - 1);
                        x.Size = new Size(30, 30);
                    }
                    if(rbTrava.Checked == true)
                    {
                        x.BackColor = rbTrava.BackColor;
                    }
                    else
                    {
                        x.BackColor = rbZid.BackColor;
                    }
                }
            }
        }
        private void StartProperties()
        {
            panGamePlay.Location = new Point(0, menuTop.Height);
            panPodloge.Location = new Point(panGamePlay.Width, menuTop.Height);
            this.Width = panGamePlay.Width + panPodloge.Width + 16;
            this.Height = menuTop.Height + panGamePlay.Height + 79;
            lblPodloge.Location = new Point(panPodloge.Width/4 - lblPodloge.Width/2, panPodloge.Height/2 - lblPodloge.Height/2);
            rbTrava.Location = new Point(panPodloge.Width/2, 0);
            rbZid.Location = new Point(panPodloge.Width / 2, rbTrava.Height);

            btnPocni.Enabled = false;
            tbBrojPoena.Enabled = true;
            rbTrava.Enabled = true;
            rbZid.Enabled = true;
            panGamePlay.Enabled = true;
            meniRezimIzmena.Checked = true;
            rbTrava.Checked = true;
            this.Text = "Tenk (Režim IZMENA)";

            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (i == 9 && j == 9)
                    {
                        polja[i, j] = new Control
                        {
                            Name = "polje" + i + j,
                            Tag = "polje",
                            Width = 30,
                            Height = 30,
                            Location = new Point(j * 30, i * 30),
                            BackColor = rbTrava.BackColor,
                        };
                    }
                    else
                    {
                        polja[i, j] = new Control
                        {
                            Name = "polje" + i + j,
                            Tag = "polje",
                            Width = 28,
                            Height = 28,
                            Location = new Point(j * 30 + 1, i * 30 + 1),
                            BackColor = Color.White,
                        };
                        polja[i, j].Click += new EventHandler(Polje_Click);
                    }
                    panGamePlay.Controls.Add(polja[i, j]);
                }
            }
            pbTenk.BackColor = rbTrava.BackColor;
            pbTenk.Location = new Point(polja[9, 9].Location.X, polja[9, 9].Location.Y);
        }
        private void Tenk1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }
        private void Tenk1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }
        private void btnPocni_Click(object sender, EventArgs e)
        {
            int br;
            bool proveraVrijednosti = int.TryParse(tbBrojPoena.Text, out br);
            if(proveraVrijednosti == true)
            {
                foreach (Control x in panGamePlay.Controls)
                {
                    if (x.BackColor == Color.White)
                    {
                        int locationX = x.Location.X;
                        int locationY = x.Location.Y;
                        x.Location = new Point(locationX - 1, locationY - 1);
                        x.Size = new Size(30, 30);
                        x.BackColor = rbTrava.BackColor;
                    }
                }

                btnPocni.Enabled = false;
                trenutnoVrijeme = DateTime.Now.TimeOfDay;
                startVrijeme = trenutnoVrijeme;
                ciljanoVrijeme = trenutnoVrijeme.Add(new TimeSpan(0, 0, 0, 5, 0));
                TenkTimer.Start();
            }
            else
            {
                MessageBox.Show("Morate unijeti broj zlatnika, koji se pojavljuju u igri");
                btnPocni.Enabled = false;
                tbBrojPoena.Enabled = true;
                rbTrava.Enabled = true;
                rbZid.Enabled = true;
                panGamePlay.Enabled = true;
                meniRezimIzmena.Checked = true;
                rbTrava.Checked = true;
                meniRezimIgranje.Checked = false;
                this.Text = "Tenk (Režim IZMENA)";
                //StartProperties();
            }
        }
        private void RezimIgranje_Click(object sender, EventArgs e)
        {
            btnPocni.Enabled = true;
            tbBrojPoena.Enabled = false;
            rbTrava.Enabled = false;
            rbZid.Enabled = false;
            panGamePlay.Enabled = false;
            meniRezimIgranje.Checked = true;
            meniRezimIzmena.Checked = false;
            this.Text = "Tenk (Režim IGRANJE)";
        }
        private void RezimIzmena_Click(object sender, EventArgs e)
        {
            btnPocni.Enabled = false;
            tbBrojPoena.Enabled = true;
            rbTrava.Enabled = true;
            rbZid.Enabled = true;
            panGamePlay.Enabled = true;
            meniRezimIgranje.Checked = false;
            meniRezimIzmena.Checked = true;
            this.Text = "Tenk (Režim IZMENA)";
        }
        private void ZlatnikCrtanje()
        {
            PictureBox zlatnik = new PictureBox
            {
                Tag = "Zlatnik",
                Width = 15,
                Height = 15,
                BackColor = Color.Gold,
                
            };
            GraphicsPath krug = new GraphicsPath();
            krug.AddEllipse(0, 0, zlatnik.Width, zlatnik.Height);
            Region region = new Region(krug);
            zlatnik.Region = region;
            int i = 0;

            foreach (Control x in panGamePlay.Controls)
            {
                if((string)x.Tag == "polje" && x.BackColor == rbTrava.BackColor)
                {
                    sviTravnasti[i] = x;
                    i++;
                }
            }
            Control trava = sviTravnasti[random.Next(0, i - 1)];
            zlatnik.Location = new Point(trava.Location.X + random.Next(30-zlatnik.Width), trava.Location.Y + random.Next(30-zlatnik.Height));
            panGamePlay.Controls.Add(zlatnik);
            zlatnik.BringToFront();
        }
    }
}
