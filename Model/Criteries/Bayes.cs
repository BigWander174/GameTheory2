namespace GameTheory2.Model.Criteries
{
    internal class Bayes : Criterion
    {
        private double[] _q;

        public Bayes(Matrix matrix, string name, DataGridView q) : base(matrix, name)
        {
            _q = new double[q.Columns.Count];
            for (int i = 0; i < _q.Length; i++)
            {
                _q[i] = Convert.ToDouble(q[i, 0].Value);
            }
        }

        public override int GetIndex()
        {
            var multiplies = Data.Capital.Select(x => Multiply(x)).ToList();
            return multiplies.IndexOf(multiplies.Max());
        }

        private double Multiply(int[] x)
        {
            return Enumerable.Range(0, x.Length).Select(i => x[i] * _q[i]).Sum();
        }
    }
}
