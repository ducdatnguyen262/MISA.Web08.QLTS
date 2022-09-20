using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MISA.Web08.QLTS.API.Entities;
using MISA.Web08.QLTS.API.Entities.DTO;
using MISA.Web08.QLTS.API.Enums;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace MISA.Web08.QLTS.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        #region API Get

        /// <summary>
        /// Lấy danh sách toàn bộ tài sản
        /// </summary>
        /// <returns>Danh sách toàn bộ tài sản</returns>
        /// Cretaed by: NDDAT (19/09/2022)
        [HttpGet]
        [Route("")]
        public List<Asset> GetAllAssets()
        {
            return new List<Asset>
            {
                new Asset
                {
                    AssetID = Guid.NewGuid(),
                    AssetCode = "TS00001",
                    AssetName = "Laptop ASUS FX504",
                    Gender = Gender.Male,
                },
                new Asset
                {
                    AssetID = Guid.NewGuid(),
                    AssetCode = "TS00002",
                    AssetName = "Xe máy Honda",
                    Gender = Gender.Female,
                }
            };
        }

        /// <summary>
        /// Lấy 1 tài sản theo id
        /// </summary>
        /// <param name="assetId">ID của tài sản vừa lấy</param>
        /// <returns>Đối tượng tài sản có ID được truyền vào</returns>
        /// Created by: NDDAT (19/09/2022)
        [HttpGet("{assetId}")]
        public Asset GetAssetById([FromRoute] Guid assetId)
        {
            return new Asset
            {
                AssetID = assetId,
                AssetCode = "TS00001",
                AssetName = "Laptop ASUS FX504",
                Gender = Gender.Male,
            };
        }

        /// <summary>
        /// Lấy danh sách các tài sản có chọn lọc
        /// </summary>
        /// <param name="keyword">Từ để tìm kiếm theo mã và tên tài sản</param>
        /// <param name="departmentId">ID phòng ban</param>
        /// <param name="categoryId">ID loại tài sản</param>
        /// <param name="limit">Số bản ghi muốn lấy</param>
        /// <param name="offset">Thứ tự bản ghi bắt đầu lấy</param>
        /// <returns>Danh sách các tài sản sau khi chọn lọc</returns>
        /// Created by: NDDAT (19/09/2022)
        [HttpGet("filter")]
        public PagingData FilterAssets([FromQuery] string keyword, [FromQuery] Guid departmentId, [FromQuery] Guid categoryId, [FromQuery] int limit, [FromQuery] int offset)
        {
            return new PagingData
            {
                Data = new List<Asset>
                {
                    new Asset
                    {
                        AssetID = Guid.NewGuid(),
                        AssetCode = "TS00001",
                        AssetName = "Laptop ASUS FX504",
                        Gender = Gender.Male,
                    }
                },
                TotalCount = 2
            };
        }

        #endregion

        #region API Add

        /// <summary>
        /// Thêm mới 1 tài sản
        /// </summary>
        /// <param name="asset">Đối tượng tài sản cần thêm mới</param>
        /// <returns>ID tài sản vừa thêm mới</returns>
        /// Cretaed by: NDDAT (19/09/2022)
        [HttpPost]
        public IActionResult InsertAsset([FromBody] Asset asset)
        {
            //return StatusCode(StatusCodes.Status201Created, Guid.NewGuid());

            return StatusCode(StatusCodes.Status400BadRequest, new ErrorResult(
                QltsErrorCode.Exception,
                "It was not possible to connect to the redis server(s)",
                "Có lỗi xảy ra! Vui lòng liên hệ với MISA.",
                "https://openapi.misa.com.vn/errorcode/e001",
                HttpContext.TraceIdentifier));
        }

        #endregion

        #region API Update

        /// <summary>
        /// Cập nhật 1 tài sản
        /// </summary>
        /// <param name="assetId">ID tài sản cần cập nhật</param>
        /// <param name="asset">Đối tượng tài sản cần cập nhật theo</param>
        /// <returns>Đối tượng tài sản sau khi cập nhật</returns>
        /// Cretaed by: NDDAT (19/09/2022)
        [HttpPut("{assetId}")]
        public IActionResult UpdateAsset([FromRoute] Guid assetId, [FromBody] Asset asset)
        {
            return StatusCode(StatusCodes.Status200OK, assetId);
        }

        #endregion

        #region API Delete

        /// <summary>
        /// Xóa 1 tài sản
        /// </summary>
        /// <param name="assetId">ID tài sản cần xóa</param>
        /// <returns>ID tài sản vừa xóa</returns>
        /// Cretaed by: NDDAT (19/09/2022)
        [HttpDelete("{assetId}")]
        public IActionResult DeleteAsset([FromRoute] Guid assetId)
        {
            return StatusCode(StatusCodes.Status200OK, assetId);
        }

        /// <summary>
        /// Xóa nhiều tài sản
        /// </summary>
        /// <param name="assetIds">Danh sách ID các tài sản cần xóa</param>
        /// <returns></returns>
        /// Cretaed by: NDDAT (19/09/2022)
        [HttpPost("batch-delete")]
        public IActionResult DeleteMultiAssets([FromBody] List<string> assetIds)
        {
            return StatusCode(StatusCodes.Status200OK);
        }
        
        #endregion
    }
}