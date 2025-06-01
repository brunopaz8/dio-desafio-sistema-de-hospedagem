namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes()
        {
            if (Suite == null)
            {
                throw new Exception("Suite não cadastrada. Cadastre uma suite antes de adicionar hóspedes.");
            }

            Console.Clear();
            Console.WriteLine(@"
======= Cadastrando Hóspedes =======
Informe quantas pessoas são:
====================================
Quantas: ");

            string quantidadeHospedes = Console.ReadLine();
            int.TryParse(quantidadeHospedes, out int quantidadeHospedesInt);

            if (quantidadeHospedesInt <= Suite.Capacidade)
            {
                Console.Clear();
                for (int i = 0; i < quantidadeHospedesInt; i++)
                {
                    Console.WriteLine(@$"
====== Adicionando Hóspedes ======
Diga o nome do hóspede número {i + 1}
==================================
Nome: ");
                    string nome = Console.ReadLine();
                    Pessoa p = new Pessoa(nome);
                    Hospedes.Add(p);

                    Console.Clear();
                    Console.WriteLine(@$"
======= Hóspede Adicionado =======
O hóspede {nome} foi adicionado!
==================================");
                }

                Console.WriteLine(@$"
==== Adicionando Hóspedes ====
Por quantos dias ?
==============================
Dias: ");
                string diasStr = Console.ReadLine();
                int.TryParse(diasStr, out int dias);
                DiasReservados = dias;

                Console.Clear();
                Console.WriteLine(@$"
==== Adicionando Hóspedes ====
Reserva feita com sucesso!
==============================");

            }
            else
            {
                throw new Exception("Capacidade da suíte incompatível com a quantidade de hóspedes.");
            }
        }

        public void CadastrarSuite()
        {
            Console.Clear();
            Console.WriteLine(@"
====== Cadastrando Suíte ======
Informe qual o tipo da suíte
===============================
Tipo: ");
            string tipo = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(@"
====== Cadastrando Suíte ======
Informe a capacidade da suíte
===============================
Capacidade: ");
            string capacidadeSuite = Console.ReadLine();
            int.TryParse(capacidadeSuite, out int capacidadeSuiteInt);

            Console.Clear();
            Console.WriteLine(@"
====== Cadastrando Suíte ======
Informe o valor da suíte
===============================
Valor: ");
            string valor = Console.ReadLine();
            decimal.TryParse(valor, out decimal valorDecimal);

            Suite = new Suite(tipo, capacidadeSuiteInt, valorDecimal);

            Console.Clear();
            Console.WriteLine(@"
====== Suíte Cadastrada ======
Suíte cadastrada com sucesso!
===============================");
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
            {
                throw new Exception("Suite não cadastrada.");
            }

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.9M;
            }

            return valor;
        }

        public void Resumo()
        {
            if (Suite == null || Hospedes.Count() == 0)
            {
                throw new Exception("Cadastre o hóspede e a suite primeiro!");
            }
            decimal valor = CalcularValorDiaria();
            string nomesHospedes = string.Join(", ", Hospedes.Select(h => h.Nome));
            Console.WriteLine(@$"
======= Resumo =======
Os hóspedes: {nomesHospedes}
ficaram na suíte do tipo: {Suite.TipoSuite}
durante {DiasReservados} dias
pagando o valor total: {valor:C2}
======================");
        }
    }
    
}
