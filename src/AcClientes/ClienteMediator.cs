using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcClientes
{
    public class ClienteMediator : Mediator
    {
        private Clientes componentCliente;
        private FormularioCliente FormularioClientes;

        public ClienteMediator(FormularioCliente formularioClientes, Clientes componentCliente)
        {
            FormularioClientes = formularioClientes;
            this.componentCliente = componentCliente;

            formularioClientes.SetMediator(this);
            componentCliente.SetMediator(this);
        }




        public void Notificar(object sender, string e)
        {
            switch (e)
            {
                case "openFormularioAdd":
                    this.FormularioClientes.Text = "Agregar Cliente";
                    this.FormularioClientes.ShowDialog();
                    break;
                case "openFormularioEdit":
                    this.FormularioClientes.Text = "Editar Clienete";
                    if (this.componentCliente.Cliente != null)
                        this.FormularioClientes.LoadForm(this.componentCliente.Cliente.Id).Wait();
                    this.FormularioClientes.ShowDialog();
                   
                    break;
                case "closeFormulario":
                    this.componentCliente.ResetForm();
                    this.componentCliente.LoadTable().Wait();
                    break;
            }
        }
    }
}
