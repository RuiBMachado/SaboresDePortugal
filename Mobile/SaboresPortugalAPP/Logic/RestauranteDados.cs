using System;

namespace SaboresPortugalGui.Logic
{
    public class RestauranteDados
    {


        public int id { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public String rua { get; set; }
        public String localidade { get; set; }
        public String codpostal { get; set; }
        public String nome { get; set; }
        public String descricao { get; set; }
        public int telefone { get; set; }
        public String email { get; set; }


        public RestauranteDados() { }
        public RestauranteDados(int id, float latitude, float longitude, String rua, String localidade, String codPostal,
            String nome, String descricao, int telefone, String email)
        {

            this.id = id;
            this.latitude = latitude;
            this.longitude = longitude;
            this.rua = rua;
            this.localidade = localidade;
            this.codpostal = codPostal;
            this.nome = nome;
            this.descricao = descricao;
            this.telefone = telefone;
            this.email = email;

        }

        public RestauranteDados(String nome, float longitude, float latitude, String desc, String local, String rua, String codP, int tel, String email)
        {
            this.nome = nome;
            this.longitude = longitude;
            this.latitude = latitude;
            this.descricao = desc;
            this.localidade = local;
            this.rua = rua;
            this.codpostal = codP;
            this.telefone = tel;
            this.email = email;
        }


    }



}