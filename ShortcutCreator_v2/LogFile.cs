using System;
using System.IO;

namespace ShortcutCreator_v2
{
    public class LogFile
    {
        public string logFileName;

        public LogFile(string logFileName)
        {
            this.logFileName = logFileName;
        }

        /// <summary>
        /// Se il file di log non esiste, lo crea. Altrimenti lo svuota.
        /// </summary>
        public void Create()
        {
            StreamWriter sw = File.CreateText(logFileName);
            sw.Close();
        }

        public void Write(string text)
        {
            StreamWriter sw = File.AppendText(logFileName);
            Log(sw, text);
            sw.Close();
        }

        public void WriteEDT(string text)
        {
            StreamWriter sw = File.AppendText(logFileName);
            sw.WriteLine(text);
            sw.Close();
        }


        #region Funzioni private

        private void Log(StreamWriter sw, string text)
        {
            // Data e ora in testa alla riga
            string sNow = DateTime.Now.ToString() + "    ";
            sw.Write(sNow);

            // Split 
            string[] tokens = text.Split('\n');

            // Se vi sono più righe, costruiamo l'header
            string header = "";
            if (tokens.Length > 1)
            {
                for (int j = 1; j <= sNow.Length; j++)
                    header += " ";
            }

            // Scrittura di ogni riga (la prima dopo data e ora, le successive incolonnate)
            for (int i = 0; i < tokens.Length; i++)
            {
                if (i == 0) sw.WriteLine(tokens[i]);
                else sw.WriteLine(header + tokens[i]);
            }

            // Flush
            sw.Flush();
        }

        #endregion

    }
}
