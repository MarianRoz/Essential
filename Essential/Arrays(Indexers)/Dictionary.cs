using System;
namespace Essential.ArraysIndexers
{
//    Задание
//Расширьте пример 5 (русско-английский словарь) еще и украинским словарем.
//Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках.

    public class Dictionary
    {
        private string[] ua = new string[5];
        private string[] eng = new string[5];
        private string[] ru = new string[5];

        public Dictionary()
        {
            ua[0] = "книжка"; eng[0] = "book";  ru[0] = "книга";
            ua[1] = "ручка";  eng[1] = "pen";   ru[1] = "ручка"; 
            ua[2] = "сонце";  eng[2] = "sun";   ru[2] = "солнце";
            ua[3] = "яблуко"; eng[3] = "apple"; ru[3] = "яблоко";
            ua[4] = "стіл";   eng[4] = "table"; ru[4] = "стол";  
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < ru.Length; i++)
                {
                    if (eng[i] == index)
                        return eng[i] + " - " + ua[i] + " - " + ru[i];
                    if (ua[i] == index)
                        return ua[i] + " - " + eng[i] + " - " + ru[i];
                    if (ru[i] == index)
                        return ru[i] + " - " + eng[i] + " - " + ua[i];
                }
                return string.Format("{0} - no translation for this word.", index);
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < ua.Length)
                    return ua[index] + " - " + eng[index] + " - " + ru[index];
                else
                    return "Attempt to access outside the array.";
            }
        }
    }
}
