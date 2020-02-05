using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
//using Final_CountDown_component;

namespace Final_CountDown

{
    public partial class Final_Count_Down : Form
    {

        public Final_Count_Down()
        {
            InitializeComponent();
            timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Nenhum método à inserir
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Nenhum método à inserir
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Nenhum método à inserir
        }

        private void Final_Count_Down_Load(object sender, EventArgs e)
        {
            /*FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            string[] files = Directory.GetFiles(fbd.SelectedPath, "*.xls");     
            System.Windows.Forms.MessageBox.Show("Arquivos na Pasta: " + files.Length.ToString(), "Alerta");*/
            labelcount1.Text = Directory.GetFiles(@"C:\HP610_WIFI_Test_SW_Release_V1.0.1.8", "log_WIFI_CC*.txt", SearchOption.AllDirectories).Count().ToString();
        }

        //Aquui está a referência do timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Monitorando alterações com : Final_CountDown");
            string path = @"c:\HP610_WIFI_Test_SW_Release_V1.0.1.8";
            string filtro = "log_WIFI_CC*.txt";
            MonitorarArquivos(path, filtro);
            Console.ReadLine();

            //Aqui cria a pasta e verifica em cada loop se ela existe=========================================================================
            //DateTime fileCreatedDate = File.GetCreationTime(@"C:\HP610_WIFI_Test_SW_Release_V1.0.1.8\");

            //Sample on Sun 01.12.2014 At 09.13 AM
            String Todaysdate = DateTime.Now.ToString("dd-MMMM-yyyy");
            if (!Directory.Exists("C:\\HP610_WIFI_Test_SW_Release_V1.0.1.8\\" + Todaysdate))
            {
                Directory.CreateDirectory("C:\\HP610_WIFI_Test_SW_Release_V1.0.1.8\\" + Todaysdate);
            }
            //=================================================================================================================================

            //Aqui tenho que inserir um método para enviar o arquivo para a pasta do dia==========



            //=====================================================================================


            //Aqui conto de acordo com a palavra "FAIL"============================================
            String varPalavra = "FAIL";

            StreamReader re = File.OpenText("C:\\HP610_WIFI_Test_SW_Release_V1.0.1.8\\log_WIFI_CC859072100516_20200114111510.txt");
            string input = re.ReadToEnd();

            if (input.IndexOf(varPalavra) > -1)
            {
                //Se existir a palavra "PASS", vai contabilizar como PASS
                //MessageBox.Show("Existe a palavra '" + varPalavra + "' no arquivo txt");
                int numero;
                if (int.TryParse(labelcount3.Text, out numero))
                {
                    labelcount3.Text = (numero + 1).ToString();
                }
            }
            else
            {
                //Se não existir a palavra "PASS", vai contabilizar como FAIL
                //MessageBox.Show("Não existe a palavra '" + varPalavra + "' no arquivo txt");
                int numero;
                if (int.TryParse(labelcount2.Text, out numero))
                {
                    labelcount2.Text = (numero + 1).ToString();
                }
            }
            //=======================================================================================

            //Aqui tenho que mover o arquivo txt, recém gerado pa a pasta do dia===================



            //=====================================================================================



        }

        /* Métodos */
        //Contador
        private static FileSystemWatcher _monitorar;
        private static object txtbusca;

        public static void MonitorarArquivos(string path, string filtro)
        {
            _monitorar = new FileSystemWatcher(path, filtro)
            {
                IncludeSubdirectories = true
            };
            _monitorar.Created += OnFileChanged;
            _monitorar.Changed += OnFileChanged;
            _monitorar.Deleted += OnFileChanged;
            _monitorar.Renamed += OnFileRenamed;
            _monitorar.EnableRaisingEvents = true;

            Console.WriteLine($"Monitorando arquivos {filtro} em {path}");
        }
        private static void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"O Arquivo {e.Name} {e.ChangeType}");
        }
        private static void OnFileRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"O Arquivo {e.OldName} {e.ChangeType} para {e.Name}");
        }

        //Aqui vou verificar se o arquivo Texto tem Pass ou Fail no filtro para contar na label

        public void Verifica_pass(string path, string filtro)
        {

        }

        //void ReadFiles(string palavra)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Aqui verifica as informações no arquivo
            String varPalavra = "FAIL";

            StreamReader re = File.OpenText("C:\\HP610_WIFI_Test_SW_Release_V1.0.1.8\\log_WIFI_CC859074701614_20200127082134.txt");
            string input = re.ReadToEnd();

            if (input.IndexOf(varPalavra) > -1)
            {
                //Se existir a palavra "PASS", vai contabilizar como PASS
                //MessageBox.Show("Existe a palavra '" + varPalavra + "' no arquivo txt");
                int numero;
                if (int.TryParse(labelcount3.Text, out numero))
                {
                    labelcount3.Text = (numero + 1).ToString();
                }
            }
            else
            {
                //Se não existir a palavra "PASS", vai contabilizar como FAIL
                //MessageBox.Show("Não existe a palavra '" + varPalavra + "' no arquivo txt");
                int numero;
                if (int.TryParse(labelcount2.Text, out numero))
                {
                    labelcount2.Text = (numero + 1).ToString();
                }
            }
        }
    }
}