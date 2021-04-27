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

namespace AcProveedores
{
    public partial class FormularioProveedores : Form
    {
        private Mediator mediator;
        private IRepoProveedor _repoProveedor;

        public FormularioProveedores(IRepoProveedor repoProveedor)
        {
            InitializeComponent();
            _repoProveedor = repoProveedor;
        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormularioProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.ResetForm();
            this.Hide();
            this.mediator.Notificar(sender,"closeFormulario");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var proveedor = GetProveedor();
            try
            {
                if (proveedor.Id == 0)
                {
                    if (!ValidateForm()) throw new Exception("Llena los campos faltantes");
                    this._repoProveedor.Add(proveedor).Wait();
                }
                else
                {
                    if (!ValidateForm()) throw new Exception("Llena los campos faltantes");
                    this._repoProveedor.Update(proveedor.Id,proveedor).Wait();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void ResetForm()
        {
            txtApodo.Text = "";
            txtBanco.Text = "";
            txtBanco2.Text = "";
            txtBanco3.Text = "";
            txtCiudad.Text = "";
            txtCel.Text = "";
            txtClaveInter.Text = "";
            txtClaveInter2.Text = "";
            txtClaveInter3.Text = "";
            txtCp.Text = "";
            txtCuentaBancaria.Text = "";
            txtCuentaBancaria2.Text = "";
            txtCuentaBancaria3.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtEstado.Text = "";
            txtNotas.Text = "";
            txtPais.Text = "";
            txtPaqueteria.Text =  "";
            txtRazonSocial.Text = "";
            txtRepreCel.Text = "";
            txtRepreCiudad.Text = "";
            txtRepreCp.Text = "";
            txtRepreDomicilio.Text = "";
            txtRepreEmail.Text = "";
            txtRepreEstado.Text = "";
            txtReprePais.Text = "";
            txtRepresentante.Text = "";
            txtRepreTel.Text = "";
            txtRfc.Text = "";
            txtTel.Text = "";
            txtId.Value = 0;
        }

        public async Task LoadForm(int id)
        {
            var proveedor = await _repoProveedor.Get(id);
            txtApodo.Text = proveedor == null ? "" : proveedor.ApodoProveedor;
            txtBanco.Text = proveedor == null ? "" : proveedor.Banco;
            txtBanco2.Text = proveedor == null ? "" : proveedor.Banco2;
            txtBanco3.Text = proveedor == null ? "" : proveedor.Banco3;
            txtCel.Text = proveedor == null ? "" : proveedor.Celular;
            txtCiudad.Text = proveedor == null ? "" : proveedor.Ciudad;
            txtClaveInter.Text = proveedor == null ? "" : proveedor.ClaveBancaria;
            txtClaveInter2.Text = proveedor == null ? "" : proveedor.ClaveBancaria2;
            txtClaveInter3.Text = proveedor == null ? "" : proveedor.ClaveBancaria3;
            txtCp.Text = proveedor == null ? "" : proveedor.Cp;
            txtCuentaBancaria.Text = proveedor == null ? "" : proveedor.CuentaBancaria;
            txtCuentaBancaria2.Text = proveedor == null ? "" : proveedor.CuentaBancaria2;
            txtCuentaBancaria3.Text = proveedor == null ? "" : proveedor.CuentaBancaria3;
            txtDomicilio.Text = proveedor == null ? "" : proveedor.Domicilio;
            txtEmail.Text = proveedor == null ? "" : proveedor.Email;
            txtEstado.Text = proveedor == null ? "" : proveedor.Estado;
            txtNotas.Text = proveedor == null ? "" : proveedor.Notas;
            txtPais.Text = proveedor == null ? "" : proveedor.Pais;
            txtPaqueteria.Text = proveedor == null ? "" : proveedor.Paqueteria;
            txtRazonSocial.Text = proveedor == null ? "" : proveedor.RazonSocial;
            txtRepreCel.Text = proveedor == null ? "" : proveedor.RepresentanteCelular;
            txtRepreCiudad.Text = proveedor == null ? "" : proveedor.RepresentanteCiudad;
            txtRepreCp.Text = proveedor == null ? "" : proveedor.RepresentatneCp;
            txtRepreDomicilio.Text = proveedor == null ? "" : proveedor.RepresentanteDomicilio;
            txtRepreEmail.Text = proveedor == null ? "" : proveedor.RepresentanteEmail;
            txtRepreEstado.Text = proveedor == null ? "" : proveedor.RepresentanteEstado;
            txtReprePais.Text = proveedor == null ? "" : proveedor.RepresentantePais;
            txtRepresentante.Text = proveedor == null ? "" : proveedor.Representante;
            txtRepreTel.Text = proveedor == null ? "" : proveedor.RepresentanteTelefeono;
            txtRfc.Text = proveedor == null ? "" : proveedor.Rfc;
            txtTel.Text = proveedor == null ? "" : proveedor.Telefono;
            txtId.Value = proveedor.Id;
        }

        private Proveedor GetProveedor() => new Proveedor
        {
            ApodoProveedor = txtApodo.Text,
            Banco = txtBanco.Text,
            Banco2 = txtBanco2.Text,
            Banco3 = txtBanco3.Text,
            Celular = txtCel.Text,
            Ciudad = txtCiudad.Text,
            ClaveBancaria = txtClaveInter.Text,
            ClaveBancaria2 = txtClaveInter2.Text,
            ClaveBancaria3 = txtClaveInter3.Text,
            Cp = txtCp.Text,
            CuentaBancaria = txtCuentaBancaria.Text,
            CuentaBancaria2 = txtCuentaBancaria2.Text,
            CuentaBancaria3 = txtCuentaBancaria3.Text,
            Domicilio = txtDomicilio.Text,
            Email = txtEmail.Text,
            Estado = txtEstado.Text,
            Activo = true,
            FechaAlta = DateTime.Now,
            Notas = txtNotas.Text,
            Pais = txtPais.Text,
            Id = (int)txtId.Value,
            Paqueteria = txtPaqueteria.Text,
            RazonSocial = txtRazonSocial.Text,
            Representante = txtRepresentante.Text,
            RepresentanteCelular = txtRepreCel.Text,
            RepresentanteCiudad = txtRepreCiudad.Text,
            RepresentanteDomicilio = txtRepreDomicilio.Text,
            RepresentanteEmail = txtRepreEmail.Text,
            RepresentanteEstado = txtRepreEstado.Text,
            RepresentantePais = txtReprePais.Text,
            RepresentanteTelefeono = txtRepreTel.Text,
            RepresentatneCp = txtRepreCp.Text,
            Rfc = txtRfc.Text,
            Telefono = txtTel.Text,
        };


        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtRepresentante.Text)) return false;
            if (string.IsNullOrEmpty(txtRepreCel.Text)) return false;
            if (string.IsNullOrEmpty(txtTel.Text)) return false;
            if (string.IsNullOrEmpty(txtRazonSocial.Text)) return false;
            if (string.IsNullOrEmpty(txtEmail.Text)) return false;
            if (string.IsNullOrEmpty(txtNotas.Text)) return false;

            return true;
        }

        private void FormularioProveedores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
