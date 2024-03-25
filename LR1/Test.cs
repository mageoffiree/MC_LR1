using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LR1.Test;

namespace LR1
{
    public partial class Test : Form
    {
        public struct question // заготовка структуры вопроса
        {
            public string val1;

            public question(string _val1)
            {
                val1 = _val1;
            }

        }
        List<question> questions = new List<question>(); // заготовка списка вопросов

        public int res = 0; // переменная для хранения числового результата теста

        public Test()
        {
            InitializeComponent();

            //заполняю список вопросами
            questions.Add(new question("Я подаю милостыню"));
            questions.Add(new question("Помогая кому-то, я не рассчитываю, что и мне помогут, когда я буду в этом нуждаться"));
            questions.Add(new question("Я стараюсь всегда помогать пожилым людям – в транспорте, в магазине, на уличном переходе"));
            questions.Add(new question("Я оказываю помощь даже в тех случаях, когда это может причинить мне какой-либо ущерб"));
            questions.Add(new question("У меня есть знакомые, которых я опекаю, потому что они в житейских делах беспомощны"));
            questions.Add(new question("Если хороший знакомый просит одолжить денег, а у меня их нет, я стараюсь взять в долг у кого-нибудь третьего, чтобы помочь"));
            questions.Add(new question("Я не раздражаюсь, когда ради чужих интересов приходится отодвигать в сторону собственные планы"));
            questions.Add(new question("В ответ на чью-то просьбу я обычно говорю «да», даже не успев толком подумать"));
            questions.Add(new question("Я сильно переживаю, если не удается помочь другу в трудной ситуации"));
            questions.Add(new question("Я не считаю людей, просящих помощи от других, корыстными манипуляторами"));
            questions.Add(new question("Можно поступаться своими целями ради помощи ближнему"));
            questions.Add(new question("У меня приподнятое настроение, когда удается сделать доброе дело"));
            questions.Add(new question("Я бросаю все свои дела, когда человек рядом со мной нуждается в помощи"));
            questions.Add(new question("Бывают бескорыстные волонтеры,которые не ищут выгоды от своих действий"));
            questions.Add(new question("Меня восхищают пожарники, спасатели – все те, кто готов пожертвовать собой ради спасения чужой жизни"));
            questions.Add(new question("Добрые люди – это люди способные помогать и сопереживать"));
            questions.Add(new question("Меня гложет чувство вины, если уклоняюсь от возможности сделать доброе дело"));
            questions.Add(new question("Я никогда не отказываю тем, кто обращается ко мне за помощью"));
            questions.Add(new question("Человек не должен всегда самостоятельно справляться со своими проблемами"));
        }

        public void Test_close(object sender, EventArgs e) // при закрытии закрываю форму
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Начать тестирование")
            {
                button1.Text = "Дать ответ"; // меняю текст на кнопке
                label3.Text = "Мне нравится говорить людям комплименты"; // вывожу первый вопрос
                label5.Text = "19"; // вывожу кол-во оставшихся вопросов 
                // делаю видимыми нужные элемент
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
            }
            else
            {
                // если не выбран вариант ответа, вывожу окно
                if (comboBox1.SelectedIndex != 0 & comboBox1.SelectedIndex != 1 & comboBox1.SelectedIndex != 2 & comboBox1.SelectedIndex != 3 & comboBox1.SelectedIndex != 4)
                {
                    MessageBox.Show("Выберите вариант ответа.");
                }
                else if (questions.Count != 0) // пока не кончились вопросы
                {
                    label3.Text = questions.First().val1; // вывожу вопрос
                    label5.Text = Convert.ToString(questions.Count-1); // вывожу кол-во оставшихся вопросов
                    //изменение результата в зависимости от ответа
                    if (comboBox1.SelectedIndex == 0)
                    {
                        res += 2;
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        res += 1;
                    }
                    // if (comboBox1.SelectedIndex == 2) res остается таким же
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        res -= 1;
                    }
                    else if (comboBox1.SelectedIndex == 4)
                    {
                        res -= 2;
                    }
                    questions.RemoveAt(0); // удаляю уже показанный вопрос из списка
                }
                else // действия при последнем вопросе
                {
                    label3.Text = "Вопросы закончились!";
                    if (comboBox1.SelectedIndex == 0)
                    {
                        res += 2;
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        res += 1;
                    }
                    // if (comboBox1.SelectedIndex == 2) res остается таким же
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        res -= 1;
                    }
                    else if (comboBox1.SelectedIndex == 4)
                    {
                        res -= 2;
                    }
                    button1.Enabled = false;

                    label2.Visible = true; // вывод результата
                    DataBank.res_test = res; // сохраняю для переноса в главную форму
                    if (res > 0)
                    {
                        label2.Text = "Вы - альтруист";
                    }
                    else if (res < 0)
                    {
                        label2.Text = "Вы - эгоист";
                    }
                    else 
                    {
                        label2.Text = "Вы - средничек";
                    }
                }
            }
        }
    }
}
