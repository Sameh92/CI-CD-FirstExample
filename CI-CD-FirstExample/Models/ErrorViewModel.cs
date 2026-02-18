namespace CI_CD_FirstExample.Models
{
    public class ErrorViewModel
    {

        public ErrorViewModel()
        {
        }
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
