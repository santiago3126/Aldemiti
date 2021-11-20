namespace Aldemiti.Dominio
{
    public class Inventario
    {
        public string nombre {get; set;}
        public string fecha_de_compra {get; set;}
        public string fecha_de_vencimiento{get; set;}
        public float valor_compra{get; set;}
        public float valor_venta{get; set;}
        public string descripcion{get;set;}
        public int cantidad {get;set;}
        public string codigo{get;set;}
        public string proveedor{get;set;}

    }
}