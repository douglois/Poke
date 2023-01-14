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

        public Frm_Detalhe()
        {
            InitializeComponent();
        }

        public void PreencheDados()
        {
            DadosPokemon.Root dadosPokemon = new DadosPokemon.Root();
            CaracteristicaPokemon.Root caracteristicaPokemon = new CaracteristicaPokemon.Root();
            dadosPokemon = DadosPokemon.DeserializaClassDados();
        }
    }
}
