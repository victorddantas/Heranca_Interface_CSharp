using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao Bytebank administração");

// CalcularBonificação();
UsarSistema();

void CalcularBonificação()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    Designer designer = new Designer("99999999999");
    designer.Nome = "Designer";

    Diretor diretor = new Diretor("99999999999");
    diretor.Nome = "Diretor";

    Auxiliar auxiliar = new Auxiliar("99999999999");
    auxiliar.Nome = "Auxiliar";

    GerenteDeContas gerenteDeContas = new GerenteDeContas("99999999999");
    gerenteDeContas.Nome = "Gerente de Contas";

    Desenvolvedor desenvolvedor = new Desenvolvedor("99999999999");
    desenvolvedor.Nome = "Desenvolvedor";

    gerenciador.Registrar(designer);
    gerenciador.Registrar(diretor);
    gerenciador.Registrar(auxiliar);
    gerenciador.Registrar(gerenteDeContas);
    gerenciador.Registrar(desenvolvedor);

    Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor diretor = new Diretor("99999999999");
    diretor.Nome = "Diretor";
    diretor.Senha = "abc";


    GerenteDeContas gerenteDeContas = new GerenteDeContas("99999999999");
    gerenteDeContas.Nome = "Gerente De Contas";
    gerenteDeContas.Senha = "abc";


    ParceiroComercial parceiroComercial = new ParceiroComercial();
    parceiroComercial.Senha = "abc";

    sistemaInterno.Logar(diretor, "abc");
    sistemaInterno.Logar(gerenteDeContas, "123");
    sistemaInterno.Logar(parceiroComercial, "abc");
}

Console.ReadKey();
























