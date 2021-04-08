using DatabasaeManager.Entidades;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcUsuarios
{
    public partial class FormUsuario : Form
    {
        private Mediator mediator;
        private IRepoUsuario<Usuario> _repo;

        public FormUsuario(IRepoUsuario<Usuario> repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void navbar1_Load(object sender, EventArgs e)
        {

        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }


        private void FormUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.ResetForm();
            this.Hide();
            this.mediator.Notificar(sender, "formularioCierre");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = GetUsuario();
            try
            {
                if (usuario.Id == 0)
                {
                    if (!ValidateForm()) throw new Exception("Favor de rellenar los campos requeridos");
                    if (!string.IsNullOrEmpty(txtFoto.Text))
                        usuario.Foto = SaveFotoUser();

                    var result = this._repo.Add(usuario);
                    result.Wait();
                    if(result.IsCompleted){
                        this.AddOrUpdateApps(usuario).Wait();
                    }
                }
                else
                {
                    usuario = _repo.Get(usuario.Id).Result;
                    if (!string.IsNullOrEmpty(txtFoto.Text))
                        usuario.Foto = SaveFotoUser();

                    this.AddOrUpdateApps(usuario).Wait();
                    this._repo.Update(usuario.Id, usuario);
                }
                this.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "Error");
            }

        }

        public void ResetForm()
        {
            txtId.Text = "";
            txtAddress.Text = "";
            txtCelular.Text = "";
            txtCurp.Text = "";
            txtFechaAlta.Value = DateTime.Now;
            txtFechaNacimiento.Value = DateTime.Now;
            txtNoInfo.Text = "";
            txtNss.Text = "";
            txtPassword.Text = "";
            txtTelefono.Text = "";
            txtUserName.Text = "";
            txtFoto.Text = "";
            txtId.Text = "";

            cbxAlmacen.Checked = false;
            cbxClientes.Checked = false;
            cbxProveedores.Checked = false;
            cbxUsuarios.Checked = false;
            chxInsumos.Checked = false;
            chxVentas.Checked = false;

            pictureBox1.Image = null;
        }

        public async Task LoadForm(int id)
        {
            var usuario = await _repo.Get(id);

            txtId.Text = usuario.Id.ToString();
            txtAddress.Text = usuario != null ? usuario.Direccion : "";
            txtCelular.Text = usuario == null ? "" : usuario.Celular;
            txtCurp.Text = usuario == null ? "" : usuario.Curp;
            txtFechaAlta.Value = usuario == null ? DateTime.Now : usuario.FechaAlta;
            txtFechaNacimiento.Value = usuario == null ? DateTime.Now : usuario.FechaNacimiento;
            txtNoInfo.Text = usuario == null ? "" : usuario.NumeroInfonavit;
            txtNss.Text = usuario == null ? "" : usuario.Nss;
            txtPassword.Text = usuario == null ? "" : usuario.Password;
            txtTelefono.Text = usuario == null ? "" : usuario.Telefono;
            txtUserName.Text = usuario == null ? "" : usuario.Username;

            pictureBox1.Image = usuario == null ?
              null :
              (string.IsNullOrEmpty(usuario.Foto)) ? null : new Bitmap(usuario.Foto);

            cbxUsuarios.Checked = usuario == null ? false : await _repo.HasApplication(usuario.Id, "usuarios");
            cbxProveedores.Checked = usuario == null ? false : await _repo.HasApplication(usuario.Id, "proveedores");
            cbxClientes.Checked = usuario == null ? false : await _repo.HasApplication(usuario.Id, "clientes");
            cbxAlmacen.Checked = usuario == null ? false : await _repo.HasApplication(usuario.Id, "almacen");
            chxInsumos.Checked = usuario == null ? false : await _repo.HasApplication(usuario.Id, "insumos");
            chxVentas.Checked = usuario == null ? false : await _repo.HasApplication(usuario.Id, "ventas");
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim())) return false;
            if (string.IsNullOrEmpty(txtPassword.Text.Trim())) return false;

            return true;
        }


        private Usuario GetUsuario() => new Usuario
        {
            Activo = true,
            Celular = txtCelular.Text,
            Curp = txtCurp.Text,
            Direccion = txtAddress.Text,
            FechaAlta = txtFechaAlta.Value,
            FechaNacimiento = txtFechaNacimiento.Value,
            Id = txtId.Text.Trim() == "" ? 0 : int.Parse(txtId.Text),
            Nss = txtNss.Text,
            NumeroInfonavit = txtNoInfo.Text,
            Password = txtPassword.Text,
            Telefono = txtTelefono.Text,
            Username = txtUserName.Text,
        };

        private void bus_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                txtFoto.Text = openFileDialog1.FileName;
            }
        }

        private string SaveFotoUser()
        {
            string pathFotos = Path.Combine(Application.StartupPath, "Fotos");
            string sourceFile = txtFoto.Text;
            return SaveFile(sourceFile, pathFotos);
        }

        private string SaveFile(string sourceFile, string destinationFile)
        {
            if (!Directory.Exists(destinationFile)) Directory.CreateDirectory(destinationFile);
            string filePath = Path.Combine(destinationFile, Path.GetFileName(sourceFile));
            File.Copy(sourceFile, filePath, true);
            return filePath;
        }

        private async Task AddOrUpdateApps(Usuario usuario)
        {
            if (cbxAlmacen.Checked) await _repo.AddApp(usuario.Id, cbxAlmacen.AccessibleName.Trim());
            else await _repo.RemoveApp(usuario.Id, cbxAlmacen.AccessibleName.Trim());

            if (cbxClientes.Checked) await _repo.AddApp(usuario.Id, cbxClientes.AccessibleName.Trim());
            else await _repo.RemoveApp(usuario.Id, cbxClientes.AccessibleName.Trim());

            if (cbxProveedores.Checked) await _repo.AddApp(usuario.Id, cbxProveedores.AccessibleName.Trim());
            else await _repo.RemoveApp(usuario.Id, cbxProveedores.AccessibleName.Trim());

            if (cbxUsuarios.Checked) await _repo.AddApp(usuario.Id, cbxUsuarios.AccessibleName.Trim());
            else await _repo.RemoveApp(usuario.Id, cbxUsuarios.AccessibleName.Trim());

            if (chxInsumos.Checked) await _repo.AddApp(usuario.Id, chxInsumos.AccessibleName.Trim());
            else await _repo.RemoveApp(usuario.Id, chxInsumos.AccessibleName.Trim());

            if (chxVentas.Checked) await _repo.AddApp(usuario.Id, chxVentas.AccessibleName.Trim());
            else await _repo.RemoveApp(usuario.Id, chxVentas.AccessibleName.Trim());
        }
    }
}
