namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Knight();
            Player player2 = new Archer();
            Monster monster = new Orc();

            int damage = player.GetAttack();
            player2.OnDamaged(damage);
        }
    }
}