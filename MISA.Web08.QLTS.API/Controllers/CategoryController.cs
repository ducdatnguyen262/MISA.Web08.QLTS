using MISA.Web08.QLTS.API.Enums;
using MISA.Web08.QLTS.API.Properties;
using Microsoft.AspNetCore.Mvc;
using MISA.Web08.QLTS.API.Entities.DTO;
using MISA.Web08.QLTS.API.Entities;
using MySqlConnector;
using Dapper;

namespace MISA.Web08.QLTS.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategorysController : ControllerBase
    {
        /// <summary>
        /// Lấy danh sách toàn bộ loại tài sản
        /// </summary>
        /// <returns>Danh sách toàn bộ loại tài sản</returns>
        /// Cretaed by: NDDAT (28/09/2022)
        [HttpGet]
        [Route("")]
        public IActionResult GetAllCategorys()
        {
            try
            {
                // Khởi tạo kết nối tới DB MySQL
                string connectionString = "Server=localhost;Port=3306;Database=misa.web08.hcsn.nddat;Uid=root;Pwd=;";
                var mysqlConnection = new MySqlConnection(connectionString);

                // Khai báo tên stored procedure
                string storedProcedureName = "Proc_category_GetAll";

                // Thực hiện gọi vào DB
                var categories = mysqlConnection.Query<Category>(
                    storedProcedureName,
                    commandType: System.Data.CommandType.StoredProcedure);

                // Xử lý dữ liệu trả về
                if (categories != null)
                {
                    return StatusCode(StatusCodes.Status200OK, categories);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new ErrorResult(
                        QltsErrorCode.SelectFailed,
                        Resource.DevMsg_SelectFailed,
                        Resource.UserMsg_SelectFailed,
                        Resource.MoreInfo_SelectFailed,
                        HttpContext.TraceIdentifier));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResult(
                    QltsErrorCode.Exception,
                    Resource.DevMsg_Exception,
                    Resource.UserMsg_Exception,
                    Resource.MoreInfo_Exception,
                    HttpContext.TraceIdentifier));
            }
        }
    }
}
