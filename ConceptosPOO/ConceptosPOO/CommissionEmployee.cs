namespace ConceptosPOO
{
    public class CommissionEmployee : Employee
    {
        // Creamos una variable para el porcentaje de comisión
        public float CommissionPercentaje { get; set; }

        // Creamos una variable para el monto total de ventas.
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            // Retornamos el valor de la comisión
            return Sales * CommissionEmployee;
        }
    }
}
