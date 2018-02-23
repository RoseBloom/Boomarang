namespace Schema
{
    public class Realivies
    {
        public Character Person { get; set; }
        public Relation Relation { get; set; }
    }
    public enum Relation { Mother, Father, Sister, Brother, Son, Daughter }
}