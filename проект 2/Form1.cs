namespace проект_2
{
    public partial class Form1 : Form
    {
        int kal = 0;
        int gr = 0;
        double ggg = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kal += 45;
            gr += 100;
        }
        void kals(int kal, int gr)
        {
            this.label2.Text = kal.ToString();
            this.label3.Text = gr.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kal += 44;
            gr += 100;
        }
        private void button30_Click(object sender, EventArgs e)
        {
            int vvr = Convert.ToInt32(textBox4.Text);
            int ves = Convert.ToInt32(textBox2.Text);
            int let = Convert.ToInt32(textBox3.Text);
            int rost = Convert.ToInt32(textBox1.Text);
            double ggg = (10 * ves) + (6.25 * rost) - (5 * let) + vvr;
            label36.Text = ggg.ToString();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = kal.ToString();
            label3.Text = gr.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            kal += 37;
            gr += 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kal += 95;
            gr += 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kal += 85;
            gr += 100;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kal += 65;
            gr += 100;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kal += 45;
            gr += 100;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kal += 50;
            gr += 100;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kal += 30;
            gr += 100;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kal += 35;
            gr += 100;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kal += 65;
            gr += 100;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kal += 300;
            gr += 100;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kal += 60;
            gr += 100;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kal += 40;
            gr += 100;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            kal += 67;
            gr += 100;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            kal += 18;
            gr += 100;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            kal += 50;
            gr += 100;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            kal += 55;
            gr += 100;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            kal += 35;
            gr += 100;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            kal += 40;
            gr += 100;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            kal += 40;
            gr += 100;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            kal += 35;
            gr += 100;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            kal += 34;
            gr += 100;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            kal += 36;
            gr += 100;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            kal += 36;
            gr += 100;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            kal += 30;
            gr += 100;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kal += 20;
            gr += 100;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kal += 35;
            gr += 100;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int ves = Convert.ToInt32(textBox1.Text);
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            int rost = Convert.ToInt32(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int let = Convert.ToInt32(textBox3.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }
}
