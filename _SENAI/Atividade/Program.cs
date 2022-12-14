using Atividade;

//declaração de variável para armazenar o valor da compra
float val_pag;

//entrada do nome
Console.WriteLine("Informar Nome");
string var_nome = Console.ReadLine();

//entrada do endereço
Console.WriteLine("Informar Endereço");
string var_endereco = Console.ReadLine();

//entrada do tipo de cliente Pf ou Pj
Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
string var_tipo = Console.ReadLine();

//SE tipo de cliente for Pessoa Física
if (var_tipo == "f")
{
    // --- Pessoa Física ----

    //objeto de pessoa física instanciado
    Pessoa_Fisica pf = new Pessoa_Fisica();

    //atribuição do valor da propriedade "nome"
    pf.nome = var_nome;

    //atribuição do valor da propriedade "endereço"
    pf.endereco = var_endereco;

    //entrada e atribuição do cpf
    Console.WriteLine("Informar CPF:");
    pf.cpf = Console.ReadLine();

    //entrada e atribuição do rg
    Console.WriteLine("Informar RG:");
    pf.rg = Console.ReadLine();

    //entrada e atribuição do valor da compra
    Console.WriteLine("Informar Valor de Compra:");
    val_pag = float.Parse(Console.ReadLine());

    //invocação do método de pagar imposto passando o valor da compra como argumento 
    pf.Pagar_Imposto(val_pag);

    //impressão dos valores no console
    Console.WriteLine("-------- Pessoa Física ---------");
    Console.WriteLine("Nome ..........: " + pf.nome);
    Console.WriteLine("Endereço ......: " + pf.endereco);
    Console.WriteLine("CPF ...........: " + pf.cpf);
    Console.WriteLine("RG ............: " + pf.rg);
    Console.WriteLine("Valor de Compra: " +
    pf.valor.ToString("C"));
    Console.WriteLine("Imposto .......: " +
    pf.valor_imposto.ToString("C"));
    Console.WriteLine("Total a Pagar : " +
    pf.total.ToString("C"));
}
//SE tipo de cliente for Pessoa Jurídica
if (var_tipo == "j")
{
    // Pessoa Jurídica

    Pessoa_Juridica pj = new Pessoa_Juridica();

    pj.nome = var_nome;

    pj.endereco = var_endereco;

    Console.WriteLine("Informar CNPJ:");
    pj.cnpj = Console.ReadLine();

    Console.WriteLine("Informar IE:");
    pj.ie = Console.ReadLine();

    Console.WriteLine("Informar Valor de Compra:");
    val_pag = float.Parse(Console.ReadLine());

    pj.Pagar_Imposto(val_pag);

    Console.WriteLine("-------- Pessoa Jurídica ---------");
    Console.WriteLine("Nome ..........: " + pj.nome);
    Console.WriteLine("Endereço ......: " + pj.endereco);
    Console.WriteLine("CNPJ ..........: " + pj.cnpj);
    Console.WriteLine("IE ............: " + pj.ie);
    Console.WriteLine("Valor de Compra: " +
    pj.valor.ToString("C"));
    Console.WriteLine("Imposto .......: " +
    pj.valor_imposto.ToString("C"));
    Console.WriteLine("Total a Pagar : " +
    pj.total.ToString("C"));
}