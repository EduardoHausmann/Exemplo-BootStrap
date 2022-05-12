namespace Model
{
    public class Veiculo
    {
        public int Id;
        public string Modelo;
        public decimal Valor;

        //Propriedade para a coluna do id_categoria(FK)
        public int IdCategoria;

        /*Objeto da categoria que permitirá acessar as
         informações da categoria através do veiculo
         */
        public Categoria Categoria;
    }
}
