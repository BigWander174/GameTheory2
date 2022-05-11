namespace GameTheory2.Model.Criteries
{
    internal class Savidge : Criterion
    {
        public Savidge(Matrix matrix, string name) : base(matrix, name)
        {
        }

        public override int GetIndex()
        {
            var array = Data.Risk.Select(element => element.Max()).ToList();

            return array.IndexOf(array.Min());
        }
    }
}
