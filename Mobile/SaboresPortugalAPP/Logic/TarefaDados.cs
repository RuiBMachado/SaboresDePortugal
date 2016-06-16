using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaboresPortugalAPP.Logic
{
    [Serializable()]
    public class TarefaDados
    {
        public int id { get; set; }
        public String dataInicio { get; set; }
        public String dataFim { get; set; }
        //public Restaurante rest;
        public List<String> relatorio;
        public List<String> imagens; //Link das fotos talvez
        public List<String> voz;
        public String nomeRestaurante;
        public int idRestaurante;
        public float longitude;
        public float latitude;
        public String descricao;
        public String localidade;
        public String rua;
        public String codPostal;
        public int telefone;
        public String email;


        public TarefaDados(int id, String dataI, String dataF, String nome, float longitude, float latitude, String desc,
            String local, String rua, String codP, int tel, String email)
        {
            this.id = id;
            this.dataInicio = dataI;
            this.dataFim = dataF;
            // this.rest = new Restaurante(nome,longitude,latitude,desc,local,rua,codP,tel,email);
            this.relatorio = new List<String>();
            this.imagens = new List<String>();
            this.voz = new List<String>();




        }

        public TarefaDados()
        {
            this.id = 0;
            this.dataInicio = " ";
            this.dataFim = " ";
            // this.rest = new Restaurante();
            this.relatorio = new List<String>();
            this.imagens = new List<String>();
            this.voz = new List<String>();

        }

        public TarefaDados(int id, float longitude, float latitude, string descricao, string localidade, string rua, string codPostal, int telefone, string email, String datai, String dataf)
        {
            this.idRestaurante = id;
            this.longitude = longitude;
            this.latitude = latitude;
            this.descricao = descricao;
            this.localidade = localidade;
            this.rua = rua;
            this.codPostal = codPostal;
            this.telefone = telefone;
            this.email = email;
            this.dataInicio = datai;
            this.dataFim = dataf;

            //this.rest = new Restaurante(nomeRestaurante, longitude, latitude, descricao, localidade, rua, codPostal, telefone, email);
        }

        public List<String> getRelatorio()
        {
            return this.relatorio;
        }

        public void addRelatorio(String r)
        {
            this.relatorio.Add(r);
        }


        public List<String> getImagem()
        {
            return this.imagens;
        }

        public void addImagem(String r)
        {
            this.imagens.Add(r);
        }



        public List<String> getVoz()
        {
            return this.voz;
        }

        public void addVoz(String r)
        {
            this.voz.Add(r);
        }


    }
}
