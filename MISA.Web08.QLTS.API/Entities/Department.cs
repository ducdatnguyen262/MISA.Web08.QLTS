namespace MISA.Web08.QLTS.API.Entities
{
    /// <summary>
    /// Phòng ban
    /// </summary>
    public class Department
    {
        /// <summary>
        /// ID phòng ban
        /// </summary>
        public Guid department_id { get; set; }

        /// <summary>
        /// Mã phòng ban
        /// </summary>
        public string department_code { get; set; }

        /// <summary>
        /// Tên phòng ban
        /// </summary>
        public string department_name { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Có phải lớp cha không
        /// </summary>
        public string is_parent { get; set; }

        /// <summary>
        /// ID phòng ban cha
        /// </summary>
        public string parent_id { get; set; }

        /// <summary>
        /// ID đơn vị
        /// </summary>
        public string organization_id { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public string created_by { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime created_date { get; set; }

        /// <summary>
        /// Người sửa
        /// </summary>
        public string modified_by { get; set; }

        /// <summary>
        /// Ngày sửa
        /// </summary>
        public DateTime modified_date { get; set; }
    }
}
