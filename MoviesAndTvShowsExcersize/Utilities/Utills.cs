using System.IO;

namespace MoviesAndTvShowsExcersize.Utilities
{
    public static class Utills
    {
        static object readRepoLocker = new object();
        static object writeLogLocker = new object();

        public static object ReadStream(string path)
        {
            string jsonString = string.Empty;

            lock (readRepoLocker)
            {
                using (StreamReader r = new StreamReader(Config.JsonRepoDir))
                {
                    jsonString = r.ReadToEndAsync().Result;
                }
            }

            return jsonString;
        }

        public static void WriteStream(string path, string exMsg)
        {
            lock (writeLogLocker)
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(exMsg);
                    }

                    return;
                }

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLineAsync(exMsg);
                }
            }
        }
    }
}