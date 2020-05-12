using System.IO
using System.Text

namespace TextEditor.BL
{
	public class FileManager
	{
		private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251); // используем стандартную кодировку windows
+
		public bool IsExist(string filePath) // проверяем наличие файла
		{
			bool isExist = File.Exists(filePath);
			return isExist;
		}

		public string GetContent(string filePath) // если кодировку не указали, то используется по умолчанию 1251
		{
			return GetContent(filePath, _defaultEncoding);
		}

		public string GetContent(string filePath, Encoding encoding) // если указали, то используем ее.у
		{
			string content = File.ReadAllText(filePath, encoding); // через метод ReadAllText, класса File обрабатываем данные 
			return content;
		}

		public void SaveContent(string content, string filePath) // сохраняем файл
		{
			SaveContent(content, filePath, _defaultEncoding)
		}

		public void SaveContent(string content, string filePath, Encoding encoding)
		{
			File.WriteAllText(filePath, content, encoding);
		}

		public int GetSymbolCount(string content) // подсчитываем количество символов
		{
			int count = content.Length;
			return count;
		}
	}
}
