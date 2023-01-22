using Newtonsoft.Json;
using PokeSon.Classes;
using System.Collections.Generic;

namespace PokeSon
{
    public partial class Frm_Inicial: Form
    {
        int contador = 252;
        int width = 951;

        DadosPokemon.Root dadosPokemon = new DadosPokemon.Root();
        CaracteristicaPokemon.Root caracteristicaPokemon = new CaracteristicaPokemon.Root();
        EspeciePokemon.Root especiePokemon = new EspeciePokemon.Root();

        public Frm_Inicial()
        {
            InitializeComponent();
            AddImagens();
            AddNomes();
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
                pokeCard[i].BorderStyle = BorderStyle.Fixed3D;

                string urlCaracteristica = dadosPokemon.results[i].url;
                caracteristicaPokemon = CaracteristicaPokemon.DeserializaClassCaracteristica(urlCaracteristica);
                especiePokemon = EspeciePokemon.DeserializaClassEspecie(caracteristicaPokemon.species.url);

                pokeCard[i].Name = caracteristicaPokemon.id.ToString();

                pokeCard[i].Padding = new Padding(0, 40, 80, 160);
                pokeCard[i].Visible = true;
                pokeCard[i].Size = new System.Drawing.Size(130, 160);

                if(especiePokemon.color.name == "green")
                {
                    pokeCard[i].BackColor = Color.FromArgb(60, 179, 113);
                }
                if (especiePokemon.color.name == "blue")
                {
                    pokeCard[i].BackColor = Color.FromArgb(135, 206, 235);
                }
                if (especiePokemon.color.name == "red")
                {
                    pokeCard[i].BackColor = Color.FromArgb(178, 34, 34);
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
            }
        }

        public void AddNomes()
        {
            int x = 45;
            int y = 180;

            DadosPokemon.Root dadosPokemon = new DadosPokemon.Root();
            CaracteristicaPokemon.Root caracteristicaPokemon = new CaracteristicaPokemon.Root();
            dadosPokemon = DadosPokemon.DeserializaClassDados();

            Label[] pokeLabel = new Label[contador];


            for (int i = 0; i <= contador - 1; i++)
            {
                pokeLabel[i] = new Label();

                if (i > 0)
                {
                    x = x + 190;
                    if (x > width + 400)
                    {
                        y = y + 210;
                        x = 45;
                    }
                }

                pokeLabel[i].Text = dadosPokemon.results[i].name;
                pokeLabel[i].Font = new Font("Comic Sans Cerif", 12);

                pokeLabel[i].TextAlign = ContentAlignment.MiddleCenter;

                pokeLabel[i].BackColor = Color.LightGray;
                pokeLabel[i].Size = new Size(100, 20);
                pokeLabel[i].Location = new Point(x, y);
                pokeLabel[i].Visible = true;

                this.Controls.Add(pokeLabel[i]);
            }
        }
    }
}