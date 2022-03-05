namespace Projeto_Dio.src.Entities
{
    public class BlackWizard : Character
    {
        public BlackWizard(string Name, int Level, string Profession) : base(Name, Level, Profession)
        {

        }

        public override string Attack()
        {
            return this.Name + " lançou uma magia fraca ";
        }
        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou uma magia capirotesca " + Bonus;
            }
            else
            {
                return this.Name + " lançou uma magia fraca " ;
            }
        }   
        
    }
}

