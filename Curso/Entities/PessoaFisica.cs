
namespace Curso.Entities
{
    internal class PessoaFisica : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public PessoaFisica(string name, double anualIncome, double healthExpenditures) :base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Imposto()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
