namespace GameTheory2.Model.Criteries
{
    internal class Laplas : Criterion
    {
        public Laplas(Matrix matrix, string name) : base(matrix, name)
        {
        }

        public override int GetIndex()
        {
            var array = Data.Capital.Select(element => element.Sum()).ToList();
            return array.IndexOf(array.Max());
        }
    }
}
