
namespace ProjetoMercadoLivre.Lib.Models
{
    public class Pedido
    {
        public int IdUsuario { get; set; }
        public int Id { get; set; }
        public int IdTransportadora { get; set; }
        public Transportadora Transportadora { get; set; }
        public Usuario Usuario { get; set; }
        public int Pedidos { get; set; }
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
        public  List<Produto> Produtos { get; set; }
        public List<ProdutoXPedido> ProdutosXPedidos { get; set; }
    
        public Pedido(DateTime dataPedido, string status)
        {
            SetDataPedido(dataPedido);
            SetStatus(status);
        }
        public DateTime GetDataPedido()
        {
            return DataPedido;
        }
        public void SetDataPedido(DateTime dataPedido)
        {
            DataPedido = dataPedido;
        }
        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string status)
        {
            Status = status;
        }
    }
}