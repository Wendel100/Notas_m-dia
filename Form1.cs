namespace Aula_media_Notas
{
    public partial class Form1 : Form
    {
        float nota1; float nota2; float nota3; float nota4;
        float media;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            nota1 = float.Parse(text1.Text);
            nota2 = float.Parse(text2.Text);
            nota3 = float.Parse(text3.Text);
            nota4 = float.Parse(text4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            text5.Text = Convert.ToString(media);
            if (media >= 5 && media <= 6)
            {
                text6.Text = ("Regular");
                text6.BackColor = Color.Blue;
            }
            else if (media >= 5 && media <= 7)
            {
                text6.Text = ("Otima nota");
                text6.BackColor = Color.Violet;
            }
            else if (media > 7 && media <= 10)
            {
                text6.Text = ("Excelte nota");
                text6.BackColor = Color.Green;
            }
            else
            {
                text6.Text = ("Reprovado");
                text6.BackColor = Color.Red;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            text5.Text = "";
            text6.Text = "";
        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text6_TextChanged(object sender, EventArgs e)
        {
        }

        private void text5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnres_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
