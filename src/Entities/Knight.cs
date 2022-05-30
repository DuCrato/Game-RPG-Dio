namespace game_RPG_DIO.src.Entities
{
    public class Knight: Hero
    {
        public Knight(string Name, int Level, string heroType) : base(Name, Level, heroType)
        {
           this.Name     = Name;
           this.Level    = Level;
           this.heroType = heroType;
        }
    }
}