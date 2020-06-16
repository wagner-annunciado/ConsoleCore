using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public string nome { get; set; }

        public Jogador1(string nome = "Messi")
        {
            this.nome = nome;
        }

        public string Chuta()
        {
            return $"{nome} está Chutando";
        }
        //chuta

        public string Corre()
        {
            return $"{nome} está Correndo";
        }
        //corre
        public string Passe()
        {
            return $"{nome} está Passando";
        }
        //passe

    }
}