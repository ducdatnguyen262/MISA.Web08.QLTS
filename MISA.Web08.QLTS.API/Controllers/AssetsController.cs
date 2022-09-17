using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MISA.Web08.QLTS.API.Entities;
using MISA.Web08.QLTS.API.Entities.DTO;
using MISA.Web08.QLTS.API.Enums;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace MISA.Web08.QLTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        /// <summary>
        /// Lấy danh sách toàn bộ tài sản
        /// </summary>
        /// <returns></returns>
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
        /// <param name="assetId"></param>
        /// <returns></returns>
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
        /// <param name="keyword"></param>
        /// <param name="departmentId"></param>
        /// <param name="categoryId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Thêm 1 tài sản
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult InsertAsset([FromBody] Asset asset)
        {
            return StatusCode(StatusCodes.Status201Created, Guid.NewGuid());
        }

        /// <summary>
        /// Cập nhật 1 tài sản
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="asset"></param>
        /// <returns></returns>
        [HttpPut("{assetId}")]
        public IActionResult UpdateAsset([FromRoute] Guid assetId, [FromBody] Asset asset)
        {
            return StatusCode(StatusCodes.Status200OK, assetId);
        }

        /// <summary>
        /// Xóa 1 tài sản
        /// </summary>
        /// <param name="assetId"></param>
        /// <returns></returns>
        [HttpDelete("{assetId}")]
        public IActionResult DeleteAsset([FromRoute] Guid assetId)
        {
            return StatusCode(StatusCodes.Status200OK, assetId);
        }

        /// <summary>
        /// Xóa nhiều tài sản
        /// </summary>
        /// <param name="assetIds"></param>
        /// <returns></returns>
        [HttpPost("batch-delete")]
        public IActionResult DeleteMultiAssets([FromBody] List<string> assetIds)
        {
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
