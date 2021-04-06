﻿using System;
using System.Windows.Forms;

namespace LoginLib
{
    public partial class Navbar: UserControl
    {
        public Navbar()
        {
            InitializeComponent();
        }

        public void AddButtonAgregar(EventHandler eventHandler)
        {
            this.btnAgregar.Click += eventHandler;
        }

        public void AddButtonEditar(EventHandler eventHandler)
        {
            this.btnEditar.Click += eventHandler;
        }

        public void AddButtonEliminar(EventHandler eventHandler)
        {
            this.btnBorrar.Click += eventHandler;
        }
    }
}
