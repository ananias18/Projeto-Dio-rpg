namespace Projeto_Dio.src.Entities
{
    public abstract class Character
    {
        public Character(string Name, int Level, string Profession)
        {
            this.Name = Name;
            this.Level = Level;
            this.Profession = Profession;
          
            

        }

        //Atributos
        public string Name;
        public int Level;
        public string Profession;
      
      




        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Profession ;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou ";
        }

        public virtual string Attack(int Bonus)
        {
            return this.Name + "  " + Bonus;
        }

    }
}

