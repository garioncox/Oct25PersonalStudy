using System.Data;

namespace Oct25PersonalStudy
{
    public class CSVReader
    {
        private string _filename;
        Dictionary<string, List<int>> _data;
        public CSVReader(string path)
        {
            _filename = path;
            _data = new();
        }
        public int GetData(string key)
        {
            _data.TryGetValue(key, out List<int> current);
            return current[current.Count-1];
        }

        public bool ReadData()
        {
            try
            {
                using(StreamReader sr = new(_filename))
                {
                    string[] labels = sr.ReadLine().Split(",");
                    for (int i = 0; i < labels.Length; i++)
                    {
                        _data.Add(labels[i], new List<int>());
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                         
                        for (int i = 0; i < line.Length; i++)
                        {
                            _data.TryGetValue(labels[i], out List<int> current);
                            current.Add(int.Parse(line[i]));
                        }
                    }
                }

                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
        }
    }
}