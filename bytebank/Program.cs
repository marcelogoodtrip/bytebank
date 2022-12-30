using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Titular;
using bytebank.Utilitario;
using System.Runtime.CompilerServices;

//ContaCorrente contaMarcelo = new ContaCorrente();
//contaMarcelo.titular = "Marcelo Moura";
//contaMarcelo.numero_agencia = 150;
//contaMarcelo.conta = "1010-X";
//contaMarcelo.DefinirSaldo(100);
//contaMarcelo.ExibirDadosDaConta();

//ContaCorrente contaLaryssa = new ContaCorrente();
//contaLaryssa.titular = "Laryssa Moura";
//contaLaryssa.numero_agencia = 150;
//contaLaryssa.conta = "1011-X";
//contaLaryssa.DefinirSaldo(100);

//Console.WriteLine();
//contaMarcelo.Depositar(100);
//Console.WriteLine("Saldo em conta: " + contaMarcelo.saldo);

//Console.WriteLine();
//contaMarcelo.Sacar(300);
//Console.WriteLine("Saldo em conta: " + contaMarcelo.saldo);

//Console.WriteLine();
//contaMarcelo.Transferir(50, contaLaryssa);
//Console.WriteLine("Saldo em conta: " + contaMarcelo.saldo);

//Console.WriteLine();
//contaLaryssa.ExibirDadosDaConta();

//Cliente cliente = new Cliente();
//cliente.Nome = "Marcelo Moura";
//cliente.Cpf = "123.456.789-00";
//cliente.Profissao = "Programador Jr.";

//ContaCorrente conta = new ContaCorrente(1, "1010-X");
//conta.Titular = cliente;
//conta.SetSaldo(300);
//conta.ExibirDadosDaConta();

//Console.WriteLine();
//Console.WriteLine("Total de Contas Cadastradas: " + ContaCorrente.ContasCriadas);
//Console.WriteLine();
//Console.WriteLine("Total de Clientes Cadastrados: " + Cliente.ClientesCriados);
//Console.WriteLine();

//ContaCorrente conta2 = new ContaCorrente(1, "1011-X");
//conta2.Titular = new Cliente();
//conta2.Titular.Nome = "Laryssa Moura";
//conta2.Titular.Cpf = "987.654.321-00";
//conta2.SetSaldo(500);
//conta2.ExibirDadosDaConta();

////Console.WriteLine("Saldo: " + conta2.GetSaldo());

//Console.WriteLine();
//Console.WriteLine("Total de Contas Cadastradas: " + ContaCorrente.ContasCriadas);
//Console.WriteLine();
//Console.WriteLine("Total de Clientes Cadastrados: " + Cliente.ClientesCriados);

//Funcionario func1 = new Funcionario("123.456.789-00", 1200);
//func1.Nome = "Laryssa Moura";

//Console.WriteLine(func1.Nome);
//Console.WriteLine(func1.Cpf);
//Console.WriteLine(func1.GetBonificacao());
//Console.WriteLine();

//Diretor dir1 = new Diretor("987.654.321-00", 5000);
//dir1.Nome = "Marcelo Moura";

//Console.WriteLine(dir1.Nome);
//Console.WriteLine(dir1.Cpf);
//Console.WriteLine(dir1.GetBonificacao());
//Console.WriteLine();

//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//gerenciador.Registrar(func1);
//gerenciador.Registrar(dir1);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacao);
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

//func1.AumentarSalario();
//dir1.AumentarSalario();

//Console.WriteLine();
//Console.WriteLine("Novo Salário do Funcionário: " + func1.Salario);
//Console.WriteLine("Novo Salário do Diretor: " + dir1.Salario);

Diretor diretor = new Diretor("000.000.000-00");
diretor.Nome = "Marcelo Diretor";
Console.WriteLine(diretor.Nome);
Console.WriteLine(diretor.Cpf);
Console.WriteLine(diretor.Salario);
Console.WriteLine("Bonificação: "+diretor.GetBonificacao());
diretor.AumentarSalario();
Console.WriteLine("Aumento Salarial: "+diretor.Salario);
Console.WriteLine();

Designer designer = new Designer("111.111.111-11");
designer.Nome = "Marcelo Designer";
Console.WriteLine(designer.Nome);
Console.WriteLine(designer.Cpf);
Console.WriteLine(designer.Salario);
Console.WriteLine("Bonificação: " + designer.GetBonificacao());
designer.AumentarSalario();
Console.WriteLine("Aumento Salarial: " + designer.Salario);
Console.WriteLine();

GerenteDeContas gerente = new GerenteDeContas("222.222.222-22");
gerente.Nome = "Marcelo Gerente";
Console.WriteLine(gerente.Nome);
Console.WriteLine(gerente.Cpf);
Console.WriteLine(gerente.Salario);
Console.WriteLine("Bonificação: " + gerente.GetBonificacao());
gerente.AumentarSalario();
Console.WriteLine("Aumento Salarial: " + gerente.Salario);
Console.WriteLine();

Auxiliar auxiliar = new Auxiliar("333.333.333-33");
auxiliar.Nome = "Marcelo Auxiliar";
Console.WriteLine(auxiliar.Nome);
Console.WriteLine(auxiliar.Cpf);
Console.WriteLine(auxiliar.Salario);
Console.WriteLine("Bonificação: " + auxiliar.GetBonificacao());
auxiliar.AumentarSalario();
Console.WriteLine("Aumento Salarial: " + auxiliar.Salario);
Console.WriteLine();

//Console.ReadKey();