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
    public partial class Clientes : Form
    {
        private Mediator mediator;
        private readonly IClienteRepo _repo;
        public Cliente Cliente { get; set; } = null;

        public Clientes(IClienteRepo repo)
        {
            InitializeComponent();

            _repo = repo;
            LoadTable().Wait();
            LoadaCatalogos().Wait();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public async Task LoadaCatalogos()
        {
            var categorias = await _repo.GetCategoriaOpcions("categorias_clientes");
            var precios = await _repo.GetCategoriaOpcions("precios_clientes");

            this.cbCategoria.DataSource = categorias;
            this.cbCategoria.DisplayMember = "Nombre";
            this.cbCategoria.ValueMember = "IdCategoriaOpcion";

            this.cbPrecio.DataSource = precios;
            this.cbPrecio.DisplayMember = "Nombre";
            this.cbPrecio.ValueMember = "IdCategoriaOpcion";

        }


        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        private void LoadButtons()
        {
            this.navbar1.AddButtonAgregar((s, e) =>
            {
                Cliente = null;
                this.mediator.Notificar(s, "openFormularioAdd");
            });

            this.navbar1.AddButtonEditar((s, e) =>
            {
                if (Cliente == null) ShowAlert("No se ha seleccionado un Cliente", "Error");
                else this.mediator.Notificar(s, "openFormularioEdit");
            });

            this.navbar1.AddButtonEliminar((s, e) =>
            {
                if (Cliente == null) ShowAlert("No se ha seleccionado un Cliente", "Error");
                else
                {
                    try
                    {
                        DeleteCliente(Cliente.Id).Wait();
                        ResetForm();
                        LoadTable().Wait();
                    }
                    catch (Exception ex)
                    {
                        ShowAlert(ex.Message, "Error");
                    }

                }
            });

            this.navbar1.AddExcelExport((s, e) =>
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel|*.xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            var clientes = _repo.GetAll().Result.Select(p => new Cliente
                            {
                                ClaveRegistro = p.ClaveRegistro,
                                Banco = p.Banco,
                                Celular = p.Celular,
                                Ciudad = p.Ciudad,
                                ClaveBancaria = p.ClaveBancaria,
                                Cp = p.Cp,
                                CuentaBancaria = p.CuentaBancaria,
                                Domicilio = p.Domicilio,
                                Email = p.Email,
                                Estado = p.Estado,
                                FechaAlta = p.FechaAlta == DateTime.MinValue ? null : p.FechaAlta,
                                Paqueteria = p.Paqueteria,
                                RazonSocial = p.RazonSocial,
                                Representante = p.Representante,
                                Rfc = p.Rfc,
                                Telefono = p.Telefono,
                            }).ToList();

                            Exportar.Excel(clientes, saveFileDialog.FileName);
                        }
                        catch (Exception er)
                        {
                            ShowAlert(er.Message, "Error");
                        }
                    }
                }
            });

            this.navbar1.AddTextFilter((s, e) =>
            {
                Cliente = null;
                ResetForm();
                LoadTable(this.navbar1.GetFilterText()).Wait();
            });
        }

        public async Task LoadTable(string filter = "")
        {
            filter = filter.ToUpper();
            var proveedores = (await this._repo.GetAll()).Where(p => p.ClaveBancaria.ToUpper().Contains(filter.ToUpper())
                || p.Representante.ToUpper().Contains(filter)
                || p.Paqueteria.ToUpper().Contains(filter)
                || p.RazonSocial.ToUpper().Contains(filter)
                || p.EmpresaEmail.ToUpper().Contains(filter))
                .Select(p => new ClienteTabla { Id = p.Id, ClaveRegistro = p.ClaveRegistro, Representante = p.Representante })
                .ToList();
            tablaClientes.DataSource = proveedores;

        }

        private void txtRazoSocial_TextChanged(object sender, EventArgs e)
        {

        }

        public void ResetForm()
        {
            Cliente = null;
            LoadForm();
        }

        public void LoadForm()
        {
            txtClaveRegistro.Text = this.Cliente == null ? "" : this.Cliente.ClaveRegistro;
            txtBanco.Text = this.Cliente == null ? "" : this.Cliente.Banco;
            txtCel.Text = this.Cliente == null ? "" : this.Cliente.Celular;
            txtClaveInter.Text = this.Cliente == null ? "" : this.Cliente.ClaveBancaria;
            txtCp.Text = this.Cliente == null ? "" : this.Cliente.Cp;
            txtCuentaBancaria.Text = this.Cliente == null ? "" : this.Cliente.CuentaBancaria;
            txtCiudad.Text = this.Cliente == null ? "" : this.Cliente.Ciudad;
            txtDomicilio.Text = this.Cliente == null ? "" : this.Cliente.Domicilio;
            txtEmail.Text = this.Cliente == null ? "" : this.Cliente.Email;
            txtEstado.Text = this.Cliente == null ? "" : this.Cliente.Estado;
            txtNotas.Text = this.Cliente == null ? "" : this.Cliente.Comentario;
            txtPais.Text = this.Cliente == null ? "" : this.Cliente.Pais;
            txtRazoSocial.Text = this.Cliente == null ? "" : this.Cliente.RazonSocial;
            txtECel.Text = this.Cliente == null ? "" : this.Cliente.EmpresaCelular;
            txtECiudad.Text = this.Cliente == null ? "" : this.Cliente.EmpresaCiudad;
            txtECp.Text = this.Cliente == null ? "" : this.Cliente.EmpresaCp;
            txtEDomicilio.Text = this.Cliente == null ? "" : this.Cliente.EmpresaDomicilio;
            txtEEmail.Text = this.Cliente == null ? "" : this.Cliente.EmpresaEmail;
            txtEEstado.Text = this.Cliente == null ? "" : this.Cliente.EmpresaEstado;
            txtEPais.Text = this.Cliente == null ? "" : this.Cliente.EmpresaPais;
            txtRepresentante.Text = this.Cliente == null ? "" : this.Cliente.Representante;
            txtETel.Text = this.Cliente == null ? "" : this.Cliente.EmpresaTelefeono;
            txtRfc.Text = this.Cliente == null ? "" : this.Cliente.Rfc;
            txtTelefono.Text = this.Cliente == null ? "" : this.Cliente.Telefono;
            txtPaqueteria.Text = this.Cliente == null ? "" : this.Cliente.Paqueteria;
            txtDiasCredito.Value = this.Cliente == null ? 0 : this.Cliente.DiasCredito;
            txtLimiteCredito.Text = this.Cliente == null ? "0" : this.Cliente.LimiteCredito.ToString();
            cbCategoria.SelectedValue = this.Cliente == null ? 0 : this.Cliente.IdCategoria;
            cbPrecio.SelectedValue = this.Cliente == null ? 0 : this.Cliente.IdNumeroPrecio;

        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.tablaClientes.Rows[e.RowIndex];
                int id = (int)row.Cells["Id"].Value;
                Cliente = FindCliente(id).Result;
                row.Selected = true;
                LoadForm();
            }
        }


        public async Task<Cliente> FindCliente(int id) => await this._repo.Get(id);
        private void ShowAlert(string text, string caption = "") => MessageBox.Show(text, caption);
        public async Task DeleteCliente(int id) => await this._repo.Delete(id);

        private void navbar1_Load(object sender, EventArgs e)
        {
            LoadButtons();
        }
    }
}
