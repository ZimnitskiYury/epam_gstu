namespace task4
{
    /// <summary>
    /// Class for transliteration from cyrillic to latin
    /// </summary>
    public class ClientMessagesHandler
    {
        /// <summary>
        /// Transliterate cylillic to latin
        /// </summary>
        /// <param name="txt">Input string</param>
        /// <returns>Return transliterated string</returns>
        public string Transliteration(string txt)
        {
            var text = txt;
            for(int i=0; i<text.Length;i++)
            {

                switch (text[i])
                {
                    case 'а': text=text.Replace('а', 'a');break;
                    case 'б': text=text.Replace('б', 'b');break;
                    case 'в': text=text.Replace('в', 'v'); break;
                    case 'г': text=text.Replace('г', 'g'); break;
                    case 'д': text=text.Replace('д', 'd'); break;
                    case 'е': text=text.Replace('е', 'e'); break;
                    case 'ё': text=text.Replace('ё', 'e'); break;
                    case 'ж': text=text.Replace("ж", "zh"); break;
                    case 'з': text=text.Replace('з', 'z'); break;
                    case 'и': text = text.Replace('и', 'i'); break;
                    case 'й': text = text.Replace('й', 'i'); break;
                    case 'к': text = text.Replace('к', 'k'); break;
                    case 'л': text = text.Replace('л', 'l'); break;
                    case 'м': text = text.Replace('м', 'm'); break;
                    case 'н': text = text.Replace('н', 'n'); break;
                    case 'о': text = text.Replace('о', 'o'); break;
                    case 'п': text = text.Replace('п', 'p'); break;
                    case 'р': text = text.Replace('р', 'r'); break;
                    case 'с': text = text.Replace('с', 's'); break;
                    case 'т': text = text.Replace('т', 't'); break;
                    case 'ц': text = text.Replace("ц", "ts"); break;
                    case 'ч': text = text.Replace("ч", "ch"); break;
                    case 'ш': text = text.Replace("ш", "sh"); break;
                    case 'щ': text = text.Replace("щ", "shch"); break;
                    case 'ъ': text = text.Replace("ъ", "ie"); break;
                    case 'э': text = text.Replace('э', 'e'); break;
                    case 'ы': text = text.Replace('ы', 'y'); break;
                    case 'у': text = text.Replace('у', 'u'); break;
                    case 'ф': text = text.Replace('ф', 'f'); break;
                    case 'х': text = text.Replace("х", "kh"); break;
                    case 'ю': text = text.Replace("ю", "iu"); break;
                    case 'я': text = text.Replace("я", "ia"); break;
                    case 'А': text = text.Replace('А', 'A'); break;
                    case 'Б': text = text.Replace('Б', 'B'); break;
                    case 'В': text = text.Replace('В', 'V'); break;
                    case 'Г': text = text.Replace('Г', 'G'); break;
                    case 'Д': text = text.Replace('Д', 'D'); break;
                    case 'Е': text = text.Replace('Е', 'E'); break;
                    case 'Ё': text = text.Replace('Ё', 'E'); break;
                    case 'Ж': text = text.Replace("Ж", "Zh"); break;
                    case 'З': text = text.Replace('З', 'Z'); break;
                    case 'И': text = text.Replace('И', 'I'); break;
                    case 'Й': text = text.Replace('Й', 'I'); break;
                    case 'К': text = text.Replace('К', 'K'); break;
                    case 'Л': text = text.Replace('Л', 'L'); break;
                    case 'М': text = text.Replace('М', 'M'); break;
                    case 'Н': text = text.Replace('Н', 'N'); break;
                    case 'О': text = text.Replace('О', 'O'); break;
                    case 'П': text = text.Replace('П', 'P'); break;
                    case 'Р': text = text.Replace('Р', 'R'); break;
                    case 'С': text = text.Replace('С', 'S'); break;
                    case 'Т': text = text.Replace('Т', 'T'); break;
                    case 'Ц': text = text.Replace("Ц", "Ts"); break;
                    case 'Ч': text = text.Replace("Ч", "Ch"); break;
                    case 'Ш': text = text.Replace("Ш", "Sh"); break;
                    case 'Щ': text = text.Replace("Щ", "Shch"); break;
                    case 'Э': text = text.Replace('Э', 'E'); break;
                    case 'У': text = text.Replace('У', 'U'); break;
                    case 'Ф': text = text.Replace('Ф', 'F'); break;
                    case 'Х': text = text.Replace("Х", "Kh"); break;
                    case 'Ю': text = text.Replace("Ю", "Iu"); break;
                    case 'Я': text = text.Replace("Я", "Ia"); break;
                    default:break;
                }
            }
            return text;
        }
    }
}
