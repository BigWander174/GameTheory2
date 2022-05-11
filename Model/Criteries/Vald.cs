namespace GameTheory2.Model.Criteries
{
    internal class Vald : Criterion
    {
        public Vald(Matrix matrix, string name) : base(matrix, name)
        {
        }

        public override int GetIndex()
        {
            var array = Data.Capital.Select(element => element.Min()).ToList();

            return array.IndexOf(array.Max());
        }
    }
}
