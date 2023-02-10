using Newtonsoft.Json;
using PokeSon.Classes;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace PokeSon
{
    public partial class Frm_Inicial: Form
    {
        int contador = 55;
        int width = 951;

        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        DadosPokemon.Root dadosPokemon = new DadosPokemon.Root();
        CaracteristicaPokemon.Root caracteristicaPokemon = new CaracteristicaPokemon.Root();
        EspeciePokemon.Root especiePokemon = new EspeciePokemon.Root();

        public Frm_Inicial()
        {
            InitializeComponent();
            AddImagens();
            AddNomes();

            //this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panel1.BackColor = borderColor;
            this.BackColor = borderColor;
        }

        void PicDobleClick(object sender, EventArgs e)
        {
            
            PictureBox pic = (PictureBox)sender;
            Frm_Detalhe frm_Detalhe = new Frm_Detalhe(pic.Name);

            frm_Detalhe.ShowDialog();
        }

        public void AddImagens()
        {
            int x = 30;
            int y = 15;

            dadosPokemon = DadosPokemon.DeserializaClassDados();

            PictureBox[] pokeCard = new PictureBox[contador];


            for (int i = 0; i <= contador - 1; i++)
            {
                pokeCard[i] = new PictureBox();

                string urlCaracteristica = dadosPokemon.results[i].url;
                caracteristicaPokemon = CaracteristicaPokemon.DeserializaClassCaracteristica(urlCaracteristica);
                especiePokemon = EspeciePokemon.DeserializaClassEspecie(caracteristicaPokemon.species.url);

                pokeCard[i].Name = caracteristicaPokemon.id.ToString();

                pokeCard[i].Padding = new Padding(0, 40, 80, 160);
                pokeCard[i].Visible = true;
                pokeCard[i].Size = new System.Drawing.Size(130, 160);

                Rectangle r = new Rectangle(0, 0, pokeCard[i].Width, pokeCard[i].Height);
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);

                pokeCard[i].Region = new Region(gp);

                if (especiePokemon.color.name == "green")
                {
                    pokeCard[i].BackColor = Color.FromArgb(60, 179, 113);
                }
                if (especiePokemon.color.name == "blue")
                {
                    pokeCard[i].BackColor = Color.FromArgb(135, 206, 235);
                }
                if (especiePokemon.color.name == "red")
                {
                    pokeCard[i].BackColor = Color.FromArgb(255, 90, 54);
                }
                if (especiePokemon.color.name == "brown")
                {
                    pokeCard[i].BackColor = Color.FromArgb(184, 134, 11);
                }
                if (especiePokemon.color.name == "yellow")
                {
                    pokeCard[i].BackColor = Color.FromArgb(240, 230, 140);
                }
                if (especiePokemon.color.name == "purple")
                {
                    pokeCard[i].BackColor = Color.FromArgb(186, 85, 211);
                }
                if (especiePokemon.color.name == "pink")
                {
                    pokeCard[i].BackColor = Color.FromArgb(240, 128, 128);
                }
                if (especiePokemon.color.name == "gray")
                {
                    pokeCard[i].BackColor = Color.Silver;
                }
                if (especiePokemon.color.name == "black")
                {
                    pokeCard[i].BackColor = Color.FromArgb(54, 54, 54);
                }
                if (especiePokemon.color.name == "white")
                {
                    pokeCard[i].BackColor = Color.FromArgb(240, 248, 255);
                }


                if (i > 0)
                {
                    x = x + 190;
                    if (x > width + 400)
                    {
                        y = y + 210;
                        x = 30;
                    }
                }

                pokeCard[i].Location = new Point(x, y);

                pokeCard[i].ImageLocation = caracteristicaPokemon.sprites.front_default;

                pokeCard[i].DoubleClick += new System.EventHandler(this.PicDobleClick);
                
                this.Controls.Add(pokeCard[i]);
                panel1.Controls.Add(pokeCard[i]);
                panel1.AutoScroll = true;
            }
        }

        public void AddNomes()
        {
            int x = 45; //Para posicionar os labels com os nomes
            int y = 180;//Para posicionar os labels com os nomes

            int w = 30;//Para posicionar os icones com os nomes
            int z = 15;//Para posicionar os icones com os nomes

            dadosPokemon = DadosPokemon.DeserializaClassDados();



            Label[] pokeLabel = new Label[contador];
            Label[] pokeTipo = new Label[contador];



            for (int i = 0; i <= contador - 1; i++)
            {
                pokeTipo[i] = new Label();
                pokeLabel[i] = new Label();

                string urlCaracteristica = dadosPokemon.results[i].url;
                caracteristicaPokemon = CaracteristicaPokemon.DeserializaClassCaracteristica(urlCaracteristica);

                if (i > 0)
                {
                    w = w + 190;
                    if (w > width + 400)
                    {
                        z = z + 210;
                        x = 30;
                    }
                }

                List<string> tipoPokemon = new List<string>();

                for (int j = 0; j < caracteristicaPokemon.types.Count; j++)
                {
                    tipoPokemon.Add(caracteristicaPokemon.types[j].type.name);
                }

                pokeTipo[i].Location = new Point(w, z);
                pokeTipo[i].Text = String.Join(" - ", tipoPokemon);
                pokeTipo[i].Font = new Font("Comic Sans Cerif", 12);

                if (i > 0) //Para posicionar os labels com os nomes
                {
                    x = x + 190;
                    if (x > width + 400)
                    {
                        y = y + 210;
                        x = 45;
                    }
                }

                panel1.Controls.Add(pokeTipo[i]);

                string nomePokemon = caracteristicaPokemon.name;

                pokeLabel[i].Text = nomePokemon;

                pokeLabel[i].Font = new Font("Comic Sans Cerif", 12);

                pokeLabel[i].TextAlign = ContentAlignment.MiddleCenter;

                pokeLabel[i].BackColor = Color.LightGray;
                pokeLabel[i].Size = new Size(100, 20);
                pokeLabel[i].Location = new Point(x, y);
                pokeLabel[i].Visible = true;
               
                panel1.Controls.Add(pokeLabel[i]);
            }
        }
    }
}