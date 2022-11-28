namespace Lab10
{
    public class Carbon : Reagent
    {
        private string _form;
        public Carbon(){}
        public Carbon(string form)
        {
            this._form = form;
        }
        public override string ToString()
        {
            return $"Информация об углероде:\nФорма кристаллической решётки - {this._form}";
        }
    }
}