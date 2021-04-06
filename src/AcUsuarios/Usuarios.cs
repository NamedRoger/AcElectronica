using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabasaeManager.Entidades;
using FastMember;
using Infrastructure;

namespace AcUsuarios
{
    public partial class Usuarios : Form
    {
        private Mediator _mediator;
        private readonly IRepoUsuario<Usuario> _repo;
        private Usuario _usuario;
        public Usuario SelectedUsuario
        {
            get => _usuario;
            set
            {
                _usuario = value;
            }
        }

        public Usuarios(IRepoUsuario<Usuario> repoUsuario)
        {
            this._repo = repoUsuario;
            InitializeComponent();
            LoadTable().Wait();
            loadButtons();
        }

        private void navbar1_Load(object sender, EventArgs e)
        {

        }

        private void loadButtons()
        {
            navbar1.AddButtonAgregar((s, e) =>
            {
                SelectedUsuario = new Usuario();
                this._mediator.Notificar(s, "openAddUser");
            });

            navbar1.AddButtonEditar((s, e) =>
            {
                if (_usuario == null) ShowAlert("No ha seleccionado ningun usuario", "Error");
                else this._mediator.Notificar(s, "openEditUser");
            });

            navbar1.AddButtonEliminar((s, e) =>
            {
                if (_usuario == null) ShowAlert("No ha seleccionado ningun usuario", "Error");
            });
        }

        private void ShowAlert(string text, string caption = "")
        {
            MessageBox.Show(text, caption);
        }


        public void SetMediator(Mediator mediator)
        {
            this._mediator = mediator;
        }

        public async Task LoadTable()
        {
            var usuarios = (await this._repo.GetAll()).Select(u => new UsuarioTabla { Id = u.Id, Usuario = u.Username }).ToList();
            this.tablaUsuarios.DataSource = usuarios.Count() == 0 ? new List<UsuarioTabla>() : usuarios;
        }


        private void tablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.tablaUsuarios.Rows[e.RowIndex];
                int idUser = (int)row.Cells["Id"].Value;
                SelectedUsuario = FindUser(idUser).Result;
                loadForm();
            }
        }

        private async Task<Usuario> FindUser(int id)
        {
            var usuario = await this._repo.Get(id);
            return usuario;
        }

        public void resetForm()
        {
            SelectedUsuario = null;
            loadForm();
        }

        public void loadForm()
        {
            txtAddress.Text = SelectedUsuario != null ? SelectedUsuario.Direccion : "";
            txtCelular.Text = SelectedUsuario == null ? "" : SelectedUsuario.Celular;
            txtCurp.Text = SelectedUsuario == null ? "" : SelectedUsuario.Curp;
            txtFechaAlta.Value = SelectedUsuario == null ? DateTime.Now : SelectedUsuario.FechaAlta;
            txtFechaNacimiento.Value = SelectedUsuario == null ? DateTime.Now : SelectedUsuario.FechaNacimiento;
            txtNoInfo.Text = SelectedUsuario == null ? "" : SelectedUsuario.NumeroInfonavit;
            txtNss.Text = SelectedUsuario == null ? "" : SelectedUsuario.Nss;
            txtPassword.Text = SelectedUsuario == null ? "" : SelectedUsuario.Password;
            txtTelefono.Text = SelectedUsuario == null ? "" : SelectedUsuario.Telefono;
            txtUserName.Text = SelectedUsuario == null ? "" : SelectedUsuario.Username;
        }
    }

}