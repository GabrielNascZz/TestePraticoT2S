<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestePráticoT2S.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Teste Prático T2S</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <style>
        * {
            margin: 0;
            padding: 0;
            font-size: 10pt;
            font-family: Arial;
        }
        .celula {
            padding: 15px;
        }
        .check {
            margin-right: 5px;
        }
        .label {
            color:red;
            font-weight:bold;
        }
        h1 {
            font-size: 25pt;
        }
        h2 {
            font-size: 20pt;
            margin-bottom: 10px;
        }
        h3 {
            font-size: 15pt;
            margin-bottom: 5px;
        }
        h1, h2, h3, div {
            font-family:'Segoe UI', Tahoma, Geneva, Verdana;
        }
        html, body {
            height: 100%;
            width: 100%;
            background-color: rgb(15,184,234);
            font-family:'Segoe UI', Tahoma, Geneva, Verdana;
        }
        #principal {
            padding: 3% 5% 5% 5%;
            background-color: white;
            margin: 5%;
            border-radius: 10px;
        }
        #GDV_Consultar th, #GDV_ConsultarM th, #GDV_Relatorio th, #GDV_Sumario th{
            text-align: center;
            color: rgb(15,184,234);
            background-color: rgb(80,80,80);
            padding: 5px;
        }
        #GDV_Consultar td, #GDV_ConsultarM td, #GDV_Relatorio td, #GDV_Sumario td{
            padding: 5px;
            text-align: center;
        }

    </style>
</head>
<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body style="padding: 10px;">
    <form id="form1" runat="server">
        <div class="row justify-content-md-center">
            <div id="principal" class="col-offset-1 col-8 col-offset-1">
                <h1 style ="text-align:center;">TESTE PRÁTICO T2S</h1><br />
                <h1>MENU:</h1>

                <asp:Button ID="BTN_CrudContainer" runat="server" Text="Crud de Container" Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_CrudContainer_Click" class="btn btn-outline-primary"/>
                <asp:Button ID="BTN_CrudMovimentacao" runat="server" Text="Crud de Movimentação" Width="160px" Height="35px" Style="margin: 5px 0 0 10px" OnClick="BTN_CrudMovimentacao_Click" class="btn btn-outline-primary"/>
                <asp:Button ID="BTN_Relatorio" runat="server" Text="RELATORIO" Width="160px" Height="35px" Style="margin: 5px 0 0 10px" OnClick="BTN_Relatorio_Click" class="btn btn-outline-primary"/>
                <br />

                <asp:Panel ID="Crud_Container" runat="server" Style="display: none">
                    <div style="padding: 5% 0% 5% 0%;">
                        <h2>Escolha uma das opções:</h2>
                        <asp:Button ID="BTN_Criar" runat="server" Text="Cadastrar Container" Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_Criar_Click" Enabled="false" class="btn btn-outline-primary"/>
                        <asp:Button ID="BTN_Consulta" runat="server" Text="Consultar Container " Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_Consulta_Click" class="btn btn-outline-primary"/>
                        <asp:Button ID="BTN_Atualizar" runat="server" Text="Atualizar Container" Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_Atualizar_Click" class="btn btn-outline-primary"/>
                        <asp:Button ID="BTN_Excluir" runat="server" Text="Excluir Container" Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_Excluir_Click" class="btn btn-outline-primary"/>
                        <br />
                    </div>
                    <div>
                        <asp:Label ID="LBL_Informacao" runat="server"><h2>Cadastrar Container</h2></asp:Label>
                        <asp:Label ID="LBL_Nome" runat="server"><h3>Informe o nome do cliente:</h3></asp:Label>
                        <asp:TextBox ID="TXT_Cliente" runat="server" Width="200"></asp:TextBox>

                        <asp:Label ID="LBL_Controle" runat="server"><h3 style ="margin-top:10px">Informe o numero de controle:</h3></asp:Label>
                        <asp:TextBox ID="TXT_NmrControle" runat="server" Width="200"></asp:TextBox>

                        <asp:Label ID="LBL_Tipo" runat="server"><h3 style ="margin-top:10px">Informe o tipo do container:</h3></asp:Label>
                        <asp:RadioButton ID="RDB_Tipo1" runat="server" Text="20" class="check" GroupName="T1" Checked=" true" />
                        <asp:RadioButton ID="RDB_Tipo2" runat="server" Text="40" class="check" GroupName="T1" />

                        <asp:Label ID="LBL_Status" runat="server"><h3 style ="margin-top:10px">Informe o status do conatiner:</h3></asp:Label>
                        <asp:RadioButton ID="RDB_Status1" runat="server" Text="Cheio" class="check" GroupName="T2" Checked="true" />
                        <asp:RadioButton ID="RDB_Status2" runat="server" Text="Vazio" class="check" GroupName="T2" />

                        <asp:Label ID="LBL_Categoria" runat="server"><h3 style ="margin-top:10px">Informe a categoria do container:</h3></asp:Label>
                        <asp:RadioButton ID="RDB_Categoria1" runat="server" Text=" Importação" class="check" GroupName="T3" Checked="true" />
                        <asp:RadioButton ID="RDB_Categoria2" runat="server" Text=" Exportação" class="check" GroupName="T3" />
                        <br />
                        <br />
                        <asp:GridView ID="GDV_Consultar" runat="server"></asp:GridView>
                        <asp:Button ID="BTN_EnviarInf" runat="server" Text="Cadastrar Container" Width="160px" Height="35px" Style="margin: 5px 0 0 15px; padding: 5px" OnClick="BTN_EnviarInf_Click1" class="btn btn-outline-primary"/>
                        <asp:Label ID="LBL_Erro" runat="server" Style="color: red"></asp:Label>
                    </div>
                </asp:Panel>
                <asp:Panel ID="Crud_Movimentacao" runat="server" Style="display: none">
                    <div style="padding: 5% 0% 5% 0%">
                        <h2>Escolha uma das opções:</h2>
                        <asp:Button ID="BTN_CriarM" runat="server" Text="Cadastrar Movimentação" Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_CriarM_Click" Enabled="false" class="btn btn-outline-primary"/>
                        <asp:Button ID="BTN_ConsultaM" runat="server" Text="Consultar Movimentação " Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_ConsultaM_Click" class="btn btn-outline-primary"/>
                        <asp:Button ID="BTN_AtualizarM" runat="server" Text="Atualizar Movimentação" Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_AtualizarM_Click" class="btn btn-outline-primary"/>
                        <asp:Button ID="BTN_ExcluirM" runat="server" Text="Excluir Movimentação" Width="160px" Height="35px" Style="margin: 5px 0 0 15px" OnClick="BTN_ExcluirM_Click" class="btn btn-outline-primary"/>
                    </div>
                    <div>
                        <asp:Label ID="LBL_InformacaoM" runat="server"><h2>Cadastrar Movimentação</h2></asp:Label>
                        <asp:Label ID="LBL_Navio" runat="server"><h3>Informe o nome do navio:</h3></asp:Label>
                        <asp:TextBox ID="TXT_Navio" runat="server" Width="200"></asp:TextBox>

                        <asp:Label ID="LBL_NmrControleM" runat="server"><h3>Informe o numero de controle do container:</h3></asp:Label>
                        <asp:TextBox ID="TXT_NmrControleM" runat="server" Width="200"></asp:TextBox>

                        <asp:Label ID="LBL_ID" runat="server" Visible ="false"><h3>Informe o container da Movimentação:</h3></asp:Label>
                        <asp:TextBox ID="TXT_ID" runat="server" Width="200" Visible ="false"></asp:TextBox>

                        <asp:Label ID="LBL_TipoM" runat="server"><h3 style ="margin-top:10px">Informe o tipo de movimentação:</h3></asp:Label>
                        <asp:RadioButton ID="RDB_TipoM1" runat="server" Text=" Embarque" class="check" GroupName="Tm1" Checked=" true" />
                        <asp:RadioButton ID="RDB_TipoM2" runat="server" Text=" Descarga" class="check" GroupName="Tm1" />
                        <asp:RadioButton ID="RDB_TipoM3" runat="server" Text=" Gate In" class="check" GroupName="Tm1" />
                        <asp:RadioButton ID="RDB_TipoM4" runat="server" Text=" Gate Out" class="check" GroupName="Tm1" />
                        <asp:RadioButton ID="RDB_TipoM5" runat="server" Text=" Posicionamento Pilha" class="check" GroupName="Tm1" />
                        <asp:RadioButton ID="RDB_TipoM6" runat="server" Text=" Pesagem" class="check" GroupName="Tm1" />
                        <asp:RadioButton ID="RDB_TipoM7" runat="server" Text=" Scanner" class="check" GroupName="Tm1" />

                        <asp:Label ID="LBL_Inicio" runat="server"> <h3 style ="margin-top:10px">Informe a data e hora do início:</h3></asp:Label>
                        <asp:Label ID="LBL_DataI" runat="server">Data: </asp:Label><asp:TextBox ID="TXT_DataI" runat="server" Width="80"></asp:TextBox><asp:Label ID="LBL_DataI1" runat="server" class="label">(dd/mm/aaaa)</asp:Label>
                        <asp:Label ID="LBL_HoraI" runat="server"><br/><br/>Hora: </asp:Label><asp:TextBox ID="TXT_HoraI" runat="server" Width="78"></asp:TextBox><asp:Label ID="LBL_HoraI1" runat="server" class="label">(hh:mm)</asp:Label>

                        <asp:Label ID="LBL_Fim" runat="server"> <h3 style ="margin-top:10px">Informe a data e hora do fim:</h3></asp:Label>

                        <asp:Label ID="LBL_DataF" runat="server">Data: </asp:Label><asp:TextBox ID="TXT_DataF" runat="server" Width="80"></asp:TextBox><asp:Label ID="LBL_DataF1" runat="server" class="label">(dd/mm/aaaa)</asp:Label>

                        <asp:Label ID="LBL_HoraF" runat="server"><br/><br/>Hora: </asp:Label><asp:TextBox ID="TXT_HoraF" runat="server" Width="78"></asp:TextBox><asp:Label ID="LBL_HoraF1" runat="server" class="label">(hh:mm)</asp:Label>
                        <br />
                        <br />
                        <asp:GridView ID="GDV_ConsultarM" runat="server"></asp:GridView>
                        <asp:Button ID="BTN_EnviarInfM" runat="server" Text="Cadastrar Movimentação" Width="160px" Height="35px" Style="margin: 5px 0 0 15px; padding: 5px" OnClick="BTN_EnviarInfM_Click" class="btn btn-outline-primary"/>
                        <asp:Label ID="LBL_ErroM" runat="server" Style="color: red"></asp:Label>
                
                    </div>
                </asp:Panel>
                <asp:Panel ID="PNL_Relatorio" runat="server" Style="display: none">
                    <asp:Label ID="Label2" runat="server"><h2 style ="margin:20px 0px 20px 0px;">Relatório de movimentações:</h2></asp:Label>
                    <asp:GridView ID="GDV_Relatorio" runat="server"></asp:GridView>
                    <asp:Label ID="Label1" runat="server"><h2 style ="margin:20px 0px 20px 0px;">Sumário:</h2></asp:Label>
                    <asp:GridView ID="GDV_Sumario" runat="server" style ="margin-top:10px;"></asp:GridView>
                </asp:Panel>
            </div>
        </div> 
    </form>
</body>
</html>
