using System;
using System.Collections.Generic;

namespace BuilderClassLibrary
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Enemy _enemy = new Enemy();

        public ICharacterBuilder SetHeight(double height)
        {
            _enemy.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            _enemy.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _enemy.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _enemy.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _enemy.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            _enemy.Inventory = inventory;
            return this;
        }

        public ICharacterBuilder AddGoodDeed(string deed)
        {
            throw new InvalidOperationException("This method is not applicable for EnemyBuilder");
        }

        public ICharacterBuilder AddEvilDeed(string deed)
        {
            if (_enemy.EvilDeeds == null)
            {
                _enemy.EvilDeeds = new List<string> { deed };
            }
            else
            {
                _enemy.EvilDeeds.Add(deed);
            }
            return this;
        }

        public ICharacter Build()
        {
            return _enemy;
        }
    }
}
