namespace Atividade
{
    /// <summary>
    /// Classe Pessoa_Fisica que herda da classe Clientes
    /// </summary>
    public class Pessoa_Fisica : Clientes
    {
        //Propiedades da classe
        public string cpf { get; set; }
        public string rg { get; set; }
    }
}