using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using xNet;


namespace VkAPITutorial
{
    public partial class MainForm : Form
    {
        VkAPI _ApiRequest;
        private string _Token;  //Токен, использующийся при запросах
        private string _UserId;  //ID пользователя
        private dynamic _Response;  //Ответ на запросы
        private dynamic _Response2;//Ответ на запросы
        private dynamic _Response3;//Ответ на запросы
        public string ID; //ID пользователя

        bool Prof(string first_name, string last_name, string bdat)//Функция выполняющаяя проверку человека из списка друзей в черном списке
        {
            if (dataGridView1 != null)//проверка что список друзей не пуст
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)//цикл прогона человека через весь черный список
                {
                   if (dataGridView1.Rows[i].Cells[1].Value != null)//если строка не пуста
                    {

                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(last_name)//если совпадает фамилия 
                        || dataGridView1.Rows[i].Cells[4].Value.ToString().Equals(last_name))
                        {
                            if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(first_name)//если совпадает имя
                            || dataGridView1.Rows[i].Cells[5].Value.ToString().Equals(first_name))
                            {
                                if(bdat==null)//если дата рожения закрыта
                                { return true; }//возвращаем истину
                                else if (dataGridView1.Rows[i].Cells[7].Value.ToString().Equals(bdat))//если совпадает дата рождения
                                { return true; }//возвращаем истину

                            }

                        }

                    }

                }

            }
            return false;//если совпадения не найдены, возвращаем ложь

        }
        public MainForm(string ID2)
        {
            ID = ID2;
            InitializeComponent();
        }

        private void Button_GetToken_Click_1(object sender, EventArgs e)//обработчик нажатия кнопки: получить токен
        {
            AuthorizationForm GetToken = new AuthorizationForm();//инициализируем новую форму
            GetToken.ShowDialog();//показываем эту форму для получения токена
        }

        private void MainForm_Load(object sender, EventArgs e)//обрботчик загрузки формы
        {
            if (ID!="")//если ID пользователя был введен на главной странице, то обработка пользователя происходит при загрузке формы
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных1DataSet.__Террористы_". При необходимости она может быть перемещена или удалена.
                this._Террористы_TableAdapter.Fill(this.база_данных1DataSet.@__Террористы_);
                string first_name; string last_name; string bdat;//объявление переменных
                User_ID.Text = ID;//присваиваем ID пользователя внутренней переменной
                StreamReader ControlInf = new StreamReader("UserInf.txt");//создаем переменную чтения файла с токеном
                _Token = ControlInf.ReadLine();//присваиваем значение токена переменной
                ControlInf.Close();//закрываем файл
                _ApiRequest = new VkAPI(_Token);//активируем API с помощью токена
                _UserId = User_ID.Text;//присваиваем значение
                string[] Params = { "city", "country", "photo_max" };//записываем в переменную параметры, которые нам нужны
                _Response = _ApiRequest.GetInformation(_UserId, Params);//заносим всю информацию о пользователе в масив
                if (_Response != null)//если массив не пуст
                {
                    User_ID.Text = _UserId;
                    User_Photo.ImageLocation = _Response["photo_max"];//грузим его фотографию
                    User_Name.Text = _Response["first_name"];//записываем фамилию
                    User_Surname.Text = _Response["last_name"];//записываем имя
                    User_Country.Text = _Response["country"]["title"];//записываем странну
                    User_City.Text = _Response["city"]["title"];//записываем город
                    Button_GetToken.Visible = false;//кнопку получить токен делаем невидимой
                }

                _ApiRequest = new VkAPI(_Token);//инициализируем новую переменную API 
                _UserId = User_ID.Text;
                _Response2 = _ApiRequest.GetFriends(_UserId);//Записывае в массив список друзей
                _Response3 = _ApiRequest.GetNumberFriends(_UserId);//записываем в массив номера друзей
                File.WriteAllText("UserInf2.txt", _Response2 + "\n");//записываем данный в файл
                int p = Convert.ToInt32(_Response3["count"]);//в переменную записываем количество друзей
                label1.Text = Convert.ToString(p);//выводим число друзей на монитор
                File.WriteAllText("UserInf3.txt", "");//в отдельный файл очищаем от данных
                for (int i = 0; i < p; i++)//цикл для обработки всего списка друзей
                {
                    first_name = _Response2[i]["first_name"];//записываем фамилию i-ого друга
                    last_name = _Response2[i]["last_name"];////записываем имя i-ого друга
                    bdat = _Response2[i]["bdate"];//записываем дату рождения i-ого друга
                    first_name = first_name.ToUpper();//переводим все в верхний регистр
                    last_name = last_name.ToUpper();
                    File.AppendAllText("UserInf3.txt", i + 1 + " " + _Response2[i]["first_name"]);//записываем друзей в подготовленный файл
                    File.AppendAllText("UserInf3.txt", "  " + _Response2[i]["last_name"] + "\n");
                    listBox1.Items.Add(Convert.ToString(i + 1) + " " + _Response2[i]["first_name"] + " " + _Response2[i]["last_name"]);//всех друзей записываем в список на экране
                    if (Prof(first_name, last_name,bdat))//вызываем функцию провкруи на совпадения в черном списке
                    {
                        listBox2.Items.Add(Convert.ToString(i + 1) + " " + _Response2[i]["first_name"] + " " + _Response2[i]["last_name"]);//при совпадении записываем в отдельный список человека
                    }
                }
            }
        }
//
        private void Button_GetInformation_Click_1(object sender, EventArgs e)//если на главной странице не вписан ID то можно вписать его на странице проверки и выполнить проверку с помощью нажатия кнопки: проверка информации
        {
            string first_name; string last_name; string bdat;//схему работы обработки прописана в предыдущем обработчике
            StreamReader ControlInf = new StreamReader("UserInf.txt");
            _Token = ControlInf.ReadLine();
            ControlInf.Close();
            _ApiRequest = new VkAPI(_Token);
            _UserId = User_ID.Text;
            string[] Params = { "city", "country", "photo_max" };
            _Response = _ApiRequest.GetInformation(_UserId, Params);
            if (_Response != null)
            {
                User_ID.Text = _UserId;
                User_Photo.ImageLocation = _Response["photo_max"];
                User_Name.Text = _Response["first_name"];
                User_Surname.Text = _Response["last_name"];
                User_Country.Text = _Response["country"]["title"];
                User_City.Text = _Response["city"]["title"];
                Button_GetToken.Visible = false;
            }

            _ApiRequest = new VkAPI(_Token);
            _UserId = User_ID.Text;
            _Response2 = _ApiRequest.GetFriends(_UserId);
            _Response3 = _ApiRequest.GetNumberFriends(_UserId);
            File.WriteAllText("UserInf2.txt", _Response2 + "\n");
            int p = Convert.ToInt32(_Response3["count"]);
            label1.Text = Convert.ToString(p);
            File.WriteAllText("UserInf3.txt", "");
            for (int i = 0; i < p; i++)
            {
                first_name = _Response2[i]["first_name"];
                last_name = _Response2[i]["last_name"];
                bdat = _Response2[i]["bdate"];
                first_name = first_name.ToUpper();
                last_name = last_name.ToUpper();
                File.AppendAllText("UserInf3.txt", i + 1 + " " + _Response2[i]["first_name"]);
                File.AppendAllText("UserInf3.txt", "  " + _Response2[i]["last_name"] + "\n");
                listBox1.Items.Add(Convert.ToString(i + 1) + " " + _Response2[i]["first_name"] + " " + _Response2[i]["last_name"]);
                if (Prof(first_name, last_name,bdat))
                {
                    listBox2.Items.Add(Convert.ToString(i + 1) + " " + _Response2[i]["first_name"] + " " + _Response2[i]["last_name"]);
                }
            }
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void проверкаЧерезЧерныйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Proverka = new Form3("","", "", "");
            Proverka.ShowDialog();
        }
    }
}