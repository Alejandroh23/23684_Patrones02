using System;

namespace Patrones01
{
    public class main
    {
        public static void Main(string[] args)
        {
            King rey = new King(new SwordBehavior());
            king.fight();

            Troll troll = new Troll(new CrossbowBehavior());
            troll.fight();

            Knight caballero = new Knight(new AxeBehavior());
            knight.fight();

            Queen reina = new Queen(new KnifeBehavior());
            queen.fight();

        }
    }