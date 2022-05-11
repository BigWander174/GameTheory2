namespace GameTheory2.Model.Criteries
{
    internal class Gurvitch : Criterion
    {
        private double _constant;
       
        public Gurvitch(Matrix matrix, string name, double constant) : base(matrix, name)
        {
            _constant = constant;
        }

        public override int GetIndex()
        {
            var minArray = Data.Capital.Select(element => element.Min()).ToList();
            var maxArray = Data.Capital.Select(element => element.Max()).ToList();

            var result = Enumerable.Range(0, minArray.Count).Select(x => minArray[x] * _constant + maxArray[x] * (1 - _constant)).ToList();

            return result.IndexOf(result.Max());
        }
    }
}
