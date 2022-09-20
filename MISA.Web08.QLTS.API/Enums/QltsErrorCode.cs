namespace MISA.Web08.QLTS.API.Enums
{
    /// <summary>
    /// Danh sách mã lỗi khi gọi API
    /// </summary>
    public enum QltsErrorCode
    {
        /// <summary>
        /// Lỗi do exception
        /// </summary>
        Exception = 1,

        /// <summary>
        /// Lỗi do trùng mã
        /// </summary>
        DuplicateCode = 2,

        /// <summary>
        /// Lỗi do nhập thiếu thông tin
        /// </summary>
        EmptyCode = 3,
    }
}
