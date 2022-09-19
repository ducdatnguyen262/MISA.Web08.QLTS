using MISA.Web08.QLTS.API.Enums;

namespace MISA.Web08.QLTS.API.Entities
{
    /// <summary>
    /// Tài sản
    /// </summary>
    public class Asset
    {
        /// <summary>
        /// ID tài sản
        /// </summary>
        public Guid AssetID { get; set; }

        /// <summary>
        /// Mã tài sản
        /// </summary>
        public string AssetCode { get; set; }

        /// <summary>
        /// Tên tài sản
        /// </summary>
        public string AssetName { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// ID phòng ban
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// ID loại tài sản
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Ngày mua
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Giá tiền
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Số lượng
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Tỉ lệ hao mòn (%)
        /// </summary>
        public double DepreciationRate { get; set; }

        /// <summary>
        /// Năm theo dõi
        /// </summary>
        public int TrackedYear { get; set; }

        /// <summary>
        /// Số năm sử dụng
        /// </summary>
        public int LifeTime { get; set; }

        /// <summary>
        /// Năm sử dụng
        /// </summary>
        public DateTime ProductionYear { get; set; }

        public Boolean Active { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa gần nhất
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa gần nhất
        /// </summary>
        public string? ModifiedBy { get; set; }
    }
}
