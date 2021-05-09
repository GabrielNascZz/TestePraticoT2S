using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestePráticoT2S
{
    public partial class Default : System.Web.UI.Page
    {
        int cod_Operador = 1, cod_OperadorM = 1;
        Crud banco = new Crud();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Botões do MENU
        protected void BTN_CrudContainer_Click(object sender, EventArgs e)
        {
            Crud_Container.Style.Value = "display: inline;";
            Crud_Movimentacao.Style.Value = "display: none;";
            PNL_Relatorio.Style.Value = "display: none";
            BTN_CrudContainer.Enabled = false;
            BTN_CrudMovimentacao.Enabled = true;
            BTN_Relatorio.Enabled = true;
        }

        protected void BTN_CrudMovimentacao_Click(object sender, EventArgs e)
        {
            Crud_Container.Style.Value = "display: none;";
            Crud_Movimentacao.Style.Value = "display: inline;";
            PNL_Relatorio.Style.Value = "display: none";
            BTN_CrudContainer.Enabled = true;
            BTN_CrudMovimentacao.Enabled = false;
            BTN_Relatorio.Enabled = true;
        }
        #endregion
        #region Botões Container
        protected void BTN_Criar_Click(object sender, EventArgs e)
        {
            cod_Operador = 1;
            #region Controle Visual
            /*Controle Visual dos botões*/
            LBL_Informacao.Text = "<h2>Cadastrar Container</h2>";
            BTN_EnviarInf.Text = "Cadastrar Container";
            BTN_Criar.Enabled = false;
            BTN_Consulta.Enabled = true;
            BTN_Atualizar.Enabled = true;
            BTN_Excluir.Enabled = true;
            /*Controle das informações*/
            LBL_Nome.Visible = true;
            TXT_Cliente.Visible = true;
            LBL_Controle.Visible = true;
            TXT_NmrControle.Visible = true;
            LBL_Tipo.Visible = true;
            RDB_Tipo1.Visible = true;
            RDB_Tipo2.Visible = true;
            LBL_Status.Visible = true;
            RDB_Status1.Visible = true;
            RDB_Status2.Visible = true;
            LBL_Categoria.Visible = true;
            RDB_Categoria1.Visible = true;
            RDB_Categoria2.Visible = true;
            GDV_Consultar.Visible = false;
            LBL_Erro.Text = "";
            #endregion

        }

        protected void BTN_Consulta_Click(object sender, EventArgs e)
        {
            cod_Operador = 2;
            #region Controle Visual
            /*Controle Visual dos botões*/
            LBL_Informacao.Text = "<h2>Consultar Container</h2>";
            BTN_EnviarInf.Text = "Consultar Container";
            BTN_Criar.Enabled = true;
            BTN_Consulta.Enabled = false;
            BTN_Atualizar.Enabled = true;
            BTN_Excluir.Enabled = true;
            /*Controle das informações*/
            LBL_Nome.Visible = false;
            TXT_Cliente.Visible = false;
            LBL_Controle.Visible = true;
            TXT_NmrControle.Visible = true;
            LBL_Tipo.Visible = false;
            RDB_Tipo1.Visible = false;
            RDB_Tipo2.Visible = false;
            LBL_Status.Visible = false;
            RDB_Status1.Visible = false;
            RDB_Status2.Visible = false;
            LBL_Categoria.Visible = false;
            RDB_Categoria1.Visible = false;
            RDB_Categoria2.Visible = false;
            GDV_Consultar.Visible = true;
            LBL_Erro.Text = "";
            #endregion
            TXT_NmrControle.Text = null;
            GDV_Consultar.DataSource = null;
            GDV_Consultar.DataBind();
        }

        protected void BTN_Atualizar_Click(object sender, EventArgs e)
        {
            cod_Operador = 3;
            #region Controle Visual
            /*Controle Visual dos botões*/
            LBL_Informacao.Text = "<h2>Atualizar Container</h2>";
            BTN_EnviarInf.Text = "Atualizar Container";
            BTN_Criar.Enabled = true;
            BTN_Consulta.Enabled = true;
            BTN_Atualizar.Enabled = false;
            BTN_Excluir.Enabled = true;
            /*Controle das informações*/
            LBL_Nome.Visible = true;
            TXT_Cliente.Visible = true;
            LBL_Controle.Visible = true;
            TXT_NmrControle.Visible = true;
            LBL_Tipo.Visible = true;
            RDB_Tipo1.Visible = true;
            RDB_Tipo2.Visible = true;
            LBL_Status.Visible = true;
            RDB_Status1.Visible = true;
            RDB_Status2.Visible = true;
            LBL_Categoria.Visible = true;
            RDB_Categoria1.Visible = true;
            RDB_Categoria2.Visible = true;
            GDV_Consultar.Visible = false;
            LBL_Erro.Text = "";
            #endregion
        }

        protected void BTN_Excluir_Click(object sender, EventArgs e)
        {
            cod_Operador = 4;
            #region Controle Visual
            /*Controle Visual dos botões*/
            LBL_Informacao.Text = "<h2>Excluir Container</h2>";
            BTN_EnviarInf.Text = "Excluir Container";
            BTN_Criar.Enabled = true;
            BTN_Consulta.Enabled = true;
            BTN_Atualizar.Enabled = true;
            BTN_Excluir.Enabled = false;
            /*Controle das informações*/
            LBL_Nome.Visible = false;
            TXT_Cliente.Visible = false;
            LBL_Controle.Visible = true;
            TXT_NmrControle.Visible = true;
            LBL_Tipo.Visible = false;
            RDB_Tipo1.Visible = false;
            RDB_Tipo2.Visible = false;
            LBL_Status.Visible = false;
            RDB_Status1.Visible = false;
            RDB_Status2.Visible = false;
            LBL_Categoria.Visible = false;
            RDB_Categoria1.Visible = false;
            RDB_Categoria2.Visible = false;
            GDV_Consultar.Visible = false;
            LBL_Erro.Text = "";
            #endregion
        }
        #endregion
        #region Botões Movimentação
        protected void BTN_CriarM_Click(object sender, EventArgs e)
        {
            cod_OperadorM = 1;
            #region Controle Visual
            /*Controle Visual dos botões*/
            LBL_InformacaoM.Text = "<h2>Cadastrar Movimentação</h2>";
            BTN_EnviarInfM.Text = "Cadastrar Movimentação";
            BTN_CriarM.Enabled = false;
            BTN_ConsultaM.Enabled = true;
            BTN_AtualizarM.Enabled = true;
            BTN_ExcluirM.Enabled = true;
            /*Controle das informações*/
            LBL_ID.Visible = false;
            TXT_ID.Visible = false;
            LBL_Navio.Visible = true;
            TXT_Navio.Visible = true;
            LBL_TipoM.Visible = true;
            RDB_TipoM1.Visible = true;
            RDB_TipoM2.Visible = true;
            RDB_TipoM3.Visible = true;
            RDB_TipoM4.Visible = true;
            RDB_TipoM5.Visible = true;
            RDB_TipoM6.Visible = true;
            RDB_TipoM7.Visible = true;
            LBL_Inicio.Visible = true;
            LBL_DataI.Visible = true;
            TXT_DataI.Visible = true;
            LBL_HoraI.Visible = true;
            TXT_HoraI.Visible = true;
            LBL_Fim.Visible = true;
            LBL_DataF.Visible = true;
            TXT_DataF.Visible = true;
            LBL_HoraF.Visible = true;
            TXT_HoraF.Visible = true;
            GDV_ConsultarM.Visible = false;
            LBL_NmrControleM.Visible = true;
            TXT_NmrControleM.Visible = true;
            LBL_DataI1.Visible = true;
            LBL_DataF1.Visible = true;
            LBL_HoraI1.Visible = true;
            LBL_HoraF1.Visible = true;
            LBL_ErroM.Text = "";

            #endregion
        }

        protected void BTN_ConsultaM_Click(object sender, EventArgs e)
        {
            cod_OperadorM = 2;
            #region Controle Visual
            /*Controle Visual dos botões*/
            LBL_InformacaoM.Text = "<h2>Consultar Movimentação</h2>";
            BTN_EnviarInfM.Text = "Consultar Movimentação";
            BTN_CriarM.Enabled = true;
            BTN_ConsultaM.Enabled = false;
            BTN_AtualizarM.Enabled = true;
            BTN_ExcluirM.Enabled = true;
            /*Controle das informações*/
            LBL_ID.Visible = true;
            TXT_ID.Visible = true;
            LBL_NmrControleM.Visible = false;
            TXT_NmrControleM.Visible = false;
            LBL_Navio.Visible = false;
            TXT_Navio.Visible = false;
            LBL_TipoM.Visible = false;
            RDB_TipoM1.Visible = false;
            RDB_TipoM2.Visible = false;
            RDB_TipoM3.Visible = false;
            RDB_TipoM4.Visible = false;
            RDB_TipoM5.Visible = false;
            RDB_TipoM6.Visible = false;
            RDB_TipoM7.Visible = false;
            LBL_Inicio.Visible = false;
            LBL_DataI.Visible = false;
            TXT_DataI.Visible = false;
            LBL_HoraI.Visible = false;
            TXT_HoraI.Visible = false;
            LBL_Fim.Visible = false;
            LBL_DataF.Visible = false;
            TXT_DataF.Visible = false;
            LBL_HoraF.Visible = false;
            TXT_HoraF.Visible = false;
            GDV_ConsultarM.Visible = true;
            LBL_DataI1.Visible = false;
            LBL_DataF1.Visible = false;
            LBL_HoraI1.Visible = false;
            LBL_HoraF1.Visible = false;
            LBL_ErroM.Text = "";
            #endregion
            GDV_ConsultarM.DataSource = null;
            GDV_ConsultarM.DataBind();
            TXT_NmrControleM.Text = null;
            LBL_ID.Text = "<h3> Informe o container da Movimentação:</h3>";
        }

        protected void BTN_AtualizarM_Click(object sender, EventArgs e)
        {
            cod_OperadorM = 3;
            TXT_NmrControleM.Text = null;
            TXT_ID.Text = null;
            LBL_ID.Text = "<h3> Informe o <span style='color:red; font-weight: bold;font-size:15pt;'>ID</span> da Movimentação:</h3>";
            #region Controle Visual
            /*Controle Visual dos botões*/
            LBL_InformacaoM.Text = "<h2>Atualizar Movimentação</h2>";
            BTN_EnviarInfM.Text = "Atualizar Movimentação";
            BTN_CriarM.Enabled = true;
            BTN_ConsultaM.Enabled = true;
            BTN_AtualizarM.Enabled = false;
            BTN_ExcluirM.Enabled = true;
            /*Controle das informações*/
            LBL_ID.Visible = true;
            TXT_ID.Visible = true;
            LBL_Navio.Visible = true;
            TXT_Navio.Visible = true;
            LBL_TipoM.Visible = true;
            RDB_TipoM1.Visible = true;
            RDB_TipoM2.Visible = true;
            RDB_TipoM3.Visible = true;
            RDB_TipoM4.Visible = true;
            RDB_TipoM5.Visible = true;
            RDB_TipoM6.Visible = true;
            RDB_TipoM7.Visible = true;
            LBL_Inicio.Visible = true;
            LBL_DataI.Visible = true;
            TXT_DataI.Visible = true;
            LBL_HoraI.Visible = true;
            TXT_HoraI.Visible = true;
            LBL_Fim.Visible = true;
            LBL_DataF.Visible = true;
            TXT_DataF.Visible = true;
            LBL_HoraF.Visible = true;
            TXT_HoraF.Visible = true;
            GDV_ConsultarM.Visible = false;
            LBL_NmrControleM.Visible = false;
            TXT_NmrControleM.Visible = false;
            LBL_ErroM.Text = "";
            LBL_DataI1.Visible = true;
            LBL_DataF1.Visible = true;
            LBL_HoraI1.Visible = true;
            LBL_HoraF1.Visible = true;
            #endregion 
        }

        protected void BTN_ExcluirM_Click(object sender, EventArgs e)
        {
            cod_OperadorM = 4;
            TXT_NmrControleM.Text = null;
            TXT_ID.Text = null;
            #region Controle visual
            /*Controle Visual dos botões*/
            LBL_InformacaoM.Text = "<h2>Excluir Movimentação</h2>";
            BTN_EnviarInfM.Text = "Excluir Movimentação";
            BTN_CriarM.Enabled = true;
            BTN_ConsultaM.Enabled = true;
            BTN_AtualizarM.Enabled = true;
            BTN_ExcluirM.Enabled = false;
            /*Controle das informações*/
            LBL_ID.Visible = true;
            TXT_ID.Visible = true;
            LBL_Navio.Visible = false;
            TXT_Navio.Visible = false;
            LBL_TipoM.Visible = false;
            RDB_TipoM1.Visible = false;
            RDB_TipoM2.Visible = false;
            RDB_TipoM3.Visible = false;
            RDB_TipoM4.Visible = false;
            RDB_TipoM5.Visible = false;
            RDB_TipoM6.Visible = false;
            RDB_TipoM7.Visible = false;
            LBL_Inicio.Visible = false;
            LBL_DataI.Visible = false;
            TXT_DataI.Visible = false;
            LBL_HoraI.Visible = false;
            TXT_HoraI.Visible = false;
            LBL_Fim.Visible = false;
            LBL_DataF.Visible = false;
            TXT_DataF.Visible = false;
            LBL_HoraF.Visible = false;
            TXT_HoraF.Visible = false;
            GDV_ConsultarM.Visible = false;
            LBL_NmrControleM.Visible = false;
            TXT_NmrControleM.Visible = false;
            LBL_ErroM.Text = "";
            LBL_DataI1.Visible = false;
            LBL_DataF1.Visible = false;
            LBL_HoraI1.Visible = false;
            LBL_HoraF1.Visible = false;

            #endregion
            LBL_ID.Text = "<h3> Informe o <span style='color:red; font-weight: bold;font-size:15pt;'>ID</span> da Movimentação:</h3>";
        }
        #endregion
        #region Enviar Informações 
        protected void BTN_EnviarInf_Click1(object sender, EventArgs e)
        {
            #region Validação
            char[] array = TXT_NmrControle.Text.ToCharArray();
            bool val = true;
            if (!BTN_Atualizar.Enabled || !BTN_Criar.Enabled)
            {
                if (TXT_Cliente.Text == "" || TXT_NmrControle.Text == "")
                {
                    val = false;
                    LBL_Erro.Text = "<h3>Preenchimento inválido!</h3>";
                }
            }
            if (array.Length == 11)
            {
                for (int x = 0; x < array.Length; x++)
                {
                    if (x >= 0 && x <= 3)
                    {
                        if (!Char.IsLetter(array[x]))
                        {
                            val = false;
                        }
                    }
                    else if (x >= 4 && x <= 10)
                    {
                        if (!Char.IsDigit(array[x]))
                        {
                            val = false;
                        }
                    }
                }
            }
            else
            {
                val = false;
            }
            if (val)
            {
                #endregion
                #region Definição da operação
                if (!BTN_Criar.Enabled) cod_Operador = 1;
                else if (!BTN_Consulta.Enabled) cod_Operador = 2;
                else if (!BTN_Atualizar.Enabled) cod_Operador = 3;
                else if (!BTN_Excluir.Enabled) cod_Operador = 4;
                switch (cod_Operador)
                {
                    case 1:
                        CadastrarContainer();
                        break;
                    case 2:
                        ConsultarContainer();
                        break;
                    case 3:
                        AtualizarContainer();
                        break;
                    case 4:
                        ExcluirContainer();
                        break;
                }
                #endregion
            }
            else
            {
                LBL_Erro.Text = "<h3>Preenchimento inválido!</h3>";
            }

        }
        protected void BTN_EnviarInfM_Click(object sender, EventArgs e)
        {
            #region Validação
            char[] arrayM = TXT_NmrControleM.Text.ToCharArray();
            bool valM = true;
            if (arrayM.Length == 11 && !BTN_CriarM.Enabled)
            {
                for (int x = 0; x < arrayM.Length; x++)
                {
                    if (x >= 0 && x <= 3)
                    {
                        if (!Char.IsLetter(arrayM[x]))
                        {
                            valM = false;
                        }
                    }
                    else if (x >= 4 && x <= 10)
                    {
                        if (!Char.IsDigit(arrayM[x]))
                        {
                            valM = false;
                        }
                    }
                }
            }
            else if (!BTN_CriarM.Enabled)
            {
                valM = false;
            }
            if (!BTN_ConsultaM.Enabled || !BTN_ExcluirM.Enabled)
            {
                if (TXT_ID.Text == "")
                {
                    valM = false;
                }
            }
            else if (!BTN_CriarM.Enabled)
            {
                if (TXT_Navio.Text == "" || TXT_NmrControleM.Text == "" || TXT_DataI.Text == "" || TXT_HoraI.Text == "" || TXT_DataF.Text == "" || TXT_HoraF.Text == "")
                {
                    valM = false;
                }
            }
            else if (!BTN_AtualizarM.Enabled)
            {
                if (TXT_Navio.Text == "" || TXT_ID.Text == "" || TXT_DataI.Text == "" || TXT_HoraI.Text == "" || TXT_DataF.Text == "" || TXT_HoraF.Text == "")
                {
                    valM = false;
                }
            }
            if (!valM)
            {
                LBL_ErroM.Text = "<h3>Preenchimento inválido!</h3>";
            }
            else
            {
                #region Definição da operação
                if (!BTN_CriarM.Enabled) cod_OperadorM = 1;
                else if (!BTN_ConsultaM.Enabled) cod_OperadorM = 2;
                else if (!BTN_AtualizarM.Enabled) cod_OperadorM = 3;
                else if (!BTN_ExcluirM.Enabled) cod_OperadorM = 4;
                switch (cod_OperadorM)
                {
                    case 1:
                        CadastrarMovimentacao();
                        break;
                    case 2:
                        ConsultarMovimentacao();
                        break;
                    case 3:
                        AtualizarMovimentacao();
                        break;
                    case 4:
                        ExcluirMovimentacao();
                        break;
                }
                #endregion
            }
            #endregion
        }
        #endregion



        #region Cadastro do Container no banco
        public void CadastrarContainer()
        {
            String cliente = TXT_Cliente.Text;
            String controle = TXT_NmrControle.Text;
            String tipo = RDB_Tipo1.Checked ? "20" : "40";
            String status = RDB_Status1.Checked ? "Cheio" : "Vazio";
            String categoria = RDB_Categoria1.Checked ? "I" : "E";
            try
            {
                DataTable resultado = banco.PesquisarContainer($"SELECT * FROM tb_container where nm_controle_container = '{controle}'");
                if (resultado.Rows.Count == 0)
                {
                    LBL_Erro.Text = banco.OperacaoBanco($"INSERT INTO tb_container(nm_cliente_container, nm_controle_container, nm_tipo_container, nm_status_container, nm_categoria_container) VALUES ('{cliente}', '{controle}', '{tipo}', '{status}', '{categoria}')");
                }
                else
                {
                    GDV_Consultar.DataSource = null;
                    GDV_Consultar.DataBind();
                    LBL_Erro.Text = "<br /><h3>ERRO: ESTES DADOS JÁ ESTÃO CADASTRADOS!</h3>";
                }
            }
            catch (Exception ex)
            {
                LBL_Erro.Text = ex.Message;
            }
        }
        #endregion
        #region Consultar container no banco
        public void ConsultarContainer()
        {
            String controle = TXT_NmrControle.Text.Trim();
            try
            {
                DataTable resultado = banco.PesquisarContainer($"SELECT * FROM tb_container where nm_controle_container = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    GDV_Consultar.DataSource = resultado;
                    GDV_Consultar.DataBind();
                    LBL_Erro.Text = null;
                }
                else
                {
                    GDV_Consultar.DataSource = null;
                    GDV_Consultar.DataBind();
                    LBL_Erro.Text = "<br /><h3>ERRO: ESTE CONTAINER NÃO FOI ENCONTRADO!</h3>";
                }
            }
            catch (Exception ex)
            {
                LBL_Erro.Text = ex.Message;
            }
        }
        #endregion
        #region Atualizar Container no banco
        public void AtualizarContainer()
        {
            String cliente = TXT_Cliente.Text;
            String controle = TXT_NmrControle.Text;
            String tipo = RDB_Tipo1.Checked ? "20" : "40";
            String status = RDB_Status1.Checked ? "Cheio" : "Vazio";
            String categoria = RDB_Categoria1.Checked ? "I" : "E";
            try
            {
                var resultado = banco.PesquisarContainer($"SELECT * FROM tb_container where nm_controle_container = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    LBL_Erro.Text = banco.OperacaoBanco($"UPDATE tb_container SET nm_cliente_container = '{cliente}', nm_tipo_container = '{tipo}', nm_status_container = '{status}', nm_categoria_container = '{categoria}' WHERE nm_controle_container = '{controle}'");
                }
                else
                {

                    LBL_Erro.Text = "<br /><h3>ERRO: ESTE CONTAINER NÃO FOI ENCONTRADO!</h3>";
                }
            }
            catch (Exception ex)
            {
                LBL_Erro.Text = ex.Message;
            }
        }
        #endregion
        #region Excluir Container no banco
        public void ExcluirContainer()
        {
            String controle = TXT_NmrControle.Text.Trim();

            try
            {
                DataTable resultado = banco.PesquisarContainer($"SELECT * FROM tb_container where nm_controle_container = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    LBL_Erro.Text = banco.OperacaoBanco($"DELETE FROM tb_container WHERE nm_controle_container = '{controle}'");
                }
                else
                {
                    LBL_Erro.Text = "<br /><h3>ERRO: ESTE CONTAINER NÃO FOI ENCONTRADO!</h3>";
                }
            }
            catch (Exception ex)
            {
                LBL_Erro.Text = ex.Message;
            }
        }
        #endregion


        #region Cadastro do Movimentação no banco
        public void CadastrarMovimentacao()
        {
            String tipo = null;

            String navio = TXT_Navio.Text;
            if (RDB_TipoM1.Checked) tipo = "Embarque";
            else if (RDB_TipoM2.Checked) tipo = "Descarga";
            else if (RDB_TipoM3.Checked) tipo = "Gate In";
            else if (RDB_TipoM4.Checked) tipo = "Gate Out";
            else if (RDB_TipoM5.Checked) tipo = "Posicionamento Pilha";
            else if (RDB_TipoM6.Checked) tipo = "Pesagem";
            else if (RDB_TipoM7.Checked) tipo = "Scanner";
            String inicio = $"{TXT_DataI.Text} {TXT_HoraI.Text}";
            String fim = $"{TXT_DataF.Text} {TXT_HoraF.Text}";
            String controle = TXT_NmrControleM.Text;
            try
            {
                var resultado = banco.PesquisarContainer($"SELECT * FROM tb_container where nm_controle_container = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    LBL_ErroM.Text = banco.OperacaoBanco($"INSERT INTO tb_movimentacao(nm_navio_movimentacao, nm_tipo_movimentacao, nm_inicio_movimentacao, nm_fim_movimentacao, cd_container) VALUES ('{navio}', '{tipo}', '{inicio}', '{fim}', '{resultado.Rows[0].ItemArray[0]}')");


                }
                else
                {
                    GDV_ConsultarM.DataSource = null;
                    GDV_ConsultarM.DataBind();
                    LBL_ErroM.Text = "<br /><h3>ERRO: CONTAINER NÃO CADASTRADO!</h3>";
                    return;

                }
                try
                {
                    var result = banco.PesquisarMovimentacao($"SELECT m.*,c.nm_controle_container FROM tb_movimentacao m INNER JOIN tb_container c on m.cd_container = c.cd_container where c.cd_container = '{resultado.Rows[0].ItemArray[0]}' and nm_inicio_movimentacao = '{inicio}' and nm_fim_movimentacao = '{fim}'");
                    LBL_ErroM.Text += " Código da movimentação: " + result.Rows[0].ItemArray[0];
                }
                catch (Exception ex)
                {
                    LBL_ErroM.Text = ex.Message;
                }
            }
            catch (Exception ex)
            {
                LBL_ErroM.Text = ex.Message;
            }
        }
        #endregion
        #region Consultar Movimentação no banco
        public void ConsultarMovimentacao()
        {
            String controle = TXT_ID.Text.Trim();
            try
            {
                DataTable resultado = banco.PesquisarMovimentacao($"SELECT m.*,c.nm_controle_container FROM tb_movimentacao m INNER JOIN tb_container c on m.cd_container = c.cd_container where c.nm_controle_container = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    GDV_ConsultarM.DataSource = resultado;
                    GDV_ConsultarM.DataBind();
                }
                else
                {
                    GDV_ConsultarM.DataSource = null;
                    GDV_ConsultarM.DataBind();
                    LBL_ErroM.Text = "<br /><h3>ERRO: ESTA MOVIMENTAÇÃO NÃO FOI ENCONTRADA!</h3>";
                }
            }
            catch (Exception ex)
            {
                LBL_Erro.Text = ex.Message;
            }
        }
        #endregion
        #region Atualizar Movimentacão no banco
        public void AtualizarMovimentacao()
        {
            String tipo = null;

            String navio = TXT_Navio.Text;
            if (RDB_TipoM1.Checked) tipo = "Embarque";
            else if (RDB_TipoM2.Checked) tipo = "Descarga";
            else if (RDB_TipoM3.Checked) tipo = "Gate In";
            else if (RDB_TipoM4.Checked) tipo = "Gate Out";
            else if (RDB_TipoM5.Checked) tipo = "Posicionamento Pilha";
            else if (RDB_TipoM6.Checked) tipo = "Pesagem";
            else if (RDB_TipoM7.Checked) tipo = "Scanner";
            String inicio = $"{TXT_DataI.Text} {TXT_HoraI.Text}";
            String fim = $"{TXT_DataF.Text} {TXT_HoraF.Text}";
            String controle = TXT_ID.Text;
            try
            {
                var resultado = banco.PesquisarMovimentacao($"SELECT m.*,c.nm_controle_container FROM tb_movimentacao m INNER JOIN tb_container c on m.cd_container = c.cd_container where cd_movimentacao = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    LBL_ErroM.Text = banco.OperacaoBanco($"UPDATE tb_movimentacao SET nm_navio_movimentacao = '{navio}', nm_tipo_movimentacao = '{tipo}', nm_inicio_movimentacao = '{inicio}', nm_fim_movimentacao = '{fim}' WHERE cd_movimentacao = '{controle}'");
                }
                else
                {
                    LBL_ErroM.Text = "<br /><h3>ERRO: MOVIMENTAÇÃO NÃO ENCONTRADA!</h3>";
                }
            }
            catch (Exception ex)
            {
                LBL_ErroM.Text = ex.Message;
            }
        }
        #endregion
        #region Excluir Movimentacao no banco
        public void ExcluirMovimentacao()
        {
            String controle = TXT_ID.Text.Trim();

            try
            {
                var resultado = banco.PesquisarMovimentacao($"SELECT m.*,c.nm_controle_container FROM tb_movimentacao m INNER JOIN tb_container c on m.cd_container = c.cd_container where cd_movimentacao = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    LBL_ErroM.Text = banco.OperacaoBanco($"DELETE FROM tb_movimentacao WHERE cd_movimentacao = '{controle}'");
                }
                else
                {
                    LBL_ErroM.Text = "<br /><h3>ERRO: MOVIMENTAÇÃO NÃO ENCONTRADA!</h3>";
                }
            }
            catch (Exception ex)
            {
                LBL_ErroM.Text = ex.Message;
            }
        }
        #endregion

        #region RELATORIO
        protected void BTN_Relatorio_Click(object sender, EventArgs e)
        {
            BTN_CrudContainer.Enabled = true;
            BTN_CrudMovimentacao.Enabled = true;
            BTN_Relatorio.Enabled = false;
            Crud_Container.Style.Value = "display: none;";
            Crud_Movimentacao.Style.Value = "display: none;";
            PNL_Relatorio.Style.Value = "display: inline";

            DataTable cat = new DataTable();
            cat.Columns.Add("Total Importações", typeof(String));
            cat.Columns.Add("Total Exportações", typeof(String));
            var resultado = banco.ListarRelatorio($"SELECT * FROM tb_container c INNER JOIN tb_movimentacao m on (c.cd_container = m.cd_container) group by c.nm_cliente_container, m.nm_tipo_movimentacao");
            var total_I = resultado.Select().Where(p => p.Field<String>("Categoria") == "Importação").Count();
            var total_E = resultado.Select().Where(p => p.Field<String>("Categoria") == "Exportação").Count();
            cat.Rows.Add(total_I, total_E);
            for (int x = 0; x < resultado.Rows.Count; x++)
            {
                GDV_Relatorio.DataSource = resultado;
                GDV_Relatorio.DataBind();
            }
            GDV_Sumario.DataSource = cat;
            GDV_Sumario.DataBind();
        }
        #endregion
    }
}