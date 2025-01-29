using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Helpers;
using Microsoft.Data.SqlClient;
using Practica.Models;

#region
/* 

create procedure SP_ALL_CLIENTES
as
 select * from clientes
go

-----------------

create procedure SP_DELETE_PEDIDO
(@codigopedido nvarchar(50))
as
 delete from pedidos where CodigoPedido = @codigopedido
go

-----------------

create procedure SP_DATOS_PEDIDO
(@codigopedido nvarchar(50))
as
 select CodigoPedido, CodigoCliente, FechaEntrega, FormaEnvio, Importe 
 from pedidos where CodigoPedido = @codigopedido
go

-----------------

create procedure SP_CLIENTE_EMPRESA
(@nombreempresa nvarchar(50))
as
	select c.CodigoCliente, c.Empresa, c.Contacto, c.Cargo, c.Ciudad, c.Telefono,
	p.CodigoPedido, p.FechaEntrega, p.FormaEnvio, p.Importe
	from clientes c
	left join pedidos p on c.CodigoCliente = p.CodigoCliente
	where c.Empresa = @nombreempresa
go
*/


#endregion
namespace Practica.Repository
{
    public class RepositoryPractica
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryPractica()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetEmpresaAsync()
        {
            string sql = "SP_ALL_CLIENTES";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> clientes = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["Empresa"].ToString();
                clientes.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return clientes;
        }

        public async Task<PedidoCliente> GetClientesAsync(string nombreEmpresa)
        {
            string sql = "SP_CLIENTE_EMPRESA";
            this.com.Parameters.AddWithValue("@nombreempresa", nombreEmpresa);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            Cliente cliente = null;
            Pedido pedido = null;

            List<Pedido> pedidolista = new List<Pedido>();
            PedidoCliente pc = new PedidoCliente();

            while (await this.reader.ReadAsync())
            {
                cliente = new Cliente
                {
                    codCliente = this.reader["CodigoCliente"].ToString(),
                    empresa = this.reader["Empresa"].ToString(),
                    contacto = this.reader["Contacto"].ToString(),
                    cargo = this.reader["Cargo"].ToString(),
                    ciudad = this.reader["Ciudad"].ToString(),
                    telefono = int.Parse(this.reader["Telefono"].ToString()),
                };

                pedido = new Pedido
                {
                    codPedido = this.reader["CodigoPedido"].ToString(),
                    codCliente = this.reader["CodigoCliente"].ToString(),
                    fechaEntrega = this.reader["FechaEntrega"].ToString(),
                    formaEnvio = this.reader["FormaEnvio"].ToString(),
                    importe = int.Parse(this.reader["Importe"].ToString())
                };

                pedidolista.Add(pedido);
            }

            await this.reader.CloseAsync();
            pc.clientes = cliente;
            pc.pedidos = pedidolista;

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return pc;

        }

        public async Task<Pedido> GetPedidosAsync(string codPedido)
        {
            string sql = "SP_DATOS_PEDIDO";
            this.com.Parameters.AddWithValue("@codigopedido", codPedido);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            Pedido pedido = null;
           
            while (await this.reader.ReadAsync()) 
            {
                pedido = new Pedido
                {
                    codPedido = this.reader["CodigoPedido"].ToString(),
                    codCliente = this.reader["CodigoCliente"].ToString(),
                    fechaEntrega = this.reader["FechaEntrega"].ToString(),
                    formaEnvio = this.reader["FormaEnvio"].ToString(),
                    importe = int.Parse(this.reader["Importe"].ToString()),
                };
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return pedido;

        }

        public async Task DeletePedidoAsync(string codPedido)
        {
            string sql = "SP_DELETE_PEDIDO";
            this.com.Parameters.AddWithValue("@codigopedido", codPedido);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            int eliminados = await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            MessageBox.Show("Pedidos eliminados: " + eliminados);

        }

    }
}
