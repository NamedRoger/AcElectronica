using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcProveedores
{
    public class ProveedorMediator : Mediator
    {
        private Proveedores componentProveedores;
        private FormularioProveedores FormularioProveedores;

        public ProveedorMediator(Proveedores componentProveedores, FormularioProveedores formularioProveedores)
        {
            this.componentProveedores = componentProveedores;
            FormularioProveedores = formularioProveedores;
            this.componentProveedores.SetMediator(this);
            this.FormularioProveedores.SetMediator(this);
        }

        public void Notificar(object sender, string e)
        {
            switch (e)
            {
                case "openFormularioAdd":
                    this.FormularioProveedores.Show();
                    this.FormularioProveedores.Text = "Agregar Proveedor";
                    break;
                case "openFormularioEdit":
                    this.FormularioProveedores.Show();
                    if (this.componentProveedores.Proveedor != null)
                        this.FormularioProveedores.LoadForm(this.componentProveedores.Proveedor.Id).Wait();
                    this.FormularioProveedores.Text = "Editar Proveedor";
                    break;
                case "closeFormulario":
                    this.componentProveedores.ResetForm();
                    this.componentProveedores.LoadTable().Wait();
                    break;
            }
        }
    }
}
