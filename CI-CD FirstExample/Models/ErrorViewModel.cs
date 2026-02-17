namespace CI_CD_FirstExample.Models
{
    public class 1ErrorViewModel
    {

        public ErrorViewModel()
    {
    }
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
}
