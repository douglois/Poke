using Newtonsoft.Json;
using PokeSon.Classes;
using System.Collections.Generic;

namespace PokeSon
{
    public partial class Frm_Inicial: Form
    {
        int contador = 252;
        int width = 951;
        string caracteristicaUrl = "";

        public Frm_Inicial()
        {
            InitializeComponent();
            AddImagens();
            AddNomes();
        }

        void PicDobleClick(object sender, EventArgs e)
        {
            Frm_Detalhe frm_Detalhe = new Frm_Detalhe();
            PictureBox pic = (PictureBox)sender;
            MessageBox.Show(pic.Name);
            frm_Detalhe.ShowDialog();
        }

        public void AddImagens()
        {
            int x = 30;
            int y = 15;
            DadosPokemon.Root dadosPokemon = new DadosPokemon.Root();
            CaracteristicaPokemon.Root caracteristicaPokemon = new CaracteristicaPokemon.Root();
            dadosPokemon = DadosPokemon.DeserializaClassDados();

            PictureBox[] pokeCard = new PictureBox[contador];


            for (int i = 0; i <= contador - 1; i++)
            {
                pokeCard[i] = new PictureBox();
                pokeCard[i].BorderStyle = BorderStyle.Fixed3D;

                pokeCard[i].BackColor = Color.LightBlue;
                string urlCaracteristica = dadosPokemon.results[i].url;
                caracteristicaPokemon = CaracteristicaPokemon.DeserializaClassCaracteristica(urlCaracteristica);
                pokeCard[i].Name = "Pokemon "+ caracteristicaPokemon.name;

                pokeCard[i].Padding = new Padding(0, 40, 80, 160);
                pokeCard[i].Visible = true;
                pokeCard[i].Size = new System.Drawing.Size(130, 160);

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
                pokeCard[i].SizeMode = PictureBoxSizeMode.Normal;
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