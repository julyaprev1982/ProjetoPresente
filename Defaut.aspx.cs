using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dados;
using System.Drawing;

namespace ProjetoPresentes
{
    public partial class Defaut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Pres p = new Pres
            {
                Id = Convert.ToInt32(IdText.Text),
                Descricao = DescricaoTxt.Text,
                Tipo = TipoTxt.Text,
                Marca = MarcaTxt.Text,
                Finalidade = FinalidadeTxt.Text,
                Cor = CorTxt.Text,
                Tamanho = TamanhoTxt.Text,
                Preco = Convert.ToDecimal(PrecoTxt.Text),
                NomeFornecedor = NomeFornecedor.Text,
        

            };
            PresDB presDB = new PresDB();
            bool status = presDB.Salvar(p);

            if (status)
            {
                Label1.Text = "Registro Inserido!";
                LimparComponentes();
                CarregarTabela();
            }
            else
            {
                Label1.Text = "Erro ao inserir registro";
                Label1.ForeColor = Color.Red;
            }

        }
        private void LimparComponentes()
        {
            IdText.Text = String.Empty;
            DescricaoTxt.Text = String.Empty;
            TipoTxt.Text = String.Empty;
            MarcaTxt.Text = String.Empty;
            FinalidadeTxt.Text = String.Empty;
           CorTxt.Text = String.Empty;
            TamanhoTxt.Text = String.Empty;
            PrecoTxt.Text = String.Empty;
            NomeFornecedor.Text = String.Empty;
            IdText.Focus();

        }

        private void CarregarTabela()
        {
            PresDB presDB = new PresDB();
            GridView1.DataSource = presDB.ConsultarTudo();
            GridView1.DataBind();
        }


    }
}