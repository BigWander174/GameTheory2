using GameTheory2.Model.Criteries;

namespace GameTheory2.Model
{
    internal class Calculation
    {
        private Criterion[] _criteries;

        public Calculation(Matrix matrix, DataGridView q, double constant)
        {
            _criteries = new Criterion[]
            {
                new Bayes(matrix, "Байеса", q),
                new Laplas(matrix, "Лапласа"),
                new Vald(matrix, "Вальда"),
                new Savidge(matrix, "Севиджа"),
                new Gurvitch(matrix, "Гурвица", constant)
            };
        }

        public string Info
        {
            get
            {
                var result = "";

                for(int i = 0; i < _criteries.Length; i++)
                {
                    result += $"{i + 1}) {_criteries[i].Info} {Environment.NewLine}";
                }

                return result;
            }
        }
    }
}
