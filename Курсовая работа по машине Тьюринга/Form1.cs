using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа_по_машине_Тьюринга
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitCommandList();
            InitFuncTable();
            form2 = new Form2(before, after, alphabet);
            form2.Name = "Расчёт временной сложности алгоритма";
        }

        char[] alphabet; // Массив символов алфавита.
        char[][] before; // Массив символов для замены (номер строки - номер ленты).

        // Массив команд в виде <qr><a1'><a2'><S1><S2, где
        // qr - номер состояния,
        // a1' и a2' - заменяемыйе символы на 1/2 ленте соответвственно,
        // S1 - символ смещения 1-ой ленты,
        // S2 - символ смещения 2-ой ленты.
        // ** Номер строки массива - порядковый номер состояния.
        string[][] after;

        Form2 form2; // Форма для вывода графика временной сложности.

        private void InitCommandList()
        {
            before = new char[2][];
            after = new string[7][];

            string Line;
            string[] strArr;
            char separator = ' ';
            int lineCount = 0;
            try
            {
                FileStream file = new FileStream(Application.StartupPath + "\\Команды МТ.txt", FileMode.Open);
                StreamReader streamReader = new StreamReader(file, Encoding.UTF8);
                if (streamReader.EndOfStream != true)
                {
                    // Считываем символы алфавита.
                    Line = streamReader.ReadLine();
                    alphabet = new char[Line.Length];
                    alphabet = Line.ToCharArray();

                    // Считываем символы исходной строки для замены.
                    Line = streamReader.ReadLine();
                    strArr = Line.Split(separator);
                    before[0] = new char[strArr.Length];
                    before[1] = new char[strArr.Length];

                    for (int i = 0; i < strArr.Length; i++)
                    {
                        before[0][i] = strArr[i][0]; // Символ первой ленты.
                        before[1][i] = strArr[i][1]; // Символ второй ленты.
                    }
                }
                while (streamReader.EndOfStream != true)
                {
                    // Считываем команды.
                    Line = streamReader.ReadLine();
                    strArr = Line.Split(separator);
                    after[lineCount] = new string[strArr.Length];

                    for (int i = 0; i < strArr.Length; i++)
                            after[lineCount][i] = strArr[i];

                    lineCount++;
                }
                streamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке команд машины Тьюринга из файла\n" + ex.StackTrace + "\n\nПричина: " + ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitFuncTable()
        {
            // Добавление в функциональную таблицу столбцов с подписью заголовков.
            for (int i = 0; i < after[0].Length; i++)
            {
                FuncTable.Columns.Add(i.ToString(), before[0][i].ToString() + before[1][i].ToString());
                FuncTable.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Заполнение функциональной таблицы.
            for (int i = 0; i < after.Length; i++)
            {
                FuncTable.Rows.Add();
                FuncTable.Rows[i].HeaderCell.Value = i.ToString();

                for (int j = 0; j < after[i].Length; j++)
                    FuncTable.Rows[i].Cells[j].Value = (after[i][j] == "-" ? "" : "q") + after[i][j];
            }
        }

        private void SourceWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13)
            {
                int i = 0;
                // Проверяем, принадлежит ли текущий символ алфавиту.
                while (i < alphabet.Length && e.KeyChar != alphabet[i]) i++;

                if (i == alphabet.Length)
                    e.Handled = true;
            }
            else if (e.KeyChar == 13) Solve_Click(sender, e); // По нажатию "Enter" запускаем МТ.
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            string sourceWord = "_" + SourceWord.Text + "_";
            string resultWord = "__";

            int currState = 0; // Текушее состояние.
            int index1 = 1; // Индекс символа, рассматриваемого на первой ленте.
            int index2 = 1; // Индекс символа, рассматриваемого на второй ленте.
            int i = 0; // Переменная для прохода по массиву заменяемых симловов.

            AlgorithmSteps.Rows.Clear();
            AlgorithmSteps.Rows.Add();
            AlgorithmSteps.Rows[0].Cells[0].Value = sourceWord.Substring(0, index1) + "q" + currState + sourceWord.Substring(index1);
            AlgorithmSteps.Rows[0].Cells[1].Value = resultWord.Substring(0, index2) + "q" + currState + resultWord.Substring(index2);

            while (currState != -1)
            {
                i = 0;
                // Ищем неходимую комбинацию символов на двух лентвх.
                while (i < 13 && (sourceWord[index1] != before[0][i] || resultWord[index2] != before[1][i]))
                        i++;

                if (i == 13 || after[currState][i] == "-")
                {
                    MessageBox.Show("В алгоритме присутствует ошибка!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AlgorithmSteps.Rows.Clear();
                    return;
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

                        // Выводим текущее состояние слова в таблицу шагов.
                        AlgorithmSteps.Rows.Add();
                        AlgorithmSteps.Rows[AlgorithmSteps.RowCount - 1].Cells[0].Value =
                            sourceWord.Substring(0, index1) + "q" + (currState == -1 ? "z" : currState.ToString()) + sourceWord.Substring(index1);
                        AlgorithmSteps.Rows[AlgorithmSteps.RowCount - 1].Cells[1].Value =
                            resultWord.Substring(0, index2) + "q" + (currState == -1 ? "z" : currState.ToString()) + resultWord.Substring(index2);
                    }
                }
            }

            // Запись шагов алгоритма в файл.
            try
            {
                FileStream file = new FileStream(Application.StartupPath + "\\" + (SourceWord.Text == "" ? "Пустое слово" : SourceWord.Text) + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(file);
                for (int j = 0; j < AlgorithmSteps.RowCount; j++)
                {
                    streamWriter.WriteLine(AlgorithmSteps.Rows[j].Cells[0].Value);
                    streamWriter.WriteLine(AlgorithmSteps.Rows[j].Cells[1].Value);
                    streamWriter.WriteLine("-----------------------------------");
                }
                streamWriter.Close();
                MessageBox.Show("Шаги алгоритма успешно записаны в файл по следующему пути:\n" + file.Name, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обнаружена ошибка при записи шагов алгоритма в файл!\n" + ex.StackTrace + "\n\nПричина: " + ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimeComplexity_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
