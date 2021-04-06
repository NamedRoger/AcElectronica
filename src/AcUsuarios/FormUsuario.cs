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

namespace AcUsuarios
{
    public partial class FormUsuario : Form
    {
        private Mediator mediator;

        public FormUsuario()
        {
            InitializeComponent();
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
            this.Hide();
            this.mediator.Notificar(sender, "formularioCierre");

        }
    }
}
