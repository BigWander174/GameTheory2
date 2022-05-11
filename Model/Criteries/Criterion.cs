namespace GameTheory2.Model.Criteries
{
    internal abstract class Criterion
    {
        private string _name;
        
        protected Matrix Data;

        public Criterion(Matrix matrix, string name)
        {
            Data = matrix;
            _name = name;
        }

        public string Info => $"Метод {_name}: A{GetIndex() + 1}";
        
        abstract public int GetIndex();
    }
}
