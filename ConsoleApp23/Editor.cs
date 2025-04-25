using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Editor

    {

        public List<DocumentoFoto> versiones { get; set; } = new List<DocumentoFoto>();
        public int Posicion;


        // salvar una version de mi documento con todos sus parrafos
        public void SalvarVersionDocumento(Documento documento)
        {
            DocumentoFoto documentoFoto = new DocumentoFoto();

            Console.WriteLine(documento.Parrafos.Count);

            documentoFoto.Parrafos = documento.Parrafos;
            versiones.Add(documentoFoto);

        }
        public Documento ObtenerVersion(int version)
        {

            Documento documento = new Documento();

            documento.Parrafos = versiones[version].Parrafos;
            Console.WriteLine(versiones[0]);

            return documento;
        }
    }


}
