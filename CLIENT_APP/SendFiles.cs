using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Sockets;

namespace CLIENT_APP
{
    public class SendFiles
    {
        const int port = 5500;
        const string address = "127.0.0.1";

        public static void PrepareFiles(List<string> filesNames, List<string> filesText)
        {
            Enumerable.Range(0, filesNames.Count).AsParallel().ForAll(x =>
            {
                SendFilesAsync(filesNames[x], filesText[x]);
            });
        }

        private static void SendFilesAsync(string fileName, string fileText)
        {
            TcpClient? client = null;

            try
            {
                client = new TcpClient(address, port);
                NetworkStream stream = client.GetStream();

                string answer = string.Empty;

                while (true)
                {
                    string message = fileText;
                    byte[] data = Encoding.Unicode.GetBytes(message);

                    stream.Write(data, 0, data.Length);

                    data = new byte[64];
                    StringBuilder builder = new();
                    int bytes = 0;

                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    answer = $"Текст файла {fileName}" + builder.ToString();

                    break;
                }
                MessageBox.Show(answer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client!.Close();
            }
        }
    }
}
