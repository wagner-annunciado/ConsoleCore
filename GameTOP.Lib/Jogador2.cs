using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Ronaldo está chutando...";
        }

        public string Corre()
        {
            return "Ronaldo está correndo...";
        }

        public string Passe()
        {
            return "Ronaldo está passando...";
        }
    }
}