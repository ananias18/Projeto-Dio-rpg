namespace Projeto_Dio.src.Entities
{
    public class Ninja : Character
    {
        public Ninja(string Name, int Level, string Profession) : base(Name, Level, Profession)
        {

        }

        public override string Attack()
        {
            return this.Name + " Tropeçou mas acertou ";
        }
       public override string Attack(int Bonus)
        {
             

            if (Bonus > 6)
            {
                return this.Name + " Nem viu de onde Veio o ataque com força de " + Bonus;
            }
            else
            {
                return this.Name + " Tropeçou mas acertou ";
            }
        }
    }
}
    

