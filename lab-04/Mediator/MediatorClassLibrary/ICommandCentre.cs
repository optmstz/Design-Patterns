namespace MediatorClassLibrary
{
    public interface ICommandCentre
    {
        void Notify(object sender, string ev);
    }
}
