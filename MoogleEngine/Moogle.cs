namespace MoogleEngine;


public static class Moogle
{
    public static/* SearchResult*/ void Query(string query)
    {
        //guardar las direcciones de los documentos. 
        //path.join concatena varios elementos unidos de un (/)
        //directory.getfiles devuelve una cadena con todas las direcciones separados por el .txt.
        string Address = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory())?.FullName, "content");
        string[] Documents_Address = Directory.GetFiles(Address, ".txt*");


        // guardar en un array de string todos los documentos
        string[] Documents = new string[Documents_Address.Length];
        for (int i = 0; i < Documents_Address.Length; i++)
        {
            Documents[i] = File.ReadAllText(Documents_Address[i]);
        }

        // crear un jagged donde cada subarray es un documento 
        string[][] All_Documents = new string[Documents.Length][];
        for (int i = 0; i < Documents.Length; i++)
        {
            All_Documents[i] = Documents[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

        }

        // creo una lista que guarde todas las palabras de los documentos creando asi el Vocabulario.
        List<string> all_documents = new();
        //Metodo que normaliza la lista, quita signos de puntuacion, mayusculas
        // tildes, dejo solo letras y numeros 
        Extras.Extras.Normalize_Text(all_documents);
        //elimino los elementos repetidos de la lista
        all_documents.Distinct();


        //guardamos el query en una lista y lo normalizamos
        List<string> Query = new();
        Extras.Extras.Normalize_Text(Query);

     




        // return new SearchResult(items, query);
    }
}
