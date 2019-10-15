using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace NAUTEC_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("boxes.data"))
            {
                string json = reader.ReadToEnd();
                List<Posicao> posicoes = new JavaScriptSerializer().Deserialize<List<Posicao>>(json);

                Dictionary<string, List<Posicao>> pessoa = new Dictionary<string, List<Posicao>>();

                foreach (var item in posicoes)
                {
                    List<Posicao> posicoesPessoa;

                    if (pessoa.TryGetValue(item.person_id, out posicoesPessoa))
                    {
                        posicoesPessoa.Add(item);
                    }
                    else
                    {
                        posicoesPessoa = new List<Posicao>();
                        posicoesPessoa.Add(item);
                        pessoa.Add(item.person_id, posicoesPessoa);
                    }
                }

                List<Pessoa> pessoasAcao = new List<Pessoa>();

                foreach (KeyValuePair<string, List<Posicao>> item in pessoa)
                {
                    Posicao primeiraPosicao = item.Value.First();
                    Posicao ultimaPosicao = item.Value.Last();

                    if (primeiraPosicao.y <= 400 && ultimaPosicao.y <= 400)
                    {
                        Pessoa teste = new Pessoa();
                        teste.id = item.Key;
                        teste.acao = "Passou pela frente da loja";
                        pessoasAcao.Add(teste);
                    }
                    else if (primeiraPosicao.y < ultimaPosicao.y)
                    {
                        Pessoa teste = new Pessoa();
                        teste.id = item.Key;
                        teste.acao = "Entrou na loja";
                        pessoasAcao.Add(teste);
                    }
                    else if (primeiraPosicao.y > ultimaPosicao.y)
                    {
                        Pessoa teste = new Pessoa();
                        teste.id = item.Key;
                        teste.acao = "Saiu da loja";
                        pessoasAcao.Add(teste);
                    }
                }

                var saida = new JavaScriptSerializer().Serialize(pessoasAcao);
                System.IO.File.WriteAllText(@"output.data", saida);
            }
        }

    }
}
