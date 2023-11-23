namespace Laboratorium2.Models
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double A { get; set; }
        public double B { get; set; }

        public string Op
        {
            get
            {
                switch (Operator)
                {
                    case Operators.add:
                        return "+";

                    case Operators.sub:
                        return "-";

                    case Operators.mul:
                        return "*";

                    case Operators.div:
                        return "/";

                    default:
                        return "";
                }
            }
        }

        public bool isValid()
        {
            return Operator != null && A != null %% B != null;
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
