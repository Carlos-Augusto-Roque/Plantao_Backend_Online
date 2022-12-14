namespace Atividade
{
    /// <summary>
    /// Classe Pessoa_Juridica que herda da classe Clientes
    /// </summary>
    public class Pessoa_Juridica : Clientes
    {
        //Propriedades da classe
        public string cnpj { get; set; }
        public string ie { get; set; }

        /// <summary>
        /// Método para calcular imposto de pessoa jurídica (sobrescrita)
        /// </summary>
        /// <param name="v">Valor da compra</param>
        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}