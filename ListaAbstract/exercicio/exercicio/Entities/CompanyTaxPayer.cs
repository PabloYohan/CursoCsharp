namespace exercicio.Entities
{
    class CompanyTaxPayer : TaxPayer
    {
        public int Employees { get; set; }

        public CompanyTaxPayer(string name, double income, int employees)
            : base(name, income)
        {
            Employees = employees;
        }

        public override double TaxesPaid()
        {
            if(Employees > 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}
