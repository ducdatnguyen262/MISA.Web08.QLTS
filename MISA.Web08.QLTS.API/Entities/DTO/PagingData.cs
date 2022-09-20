namespace MISA.Web08.QLTS.API.Entities.DTO
{
    public class PagingData
    {
        /// <summary>
        /// Danh sách các bản ghi hiển thị
        /// </summary>
        public List<Asset> Data { get; set; }

        /// <summary>
        /// Tổng số bản ghi hiển thị
        /// </summary>
        public int TotalCount { get; set; }
    }
}
