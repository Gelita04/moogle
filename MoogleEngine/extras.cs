
namespace Extras;
public static class Extras
{
    //metodo que normaliza los textos quitando mayusculas(ToLower),
    // signos de puntuacion()
    public static void Normalize_Text(List<string> example)
    {
        foreach (string item in example)
        {
            //para eliminar las mayusculas
            item.ToLower().ToList();
            //para eliminar las tildes, formD(separar los caracteres con tildes y mantener los caracteres bases)
            item.Normalize(System.Text.NormalizationForm.FormD);
            //para eliminar las comas y los puntos(. , : ;)
            item.Replace(",", " ");
            item.Replace(".", " ");
            item.Replace(";", " ");
            item.Replace(":", " ");
            //dejo solamente leyras y numeros en la lista
            foreach (char index in item)
            {
                if (!Char.IsLetterOrDigit(index))
                {
                    item.Replace("index", " ");
                }
            }
        }

    }

    //metodo que me devuelve la cantidad de dodcumentos
    public static int Count_Of_Documents(List<List<string>> example)
    {
        int count = example.Count;
        return count;
    }
    //metodo booleano que me confirme si la palabra esta en el documento
    public static void Word_in_the_Document(string example)
    {

    }

    //metodo que analiza la cantidad de veces que se repite
    // una palabra en un documento(TF)
    public static void/* double[][]*/ Term_Frequency(string[][] documents, List<string> Vocabulary)
    {
        double[][] Matrix_TF = new double[documents.Length][];
        double count = 0;
        for (int i = 0; i < documents.Length; i++)
        {
            for (int j = 0; j < Vocabulary.Count; j++)
            {
                if (j == Vocabulary.Count)
                {
                    Matrix_TF[i][j] = count;
                }
                if (documents[i][j] == Vocabulary[j])
                {
                    count++;

                }

            }
        }
    }

    //calcula el idf de los documento
    public static /*double[][]*/  void Inverse_Document_Frencuency(string[] documents, List<string> vocabulary)
    {
    }
}






