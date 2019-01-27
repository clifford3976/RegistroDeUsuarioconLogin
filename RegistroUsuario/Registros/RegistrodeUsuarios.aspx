<%@ Page Title="Registro de Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="RegistrodeUsuarios.aspx.cs" Inherits="RegistroUsuario.Registros.RegistrodeUsuarios" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="shortcut icon" href="../Imagenes/usuario_32.png" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-group container">
        <div class="row">
            <div class="col-sm-4">
                <h2 class="control-label col-sm-12" style="width: 350px">Registro de Usuarios</h2>


                <div class="form-group">
                    <label for="usuarioid">UsuarioID :</label>
                    <asp:TextBox ID="usuarioid" runat="server" placeholder="0" class="form-control" type="number"></asp:TextBox>
                </div>
                <div class="form-group align-content-center">
                    <asp:Button ID="ButtonBuscar" runat="server" Text="Search" class="btn btn-info btn-success" OnClick="ButtonBuscar_Click" />
                </div>

                <label for="nombreTextbox">Nombre :</label>
                <asp:TextBox ID="nombreTextbox" runat="server" class="form-control" type="text" Width="350px"></asp:TextBox>
                
              <label for =" NombreUsuariotextbox"> NombreUsuario :</label>
                <asp:TextBox ID="NombreUsuariotextbox" runat="server" class ="form-control" type="text" Width ="350px"></asp:TextBox>

                <label for="Telefonoinput">Telefono :</label>
                <asp:TextBox runat="server" class="form-control" ID="Telefonoinput" type="tel" Width="350px"></asp:TextBox>

                <label for="Emailinput">Email :</label>
                <asp:TextBox runat="server" class="form-control" ID="EmailInput" type="email" Width="350px"></asp:TextBox>

                <label for="pwd">Clave:</label>
                <asp:TextBox runat="server" type="password" class="form-control" ID="pwd" placeholder="Digite Clave" Width="350px"></asp:TextBox>

                <label for="confirmarpwd">Confirmar Clave:</label>
                <asp:TextBox type="password" runat="server" class="form-control" ID="confirmarpwd" placeholder="Confirmar Clave" Width="350px"></asp:TextBox>
                
                <label for =" Fecha"> Fecha :</label>
                  <asp:TextBox runat="server" type="date" class="form-control" ID="Fecha" Width="350px"></asp:TextBox>

            </div>

        </div>


    </div>

    <div class="panel">
        <div class="container" style="width: 350px">
            <asp:Label class="text-center " ID="ErrorLabel" runat="server" Text=""></asp:Label>
            <div class="form-group text-center " style="width: 350px">




                <asp:Button ID="ButtonNuevo" runat="server" Text="NEW" class="btn btn-info" OnClick="ButtonNuevo_Click" />


                <asp:Button ID="ButtonGuardar" runat="server" Text="SAVE" class="btn btn-success" OnClick="ButtonGuardar_Click" />

                <asp:Button ID="ButtonEliminar" runat="server" Text="DELETE" class="btn btn-danger" OnClick="ButtonEliminar_Click" />


            </div>
        </div>
    </div>


</asp:Content>
