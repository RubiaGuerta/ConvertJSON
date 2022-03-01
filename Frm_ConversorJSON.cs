using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConversorXML_JSON
{
    public partial class Frm_Conversor : Form
    {
        public Frm_Conversor()
        {
            InitializeComponent();
        }        

        private void Btn_ConvertJson_Click(object sender, EventArgs e)
        {
            string conteudo = Txt_Conteudo.Text;
            XNode json = JsonConvert.DeserializeXNode(conteudo, "root");
            Txt_Resultado.Text = json.ToString();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Conteudo.Text = "";
            Txt_Resultado.Text = "";
        }

        private void Btn_Copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Txt_Resultado.Text);
        }
        
    }
}
