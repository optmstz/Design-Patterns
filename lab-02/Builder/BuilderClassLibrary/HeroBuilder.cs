using BuilderClassLibrary;

public class HeroBuilder : ICharacterBuilder
{
    private Hero _hero = new Hero();

    public ICharacterBuilder SetHeight(double height)
    {
        _hero.Height = height;
        return this;
    }

    public ICharacterBuilder SetBuild(string build)
    {
        _hero.Build = build;
        return this;
    }

    public ICharacterBuilder SetHairColor(string hairColor)
    {
        _hero.HairColor = hairColor;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string eyeColor)
    {
        _hero.EyeColor = eyeColor;
        return this;
    }

    public ICharacterBuilder SetClothing(string clothing)
    {
        _hero.Clothing = clothing;
        return this;
    }

    public ICharacterBuilder SetInventory(List<string> inventory)
    {
        _hero.Inventory = inventory.ToList();
        return this;
    }

    public ICharacterBuilder AddGoodDeed(string deed)
    {
        _hero.GoodDeeds.Add(deed);
        return this;
    }

    public ICharacterBuilder AddEvilDeed(string deed)
    {
        throw new InvalidOperationException("This method is not applicable for HeroBuilder");
    }

    public ICharacter Build()
    {
        return _hero;
    }
}