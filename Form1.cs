using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritimos
{
    public partial class ANALISEALG : Form
    {

        /*------------------------------------------------------*/
        /*              OUTROS ELEMENTOS DA PAGINA              */
        /*------------------------------------------------------*/
        public ANALISEALG()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Position", "Posição");
            dataGridView1.Columns.Add("Value", "Valor");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void InserctionButton_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void results_Click(object sender, EventArgs e)
        {
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/



        /*------------------------------------------------------*/
        /*                     BUBBLE SORT                      */
        /*------------------------------------------------------*/
        private async void BubbleButton_Click(object sender, EventArgs e)
        {
            int numElements = 0;
            if (milElementos.Checked)
            {
                numElements = 1000;
            }
            else if (DezmilElementos.Checked)
            {
                numElements = 10000;
            }
            else if (CemmilElementos.Checked)
            {
                numElements = 100000;
            }

            if (numElements == 0)
            {
                MessageBox.Show("Por favor, selecione o número de elementos.");
                return;
            }

            Random rand = new Random();
            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                array[i] = rand.Next(1, 1000);
            }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = array.Length - 1;
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();
            Stopwatch stopwatch = Stopwatch.StartNew();

            int numTrocas = 0; // Contador de trocas
            int numComparacoes = 0; // Contador de comparações

            await Task.Run(() =>
            {
                BubbleSort(array, progressBar1, ref numTrocas, ref numComparacoes);
            });

            stopwatch.Stop();
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add($"Posição {i + 1}", array[i]);
            }

            results.Text = $"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms\n" +
                           $"Trocas: {numTrocas}\n" +
                           $"Comparações: {numComparacoes}";

            progressBar1.Value = 0;
        }

        private void BubbleSort(int[] array, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    numComparacoes++; // Incrementa a contagem de comparações
                    if (array[j] > array[j + 1])
                    {
                        numTrocas++; // Incrementa a contagem de trocas
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = i + 1));
                Task.Delay(200).Wait();
            }
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/



        /*------------------------------------------------------*/
        /*                IMPROVED BUBBLE SORT                  */
        /*------------------------------------------------------*/
        private async void ImprovedBubbleButton_Click(object sender, EventArgs e)
        {
            int numElements = 0;
            if (milElementos.Checked)
            {
                numElements = 1000;
            }
            else if (DezmilElementos.Checked)
            {
                numElements = 10000;
            }
            else if (CemmilElementos.Checked)
            {
                numElements = 100000;
            }

            if (numElements == 0)
            {
                MessageBox.Show("Por favor, selecione o número de elementos.");
                return;
            }
            Random rand = new Random();
            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                array[i] = rand.Next(1, 1000);
            }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = array.Length - 1;
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();
            Stopwatch stopwatch = Stopwatch.StartNew();

            int numTrocas = 0; // Contador de trocas
            int numComparacoes = 0; // Contador de comparações

            await Task.Run(() =>
            {
                ImprovedBubbleSort(array, progressBar1, ref numTrocas, ref numComparacoes);
            });
            stopwatch.Stop();

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add($"Posição {i + 1}", array[i]);
            }

            results.Text = $"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms\n" +
                           $"Trocas: {numTrocas}\n" +
                           $"Comparações: {numComparacoes}";

            progressBar1.Value = 0;
        }

        private void ImprovedBubbleSort(int[] array, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            bool swapped;
            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    numComparacoes++; // Cada comparação
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                        numTrocas++; // Cada troca
                    }
                }
                if (!swapped)
                {
                    break;
                }
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = i + 1));
                Task.Delay(200).Wait();
            }
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/



        /*------------------------------------------------------*/
        /*                   INSERCTION SORT                    */
        /*------------------------------------------------------*/
        private async void InsertionButton_Click(object sender, EventArgs e)
        {
            int numElements = 0;
            if (milElementos.Checked)
            {
                numElements = 1000;
            }
            else if (DezmilElementos.Checked)
            {
                numElements = 10000;
            }
            else if (CemmilElementos.Checked)
            {
                numElements = 100000;
            }

            if (numElements == 0)
            {
                MessageBox.Show("Por favor, selecione o número de elementos.");
                return;
            }

            Random rand = new Random();
            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = array.Length - 1;
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();

            int numTrocas = 0; // Contador de trocas
            int numComparacoes = 0; // Contador de comparações

            Stopwatch stopwatch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                InsertionSort(array, progressBar1, ref numTrocas, ref numComparacoes);
            });
            stopwatch.Stop();

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add($"Posição {i + 1}", array[i]);
            }

            results.Text = $"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms\n" +
                           $"Trocas: {numTrocas}\n" +
                           $"Comparações: {numComparacoes}";

            progressBar1.Value = 0;
        }

        private void InsertionSort(int[] array, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0)
                {
                    numComparacoes++; // Contabiliza cada comparação

                    if (array[j] > key)
                    {
                        array[j + 1] = array[j];
                        j = j - 1;
                        numTrocas++; // Contabiliza cada troca
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = key;

                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = i));
                Task.Delay(200).Wait();
            }
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/



        /*------------------------------------------------------*/
        /*                   SELECTION SORT                     */
        /*------------------------------------------------------*/
        private async void SelectionSortButton_Click(object sender, EventArgs e)
        {
            int numElements = 0;
            if (milElementos.Checked)
            {
                numElements = 1000;
            }
            else if (DezmilElementos.Checked)
            {
                numElements = 10000;
            }
            else if (CemmilElementos.Checked)
            {
                numElements = 100000;
            }

            if (numElements == 0)
            {
                MessageBox.Show("Por favor, selecione o número de elementos.");
                return;
            }

            Random rand = new Random();
            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = array.Length - 1;
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();

            int numTrocas = 0; // Contador de trocas
            int numComparacoes = 0; // Contador de comparações

            Stopwatch stopwatch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                SelectionSort(array, progressBar1, ref numTrocas, ref numComparacoes);
            });
            stopwatch.Stop();

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add($"Posição {i + 1}", array[i]);
            }

            results.Text = $"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms\n" +
                           $"Trocas: {numTrocas}\n" +
                           $"Comparações: {numComparacoes}";

            progressBar1.Value = 0;
        }

        private void SelectionSort(int[] array, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    numComparacoes++; // Contabiliza cada comparação
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                    numTrocas++; // Contabiliza cada troca
                }
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = i + 1));
                Task.Delay(200).Wait();
            }
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/



        /*------------------------------------------------------*/
        /*                     MERGE SORT                      */
        /*------------------------------------------------------*/
        private async void MergeSortButton_Click(object sender, EventArgs e)
        {
            int numElements = 0;
            if (milElementos.Checked)
            {
                numElements = 1000;
            }
            else if (DezmilElementos.Checked)
            {
                numElements = 10000;
            }
            else if (CemmilElementos.Checked)
            {
                numElements = 100000;
            }

            if (numElements == 0)
            {
                MessageBox.Show("Por favor, selecione o número de elementos.");
                return;
            }

            Random rand = new Random();
            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = array.Length - 1;
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();

            int numTrocas = 0; // Contador de trocas
            int numComparacoes = 0; // Contador de comparações

            Stopwatch stopwatch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                MergeSort(array, 0, array.Length - 1, progressBar1, ref numTrocas, ref numComparacoes);
            });
            stopwatch.Stop();

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add($"Posição {i + 1}", array[i]);
            }

            results.Text = $"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms\n" +
                           $"Trocas: {numTrocas}\n" +
                           $"Comparações: {numComparacoes}";

            progressBar1.Value = 0;
        }

        private void MergeSort(int[] array, int left, int right, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle, progressBar, ref numTrocas, ref numComparacoes);
                MergeSort(array, middle + 1, right, progressBar, ref numTrocas, ref numComparacoes);
                Merge(array, left, middle, right, ref numTrocas, ref numComparacoes);
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = right));
                Task.Delay(200).Wait();
            }
        }

        private void Merge(int[] array, int left, int middle, int right, ref int numTrocas, ref int numComparacoes)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;
            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];
            Array.Copy(array, left, leftArray, 0, leftSize);
            Array.Copy(array, middle + 1, rightArray, 0, rightSize);

            int i = 0, j = 0, k = left;

            while (i < leftSize && j < rightSize)
            {
                numComparacoes++; // Contabiliza cada comparação
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
                numTrocas++; // Contabiliza cada troca
            }

            while (i < leftSize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
                numTrocas++; // Contabiliza cada troca
            }

            while (j < rightSize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
                numTrocas++; // Contabiliza cada troca
            }
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/



        /*------------------------------------------------------*/
        /*                      QUICK SORT                      */
        /*------------------------------------------------------*/
        private async void QuickSortButton_Click(object sender, EventArgs e)
        {
            int numElements = 0;
            if (milElementos.Checked)
            {
                numElements = 1000;
            }
            else if (DezmilElementos.Checked)
            {
                numElements = 10000;
            }
            else if (CemmilElementos.Checked)
            {
                numElements = 100000;
            }
            if (numElements == 0)
            {
                MessageBox.Show("Por favor, selecione o número de elementos.");
                return;
            }

            Random rand = new Random();
            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = array.Length - 1;
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();

            int numTrocas = 0; // Contador de trocas
            int numComparacoes = 0; // Contador de comparações

            Stopwatch stopwatch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                QuickSort(array, 0, array.Length - 1, progressBar1, ref numTrocas, ref numComparacoes);
            });
            stopwatch.Stop();

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add($"Posição {i + 1}", array[i]);
            }

            results.Text = $"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms\n" +
                           $"Trocas: {numTrocas}\n" +
                           $"Comparações: {numComparacoes}";

            progressBar1.Value = 0;
        }

        private void QuickSort(int[] array, int low, int high, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high, ref numTrocas, ref numComparacoes);
                QuickSort(array, low, pivotIndex - 1, progressBar, ref numTrocas, ref numComparacoes);
                QuickSort(array, pivotIndex + 1, high, progressBar, ref numTrocas, ref numComparacoes);
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = high));
                Task.Delay(200).Wait();
            }
        }

        private int Partition(int[] array, int low, int high, ref int numTrocas, ref int numComparacoes)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                numComparacoes++; // Contabiliza cada comparação
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j, ref numTrocas); // Contabiliza cada troca
                }
            }
            Swap(array, i + 1, high, ref numTrocas); // Contabiliza a troca final
            return i + 1;
        }

        private void Swap(int[] array, int i, int j, ref int numTrocas)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            numTrocas++; // Contabiliza a troca
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/




        /*------------------------------------------------------*/
        /*                       HEAP SORT                      */
        /*------------------------------------------------------*/
        private async void HeapSortButton_Click(object sender, EventArgs e)
        {
            int numElements = 0;
            if (milElementos.Checked)
            {
                numElements = 1000;
            }
            else if (DezmilElementos.Checked)
            {
                numElements = 10000;
            }
            else if (CemmilElementos.Checked)
            {
                numElements = 100000;
            }

            if (numElements == 0)
            {
                MessageBox.Show("Por favor, selecione o número de elementos.");
                return;
            }

            Random rand = new Random();
            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = array.Length - 1;
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();

            int numTrocas = 0; // Contador de trocas
            int numComparacoes = 0; // Contador de comparações

            Stopwatch stopwatch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                HeapSort(array, progressBar1, ref numTrocas, ref numComparacoes);
            });
            stopwatch.Stop();

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add($"Posição {i + 1}", array[i]);
            }

            results.Text = $"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms\n" +
                           $"Trocas: {numTrocas}\n" +
                           $"Comparações: {numComparacoes}";

            progressBar1.Value = 0;
        }

        private void HeapSort(int[] array, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i, progressBar, ref numTrocas, ref numComparacoes);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                SwapElements(array, 0, i, ref numTrocas);
                Heapify(array, i, 0, progressBar, ref numTrocas, ref numComparacoes);
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = n - i));
                Task.Delay(200).Wait();
            }
        }

        private void Heapify(int[] array, int n, int i, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n)
            {
                numComparacoes++; // Comparação entre o nó e o filho esquerdo
                if (array[left] > array[largest])
                {
                    largest = left;
                }
            }

            if (right < n)
            {
                numComparacoes++; // Comparação entre o nó e o filho direito
                if (array[right] > array[largest])
                {
                    largest = right;
                }
            }

            if (largest != i)
            {
                SwapElements(array, i, largest, ref numTrocas);
                Heapify(array, n, largest, progressBar, ref numTrocas, ref numComparacoes);
            }
        }

        private void SwapElements(int[] array, int i, int j, ref int numTrocas)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            numTrocas++; // Contabiliza cada troca
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/




        /*------------------------------------------------------*/
        /*                      RADIX SORT                      */
        /*------------------------------------------------------*/
        private async void RadixSortButton_Click(object sender, EventArgs e)
        {
            int numElements = 0;
            if (milElementos.Checked)
            {
                numElements = 1000;
            }
            else if (DezmilElementos.Checked)
            {
                numElements = 10000;
            }
            else if (CemmilElementos.Checked)
            {
                numElements = 100000;
            }

            if (numElements == 0)
            {
                MessageBox.Show("Por favor, selecione o número de elementos.");
                return;
            }

            Random rand = new Random();
            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = array.Length - 1;
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();

            Stopwatch stopwatch = Stopwatch.StartNew();

            int numTrocas = 0; // Não é utilizado diretamente no Radix, mas deixamos para manter a estrutura
            int numComparacoes = 0; // Contador de comparações

            await Task.Run(() =>
            {
                RadixSort(array, progressBar1, ref numTrocas, ref numComparacoes);
            });

            stopwatch.Stop();

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add($"Posição {i + 1}", array[i]);
            }

            results.Text = $"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms\n" +
                           $"Trocas: {numTrocas}\n" +
                           $"Comparações: {numComparacoes}";

            progressBar1.Value = 0;
        }

        private void RadixSort(int[] array, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            int max = array.Max();
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(array, exp, progressBar, ref numTrocas, ref numComparacoes);
            }
        }

        private void CountSort(int[] array, int exp, ProgressBar progressBar, ref int numTrocas, ref int numComparacoes)
        {
            int n = array.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            // Contagem dos dígitos
            for (int i = 0; i < n; i++)
            {
                int index = (array[i] / exp) % 10;
                count[index]++;
            }

            // Atualização da contagem acumulada
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Preenchimento do array de saída com os elementos ordenados
            for (int i = n - 1; i >= 0; i--)
            {
                int index = (array[i] / exp) % 10;
                output[count[index] - 1] = array[i];
                count[index]--;
                numComparacoes++; // Comparação realizada ao acessar o índice no array
            }

            // Copiar os elementos ordenados para o array original
            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }

            progressBar.Invoke((MethodInvoker)(() => progressBar.Value = exp));
            Task.Delay(200).Wait();
        }
        /*------------------------------------------------------*/
        /*                      FIM BLOCO                       */
        /*------------------------------------------------------*/

    }
}
