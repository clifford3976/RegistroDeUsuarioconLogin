﻿using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroUsuario.Registros
{
    public partial class RegistrodeUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Usuarios LlenaClase()

        {
            Usuarios usuario = new Usuarios();

           // usuario.UsuarioId =  Convert.ToInt32(usuarioid.Text);
            usuario.Nombre = nombreTextbox.Text;
            usuario.NombreUsuario = NombreUsuariotextbox.Text;
            usuario.Telefono = Telefonoinput.Text;
            usuario.Email = EmailInput.Text;
            usuario.Clave = pwd.Text;
            usuario.Fecha = DateTime.Now;
            return usuario;

        }


        private void LlenaCampos(Usuarios usuarios)

        {

            usuarioid.Text = usuarios.UsuarioId.ToString();

            nombreTextbox.Text = usuarios.Nombre;

            NombreUsuariotextbox.Text = usuarios.NombreUsuario;

            
            Telefonoinput.Text = usuarios.Telefono;

            EmailInput.Text = usuarios.Email;


            pwd.Text = usuarios.Clave;

        }

        private void Limpiar()

        {



            usuarioid.Text = "";

            nombreTextbox.Text = "";

            NombreUsuariotextbox.Text = "";

            Telefonoinput.Text = "";

            EmailInput.Text = "";


            pwd.Text = "";
            confirmarpwd.Text = "";
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void MostrarMensaje(TiposMensaje tipo, string mensaje)

        {

            ErrorLabel.Text = mensaje;



            if (tipo == TiposMensaje.Success)

                ErrorLabel.CssClass = "alert-success";

            else

                ErrorLabel.CssClass = "alert-danger";

        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();

            Usuarios usuarios = LlenaClase();

            bool paso = false;

            if (usuarios.UsuarioId == 0)

                paso = repositorio.Guardar(usuarios);

            else

                paso = repositorio.Modificar(usuarios);

            if (paso)

            {

                MostrarMensaje(TiposMensaje.Success, "Registro Exitoso!");



            }

            else

                MostrarMensaje(TiposMensaje.Error, "No puede guardar el registro");

            Limpiar();
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();

            int id = Convert.ToInt32(usuarioid.Text);

            var usuario = repositorio.Buscar(id);


            if (usuario == null)

                MostrarMensaje(TiposMensaje.Error, "Registro no encontrado");

            else

                repositorio.Eliminar(id);

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            Usuarios usuario = repositorio.Buscar(Convert.ToInt32(usuarioid.Text));
            if (usuario != null)
            {
                LlenaCampos(usuario);
            }
            else
            {
                Response.Write("<script>alert('Usuario no encontrado');</script>");

            }
        }
    }
}