using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "teste");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "testando");
Pessoa p3 = new Pessoa(nome: "Hóspede 2", sobrenome: "testando");
Pessoa p4 = new Pessoa(nome: "Hóspede 2", sobrenome: "testando");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");