namespace Laboratorium2.Models
{
    public class Calculator
    {
        public double A { get; set; }
        public double B { get; set; }

        public string Operators { get; set; }    

        public bool isValid ()
        {
            return A != null && B != null && Operator != null;  
        }

        public double Calculate()
        {
            switch (Operator)
            {
                case Operators.Add:
                    return (double)(A + B);
                case Operators.Sub:
                    return (double)(A - B);
                case Operators.Mul: 
                    return (double)(A * B);
                case Operators.Div:
                    return (double)(A / B);
            }

            
        }
    }
}
