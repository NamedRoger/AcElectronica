using DatabasaeManager;
using DatabasaeManager.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcClientes
{
    public class ClienteRepo : IClienteRepo
    {
        private readonly DataContext context;

        public ClienteRepo(DataContext context)
        {
            this.context = context;
        }

        public async Task Add(Cliente cliente)
        {
            cliente.FechaAlta = DateTime.Now;
            await context.Clientes.AddAsync(cliente);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int key)
        {
            var proveedor = await Get(key);
            proveedor.Activo = false;
            await context.SaveChangesAsync();
        }

        public async Task<Cliente> Get(int key)
        {
            return await context.Clientes.Where(p => p.Activo).FirstOrDefaultAsync(p => p.Id == key);
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await context.Clientes.Where(p => p.Activo).ToListAsync();
        }

        public async Task Update(int key, Cliente endidad)
        {
            var cliente = await context.Clientes.FindAsync(key);

            cliente.ClaveRegistro = endidad.ClaveRegistro;
            cliente.IdCategoria = endidad.IdCategoria;
            cliente.Representante = endidad.Representante;
            cliente.Telefono = endidad.Telefono;
            cliente.Celular = endidad.Celular;
            cliente.Email = endidad.Email;
            cliente.Domicilio = endidad.Domicilio;
            cliente.Ciudad = endidad.Ciudad;
            cliente.Estado = endidad.Estado;
            cliente.Pais = endidad.Pais;
            cliente.Cp = endidad.Cp;

            cliente.RazonSocial = endidad.RazonSocial;
            cliente.Rfc = endidad.Rfc;
            cliente.EmpresaTelefeono = endidad.EmpresaTelefeono;
            cliente.EmpresaEmail = endidad.EmpresaEmail;
            cliente.EmpresaCelular = endidad.EmpresaCelular;
            cliente.EmpresaDomicilio = endidad.EmpresaDomicilio;
            cliente.EmpresaCiudad = endidad.EmpresaCiudad;
            cliente.EmpresaEstado = endidad.EmpresaEstado;
            cliente.EmpresaPais = endidad.EmpresaPais;
            cliente.EmpresaCp = endidad.EmpresaCp;
            cliente.Comentario = endidad.Comentario;


            cliente.Banco = endidad.Banco;
            cliente.ClaveBancaria = endidad.ClaveBancaria;
            cliente.CuentaBancaria = endidad.CuentaBancaria;
            cliente.LimiteCredito = endidad.LimiteCredito;
            cliente.DiasCredito = endidad.DiasCredito;
            cliente.IdNumeroPrecio = endidad.IdNumeroPrecio;
            cliente.Paqueteria = endidad.Paqueteria;

            await context.SaveChangesAsync();
        }

        public async Task<List<CategoriaOpcion>> GetCategoriaOpcions(string categoria)
        {
            categoria = categoria.ToUpper();
            var opciones = await context.CategoriaOpcions.Include(co => co.CategoriaMenu)
                .Where(co => co.CategoriaMenu.Nombre.ToUpper() == categoria)
                .ToListAsync();
            return opciones;
        }
    }
}
