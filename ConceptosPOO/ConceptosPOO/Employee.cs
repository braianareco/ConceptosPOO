namespace ConceptosPOO
{
    public abstract class Employee
    {
        // Definición de propiedades
        public int Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        /*
         * Aquí definimos el método abstracto, el cuál será heredado
         * e implementado desde otras clases.
         */
        public abstract decimal GetValueToPay();


        // Sobreescritura del metodo ToString para mostrar datos por consola.
        public override string ToString()
        {
            return $"{Id} - {FirstName} - {LastName}, " +
                $"Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is active: {IsActive}";
        }
    }
}
