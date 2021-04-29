using DatabasaeManager.Entidades;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcClientes
{
    public partial class FormularioCliente : Form
    {
        private Mediator mediator;
        private IClienteRepo _repoCliente;

        public FormularioCliente(IClienteRepo repoCliente)
        {
            InitializeComponent();
            _repoCliente = repoCliente;
            LoadaCatalogos().Wait();
        }

        private void txtECiudad_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        private void FormularioCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.ResetForm();
            this.Hide();
            this.mediator.Notificar(sender, "closeFormulario");
        }

        public async Task LoadaCatalogos()
        {
            var categorias = await _repoCliente.GetCategoriaOpcions("categorias_clientes");
            var precios = await _repoCliente.GetCategoriaOpcions("precios_clientes");

            this.cbCategoria.DataSource = categorias;
            this.cbCategoria.DisplayMember = "Nombre";
            this.cbCategoria.ValueMember = "IdCategoriaOpcion";

            this.cbPrecio.DataSource = precios;
            this.cbPrecio.DisplayMember = "Nombre";
            this.cbPrecio.ValueMember = "IdCategoriaOpcion";

        }

        public void ResetForm()
        {
            txtClaveRegistro.Text = "";
            txtBanco.Text = "";
            txtCel.Text = "";
            txtCiudad.Text = "";
            txtClaveInter.Text = "";
            txtCp.Text = "";
            txtCuentaBancaria.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtEstado.Text = "";
            txtNotas.Text = "";
            txtPais.Text = "";
            txtPaqueteria.Text = "";
            txtRazoSocial.Text = "";
            txtECel.Text = "";
            txtECiudad.Text = "";
            txtECp.Text = "";
            txtEDomicilio.Text = "";
            txtEEmail.Text = "";
            txtEEstado.Text = "";
            txtEPais.Text = "";
            txtRepresentante.Text = "";
            txtETel.Text = "";
            txtRfc.Text = "";
            txtTelefono.Text = "";
            txtId.Value = 0;
            txtLimiteCredito.Text = "";
            txtDiasCredito.Value = 0;
            cbCategoria.SelectedValue = 0;
            cbPrecio.SelectedValue = 0;
        }

        public async Task LoadForm(int id)
        {
            var cliente = await _repoCliente.Get(id);
            txtClaveRegistro.Text = cliente == null ? "" : cliente.ClaveRegistro;
            txtBanco.Text = cliente == null ? "" : cliente.Banco;
            txtCel.Text = cliente == null ? "" : cliente.Celular;
            txtCiudad.Text = cliente == null ? "" : cliente.Ciudad;
            txtClaveInter.Text = cliente == null ? "" : cliente.ClaveBancaria;
            txtCp.Text = cliente == null ? "" : cliente.Cp;
            txtCuentaBancaria.Text = cliente == null ? "" : cliente.CuentaBancaria;
            txtDomicilio.Text = cliente == null ? "" : cliente.Domicilio;
            txtEmail.Text = cliente == null ? "" : cliente.Email;
            txtEstado.Text = cliente == null ? "" : cliente.Estado;
            txtNotas.Text = cliente == null ? "" : cliente.Comentario;
            txtPais.Text = cliente == null ? "" : cliente.Pais;
            txtPaqueteria.Text = cliente == null ? "" : cliente.Paqueteria;
            txtRazoSocial.Text = cliente == null ? "" : cliente.RazonSocial;
            txtECel.Text = cliente == null ? "" : cliente.EmpresaCelular;
            txtECiudad.Text = cliente == null ? "" : cliente.EmpresaCiudad;
            txtECp.Text = cliente == null ? "" : cliente.EmpresaCp;
            txtEDomicilio.Text = cliente == null ? "" : cliente.EmpresaDomicilio;
            txtEEmail.Text = cliente == null ? "" : cliente.EmpresaEmail;
            txtEEstado.Text = cliente == null ? "" : cliente.EmpresaEstado;
            txtEPais.Text = cliente == null ? "" : cliente.EmpresaPais;
            txtRepresentante.Text = cliente == null ? "" : cliente.Representante;
            txtETel.Text = cliente == null ? "" : cliente.EmpresaTelefeono;
            txtRfc.Text = cliente == null ? "" : cliente.Rfc;
            txtTelefono.Text = cliente == null ? "" : cliente.Telefono;
            txtId.Value = cliente == null ? 0:cliente.Id;
            txtLimiteCredito.Text = cliente == null ? 0.ToString() : cliente.LimiteCredito.ToString();
            txtDiasCredito.Value = cliente == null ? 0 : cliente.DiasCredito;
            cbCategoria.SelectedValue = cliente == null ? 0 : cliente.IdCategoria;
            cbPrecio.SelectedValue = cliente == null ? 0 : cliente.IdNumeroPrecio;
        }

        private Cliente GetCliente() => new Cliente
        {
            ClaveRegistro = txtClaveRegistro.Text,
            Banco = txtBanco.Text,
            Celular = txtCel.Text,
            Ciudad = txtCiudad.Text,
            ClaveBancaria = txtClaveInter.Text,
            Cp = txtCp.Text,
            CuentaBancaria = txtCuentaBancaria.Text,
            Domicilio = txtDomicilio.Text,
            Email = txtEmail.Text,
            Estado = txtEstado.Text,
            Comentario = txtNotas.Text,
            Pais = txtPais.Text,
            Id = (int)txtId.Value,
            Paqueteria = txtPaqueteria.Text,
            RazonSocial = txtRazoSocial.Text,
            Representante = txtRepresentante.Text,
            EmpresaCelular = txtECel.Text,
            EmpresaCiudad = txtECiudad.Text,
            EmpresaDomicilio = txtEDomicilio.Text,
            EmpresaEmail = txtEEmail.Text,
            EmpresaEstado = txtEEstado.Text,
            EmpresaPais = txtEPais.Text,
            EmpresaTelefeono = txtETel.Text,
            EmpresaCp = txtECp.Text,
            Rfc = txtRfc.Text,
            Telefono = txtTelefono.Text,
            IdCategoria = (int) cbCategoria.SelectedValue,
            DiasCredito = txtDiasCredito.Value,
            IdNumeroPrecio = (int) cbPrecio.SelectedValue,
            LimiteCredito = Decimal.Parse(txtLimiteCredito.Text == "" ? "   0" : txtLimiteCredito.Text),
        };


        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtRepresentante.Text)) return false;
            if (string.IsNullOrEmpty(txtClaveRegistro.Text)) return false;
            if (string.IsNullOrEmpty(txtTelefono.Text)) return false;
            if (string.IsNullOrEmpty(txtRazoSocial.Text)) return false;
            if (string.IsNullOrEmpty(txtEmail.Text)) return false;
            if (string.IsNullOrEmpty(txtNotas.Text)) return false;

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = GetCliente();
            try
            {
                if (cliente.Id == 0)
                {
                    if (!ValidateForm()) throw new Exception("Llena los campos faltantes");
                    this._repoCliente.Add(cliente).Wait();
                }
                else
                {
                    if (!ValidateForm()) throw new Exception("Llena los campos faltantes");
                    this._repoCliente.Update(cliente.Id, cliente).Wait();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
