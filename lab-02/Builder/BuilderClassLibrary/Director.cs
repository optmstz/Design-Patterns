using System.Collections.Generic;

namespace BuilderClassLibrary
{
    public class Director
    {
        private ICharacterBuilder _builder;

        public Director(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructHero(double height, string build, string hairColor, string eyeColor, string clothing, List<string> inventory, List<string> goodDeeds)
        {
            _builder.SetHeight(height)
                    .SetBuild(build)
                    .SetHairColor(hairColor)
                    .SetEyeColor(eyeColor)
                    .SetClothing(clothing)
                    .SetInventory(inventory);

            foreach (var deed in goodDeeds)
            {
                _builder.AddGoodDeed(deed);
            }
        }

        public void ConstructEnemy(double height, string build, string hairColor, string eyeColor, string clothing, List<string> inventory, List<string> evilDeeds)
        {
            _builder.SetHeight(height)
                    .SetBuild(build)
                    .SetHairColor(hairColor)
                    .SetEyeColor(eyeColor)
                    .SetClothing(clothing)
                    .SetInventory(inventory);

            foreach (var deed in evilDeeds)
            {
                _builder.AddEvilDeed(deed);
            }
        }
    }
}
