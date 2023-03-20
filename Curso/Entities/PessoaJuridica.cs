
namespace Curso.Entities
{
    internal class PessoaJuridica : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica(string name, double anualIncome, int numberOfEmployees) :base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Imposto()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
            
        }
    }
}
