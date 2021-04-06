﻿using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcUsuarios
{
    public class UserMediator : Mediator
    {
        private Usuarios _componentUsers;
        public Usuarios Usuarios 
        { 
            set {
                _componentUsers = value;
            } 
        }
        private FormUsuario _formUsuario;
        public FormUsuario FormUsuario
        {
            set
            {
                _formUsuario = value;
            }
        }

        public UserMediator(FormUsuario formUsuario, Usuarios componentUsers)
        {
            _formUsuario = formUsuario;
            _componentUsers = componentUsers;
            _formUsuario.SetMediator(this);
            _componentUsers.SetMediator(this);
        }



        public void Notificar(object sender, string e)
        {
            switch (e)
            {
                case "formularioCierre":
                    this._componentUsers.SelectedUsuario = null;
                    break;
                case "openAddUser":
                    this._formUsuario.Show();
                    break;
            }
        }
    }
}
