namespace Api.Models;

public class Producto
{
    public int ProductoId { get; set; }
    public string Nombre { get; set; } = null!;
    public string Descripcion { get; set; } = null!;
    public decimal Precio { get; set; }
    public string ImagenUrl { get; set; } = null!;
    
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
}

