namespace exercicio.Entities
{
    class IndividualTaxPayer : TaxPayer
    {
        public double Health { get; set; }

        public IndividualTaxPayer(string name, double income, double health)
            :base(name, income)
        {
            Health = health;
        }

        public override double TaxesPaid()
        {
            if(Income < 20000.00)
            {
                return Income * (15 / 100);
            }
            else
            {
                return (Income / 4) - (Health / 2);
            }
        }
    }
}
