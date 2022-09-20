using MISA.Web08.QLTS.API.Enums;

namespace MISA.Web08.QLTS.API.Entities.DTO
{
    public class ErrorResult
    {
        #region Property

        public QltsErrorCode ErrorCode { get; set; }

        public string DevMsg { get; set; }

        public string UserMsg { get; set; }

        public string MoreInfo { get; set; }

        public string TraceId { get; set; }

        #endregion

        #region Constructor

        public ErrorResult() { }

        public ErrorResult(QltsErrorCode errorCode, string devMsg, string userMsg, string moreInfo, string traceId)
        {
            ErrorCode = errorCode;
            DevMsg = devMsg;
            UserMsg = userMsg;
            MoreInfo = moreInfo;
            TraceId = traceId;
        }

        #endregion
    }
}
