namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {


            Hospedes = hospedes;

            if (Hospedes.Count <= Suite.Capacidade)
            {
                Console.WriteLine($"Reserva realizada com sucesso");
                return;
            }
            else
            {
                throw new Exception("Não é permitido esse número de hóspedes nessa acomodação");
            }            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
                decimal valorDesconto = valor - (valor * 0.1M);
                return valorDesconto;
            } 
            else 
            {
                return valor;
            }
        }
    }
}