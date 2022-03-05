namespace Projeto_Dio.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string Name, int Level, string Profession) : base(Name, Level, Profession)
        {

        }

        public override string Attack()
        {
            return this.Name + " lançou uma magia com força fraca ";
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " lançou uma magia com força fraca com bônus de ";
            }
        }
    }
}
