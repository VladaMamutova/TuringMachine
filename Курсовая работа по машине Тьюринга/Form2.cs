using System;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Курсовая_работа_по_машине_Тьюринга
{
    public partial class Form2 : Form
    {
        public Form2(char[][] arrBefore, string[][] arrAfter, char[] arrAlphabet)
        {
            InitializeComponent();
            before = arrBefore;
            after = arrAfter;
            alphabet = arrAlphabet;
            x = 0;
            Graph.Series[0].Points.AddXY(0, 0);
        }

        char[] alphabet;
        char[][] before;
        string[][] after;
        int x;
        DateTime startTime;

        private int TuringMachine(string word)
        {
            string sourceWord = "_" + word + "_";
            string resultWord = "__";
            int currState = 0; // Текушее состояние.
            int index1 = 1; // Индекс символа, рассматриваемого на первой ленте.
            int index2 = 1; // Индекс символа, рассматриваемого на второй ленте.
            int i; // Переменная для прохода по массиву заменяемых симловов.
            int tactNumber = 0;
            while (currState != -1)
            {
                if (backgroundWorker.CancellationPending == true) // Нажата кнопка "Стоп".
                    return -1;

                i = 0;
                // Ищем неходимую комбинацию символов на двух лентвх.
                while (i < 13 && (sourceWord[index1] != before[0][i] || resultWord[index2] != before[1][i]))
                    i++;

                if (i == 13 || after[currState][i] == "-")
                {
                    MessageBox.Show("В алгоритме присутствует ошибка!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    if (sourceWord[index1] == before[0][i] && resultWord[index2] == before[1][i])
                    {
                        // Если заменяемые символы на лентах отличаются от исходных,
                        // производим замену.
                        if (before[0][i] != after[currState][i][1])
                        {
                            sourceWord = sourceWord.Remove(index1, 1);
                            sourceWord = sourceWord.Insert(index1, after[currState][i][1].ToString());
                        }

                        if (before[1][i] != after[currState][i][2])
                        {
                            resultWord = resultWord.Remove(index2, 1);
                            resultWord = resultWord.Insert(index2, after[currState][i][2].ToString()) + "_";
                        }

                        // Смещаем управляющее устройство (индексы просматриваемых символов слова на каждой ленте).
                        switch (after[currState][i][3])
                        {
                            case 'R': index1++; break;
                            case 'L': index1--; break;
                        }
                        switch (after[currState][i][4])
                        {
                            case 'R': index2++; break;
                            case 'L': index2--; break;
                        }

                        // Изменяем состояние машины Тьюринга.
                        if (after[currState][i][0] != 'z')
                            currState = Convert.ToInt32(after[currState][i][0].ToString());
                        else currState = -1;
                    }
                }
                tactNumber++; // Увеличиваем значение количества тактов.
            }

            return tactNumber;
        }

        private int WordGeneration(int wordLength)
        {
            uint letterCount = (uint)alphabet.Length; // Количество символов в алфавите.
            StringBuilder str = new StringBuilder(new string(alphabet[0], wordLength)); // Сгенерированное слово.
            ulong n = 1, temp; // Порядковый номер текущего слова и переменная для генерации слова.
            ulong strCount = (ulong)Math.Pow(letterCount, wordLength); // Всего слов перебора.
            int maxTacts = 0; // Максимальное число тактов.
            int tempTact = 0; // Текущее число тактов.
            int progressBarValue = (int)(100 / strCount); // Текущее значение progressBar'a.
            int progressIncrease = progressBarValue > 0 ? progressBarValue : 2; // Шаг progressBar'a.

            while (n <= strCount)
            {
                tempTact = TuringMachine(str.ToString());

                if (tempTact == -1) return -1; // В алгоритме ошибка или нажата кнопка "Стоп".

                if (tempTact > maxTacts)
                    maxTacts = tempTact;

                // Изменяем значение progressBar'a.
                if ((int)(n * 100 / strCount) == progressBarValue)
                {
                    backgroundWorker.ReportProgress(-progressBarValue);
                    progressBarValue += progressIncrease; 
                }

                // Генерируем новое слово методом полного перебора.
                if (n != strCount)
                {
                    temp = n;
                    for (int i = wordLength - 1; i >= 0; i--)
                    {
                        str[i] = alphabet[temp % letterCount];
                        temp /= letterCount;
                    }
                }
                n++;
            }
            return maxTacts;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Stop.Enabled = true;
            Start.Enabled = false;
            Graph.Series[0].Points.Clear(); // Очичаем график.
            startTime = DateTime.Now;
            backgroundWorker.RunWorkerAsync(); // Запускаем второй поток для отрисовки графика и перебора слов.
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int length = (int)WordLength.Value;
            x = 0; // Рисуем график с нуля.
            int y = 0; // Максимальное число тактов (значения по оси Оy).
            
            while (x <= length && y != -1)
            {
                y = WordGeneration(x);
                if (y != -1) // y = -1, если в алгоритме ошибка или нажата кнопка "Стоп".
                {
                    if(x > 4) Thread.Sleep(450); // Подождать, чтоб отрисовался progressBar.
                    backgroundWorker.ReportProgress(y); // Добавляем значение на график.

                    // Подождать, чтоб точка на график добавилась перед тем, как изменится значение x.
                    if (x < 4) Thread.Sleep(700);
                    else Thread.Sleep(500);
                    x++;
                }
            }
                   
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync(); // Отменяем отрисовку графика и перебор слов.
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Положительное значение e.ProgressPercentage - координата y для добаления точки на график,
            // отрицательное (показывает, что изменился прогресс генерации слов) - процент progressBar'a.
            if (e.ProgressPercentage > 0)
            {
                if (x < 4) progressBar.Value = 100;
                Graph.Series[0].Points.AddXY(x, e.ProgressPercentage);
            }
            else progressBar.Value = -e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Stop.Enabled = false;
            Start.Enabled = true;
            progressBar.Value = 100;
            TimeSpan resultTime = DateTime.Now - startTime;
            MessageBox.Show("График отрисовался! Перебор слов на " + (x - 1) + " символов закончен.\n" +
                "Затраченное время: " +
                Convert.ToInt32(resultTime.TotalHours).ToString() + " ч " +
                resultTime.Minutes.ToString() + " м " +
                resultTime.Seconds.ToString() + " c " +
                resultTime.Milliseconds.ToString() + " мс");
            progressBar.Value = 0;
        }
    }
}
