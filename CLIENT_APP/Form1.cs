namespace CLIENT_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> filesText = new();
        List<string> filesNames = new();

        private void SelectFilesBtn_Click(object sender, EventArgs e)
        {
            filesText.Clear();

            OpenFileDialog dlg = new();

            dlg.RestoreDirectory = true;
            dlg.DefaultExt = ".txt";
            dlg.Filter = "текстовые файлы (.txt) |*.txt";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                listBoxFiles.Items.Clear();

                string[] filePath = dlg.FileName.Split(new char[] { '\\' });

                labelPathToFolder.Text = "Путь к папке: "+dlg.FileName.Remove(dlg.FileName.Length - filePath[^1].Length - 1);

                int count = 0;
                int okFiles = 0;

                foreach (string file in dlg.FileNames)
                {
                    string fileText = string.Empty;

                    using (StreamReader reader = new(file))
                    {
                        fileText = reader.ReadToEnd();
                        filesText.Add(fileText);
                    }

                    string[] words = fileText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string[] filesNameArr = file.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                    string fileName = filesNameArr[^1];

                    count++;

                    if (words.Length > 0)
                    {
                        okFiles++;

                        listBoxFiles.Items.Add(fileName);

                        //textBoxForSend.Text += $"Текст файла «{fileName}»:\n" + File.ReadAllText(file) + "\n\n";
                    }
                }
                labelFilesToSend.Text = $"Файлов к отправке: {okFiles}";
                labelCountSelectedFiles.Text = $"Выбрано файлов: {count} | Пустых файлов: {count-okFiles}";

                progressSendFiles.Maximum = okFiles;
            }
        }

        private void SendFilesBtn_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.Items.Count < 1)
            {
                MessageBox.Show("Вы не прикрепили файлы или текст в файле отсутсвует..");
            }
            else
            {
                filesNames.Clear();
                try
                {
                    foreach (var fileName in listBoxFiles.Items)
                    {
                        filesNames.Add(fileName.ToString());
                    }
                    SendFiles.PrepareFiles(filesNames, filesText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
