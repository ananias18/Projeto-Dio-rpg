namespace Projeto_Dio.src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name, int Level, string Profession) : base(Name, Level, Profession)
        {

        }

        public override string Attack()
        {
            return this.Name + " Atacou com fome ";
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Deu uma chapuletada com dano de " + Bonus;
            }
            else
            {
                return this.Name + " Atacou com fome ";
            }
        }
    }
}



