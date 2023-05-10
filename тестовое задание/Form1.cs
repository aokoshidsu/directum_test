using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.IO;

namespace тестовое_задание
{
    public partial class Form1 : Form
    {
        //Хранит путь до папки, куда нужно генерировать файлы
        string folderPath = String.Empty;
        //Путь до базового файла, откуда берутся слова для генерации
        const string WORDS = "RUS.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            minWordCount.TextChanged += minWordCount_TextChanged;
            maxWordCount.TextChanged += maxWordCount_TextChanged;
        }

        /// <summary>
        /// Нажатие на кнопку "Выбрать папку". Сохраняет путь к выбранной папке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void folderSearcher_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                folderPath = FBD.SelectedPath;
                folderShower.Text = FBD.SelectedPath;
                folderShower.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Минимальное значение поля максимум не превышает заданного минимума.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minWordCount_TextChanged(Object sender, EventArgs e)
        {
            maxWordCount.Minimum = minWordCount.Value;
        }

        /// <summary>
        /// Максимальное значение поля минимум не превышает заданного максимума.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxWordCount_TextChanged(Object sender, EventArgs e)
        {
            minWordCount.Maximum = maxWordCount.Value;
        }

        /// <summary>
        /// Нажатие на кнопку "Сгенерировать". Генерирует текстовые файлы. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_Click(object sender, EventArgs e)
        {
            //Обработки неверно введённых пользователем данных
            if (String.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Выберите папку для создания файлов.");
                return;
            }

            if ((int)cntFiles.Value == 0)
            {
                MessageBox.Show("Кол-во создаваемых файлов не может равняться 0.");
                return;
            }

            //Алгоритм генерации текстовых файлов
            int lineCount = File.ReadLines(WORDS).Count();
            Random rnd = new Random();

            for (int i = 0; i < (int)cntFiles.Value; i++)
            {
                //Создается документ, рандомно определяется кол-во слов в нём
                int wordCount = rnd.Next((int)minWordCount.Value, (int)maxWordCount.Value);
                DocX document = DocX.Create(folderPath + $@"\{i+1}.docx");
                string toInsert = String.Empty;

                //Считываем случайные слова из базового файла, расставляем знаки препинания
                for (int j = 0; j < wordCount; j++)
                {
                    int line = rnd.Next(lineCount);
                    toInsert += File.ReadLines(WORDS, Encoding.GetEncoding(1251)).Skip(line).First();
                    toInsert += getSymbol();
                }

                //Вставляем текст в файл, сохраняем
                document.InsertParagraph(toInsert);
                document.Save();
            }

            MessageBox.Show("Ваши файлы успешно сгенерированы!");
        }

        /// <summary>
        /// Функция возвращает рандомный знак препинания для текста.
        /// </summary>
        /// <returns></returns>
        private string getSymbol()
        {
            // . , ! ? : - ;
            Random rand = new Random();
            int a = rand.Next(50);
            if (a < 15 || a > 29)
                return " ";
            if (a == 29)
                return "; ";
            if (a == 28)
                return " - ";
            if (a == 27)
                return ": ";
            if (a == 26 || a == 25)
                return "? ";
            if (a == 24 || a == 23)
                return "! ";
            if (a < 23 && a > 19)
                return ", ";
            if (a < 20 && a > 14)
                return ". ";
            return String.Empty;
        }

    }
}
