using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI;

namespace BLL
{
    public class RepositorioUsuario : Repositorio<Usuarios>
    {
        public static void Autenticar(string NombreUsuario, string Clave, Page page)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            Usuarios usuario = new Usuarios();

            filtrar = t => t.NombreUsuario.Equals(NombreUsuario) && t.Clave.Equals(Clave);

            if (repositorio.GetList(filtrar).Count() != 0)
                FormsAuthentication.RedirectFromLoginPage(usuario.NombreUsuario, true);
            else
               ScriptManager.RegisterStartupScript(page, typeof(Page), "toastr_message", script: "toastr['error'] ('NombreUsuario o Clave Incorrecto');", addScriptTags: true);
        }
    }
}
