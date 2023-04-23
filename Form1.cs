namespace kendiXOX
{
    public partial class Form1 : Form
    {
        bool sira = true;
        int tur,x,o,oyun = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Kontrol()
        {
            bool zafer = false;
            if((button1.Text == button2.Text) && (button3.Text == button2.Text) && !button1.Enabled)
            {
                button1.BackColor = Color.Green;button2.BackColor = Color.Green;button3.BackColor = Color.Green;
                zafer = true;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && !button6.Enabled)
            {
                button4.BackColor = Color.Green;button5.BackColor = Color.Green; button6.BackColor = Color.Green;
                zafer = true;
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && !button9.Enabled)
            {
                button7.BackColor = Color.Green; button8.BackColor = Color.Green; button9.BackColor = Color.Green;
                zafer = true;
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && !button1.Enabled)
            {
                button1.BackColor = Color.Green; button4.BackColor = Color.Green; button7.BackColor = Color.Green;
                zafer = true;
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && !button5.Enabled)
            {
                button2.BackColor = Color.Green; button5.BackColor = Color.Green; button8.BackColor = Color.Green;
                zafer = true;
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && !button6.Enabled)
            {
                button3.BackColor = Color.Green; button6.BackColor = Color.Green; button9.BackColor = Color.Green;
                zafer = true;
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && !button1.Enabled)
            {
                button1.BackColor = Color.Green; button5.BackColor = Color.Green; button9.BackColor = Color.Green;
                zafer = true;
            }
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && !button5.Enabled)
            {
                button3.BackColor = Color.Green; button7.BackColor = Color.Green; button5.BackColor = Color.Green;
                zafer = true;
            }
            else if (!button1.Enabled && !button2.Enabled && !button3.Enabled && !button4.Enabled
                && !button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled && !button9.Enabled)
            {
                MessageBox.Show("Oyun berabere bitti.","Oyun Bitti",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                sira = !sira;
                if (sira)
                {
                    label1.Text = "X";
                }
                else
                {
                    label1.Text = "O";
                }
                return;
            }
            if (zafer)
            {
                try
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                catch (Exception)
                {

                    throw;
                }
                if (sira)
                {
                    MessageBox.Show("X oyuncusu oyunu kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    x++;
                }
                else
                {
                    MessageBox.Show("O oyuncusu oyunu kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    o++;
                }
            }
            oyun++;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            tur++;
            button1.Enabled = false;
            if (sira)
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text="O";
            }
            Kontrol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tur++;
            button2.Enabled = false;
            if (sira)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }
            Kontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tur++;
            button3.Enabled = false;
            if (sira)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }
            Kontrol();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tur++;
            button4.Enabled = false;
            if (sira)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }
            Kontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tur++;
            button5.Enabled = false;
            if (sira)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }
            Kontrol();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tur++;
            button6.Enabled = false;
            if (sira)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }
            Kontrol();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tur++;
            button7.Enabled = false;
            if (sira)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }
            Kontrol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tur++;
            button8.Enabled = false;
            if (sira)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }
            Kontrol();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tur++;
            button9.Enabled = false;
            if (sira)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }
            Kontrol();
        }

        private void geliþtiriciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Düzce Meslek Yüksekokulu'ndan 211103043 numaralý öðrenci Ömer Furkan Durmuþ tarafýndan yapýlmýþtýr.", "Geliþtirici", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void nasýlOynanýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyunculardan biri X, diðeri O sembolünü kullanmalýdýr.\nOyun sonunda 3 ayný sembolü arka arkaya sýralayan oyuncu, 3 sembolün üzerine çizik atar ve oyunu kazanýr.\nOyun sonunda 3 ayný sembol arka arkaya sýralanamamýþ ise oyun beraberedir.", "Nasýl Oynanýr", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void istatistiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun açýldýðýndan beri "+tur.ToString()+" hamleyle " + oyun.ToString() + " kez oyun oynandý.\n-> X oyuncularý "+x.ToString()+ " kez kazandý.\n-> O oyuncularý " + o.ToString() + " kez kazandý.\n"+
                (oyun-(x+o)).ToString()+" kez de beraberlikle sonuçlandý.","Ýstatistikler",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                sira = true;
                label1.Text = "X";
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}