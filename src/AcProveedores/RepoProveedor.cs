using DatabasaeManager;
using DatabasaeManager.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcProveedores
{
    public class RepoProveedor : IRepoProveedor
    {
        private readonly DataContext _context;

        public RepoProveedor(DataContext context)
        {
            _context = context;
        }

        public async Task Add(Proveedor proveedor)
        {
            await _context.Proveedores.AddAsync(proveedor);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int key)
        {
            var proveedor = await Get(key);
            proveedor.Activo = false;
            await _context.SaveChangesAsync();
        }

        public async Task<Proveedor> Get(int key)
        {
            return await _context.Proveedores.Where(p => p.Activo).FirstOrDefaultAsync(p => p.Id == key);
        }

        public async Task<IEnumerable<Proveedor>> GetAll()
        {
            return await _context.Proveedores.Where(p => p.Activo).ToListAsync();
        }

        public async Task Update(int key, Proveedor endidad)
        {
            var proveedor = await _context.Proveedores.FindAsync(key);
            proveedor.ApodoProveedor = endidad.ApodoProveedor;
            proveedor.Banco = endidad.Banco;
            proveedor.Banco2 = endidad.Banco2;
            proveedor.Banco3 = endidad.Banco3;
            proveedor.Celular = endidad.Celular;
            proveedor.Ciudad = endidad.Ciudad;
            proveedor.ClaveBancaria = endidad.ClaveBancaria;
            proveedor.ClaveBancaria2 = endidad.ClaveBancaria2;
            proveedor.ClaveBancaria3 = endidad.ClaveBancaria3;
            proveedor.Cp = endidad.Cp;
            proveedor.CuentaBancaria = endidad.CuentaBancaria;
            proveedor.CuentaBancaria2 = endidad.CuentaBancaria2;
            proveedor.CuentaBancaria3 = endidad.CuentaBancaria3;
            proveedor.Domicilio = endidad.Domicilio;
            proveedor.Email = endidad.Email;
            proveedor.Estado = endidad.Estado;
            proveedor.Notas = endidad.Notas;
            proveedor.Pais = endidad.Pais;
            proveedor.Paqueteria = endidad.Paqueteria;
            proveedor.RazonSocial = endidad.RazonSocial;
            proveedor.Representante = endidad.Representante;
            proveedor.RepresentanteCelular = endidad.RepresentanteCelular;
            proveedor.RepresentanteCiudad = endidad.RepresentanteCiudad;
            proveedor.RepresentanteDomicilio = endidad.RepresentanteDomicilio;
            proveedor.RepresentanteEmail = endidad.RepresentanteEmail;
            proveedor.RepresentanteEstado = endidad.RepresentanteEstado;
            proveedor.RepresentantePais = endidad.RepresentantePais;
            proveedor.RepresentanteTelefeono = endidad.RepresentanteTelefeono;
            proveedor.RepresentatneCp = endidad.RepresentatneCp;
            proveedor.Rfc = endidad.Rfc;
            proveedor.Telefono = endidad.Telefono;

            await _context.SaveChangesAsync();
        }
    }
}
