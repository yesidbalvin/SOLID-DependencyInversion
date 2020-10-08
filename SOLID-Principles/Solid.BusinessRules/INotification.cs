namespace Solid.BusinessRules
{
    public interface INotification
    {
        bool NotifyCreationByEmail(string emailAddress);
    }
}
