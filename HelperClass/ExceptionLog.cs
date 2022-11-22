using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalTest.HelperClass
{
    public static class ExceptionLog
    {
        static FileStream fs;
        static StreamWriter m_streamWriter;
        public static void LogError(string message, DateTime time)
        {
            string fileName = string.Empty;
            fileName = AppDomain.CurrentDomain.BaseDirectory + "\\TechnicalTest.ERROR";
            fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            try
            {
                m_streamWriter.WriteLine(time.ToShortDateString().ToString() + " " + time.ToShortTimeString().ToString() + " " + message);
                m_streamWriter.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
                m_streamWriter.Flush();
            }
            catch (Exception)
            {
            }
            finally
            {
                if (m_streamWriter != null)
                {
                    m_streamWriter.Close();
                    m_streamWriter = null;
                }
            }
        }
    }
}