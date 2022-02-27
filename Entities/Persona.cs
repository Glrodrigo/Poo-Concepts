namespace Dotnet.Entities
{
    public class Persona
    {
        public Persona(string name, string herotype, int level)
        {
            this.name = name;
            this.herotype = herotype;
            this.level = level;
        }

        public string name;
        public string herotype;
        public int level;

        public override string ToString(){
            return this.name + " level " + this.level;
        }

        public string Attack(){
            return this.name + " atacou com sua espada";
        }
    }
}