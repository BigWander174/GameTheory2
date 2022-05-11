namespace GameTheory2.Model
{
    internal class Matrix
    {
        private int[][] _capital;
        private int[][] _risk;

        public int[][] Risk => _risk;
        public int[][] Capital => _capital;

        public void Work(DataGridView mainView)
        {
            Set(mainView);
            CalculateRisk();
        }

        private void Set(DataGridView mainView)
        {
            CreateMatrix(mainView, ref _capital);
            FillMatrix(mainView, ref _capital);
            CreateMatrix(mainView, ref _risk);
        }

        private void CreateMatrix(DataGridView mainView, ref int[][] matrix)
        {
            matrix = new int[mainView.Rows.Count][];
            for (int i = 0; i < _capital.Length; i++)
            {
                matrix[i] = new int[mainView.Columns.Count];
            }
        }

        private void FillMatrix(DataGridView mainView, ref int[][] goodMatrix)
        {
            for (int i = 0; i < _capital.Length; i++)
            {
                for (int j = 0; j < _capital[i].Length; j++)
                {
                    _capital[i][j] = Convert.ToInt32(mainView[j, i].Value);
                }
            }
        }

        private int[][] Transpone(int[][] target)
        {
            CreateCopy(target, out int[][] copy);

            var transponed = new int[target[0].Length][];
            for (int i = 0; i < transponed.Length; i++)
            {
                transponed[i] = new int[target.Length];
                for (int j = 0; j < transponed[i].Length; j++)
                {
                    transponed[i][j] = target[j][i];
                }
            }

            return transponed;
        }

        private void CreateCopy(int[][] target, out int[][] copy)
        {
            copy = new int[target.Length][];

            for (int i = 0; i < target.Length; i++)
            {
                copy[i] = new int[target[i].Length];

                for (int j = 0; j < target[i].Length; j++)
                {
                    copy[i][j] = target[i][j];
                }
            }
        }

        private void CalculateRisk()
        {
            var transponed = Transpone(_capital);
            int[] maximums = Enumerable.Range(0, _capital.Length).Select(x => transponed[x].Max()).ToArray();

            for (int i = 0; i < _capital.Length; i++)
            {
                for (int j = 0; j < _capital[i].Length; j++)
                {
                    _risk[i][j] = maximums[j] - _capital[i][j];
                }
            }
        }
    }
}
