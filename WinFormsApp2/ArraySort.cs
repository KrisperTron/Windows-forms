using System;

namespace WinFormsApp2
{
    public class ArraySort
    {
        private int[] _array;
        private int _size;
        
        public ArraySort(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Размер массива должен быть положительным числом");
            
            _size = size;
            _array = new int[size];
            InitializeWithZeros();
        }
        
        
        /// <summary>
        /// Инициализация массива нулями
        /// </summary>
        private void InitializeWithZeros()
        {
            for (int i = 0; i < _size; i++)
            {
                _array[i] = 0;
            }
        }
        
        
        public void UpdateFromDataGridView(DataGridView dataGridView)
        {
            if (dataGridView == null)
                throw new ArgumentNullException(nameof(dataGridView));
            
            for (int i = 0; i < _size; i++)
            {
                if (dataGridView.Rows[i].Cells[1].Value != null &&
                    int.TryParse(dataGridView.Rows[i].Cells[1].Value.ToString(), out int value))
                {
                    _array[i] = value;
                }
                else
                {
                    throw new FormatException($"Неверный формат данных в строке {i + 1}");
                }
            }
        }

        /// <summary>
        /// Вернуть текущий массив (копию)
        /// </summary>
        public int[] GetArray() => (int[])_array.Clone();

        /// <summary>
        /// Инициализация массива случайными числами
        /// </summary>
        public void InitializeRandom(int minValue = 0, int maxValue = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < _size; i++)
                _array[i] = rnd.Next(minValue, maxValue + 1);
        }
        
        public void InitializeRandomPublic() => InitializeRandom();

        /// <summary>
        /// Создать копию массива
        /// </summary>
        public int[] CloneArray() => (int[])_array.Clone();

        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        public int[] BubbleSort(bool ascending = true)
        {
            int[] arr = CloneArray();
            
            for (int i = 0; i < _size - 1; i++)
            {
                for (int j = 0; j < _size - i - 1; j++)
                {
                    bool shouldSwap = ascending 
                        ? arr[j] > arr[j + 1]
                        : arr[j] < arr[j + 1];
                    
                    if (shouldSwap)
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Сортировка текущего массива (модифицирует его)
        /// </summary>
        public void SortInPlace(bool ascending = true)
        {
            for (int i = 0; i < _size - 1; i++)
            {
                for (int j = 0; j < _size - i - 1; j++)
                {
                    bool shouldSwap = ascending 
                        ? _array[j] > _array[j + 1]
                        : _array[j] < _array[j + 1];
                    
                    if (shouldSwap)
                    {
                        Swap(_array, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Найти минимальный элемент и его индекс
        /// </summary>
        public (int value, int index) FindMin()
        {
            if (_size == 0)
                throw new InvalidOperationException("Массив пуст");
            
            int minValue = _array[0];
            int minIndex = 0;
            
            for (int i = 1; i < _size; i++)
            {
                if (_array[i] < minValue)
                {
                    minValue = _array[i];
                    minIndex = i;
                }
            }
            
            return (minValue, minIndex);
        }

        /// <summary>
        /// Найти максимальный элемент и его индекс
        /// </summary>
        public (int value, int index) FindMax()
        {
            if (_size == 0)
                throw new InvalidOperationException("Массив пуст");
            
            int maxValue = _array[0];
            int maxIndex = 0;
            
            for (int i = 1; i < _size; i++)
            {
                if (_array[i] > maxValue)
                {
                    maxValue = _array[i];
                    maxIndex = i;
                }
            }
            
            return (maxValue, maxIndex);
        }

        /// <summary>
        /// Вычислить среднее арифметическое
        /// </summary>
        public double CalculateAverage()
        {
            if (_size == 0)
                return 0;
            
            double sum = 0;
            for (int i = 0; i < _size; i++)
            {
                sum += _array[i];
            }
            
            return sum / _size;
        }



        /// <summary>
        /// Преобразовать массив в строку
        /// </summary>
        public override string ToString()
        {
            return string.Join(", ", _array);
        }


        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}