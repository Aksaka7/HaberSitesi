namespace Shared.Helpers.Abstract
{
    public interface IRequestService //RestShark ve Newton u yükle mutlaka
    {
        T Get<T>(string url);

        T Post<T>(string url, object model);
    }
}
