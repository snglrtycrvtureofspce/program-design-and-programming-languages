namespace Lab10
{
    public class Iron : Reagent
    {
        private double _frequency;
        public Iron(){}
        public Iron(double frequency)
        {
            this._frequency = frequency;
        }
        public override string ToString()
        {
            return $"Информация о железе:\nЧастота выработки руды для железа - {this._frequency}";
        }
    }
}