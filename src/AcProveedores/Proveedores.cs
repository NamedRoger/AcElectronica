﻿using DatabasaeManager.Entidades;
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
    public partial class Proveedores : Form
    {
        private Mediator mediator;
        private readonly IRepoProveedor _repo;
        public Proveedor Proveedor { get; set; }

        public Proveedores(IRepoProveedor repo)
        {
            InitializeComponent();
            _repo = repo;
            LoadTable().Wait();
        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void navbar1_Load(object sender, EventArgs e)
        {
            LoadButtons();
        }

        private void LoadButtons()
        {
            this.navbar1.AddButtonAgregar((s, e) =>
            {
                Proveedor = null;
                this.mediator.Notificar(s, "openFormularioAdd");
            });

            this.navbar1.AddButtonEditar((s, e) =>
            {
                if (Proveedor == null) ShowAlert("No se ha seleccionado un Proveedor", "Error");
                else this.mediator.Notificar(s, "openFormularioEdit");
            });

            this.navbar1.AddButtonEliminar((s, e) =>
            {
                if (Proveedor == null) ShowAlert("No se ha seleccionado un Proveedor", "Error");
                else
                {
                    try
                    {
                        DeleteProveedor(Proveedor.Id).Wait();
                        ResetForm();
                        LoadTable().Wait();
                    }
                    catch (Exception ex)
                    {
                        ShowAlert(ex.Message,"Error");
                    }
                  
                }
            });

            this.navbar1.AddExcelExport((s,e)=> {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel|*.xlsx"})
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            var proveedores = _repo.GetAll().Result.Select(p => new Proveedor { 
                                ApodoProveedor = p.ApodoProveedor,
                                Banco = p.Banco,
                                Banco2 = p.Banco2,
                                Banco3 = p.Banco3,
                                Celular = p.Celular,
                                Ciudad = p.Ciudad,
                                ClaveBancaria = p.ClaveBancaria,
                                ClaveBancaria2 = p.ClaveBancaria2,
                                ClaveBancaria3 = p.ClaveBancaria3,
                                Cp = p.Cp,
                                CuentaBancaria = p.CuentaBancaria,
                                CuentaBancaria2 = p.CuentaBancaria2,
                                CuentaBancaria3 = p.CuentaBancaria3,
                                Domicilio = p.Domicilio,
                                Email = p.Email,
                                Estado = p.Estado,
                                FechaAlta = p.FechaAlta == DateTime.MinValue ? null: p.FechaAlta,
                                UltimaCompra = p.UltimaCompra == DateTime.MinValue ? null : p.FechaAlta,
                                Notas = p.Notas,
                                Paqueteria = p.Paqueteria,
                                RazonSocial = p.RazonSocial,
                                Representante = p.Representante,
                                RepresentanteCelular = p.RepresentanteCelular,
                                Rfc = p.Rfc,
                                Telefono = p.Telefono,
                            }).ToList();

                            Exportar.Excel(proveedores,saveFileDialog.FileName);
                        }
                        catch (Exception er)
                        {
                            ShowAlert(er.Message,"Error");
                        }
                    }
                }
            });

            this.navbar1.AddTextFilter((s, e) =>
            {
                Proveedor = null;
                ResetForm();
                LoadTable(this.navbar1.GetFilterText()).Wait();
            });
        }

        public async Task LoadTable(string filter = "")
        {
            filter = filter.ToUpper();
            var proveedores = (await this._repo.GetAll()).Where(p => p.ApodoProveedor.ToUpper().Contains(filter.ToUpper()) 
                || p.Representante.ToUpper().Contains(filter) 
                || p.Paqueteria.ToUpper().Contains(filter)
                || p.RazonSocial.ToUpper().Contains(filter) 
                || p.RepresentanteEmail.ToUpper().Contains(filter))
                .Select(p => new ProveedorTabla { Id = p.Id, RazonSocial = p.RazonSocial, Representante = p.Representante })
                .ToList();
            tablaProveedores.DataSource = proveedores;

        }

        private void txtRazoSocial_TextChanged(object sender, EventArgs e)
        {

        }

        public void ResetForm()
        {
            Proveedor = null;
            LoadForm();
        }

        public void LoadForm()
        {
            txtApodo.Text = this.Proveedor == null ? "" : this.Proveedor.ApodoProveedor;
            txtBanco.Text = this.Proveedor == null ? "" : this.Proveedor.Banco;
            txtBanco2.Text = this.Proveedor == null ? "" : this.Proveedor.Banco2;
            txtBanco3.Text = this.Proveedor == null ? "" : this.Proveedor.Banco3;
            txtCel.Text = this.Proveedor == null ? "" : this.Proveedor.Celular;
            txtClaveInter.Text = this.Proveedor == null ? "" : this.Proveedor.ClaveBancaria;
            txtClaveInter2.Text = this.Proveedor == null ? "" : this.Proveedor.ClaveBancaria2;
            txtClaveInter3.Text = this.Proveedor == null ? "" : this.Proveedor.ClaveBancaria3;
            txtCp.Text = this.Proveedor == null ? "" : this.Proveedor.Cp;
            txtCuentaBancaria.Text = this.Proveedor == null ? "" : this.Proveedor.CuentaBancaria;
            txtCuentaBancaria2.Text = this.Proveedor == null ? "" : this.Proveedor.CuentaBancaria2;
            txtCuentaBancaria3.Text = this.Proveedor == null ? "" : this.Proveedor.CuentaBancaria3;
            txtCiudad.Text = this.Proveedor == null ? "" : this.Proveedor.Ciudad;
            txtDomicilio.Text = this.Proveedor == null ? "" : this.Proveedor.Domicilio;
            txtEmail.Text = this.Proveedor == null ? "" : this.Proveedor.Email;
            txtEstado.Text = this.Proveedor == null ? "" : this.Proveedor.Estado;
            txtNotas.Text = this.Proveedor == null ? "" : this.Proveedor.Notas;
            txtPais.Text = this.Proveedor == null ? "" : this.Proveedor.Pais;
            txtRazoSocial.Text = this.Proveedor == null ? "" : this.Proveedor.RazonSocial;
            txtRepreCelular.Text = this.Proveedor == null ? "" : this.Proveedor.RepresentanteCelular;
            txtRepreCiudad.Text = this.Proveedor == null ? "" : this.Proveedor.RepresentanteCiudad;
            txtRepreCp.Text = this.Proveedor == null ? "" : this.Proveedor.RepresentatneCp;
            txtRepreDomicilio.Text = this.Proveedor == null ? "" : this.Proveedor.RepresentanteDomicilio;
            txtRepreEmail.Text = this.Proveedor == null ? "" : this.Proveedor.RepresentanteEmail;
            txtRepreEstado.Text = this.Proveedor == null ? "" : this.Proveedor.RepresentanteEstado;
            txtReprePais.Text = this.Proveedor == null ? "" : this.Proveedor.RepresentantePais;
            txtRepresentante.Text = this.Proveedor == null ? "" : this.Proveedor.Representante;
            txtRepreTelefono.Text = this.Proveedor == null ? "" : this.Proveedor.RepresentanteTelefeono;
            txtRfc.Text = this.Proveedor == null ? "" : this.Proveedor.Rfc;
            txtTelefono.Text = this.Proveedor == null ? "" : this.Proveedor.Telefono;
            txtPaqueteria.Text = this.Proveedor == null ? "" : this.Proveedor.Paqueteria;
        }

        private void tablaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.tablaProveedores.Rows[e.RowIndex];
                int id = (int)row.Cells["Id"].Value;
                Proveedor = FindProveedor(id).Result;
                row.Selected = true;
                LoadForm();
            }
        }


        public async Task<Proveedor> FindProveedor(int id) => await this._repo.Get(id);
        private void ShowAlert(string text, string caption = "") => MessageBox.Show(text, caption);
        public async Task DeleteProveedor(int id) => await this._repo.Delete(id);

    }
}
