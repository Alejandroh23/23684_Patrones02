using System;

    public abstract class Caracter
    {
        private WeaponBehaviour weapon;

        public Caracter(WeaponBehaviour weapon)
        {
            this.weapon = weapon;
        }

        public void setWeapon(WeaponBehaviour weapon)
        {
            this.weapon = weapon;
        }

        public void fight()
        {
            Console.Write("Utilizare mi ");
            this.weapon.UseWeapon();
        }
    }