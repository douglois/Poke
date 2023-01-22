using PokeSon.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeSon
{
    public partial class Frm_Detalhe : Form
    {
        string idSelecionado = "";
        public Frm_Detalhe(string id)
        {
            InitializeComponent();
            idSelecionado = id;
            PreencheDados();

        }

        public void PreencheDados()
        {
            string urlSelecionado = "https://pokeapi.co/api/v2/pokemon/" + idSelecionado;

            CaracteristicaPokemon.Root caracteristicaPokemon = new CaracteristicaPokemon.Root();

            caracteristicaPokemon = CaracteristicaPokemon.DeserializaClassCaracteristica(urlSelecionado);

            picImagemDetalhe.ImageLocation = caracteristicaPokemon.sprites.other.officialartwork.front_default;
            txtNomeDetalhe.Text = caracteristicaPokemon.name;
        }
    }
}
