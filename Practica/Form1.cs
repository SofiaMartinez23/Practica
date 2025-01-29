using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica.Models;
using Practica.Repository;


namespace Practica
{
    public partial class Form1 : Form
    {

        RepositoryPractica repo;

        public Form1()
        {
            InitializeComponent();
            this.repo = new RepositoryPractica();
            this.LoadEmpresa();

        }

        public async Task LoadEmpresa()
        {
            List<string> clientes = await this.repo.GetEmpresaAsync();
            this.cmbClientes.Items.Clear();
            foreach (string name in clientes)
            {
                this.cmbClientes.Items.Add(name);
            }
        }

        public async Task LoadPedido(string codPedido)
        {
            this.txtEmpresa.Clear();
            this.txtContacto.Clear();
            this.txtCargo.Clear();
            this.txtCiudad.Clear();
            this.txtTelefono.Clear();

            Pedido pedido = await this.repo.GetPedidosAsync(codPedido);
            this.txtCodigoPedido.Text = pedido.codPedido.ToString();
            this.txtFechaEntrega.Text = pedido.fechaEntrega.ToString();
            this.txtFormaEnvio.Text = pedido.formaEnvio.ToString();
            this.txtImporte.Text = pedido.importe.ToString();
        }

        public async Task LoadClientes(string empresaSeleccionada)
        {
            this.txtEmpresa.Clear();
            this.txtContacto.Clear();
            this.txtCargo.Clear();
            this.txtCiudad.Clear();
            this.txtTelefono.Clear();

            PedidoCliente pc = await this.repo.GetClientesAsync(empresaSeleccionada);
            this.txtEmpresa.Text = pc.clientes.empresa.ToString();
            this.txtContacto.Text = pc.clientes.contacto.ToString();
            this.txtCargo.Text = pc.clientes.cargo.ToString();
            this.txtCiudad.Text = pc.clientes.ciudad.ToString();
            this.txtTelefono.Text = pc.clientes.telefono.ToString();
        }

        private async void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbClientes.SelectedIndex != -1)
            {
                string empresaSeleccionada = this.cmbClientes.SelectedIndex.ToString();
                await this.LoadClientes(empresaSeleccionada);
            }
        }

        private async void btnElimiarPedio_Click(object sender, EventArgs e)
        {
            string codigoPedido = this.lstPedidos.SelectedItem.ToString();
            await this.repo.DeletePedidoAsync(codigoPedido);
            string nombreEmpresa = this.cmbClientes.SelectedItem.ToString();
            await this.LoadClientes(nombreEmpresa);

            this.txtCodigoPedido.Clear();
            this.txtFechaEntrega.Clear();
            this.txtFormaEnvio.Clear();
            this.txtImporte.Clear();


        }

        private async void lstPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstPedidos.SelectedIndex != -1)
            {
                string pedidoSeleccionado = this.lstPedidos.SelectedIndex.ToString();
                await this.repo.GetPedidosAsync(pedidoSeleccionado);
            }
        }
    }
}
